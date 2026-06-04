<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        FContainer = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' FContainer
        ' 
        FContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FContainer.AutoScroll = True
        FContainer.BackColor = Color.LightSteelBlue
        FContainer.Location = New Point(259, 0)
        FContainer.Name = "FContainer"
        FContainer.Size = New Size(805, 677)
        FContainer.TabIndex = 2
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        ClientSize = New Size(1064, 734)
        Controls.Add(FContainer)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        Controls.SetChildIndex(FContainer, 0)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FContainer As FlowLayoutPanel
End Class
