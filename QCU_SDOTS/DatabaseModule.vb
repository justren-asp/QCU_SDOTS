Imports MySql.Data.MySqlClient

Module DatabaseModule

    ' MySQL database connection string
    Public connString As String = "Server=localhost;Database=qcu_sdots_db;Uid=root;Pwd=;"

    ' Function to generate and return a new MySQL connection safely
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connString)
    End Function

End Module