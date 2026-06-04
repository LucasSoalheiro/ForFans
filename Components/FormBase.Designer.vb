<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBase
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        sidebar = New SideBar()
        TimerSidebar = New Timer(components)
        SuspendLayout()
        ' 
        ' sidebar
        ' 
        sidebar.AccountName = ""
        sidebar.BackColor = SystemColors.ActiveCaption
        sidebar.BringToFront()
        sidebar.Dock = DockStyle.Left
        sidebar.Location = New Point(0, 0)
        sidebar.Margin = New Padding(3, 4, 3, 4)
        sidebar.Name = "sidebar"
        sidebar.Size = New Size(233, 791)
        sidebar.TabIndex = 1
        ' 
        ' TimerSidebar
        ' 
        TimerSidebar.Interval = 15
        ' 
        ' FormBase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1064, 791)
        Controls.Add(sidebar)
        MinimumSize = New Size(1080, 773)
        Name = "FormBase"
        Text = "FormBase"
        ResumeLayout(False)
    End Sub


    Friend WithEvents sidebar As SideBar
    Friend WithEvents TimerSidebar As Timer
End Class
