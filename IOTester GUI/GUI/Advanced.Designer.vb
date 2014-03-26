<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advanced
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Advanced))
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripJobs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemAddJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemDeleteJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemProcessJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemAbortJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemChangeStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemPostPoned = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemWaiting = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPageLog = New System.Windows.Forms.TabPage()
        Me.TreeViewLog = New System.Windows.Forms.TreeView()
        Me.TabPageQueue = New System.Windows.Forms.TabPage()
        Me.ButtonBenchmarkStop = New System.Windows.Forms.Button()
        Me.ButtonBenchmarkStart = New System.Windows.Forms.Button()
        Me.ListViewJobs = New System.Windows.Forms.ListView()
        Me.ColumnHeaderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDrive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBufferSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderQueueDepth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSequential = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderOwner = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderEnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBandwidth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderVelocity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControlAdvanced = New System.Windows.Forms.TabControl()
        Me.OpenFileDialogLoad = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStripMain.SuspendLayout()
        Me.ContextMenuStripJobs.SuspendLayout()
        Me.TabPageLog.SuspendLayout()
        Me.TabPageQueue.SuspendLayout()
        Me.TabControlAdvanced.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1083, 24)
        Me.MenuStripMain.TabIndex = 702
        Me.MenuStripMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save as..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdvancedModeToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AdvancedModeToolStripMenuItem
        '
        Me.AdvancedModeToolStripMenuItem.Checked = True
        Me.AdvancedModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AdvancedModeToolStripMenuItem.Name = "AdvancedModeToolStripMenuItem"
        Me.AdvancedModeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AdvancedModeToolStripMenuItem.Text = "Advanced Mode"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.ToolStripMenuItem3, Me.AboutToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem2.Text = "?"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(115, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ContextMenuStripJobs
        '
        Me.ContextMenuStripJobs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemAddJob, Me.ToolStripMenuItemDeleteJob, Me.ToolStripMenuItem4, Me.ToolStripMenuItemProcessJob, Me.ToolStripMenuItemAbortJob, Me.ToolStripMenuItem5, Me.ToolStripMenuItemChangeStatus})
        Me.ContextMenuStripJobs.Name = "ContextMenuStrip_Jobs"
        Me.ContextMenuStripJobs.Size = New System.Drawing.Size(151, 126)
        '
        'ToolStripMenuItemAddJob
        '
        Me.ToolStripMenuItemAddJob.Name = "ToolStripMenuItemAddJob"
        Me.ToolStripMenuItemAddJob.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItemAddJob.Text = "Add"
        '
        'ToolStripMenuItemDeleteJob
        '
        Me.ToolStripMenuItemDeleteJob.Name = "ToolStripMenuItemDeleteJob"
        Me.ToolStripMenuItemDeleteJob.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItemDeleteJob.Text = "Delete "
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(147, 6)
        '
        'ToolStripMenuItemProcessJob
        '
        Me.ToolStripMenuItemProcessJob.Name = "ToolStripMenuItemProcessJob"
        Me.ToolStripMenuItemProcessJob.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItemProcessJob.Text = "Process"
        '
        'ToolStripMenuItemAbortJob
        '
        Me.ToolStripMenuItemAbortJob.Name = "ToolStripMenuItemAbortJob"
        Me.ToolStripMenuItemAbortJob.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItemAbortJob.Text = "Abort"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(147, 6)
        '
        'ToolStripMenuItemChangeStatus
        '
        Me.ToolStripMenuItemChangeStatus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemPostPoned, Me.ToolStripMenuItemWaiting})
        Me.ToolStripMenuItemChangeStatus.Name = "ToolStripMenuItemChangeStatus"
        Me.ToolStripMenuItemChangeStatus.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItemChangeStatus.Text = "Change Status"
        '
        'ToolStripMenuItemPostPoned
        '
        Me.ToolStripMenuItemPostPoned.Name = "ToolStripMenuItemPostPoned"
        Me.ToolStripMenuItemPostPoned.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItemPostPoned.Text = "Postponed"
        '
        'ToolStripMenuItemWaiting
        '
        Me.ToolStripMenuItemWaiting.Name = "ToolStripMenuItemWaiting"
        Me.ToolStripMenuItemWaiting.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItemWaiting.Text = "Waiting"
        '
        'TabPageLog
        '
        Me.TabPageLog.Controls.Add(Me.TreeViewLog)
        Me.TabPageLog.Location = New System.Drawing.Point(4, 22)
        Me.TabPageLog.Name = "TabPageLog"
        Me.TabPageLog.Size = New System.Drawing.Size(1051, 377)
        Me.TabPageLog.TabIndex = 2
        Me.TabPageLog.Text = "Log"
        Me.TabPageLog.UseVisualStyleBackColor = True
        '
        'TreeViewLog
        '
        Me.TreeViewLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeViewLog.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewLog.Name = "TreeViewLog"
        Me.TreeViewLog.Size = New System.Drawing.Size(616, 389)
        Me.TreeViewLog.TabIndex = 0
        '
        'TabPageQueue
        '
        Me.TabPageQueue.Controls.Add(Me.ButtonBenchmarkStop)
        Me.TabPageQueue.Controls.Add(Me.ButtonBenchmarkStart)
        Me.TabPageQueue.Controls.Add(Me.ListViewJobs)
        Me.TabPageQueue.Location = New System.Drawing.Point(4, 22)
        Me.TabPageQueue.Name = "TabPageQueue"
        Me.TabPageQueue.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageQueue.Size = New System.Drawing.Size(1051, 377)
        Me.TabPageQueue.TabIndex = 1
        Me.TabPageQueue.Text = "Queue"
        Me.TabPageQueue.UseVisualStyleBackColor = True
        '
        'ButtonBenchmarkStop
        '
        Me.ButtonBenchmarkStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBenchmarkStop.Location = New System.Drawing.Point(965, 348)
        Me.ButtonBenchmarkStop.Name = "ButtonBenchmarkStop"
        Me.ButtonBenchmarkStop.Size = New System.Drawing.Size(80, 23)
        Me.ButtonBenchmarkStop.TabIndex = 2
        Me.ButtonBenchmarkStop.Text = "Stop"
        Me.ButtonBenchmarkStop.UseVisualStyleBackColor = True
        '
        'ButtonBenchmarkStart
        '
        Me.ButtonBenchmarkStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBenchmarkStart.Location = New System.Drawing.Point(879, 348)
        Me.ButtonBenchmarkStart.Name = "ButtonBenchmarkStart"
        Me.ButtonBenchmarkStart.Size = New System.Drawing.Size(80, 23)
        Me.ButtonBenchmarkStart.TabIndex = 1
        Me.ButtonBenchmarkStart.Text = "Start"
        Me.ButtonBenchmarkStart.UseVisualStyleBackColor = True
        '
        'ListViewJobs
        '
        Me.ListViewJobs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewJobs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewJobs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderName, Me.ColumnHeaderType, Me.ColumnHeaderDrive, Me.ColumnHeaderSize, Me.ColumnHeaderBufferSize, Me.ColumnHeaderQueueDepth, Me.ColumnHeaderSequential, Me.ColumnHeaderStatus, Me.ColumnHeaderOwner, Me.ColumnHeaderStart, Me.ColumnHeaderEnd, Me.ColumnHeaderBandwidth, Me.ColumnHeaderVelocity})
        Me.ListViewJobs.ContextMenuStrip = Me.ContextMenuStripJobs
        Me.ListViewJobs.FullRowSelect = True
        Me.ListViewJobs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewJobs.Location = New System.Drawing.Point(0, 0)
        Me.ListViewJobs.Name = "ListViewJobs"
        Me.ListViewJobs.Size = New System.Drawing.Size(1051, 342)
        Me.ListViewJobs.TabIndex = 0
        Me.ListViewJobs.UseCompatibleStateImageBehavior = False
        Me.ListViewJobs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderName
        '
        Me.ColumnHeaderName.Text = "Name"
        Me.ColumnHeaderName.Width = 120
        '
        'ColumnHeaderType
        '
        Me.ColumnHeaderType.Text = "Type"
        '
        'ColumnHeaderDrive
        '
        Me.ColumnHeaderDrive.Text = "Drive"
        '
        'ColumnHeaderSize
        '
        Me.ColumnHeaderSize.Text = "Size"
        '
        'ColumnHeaderBufferSize
        '
        Me.ColumnHeaderBufferSize.Text = "Buffer"
        '
        'ColumnHeaderQueueDepth
        '
        Me.ColumnHeaderQueueDepth.Text = "QD"
        Me.ColumnHeaderQueueDepth.Width = 30
        '
        'ColumnHeaderSequential
        '
        Me.ColumnHeaderSequential.Text = "Sequential"
        Me.ColumnHeaderSequential.Width = 70
        '
        'ColumnHeaderStatus
        '
        Me.ColumnHeaderStatus.Text = "Status"
        Me.ColumnHeaderStatus.Width = 70
        '
        'ColumnHeaderOwner
        '
        Me.ColumnHeaderOwner.Text = "Owner"
        Me.ColumnHeaderOwner.Width = 100
        '
        'ColumnHeaderStart
        '
        Me.ColumnHeaderStart.Text = "Start"
        Me.ColumnHeaderStart.Width = 120
        '
        'ColumnHeaderEnd
        '
        Me.ColumnHeaderEnd.Text = "End"
        Me.ColumnHeaderEnd.Width = 120
        '
        'ColumnHeaderBandwidth
        '
        Me.ColumnHeaderBandwidth.Text = "Bandwidth"
        Me.ColumnHeaderBandwidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderBandwidth.Width = 90
        '
        'ColumnHeaderVelocity
        '
        Me.ColumnHeaderVelocity.Text = "Velocity"
        Me.ColumnHeaderVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderVelocity.Width = 90
        '
        'TabControlAdvanced
        '
        Me.TabControlAdvanced.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlAdvanced.Controls.Add(Me.TabPageQueue)
        Me.TabControlAdvanced.Controls.Add(Me.TabPageLog)
        Me.TabControlAdvanced.Location = New System.Drawing.Point(12, 27)
        Me.TabControlAdvanced.Name = "TabControlAdvanced"
        Me.TabControlAdvanced.SelectedIndex = 0
        Me.TabControlAdvanced.Size = New System.Drawing.Size(1059, 403)
        Me.TabControlAdvanced.TabIndex = 703
        '
        'OpenFileDialogLoad
        '
        Me.OpenFileDialogLoad.DefaultExt = "ini"
        Me.OpenFileDialogLoad.Filter = "Ini files|*.ini|All files|*.*"
        '
        'Advanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 442)
        Me.Controls.Add(Me.TabControlAdvanced)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Advanced"
        Me.Text = "IO Tester"
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.ContextMenuStripJobs.ResumeLayout(False)
        Me.TabPageLog.ResumeLayout(False)
        Me.TabPageQueue.ResumeLayout(False)
        Me.TabControlAdvanced.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripJobs As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItemAddJob As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemDeleteJob As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPageLog As System.Windows.Forms.TabPage
    Friend WithEvents TreeViewLog As System.Windows.Forms.TreeView
    Friend WithEvents TabPageQueue As System.Windows.Forms.TabPage
    Friend WithEvents ButtonBenchmarkStart As System.Windows.Forms.Button
    Friend WithEvents ListViewJobs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeaderDrive As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderType As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderBufferSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderSequential As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderBandwidth As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderVelocity As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabControlAdvanced As System.Windows.Forms.TabControl
    Friend WithEvents ColumnHeaderName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripMenuItemChangeStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemPostPoned As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemWaiting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeaderOwner As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderStart As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderEnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents OpenFileDialogLoad As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonBenchmarkStop As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemProcessJob As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAbortJob As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColumnHeaderQueueDepth As System.Windows.Forms.ColumnHeader
End Class
