<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentCard
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
        ThumbnailPic = New Krypton.Toolkit.KryptonPictureBox()
        ContentTitle = New Krypton.Toolkit.KryptonLabel()
        ContentDescription = New Krypton.Toolkit.KryptonLabel()
        EditBtn = New Krypton.Toolkit.KryptonButton()
        DeleteBtn = New Krypton.Toolkit.KryptonButton()
        CType(MainPanel, ComponentModel.ISupportInitialize).BeginInit()
        MainPanel.SuspendLayout()
        CType(ThumbnailPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MainPanel
        ' 
        MainPanel.Controls.Add(DeleteBtn)
        MainPanel.Controls.Add(EditBtn)
        MainPanel.Controls.Add(ContentDescription)
        MainPanel.Controls.Add(ContentTitle)
        MainPanel.Controls.Add(ThumbnailPic)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(0, 0)
        MainPanel.Name = "MainPanel"
        MainPanel.Padding = New Padding(15)
        MainPanel.Size = New Size(800, 160)
        MainPanel.StateCommon.Color1 = Color.White
        MainPanel.TabIndex = 0
        ' 
        ' ThumbnailPic
        ' 
        ThumbnailPic.Location = New Point(15, 15)
        ThumbnailPic.Name = "ThumbnailPic"
        ThumbnailPic.Size = New Size(220, 130)
        ThumbnailPic.SizeMode = PictureBoxSizeMode.Zoom
        ThumbnailPic.TabIndex = 0
        ThumbnailPic.TabStop = False
        ' 
        ' ContentTitle
        ' 
        ContentTitle.Location = New Point(250, 15)
        ContentTitle.Name = "ContentTitle"
        ContentTitle.Size = New Size(380, 26)
        ContentTitle.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(15), CByte(20), CByte(25))
        ContentTitle.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ContentTitle.TabIndex = 1
        ContentTitle.Values.Text = "Title"
        ' 
        ' ContentDescription
        ' 
        ContentDescription.Location = New Point(250, 45)
        ContentDescription.Name = "ContentDescription"
        ContentDescription.Size = New Size(380, 50)
        ContentDescription.StateCommon.ShortText.Color1 = Color.Gray
        ContentDescription.StateCommon.ShortText.Font = New Font("Segoe UI", 10F)
        ContentDescription.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True
        ContentDescription.TabIndex = 2
        ContentDescription.Values.Text = "Description"
        ' 
        ' EditBtn
        ' 
        EditBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        EditBtn.Location = New Point(680, 20)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(100, 35)
        EditBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(29), CByte(161), CByte(242))
        EditBtn.StateCommon.Border.Rounding = 10F
        EditBtn.StateCommon.Content.ShortText.Color1 = Color.White
        EditBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        EditBtn.TabIndex = 3
        EditBtn.Values.Text = "Editar"
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DeleteBtn.Location = New Point(680, 65)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(100, 35)
        DeleteBtn.StateCommon.Back.Color1 = Color.Firebrick
        DeleteBtn.StateCommon.Border.Rounding = 10F
        DeleteBtn.StateCommon.Content.ShortText.Color1 = Color.White
        DeleteBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DeleteBtn.TabIndex = 4
        DeleteBtn.Values.Text = "Excluir"
        ' 
        ' ContentCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(MainPanel)
        Margin = New Padding(0, 0, 0, 15)
        Name = "ContentCard"
        Size = New Size(800, 160)
        CType(MainPanel, ComponentModel.ISupportInitialize).EndInit()
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(ThumbnailPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents ThumbnailPic As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents ContentTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ContentDescription As Krypton.Toolkit.KryptonLabel
    Friend WithEvents EditBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents DeleteBtn As Krypton.Toolkit.KryptonButton
End Class
