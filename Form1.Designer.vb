<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Nome_txt = New TextBox()
        Email_txt = New TextBox()
        Senha_txt = New TextBox()
        ConfirmacaoSenha_txt = New TextBox()
        Cpf_txt = New TextBox()
        Telefone_txt = New TextBox()
        DataNasc_txt = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(333, 310)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Nome_txt
        ' 
        Nome_txt.Location = New Point(238, 97)
        Nome_txt.Name = "Nome_txt"
        Nome_txt.Size = New Size(243, 23)
        Nome_txt.TabIndex = 1
        ' 
        ' Email_txt
        ' 
        Email_txt.Location = New Point(238, 126)
        Email_txt.Name = "Email_txt"
        Email_txt.Size = New Size(243, 23)
        Email_txt.TabIndex = 2
        ' 
        ' Senha_txt
        ' 
        Senha_txt.Location = New Point(238, 155)
        Senha_txt.Name = "Senha_txt"
        Senha_txt.Size = New Size(243, 23)
        Senha_txt.TabIndex = 3
        ' 
        ' ConfirmacaoSenha_txt
        ' 
        ConfirmacaoSenha_txt.Location = New Point(238, 184)
        ConfirmacaoSenha_txt.Name = "ConfirmacaoSenha_txt"
        ConfirmacaoSenha_txt.Size = New Size(243, 23)
        ConfirmacaoSenha_txt.TabIndex = 4
        ' 
        ' Cpf_txt
        ' 
        Cpf_txt.Location = New Point(238, 213)
        Cpf_txt.Name = "Cpf_txt"
        Cpf_txt.Size = New Size(243, 23)
        Cpf_txt.TabIndex = 5
        ' 
        ' Telefone_txt
        ' 
        Telefone_txt.Location = New Point(238, 242)
        Telefone_txt.Name = "Telefone_txt"
        Telefone_txt.Size = New Size(243, 23)
        Telefone_txt.TabIndex = 6
        ' 
        ' DataNasc_txt
        ' 
        DataNasc_txt.Location = New Point(238, 271)
        DataNasc_txt.Name = "DataNasc_txt"
        DataNasc_txt.Size = New Size(243, 23)
        DataNasc_txt.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataNasc_txt)
        Controls.Add(Telefone_txt)
        Controls.Add(Cpf_txt)
        Controls.Add(ConfirmacaoSenha_txt)
        Controls.Add(Senha_txt)
        Controls.Add(Email_txt)
        Controls.Add(Nome_txt)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Nome_txt As TextBox
    Friend WithEvents Email_txt As TextBox
    Friend WithEvents Senha_txt As TextBox
    Friend WithEvents ConfirmacaoSenha_txt As TextBox
    Friend WithEvents Cpf_txt As TextBox
    Friend WithEvents Telefone_txt As TextBox
    Friend WithEvents DataNasc_txt As TextBox

End Class
