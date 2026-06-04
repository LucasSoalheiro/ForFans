<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatorArea
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
        txtTitle = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        txtDescription = New Krypton.Toolkit.KryptonTextBox()
        ButtonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        picPreview = New Krypton.Toolkit.KryptonPictureBox()
        SelectFileBtn = New Krypton.Toolkit.KryptonButton()
        ThumbnailBtn = New Krypton.Toolkit.KryptonButton()
        SaveBtn = New Krypton.Toolkit.KryptonButton()
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitle
        ' 
        txtTitle.ButtonSpecs.Add(ButtonSpecAny1)
        txtTitle.CueHint.CueHintText = "Adicione aqui o título do seu conteúdo"
        txtTitle.CueHint.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(192, 152)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(750, 36)
        txtTitle.StateCommon.Border.Rounding = 8F
        txtTitle.TabIndex = 2
        ' 
        ' ButtonSpecAny1
        ' 
        ButtonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny1.Image = My.Resources.Resources.edit_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24__1_
        ButtonSpecAny1.UniqueName = "e939b9202d3244c68ba76054a2b9e773"
        ' 
        ' txtDescription
        ' 
        txtDescription.ButtonSpecs.Add(ButtonSpecAny2)
        txtDescription.CueHint.CueHintText = "Adicione aqui a descrição do seu conteúdo"
        txtDescription.CueHint.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescription.Location = New Point(192, 262)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(750, 58)
        txtDescription.StateCommon.Border.Rounding = 8F
        txtDescription.TabIndex = 3
        ' 
        ' ButtonSpecAny2
        ' 
        ButtonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        ButtonSpecAny2.Image = My.Resources.Resources.description_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ButtonSpecAny2.UniqueName = "23f5c11dae77489381056b0cd173ac94"
        ' 
        ' picPreview
        ' 
        picPreview.BorderStyle = BorderStyle.FixedSingle
        picPreview.Location = New Point(192, 458)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(372, 252)
        picPreview.TabIndex = 4
        picPreview.TabStop = False
        ' 
        ' SelectFileBtn
        ' 
        SelectFileBtn.Location = New Point(652, 559)
        SelectFileBtn.Name = "SelectFileBtn"
        SelectFileBtn.Size = New Size(172, 49)
        SelectFileBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        SelectFileBtn.StateCommon.Back.Color2 = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        SelectFileBtn.StateCommon.Border.Rounding = 8F
        SelectFileBtn.StateCommon.Content.ShortText.Color1 = Color.White
        SelectFileBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SelectFileBtn.TabIndex = 5
        SelectFileBtn.Values.DropDownArrowColor = Color.Empty
        SelectFileBtn.Values.Image = My.Resources.Resources.image_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz241
        SelectFileBtn.Values.Text = "Selecionar o contéudo"
        ' 
        ' ThumbnailBtn
        ' 
        ThumbnailBtn.Location = New Point(652, 458)
        ThumbnailBtn.Name = "ThumbnailBtn"
        ThumbnailBtn.Size = New Size(172, 50)
        ThumbnailBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        ThumbnailBtn.StateCommon.Back.Color2 = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        ThumbnailBtn.StateCommon.Border.Rounding = 8F
        ThumbnailBtn.StateCommon.Content.ShortText.Color1 = Color.White
        ThumbnailBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ThumbnailBtn.TabIndex = 8
        ThumbnailBtn.Values.DropDownArrowColor = Color.Empty
        ThumbnailBtn.Values.Image = My.Resources.Resources.image_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        ThumbnailBtn.Values.Text = "Selecione a thumbnail"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Location = New Point(652, 658)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(172, 42)
        SaveBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        SaveBtn.StateCommon.Back.Color2 = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        SaveBtn.StateCommon.Border.Rounding = 8F
        SaveBtn.StateCommon.Content.ShortText.Color1 = Color.White
        SaveBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveBtn.TabIndex = 11
        SaveBtn.Values.DropDownArrowColor = Color.Empty
        SaveBtn.Values.Image = My.Resources.Resources.bolt_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        SaveBtn.Values.Text = "Publicar Conteúdo"
        ' 
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(192, 116)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(192, 30)
        KryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel2.StateCommon.ShortText.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel2.TabIndex = 12
        KryptonLabel2.Values.Text = "Título do Conteúdo"
        ' 
        ' KryptonLabel3
        ' 
        KryptonLabel3.Location = New Point(192, 12)
        KryptonLabel3.Name = "KryptonLabel3"
        KryptonLabel3.Size = New Size(252, 49)
        KryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel3.StateCommon.ShortText.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel3.TabIndex = 14
        KryptonLabel3.Values.Text = "Criar Conteúdo"
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(192, 226)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(226, 30)
        KryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel1.TabIndex = 15
        KryptonLabel1.Values.Text = "Descrição do Conteúdo"
        ' 
        ' KryptonLabel5
        ' 
        KryptonLabel5.Location = New Point(192, 67)
        KryptonLabel5.Name = "KryptonLabel5"
        KryptonLabel5.Size = New Size(419, 26)
        KryptonLabel5.StateCommon.ShortText.Color1 = Color.Black
        KryptonLabel5.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KryptonLabel5.TabIndex = 17
        KryptonLabel5.Values.Text = "Publique fotos,vídeos ou textos exclusivos para seus fãs."
        ' 
        ' KryptonLabel4
        ' 
        KryptonLabel4.Location = New Point(192, 406)
        KryptonLabel4.Name = "KryptonLabel4"
        KryptonLabel4.Size = New Size(226, 30)
        KryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel4.StateCommon.ShortText.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel4.TabIndex = 18
        KryptonLabel4.Values.Text = "Prévia do Arquivo"
        ' 
        ' CreatorArea
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(250))
        ClientSize = New Size(1064, 734)
        Controls.Add(KryptonLabel4)
        Controls.Add(KryptonLabel5)
        Controls.Add(KryptonLabel1)
        Controls.Add(KryptonLabel3)
        Controls.Add(KryptonLabel2)
        Controls.Add(SaveBtn)
        Controls.Add(ThumbnailBtn)
        Controls.Add(SelectFileBtn)
        Controls.Add(picPreview)
        Controls.Add(txtDescription)
        Controls.Add(txtTitle)
        Name = "CreatorArea"
        StartPosition = FormStartPosition.CenterScreen
        Text = "'"
        Controls.SetChildIndex(txtTitle, 0)
        Controls.SetChildIndex(txtDescription, 0)
        Controls.SetChildIndex(picPreview, 0)
        Controls.SetChildIndex(SelectFileBtn, 0)
        Controls.SetChildIndex(ThumbnailBtn, 0)
        Controls.SetChildIndex(SaveBtn, 0)
        Controls.SetChildIndex(KryptonLabel2, 0)
        Controls.SetChildIndex(KryptonLabel3, 0)
        Controls.SetChildIndex(KryptonLabel1, 0)
        Controls.SetChildIndex(KryptonLabel5, 0)
        Controls.SetChildIndex(KryptonLabel4, 0)
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTitle As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDescription As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents picPreview As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents SelectFileBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents ThumbnailBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents SaveBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ButtonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ButtonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
End Class
