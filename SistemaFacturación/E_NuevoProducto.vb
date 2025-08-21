Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Globalization

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
        P_Productos.Show()
        P_Productos.Select()
        P_Productos.TXT_BuscarProd.SelectAll()
        Me.Close()
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
        B_Marca.caso = "NProd"
        B_Marca.TXT_BuscarMarca.Text = TXT_Marca.Text
        B_Marca.Show()
        B_Marca.Select()
    End Sub

    Private Sub TXT_Proveedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Proveedor.MouseDoubleClick
        B_Proveedor.caso = "NProd"
        B_Proveedor.TXT_BuscarProv.Text = TXT_Proveedor.Text
        B_Proveedor.Show()
        B_Proveedor.Select()
    End Sub

    Private Sub TXT_Categoria_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Categoria.MouseDoubleClick
        B_Categoria.caso = "NProd"
        B_Categoria.TXT_BuscarCat.Text = TXT_Categoria.Text
        B_Categoria.Show()
        B_Categoria.Select()
    End Sub

    Private Sub TXT_Impuesto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Impuesto.MouseDoubleClick
        B_Impuesto.caso = "NProd"
        B_Impuesto.Show()
        B_Impuesto.Select()
    End Sub

    Private Sub BTN_NProv_Click(sender As Object, e As EventArgs) Handles BTN_NProv.Click
        If VALIDAR() Then
            Try
                PRG_Guardando.Visible = True
                PRG_Guardando.Start()
                T.Tables.Clear()
                Dim codigo As String = TXT_Cod.Text
                If ModProd = False Then
                    If Not EXISTECOD("producto", "codigo", codigo) Then ' Si no se ha guardado la categoría
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                Else
                    If codigo = CodigoPreMod Or Not EXISTECOD("producto", "codigo", codigo) Then
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                End If
                Cargar_Tabla(T, SQL)
                If Correcto Then
                    ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                    If msgGuardar() Then
                        Try
                            If ModProd = False Then
                                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                                If EXISTEPK("producto", "ID", idProd) = False Then ' Si no se ha guardado la categoría
                                    ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                    GUARDAR_PK("producto", "ID", idProd)
                                End If
                                GUARDAR_TIMEACTUAL("producto", "fechaAdd", "ID", idProd)
                            End If

                            ' Actualizar los campos en la base de datos
                            GUARDAR_TEXT("producto", "codigo", TXT_Cod.Text, "ID", idProd)

                            GUARDAR_TEXT("producto", "nombre", TXT_Nombre.Text, "ID", idProd)

                            If Not String.IsNullOrEmpty(TXT_PrecioBase.Text) Then
                                Dim precioB = Replace(TXT_PrecioBase.Text, ",", ".")
                                GUARDAR_NUMERIC("producto", "precio_base", precioB, "ID", idProd)
                            Else
                                GUARDAR_NUMERIC("producto", "precio_base", 0, "ID", idProd)
                            End If

                            If Not String.IsNullOrEmpty(TXT_Impuesto.Text) Then
                                Dim impP = Replace(TXT_Impuesto.Text, ",", ".")
                                GUARDAR_NUMERIC("producto", "porc_impuesto", impP, "ID", idProd)
                            Else
                                GUARDAR_NUMERIC("producto", "porc_impuesto", 0, "ID", idProd)
                            End If

                            If SWT_Var.Checked = True Then
                                GUARDAR_INT("producto", "variable", 1, "ID", idProd)
                            Else
                                GUARDAR_INT("producto", "variable", 0, "ID", idProd)
                            End If

                            GUARDAR_INT("producto", "inventario", NUD_Inv.Value, "ID", idProd)

                            Dim precioV As Double
                            ' Reemplazar la coma por punto
                            Dim precioTexto As String = TXT_PrecioVenta.Text.Replace(",", ".")
                            ' Usar InvariantCulture para asegurar que el punto se interprete como separador decimal
                            precioV = Double.Parse(precioTexto, CultureInfo.InvariantCulture)
                            If Not EXISTECOD("producto_precioVenta", "ID_Producto", idProd) Then
                                GUARDAR_VarCompNumeric("producto_precioVenta", idProd, precioV)
                            Else
                                GUARDAR_NUMERIC("producto_precioVenta", "precio_venta", precioV, "ID_Producto", idProd)
                            End If

                            If Not String.IsNullOrEmpty(TXT_Ganancia.Text) Then
                                Dim ganancia As Double = Double.Parse(Replace(TXT_Ganancia.Text, ",", "."), CultureInfo.InvariantCulture)
                                GUARDAR_NUMERIC("producto", "ganancia", ganancia, "ID", idProd)
                            Else
                                GUARDAR_NUMERIC("producto", "ganancia", 0, "ID", idProd)
                            End If

                            If SWT_Fav.Checked = True Then
                                GUARDAR_TEXT("producto", "favorito", "Si", "ID", idProd)
                            Else
                                GUARDAR_TEXT("producto", "favorito", "No", "ID", idProd)
                            End If
                            'Se agregan los campos en las tablas relacionadas en caso de ser necesario

                            If Not String.IsNullOrEmpty(TXT_Desc.Text) Then
                                If EXISTECOD("producto_desc", "ID_Producto", idProd) Then
                                    GUARDAR_VarCompuestas("producto_desc", idProd, TXT_Desc.Text)
                                Else
                                    GUARDAR_TEXT("producto_desc", "descripcion", TXT_Desc.Text, "ID_Producto", idProd)
                                End If
                            Else
                                ELIMINAR("producto_desc", "ID_Producto", idProd)
                            End If

                            If Not String.IsNullOrEmpty(LBL_IDCat.Text) And LBL_IDCat.Text <> "idCat" Then
                                If Not EXISTECOD("producto_categoria", "ID_Producto", idProd) Then
                                    Dim idCat As Integer
                                    If Integer.TryParse(LBL_IDCat.Text, idCat) Then
                                        GUARDAR_VarCompuestas("producto_categoria", idProd, idCat)
                                    Else
                                        msgError("No se logró almacenar la categoría, vuelva a intentarlo")
                                    End If
                                Else
                                    GUARDAR_TEXT("producto_categoria", "ID_Categoria", LBL_IDCat.Text, "ID_Producto", idProd)
                                End If
                            Else
                                ELIMINAR("producto_categoria", "ID_Producto", idProd)
                            End If


                            If Not String.IsNullOrEmpty(LBL_IDMarca.Text) And LBL_IDMarca.Text <> "idMarca" Then
                                If Not EXISTECOD("producto_marca", "ID_Producto", idProd) Then
                                    Dim idMarca As Integer
                                    If Integer.TryParse(LBL_IDMarca.Text, idMarca) Then
                                        GUARDAR_VarCompuestasInt("producto_marca", idProd, idMarca)
                                    Else
                                        MsgBox("No se logró almacenar la marca, vuelva a intentarlo", vbInformation + vbOKOnly, "Marca no guardada")
                                    End If
                                Else
                                    GUARDAR_TEXT("producto_marca", "ID_Marca", LBL_IDMarca.Text, "ID_Producto", idProd)
                                End If
                            Else
                                ELIMINAR("producto_marca", "ID_Producto", idProd)
                            End If

                            If Not String.IsNullOrEmpty(LBL_Prov.Text) And LBL_Prov.Text <> "idProv" Then
                                If Not EXISTECOD("producto_proveedor", "ID_Producto", idProd) Then
                                    Dim idProv As Integer
                                    If Integer.TryParse(LBL_Prov.Text, idProv) Then
                                        GUARDAR_VarCompuestasInt("producto_proveedor", idProd, idProv)
                                    Else
                                        MsgBox("No se logró almacenar el proveedor, vuelva a intentarlo", vbInformation + vbOKOnly, "Proveedor no guardads")
                                    End If
                                Else
                                    GUARDAR_TEXT("producto_proveedor", "ID_Proveedor", LBL_Prov.Text, "ID_Producto", idProd)
                                End If
                            Else
                                ELIMINAR("producto_proveedor", "ID_Producto", idProd)
                            End If
                            LIMPIAR()
                            msgDatoAlm()
                            PRG_Guardando.Stop()
                            PRG_Guardando.Visible = False
                            ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                            P_Productos.Show()
                            P_Productos.Select()
                            P_Productos.REFRESCAR()
                            P_Productos.TXT_BuscarProd.SelectAll()
                            Me.Close()
                            ModProd = False
                        Catch ex As Exception
                            msgError("Error al actualizar los datos: " & ex.Message)
                            PRG_Guardando.Stop()
                        End Try
                    End If
                Else
                    msgError("El código " + TXT_Cod.Text + " ya existe, coloque un código distinto")
                    TXT_Cod.SelectAll()
                    PRG_Guardando.Stop()
                End If
            Catch ex As Exception
                msgError("Error: " & ex.Message)
                PRG_Guardando.Stop()
            End Try
        End If
        PRG_Guardando.Stop()
        PRG_Guardando.Visible = False
    End Sub


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
        calculoPrecioVenta()

    End Sub

    Private Sub TXT_Impuesto_TextChanged(sender As Object, e As EventArgs) Handles TXT_Impuesto.TextChanged
        VALIDAR()
        calculoPrecioVenta()
    End Sub

    Private Sub TXT_Ganan1cia_TextChanged(sender As Object, e As EventArgs) Handles TXT_Ganancia.TextChanged
        VALIDAR()
        If actGan Then
            calculoPrecioVenta()
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
    Private Sub CKB_Fav_CheckedChanged(sender As Object, e As EventArgs)
        If SWT_Fav.Checked = True Then
            SQL = "SELECT COUNT(ID) FROM producto WHERE favorito = 'Si'"
            If ModProd Then
                SQL += " AND ID <> " + idProd
            End If
            T.Tables.Clear()
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows(0).Item(0) >= 8 Then
                MsgBox("Solo puede tener un máximo de 10 productos en favorito" + vbCrLf + "Elimine el favorito de otro producto para agregar este", vbCritical + vbOKOnly, "Limite de favoritos alcanzado")
                SWT_Fav.Checked = False
            End If
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