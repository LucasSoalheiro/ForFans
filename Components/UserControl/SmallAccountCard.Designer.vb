<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmallAccountCard
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
        AccountPicProfile = New Krypton.Toolkit.KryptonPictureBox()
        AccountName = New Krypton.Toolkit.KryptonLabel()
        DeactiveSubBtn = New Krypton.Toolkit.KryptonButton()
        CType(MainPanel, ComponentModel.ISupportInitialize).BeginInit()
        MainPanel.SuspendLayout()
        CType(AccountPicProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MainPanel
        ' 
        MainPanel.Controls.Add(DeactiveSubBtn)
        MainPanel.Controls.Add(AccountName)
        MainPanel.Controls.Add(AccountPicProfile)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(0, 0)
        MainPanel.Name = "MainPanel"
        MainPanel.Padding = New Padding(10)
        MainPanel.Size = New Size(800, 80)
        MainPanel.StateCommon.Color1 = Color.White
        MainPanel.TabIndex = 0
        ' 
        ' AccountPicProfile
        ' 
        AccountPicProfile.Location = New Point(15, 15)
        AccountPicProfile.Name = "AccountPicProfile"
        AccountPicProfile.Size = New Size(50, 50)
        AccountPicProfile.SizeMode = PictureBoxSizeMode.Zoom
        AccountPicProfile.TabIndex = 0
        AccountPicProfile.TabStop = False
        ' 
        ' AccountName
        ' 
        AccountName.Location = New Point(80, 25)
        AccountName.Name = "AccountName"
        AccountName.Size = New Size(232, 26)
        AccountName.StateCommon.ShortText.Color1 = Color.Black
        AccountName.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        AccountName.TabIndex = 1
        AccountName.Values.Text = "Creator Account Name"
        ' 
        ' DeactiveSubBtn
        ' 
        DeactiveSubBtn.Anchor = AnchorStyles.Right
        DeactiveSubBtn.Location = New Point(650, 20)
        DeactiveSubBtn.Name = "DeactiveSubBtn"
        DeactiveSubBtn.Size = New Size(130, 40)
        DeactiveSubBtn.StateCommon.Back.Color1 = Color.Transparent
        DeactiveSubBtn.StateCommon.Border.Color1 = Color.Firebrick
        DeactiveSubBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom Or Krypton.Toolkit.PaletteDrawBorders.Left Or Krypton.Toolkit.PaletteDrawBorders.Right
        DeactiveSubBtn.StateCommon.Border.Rounding = 20F
        DeactiveSubBtn.StateCommon.Content.ShortText.Color1 = Color.Firebrick
        DeactiveSubBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DeactiveSubBtn.TabIndex = 2
        DeactiveSubBtn.Values.Text = "Remover"
        ' 
        ' SmallAccountCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(MainPanel)
        Margin = New Padding(0, 0, 0, 10)
        Name = "SmallAccountCard"
        Size = New Size(800, 80)
        CType(MainPanel, ComponentModel.ISupportInitialize).EndInit()
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(AccountPicProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents AccountPicProfile As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents AccountName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DeactiveSubBtn As Krypton.Toolkit.KryptonButton

End Class
