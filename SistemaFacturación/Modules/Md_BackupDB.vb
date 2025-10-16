Imports System.IO
Imports System.Configuration
Imports Serilog
Imports Serilog.Context
Namespace SistemaFacturacion.Modules

    Module Md_BackupDB
#Region "exportar"
        Friend Sub ExportarDB()
            Using LogContext.PushProperty("Feature", "Exportacion")
                Log.Information("Iniciando proceso de exportación de la base de datos.")
                ' Definición de la ruta de acceso del respaldo
                Dim fechaActual As String = Now.ToString("yyyyMMdd_HHmmss")
                Dim backupDir As String = GetAppSetting("DirectorioRespaldo")
                Dim respaldo As String = Path.Combine(backupDir, "DBCommonBackup_" & fechaActual & ".db")

                ' Se crea el directorio en caso de que no exista
                If Not Directory.Exists(backupDir) Then
                    Log.Information("El directorio de respaldo no existe. Creando: " & backupDir)
                    Directory.CreateDirectory(backupDir)
                End If

                Try
                    ' Se copia la base de datos a un nuevo archivo
                    File.Copy(GetDbPath(), respaldo, True)
                    Log.Information("Copia de seguridad creada exitosamente: " & respaldo)
                    MsgBox("Archivo de respaldo de la base de datos generado correctamente en la ruta: " & vbCrLf & vbCrLf & respaldo, vbOK, "Respaldo generado")
                Catch ex As Exception
                    MsgError("Error al crear la copia de seguridad: " & ex.Message)
                End Try
            End Using
        End Sub
#End Region

#Region "importar"
        Friend Sub ImportarDB(respaldo As String)
            Using LogContext.PushProperty("Feature", "Importacion")
                Log.Information("Iniciando proceso de importación de la base de datos desde: " & respaldo)
                Try
                    ' Se copia el respaldo en la base de datos que se encuentra en la posición actual
                    File.Copy(respaldo, GetDbPath(), True)
                    Log.Information("Importación de la base de datos realizada correctamente desde: " & respaldo)
                    MsgBox("Importación de la base de datos realizada correctamente desde la ruta: " & vbCrLf & vbCrLf & respaldo, vbOK, "Importación generada")
                Catch ex As Exception
                    MsgError("Error al importar la base de datos: " & ex.Message)
                End Try
            End Using
        End Sub
#End Region

    End Module

End Namespace
