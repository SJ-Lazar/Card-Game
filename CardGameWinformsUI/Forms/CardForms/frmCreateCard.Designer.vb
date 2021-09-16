<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateCard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudAttack = New System.Windows.Forms.NumericUpDown()
        Me.nudDefense = New System.Windows.Forms.NumericUpDown()
        Me.rbMonster = New System.Windows.Forms.RadioButton()
        Me.rbSpell = New System.Windows.Forms.RadioButton()
        Me.txtImagePath = New System.Windows.Forms.TextBox()
        Me.txtImageName = New System.Windows.Forms.TextBox()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAttack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDefense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create A New Card"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(26, 65)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(266, 20)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Image"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(26, 288)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(266, 68)
        Me.txtDescription.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Description/Effect"
        '
        'pbImage
        '
        Me.pbImage.BackColor = System.Drawing.Color.Silver
        Me.pbImage.Location = New System.Drawing.Point(26, 128)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(270, 111)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 8
        Me.pbImage.TabStop = False
        '
        'ofdImage
        '
        Me.ofdImage.FileName = "ofdImage"
        '
        'btnChooseImage
        '
        Me.btnChooseImage.Location = New System.Drawing.Point(26, 246)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(270, 23)
        Me.btnChooseImage.TabIndex = 11
        Me.btnChooseImage.Text = "Choose Image"
        Me.btnChooseImage.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(110, 416)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Attack"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(169, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Defense"
        '
        'nudAttack
        '
        Me.nudAttack.Location = New System.Drawing.Point(26, 375)
        Me.nudAttack.Name = "nudAttack"
        Me.nudAttack.Size = New System.Drawing.Size(119, 20)
        Me.nudAttack.TabIndex = 16
        '
        'nudDefense
        '
        Me.nudDefense.Location = New System.Drawing.Point(172, 375)
        Me.nudDefense.Name = "nudDefense"
        Me.nudDefense.Size = New System.Drawing.Size(120, 20)
        Me.nudDefense.TabIndex = 17
        '
        'rbMonster
        '
        Me.rbMonster.AutoSize = True
        Me.rbMonster.Location = New System.Drawing.Point(26, 91)
        Me.rbMonster.Name = "rbMonster"
        Me.rbMonster.Size = New System.Drawing.Size(63, 17)
        Me.rbMonster.TabIndex = 18
        Me.rbMonster.TabStop = True
        Me.rbMonster.Text = "Monster"
        Me.rbMonster.UseVisualStyleBackColor = True
        '
        'rbSpell
        '
        Me.rbSpell.AutoSize = True
        Me.rbSpell.Location = New System.Drawing.Point(122, 91)
        Me.rbSpell.Name = "rbSpell"
        Me.rbSpell.Size = New System.Drawing.Size(48, 17)
        Me.rbSpell.TabIndex = 19
        Me.rbSpell.TabStop = True
        Me.rbSpell.Text = "Spell"
        Me.rbSpell.UseVisualStyleBackColor = True
        '
        'txtImagePath
        '
        Me.txtImagePath.Location = New System.Drawing.Point(25, 219)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.Size = New System.Drawing.Size(270, 20)
        Me.txtImagePath.TabIndex = 20
        '
        'txtImageName
        '
        Me.txtImageName.Location = New System.Drawing.Point(25, 193)
        Me.txtImageName.Name = "txtImageName"
        Me.txtImageName.Size = New System.Drawing.Size(270, 20)
        Me.txtImageName.TabIndex = 21
        '
        'frmCreateCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 488)
        Me.Controls.Add(Me.txtImageName)
        Me.Controls.Add(Me.txtImagePath)
        Me.Controls.Add(Me.rbSpell)
        Me.Controls.Add(Me.rbMonster)
        Me.Controls.Add(Me.nudDefense)
        Me.Controls.Add(Me.nudAttack)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnChooseImage)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCreateCard"
        Me.Text = "Create Card"
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAttack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDefense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents ofdImage As OpenFileDialog
    Friend WithEvents btnChooseImage As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nudAttack As NumericUpDown
    Friend WithEvents nudDefense As NumericUpDown
    Friend WithEvents rbMonster As RadioButton
    Friend WithEvents rbSpell As RadioButton
    Friend WithEvents txtImagePath As TextBox
    Friend WithEvents txtImageName As TextBox
End Class
