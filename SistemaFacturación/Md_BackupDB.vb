Imports System.IO
Imports System.Configuration

Module Md_BackupDB
#Region "exportar"
    Friend Sub ExportarDB()
        ' Definición de la ruta de acceso del respaldo
        Dim fechaActual As String = Now.ToString("yyyyMMdd_HHmmss")
        Dim backupDir As String = GetAppSetting("DirectorioRespaldo")
        Dim respaldo As String = Path.Combine(backupDir, "DBCommonBackup_" & fechaActual & ".db")

        ' Se crea el directorio en caso de que no exista
        If Not Directory.Exists(backupDir) Then
            Directory.CreateDirectory(backupDir)
        End If

        Try
            ' Se copia la base de datos a un nuevo archivo
            File.Copy(GetDbPath(), respaldo, True)
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

            ' Se copia el respaldo en la base de datos que se encuentra en la posición actual
            File.Copy(respaldo, GetDbPath(), True)
            Console.WriteLine("Importación de la base de datos realizada correctamente: " & respaldo)
            MsgBox("Importación de la base de datos realizada correctamente desde la ruta: " & vbCrLf & vbCrLf & respaldo, vbOK, "Importación generada")
        Catch ex As Exception
            Console.WriteLine("Error al importar la base de datos: " & ex.Message)
            MsgBox("Error al importar la base de datos: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub
#End Region

End Module

