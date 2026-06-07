<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserEditDialog
    Inherits Krypton.Toolkit.KryptonForm

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
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New Krypton.Toolkit.KryptonLabel()
        Me.txtName = New Krypton.Toolkit.KryptonTextBox()
        Me.txtEmail = New Krypton.Toolkit.KryptonTextBox()
        Me.cmbRole = New Krypton.Toolkit.KryptonComboBox()
        Me.btnSave = New Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New Krypton.Toolkit.KryptonButton()
        Me.lblName = New Krypton.Toolkit.KryptonLabel()
        Me.lblEmail = New Krypton.Toolkit.KryptonLabel()
        Me.lblRole = New Krypton.Toolkit.KryptonLabel()
        CType(Me.cmbRole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(155, 33)
        Me.lblTitle.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Values.Text = "Editar Usuário"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(12, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(50, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Values.Text = "Nome:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 86)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(360, 33)
        Me.txtName.StateCommon.Border.Rounding = 8
        Me.txtName.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.txtName.TabIndex = 2
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(12, 125)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 20)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Values.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(12, 151)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(360, 33)
        Me.txtEmail.StateCommon.Border.Rounding = 8
        Me.txtEmail.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.txtEmail.TabIndex = 4
        '
        'lblRole
        '
        Me.lblRole.Location = New System.Drawing.Point(12, 190)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(41, 20)
        Me.lblRole.TabIndex = 5
        Me.lblRole.Values.Text = "Role:"
        '
        'cmbRole
        '
        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.Items.AddRange(New Object() {"subscriber", "creator", "admin"})
        Me.cmbRole.Location = New System.Drawing.Point(12, 216)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(360, 27)
        Me.cmbRole.StateCommon.ComboBox.Border.Rounding = 8
        Me.cmbRole.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(282, 270)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 35)
        Me.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSave.StateCommon.Border.Rounding = 8
        Me.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnSave.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.TabIndex = 7
        Me.btnSave.Values.Text = "Salvar"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(186, 270)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 35)
        Me.btnCancel.StateCommon.Border.Rounding = 8
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Values.Text = "Cancelar"
        '
        'UserEditDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 321)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserEditDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar Usuário"
        CType(Me.cmbRole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtEmail As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cmbRole As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnSave As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As Krypton.Toolkit.KryptonButton
    Friend WithEvents lblName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblEmail As Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblRole As Krypton.Toolkit.KryptonLabel
End Class
