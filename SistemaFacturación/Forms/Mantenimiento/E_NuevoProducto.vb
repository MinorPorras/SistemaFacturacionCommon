Imports System.Data.SQLite
Imports System.Globalization
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Busqueda
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Namespace SistemaFacturacion.Forms.Mantenimiento

    Public Class E_NuevoProducto
        Friend idProd As String
        Friend ModProd As Boolean = False
        Friend CodigoPreMod As String
        Friend precioBase As Double
        Friend impuesto As Double
        Friend ganancia As Double
        Friend precioVenta As Double
        Friend Inicializando As Boolean = True
        Dim actpVenta As Boolean = False
        Dim actGan = False
        Private Correcto As Boolean

        Private Sub BTN_RegresarProv_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProv.Click
            ModProd = False
            Me.DialogResult = DialogResult.Cancel
        End Sub

        Private Sub E_NuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            If ModProd = False Then
                idProd = OBTENERPK("producto", "ID")
            End If
            PRG_Guardando.Visible = False
        End Sub

        Private Function VALIDAR()
            ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
            If TXT_Cod.Text <> "" And TXT_Nombre.Text <> "" And TXT_PrecioVenta.Text <> "" Then
                BTN_NProv.Enabled = True
                Return True
            Else
                BTN_NProv.Enabled = False
                Return False
            End If

        End Function

        Private Sub TXT_Marca_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Marca.MouseDoubleClick
            Dim frmSearchMarca As New B_Marca With {.Owner = Me}
            frmSearchMarca.ShowDialog()
        End Sub

        Private Sub TXT_Proveedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Proveedor.MouseDoubleClick
            Dim frmSearchProv As New B_Proveedor With {.Owner = Me}
            frmSearchProv.ShowDialog()
        End Sub

        Private Sub TXT_Categoria_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Categoria.MouseDoubleClick
            Dim frmSearchCategoria As New B_Categoria With {.Owner = Me}
            frmSearchCategoria.ShowDialog()
        End Sub

        Private Sub TXT_Impuesto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Impuesto.MouseDoubleClick
            B_Impuesto.caso = "NProd"
            B_Impuesto.Show()
            B_Impuesto.Select()
        End Sub

        Private Sub BTN_NProv_Click(sender As Object, e As EventArgs) Handles BTN_NProv.Click
            If Not VALIDAR() Then Return

            PRG_Guardando.Visible = True
            PRG_Guardando.Start()

            Try
                Dim codigo As String = TXT_Cod.Text
                Dim correcto As Boolean = False
                If ModProd = False Then
                    correcto = Not EXISTECOD("producto", "codigo", codigo)
                Else
                    correcto = (codigo = CodigoPreMod OrElse Not EXISTECOD("producto", "codigo", codigo))
                End If

                If Not correcto Then
                    msgError("El código " & TXT_Cod.Text & " ya existe, coloque un código distinto")
                    TXT_Cod.SelectAll()
                    Return
                End If

                If msgGuardar() Then
                    ' Se define un delegado que contiene todas las operaciones
                    Dim operacionesDeGuardado As Action(Of SQLiteConnection, SQLiteTransaction) =
                    Sub(conn, transaction)
                        CrearOActualizarProducto(conn, transaction)
                        CrearOActualizarPrecioVenta(conn, transaction)
                        CrearOActualizarDescripcion(conn, transaction)
                        CrearOActualizarCategoria(conn, transaction)
                        CrearOActualizarMarca(conn, transaction)
                        CrearOActualizarProveedor(conn, transaction)
                    End Sub

                    ' Se llama al método para ejecutar la transacción de forma segura
                    If EJECUTAR_TRANSACCION(operacionesDeGuardado) Then
                        LIMPIAR()
                        MsgDatoAlm()
                        ModProd = False
                        isNavigating = True
                        Me.DialogResult = DialogResult.OK
                    Else
                        msgError("Ocurrió un error al guardar los datos. La operación fue revertida.")
                    End If
                End If
            Catch ex As Exception
                msgError("Error: " & ex.Message)
            Finally
                PRG_Guardando.Stop()
                PRG_Guardando.Visible = False
            End Try
        End Sub

