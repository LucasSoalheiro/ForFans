Imports MySql.Data.MySqlClient

Public Module ConexaoBD
    Private connStr As String
    Sub New()
        Try
            Dim opcoes As New dotenv.net.DotEnvOptions(probeForEnv:=True, probeLevelsToSearch:=4)
            dotenv.net.DotEnv.Load(opcoes)

            Dim host As String = Environment.GetEnvironmentVariable("DB_HOST")
            Dim name As String = Environment.GetEnvironmentVariable("DB_NAME")
            Dim user As String = Environment.GetEnvironmentVariable("DB_USER")
            Dim pass As String = Environment.GetEnvironmentVariable("DB_PASS")
            connStr = $"Server={host};Database={name};user={user};password={pass};"
        Catch ex As Exception
            MsgBox($"Erro de Configuração: {ex.Message}", MsgBoxStyle.Critical)
            connStr = String.Empty
        End Try
    End Sub
    Public Async Function GetConnectionAsync() As Task(Of MySqlConnection)
        Dim conn As New MySqlConnection(connStr)
        Await conn.OpenAsync()
        MsgBox("deubom")
        Return conn
    End Function

    Public Async Function ReadAllAsync(table As String, Optional where As String = "") As Task(Of DataTable)
        Dim dt As New DataTable()
        Using conn As MySqlConnection = Await GetConnectionAsync()
            Dim sql As String = $"SELECT * FROM {table}"
            If Not String.IsNullOrEmpty(where) Then sql &= $" WHERE {where}"

            Using cmd As New MySqlCommand(sql, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Await Task.Run(Sub() da.Fill(dt))
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Async Function ReadAsync(table As String, where As String) As Task(Of DataRow)
        Dim dt As DataTable = Await ReadAllAsync(table, where)
        If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Return Nothing
    End Function

    Public Async Function CreateAsync(table As String, data As Dictionary(Of String, Object)) As Task(Of Long)
        Using conn As MySqlConnection = Await GetConnectionAsync()
            Dim columns As String = String.Join(", ", data.Keys)
            Dim placeholders As String = String.Join(", ", data.Keys.Select(Function(k) "@" & k))
            Dim sql As String = $"INSERT INTO {table} ({columns}) VALUES ({placeholders}); SELECT LAST_INSERT_ID();"

            Using cmd As New MySqlCommand(sql, conn)
                For Each pair In data
                    cmd.Parameters.AddWithValue("@" & pair.Key, pair.Value)
                Next
                Dim insertId As Object = Await cmd.ExecuteScalarAsync()
                Return Convert.ToInt64(insertId)
            End Using
        End Using
    End Function

    Public Async Function UpdateAsync(table As String, data As Dictionary(Of String, Object), where As String) As Task(Of Integer)
        Using conn As MySqlConnection = Await GetConnectionAsync()
            Dim setClauses As New List(Of String)()
            For Each key In data.Keys
                setClauses.Add($"{key} = @{key}")
            Next
            Dim setStr As String = String.Join(", ", setClauses)
            Dim sql As String = $"UPDATE {table} SET {setStr} WHERE {where}"

            Using cmd As New MySqlCommand(sql, conn)
                For Each pair In data
                    cmd.Parameters.AddWithValue("@" & pair.Key, pair.Value)
                Next
                Return Await cmd.ExecuteNonQueryAsync()
            End Using
        End Using
    End Function

    Public Async Function DeleteRecordAsync(table As String, where As String) As Task(Of Integer)
        Using conn As MySqlConnection = Await GetConnectionAsync()
            Dim sql As String = $"DELETE FROM {table} WHERE {where}"
            Using cmd As New MySqlCommand(sql, conn)
                Return Await cmd.ExecuteNonQueryAsync()
            End Using
        End Using
    End Function
End Module
