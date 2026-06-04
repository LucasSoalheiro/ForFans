<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signatures
    Inherits FormBase

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
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        KryptonButton1 = New Krypton.Toolkit.KryptonButton()
        SuspendLayout()
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(357, 26)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(316, 49)
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel1.TabIndex = 13
        KryptonLabel1.Values.Text = "Minhas Assinaturas"
        ' 
        ' KryptonButton1
        ' 
        KryptonButton1.Location = New Point(357, 113)
        KryptonButton1.Name = "KryptonButton1"
        KryptonButton1.Size = New Size(121, 31)
        KryptonButton1.StateCommon.Back.Color1 = Color.Blue
        KryptonButton1.StateCommon.Border.Rounding = 7F
        KryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White
        KryptonButton1.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonButton1.TabIndex = 14
        KryptonButton1.Values.DropDownArrowColor = Color.Empty
        KryptonButton1.Values.Text = "Ativas"
        ' 
        ' signatures
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 734)
        Controls.Add(KryptonButton1)
        Controls.Add(KryptonLabel1)
        Name = "signatures"
        StartPosition = FormStartPosition.CenterScreen
        Text = "assinatura"
        Controls.SetChildIndex(KryptonLabel1, 0)
        Controls.SetChildIndex(KryptonButton1, 0)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonButton1 As Krypton.Toolkit.KryptonButton
End Class
