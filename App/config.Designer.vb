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
        NameUser = New Krypton.Toolkit.KryptonLabel()
        Useremail = New Krypton.Toolkit.KryptonLabel()
        NewUseremail = New Krypton.Toolkit.KryptonTextBox()
        NewBios = New Krypton.Toolkit.KryptonTaskDialogKryptonRichTextBox()
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        ChangeImage = New Krypton.Toolkit.KryptonButton()
        BtnSave = New Krypton.Toolkit.KryptonButton()
        CType(PictureProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureProfile
        ' 
        PictureProfile.Location = New Point(322, 30)
        PictureProfile.Name = "PictureProfile"
        PictureProfile.Size = New Size(105, 105)
        PictureProfile.TabIndex = 4
        PictureProfile.TabStop = False
        ' 
        ' newName
        ' 
        newName.Location = New Point(322, 197)
        newName.Name = "newName"
        newName.Size = New Size(238, 23)
        newName.TabIndex = 9
        ' 
        ' NameUser
        ' 
        NameUser.Location = New Point(470, 30)
        NameUser.Name = "NameUser"
        NameUser.Size = New Size(90, 25)
        NameUser.TabIndex = 2
        NameUser.Values.Text = "Username"
        ' 
        ' Useremail
        ' 
        Useremail.Location = New Point(470, 61)
        Useremail.Name = "Useremail"
        Useremail.Size = New Size(90, 25)
        Useremail.TabIndex = 3
        Useremail.Values.Text = "Useremail"
        ' 
        ' NewUseremail
        ' 
        NewUseremail.Location = New Point(322, 255)
        NewUseremail.Name = "NewUseremail"
        NewUseremail.Size = New Size(238, 23)
        NewUseremail.TabIndex = 10
        ' 
        ' NewBios
        ' 
        NewBios.Location = New Point(322, 352)
        NewBios.Name = "NewBios"
        NewBios.Size = New Size(414, 182)
        NewBios.TabIndex = 11
        NewBios.Text = ""
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(324, 171)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(90, 25)
        KryptonLabel1.TabIndex = 12
        KryptonLabel1.Values.Text = "Name"
        ' 
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(322, 224)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(90, 25)
        KryptonLabel2.TabIndex = 13
        KryptonLabel2.Values.Text = "Email"
        ' 
        ' ChangeImage
        ' 
        ChangeImage.Location = New Point(468, 104)
        ChangeImage.Name = "ChangeImage"
        ChangeImage.Size = New Size(90, 25)
        ChangeImage.TabIndex = 14
        ChangeImage.Values.DropDownArrowColor = Color.Empty
        ChangeImage.Values.Text = "Change Image"
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(769, 496)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(90, 25)
        BtnSave.TabIndex = 15
        BtnSave.Values.DropDownArrowColor = Color.Empty
        BtnSave.Values.Text = "Save Changes"
        ' 
        ' config
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 734)
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
End Class
