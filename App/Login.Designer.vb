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
        LoginPassword = New Krypton.Toolkit.KryptonTextBox()
        LoginBtn = New Krypton.Toolkit.KryptonButton()
        CreateAccountLink = New Krypton.Toolkit.KryptonLinkLabel()
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        SuspendLayout()
        ' 
        ' LoginEmail
        ' 
        LoginEmail.Location = New Point(622, 127)
        LoginEmail.Name = "LoginEmail"
        LoginEmail.Size = New Size(199, 40)
        LoginEmail.StateCommon.Back.Color1 = Color.White
        LoginEmail.StateCommon.Border.Color1 = Color.FromArgb(CByte(180), CByte(195), CByte(210))
        LoginEmail.StateCommon.Border.Rounding = 8F
        LoginEmail.StateCommon.Content.Padding = New Padding(10, 8, 10, 8)
        LoginEmail.TabIndex = 1
        ' 
        ' LoginPassword
        ' 
        LoginPassword.Location = New Point(622, 244)
        LoginPassword.Name = "LoginPassword"
        LoginPassword.PasswordChar = "●"c
        LoginPassword.Size = New Size(199, 40)
        LoginPassword.StateCommon.Border.Color1 = Color.FromArgb(CByte(180), CByte(195), CByte(210))
        LoginPassword.StateCommon.Border.Rounding = 8F
        LoginPassword.StateCommon.Content.Padding = New Padding(10, 8, 10, 8)
        LoginPassword.TabIndex = 2
        ' 
        ' LoginBtn
        ' 
        LoginBtn.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1
        LoginBtn.Location = New Point(622, 335)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(364, 45)
        LoginBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(40), CByte(120), CByte(225))
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
        LoginBtn.Values.Text = "Login"
        ' 
        ' CreateAccountLink
        ' 
        CreateAccountLink.Location = New Point(702, 400)
        CreateAccountLink.Name = "CreateAccountLink"
        CreateAccountLink.Size = New Size(199, 25)
        CreateAccountLink.TabIndex = 4
        CreateAccountLink.Values.Text = "Não tem conta? Cadastre-se grátis"
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(622, 88)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(90, 33)
        KryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel1.TabIndex = 5
        KryptonLabel1.Values.Text = "Email"
        ' 
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(622, 191)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(90, 33)
        KryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel2.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel2.TabIndex = 6
        KryptonLabel2.Values.Text = "Senha"
        ' 
        ' KryptonLabel3
        ' 
        KryptonLabel3.Location = New Point(622, 24)
        KryptonLabel3.Name = "KryptonLabel3"
        KryptonLabel3.Size = New Size(197, 33)
        KryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel3.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel3.TabIndex = 7
        KryptonLabel3.Values.Text = "Entrar na sua conta"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1033, 539)
        Controls.Add(KryptonLabel3)
        Controls.Add(KryptonLabel2)
        Controls.Add(KryptonLabel1)
        Controls.Add(CreateAccountLink)
        Controls.Add(LoginBtn)
        Controls.Add(LoginPassword)
        Controls.Add(LoginEmail)
        FormBorderStyle = FormBorderStyle.FixedSingle
        FormScreenCaptureMode = ScreenCaptureMode.HideWindow
        Name = "Login"
        Text = "Login"
        Controls.SetChildIndex(LoginEmail, 0)
        Controls.SetChildIndex(LoginPassword, 0)
        Controls.SetChildIndex(LoginBtn, 0)
        Controls.SetChildIndex(CreateAccountLink, 0)
        Controls.SetChildIndex(KryptonLabel1, 0)
        Controls.SetChildIndex(KryptonLabel2, 0)
        Controls.SetChildIndex(KryptonLabel3, 0)
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
End Class
