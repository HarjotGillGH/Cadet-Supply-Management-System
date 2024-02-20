Imports System
'Imports System.Data.SQLite not used by this application
Imports System.Diagnostics.CodeAnalysis
Imports Microsoft.Data.Sqlite
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = ""
        System.Diagnostics.Debug.WriteLine("DOES THIS EvEN WORK?")
        'Dim connectionString As String = "Data Source=example.db;Version=3;"
        Dim connectionString As String = "Data Source=C:\Users\har_j\Desktop\CADET PROGRAM\Cadets Supply Management System\Cadets Supply Management System\test.db;" 'Version=3;"
        ' SQL query to select data
        Dim query As String = "SELECT * FROM users"

        ' Create a connection to the database
        Using connection As New SqliteConnection(connectionString)
            ' Open the connection
            connection.Open()
            Dim insertQuery As String = "INSERT INTO users (username, email) VALUES (@username, @email)"

            ' Data to insert
            Dim usernameI As String = "JohnDoe"
            Dim emailI As String = "john@example.com"


            ' Open the connection
            'connection.Open()

            ' Create a command to execute the query
            Using command As New SqliteCommand(insertQuery, connection)
                ' Add parameters to the command
                command.Parameters.AddWithValue("@username", usernameI)
                command.Parameters.AddWithValue("@email", emailI)

                ' Execute the query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    System.Diagnostics.Debug.WriteLine("Data inserted successfully.")
                Else
                    System.Diagnostics.Debug.WriteLine("Failed to insert data.")
                End If




                Dim queryRead As String = "SELECT * FROM users"



                ' Create a command to execute the query
                Using command1 As New SqliteCommand(queryRead, connection)
                    ' Execute the query
                    Using reader As SqliteDataReader = command1.ExecuteReader()
                        ' Loop through the results and print them
                        System.Diagnostics.Debug.WriteLine("LOLOL DOES the reader workLLLLLLLLLLLLLLLLLL")
                        'System.Diagnostics.Debug.WriteLine(reader.n)
                        System.Diagnostics.Debug.WriteLine(reader.Read())
                        While reader.Read()
                            ' Example: Assuming the "users" ec  has columns id, username, and email
                            Dim id As Integer = reader.GetInt32(0)
                            Dim username As String = reader.GetString(1)
                            Dim email As String = reader.GetString(2)

                            System.Diagnostics.Debug.WriteLine("loop running")
                            System.Diagnostics.Debug.WriteLine("ID: " + CStr(id) + " Username: " + username + ", Email: " + email)
                            str = "ID: " + CStr(id) + " Username: " + username + ", Email: " + email + vbCrLf
                            outputLBX.Items.Add(str)
                        End While

                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class
