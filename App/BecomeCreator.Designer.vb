<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BecomeCreator
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
        KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        KryptonTextBox1 = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        KryptonTextBox2 = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        ButtonSpecAny3 = New Krypton.Toolkit.ButtonSpecAny()
        KryptonPictureBox1 = New Krypton.Toolkit.KryptonPictureBox()
        KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        KryptonCheckBox1 = New Krypton.Toolkit.KryptonCheckBox()
        KryptonButton1 = New Krypton.Toolkit.KryptonButton()
        BtnAddPhoto = New Krypton.Toolkit.KryptonButton()
        BtnRemovePhoto = New Krypton.Toolkit.KryptonButton()
        CType(KryptonPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' KryptonLabel5
        ' 
        KryptonLabel5.Location = New Point(226, 12)
        KryptonLabel5.Name = "KryptonLabel5"
        KryptonLabel5.Size = New Size(259, 49)
        KryptonLabel5.StateCommon.ShortText.Color1 = Color.Black
        KryptonLabel5.StateCommon.ShortText.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel5.TabIndex = 19
        KryptonLabel5.Values.Text = "Seja um criador"
        ' 
        ' KryptonLabel6
        ' 
        KryptonLabel6.Location = New Point(226, 67)
        KryptonLabel6.Name = "KryptonLabel6"
        KryptonLabel6.Size = New Size(352, 25)
        KryptonLabel6.StateCommon.ShortText.Color1 = Color.Gray
        KryptonLabel6.StateCommon.ShortText.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel6.TabIndex = 20
        KryptonLabel6.Values.Text = "Preencha os dados abaixo para validar o seu perfil"
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(226, 179)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(203, 26)
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel1.TabIndex = 21
        KryptonLabel1.Values.Text = "Nome Artístico / Criador"
        ' 
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(226, 280)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(203, 26)
        KryptonLabel2.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel2.TabIndex = 25
        KryptonLabel2.Values.Text = "Categoria de Contéudo"
        ' 
        ' KryptonTextBox1
        ' 
        KryptonTextBox1.ButtonSpecs.Add(ButtonSpecAny1)
        KryptonTextBox1.CueHint.Color1 = Color.Black
        KryptonTextBox1.CueHint.CueHintText = "Ex: Luquinhas Oficial"
        KryptonTextBox1.Location = New Point(226, 211)
        KryptonTextBox1.Name = "KryptonTextBox1"
        KryptonTextBox1.Size = New Size(416, 36)
        KryptonTextBox1.StateCommon.Border.Rounding = 8F
        KryptonTextBox1.TabIndex = 27
        ' 
        ' ButtonSpecAny1
        ' 
        ButtonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny1.Image = My.Resources.Resources.star_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz242
        ButtonSpecAny1.UniqueName = "c4d4d372d525438a9ff3d6a3469a3351"
        ' 
        ' KryptonTextBox2
        ' 
        KryptonTextBox2.ButtonSpecs.Add(ButtonSpecAny2)
        KryptonTextBox2.CueHint.Color1 = Color.Black
        KryptonTextBox2.CueHint.CueHintText = "Ex: Humor. Games, Música"
        KryptonTextBox2.Location = New Point(226, 312)
        KryptonTextBox2.Name = "KryptonTextBox2"
        KryptonTextBox2.Size = New Size(416, 36)
        KryptonTextBox2.StateCommon.Border.Rounding = 8F
        KryptonTextBox2.TabIndex = 28
        ' 
        ' ButtonSpecAny2
        ' 
        ButtonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny2.Image = My.Resources.Resources.category_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ButtonSpecAny2.UniqueName = "35e3ffb220ee4f6ba9b8681ca377a2b8"
        ' 
        ' ButtonSpecAny3
        ' 
        ButtonSpecAny3.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny3.Image = My.Resources.Resources.link_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ButtonSpecAny3.UniqueName = "53a85bdcf2d84b029b197046df67efec"
        ' 
        ' KryptonPictureBox1
        ' 
        KryptonPictureBox1.Location = New Point(684, 169)
        KryptonPictureBox1.Name = "KryptonPictureBox1"
        KryptonPictureBox1.Size = New Size(353, 239)
        KryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        KryptonPictureBox1.TabIndex = 30
        KryptonPictureBox1.TabStop = False
        ' 
        ' KryptonLabel4
        ' 
        KryptonLabel4.Location = New Point(684, 137)
        KryptonLabel4.Name = "KryptonLabel4"
        KryptonLabel4.Size = New Size(203, 26)
        KryptonLabel4.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel4.TabIndex = 31
        KryptonLabel4.Values.Text = "Sua Foto"
        ' 
        ' KryptonCheckBox1
        ' 
        KryptonCheckBox1.Location = New Point(226, 562)
        KryptonCheckBox1.Name = "KryptonCheckBox1"
        KryptonCheckBox1.Size = New Size(724, 26)
        KryptonCheckBox1.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonCheckBox1.TabIndex = 32
        KryptonCheckBox1.Values.Text = "Declaro que li e aceito os Termos de Uso de Criadores da plataforma e sou maior de idade."
        ' 
        ' KryptonButton1
        ' 
        KryptonButton1.Location = New Point(226, 630)
        KryptonButton1.Name = "KryptonButton1"
        KryptonButton1.Size = New Size(811, 50)
        KryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        KryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(CByte(40), CByte(120), CByte(225))
        KryptonButton1.StateCommon.Border.Rounding = 8F
        KryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White
        KryptonButton1.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonButton1.TabIndex = 33
        KryptonButton1.Values.DropDownArrowColor = Color.Empty
        KryptonButton1.Values.Image = My.Resources.Resources.send_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        KryptonButton1.Values.Text = "Enviar"
        ' 
        ' BtnAddPhoto
        ' 
        BtnAddPhoto.Location = New Point(684, 414)
        BtnAddPhoto.Name = "BtnAddPhoto"
        BtnAddPhoto.Size = New Size(170, 40)
        BtnAddPhoto.StateCommon.Back.Color1 = Color.FromArgb(CByte(29), CByte(161), CByte(242))
        BtnAddPhoto.StateCommon.Border.Rounding = 8F
        BtnAddPhoto.StateCommon.Content.ShortText.Color1 = Color.White
        BtnAddPhoto.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        BtnAddPhoto.TabIndex = 34
        BtnAddPhoto.Values.Image = My.Resources.Resources.image_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        BtnAddPhoto.Values.Text = "Adicionar Foto"
        ' 
        ' BtnRemovePhoto
        ' 
        BtnRemovePhoto.Location = New Point(867, 414)
        BtnRemovePhoto.Name = "BtnRemovePhoto"
        BtnRemovePhoto.Size = New Size(170, 40)
        BtnRemovePhoto.StateCommon.Back.Color1 = Color.Firebrick
        BtnRemovePhoto.StateCommon.Border.Rounding = 8F
        BtnRemovePhoto.StateCommon.Content.ShortText.Color1 = Color.White
        BtnRemovePhoto.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        BtnRemovePhoto.TabIndex = 35
        BtnRemovePhoto.Values.Text = "Remover Foto"
        ' 
        ' BecomeCreator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 734)
        Controls.Add(BtnRemovePhoto)
        Controls.Add(BtnAddPhoto)
        Controls.Add(KryptonButton1)
        Controls.Add(KryptonCheckBox1)
        Controls.Add(KryptonLabel4)
        Controls.Add(KryptonPictureBox1)
        Controls.Add(KryptonTextBox2)
        Controls.Add(KryptonTextBox1)
        Controls.Add(KryptonLabel2)
        Controls.Add(KryptonLabel1)
        Controls.Add(KryptonLabel6)
        Controls.Add(KryptonLabel5)
        Name = "BecomeCreator"
        Text = "BecomeCreator"
        Controls.SetChildIndex(KryptonLabel5, 0)
        Controls.SetChildIndex(KryptonLabel6, 0)
        Controls.SetChildIndex(KryptonLabel1, 0)
        Controls.SetChildIndex(KryptonLabel2, 0)
        Controls.SetChildIndex(KryptonTextBox1, 0)
        Controls.SetChildIndex(KryptonTextBox2, 0)
        Controls.SetChildIndex(KryptonPictureBox1, 0)
        Controls.SetChildIndex(KryptonLabel4, 0)
        Controls.SetChildIndex(KryptonCheckBox1, 0)
        Controls.SetChildIndex(KryptonButton1, 0)
        Controls.SetChildIndex(BtnAddPhoto, 0)
        Controls.SetChildIndex(BtnRemovePhoto, 0)
        CType(KryptonPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox1 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonTextBox2 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ButtonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ButtonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ButtonSpecAny3 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonPictureBox1 As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonCheckBox1 As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents BtnAddPhoto As Krypton.Toolkit.KryptonButton
    Friend WithEvents BtnRemovePhoto As Krypton.Toolkit.KryptonButton
End Class
