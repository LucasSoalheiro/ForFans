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
        lblFileName = New Krypton.Toolkit.KryptonLabel()
        lblType = New Krypton.Toolkit.KryptonLabel()
        ThumbnailBtn = New Krypton.Toolkit.KryptonButton()
        SaveBtn = New Krypton.Toolkit.KryptonButton()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(242, 27)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(100, 23)
        txtTitle.TabIndex = 2
        txtTitle.Text = "KryptonTextBox1"
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(349, 54)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(100, 23)
        txtDescription.TabIndex = 3
        txtDescription.Text = "KryptonTextBox2"
        ' 
        ' picPreview
        ' 
        picPreview.Location = New Point(418, 214)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(100, 50)
        picPreview.TabIndex = 4
        picPreview.TabStop = False
        ' 
        ' SelectFileBtn
        ' 
        SelectFileBtn.Location = New Point(533, 220)
        SelectFileBtn.Name = "SelectFileBtn"
        SelectFileBtn.Size = New Size(103, 44)
        SelectFileBtn.TabIndex = 5
        SelectFileBtn.Values.DropDownArrowColor = Color.Empty
        SelectFileBtn.Values.Text = "Selecionar Imagem"
        ' 
        ' lblFileName
        ' 
        lblFileName.Location = New Point(242, 275)
        lblFileName.Name = "lblFileName"
        lblFileName.Size = New Size(243, 65)
        lblFileName.TabIndex = 6
        lblFileName.Values.Text = "KryptonLabel1"
        ' 
        ' lblType
        ' 
        lblType.Location = New Point(491, 299)
        lblType.Name = "lblType"
        lblType.Size = New Size(389, 61)
        lblType.TabIndex = 7
        lblType.Values.Text = "KryptonLabel2"
        ' 
        ' ThumbnailBtn
        ' 
        ThumbnailBtn.Location = New Point(359, 106)
        ThumbnailBtn.Name = "ThumbnailBtn"
        ThumbnailBtn.Size = New Size(90, 25)
        ThumbnailBtn.TabIndex = 8
        ThumbnailBtn.Values.DropDownArrowColor = Color.Empty
        ThumbnailBtn.Values.Text = "KryptonButton1"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Location = New Point(379, 396)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(90, 25)
        SaveBtn.TabIndex = 11
        SaveBtn.Values.DropDownArrowColor = Color.Empty
        SaveBtn.Values.Text = "KryptonButton1"
        ' 
        ' CreatorArea
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 734)
        Controls.Add(SaveBtn)
        Controls.Add(ThumbnailBtn)
        Controls.Add(lblType)
        Controls.Add(lblFileName)
        Controls.Add(SelectFileBtn)
        Controls.Add(picPreview)
        Controls.Add(txtDescription)
        Controls.Add(txtTitle)
        Name = "CreatorArea"
        Text = "CreatorArea"
        Controls.SetChildIndex(txtTitle, 0)
        Controls.SetChildIndex(txtDescription, 0)
        Controls.SetChildIndex(picPreview, 0)
        Controls.SetChildIndex(SelectFileBtn, 0)
        Controls.SetChildIndex(lblFileName, 0)
        Controls.SetChildIndex(lblType, 0)
        Controls.SetChildIndex(ThumbnailBtn, 0)
        Controls.SetChildIndex(SaveBtn, 0)
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTitle As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDescription As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents picPreview As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents SelectFileBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents lblFileName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblType As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ThumbnailBtn As Krypton.Toolkit.KryptonButton
    Friend WithEvents SaveBtn As Krypton.Toolkit.KryptonButton
End Class
