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
        nome_txt = New TextBox()
        email_txt = New TextBox()
        senha_txt = New TextBox()
        confirmacaoSenha_txt = New TextBox()
        cpf_txt = New TextBox()
        telefone_txt = New TextBox()
        dataNasc_txt = New TextBox()
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
        ' nome_txt
        ' 
        nome_txt.Location = New Point(238, 97)
        nome_txt.Name = "nome_txt"
        nome_txt.Size = New Size(243, 23)
        nome_txt.TabIndex = 1
        ' 
        ' email_txt
        ' 
        email_txt.Location = New Point(238, 126)
        email_txt.Name = "email_txt"
        email_txt.Size = New Size(243, 23)
        email_txt.TabIndex = 2
        ' 
        ' senha_txt
        ' 
        senha_txt.Location = New Point(238, 155)
        senha_txt.Name = "senha_txt"
        senha_txt.Size = New Size(243, 23)
        senha_txt.TabIndex = 3
        ' 
        ' confirmacaoSenha_txt
        ' 
        confirmacaoSenha_txt.Location = New Point(238, 184)
        confirmacaoSenha_txt.Name = "confirmacaoSenha_txt"
        confirmacaoSenha_txt.Size = New Size(243, 23)
        confirmacaoSenha_txt.TabIndex = 4
        ' 
        ' cpf_txt
        ' 
        cpf_txt.Location = New Point(238, 213)
        cpf_txt.Name = "cpf_txt"
        cpf_txt.Size = New Size(243, 23)
        cpf_txt.TabIndex = 5
        ' 
        ' telefone_txt
        ' 
        telefone_txt.Location = New Point(238, 242)
        telefone_txt.Name = "telefone_txt"
        telefone_txt.Size = New Size(243, 23)
        telefone_txt.TabIndex = 6
        ' 
        ' dataNasc_txt
        ' 
        dataNasc_txt.Location = New Point(238, 271)
        dataNasc_txt.Name = "dataNasc_txt"
        dataNasc_txt.Size = New Size(243, 23)
        dataNasc_txt.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dataNasc_txt)
        Controls.Add(telefone_txt)
        Controls.Add(cpf_txt)
        Controls.Add(confirmacaoSenha_txt)
        Controls.Add(senha_txt)
        Controls.Add(email_txt)
        Controls.Add(nome_txt)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents nome_txt As TextBox
    Friend WithEvents email_txt As TextBox
    Friend WithEvents senha_txt As TextBox
    Friend WithEvents confirmacaoSenha_txt As TextBox
    Friend WithEvents cpf_txt As TextBox
    Friend WithEvents telefone_txt As TextBox
    Friend WithEvents dataNasc_txt As TextBox

End Class
