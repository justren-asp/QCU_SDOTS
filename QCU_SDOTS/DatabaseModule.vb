Imports MySql.Data.MySqlClient

Module DatabaseModule
    Public Function GetConnection() As MySqlConnection
        Dim connStr As String = "Server=localhost;Port=3306;Database=qcu_sdots_db;Uid=root;Pwd=;"
        Return New MySqlConnection(connStr)
    End Function
End Module