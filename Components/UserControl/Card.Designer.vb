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
        TitleContent = New Krypton.Toolkit.KryptonLabel()
        CreatorNamelbl = New Krypton.Toolkit.KryptonLabel()
        ThumbnailImage = New Krypton.Toolkit.KryptonPictureBox()
        CType(ThumbnailImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TitleContent
        ' 
        TitleContent.Location = New Point(0, 47)
        TitleContent.Name = "TitleContent"
        TitleContent.Size = New Size(535, 41)
        TitleContent.TabIndex = 0
        TitleContent.Values.Text = "Tiitle of Content"
        ' 
        ' CreatorNamelbl
        ' 
        CreatorNamelbl.Location = New Point(-1, 3)
        CreatorNamelbl.Name = "CreatorNamelbl"
        CreatorNamelbl.Size = New Size(174, 38)
        CreatorNamelbl.TabIndex = 1
        CreatorNamelbl.Values.Text = "Creator of Content"
        ' 
        ' ThumbnailImage
        ' 
        ThumbnailImage.Location = New Point(3, 94)
        ThumbnailImage.Name = "ThumbnailImage"
        ThumbnailImage.Size = New Size(610, 248)
        ThumbnailImage.TabIndex = 2
        ThumbnailImage.TabStop = False
        ' 
        ' Card
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ThumbnailImage)
        Controls.Add(CreatorNamelbl)
        Controls.Add(TitleContent)
        Name = "Card"
        Size = New Size(616, 345)
        CType(ThumbnailImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TitleContent As Krypton.Toolkit.KryptonLabel
    Friend WithEvents CreatorNamelbl As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPictureBox1 As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents ThumbnailImage As Krypton.Toolkit.KryptonPictureBox

End Class
