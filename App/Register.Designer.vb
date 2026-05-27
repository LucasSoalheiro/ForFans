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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        UserEmail = New Krypton.Toolkit.KryptonTextBox()
        UserPassword = New Krypton.Toolkit.KryptonTextBox()
        RegiterBtn = New Krypton.Toolkit.KryptonButton()
        UserName = New Krypton.Toolkit.KryptonTextBox()
        LoginLink = New Krypton.Toolkit.KryptonLinkLabel()
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        KryptonPictureBox1 = New Krypton.Toolkit.KryptonPictureBox()
        KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
        CType(KryptonPanel1, ComponentModel.ISupportInitialize).BeginInit()
        KryptonPanel1.SuspendLayout()
        CType(KryptonPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' KryptonPanel1
        ' 
        KryptonPanel1.Controls.Add(KryptonLabel7)
        KryptonPanel1.StateCommon.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        KryptonPanel1.StateCommon.Color2 = Color.FromArgb(CByte(40), CByte(120), CByte(225))
        KryptonPanel1.Controls.SetChildIndex(KryptonLabel7, 0)
        ' 
        ' UserEmail
        ' 
        UserEmail.CueHint.Color1 = SystemColors.ButtonShadow
        UserEmail.CueHint.CueHintText = "seu@email.com"
        UserEmail.CueHint.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserEmail.Location = New Point(624, 245)
        UserEmail.Margin = New Padding(3, 2, 3, 2)
        UserEmail.Name = "UserEmail"
        UserEmail.Size = New Size(242, 40)
        UserEmail.StateCommon.Border.Color1 = Color.FromArgb(CByte(180), CByte(195), CByte(210))
        UserEmail.StateCommon.Border.Rounding = 8F
        UserEmail.StateCommon.Content.Padding = New Padding(10, 8, 10, 8)
        UserEmail.TabIndex = 2
        UserEmail.Tag = ""
        ' 
        ' UserPassword
        ' 
        UserPassword.CueHint.Color1 = SystemColors.ButtonShadow
        UserPassword.CueHint.CueHintText = "●●●●●●●●"
        UserPassword.CueHint.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserPassword.Location = New Point(624, 356)
        UserPassword.Margin = New Padding(3, 2, 3, 2)
        UserPassword.Name = "UserPassword"
        UserPassword.PasswordChar = "●"c
        UserPassword.Size = New Size(242, 40)
        UserPassword.StateCommon.Border.Color1 = Color.FromArgb(CByte(180), CByte(195), CByte(210))
        UserPassword.StateCommon.Border.Rounding = 8F
        UserPassword.StateCommon.Content.Padding = New Padding(10, 8, 10, 8)
        UserPassword.TabIndex = 3
        ' 
        ' RegiterBtn
        ' 
        RegiterBtn.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2
        RegiterBtn.Location = New Point(624, 431)
        RegiterBtn.Margin = New Padding(3, 2, 3, 2)
        RegiterBtn.Name = "RegiterBtn"
        RegiterBtn.Size = New Size(364, 45)
        RegiterBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        RegiterBtn.StateCommon.Back.Color2 = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        RegiterBtn.StateCommon.Border.Color1 = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        RegiterBtn.StateCommon.Border.Rounding = 8F
        RegiterBtn.StateCommon.Content.ShortText.Color1 = Color.White
        RegiterBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RegiterBtn.TabIndex = 4
        RegiterBtn.Values.DropDownArrowColor = Color.Empty
        RegiterBtn.Values.Text = "Registrar Conta"
        ' 
        ' UserName
        ' 
        UserName.CueHint.Color1 = SystemColors.ButtonShadow
        UserName.CueHint.CueHintText = "Seu Nome"
        UserName.CueHint.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserName.Location = New Point(624, 137)
        UserName.Margin = New Padding(3, 2, 3, 2)
        UserName.Name = "UserName"
        UserName.Size = New Size(242, 40)
        UserName.StateCommon.Border.Color1 = Color.FromArgb(CByte(180), CByte(195), CByte(210))
        UserName.StateCommon.Border.Rounding = 8F
        UserName.StateCommon.Content.Padding = New Padding(10, 8, 10, 8)
        UserName.TabIndex = 1
        ' 
        ' LoginLink
        ' 
        LoginLink.Location = New Point(731, 491)
        LoginLink.Name = "LoginLink"
        LoginLink.Size = New Size(149, 25)
        LoginLink.TabIndex = 5
        LoginLink.Values.Text = "Já tem conta? Entrar"
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(624, 30)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(145, 37)
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel1.TabIndex = 6
        KryptonLabel1.Values.Text = "Criar Conta"
        ' 
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(624, 90)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(172, 33)
        KryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel2.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel2.TabIndex = 7
        KryptonLabel2.Values.Text = "Nome Completo"
        ' 
        ' KryptonLabel3
        ' 
        KryptonLabel3.Location = New Point(624, 197)
        KryptonLabel3.Name = "KryptonLabel3"
        KryptonLabel3.Size = New Size(90, 33)
        KryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel3.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel3.TabIndex = 8
        KryptonLabel3.Values.Text = "Email"
        ' 
        ' KryptonLabel4
        ' 
        KryptonLabel4.Location = New Point(624, 306)
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
        KryptonPictureBox1.Location = New Point(931, 12)
        KryptonPictureBox1.Name = "KryptonPictureBox1"
        KryptonPictureBox1.Size = New Size(70, 70)
        KryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        KryptonPictureBox1.TabIndex = 12
        KryptonPictureBox1.TabStop = False
        ' 
        ' KryptonLabel7
        ' 
        KryptonLabel7.Location = New Point(56, 169)
        KryptonLabel7.Name = "KryptonLabel7"
        KryptonLabel7.Size = New Size(487, 142)
        KryptonLabel7.StateCommon.ShortText.Color1 = Color.White
        KryptonLabel7.StateCommon.ShortText.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel7.TabIndex = 12
        KryptonLabel7.Values.Text = resources.GetString("KryptonLabel7.Values.Text")
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1033, 539)
        Controls.Add(KryptonPictureBox1)
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
        Controls.SetChildIndex(KryptonPictureBox1, 0)
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
End Class
