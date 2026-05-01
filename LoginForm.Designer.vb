<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

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
        Email_txt = New TextBox()
        Senha_txt = New TextBox()
        Login_btn = New Button()
        SuspendLayout()
        ' 
        ' Email_txt
        ' 
        Email_txt.Location = New Point(68, 63)
        Email_txt.Name = "Email_txt"
        Email_txt.Size = New Size(179, 23)
        Email_txt.TabIndex = 0
        ' 
        ' Senha_txt
        ' 
        Senha_txt.Location = New Point(68, 112)
        Senha_txt.Name = "Senha_txt"
        Senha_txt.Size = New Size(179, 23)
        Senha_txt.TabIndex = 1
        ' 
        ' Login_btn
        ' 
        Login_btn.Location = New Point(70, 160)
        Login_btn.Name = "Login_btn"
        Login_btn.Size = New Size(75, 23)
        Login_btn.TabIndex = 2
        Login_btn.Text = "Login"
        Login_btn.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Login_btn)
        Controls.Add(Senha_txt)
        Controls.Add(Email_txt)
        Name = "LoginForm"
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Email_txt As TextBox
    Friend WithEvents Senha_txt As TextBox
    Friend WithEvents Login_btn As Button
End Class
