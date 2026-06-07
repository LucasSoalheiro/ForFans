<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatorPage
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


    Friend WithEvents CreatorPicture As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents CreatorName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents SubscribersNumber As Krypton.Toolkit.KryptonLabel

    Private Sub InitializeComponent()
        ProfileHeader = New Panel()
        CreatorPicture = New Krypton.Toolkit.KryptonPictureBox()
        CreatorName = New Krypton.Toolkit.KryptonLabel()
        SubscribersNumber = New Krypton.Toolkit.KryptonLabel()
        CreatorBio = New Krypton.Toolkit.KryptonLabel()
        SubscribeBtn = New Krypton.Toolkit.KryptonButton()
        FPCreatorsContent = New FlowLayoutPanel()
        ProfileHeader.SuspendLayout()
        CType(CreatorPicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProfileHeader
        ' 
        ProfileHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ProfileHeader.BackColor = Color.White
        ProfileHeader.Controls.Add(SubscribeBtn)
        ProfileHeader.Controls.Add(CreatorBio)
        ProfileHeader.Controls.Add(SubscribersNumber)
        ProfileHeader.Controls.Add(CreatorName)
        ProfileHeader.Controls.Add(CreatorPicture)
        ProfileHeader.Location = New Point(110, 0)
        ProfileHeader.Name = "ProfileHeader"
        ProfileHeader.Padding = New Padding(20)
        ProfileHeader.Size = New Size(920, 240)
        ProfileHeader.TabIndex = 8
        ' 
        ' CreatorPicture
        ' 
        CreatorPicture.Location = New Point(40, 30)
        CreatorPicture.Name = "CreatorPicture"
        CreatorPicture.Size = New Size(160, 160)
        CreatorPicture.SizeMode = PictureBoxSizeMode.Zoom
        CreatorPicture.TabIndex = 2
        CreatorPicture.TabStop = False
        ' 
        ' CreatorName
        ' 
        CreatorName.Location = New Point(220, 35)
        CreatorName.Name = "CreatorName"
        CreatorName.Size = New Size(400, 45)
        CreatorName.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(15), CByte(20), CByte(25))
        CreatorName.StateCommon.ShortText.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        CreatorName.TabIndex = 3
        CreatorName.Values.Text = "Creator Name"
        ' 
        ' SubscribersNumber
        ' 
        SubscribersNumber.Location = New Point(220, 85)
        SubscribersNumber.Name = "SubscribersNumber"
        SubscribersNumber.Size = New Size(194, 25)
        SubscribersNumber.StateCommon.ShortText.Color1 = Color.Gray
        SubscribersNumber.StateCommon.ShortText.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        SubscribersNumber.TabIndex = 4
        SubscribersNumber.Values.Text = "Number of Subscribers"
        ' 
        ' CreatorBio
        ' 
        CreatorBio.Location = New Point(220, 120)
        CreatorBio.Name = "CreatorBio"
        CreatorBio.Size = New Size(650, 60)
        CreatorBio.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(15), CByte(20), CByte(25))
        CreatorBio.StateCommon.ShortText.Font = New Font("Segoe UI", 11F)
        CreatorBio.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True
        CreatorBio.TabIndex = 5
        CreatorBio.Values.Text = "Bio of the creator"
        ' 
        ' SubscribeBtn
        ' 
        SubscribeBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SubscribeBtn.Location = New Point(740, 40)
        SubscribeBtn.Name = "SubscribeBtn"
        SubscribeBtn.Size = New Size(140, 40)
        SubscribeBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(29), CByte(161), CByte(242))
        SubscribeBtn.StateCommon.Border.Rounding = 20F
        SubscribeBtn.StateCommon.Content.ShortText.Color1 = Color.White
        SubscribeBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        SubscribeBtn.TabIndex = 6
        SubscribeBtn.Values.Text = "Inscrever-se"
        ' 
        ' FPCreatorsContent
        ' 
        FPCreatorsContent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FPCreatorsContent.AutoScroll = True
        FPCreatorsContent.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(250))
        FPCreatorsContent.Location = New Point(110, 240)
        FPCreatorsContent.Name = "FPCreatorsContent"
        FPCreatorsContent.Padding = New Padding(40, 20, 40, 20)
        FPCreatorsContent.Size = New Size(920, 500)
        FPCreatorsContent.TabIndex = 7
        ' 
        ' CreatorPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        BackColor = Color.White
        ClientSize = New Size(1064, 734)
        Controls.Add(FPCreatorsContent)
        Controls.Add(ProfileHeader)
        Name = "CreatorPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Perfil do Criador"
        Controls.SetChildIndex(ProfileHeader, 0)
        Controls.SetChildIndex(FPCreatorsContent, 0)
        ProfileHeader.ResumeLayout(False)
        ProfileHeader.PerformLayout()
        CType(CreatorPicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents ProfileHeader As Panel
    Friend WithEvents CreatorBio As Krypton.Toolkit.KryptonLabel
    Friend WithEvents SubscribeBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents FPCreatorsContent As FlowLayoutPanel
End Class
