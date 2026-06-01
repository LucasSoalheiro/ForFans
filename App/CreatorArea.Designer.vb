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
        txtDescription = New Krypton.Toolkit.KryptonTextBox()
        picPreview = New Krypton.Toolkit.KryptonPictureBox()
        SelectFileBtn = New Krypton.Toolkit.KryptonButton()
        ThumbnailBtn = New Krypton.Toolkit.KryptonButton()
        SaveBtn = New Krypton.Toolkit.KryptonButton()
        KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitle
        ' 
        txtTitle.CueHint.CueHintText = "Adicione aqui o título do seu conteúdo"
        txtTitle.CueHint.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(611, 84)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(283, 23)
        txtTitle.TabIndex = 2
        ' 
        ' txtDescription
        ' 
        txtDescription.CueHint.CueHintText = "Adicione aqui a descrição do seu conteúdo"
        txtDescription.CueHint.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescription.Location = New Point(612, 166)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(357, 70)
        txtDescription.TabIndex = 3
        ' 
        ' picPreview
        ' 
        picPreview.Location = New Point(611, 274)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(241, 203)
        picPreview.TabIndex = 4
        picPreview.TabStop = False
        ' 
        ' SelectFileBtn
        ' 
        SelectFileBtn.Location = New Point(877, 274)
        SelectFileBtn.Name = "SelectFileBtn"
        SelectFileBtn.Size = New Size(145, 49)
        SelectFileBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        SelectFileBtn.StateCommon.Back.Color2 = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        SelectFileBtn.StateCommon.Border.Rounding = 8F
        SelectFileBtn.StateCommon.Content.ShortText.Color1 = Color.White
        SelectFileBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SelectFileBtn.TabIndex = 5
        SelectFileBtn.Values.DropDownArrowColor = Color.Empty
        SelectFileBtn.Values.Text = "Selecionar o contéudo"
        ' 
        ' ThumbnailBtn
        ' 
        ThumbnailBtn.Location = New Point(877, 346)
        ThumbnailBtn.Name = "ThumbnailBtn"
        ThumbnailBtn.Size = New Size(145, 50)
        ThumbnailBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        ThumbnailBtn.StateCommon.Back.Color2 = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        ThumbnailBtn.StateCommon.Border.Rounding = 8F
        ThumbnailBtn.StateCommon.Content.ShortText.Color1 = Color.White
        ThumbnailBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ThumbnailBtn.TabIndex = 8
        ThumbnailBtn.Values.DropDownArrowColor = Color.Empty
        ThumbnailBtn.Values.Text = "Selecione a thumbnail"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Location = New Point(877, 421)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(145, 42)
        SaveBtn.StateCommon.Back.Color1 = Color.FromArgb(CByte(4), CByte(44), CByte(83))
        SaveBtn.StateCommon.Back.Color2 = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        SaveBtn.StateCommon.Border.Rounding = 8F
        SaveBtn.StateCommon.Content.ShortText.Color1 = Color.White
        SaveBtn.StateCommon.Content.ShortText.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveBtn.TabIndex = 11
        SaveBtn.Values.DropDownArrowColor = Color.Empty
        SaveBtn.Values.Text = "Criar"
        ' 
        ' KryptonLabel2
        ' 
        KryptonLabel2.Location = New Point(611, 53)
        KryptonLabel2.Name = "KryptonLabel2"
        KryptonLabel2.Size = New Size(188, 25)
        KryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel2.StateCommon.ShortText.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel2.TabIndex = 12
        KryptonLabel2.Values.Text = "Título do Conteúdo"
        ' 
        ' KryptonLabel3
        ' 
        KryptonLabel3.Location = New Point(659, 0)
        KryptonLabel3.Name = "KryptonLabel3"
        KryptonLabel3.Size = New Size(236, 33)
        KryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel3.StateCommon.ShortText.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel3.TabIndex = 14
        KryptonLabel3.Values.Text = "Criar Conteúdo"
        ' 
        ' KryptonLabel1
        ' 
        KryptonLabel1.Location = New Point(611, 126)
        KryptonLabel1.Name = "KryptonLabel1"
        KryptonLabel1.Size = New Size(188, 25)
        KryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        KryptonLabel1.StateCommon.ShortText.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KryptonLabel1.TabIndex = 15
        KryptonLabel1.Values.Text = "Descrição do Conteúdo"
        ' 
        ' CreatorArea
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1064, 734)
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
End Class
