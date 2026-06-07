<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmallCard
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
        ContentTitle = New Krypton.Toolkit.KryptonLabel()
        Thumbnail = New Krypton.Toolkit.KryptonPictureBox()
        CType(MainPanel, ComponentModel.ISupportInitialize).BeginInit()
        MainPanel.SuspendLayout()
        CType(Thumbnail, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MainPanel
        ' 
        MainPanel.Controls.Add(Thumbnail)
        MainPanel.Controls.Add(ContentTitle)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(0, 0)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(400, 300)
        MainPanel.StateCommon.Color1 = Color.White
        MainPanel.TabIndex = 0
        ' 
        ' ContentTitle
        ' 
        ContentTitle.Location = New Point(10, 260)
        ContentTitle.Name = "ContentTitle"
        ContentTitle.Size = New Size(380, 30)
        ContentTitle.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(15), CByte(20), CByte(25))
        ContentTitle.StateCommon.ShortText.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        ContentTitle.TabIndex = 0
        ContentTitle.Values.Text = "Title"
        ' 
        ' Thumbnail
        ' 
        Thumbnail.Location = New Point(10, 10)
        Thumbnail.Name = "Thumbnail"
        Thumbnail.Size = New Size(380, 240)
        Thumbnail.SizeMode = PictureBoxSizeMode.Zoom
        Thumbnail.TabIndex = 1
        Thumbnail.TabStop = False
        ' 
        ' SmallCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(MainPanel)
        Margin = New Padding(0, 0, 15, 15)
        Name = "SmallCard"
        Size = New Size(400, 300)
        CType(MainPanel, ComponentModel.ISupportInitialize).EndInit()
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(Thumbnail, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents ContentTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Thumbnail As Krypton.Toolkit.KryptonPictureBox

End Class
