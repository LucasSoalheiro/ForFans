<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homevb
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
        Login_btn = New Button()
        Cad_btn = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Login_btn
        ' 
        Login_btn.Location = New Point(201, 276)
        Login_btn.Name = "Login_btn"
        Login_btn.Size = New Size(75, 23)
        Login_btn.TabIndex = 0
        Login_btn.Text = "Login"
        Login_btn.UseVisualStyleBackColor = True
        ' 
        ' Cad_btn
        ' 
        Cad_btn.Location = New Point(499, 276)
        Cad_btn.Name = "Cad_btn"
        Cad_btn.Size = New Size(75, 23)
        Cad_btn.TabIndex = 1
        Cad_btn.Text = "Cadastro"
        Cad_btn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(296, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 15)
        Label1.TabIndex = 2
        Label1.Text = "Bem-vindo ao ForFans"
        ' 
        ' Homevb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Cad_btn)
        Controls.Add(Login_btn)
        Name = "Homevb"
        Text = "Homevb"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Login_btn As Button
    Friend WithEvents Cad_btn As Button
    Friend WithEvents Label1 As Label
End Class
