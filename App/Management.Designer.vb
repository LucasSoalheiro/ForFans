<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management
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
        FLContents = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' FLContents
        ' 
        FLContents.Location = New Point(98, 12)
        FLContents.Name = "FLContents"
        FLContents.Size = New Size(954, 710)
        FLContents.TabIndex = 2
        ' 
        ' Management
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 734)
        Controls.Add(FLContents)
        Name = "Management"
        Text = "Management"
        Controls.SetChildIndex(FLContents, 0)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FLContents As FlowLayoutPanel
End Class