#Region "Creación y actualización de datos en la DB"
        Private Function CrearOActualizarProducto(ByVal conn As SQLiteConnection, ByVal transaction As SQLiteTransaction) As Boolean
            Dim sql As String
            Dim parametros As New Dictionary(Of String, Object)

            If ModProd = False Then
                sql = "INSERT INTO producto (ID, codigo, nombre, precio_base, porc_impuesto, variable, inventario, ganancia, fechaAdd) VALUES (@id, @codigo, @nombre, @precio_base, @porc_impuesto, @variable, @inventario, @ganancia, @fechaAdd)"
                parametros.Add("fechaAdd", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            Else
                sql = "UPDATE producto SET codigo = @codigo, nombre = @nombre, precio_base = @precio_base, porc_impuesto = @porc_impuesto, variable = @variable, inventario = @inventario, ganancia = @ganancia WHERE ID = @id"
            End If

            parametros.Add("id", idProd)
            parametros.Add("codigo", TXT_Cod.Text)
            parametros.Add("nombre", TXT_Nombre.Text)
            parametros.Add("precio_base", If(String.IsNullOrEmpty(TXT_PrecioBase.Text), 0, Double.Parse(TXT_PrecioBase.Text.Replace(",", "."), CultureInfo.InvariantCulture)))
            parametros.Add("porc_impuesto", If(String.IsNullOrEmpty(TXT_Impuesto.Text), 0, Double.Parse(TXT_Impuesto.Text.Replace(",", "."), CultureInfo.InvariantCulture)))
            parametros.Add("variable", If(SWT_Var.Checked, 1, 0))
            parametros.Add("inventario", NUD_Inv.Value)
            parametros.Add("ganancia", If(String.IsNullOrEmpty(TXT_Ganancia.Text), 0, Double.Parse(TXT_Ganancia.Text.Replace(",", "."), CultureInfo.InvariantCulture)))

            ' Aquí está el cambio: se llama al nuevo método con la transacción
            Return EJECUTAR_PARAMETROS_TRANSACCION(sql, parametros, conn, transaction)
        End Function

        Private Function CrearOActualizarPrecioVenta(ByVal conn As SQLiteConnection, ByVal transaction As SQLiteTransaction) As Boolean
            Dim sql As String
            Dim precioVenta As Double = Double.Parse(TXT_PrecioVenta.Text.Replace(",", "."), CultureInfo.InvariantCulture)
            Dim parametros As New Dictionary(Of String, Object)

            If Not EXISTECOD("producto_precioVenta", "ID_Producto", idProd) Then
                sql = "INSERT INTO producto_precioVenta (ID_Producto, precio_venta) VALUES (@id_prod, @precio_venta)"
                parametros.Add("id_prod", idProd)
                parametros.Add("precio_venta", precioVenta)
            Else
                sql = "UPDATE producto_precioVenta SET precio_venta = @precio_venta WHERE ID_Producto = @id_prod"
                parametros.Add("precio_venta", precioVenta)
                parametros.Add("id_prod", idProd)
            End If

            ' Aquí está el cambio
            Return EJECUTAR_PARAMETROS_TRANSACCION(sql, parametros, conn, transaction)
        End Function

        Private Sub CrearOActualizarDescripcion(ByVal conn As SQLiteConnection, ByVal transaction As SQLiteTransaction)
            Dim sql As String
            Dim parametros As New Dictionary(Of String, Object)

            If Not String.IsNullOrEmpty(TXT_Desc.Text) Then
                If Not EXISTECOD("producto_desc", "ID_Producto", idProd) Then
                    sql = "INSERT INTO producto_desc (ID_Producto, descripcion) VALUES (@id_prod, @desc)"
                    parametros.Add("id_prod", idProd)
                    parametros.Add("desc", TXT_Desc.Text)
                Else
                    sql = "UPDATE producto_desc SET descripcion = @desc WHERE ID_Producto = @id_prod"
                    parametros.Add("desc", TXT_Desc.Text)
                    parametros.Add("id_prod", idProd)
                End If
            Else
                sql = "DELETE FROM producto_desc WHERE ID_Producto = @id_prod"
                parametros.Add("id_prod", idProd)
            End If

            EJECUTAR_PARAMETROS_TRANSACCION(sql, parametros, conn, transaction)
        End Sub
        Private Sub CrearOActualizarCategoria(ByVal conn As SQLiteConnection, ByVal transaction As SQLiteTransaction)
            Dim sql As String
            Dim parametros As New Dictionary(Of String, Object)

            If Not String.IsNullOrEmpty(LBL_IDCat.Text) Then
                If Not EXISTECOD("producto_categoria", "ID_Producto", idProd) Then
                    sql = "INSERT INTO producto_categoria (ID_Producto, ID_Categoria) VALUES (@id_prod, @id_cat)"
                    parametros.Add("id_prod", idProd)
                    parametros.Add("id_cat", LBL_IDCat.Text)
                Else
                    sql = "UPDATE producto_categoria SET ID_Categoria = @id_cat WHERE ID_Producto = @id_prod"
                    parametros.Add("id_cat", LBL_IDCat.Text)
                    parametros.Add("id_prod", idProd)
                End If
            Else
                sql = "DELETE FROM producto_categoria WHERE ID_Producto = @id_prod"
                parametros.Add("id_prod", idProd)
            End If

            EJECUTAR_PARAMETROS_TRANSACCION(sql, parametros, conn, transaction)
        End Sub
        Private Sub CrearOActualizarMarca(ByVal conn As SQLiteConnection, ByVal transaction As SQLiteTransaction)
            Dim sql As String
            Dim parametros As New Dictionary(Of String, Object)

            If Not String.IsNullOrEmpty(LBL_IDMarca.Text) Then
                If Not EXISTECOD("producto_marca", "ID_Producto", idProd) Then
                    sql = "INSERT INTO producto_marca (ID_Producto, ID_Marca) VALUES (@id_prod, @id_marca)"
                    parametros.Add("id_prod", idProd)
                    parametros.Add("id_marca", LBL_IDMarca.Text)
                Else
                    sql = "UPDATE producto_marca SET ID_Marca = @id_marca WHERE ID_Producto = @id_prod"
                    parametros.Add("id_marca", LBL_IDMarca.Text)
                    parametros.Add("id_prod", idProd)
                End If
            Else
                sql = "DELETE FROM producto_marca WHERE ID_Producto = @id_prod"
                parametros.Add("id_prod", idProd)
            End If

            EJECUTAR_PARAMETROS_TRANSACCION(sql, parametros, conn, transaction)
        End Sub
        Private Sub CrearOActualizarProveedor(ByVal conn As SQLiteConnection, ByVal transaction As SQLiteTransaction)
            Dim sql As String
            Dim parametros As New Dictionary(Of String, Object)

            If Not String.IsNullOrEmpty(LBL_Prov.Text) Then
                If Not EXISTECOD("producto_proveedor", "ID_Producto", idProd) Then
                    sql = "INSERT INTO producto_proveedor (ID_Producto, ID_Proveedor) VALUES (@id_prod, @id_prov)"
                    parametros.Add("id_prod", idProd)
                    parametros.Add("id_prov", LBL_Prov.Text)
                Else
                    sql = "UPDATE producto_proveedor SET ID_Proveedor = @id_prov WHERE ID_Producto = @id_prod"
                    parametros.Add("id_prov", LBL_Prov.Text)
                    parametros.Add("id_prod", idProd)
                End If
            Else
                sql = "DELETE FROM producto_proveedor WHERE ID_Producto = @id_prod"
                parametros.Add("id_prod", idProd)
            End If

            EJECUTAR_PARAMETROS_TRANSACCION(sql, parametros, conn, transaction)
        End Sub
#End Region


        Private Sub LIMPIAR()
            TXT_PrecioBase.Text = "0"
            TXT_Impuesto.Text = "0"
            TXT_Ganancia.Text = "0"
            TXT_PrecioVenta.Text = "0"
            TXT_Cod.Clear()
            TXT_Nombre.Clear()
            TXT_Desc.Clear()
            TXT_Marca.Clear()
            TXT_Proveedor.Clear()
            TXT_Categoria.Clear()
            LBL_IDCat.Text = "idCat"
            LBL_IDMarca.Text = "idMarca"
            LBL_Prov.Text = "idProv"
        End Sub

        Private Sub TXT_Cod_TextChanged(sender As Object, e As EventArgs) Handles TXT_Cod.TextChanged
            VALIDAR()
        End Sub

        Private Sub TXT_CodBarra_TextChanged(sender As Object, e As EventArgs)
            VALIDAR()
        End Sub

        Private Sub TXT_Nombre_TextChanged(sender As Object, e As EventArgs) Handles TXT_Nombre.TextChanged
            VALIDAR()
        End Sub

        Private Sub TXT_PrecioVenta_TextChanged(sender As Object, e As EventArgs) Handles TXT_PrecioVenta.TextChanged
            If SWT_Var.Checked = False Then
                VALIDAR()
                If actpVenta Then
                    actGan = False
                    Try
                        Dim precioB As Double = 0
                        Dim precioV As Double = 0
                        Dim impP As Double = 0

                        If Not String.IsNullOrEmpty(TXT_PrecioBase.Text) Then
                            precioB = Convert.ToDouble(TXT_PrecioBase.Text)
                        End If

                        If Not String.IsNullOrEmpty(TXT_PrecioVenta.Text) Then
                            precioV = Convert.ToDouble(TXT_PrecioVenta.Text)
                        End If

                        If Not String.IsNullOrEmpty(TXT_Impuesto.Text) Then
                            impP = Convert.ToDouble(TXT_Impuesto.Text)
                        End If

                        ' Calcular el impuesto como un porcentaje del precio base
                        Dim impuesto As Double = precioB * (impP / 100)
                        Dim BaseImp As Double = precioB + impuesto

                        ' Calcular el porcentaje de ganancia
                        If BaseImp <> 0 Then
                            TXT_Ganancia.Text = (((precioV - BaseImp) / BaseImp) * 100).ToString("F2")
                        Else
                            TXT_Ganancia.Text = "0"
                        End If
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
                    End Try
                    actGan = True
                End If
            End If
        End Sub

        Private Sub TXT_PrecioBase_TextChanged(sender As Object, e As EventArgs) Handles TXT_PrecioBase.TextChanged
            VALIDAR()
            CalculoPrecioVenta()

        End Sub

        Private Sub TXT_Impuesto_TextChanged(sender As Object, e As EventArgs) Handles TXT_Impuesto.TextChanged
            VALIDAR()
            CalculoPrecioVenta()
        End Sub

        Private Sub TXT_Ganan1cia_TextChanged(sender As Object, e As EventArgs) Handles TXT_Ganancia.TextChanged
            VALIDAR()
            If actGan Then
                CalculoPrecioVenta()
            End If
        End Sub

        Private Sub CalculoPrecioVenta()
            If SWT_Var.Checked = False Then
                actpVenta = False
                Try
                    Dim precioB As Double = 0
                    Dim ganP As Double = 0
                    Dim impP As Double = 0

                    If Not String.IsNullOrEmpty(TXT_PrecioBase.Text) Then
                        precioB = Convert.ToDouble(TXT_PrecioBase.Text)
                    End If

                    If Not String.IsNullOrEmpty(TXT_Ganancia.Text) Then
                        ganP = Convert.ToDouble(TXT_Ganancia.Text)
                    End If

                    If Not String.IsNullOrEmpty(TXT_Impuesto.Text) Then
                        impP = Convert.ToDouble(TXT_Impuesto.Text)
                    End If

                    ' Calcular la ganancia y el impuesto correctamente
                    Dim ganancia As Double = precioB * (ganP / 100)
                    Dim impuesto As Double = precioB * (impP / 100) ' Era necesario calcular el impuesto como porcentaje del precio base

                    ' Calcular el precio de venta
                    TXT_PrecioVenta.Text = (precioB + ganancia + impuesto).ToString("F2") ' "F2" para mostrar dos decimales
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
                End Try
                actpVenta = True
            End If
        End Sub

        Private Sub SWT_Var_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_Var.CheckedChanged
            If SWT_Var.Checked = True Then
                TXT_PrecioVenta.Enabled = False
                TXT_Ganancia.Enabled = False
                TXT_Impuesto.Enabled = False
                TXT_PrecioVenta.Text = "0,00"
                TXT_Ganancia.Text = "0"
                TXT_Impuesto.Text = "0"
            Else
                TXT_PrecioVenta.Enabled = True
                TXT_Ganancia.Enabled = True
                TXT_Impuesto.Enabled = True
            End If
        End Sub

        Private Sub TXT_Marca_TextChanged(sender As Object, e As EventArgs) Handles TXT_Marca.TextChanged
            If String.IsNullOrEmpty(TXT_Marca.Text) Then
                LBL_IDMarca.Text = ""
            End If
        End Sub

        Private Sub TXT_Proveedor_TextChanged(sender As Object, e As EventArgs) Handles TXT_Proveedor.TextChanged
            If String.IsNullOrEmpty(TXT_Proveedor.Text) Then
                LBL_Prov.Text = ""
            End If
        End Sub

        Private Sub TXT_Categoria_TextChanged(sender As Object, e As EventArgs) Handles TXT_Categoria.TextChanged
            If String.IsNullOrEmpty(TXT_Categoria.Text) Then
                LBL_IDCat.Text = ""
            End If
        End Sub

        Private Sub BTN_AutoCod_Click(sender As Object, e As EventArgs) Handles BTN_AutoCod.Click
            ' Obtener todos los códigos existentes
            Dim codigosExistentes As List(Of Integer) = ObtenerCodigosExistentes("producto", "codigo")
            ' Ordenarlos
            codigosExistentes.Sort()

            ' Número de dígitos según configuración
            Dim numConfig As Integer = Integer.Parse(Md_Inicializacion.GetAppSetting("AutoCodProd"))

            ' Encontrar el primer número que no esté en uso
            Dim codigoDisponible As Integer = 1
            For Each codigo In codigosExistentes
                If codigo = codigoDisponible Then
                    codigoDisponible += 1
                ElseIf codigo > codigoDisponible Then
                    Exit For
                End If
            Next

            ' Formatear el código disponible con ceros a la izquierda según numConfig
            Dim CodActual As String = codigoDisponible.ToString("D" & numConfig)
            TXT_Cod.Text = CodActual
        End Sub
    End Class

End Namespace