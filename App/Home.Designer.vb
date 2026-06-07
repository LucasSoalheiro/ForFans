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
        HeaderPanel = New Panel()
        lblHomeTitle = New Krypton.Toolkit.KryptonLabel()
        HeaderPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' FContainer
        ' 
        FContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FContainer.AutoScroll = True
        FContainer.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(250))
        FContainer.FlowDirection = FlowDirection.TopDown
        FContainer.Location = New Point(110, 80)
        FContainer.Name = "FContainer"
        FContainer.Padding = New Padding(40, 0, 40, 0)
        FContainer.Size = New Size(920, 600)
        FContainer.TabIndex = 2
        FContainer.WrapContents = False
        ' 
        ' HeaderPanel
        ' 
        HeaderPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        HeaderPanel.Controls.Add(lblHomeTitle)
        HeaderPanel.Location = New Point(110, 0)
        HeaderPanel.Name = "HeaderPanel"
        HeaderPanel.Size = New Size(920, 80)
        HeaderPanel.TabIndex = 3
        ' 
        ' lblHomeTitle
        ' 
        lblHomeTitle.Location = New Point(40, 15)
        lblHomeTitle.Name = "lblHomeTitle"
        lblHomeTitle.Size = New Size(125, 45)
        lblHomeTitle.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(15), CByte(20), CByte(25))
        lblHomeTitle.StateCommon.ShortText.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblHomeTitle.TabIndex = 0
        lblHomeTitle.Values.Text = "Início"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1064, 734)
        Controls.Add(HeaderPanel)
        Controls.Add(FContainer)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        Controls.SetChildIndex(FContainer, 0)
        Controls.SetChildIndex(HeaderPanel, 0)
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents FContainer As FlowLayoutPanel
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents lblHomeTitle As Krypton.Toolkit.KryptonLabel
End Class
