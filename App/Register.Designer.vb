<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        UserEmail = New Krypton.Toolkit.KryptonTextBox()
        UserPassword = New Krypton.Toolkit.KryptonTextBox()
        RegiterBtn = New Krypton.Toolkit.KryptonButton()
        UserName = New Krypton.Toolkit.KryptonTextBox()
        LoginLink = New Krypton.Toolkit.KryptonLinkLabel()
        SuspendLayout()
        ' 
        ' UserEmail
        ' 
        UserEmail.Location = New Point(699, 206)
        UserEmail.Margin = New Padding(3, 2, 3, 2)
        UserEmail.Name = "UserEmail"
        UserEmail.Size = New Size(242, 23)
        UserEmail.TabIndex = 2
        UserEmail.Tag = ""
        ' 
        ' UserPassword
        ' 
        UserPassword.Location = New Point(699, 257)
        UserPassword.Margin = New Padding(3, 2, 3, 2)
        UserPassword.Name = "UserPassword"
        UserPassword.Size = New Size(242, 23)
        UserPassword.TabIndex = 3
        ' 
        ' RegiterBtn
        ' 
        RegiterBtn.Location = New Point(766, 344)
        RegiterBtn.Margin = New Padding(3, 2, 3, 2)
        RegiterBtn.Name = "RegiterBtn"
        RegiterBtn.Size = New Size(112, 23)
        RegiterBtn.TabIndex = 4
        RegiterBtn.Values.DropDownArrowColor = Color.Empty
        RegiterBtn.Values.Text = "Register Account"
        ' 
        ' UserName
        ' 
        UserName.Location = New Point(699, 144)
        UserName.Margin = New Padding(3, 2, 3, 2)
        UserName.Name = "UserName"
        UserName.Size = New Size(242, 23)
        UserName.TabIndex = 1
        ' 
        ' LoginLink
        ' 
        LoginLink.Location = New Point(872, 502)
        LoginLink.Name = "LoginLink"
        LoginLink.Size = New Size(149, 25)
        LoginLink.TabIndex = 5
        LoginLink.Values.Text = "i already have an account"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1033, 539)
        Controls.Add(LoginLink)
        Controls.Add(RegiterBtn)
        Controls.Add(UserPassword)
        Controls.Add(UserEmail)
        Controls.Add(UserName)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Register"
        Text = "Register"
        Controls.SetChildIndex(UserName, 0)
        Controls.SetChildIndex(UserEmail, 0)
        Controls.SetChildIndex(UserPassword, 0)
        Controls.SetChildIndex(RegiterBtn, 0)
        Controls.SetChildIndex(LoginLink, 0)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UserEmail As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents UserPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents RegiterBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents UserName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LoginLink As Krypton.Toolkit.KryptonLinkLabel
End Class
