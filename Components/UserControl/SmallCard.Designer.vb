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
        ContentTitle = New Krypton.Toolkit.KryptonLabel()
        Thumbnail = New Krypton.Toolkit.KryptonPictureBox()
        CType(Thumbnail, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ContentTitle
        ' 
        ContentTitle.Location = New Point(3, 3)
        ContentTitle.Name = "ContentTitle"
        ContentTitle.Size = New Size(90, 25)
        ContentTitle.TabIndex = 0
        ContentTitle.Values.Text = "Title"
        ' 
        ' Thumbnail
        ' 
        Thumbnail.Location = New Point(3, 31)
        Thumbnail.Name = "Thumbnail"
        Thumbnail.Size = New Size(437, 225)
        Thumbnail.SizeMode = PictureBoxSizeMode.Zoom
        Thumbnail.TabIndex = 1
        Thumbnail.TabStop = False
        ' 
        ' SmallCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Thumbnail)
        Controls.Add(ContentTitle)
        Name = "SmallCard"
        Size = New Size(443, 259)
        CType(Thumbnail, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContentTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Thumbnail As Krypton.Toolkit.KryptonPictureBox

End Class
