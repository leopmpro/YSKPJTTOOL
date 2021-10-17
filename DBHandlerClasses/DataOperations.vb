Imports System.Data.SqlClient


Public Class DataOperations
    Inherits SqlServerConnection
    Public Sub New(sDatabaseServer As String, sDefaultCatalog As String)
        DatabaseServer = sDatabaseServer
        DefaultCatalog = sDefaultCatalog
    End Sub

    Public Function GetActivePjtList() As DataTable
        Dim myDt = New DataTable()
        mHasException = False
        Dim queryString = "Select * From dbo.Tasks"

        Using mySqlConnection = New SqlConnection With {
            .ConnectionString = ConnectionString}
            Using myCmd = New SqlCommand With {
             .Connection = mySqlConnection}

                myCmd.CommandText = queryString
                '                cmd.Parameters.AddWithValue("@ActiveStatus", pStatus)
                Try
                    mySqlConnection.Open()
                    myDt.Load(myCmd.ExecuteReader())
                    'dt.Columns("CustomerIdentifier").ColumnMapping = MappingType.Hidden

                Catch ex As Exception
                    mHasException = True
                    mLastException = ex
                End Try

            End Using

        End Using

        Return myDt
    End Function

End Class
