<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMainMenu
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlCenter = New System.Windows.Forms.Panel()
        Me.btnManageAI = New System.Windows.Forms.Button()
        Me.btnManagePlayers = New System.Windows.Forms.Button()
        Me.btnManageCards = New System.Windows.Forms.Button()
        Me.btnCardManager = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlCenter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(784, 100)
        Me.pnlHeader.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome Admin Nike"
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 661)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(784, 100)
        Me.pnlFooter.TabIndex = 2
        '
        'pnlCenter
        '
        Me.pnlCenter.BackColor = System.Drawing.Color.Gray
        Me.pnlCenter.Controls.Add(Me.btnCardManager)
        Me.pnlCenter.Controls.Add(Me.btnManageAI)
        Me.pnlCenter.Controls.Add(Me.btnManagePlayers)
        Me.pnlCenter.Controls.Add(Me.btnManageCards)
        Me.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCenter.Location = New System.Drawing.Point(0, 100)
        Me.pnlCenter.Name = "pnlCenter"
        Me.pnlCenter.Size = New System.Drawing.Size(784, 561)
        Me.pnlCenter.TabIndex = 3
        '
        'btnManageAI
        '
        Me.btnManageAI.Location = New System.Drawing.Point(477, 52)
        Me.btnManageAI.Name = "btnManageAI"
        Me.btnManageAI.Size = New System.Drawing.Size(122, 75)
        Me.btnManageAI.TabIndex = 2
        Me.btnManageAI.Text = "Manage AI"
        Me.btnManageAI.UseVisualStyleBackColor = True
        '
        'btnManagePlayers
        '
        Me.btnManagePlayers.Location = New System.Drawing.Point(349, 52)
        Me.btnManagePlayers.Name = "btnManagePlayers"
        Me.btnManagePlayers.Size = New System.Drawing.Size(122, 75)
        Me.btnManagePlayers.TabIndex = 1
        Me.btnManagePlayers.Text = "Manage Players"
        Me.btnManagePlayers.UseVisualStyleBackColor = True
        '
        'btnManageCards
        '
        Me.btnManageCards.Location = New System.Drawing.Point(221, 52)
        Me.btnManageCards.Name = "btnManageCards"
        Me.btnManageCards.Size = New System.Drawing.Size(122, 75)
        Me.btnManageCards.TabIndex = 0
        Me.btnManageCards.Text = "Manage Cards "
        Me.btnManageCards.UseVisualStyleBackColor = True
        '
        'btnCardManager
        '
        Me.btnCardManager.Location = New System.Drawing.Point(221, 133)
        Me.btnCardManager.Name = "btnCardManager"
        Me.btnCardManager.Size = New System.Drawing.Size(122, 75)
        Me.btnCardManager.TabIndex = 3
        Me.btnCardManager.Text = "Card Manager"
        Me.btnCardManager.UseVisualStyleBackColor = True
        '
        'mdiMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 761)
        Me.Controls.Add(Me.pnlCenter)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.IsMdiContainer = True
        Me.Name = "mdiMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlCenter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlCenter As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnManageAI As Button
    Friend WithEvents btnManagePlayers As Button
    Friend WithEvents btnManageCards As Button
    Friend WithEvents btnCardManager As Button
End Class
