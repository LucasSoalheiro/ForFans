<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Content
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Content))
        ContentPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        pnlPlayerContainer = New Krypton.Toolkit.KryptonPanel()
        lblTitle = New Krypton.Toolkit.KryptonLabel()
        lblDescription = New Krypton.Toolkit.KryptonLabel()
        btnBack = New Krypton.Toolkit.KryptonButton()
        btnLike = New Krypton.Toolkit.KryptonButton()
        pnlDescription = New Krypton.Toolkit.KryptonPanel()
        CType(ContentPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(pnlPlayerContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        pnlPlayerContainer.SuspendLayout()
        CType(pnlDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        pnlDescription.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContentPlayer
        ' 
        ContentPlayer.Dock = DockStyle.Fill
        ContentPlayer.Enabled = True
        ContentPlayer.Location = New Point(0, 0)
        ContentPlayer.Name = "ContentPlayer"
        ContentPlayer.OcxState = CType(resources.GetObject("ContentPlayer.OcxState"), AxHost.State)
        ContentPlayer.Size = New Size(800, 450)
        ContentPlayer.TabIndex = 2
        ' 
        ' pnlPlayerContainer
        ' 
        pnlPlayerContainer.Anchor = System.Windows.Forms.AnchorStyles.Top
        pnlPlayerContainer.Controls.Add(ContentPlayer)
        pnlPlayerContainer.Location = New System.Drawing.Point(132, 100)
        pnlPlayerContainer.Name = "pnlPlayerContainer"
        pnlPlayerContainer.Padding = New System.Windows.Forms.Padding(2)
        pnlPlayerContainer.Size = New System.Drawing.Size(804, 454)
        pnlPlayerContainer.StateCommon.Color1 = System.Drawing.Color.Black
        pnlPlayerContainer.TabIndex = 3
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        lblTitle.Location = New System.Drawing.Point(132, 40)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New System.Drawing.Size(147, 40)
        lblTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 30, 30)
        lblTitle.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.0F, System.Drawing.FontStyle.Bold)
        lblTitle.TabIndex = 4
        lblTitle.Values.Text = "Video Title"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = False
        lblDescription.Dock = System.Windows.Forms.DockStyle.Fill
        lblDescription.Location = New System.Drawing.Point(15, 15)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New System.Drawing.Size(774, 70)
        lblDescription.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(80, 80, 80)
        lblDescription.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 11.0F)
        lblDescription.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True
        lblDescription.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Near
        lblDescription.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        lblDescription.TabIndex = 5
        lblDescription.Values.Text = "Description goes here..."
        ' 
        ' pnlDescription
        ' 
        pnlDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        pnlDescription.Controls.Add(lblDescription)
        pnlDescription.Location = New System.Drawing.Point(132, 570)
        pnlDescription.Name = "pnlDescription"
        pnlDescription.Padding = New System.Windows.Forms.Padding(15)
        pnlDescription.Size = New System.Drawing.Size(804, 100)
        pnlDescription.StateCommon.Color1 = System.Drawing.Color.White
        pnlDescription.TabIndex = 6
        ' 
        ' btnBack
        ' 
        btnBack.Location = New System.Drawing.Point(25, 25)
        btnBack.Name = "btnBack"
        btnBack.Size = New System.Drawing.Size(40, 40)
        btnBack.StateCommon.Back.Color1 = System.Drawing.Color.White
        btnBack.StateCommon.Back.Color2 = System.Drawing.Color.White
        btnBack.StateCommon.Border.Rounding = 20
        btnBack.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        btnBack.TabIndex = 7
        btnBack.Values.Text = "←"
        ' 
        ' btnLike
        ' 
        btnLike.Anchor = System.Windows.Forms.AnchorStyles.Top
        btnLike.Location = New System.Drawing.Point(836, 40)
        btnLike.Name = "btnLike"
        btnLike.Size = New System.Drawing.Size(100, 40)
        btnLike.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(235, 243, 255)
        btnLike.StateCommon.Border.Rounding = 20
        btnLike.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(4, 41, 84)
        btnLike.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Bold)
        btnLike.TabIndex = 8
        btnLike.Values.Text = "❤ Like"

        ' 
        ' Content
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(247, 249, 250)
        ClientSize = New Size(1064, 734)
        Controls.Add(btnLike)
        Controls.Add(btnBack)
        Controls.Add(pnlDescription)
        Controls.Add(lblTitle)
        Controls.Add(pnlPlayerContainer)
        Name = "Content"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Content"
        Controls.SetChildIndex(pnlPlayerContainer, 0)
        Controls.SetChildIndex(lblTitle, 0)
        Controls.SetChildIndex(pnlDescription, 0)
        Controls.SetChildIndex(btnBack, 0)
        Controls.SetChildIndex(btnLike, 0)
        CType(ContentPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(pnlPlayerContainer, System.ComponentModel.ISupportInitialize).EndInit()
        pnlPlayerContainer.ResumeLayout(False)
        CType(pnlDescription, System.ComponentModel.ISupportInitialize).EndInit()
        pnlDescription.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContentPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents pnlPlayerContainer As Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDescription As Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBack As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnLike As Krypton.Toolkit.KryptonButton
    Friend WithEvents pnlDescription As Krypton.Toolkit.KryptonPanel
End Class
