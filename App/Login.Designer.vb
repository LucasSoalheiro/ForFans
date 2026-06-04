<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        LoginEmail = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        LoginPassword = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        LoginBtn = New Krypton.Toolkit.KryptonButton()
        CreateAccountLink = New Krypton.Toolkit.KryptonLinkLabel()
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
        KryptonPictureBox1 = New Krypton.Toolkit.KryptonPictureBox()
        KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
        CType(KryptonPanel1, ComponentModel.ISupportInitialize).BeginInit()
        KryptonPanel1.SuspendLayout()
        CType(KryptonPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' KryptonPanel1
        ' 
        KryptonPanel1.Controls.Add(KryptonLabel7)
        KryptonPanel1.Controls.Add(KryptonPictureBox1)
        KryptonPanel1.Controls.Add(KryptonLabel5)
        KryptonPanel1.Controls.Add(KryptonLabel4)
        KryptonPanel1.Size = New Size(584, 578)
        KryptonPanel1.StateCommon.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        KryptonPanel1.StateCommon.Color2 = Color.FromArgb(CByte(40), CByte(120), CByte(225))
        KryptonPanel1.Controls.SetChildIndex(KryptonLabel4, 0)
        KryptonPanel1.Controls.SetChildIndex(KryptonLabel5, 0)
        KryptonPanel1.Controls.SetChildIndex(KryptonPictureBox1, 0)
        KryptonPanel1.Controls.SetChildIndex(KryptonLabel7, 0)
        ' 
        ' LoginEmail
        ' 
        LoginEmail.ButtonSpecs.Add(ButtonSpecAny1)
        LoginEmail.CueHint.Color1 = SystemColors.ButtonShadow
        LoginEmail.CueHint.CueHintText = "seu@email.com"
        LoginEmail.CueHint.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginEmail.Location = New Point(622, 183)
        LoginEmail.Name = "LoginEmail"
        LoginEmail.Size = New Size(401, 40)
        LoginEmail.StateCommon.Back.Color1 = Color.White
        LoginEmail.StateCommon.Border.Color1 = Color.FromArgb(CByte(180), CByte(195), CByte(210))
        LoginEmail.StateCommon.Border.Rounding = 8F
        LoginEmail.StateCommon.Content.Padding = New Padding(10, 8, 10, 8)
        LoginEmail.TabIndex = 1
        ' 
        ' ButtonSpecAny1
        ' 
        ButtonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny1.Image = My.Resources.Resources.mail_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ButtonSpecAny1.Style = Krypton.Toolkit.PaletteButtonStyle.LowProfile
        ButtonSpecAny1.UniqueName = "c270eeb79dc04a2ea326182dfb21fe7c"
        ' 
        ' LoginPassword
        ' 
        LoginPassword.ButtonSpecs.Add(ButtonSpecAny2)
        LoginPassword.CueHint.Color1 = SystemColors.ButtonShadow
        LoginPassword.CueHint.CueHintText = "●●●●●●●●●●●"
        LoginPassword.CueHint.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginPassword.Location = New Point(622, 295)
        LoginPassword.Name = "LoginPassword"
        LoginPassword.PasswordChar = "●"c
        LoginPassword.Size = New Size(401, 40)
        LoginPassword.StateCommon.Border.Color1 = Color.FromArgb(CByte(180), CByte(195), CByte(210))
        LoginPassword.StateCommon.Border.Rounding = 8F
        LoginPassword.StateCommon.Content.Padding = New Padding(10, 8, 10, 8)
        LoginPassword.TabIndex = 2
        ' 
        ' ButtonSpecAny2
        ' 
        ButtonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny2.Image = My.Resources.Resources.lock_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ButtonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.LowProfile
        ButtonSpecAny2.UniqueName = "a82d61f24f0842a8ac4e9ba60f4fd0bf"
        ' 
        ' LoginBtn
        ' 
        LoginBtn.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1
        LoginBtn.Location = New Point(622, 389)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(401, 45)
        LoginBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        LoginBtn.StateCommon.Back.Color2 = Color.FromArgb(CByte(40), CByte(120), CByte(225))
        LoginBtn.StateCommon.Border.Color1 = Color.FromArgb(CByte(127), CByte(119), CByte(221))
        LoginBtn.StateCommon.Border.Rounding = 8F
        LoginBtn.StateCommon.Border.Width = 1
        LoginBtn.StateCommon.Content.LongText.Color1 = Color.Black
        LoginBtn.StateCommon.Content.LongText.Font = New Font("Microsoft Sans Serif", 8.25F)
        LoginBtn.StateCommon.Content.ShortText.Color1 = Color.White
        LoginBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginBtn.TabIndex = 3
        LoginBtn.Values.DropDownArrowColor = Color.Empty
        LoginBtn.Values.Text = "Entrar na plataforma"
        ' 
        ' CreateAccountLink
        ' 
        CreateAccountLink.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline
        CreateAccountLink.Location = New Point(718, 440)
        CreateAccountLink.Name = "CreateAccountLink"
        CreateAccountLink.Size = New Size(199, 25)
        CreateAccountLink.TabIndex = 4
        CreateAccountLink.Values.Text = "Não tem conta? Cadastre-se grátis"
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(622, 144)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(90, 33)
        KryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel1.TabIndex = 5
        KryptonLabel1.Values.Text = "Email"
        ' 
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(622, 256)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(90, 33)
        KryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel2.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel2.TabIndex = 6
        KryptonLabel2.Values.Text = "Senha"
        ' 
        ' KryptonLabel3
        ' 
        KryptonLabel3.Location = New Point(730, 29)
        KryptonLabel3.Name = "KryptonLabel3"
        KryptonLabel3.Size = New Size(187, 49)
        KryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel3.StateCommon.ShortText.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel3.TabIndex = 7
        KryptonLabel3.Values.Text = "Bem-vindo"
        ' 
        ' KryptonLabel4
        ' 
        KryptonLabel4.Location = New Point(100, 166)
        KryptonLabel4.Name = "KryptonLabel4"
        KryptonLabel4.Size = New Size(217, 65)
        KryptonLabel4.StateCommon.ShortText.Color1 = Color.White
        KryptonLabel4.StateCommon.ShortText.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel4.TabIndex = 8
        KryptonLabel4.Values.Text = "Seu conteúdo."
        ' 
        ' KryptonLabel5
        ' 
        KryptonLabel5.Location = New Point(100, 221)
        KryptonLabel5.Name = "KryptonLabel5"
        KryptonLabel5.Size = New Size(239, 68)
        KryptonLabel5.StateCommon.ShortText.Color1 = Color.White
        KryptonLabel5.StateCommon.ShortText.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel5.TabIndex = 9
        KryptonLabel5.Values.Text = "Sua Plataforma."
        ' 
        ' KryptonPictureBox1
        ' 
        KryptonPictureBox1.Image = My.Resources.Resources.logo
        KryptonPictureBox1.Location = New Point(100, 90)
        KryptonPictureBox1.Name = "KryptonPictureBox1"
        KryptonPictureBox1.Size = New Size(55, 55)
        KryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        KryptonPictureBox1.TabIndex = 11
        KryptonPictureBox1.TabStop = False
        ' 
        ' KryptonLabel7
        ' 
        KryptonLabel7.Location = New Point(100, 295)
        KryptonLabel7.Name = "KryptonLabel7"
        KryptonLabel7.Size = New Size(398, 142)
        KryptonLabel7.StateCommon.ShortText.Color1 = Color.White
        KryptonLabel7.StateCommon.ShortText.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel7.TabIndex = 11
        KryptonLabel7.Values.Text = "Vá além do feed público.Conecte-se com " & vbCrLf & "seus criadores favoritos em um ambiente" & vbCrLf & "feito para conteúdos inéditos e interações" & vbCrLf & "reais." & vbCrLf
        ' 
        ' KryptonLabel6
        ' 
        KryptonLabel6.Location = New Point(682, 73)
        KryptonLabel6.Name = "KryptonLabel6"
        KryptonLabel6.Size = New Size(289, 24)
        KryptonLabel6.StateCommon.ShortText.Color1 = Color.Gray
        KryptonLabel6.StateCommon.ShortText.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel6.TabIndex = 8
        KryptonLabel6.Values.Text = "Insira seus dados para acessar sua conta."
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1049, 578)
        Controls.Add(KryptonLabel6)
        Controls.Add(KryptonLabel3)
        Controls.Add(KryptonLabel2)
        Controls.Add(KryptonLabel1)
        Controls.Add(CreateAccountLink)
        Controls.Add(LoginBtn)
        Controls.Add(LoginPassword)
        Controls.Add(LoginEmail)
        FormBorderStyle = FormBorderStyle.None
        FormScreenCaptureMode = ScreenCaptureMode.HideWindow
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Controls.SetChildIndex(LoginEmail, 0)
        Controls.SetChildIndex(LoginPassword, 0)
        Controls.SetChildIndex(LoginBtn, 0)
        Controls.SetChildIndex(CreateAccountLink, 0)
        Controls.SetChildIndex(KryptonLabel1, 0)
        Controls.SetChildIndex(KryptonLabel2, 0)
        Controls.SetChildIndex(KryptonLabel3, 0)
        Controls.SetChildIndex(KryptonPanel1, 0)
        Controls.SetChildIndex(KryptonLabel6, 0)
        CType(KryptonPanel1, ComponentModel.ISupportInitialize).EndInit()
        KryptonPanel1.ResumeLayout(False)
        KryptonPanel1.PerformLayout()
        CType(KryptonPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginEmail As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LoginPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LoginBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents CreateAccountLink As Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPictureBox1 As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ButtonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ButtonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
End Class
