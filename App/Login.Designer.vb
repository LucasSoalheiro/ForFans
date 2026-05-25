<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits SmallForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LoginEmail = New Krypton.Toolkit.KryptonTextBox()
        LoginPassword = New Krypton.Toolkit.KryptonTextBox()
        LoginBtn = New Krypton.Toolkit.KryptonButton()
        CreateAccountLink = New Krypton.Toolkit.KryptonLinkLabel()
        SuspendLayout()
        ' 
        ' LoginEmail
        ' 
        LoginEmail.Location = New Point(716, 223)
        LoginEmail.Name = "LoginEmail"
        LoginEmail.Size = New Size(199, 23)
        LoginEmail.TabIndex = 1
        ' 
        ' LoginPassword
        ' 
        LoginPassword.Location = New Point(716, 275)
        LoginPassword.Name = "LoginPassword"
        LoginPassword.Size = New Size(199, 23)
        LoginPassword.TabIndex = 2
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Location = New Point(772, 333)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(90, 25)
        LoginBtn.TabIndex = 3
        LoginBtn.Values.DropDownArrowColor = Color.Empty
        LoginBtn.Values.Text = "Login"
        ' 
        ' CreateAccountLink
        ' 
        CreateAccountLink.Location = New Point(883, 502)
        CreateAccountLink.Name = "CreateAccountLink"
        CreateAccountLink.Size = New Size(138, 25)
        CreateAccountLink.TabIndex = 4
        CreateAccountLink.Values.Text = "i don't have an account"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1033, 539)
        Controls.Add(CreateAccountLink)
        Controls.Add(LoginBtn)
        Controls.Add(LoginPassword)
        Controls.Add(LoginEmail)
        Name = "Login"
        Text = "Login"
        Controls.SetChildIndex(LoginEmail, 0)
        Controls.SetChildIndex(LoginPassword, 0)
        Controls.SetChildIndex(LoginBtn, 0)
        Controls.SetChildIndex(CreateAccountLink, 0)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginEmail As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LoginPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LoginBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents CreateAccountLink As Krypton.Toolkit.KryptonLinkLabel
End Class
