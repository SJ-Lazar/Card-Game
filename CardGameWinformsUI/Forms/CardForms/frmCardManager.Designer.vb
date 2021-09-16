<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardManager
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
        Me.btnShowCard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowCard
        '
        Me.btnShowCard.Location = New System.Drawing.Point(70, 57)
        Me.btnShowCard.Name = "btnShowCard"
        Me.btnShowCard.Size = New System.Drawing.Size(220, 80)
        Me.btnShowCard.TabIndex = 0
        Me.btnShowCard.Text = "Button1"
        Me.btnShowCard.UseVisualStyleBackColor = True
        '
        'frmCardManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnShowCard)
        Me.Name = "frmCardManager"
        Me.Text = "frmCardManager"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShowCard As Button
End Class
