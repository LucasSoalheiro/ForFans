<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits SmallForm

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
        UserEmail = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        UserPassword = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        RegiterBtn = New Krypton.Toolkit.KryptonButton()
        UserName = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny3 = New Krypton.Toolkit.ButtonSpecAny()
        LoginLink = New Krypton.Toolkit.KryptonLinkLabel()
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        KryptonPictureBox1 = New Krypton.Toolkit.KryptonPictureBox()
        KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
        CType(KryptonPanel1, ComponentModel.ISupportInitialize).BeginInit()
        KryptonPanel1.SuspendLayout()
        CType(KryptonPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' KryptonPanel1
        ' 
        KryptonPanel1.Controls.Add(KryptonLabel5)
        KryptonPanel1.Controls.Add(KryptonPictureBox1)
        KryptonPanel1.Controls.Add(KryptonLabel7)
        KryptonPanel1.StateCommon.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        KryptonPanel1.StateCommon.Color2 = Color.FromArgb(CByte(40), CByte(120), CByte(225))
        KryptonPanel1.Controls.SetChildIndex(KryptonLabel7, 0)
        KryptonPanel1.Controls.SetChildIndex(KryptonPictureBox1, 0)
        KryptonPanel1.Controls.SetChildIndex(KryptonLabel5, 0)
        ' 
        ' UserEmail
        ' 
        UserEmail.ButtonSpecs.Add(ButtonSpecAny1)
        UserEmail.CueHint.Color1 = SystemColors.ButtonShadow
        UserEmail.CueHint.CueHintText = "seu@email.com"
        UserEmail.CueHint.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserEmail.Location = New Point(624, 214)
        UserEmail.Margin = New Padding(3, 2, 3, 2)
        UserEmail.Name = "UserEmail"
        UserEmail.Size = New Size(385, 40)
        UserEmail.StateCommon.Border.Color1 = Color.FromArgb(CByte(180), CByte(195), CByte(210))
        UserEmail.StateCommon.Border.Rounding = 8F
        UserEmail.StateCommon.Content.Padding = New Padding(10, 8, 10, 8)
        UserEmail.TabIndex = 2
        UserEmail.Tag = ""
        ' 
        ' ButtonSpecAny1
        ' 
        ButtonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny1.Image = My.Resources.Resources.mail_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ButtonSpecAny1.Style = Krypton.Toolkit.PaletteButtonStyle.LowProfile
        ButtonSpecAny1.UniqueName = "333908ef851f46db893fc3f660a5f04e"
        ' 
        ' UserPassword
        ' 
        UserPassword.ButtonSpecs.Add(ButtonSpecAny2)
        UserPassword.CueHint.Color1 = SystemColors.ButtonShadow
        UserPassword.CueHint.CueHintText = "●●●●●●●●"
        UserPassword.CueHint.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserPassword.Location = New Point(624, 315)
        UserPassword.Margin = New Padding(3, 2, 3, 2)
        UserPassword.Name = "UserPassword"
        UserPassword.PasswordChar = "●"c
        UserPassword.Size = New Size(385, 40)
        UserPassword.StateCommon.Border.Color1 = Color.FromArgb(CByte(180), CByte(195), CByte(210))
        UserPassword.StateCommon.Border.Rounding = 8F
        UserPassword.StateCommon.Content.Padding = New Padding(10, 8, 10, 8)
        UserPassword.TabIndex = 3
        ' 
        ' ButtonSpecAny2
        ' 
        ButtonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny2.Image = My.Resources.Resources.lock_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ButtonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.LowProfile
        ButtonSpecAny2.UniqueName = "8750b3591275411eabb855db4107e8a6"
        ' 
        ' RegiterBtn
        ' 
        RegiterBtn.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2
        RegiterBtn.Location = New Point(624, 394)
        RegiterBtn.Margin = New Padding(3, 2, 3, 2)
        RegiterBtn.Name = "RegiterBtn"
        RegiterBtn.Size = New Size(385, 45)
        RegiterBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        RegiterBtn.StateCommon.Back.Color2 = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        RegiterBtn.StateCommon.Border.Color1 = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        RegiterBtn.StateCommon.Border.Rounding = 8F
        RegiterBtn.StateCommon.Content.ShortText.Color1 = Color.White
        RegiterBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RegiterBtn.TabIndex = 4
        RegiterBtn.Values.DropDownArrowColor = Color.Empty
        RegiterBtn.Values.Text = "Criar minha conta"
        ' 
        ' UserName
        ' 
        UserName.ButtonSpecs.Add(ButtonSpecAny3)
        UserName.CueHint.Color1 = SystemColors.ButtonShadow
        UserName.CueHint.CueHintText = "Seu Nome"
        UserName.CueHint.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserName.Location = New Point(624, 111)
        UserName.Margin = New Padding(3, 2, 3, 2)
        UserName.Name = "UserName"
        UserName.Size = New Size(385, 40)
        UserName.StateCommon.Border.Color1 = Color.FromArgb(CByte(180), CByte(195), CByte(210))
        UserName.StateCommon.Border.Rounding = 8F
        UserName.StateCommon.Content.Padding = New Padding(10, 8, 10, 8)
        UserName.TabIndex = 1
        ' 
        ' ButtonSpecAny3
        ' 
        ButtonSpecAny3.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny3.Image = My.Resources.Resources.person_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ButtonSpecAny3.Style = Krypton.Toolkit.PaletteButtonStyle.LowProfile
        ButtonSpecAny3.UniqueName = "47875131b7744449b822340344225181"
        ' 
        ' LoginLink
        ' 
        LoginLink.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline
        LoginLink.Location = New Point(740, 444)
        LoginLink.Name = "LoginLink"
        LoginLink.Size = New Size(149, 25)
        LoginLink.TabIndex = 5
        LoginLink.Values.Text = "Já tem conta? Entrar"
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(624, 12)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(190, 37)
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel1.TabIndex = 6
        KryptonLabel1.Values.Text = "Começar agora"
        ' 
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(624, 73)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(172, 33)
        KryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel2.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel2.TabIndex = 7
        KryptonLabel2.Values.Text = "Nome Completo"
        ' 
        ' KryptonLabel3
        ' 
        KryptonLabel3.Location = New Point(624, 176)
        KryptonLabel3.Name = "KryptonLabel3"
        KryptonLabel3.Size = New Size(90, 33)
        KryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel3.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel3.TabIndex = 8
        KryptonLabel3.Values.Text = "Email"
        ' 
        ' KryptonLabel4
        ' 
        KryptonLabel4.Location = New Point(624, 277)
        KryptonLabel4.Name = "KryptonLabel4"
        KryptonLabel4.Size = New Size(90, 33)
        KryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel4.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel4.TabIndex = 9
        KryptonLabel4.Values.Text = "Senha"
        ' 
        ' KryptonPictureBox1
        ' 
        KryptonPictureBox1.Image = My.Resources.Resources.logo
        KryptonPictureBox1.Location = New Point(85, 90)
        KryptonPictureBox1.Name = "KryptonPictureBox1"
        KryptonPictureBox1.Size = New Size(70, 54)
        KryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        KryptonPictureBox1.TabIndex = 12
        KryptonPictureBox1.TabStop = False
        ' 
        ' KryptonLabel7
        ' 
        KryptonLabel7.Location = New Point(96, 236)
        KryptonLabel7.Name = "KryptonLabel7"
        KryptonLabel7.Size = New Size(310, 57)
        KryptonLabel7.StateCommon.ShortText.Color1 = Color.White
        KryptonLabel7.StateCommon.ShortText.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel7.TabIndex = 12
        KryptonLabel7.Values.Text = "Crie sua conta em menos de 1 minuto e comece" & vbCrLf & "a apoiar seus criadores favoritos hoje mesmo." & vbCrLf
        ' 
        ' KryptonLabel5
        ' 
        KryptonLabel5.Location = New Point(85, 176)
        KryptonLabel5.Name = "KryptonLabel5"
        KryptonLabel5.Size = New Size(481, 54)
        KryptonLabel5.StateCommon.ShortText.Color1 = Color.White
        KryptonLabel5.StateCommon.ShortText.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel5.TabIndex = 13
        KryptonLabel5.Values.Text = "Junte-se à nossa comunidade."
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1033, 539)
        Controls.Add(KryptonLabel4)
        Controls.Add(KryptonLabel3)
        Controls.Add(KryptonLabel2)
        Controls.Add(KryptonLabel1)
        Controls.Add(LoginLink)
        Controls.Add(RegiterBtn)
        Controls.Add(UserPassword)
        Controls.Add(UserEmail)
        Controls.Add(UserName)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        Controls.SetChildIndex(KryptonPanel1, 0)
        Controls.SetChildIndex(UserName, 0)
        Controls.SetChildIndex(UserEmail, 0)
        Controls.SetChildIndex(UserPassword, 0)
        Controls.SetChildIndex(RegiterBtn, 0)
        Controls.SetChildIndex(LoginLink, 0)
        Controls.SetChildIndex(KryptonLabel1, 0)
        Controls.SetChildIndex(KryptonLabel2, 0)
        Controls.SetChildIndex(KryptonLabel3, 0)
        Controls.SetChildIndex(KryptonLabel4, 0)
        CType(KryptonPanel1, ComponentModel.ISupportInitialize).EndInit()
        KryptonPanel1.ResumeLayout(False)
        KryptonPanel1.PerformLayout()
        CType(KryptonPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UserEmail As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents UserPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents RegiterBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents UserName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LoginLink As Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPictureBox1 As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ButtonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ButtonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ButtonSpecAny3 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
End Class
