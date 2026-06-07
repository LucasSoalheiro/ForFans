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
        HeaderPanel = New Panel()
        lblTitle = New Krypton.Toolkit.KryptonLabel()
        lblSubtitle = New Krypton.Toolkit.KryptonLabel()
        SignaturesLayout = New FlowLayoutPanel()
        HeaderPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' HeaderPanel
        ' 
        HeaderPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        HeaderPanel.Controls.Add(lblSubtitle)
        HeaderPanel.Controls.Add(lblTitle)
        HeaderPanel.Location = New Point(110, 0)
        HeaderPanel.Name = "HeaderPanel"
        HeaderPanel.Size = New Size(920, 120)
        HeaderPanel.TabIndex = 3
        ' 
        ' lblTitle
        ' 
        lblTitle.Location = New Point(40, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(300, 45)
        lblTitle.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(15), CByte(20), CByte(25))
        lblTitle.StateCommon.ShortText.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblTitle.TabIndex = 0
        lblTitle.Values.Text = "Assinaturas"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.Location = New Point(40, 65)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(400, 30)
        lblSubtitle.StateCommon.ShortText.Color1 = Color.Gray
        lblSubtitle.StateCommon.ShortText.Font = New Font("Segoe UI", 11F)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Values.Text = "Gerencie os criadores que você apoia"
        ' 
        ' SignaturesLayout
        ' 
        SignaturesLayout.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SignaturesLayout.AutoScroll = True
        SignaturesLayout.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(250))
        SignaturesLayout.FlowDirection = FlowDirection.TopDown
        SignaturesLayout.Location = New Point(110, 120)
        SignaturesLayout.Name = "SignaturesLayout"
        SignaturesLayout.Padding = New Padding(40, 0, 40, 0)
        SignaturesLayout.Size = New Size(920, 560)
        SignaturesLayout.TabIndex = 16
        SignaturesLayout.WrapContents = False
        ' 
        ' signatures
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1064, 734)
        Controls.Add(HeaderPanel)
        Controls.Add(SignaturesLayout)
        Name = "signatures"
        StartPosition = FormStartPosition.CenterScreen
        Text = "assinatura"
        Controls.SetChildIndex(SignaturesLayout, 0)
        Controls.SetChildIndex(HeaderPanel, 0)
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents lblTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSubtitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents SignaturesLayout As FlowLayoutPanel
End Class
