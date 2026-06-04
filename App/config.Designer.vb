<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class config
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
        PictureProfile = New Krypton.Toolkit.KryptonPictureBox()
        newName = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        NameUser = New Krypton.Toolkit.KryptonLabel()
        Useremail = New Krypton.Toolkit.KryptonLabel()
        NewUseremail = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        NewBios = New Krypton.Toolkit.KryptonTaskDialogKryptonRichTextBox()
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        ChangeImage = New Krypton.Toolkit.KryptonButton()
        BtnSave = New Krypton.Toolkit.KryptonButton()
        KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
        CType(PictureProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureProfile
        ' 
        PictureProfile.Image = My.Resources.Resources.person_edit_256dp_E3E3E3_FILL0_wght400_GRAD0_opsz48
        PictureProfile.Location = New Point(322, 121)
        PictureProfile.Name = "PictureProfile"
        PictureProfile.Size = New Size(120, 120)
        PictureProfile.SizeMode = PictureBoxSizeMode.Zoom
        PictureProfile.TabIndex = 4
        PictureProfile.TabStop = False
        ' 
        ' newName
        ' 
        newName.ButtonSpecs.Add(ButtonSpecAny1)
        newName.CueHint.Color1 = Color.Black
        newName.CueHint.CueHintText = "Insira o novo nome"
        newName.Location = New Point(322, 296)
        newName.Name = "newName"
        newName.Size = New Size(414, 36)
        newName.StateCommon.Border.Rounding = 8F
        newName.TabIndex = 9
        ' 
        ' ButtonSpecAny1
        ' 
        ButtonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny1.Image = My.Resources.Resources.person_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ButtonSpecAny1.UniqueName = "a0160eacafcc44b7aa6ba5dc773692fc"
        ' 
        ' NameUser
        ' 
        NameUser.Location = New Point(458, 133)
        NameUser.Name = "NameUser"
        NameUser.Size = New Size(90, 25)
        NameUser.TabIndex = 2
        NameUser.Values.Text = "Username"
        ' 
        ' Useremail
        ' 
        Useremail.Location = New Point(458, 164)
        Useremail.Name = "Useremail"
        Useremail.Size = New Size(90, 25)
        Useremail.TabIndex = 3
        Useremail.Values.Text = "Useremail"
        ' 
        ' NewUseremail
        ' 
        NewUseremail.ButtonSpecs.Add(ButtonSpecAny2)
        NewUseremail.CueHint.Color1 = Color.Black
        NewUseremail.CueHint.CueHintText = "Insira o novo email"
        NewUseremail.Location = New Point(322, 370)
        NewUseremail.Name = "NewUseremail"
        NewUseremail.Size = New Size(414, 36)
        NewUseremail.StateCommon.Border.Rounding = 8F
        NewUseremail.TabIndex = 10
        ' 
        ' ButtonSpecAny2
        ' 
        ButtonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny2.Image = My.Resources.Resources.mail_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ButtonSpecAny2.UniqueName = "d4e5238e07bc407f9980e7e87eedda0e"
        ' 
        ' NewBios
        ' 
        NewBios.CueHint.Color1 = Color.Black
        NewBios.CueHint.CueHintText = "Conte algo sobre você..."
        NewBios.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        NewBios.Location = New Point(322, 469)
        NewBios.Name = "NewBios"
        NewBios.Size = New Size(653, 132)
        NewBios.StateCommon.Border.Rounding = 8F
        NewBios.TabIndex = 11
        NewBios.Text = ""
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(322, 264)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(90, 26)
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel1.TabIndex = 12
        KryptonLabel1.Values.Text = "Nome"
        ' 
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(322, 338)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(90, 26)
        KryptonLabel2.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel2.TabIndex = 13
        KryptonLabel2.Values.Text = "Email"
        ' 
        ' ChangeImage
        ' 
        ChangeImage.Location = New Point(458, 202)
        ChangeImage.Name = "ChangeImage"
        ChangeImage.Size = New Size(137, 39)
        ChangeImage.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        ChangeImage.StateCommon.Border.Rounding = 8F
        ChangeImage.StateCommon.Content.ShortText.Color1 = Color.DeepSkyBlue
        ChangeImage.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChangeImage.TabIndex = 14
        ChangeImage.Values.DropDownArrowColor = Color.Empty
        ChangeImage.Values.Image = My.Resources.Resources.upload_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ChangeImage.Values.Text = "Trocar Foto"
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(693, 626)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(282, 39)
        BtnSave.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        BtnSave.StateCommon.Back.Color2 = Color.FromArgb(CByte(40), CByte(120), CByte(225))
        BtnSave.StateCommon.Border.Rounding = 8F
        BtnSave.StateCommon.Content.ShortText.Color1 = Color.White
        BtnSave.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 11.25F)
        BtnSave.TabIndex = 15
        BtnSave.Values.DropDownArrowColor = Color.Empty
        BtnSave.Values.Text = "Salvar Alterações"
        ' 
        ' KryptonLabel3
        ' 
        KryptonLabel3.Location = New Point(322, 437)
        KryptonLabel3.Name = "KryptonLabel3"
        KryptonLabel3.Size = New Size(90, 26)
        KryptonLabel3.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel3.TabIndex = 16
        KryptonLabel3.Values.Text = "Biografia"
        ' 
        ' KryptonLabel5
        ' 
        KryptonLabel5.Location = New Point(322, 12)
        KryptonLabel5.Name = "KryptonLabel5"
        KryptonLabel5.Size = New Size(239, 49)
        KryptonLabel5.StateCommon.ShortText.Color1 = Color.Black
        KryptonLabel5.StateCommon.ShortText.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel5.TabIndex = 18
        KryptonLabel5.Values.Text = "Configurações"
        ' 
        ' KryptonLabel6
        ' 
        KryptonLabel6.Location = New Point(322, 67)
        KryptonLabel6.Name = "KryptonLabel6"
        KryptonLabel6.Size = New Size(308, 25)
        KryptonLabel6.StateCommon.ShortText.Color1 = Color.Gray
        KryptonLabel6.StateCommon.ShortText.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel6.TabIndex = 19
        KryptonLabel6.Values.Text = "Gerencie suas informações de perfil e conta"
        ' 
        ' config
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        ClientSize = New Size(1064, 734)
        Controls.Add(KryptonLabel6)
        Controls.Add(KryptonLabel5)
        Controls.Add(KryptonLabel3)
        Controls.Add(BtnSave)
        Controls.Add(ChangeImage)
        Controls.Add(KryptonLabel2)
        Controls.Add(KryptonLabel1)
        Controls.Add(NewBios)
        Controls.Add(NewUseremail)
        Controls.Add(newName)
        Controls.Add(PictureProfile)
        Controls.Add(Useremail)
        Controls.Add(NameUser)
        Name = "config"
        StartPosition = FormStartPosition.CenterScreen
        Text = "config"
        Controls.SetChildIndex(NameUser, 0)
        Controls.SetChildIndex(Useremail, 0)
        Controls.SetChildIndex(PictureProfile, 0)
        Controls.SetChildIndex(newName, 0)
        Controls.SetChildIndex(NewUseremail, 0)
        Controls.SetChildIndex(NewBios, 0)
        Controls.SetChildIndex(KryptonLabel1, 0)
        Controls.SetChildIndex(KryptonLabel2, 0)
        Controls.SetChildIndex(ChangeImage, 0)
        Controls.SetChildIndex(BtnSave, 0)
        Controls.SetChildIndex(KryptonLabel3, 0)
        Controls.SetChildIndex(KryptonLabel5, 0)
        Controls.SetChildIndex(KryptonLabel6, 0)
        CType(PictureProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureProfile As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents newName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Userbio As Krypton.Toolkit.KryptonLabel
    Friend WithEvents NameUser As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Useremail As Krypton.Toolkit.KryptonLabel
    Friend WithEvents NewUseremail As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents NewBios As Krypton.Toolkit.KryptonTaskDialogKryptonRichTextBox
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ChangeImage As Krypton.Toolkit.KryptonButton
    Friend WithEvents BtnSave As Krypton.Toolkit.KryptonButton
    Friend WithEvents ButtonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ButtonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
End Class
