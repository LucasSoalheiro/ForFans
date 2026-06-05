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
        AccountPicProfile = New Krypton.Toolkit.KryptonPictureBox()
        AccountName = New Krypton.Toolkit.KryptonLabel()
        DeactiveSubBtn = New Krypton.Toolkit.KryptonButton()
        CType(AccountPicProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AccountPicProfile
        ' 
        AccountPicProfile.Location = New Point(3, 1)
        AccountPicProfile.Name = "AccountPicProfile"
        AccountPicProfile.Size = New Size(50, 50)
        AccountPicProfile.SizeMode = PictureBoxSizeMode.Zoom
        AccountPicProfile.TabIndex = 0
        AccountPicProfile.TabStop = False
        ' 
        ' AccountName
        ' 
        AccountName.Location = New Point(59, 3)
        AccountName.Name = "AccountName"
        AccountName.Size = New Size(232, 46)
        AccountName.TabIndex = 1
        AccountName.Values.Text = "Creator Account Name"
        ' 
        ' DeactiveSubBtn
        ' 
        DeactiveSubBtn.Location = New Point(297, 3)
        DeactiveSubBtn.Name = "DeactiveSubBtn"
        DeactiveSubBtn.Size = New Size(117, 46)
        DeactiveSubBtn.TabIndex = 2
        DeactiveSubBtn.Values.DropDownArrowColor = Color.Empty
        DeactiveSubBtn.Values.Text = "Deactive Sub"
        ' 
        ' SmallAccountCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DeactiveSubBtn)
        Controls.Add(AccountName)
        Controls.Add(AccountPicProfile)
        Name = "SmallAccountCard"
        Size = New Size(417, 52)
        CType(AccountPicProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AccountPicProfile As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents AccountName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DeactiveSubBtn As Krypton.Toolkit.KryptonButton

End Class
