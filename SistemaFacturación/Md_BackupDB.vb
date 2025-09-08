Imports System.IO
Imports System.Configuration

Module Md_BackupDB
    Dim DBActual As String

#Region "exportar"
    Friend Sub ExportarDB()
        ' Definición de la ruta de acceso del respaldo
        Dim fechaActual As String = Now.ToString("yyyyMMdd_HHmmss")
        Dim backupDir As String = ConfigurationManager.AppSettings("DirectorioRespaldo") & "RespaldosSF"
        Dim respaldo As String = Path.Combine(backupDir, "DBSistemaFact_" & fechaActual & ".db")

        ' Se crea el directorio en caso de que no exista
        If Not Directory.Exists(backupDir) Then
            Directory.CreateDirectory(backupDir)
        End If

        Try
            Dim conexionSetting As System.Configuration.ConnectionStringSettings = ConfigurationManager.ConnectionStrings("conexionString")
            If conexionSetting Is Nothing Then
                msgError("No se pudo encontrar la conexión")
            End If
            ' Obtener la ruta de la base de datos actual
            Dim strConexion As String = conexionSetting.ConnectionString

            If strConexion.Contains("|DataDirectory|") Then
                ' Obtener la ruta completa del ejecutable
                Dim appPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
                ' Obtener solo el directorio de esa ruta
                Dim appDir As String = System.IO.Path.GetDirectoryName(appPath)
                ' Reemplazar la cadena por la ruta del directorio
                DBActual = strConexion.Replace("Data Source=|DataDirectory|", appDir)

            Else
                ' Si no tiene |DataDirectory|, asumimos que es una ruta completa.
                Dim strsplit As String() = strConexion.Split("=")
                If strsplit.Length <= 1 Then
                    MsgBox("Error en el formato de la cadena de conexión.", MsgBoxStyle.Exclamation, "Error")
                    Return
                End If
                DBActual = strsplit(1).Trim()

            End If

            ' Se copia la base de datos a un nuevo archivo
            File.Copy(DBActual, respaldo, True)
            Console.WriteLine("Copia de seguridad creada exitosamente: " & respaldo)
            MsgBox("Archivo de respaldo de la base de datos generado correctamente en la ruta: " & vbCrLf & vbCrLf & respaldo, vbOK, "Respaldo generado")
        Catch ex As Exception
            Console.WriteLine("Error al crear la copia de seguridad: " & ex.Message)
            MsgBox("Error al crear la copia de seguridad: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub
#End Region

#Region "importar"
    Friend Sub ImportarDB(respaldo As String)
        Try
            Dim conexionSetting As System.Configuration.ConnectionStringSettings = ConfigurationManager.ConnectionStrings("conexionString")
            If conexionSetting Is Nothing Then
                msgError("No se pudo encontrar la conexión")
            End If
            ' Obtener la ruta de la base de datos actual
            Dim strConexion As String = conexionSetting.ConnectionString

            If strConexion.Contains("|DataDirectory|") Then
                ' Obtener la ruta completa del ejecutable
                Dim appPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
                ' Obtener solo el directorio de esa ruta
                Dim appDir As String = System.IO.Path.GetDirectoryName(appPath)
                ' Reemplazar la cadena por la ruta del directorio
                DBActual = strConexion.Replace("Data Source=|DataDirectory|", appDir)

            Else
                ' Si no tiene |DataDirectory|, asumimos que es una ruta completa.
                Dim strsplit As String() = strConexion.Split("=")
                If strsplit.Length <= 1 Then
                    MsgBox("Error en el formato de la cadena de conexión.", MsgBoxStyle.Exclamation, "Error")
                    Return
                End If
                DBActual = strsplit(1).Trim()

            End If

            ' Se copia el respaldo en la base de datos que se encuentra en la posición actual
            File.Copy(respaldo, DBActual, True)
            Console.WriteLine("Importación de la base de datos realizada correctamente: " & respaldo)
            MsgBox("Importación de la base de datos realizada correctamente desde la ruta: " & vbCrLf & vbCrLf & respaldo, vbOK, "Importación generada")
        Catch ex As Exception
            Console.WriteLine("Error al importar la base de datos: " & ex.Message)
            MsgBox("Error al importar la base de datos: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub
#End Region

End Module

