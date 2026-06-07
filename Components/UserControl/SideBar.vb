Public Class SideBar
    Public Event ToggleSideBar()
    Private SpecialPath As String

    ' Removidos UserId e ActualForm pois agora usamos SessionManager e Me.FindForm()

    Public Property AccountName As String
        Get
            Return AccountLbl.Text
        End Get
        Set(value As String)
            AccountLbl.Text = value
        End Set
    End Property

    Private Sub NavigateTo(newForm As Form)
        Dim currentForm = Me.FindForm()
        newForm.Show()
        If currentForm IsNot Nothing Then currentForm.Close()
    End Sub

    Private Sub SidebarBtn_Click(sender As Object, e As EventArgs) Handles SidebarBtn.Click
        RaiseEvent ToggleSideBar()
    End Sub

    Private Sub SideBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(29, 161, 242)
        If SessionManager.IsLoggedIn Then
            AccountLbl.Text = SessionManager.UserName

            ' Controle de Acesso (RBAC)
            Dim isCreator = (SessionManager.UserRole = "creator" OrElse SessionManager.UserRole = "admin")
            Dim isAdmin = (SessionManager.UserRole = "admin")
            Dim isSubscriberOnly = (SessionManager.UserRole = "subscriber")
            If isAdmin Then
                KryptonButton3.Visible = False
                AccountLbl.Visible = False
            End If
            ButtonCreatorArea.Visible = isCreator
            LabelCreatorArea.Visible = isCreator
            KryptonButton4.Visible = isCreator
            ManageContents.Visible = isCreator

            'Botões especiais
            If isAdmin Then
                SpecialLbl.Text = "Admin Panel"
                SpecialPath = "AdminPanel"
                SpecialBtn.Visible = True
                SpecialLbl.Visible = True
            ElseIf isSubscriberOnly Then
                SpecialLbl.Text = "Be a Creator"
                SpecialPath = "BecomeCreator"
                SpecialBtn.Visible = True
                SpecialLbl.Visible = True
            Else
                SpecialBtn.Visible = False
                SpecialLbl.Visible = False
            End If

            RepositionItems()
        End If
    End Sub

    Private Sub RepositionItems()
        Dim currentY As Integer = 80
        Dim spacing As Integer = 65

        ' Lista ordenada de itens do menu (Excluindo os que ficam fixos no rodapé)
        Dim menuItems = {
            New With {.Icon = DirectCast(ButtonCreatorArea, Control), .Label = DirectCast(LabelCreatorArea, Control)},
            New With {.Icon = DirectCast(KryptonButton2, Control), .Label = DirectCast(KryptonLabel4, Control)},
            New With {.Icon = DirectCast(KryptonButton4, Control), .Label = DirectCast(ManageContents, Control)},
            New With {.Icon = DirectCast(SpecialBtn, Control), .Label = DirectCast(SpecialLbl, Control)}
        }

        For Each item In menuItems
            If item.Icon.Visible Then
                item.Icon.Top = currentY
                item.Label.Top = currentY
                currentY += spacing
            End If
        Next
    End Sub

    Private Sub SpecialBtn_Click(sender As Object, e As EventArgs) Handles SpecialBtn.Click
        Select Case SpecialPath
            Case "AdminPanel"
                NavigateTo(New AdminPanel())
            Case "BecomeCreator"
                NavigateTo(New BecomeCreator())
        End Select
    End Sub


    Private Sub LabelCreatorArea_Click(sender As Object, e As EventArgs) Handles LabelCreatorArea.Click
        NavigateTo(New CreatorArea())
    End Sub

    Private Sub ButtonCreatorArea_Click(sender As Object, e As EventArgs) Handles ButtonCreatorArea.Click
        NavigateTo(New CreatorArea())
    End Sub

    Private Sub KryptonLabel1_Click(sender As Object, e As EventArgs) Handles KryptonLabel1.Click
        NavigateTo(New Home())
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        NavigateTo(New config())
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        NavigateTo(New signatures())
    End Sub

    Private Sub KryptonLabel4_Click(sender As Object, e As EventArgs) Handles KryptonLabel4.Click
        NavigateTo(New signatures())
    End Sub

    Private Sub AccountLbl_Click(sender As Object, e As EventArgs) Handles AccountLbl.Click
        NavigateTo(New config())
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        SessionManager.Logout()
        NavigateTo(New Login())
    End Sub

    Private Sub KryptonLabel2_Click(sender As Object, e As EventArgs) Handles KryptonLabel2.Click
        SessionManager.Logout()
        NavigateTo(New Login())
    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        NavigateTo(New Management)
    End Sub

    Private Sub ManageContents_Click(sender As Object, e As EventArgs) Handles ManageContents.Click
        NavigateTo(New Management)
    End Sub

    Private Sub SpecialLbl_Click(sender As Object, e As EventArgs) Handles SpecialLbl.Click
        If SpecialPath = "AdminPanel" Then
            NavigateTo(New AdminPanel())
        ElseIf SpecialPath = "BecomeCreator" Then
            NavigateTo(New BecomeCreator())
        End If
    End Sub
End Class

