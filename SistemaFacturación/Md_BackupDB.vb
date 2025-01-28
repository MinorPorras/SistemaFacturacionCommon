Imports System.IO
Imports System.Configuration
Imports System.Threading

Module Md_BackupDB
    Dim DBActual As String

#Region "exportar"
    Friend Sub ExportarDB()
        ' Definición de la ruta de acceso del respaldo
        Dim fechaActual As String = Now.ToString("yyyyMMdd_HHmmss")
        Dim backupDir As String = ConfigurationManager.AppSettings("DirectorioRespaldo") & "RespaldosSF"
        Dim respaldo As String = Path.Combine(backupDir, "DBSistemaFact_" & fechaActual & ".db")

        ' Se crea el directorio  en caso de que no exista
        If Not Directory.Exists(backupDir) Then
            Directory.CreateDirectory(backupDir)
        End If
        DESCONECTAR()
        ' Se copia la base de datos a un nuevo archivo
        Try
            Dim strsplit As String() = ObtenerConnectionString("DbConnectionString").Split("=")
            DBActual = strsplit(1).Trim()
            File.Copy(DBActual, respaldo, True)
            Console.WriteLine("Copia de seguridad creada exitosamente: " & respaldo)
            MsgBox("Archivo de respaldo de la base de datos generado correctamente en la ruta: " & vbCrLf & vbCrLf & respaldo, vbOK, "Respaldo generado")
        Catch ex As Exception
            Console.WriteLine("Error al crear la copia de seguridad: " & ex.Message)
            msgError("Error al crear la copia de seguridad: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "importar"
    Friend Sub ImportarDB(respaldo As String)
        DESCONECTAR()
        ' Se copia el respaldo en la base de datos que se encuentra en la posición actual
        Try
            Dim strsplit As String() = ObtenerConnectionString("DbConnectionString").Split("=")
            DBActual = strsplit(1).Trim()
            File.Copy(respaldo, DBActual, True)
            Console.WriteLine("Importación de la base de datos realizada correctamente: " & respaldo)
            MsgBox("Importación de la base de datos realizada correctamente desde la ruta: " & vbCrLf & vbCrLf & respaldo, vbOK, "Importación generada")
        Catch ex As Exception
            Console.WriteLine("Error al importar la base de datos: " & ex.Message)
            msgError("Error al importar la base de datos: " & ex.Message)
        End Try
    End Sub
#End Region

End Module

