<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Card
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        MainPanel = New Krypton.Toolkit.KryptonPanel()
        TitleContent = New Krypton.Toolkit.KryptonLabel()
        CreatorNamelbl = New Krypton.Toolkit.KryptonLabel()
        ThumbnailImage = New Krypton.Toolkit.KryptonPictureBox()
        AccountPicture = New Krypton.Toolkit.KryptonPictureBox()
        CType(MainPanel, ComponentModel.ISupportInitialize).BeginInit()
        MainPanel.SuspendLayout()
        CType(ThumbnailImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(AccountPicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MainPanel
        ' 
        MainPanel.Controls.Add(TitleContent)
        MainPanel.Controls.Add(CreatorNamelbl)
        MainPanel.Controls.Add(ThumbnailImage)
        MainPanel.Controls.Add(AccountPicture)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(0, 0)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(800, 520)
        MainPanel.StateCommon.Color1 = Color.White
        MainPanel.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        MainPanel.TabIndex = 0
        ' 
        ' TitleContent
        ' 
        TitleContent.Location = New Point(80, 40)
        TitleContent.Name = "TitleContent"
        TitleContent.Size = New Size(680, 26)
        TitleContent.StateCommon.ShortText.Color1 = Color.Black
        TitleContent.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Regular)
        TitleContent.TabIndex = 0
        TitleContent.Values.Text = "Tiitle of Content"
        ' 
        ' CreatorNamelbl
        ' 
        CreatorNamelbl.Location = New Point(80, 15)
        CreatorNamelbl.Name = "CreatorNamelbl"
        CreatorNamelbl.Size = New Size(149, 26)
        CreatorNamelbl.StateCommon.ShortText.Color1 = Color.Black
        CreatorNamelbl.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        CreatorNamelbl.TabIndex = 1
        CreatorNamelbl.Values.Text = "Creator Name"
        ' 
        ' ThumbnailImage
        ' 
        ThumbnailImage.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        ThumbnailImage.Location = New Point(80, 80)
        ThumbnailImage.Name = "ThumbnailImage"
        ThumbnailImage.Size = New Size(680, 400)
        ThumbnailImage.SizeMode = PictureBoxSizeMode.Zoom
        ThumbnailImage.TabIndex = 2
        ThumbnailImage.TabStop = False
        ' 
        ' AccountPicture
        ' 
        AccountPicture.Location = New Point(20, 15)
        AccountPicture.Name = "AccountPicture"
        AccountPicture.Size = New Size(50, 50)
        AccountPicture.SizeMode = PictureBoxSizeMode.Zoom
        AccountPicture.TabIndex = 3
        AccountPicture.TabStop = False
        ' 
        ' Card
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(MainPanel)
        Margin = New Padding(0, 0, 0, 20)
        Name = "Card"
        Size = New Size(800, 520)
        CType(MainPanel, ComponentModel.ISupportInitialize).EndInit()
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(ThumbnailImage, ComponentModel.ISupportInitialize).EndInit()
        CType(AccountPicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TitleContent As Krypton.Toolkit.KryptonLabel
    Friend WithEvents CreatorNamelbl As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ThumbnailImage As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents AccountPicture As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents MainPanel As Krypton.Toolkit.KryptonPanel

End Class
