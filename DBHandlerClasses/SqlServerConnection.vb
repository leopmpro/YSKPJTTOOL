Public Class SqlServerConnection
    Inherits BaseExceptionProperties
    Implements IConnection

    Protected DatabaseServer As String = ""
    Protected DefaultCatalog As String = ""

    Public ReadOnly Property ConnectionString As String Implements IConnection.ConnectionString
        Get
            Return $"Data Source={DatabaseServer};Initial Catalog={DefaultCatalog};Integrated Security=True"
        End Get
    End Property
End Class
