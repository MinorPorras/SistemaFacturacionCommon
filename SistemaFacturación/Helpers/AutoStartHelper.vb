Imports Microsoft.Win32
Imports Serilog
Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Namespace SistemaFacturacion.Helper
    ''' <summary>
    ''' Helper que permite la creación, modificación y eliminación de los registros necesarios para que la aplicación 
    ''' se inicie cuando se inicia sesión en windows
    ''' </summary>
    Module AutoStartHelper

        Private Const REG_KEY As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        Private Const APP_NAME As String = "SistemaFacturacionCommon"

        ''' <summary>
        ''' Obtiene o establece si la aplicación inicia con Windows
        ''' </summary>
        Public Property IniciarConWindows As Boolean
            Get
                Return IsRegistryConfigured()
            End Get
            Set(value As Boolean)
                ConfigureStartRegistry(value)
            End Set
        End Property

        Private Function IsRegistryConfigured() As Boolean
            Try
                Using key As RegistryKey = Registry.CurrentUser.OpenSubKey(REG_KEY)
                    If key IsNot Nothing Then
                        Dim valor As String = TryCast(key.GetValue(APP_NAME), String)
                        Return Not String.IsNullOrEmpty(valor) AndAlso File.Exists(valor)
                    End If
                End Using
                Return False
            Catch
                Return False
            End Try
        End Function

        Private Function ConfigureStartRegistry(enable As Boolean) As Boolean
            Try
                Using key As RegistryKey = Registry.CurrentUser.CreateSubKey(REG_KEY)
                    If enable Then
                        key.SetValue(APP_NAME, Application.ExecutablePath)
                    Else
                        key.DeleteValue(APP_NAME, False)
                        Log.Information("Eliminado el registro")
                    End If
                End Using
                Return True
            Catch ex As Exception
                Log.Error(ex.Message)
                Return False
            End Try
        End Function

    End Module
End Namespace

