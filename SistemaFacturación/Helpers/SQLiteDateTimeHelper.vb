Imports System.Data.SQLite

''' <summary>
''' Clase utilitaria para manejo de fechas y horas con SQLite
''' Garantiza precisión total incluyendo horas, minutos y segundos
''' </summary>
Public NotInheritable Class SQLiteDateTimeHelper

    ' Constantes para formato SQLite
    Private Const FormatoSQLite As String = "yyyy-MM-dd HH:mm:ss"
    Private Const FormatoSQLiteFecha As String = "yyyy-MM-dd"

    ''' <summary>
    ''' Convierte un DateTime a formato SQLite incluyendo horas, minutos y segundos
    ''' </summary>
    ''' <param name="fecha">Fecha a convertir</param>
    ''' <returns>String en formato "yyyy-MM-dd HH:mm:ss"</returns>
    Public Shared Function ToSQLiteString(ByVal fecha As DateTime) As String
        Return fecha.ToString(FormatoSQLite)
    End Function

    ''' <summary>
    ''' Convierte un DateTime a solo fecha en formato SQLite
    ''' </summary>
    ''' <param name="fecha">Fecha a convertir</param>
    ''' <returns>String en formato "yyyy-MM-dd"</returns>
    Public Shared Function ToSQLiteDate(ByVal fecha As DateTime) As String
        Return fecha.ToString(FormatoSQLiteFecha)
    End Function

    ''' <summary>
    ''' Obtiene el inicio del día (00:00:00) para una fecha específica
    ''' </summary>
    ''' <param name="fecha">Fecha base</param>
    ''' <returns>DateTime con hora 00:00:00</returns>
    Public Shared Function InicioDelDia(ByVal fecha As DateTime) As DateTime
        Return New DateTime(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0)
    End Function

    ''' <summary>
    ''' Obtiene el final del día (23:59:59) para una fecha específica
    ''' Incluye todos los segundos del día para cierre exacto
    ''' </summary>
    ''' <param name="fecha">Fecha base</param>
    ''' <returns>DateTime con hora 23:59:59</returns>
    Public Shared Function FinalDelDia(ByVal fecha As DateTime) As DateTime
        Return New DateTime(fecha.Year, fecha.Month, fecha.Day, 23, 59, 59)
    End Function

    ''' <summary>
    ''' Obtiene el final del día con milisegundos (23:59:59.999) para máxima precisión
    ''' Úsalo cuando necesites incluir el último milisegundo del día
    ''' </summary>
    ''' <param name="fecha">Fecha base</param>
    ''' <returns>DateTime con hora 23:59:59.999</returns>
    Public Shared Function FinalDelDiaPreciso(ByVal fecha As DateTime) As DateTime
        Return New DateTime(fecha.Year, fecha.Month, fecha.Day, 23, 59, 59, 999)
    End Function

    ''' <summary>
    ''' Crea un rango de fechas completo para un día específico
    ''' </summary>
    ''' <param name="fecha">Fecha del día</param>
    ''' <returns>Tupla con fecha inicio y fin del día</returns>
    Public Shared Function RangoDiaCompleto(ByVal fecha As DateTime) As (inicio As DateTime, fin As DateTime)
        Return (InicioDelDia(fecha), FinalDelDia(fecha))
    End Function

    ''' <summary>
    ''' Convierte una fecha almacenada en SQLite a DateTime de .NET
    ''' </summary>
    ''' <param name="fechaSQLite">Fecha en formato SQLite</param>
    ''' <returns>DateTime de .NET</returns>
    Public Shared Function FromSQLiteString(ByVal fechaSQLite As String) As DateTime
        Return DateTime.ParseExact(fechaSQLite, FormatoSQLite,
                                   System.Globalization.CultureInfo.InvariantCulture)
    End Function

    ''' <summary>
    ''' Crea un parámetro SQLite con fecha y hora formateada correctamente
    ''' </summary>
    ''' <param name="nombre">Nombre del parámetro</param>
    ''' <param name="valor">Valor DateTime a convertir</param>
    ''' <returns>SQLiteParameter con valor formateado para SQLite</returns>
    Public Shared Function CreateDateTimeParameter(ByVal nombre As String, ByVal valor As DateTime) As SQLiteParameter
        Return New SQLiteParameter(nombre, ToSQLiteString(valor))
    End Function

    ''' <summary>
    ''' Crea un parámetro SQLite con solo fecha (sin hora)
    ''' </summary>
    ''' <param name="nombre">Nombre del parámetro</param>
    ''' <param name="valor">Valor DateTime</param>
    ''' <returns>SQLiteParameter con solo fecha</returns>
    Public Shared Function CreateDateParameter(ByVal nombre As String, ByVal valor As DateTime) As SQLiteParameter
        Return New SQLiteParameter(nombre, ToSQLiteDate(valor))
    End Function

End Class

