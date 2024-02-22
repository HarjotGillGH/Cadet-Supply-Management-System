Imports Microsoft.Data.Sqlite
Public Class DatabaseManager

    Private connectionString As String

    Public Sub New(ByVal connectionStr As String)
        Me.connectionString = connectionStr
    End Sub

    ' intialize connection
    ' insert data
    Public Function runQuery(ByVal query As String)
        Dim dataTable = New DataTable()
        Using connection As New SqliteConnection(connectionString)
            connection.Open()
            Using command As New SqliteCommand(query, connection)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    dataTable.Load(reader)

                End Using
            End Using
        End Using
        Return DataTable
    End Function


End Class
