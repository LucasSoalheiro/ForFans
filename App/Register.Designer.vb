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
        UserName = New Krypton.Toolkit.KryptonTextBox()
        UserEmail = New Krypton.Toolkit.KryptonTextBox()
        UserPassword = New Krypton.Toolkit.KryptonTextBox()
        RegiterBtn = New Krypton.Toolkit.KryptonButton()
        SuspendLayout()
        ' 
        ' UserName
        ' 
        UserName.Location = New Point(799, 192)
        UserName.Name = "UserName"
        UserName.Size = New Size(276, 27)
        UserName.TabIndex = 1
        ' 
        ' UserEmail
        ' 
        UserEmail.Location = New Point(799, 274)
        UserEmail.Name = "UserEmail"
        UserEmail.Size = New Size(276, 27)
        UserEmail.TabIndex = 2
        UserEmail.Tag = ""
        ' 
        ' UserPassword
        ' 
        UserPassword.Location = New Point(799, 343)
        UserPassword.Name = "UserPassword"
        UserPassword.Size = New Size(276, 27)
        UserPassword.TabIndex = 3
        ' 
        ' RegiterBtn
        ' 
        RegiterBtn.Location = New Point(875, 458)
        RegiterBtn.Name = "RegiterBtn"
        RegiterBtn.Size = New Size(128, 31)
        RegiterBtn.TabIndex = 4
        RegiterBtn.Values.DropDownArrowColor = Color.Empty
        RegiterBtn.Values.Text = "Register Account"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1179, 711)
        Controls.Add(RegiterBtn)
        Controls.Add(UserPassword)
        Controls.Add(UserEmail)
        Controls.Add(UserName)
        Name = "Register"
        Text = "Register"
        Controls.SetChildIndex(UserName, 0)
        Controls.SetChildIndex(UserEmail, 0)
        Controls.SetChildIndex(UserPassword, 0)
        Controls.SetChildIndex(RegiterBtn, 0)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UserName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents UserEmail As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents UserPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents RegiterBtn As Krypton.Toolkit.KryptonButton
End Class
