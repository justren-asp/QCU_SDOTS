Imports MySql.Data.MySqlClient

Module DatabaseModule
    Public connString As String = "Server=localhost;Database=qcu_sdots_db;Uid=root;Pwd=;"

    ' Session variables for logged-in user
    Public currentUserID As Integer = 0
    Public currentUserRole As String = ""
    Public currentFullName As String = ""

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connString)
    End Function
End Module