Imports MySql.Data.MySqlClient
Imports Krypton.Toolkit

Public Class AdminPanel
    Inherits FormBase

    Private Async Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.AccountName = SessionManager.UserName
        SetupGrid()
        Await LoadUsers()
    End Sub

    Private Sub SetupGrid()
        dgvUsers.Columns.Clear()
        dgvUsers.AutoGenerateColumns = False

        ' ID (Hidden)
        dgvUsers.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "id",
            .HeaderText = "ID",
            .DataPropertyName = "id",
            .Visible = False
        })

        ' Nome
        dgvUsers.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "name",
            .HeaderText = "Nome",
            .DataPropertyName = "name",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        })

        ' Email
        dgvUsers.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "email",
            .HeaderText = "Email",
            .DataPropertyName = "email",
            .Width = 200
        })

        ' Status
        dgvUsers.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "status",
            .HeaderText = "Status",
            .Width = 100
        })

        ' Botão Editar
        Dim btnEdit As New KryptonDataGridViewButtonColumn() With {
            .Name = "btnEdit",
            .HeaderText = "Ações",
            .Text = "Editar",
            .UseColumnTextForButtonValue = True,
            .Width = 100
        }
        dgvUsers.Columns.Add(btnEdit)

        ' Botão Bloquear
        Dim btnBlock As New KryptonDataGridViewButtonColumn() With {
            .Name = "btnBlock",
            .HeaderText = "",
            .Text = "Bloquear",
            .UseColumnTextForButtonValue = True,
            .Width = 100
        }
        dgvUsers.Columns.Add(btnBlock)
    End Sub

    Private Async Function LoadUsers() As Task
        Try
            Dim dtUsers = Await ReadAllAsync("Users", "role != 'admin'")
            dgvUsers.Rows.Clear()

            For Each row As DataRow In dtUsers.Rows
                Dim isActive As Boolean = Convert.ToBoolean(row("active"))
                Dim statusText As String = If(isActive, "Ativo", "Inativo")
                Dim rowIndex As Integer = dgvUsers.Rows.Add(
                    row("id"),
                    row("name"),
                    row("email"),
                    statusText
                )

                ' Personaliza o texto do botão de bloquear baseado no status
                dgvUsers.Rows(rowIndex).Cells("btnBlock").Value = If(isActive, "Bloquear", "Ativar")
            Next
        Catch ex As Exception
            MsgBox($"Erro ao carregar usuários: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Function

    Private Async Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex < 0 Then Return

        Dim userId = dgvUsers.Rows(e.RowIndex).Cells("id").Value
        Dim userName = dgvUsers.Rows(e.RowIndex).Cells("name").Value.ToString()

        If dgvUsers.Columns(e.ColumnIndex).Name = "btnEdit" Then
            Using dialog As New UserEditDialog(Convert.ToInt32(userId))
                If dialog.ShowDialog() = DialogResult.OK Then
                    Await LoadUsers()
                End If
            End Using

        ElseIf dgvUsers.Columns(e.ColumnIndex).Name = "btnBlock" Then
            Dim currentStatus = dgvUsers.Rows(e.RowIndex).Cells("status").Value.ToString()
            Dim isBlocking = (currentStatus = "Ativo")
            Dim newStatus = Not isBlocking
            Dim actionText = If(isBlocking, "bloquear", "ativar")

            If MsgBox($"Deseja realmente {actionText} o usuário {userName}?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    Dim data As New Dictionary(Of String, Object) From {{"active", newStatus}}
                    Dim params As New List(Of MySqlParameter) From {New MySqlParameter("@id", userId)}

                    Await UpdateAsync("Users", data, "id = @id", params)
                    Await LoadUsers()
                Catch ex As Exception
                    MsgBox($"Erro ao atualizar status: {ex.Message}", MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub
End Class