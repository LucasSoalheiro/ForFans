<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmallForm
    Inherits System.Windows.Forms.Form

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
        KryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Title = New Krypton.Toolkit.KryptonLabel()
        CType(KryptonPanel1, ComponentModel.ISupportInitialize).BeginInit()
        KryptonPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' KryptonPanel1
        ' 
        KryptonPanel1.Controls.Add(Title)
        KryptonPanel1.Dock = DockStyle.Left
        KryptonPanel1.Location = New Point(0, 0)
        KryptonPanel1.Name = "KryptonPanel1"
        KryptonPanel1.Size = New Size(668, 711)
        KryptonPanel1.TabIndex = 0
        ' 
        ' Title
        ' 
        Title.Location = New Point(200, 138)
        Title.Name = "Title"
        Title.Size = New Size(222, 99)
        Title.StateCommon.LongText.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title.StateCommon.ShortText.Font = New Font("Segoe UI", 29F, FontStyle.Bold)
        Title.TabIndex = 0
        Title.Values.Text = "ForFans"
        ' 
        ' SmallForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1179, 711)
        Controls.Add(KryptonPanel1)
        Margin = New Padding(3, 4, 3, 4)
        MaximumSize = New Size(1197, 758)
        MinimumSize = New Size(1197, 758)
        Name = "SmallForm"
        Text = "SmallForm"
        CType(KryptonPanel1, ComponentModel.ISupportInitialize).EndInit()
        KryptonPanel1.ResumeLayout(False)
        KryptonPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents KryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents Title As Krypton.Toolkit.KryptonLabel
End Class
