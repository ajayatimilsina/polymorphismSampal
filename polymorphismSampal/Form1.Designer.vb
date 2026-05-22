<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBoxDog = New PictureBox()
        PictureBoxCat = New PictureBox()
        PictureBoxBird = New PictureBox()
        ButtonSing = New Button()
        ButtonReset = New Button()
        CType(PictureBoxDog, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxCat, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxBird, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxDog
        ' 
        PictureBoxDog.AccessibleRole = AccessibleRole.OutlineButton
        PictureBoxDog.Image = My.Resources.Resources.DogCookie
        PictureBoxDog.Location = New Point(12, 68)
        PictureBoxDog.Name = "PictureBoxDog"
        PictureBoxDog.Size = New Size(221, 156)
        PictureBoxDog.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxDog.TabIndex = 0
        PictureBoxDog.TabStop = False
        ' 
        ' PictureBoxCat
        ' 
        PictureBoxCat.Image = My.Resources.Resources.CatCookie
        PictureBoxCat.Location = New Point(279, 68)
        PictureBoxCat.Name = "PictureBoxCat"
        PictureBoxCat.Size = New Size(221, 156)
        PictureBoxCat.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxCat.TabIndex = 0
        PictureBoxCat.TabStop = False
        ' 
        ' PictureBoxBird
        ' 
        PictureBoxBird.Image = My.Resources.Resources.Birdcookie
        PictureBoxBird.Location = New Point(545, 68)
        PictureBoxBird.Name = "PictureBoxBird"
        PictureBoxBird.Size = New Size(221, 156)
        PictureBoxBird.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxBird.TabIndex = 0
        PictureBoxBird.TabStop = False
        ' 
        ' ButtonSing
        ' 
        ButtonSing.Location = New Point(215, 277)
        ButtonSing.Name = "ButtonSing"
        ButtonSing.Size = New Size(358, 39)
        ButtonSing.TabIndex = 1
        ButtonSing.Text = "鳴く"
        ButtonSing.UseVisualStyleBackColor = True
        ' 
        ' ButtonReset
        ' 
        ButtonReset.Location = New Point(215, 340)
        ButtonReset.Name = "ButtonReset"
        ButtonReset.Size = New Size(358, 39)
        ButtonReset.TabIndex = 1
        ButtonReset.Text = "元に戻す"
        ButtonReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonReset)
        Controls.Add(ButtonSing)
        Controls.Add(PictureBoxBird)
        Controls.Add(PictureBoxCat)
        Controls.Add(PictureBoxDog)
        Name = "Form1"
        Text = "動物のクッキー"
        CType(PictureBoxDog, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxCat, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxBird, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBoxDog As PictureBox
    Friend WithEvents PictureBoxCat As PictureBox
    Friend WithEvents PictureBoxBird As PictureBox
    Friend WithEvents ButtonSing As Button
    Friend WithEvents ButtonReset As Button

End Class
