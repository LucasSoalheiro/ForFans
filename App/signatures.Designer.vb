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
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        SignaturesLayout = New FlowLayoutPanel()
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
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(357, 82)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(360, 31)
        KryptonLabel2.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel2.TabIndex = 15
        KryptonLabel2.Values.Text = "Gerencie os criadores que você atualmete apoia"
        ' 
        ' SignaturesLayout
        ' 
        SignaturesLayout.Location = New Point(235, 170)
        SignaturesLayout.Name = "SignaturesLayout"
        SignaturesLayout.Size = New Size(678, 564)
        SignaturesLayout.TabIndex = 16
        ' 
        ' signatures
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(250))
        ClientSize = New Size(1064, 734)
        Controls.Add(SignaturesLayout)
        Controls.Add(KryptonLabel2)
        Controls.Add(KryptonLabel1)
        Name = "signatures"
        StartPosition = FormStartPosition.CenterScreen
        Text = "assinatura"
        Controls.SetChildIndex(KryptonLabel1, 0)
        Controls.SetChildIndex(KryptonLabel2, 0)
        Controls.SetChildIndex(SignaturesLayout, 0)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents SignaturesLayout As FlowLayoutPanel
End Class
