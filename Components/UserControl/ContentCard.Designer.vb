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
        ThumbnailPic = New Krypton.Toolkit.KryptonPictureBox()
        ContentTitle = New Krypton.Toolkit.KryptonLabel()
        ContentDescription = New Krypton.Toolkit.KryptonLabel()
        EditBtn = New Krypton.Toolkit.KryptonButton()
        DeleteBtn = New Krypton.Toolkit.KryptonButton()
        CType(ThumbnailPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ThumbnailPic
        ' 
        ThumbnailPic.Location = New Point(3, 84)
        ThumbnailPic.Name = "ThumbnailPic"
        ThumbnailPic.Size = New Size(451, 185)
        ThumbnailPic.SizeMode = PictureBoxSizeMode.Zoom
        ThumbnailPic.TabIndex = 0
        ThumbnailPic.TabStop = False
        ' 
        ' ContentTitle
        ' 
        ContentTitle.Location = New Point(3, 3)
        ContentTitle.Name = "ContentTitle"
        ContentTitle.Size = New Size(225, 25)
        ContentTitle.TabIndex = 1
        ContentTitle.Values.Text = "Title"
        ' 
        ' ContentDescription
        ' 
        ContentDescription.Location = New Point(3, 34)
        ContentDescription.Name = "ContentDescription"
        ContentDescription.Size = New Size(451, 44)
        ContentDescription.TabIndex = 2
        ContentDescription.Values.Text = "Description"
        ' 
        ' EditBtn
        ' 
        EditBtn.Location = New Point(234, 3)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(90, 25)
        EditBtn.TabIndex = 3
        EditBtn.Values.DropDownArrowColor = Color.Empty
        EditBtn.Values.Text = "Editar"
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.Location = New Point(364, 3)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(90, 25)
        DeleteBtn.TabIndex = 4
        DeleteBtn.Values.DropDownArrowColor = Color.Empty
        DeleteBtn.Values.Text = "Deleter"
        ' 
        ' ContentCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DeleteBtn)
        Controls.Add(EditBtn)
        Controls.Add(ContentDescription)
        Controls.Add(ContentTitle)
        Controls.Add(ThumbnailPic)
        Name = "ContentCard"
        Size = New Size(457, 272)
        CType(ThumbnailPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ThumbnailPic As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents ContentTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ContentDescription As Krypton.Toolkit.KryptonLabel
    Friend WithEvents EditBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents DeleteBtn As Krypton.Toolkit.KryptonButton

End Class
