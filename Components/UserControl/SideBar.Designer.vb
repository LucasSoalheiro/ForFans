<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SideBar
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
        SidebarBtn = New Krypton.Toolkit.KryptonButton()
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        ButtonCreatorArea = New Krypton.Toolkit.KryptonButton()
        KryptonButton2 = New Krypton.Toolkit.KryptonButton()
        KryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        KryptonButton3 = New Krypton.Toolkit.KryptonButton()
        KryptonButton4 = New Krypton.Toolkit.KryptonButton()
        AccountLbl = New Krypton.Toolkit.KryptonLabel()
        ManageContents = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        LabelCreatorArea = New Krypton.Toolkit.KryptonLabel()
        KryptonButton1 = New Krypton.Toolkit.KryptonButton()
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        SpecialBtn = New Krypton.Toolkit.KryptonButton()
        SpecialLbl = New Krypton.Toolkit.KryptonLabel()
        SuspendLayout()
        ' 
        ' SidebarBtn
        ' 
        SidebarBtn.Location = New Point(3, 3)
        SidebarBtn.Name = "SidebarBtn"
        SidebarBtn.Size = New Size(55, 55)
        SidebarBtn.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        SidebarBtn.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        SidebarBtn.StateNormal.Border.Rounding = 10F
        SidebarBtn.StatePressed.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Light
        SidebarBtn.TabIndex = 3
        SidebarBtn.Values.DropDownArrowColor = Color.Empty
        SidebarBtn.Values.Image = My.Resources.Resources.logo
        SidebarBtn.Values.Text = ""
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(64, 3)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(149, 55)
        KryptonLabel1.StateCommon.ShortText.Color1 = Color.White
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
        KryptonLabel1.TabIndex = 4
        KryptonLabel1.Values.Text = "ForFans"
        ' 
        ' ButtonCreatorArea
        ' 
        ButtonCreatorArea.Location = New Point(3, 143)
        ButtonCreatorArea.Name = "ButtonCreatorArea"
        ButtonCreatorArea.Size = New Size(55, 55)
        ButtonCreatorArea.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        ButtonCreatorArea.StateCommon.Border.Color1 = Color.White
        ButtonCreatorArea.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        ButtonCreatorArea.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.False
        ButtonCreatorArea.TabIndex = 5
        ButtonCreatorArea.Values.DropDownArrowColor = Color.Empty
        ButtonCreatorArea.Values.Image = My.Resources.Resources.video_camera_back_add_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz241
        ButtonCreatorArea.Values.Text = ""
        ' 
        ' KryptonButton2
        ' 
        KryptonButton2.Location = New Point(3, 221)
        KryptonButton2.Name = "KryptonButton2"
        KryptonButton2.Size = New Size(55, 55)
        KryptonButton2.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        KryptonButton2.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        KryptonButton2.TabIndex = 6
        KryptonButton2.Values.DropDownArrowColor = Color.Empty
        KryptonButton2.Values.Image = My.Resources.Resources.favorite_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        KryptonButton2.Values.Text = ""
        ' 
        ' KryptonBorderEdge1
        ' 
        KryptonBorderEdge1.Location = New Point(0, 64)
        KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        KryptonBorderEdge1.Size = New Size(353, 1)
        KryptonBorderEdge1.StateCommon.Color1 = Color.CornflowerBlue
        KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        ' 
        ' KryptonButton3
        ' 
        KryptonButton3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        KryptonButton3.Location = New Point(3, 435)
        KryptonButton3.Name = "KryptonButton3"
        KryptonButton3.Size = New Size(55, 55)
        KryptonButton3.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        KryptonButton3.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        KryptonButton3.StateCommon.Border.Width = 8
        KryptonButton3.TabIndex = 9
        KryptonButton3.Values.DropDownArrowColor = Color.Empty
        KryptonButton3.Values.Image = My.Resources.Resources.settings_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        KryptonButton3.Values.Text = ""
        ' 
        ' KryptonButton4
        ' 
        KryptonButton4.Location = New Point(3, 299)
        KryptonButton4.Name = "KryptonButton4"
        KryptonButton4.Size = New Size(55, 55)
        KryptonButton4.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        KryptonButton4.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        KryptonButton4.TabIndex = 12
        KryptonButton4.Values.DropDownArrowColor = Color.Empty
        KryptonButton4.Values.Image = My.Resources.Resources.manage_accounts_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        KryptonButton4.Values.Text = ""
        ' 
        ' AccountLbl
        ' 
        AccountLbl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        AccountLbl.Location = New Point(64, 435)
        AccountLbl.Name = "AccountLbl"
        AccountLbl.Size = New Size(100, 55)
        AccountLbl.StateCommon.ShortText.Color1 = Color.White
        AccountLbl.StateCommon.ShortText.Font = New Font("Segoe UI", 16.15F, FontStyle.Bold)
        AccountLbl.TabIndex = 15
        AccountLbl.Values.Text = ""
        ' 
        ' ManageContents
        ' 
        ManageContents.Location = New Point(64, 299)
        ManageContents.Name = "ManageContents"
        ManageContents.Size = New Size(166, 55)
        ManageContents.StateCommon.ShortText.Color1 = Color.White
        ManageContents.StateCommon.ShortText.Font = New Font("Segoe UI", 16.15F, FontStyle.Bold)
        ManageContents.TabIndex = 16
        ManageContents.Values.Text = "Gerenciar"
        ' 
        ' KryptonLabel4
        ' 
        KryptonLabel4.Location = New Point(64, 221)
        KryptonLabel4.Name = "KryptonLabel4"
        KryptonLabel4.Size = New Size(166, 55)
        KryptonLabel4.StateCommon.ShortText.Color1 = Color.White
        KryptonLabel4.StateCommon.ShortText.Font = New Font("Segoe UI", 16.15F, FontStyle.Bold)
        KryptonLabel4.TabIndex = 17
        KryptonLabel4.Values.Text = "Assinaturas"
        ' 
        ' LabelCreatorArea
        ' 
        LabelCreatorArea.Location = New Point(64, 143)
        LabelCreatorArea.Name = "LabelCreatorArea"
        LabelCreatorArea.Size = New Size(166, 55)
        LabelCreatorArea.StateCommon.ShortText.Color1 = Color.White
        LabelCreatorArea.StateCommon.ShortText.Font = New Font("Segoe UI", 16.15F, FontStyle.Bold)
        LabelCreatorArea.TabIndex = 18
        LabelCreatorArea.Values.Text = "Criar"
        ' 
        ' KryptonButton1
        ' 
        KryptonButton1.Location = New Point(0, 496)
        KryptonButton1.Name = "KryptonButton1"
        KryptonButton1.Size = New Size(55, 55)
        KryptonButton1.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        KryptonButton1.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        KryptonButton1.TabIndex = 20
        KryptonButton1.Values.DropDownArrowColor = Color.Empty
        KryptonButton1.Values.Image = My.Resources.Resources.exit_to_app_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        KryptonButton1.Values.Text = ""
        ' 
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(64, 496)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(166, 55)
        KryptonLabel2.StateCommon.ShortText.Color1 = Color.White
        KryptonLabel2.StateCommon.ShortText.Font = New Font("Segoe UI", 16.15F, FontStyle.Bold)
        KryptonLabel2.TabIndex = 21
        KryptonLabel2.Values.Text = "Sair"
        ' 
        ' SpecialBtn
        ' 
        SpecialBtn.Location = New Point(3, 360)
        SpecialBtn.Name = "SpecialBtn"
        SpecialBtn.Size = New Size(55, 55)
        SpecialBtn.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        SpecialBtn.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        SpecialBtn.TabIndex = 23
        SpecialBtn.Values.DropDownArrowColor = Color.Empty
        SpecialBtn.Values.Image = My.Resources.Resources.manage_accounts_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        SpecialBtn.Values.Text = ""
        ' 
        ' SpecialLbl
        ' 
        SpecialLbl.Location = New Point(64, 360)
        SpecialLbl.Name = "SpecialLbl"
        SpecialLbl.Size = New Size(166, 55)
        SpecialLbl.StateCommon.ShortText.Color1 = Color.White
        SpecialLbl.StateCommon.ShortText.Font = New Font("Segoe UI", 16.15F, FontStyle.Bold)
        SpecialLbl.TabIndex = 24
        SpecialLbl.Values.Text = "Nothing"
        ' 
        ' SideBar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(29, 161, 242)
        Controls.Add(SpecialLbl)
        Controls.Add(SpecialBtn)
        Controls.Add(KryptonLabel2)
        Controls.Add(KryptonButton1)
        Controls.Add(LabelCreatorArea)
        Controls.Add(KryptonLabel4)
        Controls.Add(ManageContents)
        Controls.Add(AccountLbl)
        Controls.Add(KryptonButton4)
        Controls.Add(KryptonButton3)
        Controls.Add(KryptonBorderEdge1)
        Controls.Add(KryptonButton2)
        Controls.Add(ButtonCreatorArea)
        Controls.Add(KryptonLabel1)
        Controls.Add(SidebarBtn)
        Name = "SideBar"
        Size = New Size(242, 708)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents SidebarBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ButtonCreatorArea As Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonButton3 As Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton4 As Krypton.Toolkit.KryptonButton
    Friend WithEvents AccountLbl As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ManageContents As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LabelCreatorArea As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents SpecialBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents SpecialLbl As Krypton.Toolkit.KryptonLabel

End Class
