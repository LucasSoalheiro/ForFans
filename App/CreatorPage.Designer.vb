<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatorPage
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


    Friend WithEvents CreatorPicture As Krypton.Toolkit.KryptonPictureBox
    Friend WithEvents CreatorName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents SubscribersNumber As Krypton.Toolkit.KryptonLabel

    Private Sub InitializeComponent()
        CreatorPicture = New Krypton.Toolkit.KryptonPictureBox()
        CreatorName = New Krypton.Toolkit.KryptonLabel()
        SubscribersNumber = New Krypton.Toolkit.KryptonLabel()
        CreatorBio = New Krypton.Toolkit.KryptonLabel()
        SubscribeBtn = New Krypton.Toolkit.KryptonButton()
        CType(CreatorPicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CreatorPicture
        ' 
        CreatorPicture.Location = New Point(112, 26)
        CreatorPicture.Name = "CreatorPicture"
        CreatorPicture.Size = New Size(182, 182)
        CreatorPicture.SizeMode = PictureBoxSizeMode.Zoom
        CreatorPicture.TabIndex = 2
        CreatorPicture.TabStop = False
        ' 
        ' CreatorName
        ' 
        CreatorName.Location = New Point(300, 26)
        CreatorName.Name = "CreatorName"
        CreatorName.Size = New Size(707, 67)
        CreatorName.StateCommon.ShortText.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CreatorName.TabIndex = 3
        CreatorName.Values.Text = "Creator Name"
        ' 
        ' SubscribersNumber
        ' 
        SubscribersNumber.Location = New Point(300, 99)
        SubscribersNumber.Name = "SubscribersNumber"
        SubscribersNumber.Size = New Size(194, 25)
        SubscribersNumber.TabIndex = 4
        SubscribersNumber.Values.Text = "Number of Subscribers"
        ' 
        ' CreatorBio
        ' 
        CreatorBio.Location = New Point(300, 130)
        CreatorBio.Name = "CreatorBio"
        CreatorBio.Size = New Size(707, 78)
        CreatorBio.TabIndex = 5
        CreatorBio.Values.Text = "Bio of the creator"
        ' 
        ' SubscribeBtn
        ' 
        SubscribeBtn.Location = New Point(500, 99)
        SubscribeBtn.Name = "SubscribeBtn"
        SubscribeBtn.Size = New Size(90, 25)
        SubscribeBtn.TabIndex = 6
        SubscribeBtn.Values.DropDownArrowColor = Color.Empty
        SubscribeBtn.Values.Text = "Subscribe"
        ' 
        ' CreatorPage
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        ClientSize = New Size(1064, 791)
        Controls.Add(SubscribeBtn)
        Controls.Add(CreatorBio)
        Controls.Add(SubscribersNumber)
        Controls.Add(CreatorName)
        Controls.Add(CreatorPicture)
        Name = "CreatorPage"
        Controls.SetChildIndex(CreatorPicture, 0)
        Controls.SetChildIndex(CreatorName, 0)
        Controls.SetChildIndex(SubscribersNumber, 0)
        Controls.SetChildIndex(CreatorBio, 0)
        Controls.SetChildIndex(SubscribeBtn, 0)
        CType(CreatorPicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents CreatorBio As Krypton.Toolkit.KryptonLabel
    Friend WithEvents SubscribeBtn As Krypton.Toolkit.KryptonButton
End Class
