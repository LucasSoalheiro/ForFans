<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadForm
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
        Cad_btn = New Button()
        Nome_txt = New TextBox()
        Email_txt = New TextBox()
        Senha_txt = New TextBox()
        ConfirmacaoSenha_txt = New TextBox()
        DataNasc_txt = New MaskedTextBox()
        Telefone_txt = New MaskedTextBox()
        Cpf_txt = New MaskedTextBox()
        ConteudoSenha_lbl = New Label()
        SuspendLayout()
        ' 
        ' Cad_btn
        ' 
        Cad_btn.Location = New Point(30, 279)
        Cad_btn.Name = "Cad_btn"
        Cad_btn.Size = New Size(75, 23)
        Cad_btn.TabIndex = 0
        Cad_btn.Text = "Cadastrar"
        Cad_btn.UseVisualStyleBackColor = True
        ' 
        ' Nome_txt
        ' 
        Nome_txt.Location = New Point(30, 67)
        Nome_txt.Name = "Nome_txt"
        Nome_txt.Size = New Size(243, 23)
        Nome_txt.TabIndex = 1
        ' 
        ' Email_txt
        ' 
        Email_txt.Location = New Point(30, 96)
        Email_txt.Name = "Email_txt"
        Email_txt.Size = New Size(243, 23)
        Email_txt.TabIndex = 2
        ' 
        ' Senha_txt
        ' 
        Senha_txt.Location = New Point(30, 125)
        Senha_txt.Name = "Senha_txt"
        Senha_txt.Size = New Size(243, 23)
        Senha_txt.TabIndex = 3
        ' 
        ' ConfirmacaoSenha_txt
        ' 
        ConfirmacaoSenha_txt.Location = New Point(30, 154)
        ConfirmacaoSenha_txt.Name = "ConfirmacaoSenha_txt"
        ConfirmacaoSenha_txt.Size = New Size(243, 23)
        ConfirmacaoSenha_txt.TabIndex = 4
        ' 
        ' DataNasc_txt
        ' 
        DataNasc_txt.Location = New Point(30, 241)
        DataNasc_txt.Mask = "00/00/0000"
        DataNasc_txt.Name = "DataNasc_txt"
        DataNasc_txt.Size = New Size(243, 23)
        DataNasc_txt.TabIndex = 8
        DataNasc_txt.ValidatingType = GetType(Date)
        ' 
        ' Telefone_txt
        ' 
        Telefone_txt.Location = New Point(30, 212)
        Telefone_txt.Mask = "(99) 00000-0000"
        Telefone_txt.Name = "Telefone_txt"
        Telefone_txt.Size = New Size(243, 23)
        Telefone_txt.TabIndex = 9
        ' 
        ' Cpf_txt
        ' 
        Cpf_txt.Location = New Point(30, 183)
        Cpf_txt.Mask = "000.000.000-00"
        Cpf_txt.Name = "Cpf_txt"
        Cpf_txt.Size = New Size(243, 23)
        Cpf_txt.TabIndex = 10
        ' 
        ' ConteudoSenha_lbl
        ' 
        ConteudoSenha_lbl.AutoSize = True
        ConteudoSenha_lbl.Location = New Point(279, 125)
        ConteudoSenha_lbl.MaximumSize = New Size(300, 200)
        ConteudoSenha_lbl.MinimumSize = New Size(300, 20)
        ConteudoSenha_lbl.Name = "ConteudoSenha_lbl"
        ConteudoSenha_lbl.Size = New Size(300, 20)
        ConteudoSenha_lbl.TabIndex = 11
        ' 
        ' CadForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ConteudoSenha_lbl)
        Controls.Add(Cpf_txt)
        Controls.Add(Telefone_txt)
        Controls.Add(DataNasc_txt)
        Controls.Add(ConfirmacaoSenha_txt)
        Controls.Add(Senha_txt)
        Controls.Add(Email_txt)
        Controls.Add(Nome_txt)
        Controls.Add(Cad_btn)
        Name = "CadForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cad_btn As Button
    Friend WithEvents Nome_txt As TextBox
    Friend WithEvents Email_txt As TextBox
    Friend WithEvents Senha_txt As TextBox
    Friend WithEvents ConfirmacaoSenha_txt As TextBox
    Friend WithEvents DataNasc_txt As MaskedTextBox
    Friend WithEvents Telefone_txt As MaskedTextBox
    Friend WithEvents Cpf_txt As MaskedTextBox
    Friend WithEvents ConteudoSenha_lbl As Label

End Class
