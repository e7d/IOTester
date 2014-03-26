<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Status))
        Me.LabelTimeRemaining = New System.Windows.Forms.Label()
        Me.LabelTimeElapsed = New System.Windows.Forms.Label()
        Me.LabelVelocity = New System.Windows.Forms.Label()
        Me.TextBoxTimeRemaining = New System.Windows.Forms.TextBox()
        Me.TextBoxTimeElapsed = New System.Windows.Forms.TextBox()
        Me.TextBoxVelocity = New System.Windows.Forms.TextBox()
        Me.TextBoxBandwidth = New System.Windows.Forms.TextBox()
        Me.LabelBandwidth = New System.Windows.Forms.Label()
        Me.ProgressBarJob = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'LabelTimeRemaining
        '
        Me.LabelTimeRemaining.AutoSize = True
        Me.LabelTimeRemaining.Location = New System.Drawing.Point(12, 87)
        Me.LabelTimeRemaining.Name = "LabelTimeRemaining"
        Me.LabelTimeRemaining.Size = New System.Drawing.Size(81, 13)
        Me.LabelTimeRemaining.TabIndex = 1
        Me.LabelTimeRemaining.Text = "Time remaining:"
        '
        'LabelTimeElapsed
        '
        Me.LabelTimeElapsed.AutoSize = True
        Me.LabelTimeElapsed.Location = New System.Drawing.Point(12, 61)
        Me.LabelTimeElapsed.Name = "LabelTimeElapsed"
        Me.LabelTimeElapsed.Size = New System.Drawing.Size(73, 13)
        Me.LabelTimeElapsed.TabIndex = 6
        Me.LabelTimeElapsed.Text = "Time elapsed:"
        '
        'LabelVelocity
        '
        Me.LabelVelocity.AutoSize = True
        Me.LabelVelocity.Location = New System.Drawing.Point(12, 35)
        Me.LabelVelocity.Name = "LabelVelocity"
        Me.LabelVelocity.Size = New System.Drawing.Size(47, 13)
        Me.LabelVelocity.TabIndex = 5
        Me.LabelVelocity.Text = "Velocity:"
        '
        'TextBoxTimeRemaining
        '
        Me.TextBoxTimeRemaining.BackColor = System.Drawing.Color.White
        Me.TextBoxTimeRemaining.ForeColor = System.Drawing.Color.Black
        Me.TextBoxTimeRemaining.Location = New System.Drawing.Point(99, 84)
        Me.TextBoxTimeRemaining.Name = "TextBoxTimeRemaining"
        Me.TextBoxTimeRemaining.ReadOnly = True
        Me.TextBoxTimeRemaining.ShortcutsEnabled = False
        Me.TextBoxTimeRemaining.Size = New System.Drawing.Size(173, 20)
        Me.TextBoxTimeRemaining.TabIndex = 4
        Me.TextBoxTimeRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxTimeElapsed
        '
        Me.TextBoxTimeElapsed.BackColor = System.Drawing.Color.White
        Me.TextBoxTimeElapsed.ForeColor = System.Drawing.Color.Black
        Me.TextBoxTimeElapsed.Location = New System.Drawing.Point(99, 58)
        Me.TextBoxTimeElapsed.Name = "TextBoxTimeElapsed"
        Me.TextBoxTimeElapsed.ReadOnly = True
        Me.TextBoxTimeElapsed.ShortcutsEnabled = False
        Me.TextBoxTimeElapsed.Size = New System.Drawing.Size(173, 20)
        Me.TextBoxTimeElapsed.TabIndex = 3
        Me.TextBoxTimeElapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxVelocity
        '
        Me.TextBoxVelocity.BackColor = System.Drawing.Color.White
        Me.TextBoxVelocity.ForeColor = System.Drawing.Color.Black
        Me.TextBoxVelocity.Location = New System.Drawing.Point(99, 32)
        Me.TextBoxVelocity.Name = "TextBoxVelocity"
        Me.TextBoxVelocity.ReadOnly = True
        Me.TextBoxVelocity.ShortcutsEnabled = False
        Me.TextBoxVelocity.Size = New System.Drawing.Size(173, 20)
        Me.TextBoxVelocity.TabIndex = 2
        Me.TextBoxVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxBandwidth
        '
        Me.TextBoxBandwidth.BackColor = System.Drawing.Color.White
        Me.TextBoxBandwidth.ForeColor = System.Drawing.Color.Black
        Me.TextBoxBandwidth.Location = New System.Drawing.Point(99, 6)
        Me.TextBoxBandwidth.Name = "TextBoxBandwidth"
        Me.TextBoxBandwidth.ReadOnly = True
        Me.TextBoxBandwidth.ShortcutsEnabled = False
        Me.TextBoxBandwidth.Size = New System.Drawing.Size(173, 20)
        Me.TextBoxBandwidth.TabIndex = 1
        Me.TextBoxBandwidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelBandwidth
        '
        Me.LabelBandwidth.AutoSize = True
        Me.LabelBandwidth.Location = New System.Drawing.Point(12, 9)
        Me.LabelBandwidth.Name = "LabelBandwidth"
        Me.LabelBandwidth.Size = New System.Drawing.Size(60, 13)
        Me.LabelBandwidth.TabIndex = 0
        Me.LabelBandwidth.Text = "Bandwidth:"
        '
        'ProgressBarJob
        '
        Me.ProgressBarJob.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBarJob.Location = New System.Drawing.Point(0, 113)
        Me.ProgressBarJob.Name = "ProgressBarJob"
        Me.ProgressBarJob.Size = New System.Drawing.Size(284, 23)
        Me.ProgressBarJob.Step = 1
        Me.ProgressBarJob.TabIndex = 1
        '
        'Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 136)
        Me.Controls.Add(Me.LabelTimeRemaining)
        Me.Controls.Add(Me.ProgressBarJob)
        Me.Controls.Add(Me.LabelTimeElapsed)
        Me.Controls.Add(Me.LabelVelocity)
        Me.Controls.Add(Me.LabelBandwidth)
        Me.Controls.Add(Me.TextBoxTimeRemaining)
        Me.Controls.Add(Me.TextBoxBandwidth)
        Me.Controls.Add(Me.TextBoxTimeElapsed)
        Me.Controls.Add(Me.TextBoxVelocity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(300, 170)
        Me.MinimumSize = New System.Drawing.Size(300, 170)
        Me.Name = "Status"
        Me.Text = "Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxBandwidth As System.Windows.Forms.TextBox
    Friend WithEvents LabelBandwidth As System.Windows.Forms.Label
    Friend WithEvents TextBoxTimeRemaining As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTimeElapsed As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVelocity As System.Windows.Forms.TextBox
    Friend WithEvents LabelTimeRemaining As System.Windows.Forms.Label
    Friend WithEvents LabelTimeElapsed As System.Windows.Forms.Label
    Friend WithEvents LabelVelocity As System.Windows.Forms.Label
    Friend WithEvents ProgressBarJob As System.Windows.Forms.ProgressBar
End Class
