<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBattleField
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
        Me.pPlayersField = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblOpenetsName = New System.Windows.Forms.Label()
        Me.lblPlayersLifePoints = New System.Windows.Forms.Label()
        Me.lblOpenentsLifePoints = New System.Windows.Forms.Label()
        Me.rbtnStanbyPhase = New System.Windows.Forms.RadioButton()
        Me.rbtnMainPhase = New System.Windows.Forms.RadioButton()
        Me.rbtnBattlePhase = New System.Windows.Forms.RadioButton()
        Me.rbtnEndPhase = New System.Windows.Forms.RadioButton()
        Me.pPlayersField.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPlayersField
        '
        Me.pPlayersField.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pPlayersField.Controls.Add(Me.Panel3)
        Me.pPlayersField.Controls.Add(Me.GroupBox3)
        Me.pPlayersField.Controls.Add(Me.GroupBox2)
        Me.pPlayersField.Controls.Add(Me.GroupBox1)
        Me.pPlayersField.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pPlayersField.Location = New System.Drawing.Point(12, 439)
        Me.pPlayersField.Name = "pPlayersField"
        Me.pPlayersField.Size = New System.Drawing.Size(1494, 340)
        Me.pPlayersField.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblPlayersLifePoints)
        Me.Panel3.Controls.Add(Me.lblPlayerName)
        Me.Panel3.Location = New System.Drawing.Point(4, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 132)
        Me.Panel3.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Location = New System.Drawing.Point(310, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(943, 168)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PlayersHand"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(1281, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 299)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DeckZone"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1102, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Card Zones"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(16, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1494, 340)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblOpenentsLifePoints)
        Me.Panel4.Controls.Add(Me.lblOpenetsName)
        Me.Panel4.Location = New System.Drawing.Point(1290, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 132)
        Me.Panel4.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 299)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DeckZone"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox6.Location = New System.Drawing.Point(375, 169)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1102, 168)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Card Zones"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Location = New System.Drawing.Point(322, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(943, 168)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PlayersHand"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.rbtnEndPhase)
        Me.Panel2.Controls.Add(Me.rbtnBattlePhase)
        Me.Panel2.Controls.Add(Me.rbtnMainPhase)
        Me.Panel2.Controls.Add(Me.rbtnStanbyPhase)
        Me.Panel2.Location = New System.Drawing.Point(121, 371)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1272, 51)
        Me.Panel2.TabIndex = 2
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPlayerName.Location = New System.Drawing.Point(46, 4)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(72, 23)
        Me.lblPlayerName.TabIndex = 0
        Me.lblPlayerName.Text = "Name"
        '
        'lblOpenetsName
        '
        Me.lblOpenetsName.AutoSize = True
        Me.lblOpenetsName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenetsName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOpenetsName.Location = New System.Drawing.Point(68, 14)
        Me.lblOpenetsName.Name = "lblOpenetsName"
        Me.lblOpenetsName.Size = New System.Drawing.Size(72, 23)
        Me.lblOpenetsName.TabIndex = 1
        Me.lblOpenetsName.Text = "Name"
        '
        'lblPlayersLifePoints
        '
        Me.lblPlayersLifePoints.AutoSize = True
        Me.lblPlayersLifePoints.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayersLifePoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPlayersLifePoints.Location = New System.Drawing.Point(64, 55)
        Me.lblPlayersLifePoints.Name = "lblPlayersLifePoints"
        Me.lblPlayersLifePoints.Size = New System.Drawing.Size(66, 23)
        Me.lblPlayersLifePoints.TabIndex = 1
        Me.lblPlayersLifePoints.Text = "4000"
        '
        'lblOpenentsLifePoints
        '
        Me.lblOpenentsLifePoints.AutoSize = True
        Me.lblOpenentsLifePoints.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenentsLifePoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOpenentsLifePoints.Location = New System.Drawing.Point(74, 54)
        Me.lblOpenentsLifePoints.Name = "lblOpenentsLifePoints"
        Me.lblOpenentsLifePoints.Size = New System.Drawing.Size(66, 23)
        Me.lblOpenentsLifePoints.TabIndex = 2
        Me.lblOpenentsLifePoints.Text = "4000"
        '
        'rbtnStanbyPhase
        '
        Me.rbtnStanbyPhase.AutoSize = True
        Me.rbtnStanbyPhase.Location = New System.Drawing.Point(28, 18)
        Me.rbtnStanbyPhase.Name = "rbtnStanbyPhase"
        Me.rbtnStanbyPhase.Size = New System.Drawing.Size(97, 17)
        Me.rbtnStanbyPhase.TabIndex = 3
        Me.rbtnStanbyPhase.TabStop = True
        Me.rbtnStanbyPhase.Text = "Standby Phase"
        Me.rbtnStanbyPhase.UseVisualStyleBackColor = True
        '
        'rbtnMainPhase
        '
        Me.rbtnMainPhase.AutoSize = True
        Me.rbtnMainPhase.Location = New System.Drawing.Point(131, 18)
        Me.rbtnMainPhase.Name = "rbtnMainPhase"
        Me.rbtnMainPhase.Size = New System.Drawing.Size(81, 17)
        Me.rbtnMainPhase.TabIndex = 4
        Me.rbtnMainPhase.TabStop = True
        Me.rbtnMainPhase.Text = "Main Phase"
        Me.rbtnMainPhase.UseVisualStyleBackColor = True
        '
        'rbtnBattlePhase
        '
        Me.rbtnBattlePhase.AutoSize = True
        Me.rbtnBattlePhase.Location = New System.Drawing.Point(218, 18)
        Me.rbtnBattlePhase.Name = "rbtnBattlePhase"
        Me.rbtnBattlePhase.Size = New System.Drawing.Size(85, 17)
        Me.rbtnBattlePhase.TabIndex = 5
        Me.rbtnBattlePhase.TabStop = True
        Me.rbtnBattlePhase.Text = "Battle Phase"
        Me.rbtnBattlePhase.UseVisualStyleBackColor = True
        '
        'rbtnEndPhase
        '
        Me.rbtnEndPhase.AutoSize = True
        Me.rbtnEndPhase.Location = New System.Drawing.Point(309, 18)
        Me.rbtnEndPhase.Name = "rbtnEndPhase"
        Me.rbtnEndPhase.Size = New System.Drawing.Size(77, 17)
        Me.rbtnEndPhase.TabIndex = 6
        Me.rbtnEndPhase.TabStop = True
        Me.rbtnEndPhase.Text = "End Phase"
        Me.rbtnEndPhase.UseVisualStyleBackColor = True
        '
        'frmBattleField
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1518, 805)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pPlayersField)
        Me.Name = "frmBattleField"
        Me.Text = "BattleField"
        Me.pPlayersField.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pPlayersField As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblPlayersLifePoints As Label
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lblOpenentsLifePoints As Label
    Friend WithEvents lblOpenetsName As Label
    Friend WithEvents rbtnEndPhase As RadioButton
    Friend WithEvents rbtnBattlePhase As RadioButton
    Friend WithEvents rbtnMainPhase As RadioButton
    Friend WithEvents rbtnStanbyPhase As RadioButton
End Class
