<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCard
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
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.pbCardImage = New System.Windows.Forms.PictureBox()
        Me.txtCardDescription = New System.Windows.Forms.TextBox()
        Me.txtAttack = New System.Windows.Forms.TextBox()
        Me.txtDefense = New System.Windows.Forms.TextBox()
        CType(Me.pbCardImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCardName
        '
        Me.txtCardName.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCardName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCardName.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCardName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardName.ForeColor = System.Drawing.SystemColors.Window
        Me.txtCardName.Location = New System.Drawing.Point(0, 0)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(134, 19)
        Me.txtCardName.TabIndex = 0
        Me.txtCardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbCardImage
        '
        Me.pbCardImage.BackColor = System.Drawing.Color.Silver
        Me.pbCardImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbCardImage.Location = New System.Drawing.Point(0, 19)
        Me.pbCardImage.Name = "pbCardImage"
        Me.pbCardImage.Size = New System.Drawing.Size(134, 88)
        Me.pbCardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCardImage.TabIndex = 1
        Me.pbCardImage.TabStop = False
        '
        'txtCardDescription
        '
        Me.txtCardDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCardDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCardDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCardDescription.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardDescription.ForeColor = System.Drawing.SystemColors.Window
        Me.txtCardDescription.Location = New System.Drawing.Point(0, 107)
        Me.txtCardDescription.Multiline = True
        Me.txtCardDescription.Name = "txtCardDescription"
        Me.txtCardDescription.Size = New System.Drawing.Size(134, 69)
        Me.txtCardDescription.TabIndex = 2
        Me.txtCardDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAttack
        '
        Me.txtAttack.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAttack.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAttack.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtAttack.ForeColor = System.Drawing.SystemColors.Window
        Me.txtAttack.Location = New System.Drawing.Point(0, 176)
        Me.txtAttack.Multiline = True
        Me.txtAttack.Name = "txtAttack"
        Me.txtAttack.Size = New System.Drawing.Size(70, 35)
        Me.txtAttack.TabIndex = 3
        Me.txtAttack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDefense
        '
        Me.txtDefense.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDefense.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDefense.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtDefense.ForeColor = System.Drawing.SystemColors.Window
        Me.txtDefense.Location = New System.Drawing.Point(64, 176)
        Me.txtDefense.Multiline = True
        Me.txtDefense.Name = "txtDefense"
        Me.txtDefense.Size = New System.Drawing.Size(70, 35)
        Me.txtDefense.TabIndex = 4
        '
        'frmCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(134, 211)
        Me.Controls.Add(Me.txtDefense)
        Me.Controls.Add(Me.txtAttack)
        Me.Controls.Add(Me.txtCardDescription)
        Me.Controls.Add(Me.pbCardImage)
        Me.Controls.Add(Me.txtCardName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCard"
        CType(Me.pbCardImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCardName As TextBox
    Friend WithEvents pbCardImage As PictureBox
    Friend WithEvents txtCardDescription As TextBox
    Friend WithEvents txtAttack As TextBox
    Friend WithEvents txtDefense As TextBox
End Class
