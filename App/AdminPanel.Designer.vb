<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvUsers = New Krypton.Toolkit.KryptonDataGridView()
        lblTitle = New Krypton.Toolkit.KryptonLabel()
        CType(dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsers.ColumnHeadersHeight = 36
        dgvUsers.Location = New Point(80, 80)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowHeadersVisible = False
        dgvUsers.Size = New Size(950, 620)
        dgvUsers.StateCommon.Background.Color1 = Color.White
        dgvUsers.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        dgvUsers.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.Location = New Point(80, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(307, 49)
        lblTitle.StateCommon.ShortText.Color1 = Color.FromArgb(CByte(4), CByte(41), CByte(84))
        lblTitle.StateCommon.ShortText.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.TabIndex = 2
        lblTitle.Values.Text = "Gerenciar Usuários"
        ' 
        ' AdminPanel
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1064, 734)
        Controls.Add(lblTitle)
        Controls.Add(dgvUsers)
        Name = "AdminPanel"
        Text = "AdminPanel"
        Controls.SetChildIndex(dgvUsers, 0)
        Controls.SetChildIndex(lblTitle, 0)
        CType(dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvUsers As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents lblTitle As Krypton.Toolkit.KryptonLabel
End Class
