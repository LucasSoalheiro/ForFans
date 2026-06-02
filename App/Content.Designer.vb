<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Content
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Content))
        ContentPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        CType(ContentPlayer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ContentPlayer
        ' 
        ContentPlayer.Enabled = True
        ContentPlayer.Location = New Point(277, 12)
        ContentPlayer.Name = "ContentPlayer"
        ContentPlayer.OcxState = CType(resources.GetObject("ContentPlayer.OcxState"), AxHost.State)
        ContentPlayer.Size = New Size(775, 482)
        ContentPlayer.TabIndex = 2
        ' 
        ' Content
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1064, 734)
        Controls.Add(ContentPlayer)
        Name = "Content"
        Text = "Content"
        Controls.SetChildIndex(ContentPlayer, 0)
        CType(ContentPlayer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ContentPlayer As AxWMPLib.AxWindowsMediaPlayer
End Class
