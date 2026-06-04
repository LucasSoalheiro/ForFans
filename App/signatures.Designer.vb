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
        SuspendLayout()
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(485, 29)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(161, 26)
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel1.TabIndex = 13
        KryptonLabel1.Values.Text = "Minhas Assinaturas"
        ' 
        ' signatures
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 734)
        Controls.Add(KryptonLabel1)
        Name = "signatures"
        Text = "assinatura"
        Controls.SetChildIndex(KryptonLabel1, 0)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
End Class
