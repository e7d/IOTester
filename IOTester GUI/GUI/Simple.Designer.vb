<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simple))
        Me.LabelWriteSequentialBandwidthValue = New System.Windows.Forms.Label()
        Me.LabelWriteSequentialBandwidthUnit = New System.Windows.Forms.Label()
        Me.LabelReadSequentialBandwidthUnit = New System.Windows.Forms.Label()
        Me.LabelReadSequentialBandwidthValue = New System.Windows.Forms.Label()
        Me.LabelSizeTitle = New System.Windows.Forms.Label()
        Me.ComboBoxSizeValue = New System.Windows.Forms.ComboBox()
        Me.LabelDriveTitle = New System.Windows.Forms.Label()
        Me.ComboBoxDriveValue = New System.Windows.Forms.ComboBox()
        Me.LabelWriteSequentialVelocityValue = New System.Windows.Forms.Label()
        Me.LabelWriteSequentialWriteUnit = New System.Windows.Forms.Label()
        Me.LabelReadSequentialVelocityUnit = New System.Windows.Forms.Label()
        Me.LabelReadSequentialVelocityValue = New System.Windows.Forms.Label()
        Me.ProgressBarBenchmark = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip_Main = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip_Main = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonSequential = New System.Windows.Forms.Button()
        Me.Button512KB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelRead512KBVelocityValue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelWrite512KBVelocityValue = New System.Windows.Forms.Label()
        Me.LabelRead512KBBandwidthUnit = New System.Windows.Forms.Label()
        Me.LabelRead512KBBandwidthValue = New System.Windows.Forms.Label()
        Me.LabelWrite512KBBandwidthUnit = New System.Windows.Forms.Label()
        Me.LabelWrite512KBBandwidthValue = New System.Windows.Forms.Label()
        Me.Button4KB = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelRead4KBVelocityValue = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelWrite4KBVelocityValue = New System.Windows.Forms.Label()
        Me.LabelRead4KBBandwidthUnit = New System.Windows.Forms.Label()
        Me.LabelRead4KBBandwidthValue = New System.Windows.Forms.Label()
        Me.LabelWrite4KBBandwidthUnit = New System.Windows.Forms.Label()
        Me.LabelWrite4KBBandwidthValue = New System.Windows.Forms.Label()
        Me.Button4KBQD32 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LabelRead4KBQD32VelocityValue = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LabelWrite4KBQD32VelocityValue = New System.Windows.Forms.Label()
        Me.LabelRead4KBQD32BandwidthUnit = New System.Windows.Forms.Label()
        Me.LabelRead4KBQD32BandwidthValue = New System.Windows.Forms.Label()
        Me.LabelWrite4KBQD32BandwidthUnit = New System.Windows.Forms.Label()
        Me.LabelWrite4KBQD32BandwidthValue = New System.Windows.Forms.Label()
        Me.LabelReadTitle = New System.Windows.Forms.Label()
        Me.LabelWriteTitle = New System.Windows.Forms.Label()
        Me.ButtonAll = New System.Windows.Forms.Button()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelWriteSequentialBandwidthValue
        '
        Me.LabelWriteSequentialBandwidthValue.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWriteSequentialBandwidthValue.ForeColor = System.Drawing.Color.Gray
        Me.LabelWriteSequentialBandwidthValue.Location = New System.Drawing.Point(226, 139)
        Me.LabelWriteSequentialBandwidthValue.Name = "LabelWriteSequentialBandwidthValue"
        Me.LabelWriteSequentialBandwidthValue.Size = New System.Drawing.Size(105, 38)
        Me.LabelWriteSequentialBandwidthValue.TabIndex = 2
        Me.LabelWriteSequentialBandwidthValue.Text = "-.--"
        Me.LabelWriteSequentialBandwidthValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelWriteSequentialBandwidthUnit
        '
        Me.LabelWriteSequentialBandwidthUnit.AutoSize = True
        Me.LabelWriteSequentialBandwidthUnit.Location = New System.Drawing.Point(325, 155)
        Me.LabelWriteSequentialBandwidthUnit.Name = "LabelWriteSequentialBandwidthUnit"
        Me.LabelWriteSequentialBandwidthUnit.Size = New System.Drawing.Size(23, 13)
        Me.LabelWriteSequentialBandwidthUnit.TabIndex = 3
        Me.LabelWriteSequentialBandwidthUnit.Text = "B/s"
        '
        'LabelReadSequentialBandwidthUnit
        '
        Me.LabelReadSequentialBandwidthUnit.AutoSize = True
        Me.LabelReadSequentialBandwidthUnit.Location = New System.Drawing.Point(196, 155)
        Me.LabelReadSequentialBandwidthUnit.Name = "LabelReadSequentialBandwidthUnit"
        Me.LabelReadSequentialBandwidthUnit.Size = New System.Drawing.Size(23, 13)
        Me.LabelReadSequentialBandwidthUnit.TabIndex = 6
        Me.LabelReadSequentialBandwidthUnit.Text = "B/s"
        '
        'LabelReadSequentialBandwidthValue
        '
        Me.LabelReadSequentialBandwidthValue.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReadSequentialBandwidthValue.ForeColor = System.Drawing.Color.Gray
        Me.LabelReadSequentialBandwidthValue.Location = New System.Drawing.Point(97, 139)
        Me.LabelReadSequentialBandwidthValue.Name = "LabelReadSequentialBandwidthValue"
        Me.LabelReadSequentialBandwidthValue.Size = New System.Drawing.Size(105, 38)
        Me.LabelReadSequentialBandwidthValue.TabIndex = 5
        Me.LabelReadSequentialBandwidthValue.Text = "-.--"
        Me.LabelReadSequentialBandwidthValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelSizeTitle
        '
        Me.LabelSizeTitle.AutoSize = True
        Me.LabelSizeTitle.Location = New System.Drawing.Point(11, 39)
        Me.LabelSizeTitle.Name = "LabelSizeTitle"
        Me.LabelSizeTitle.Size = New System.Drawing.Size(30, 13)
        Me.LabelSizeTitle.TabIndex = 10
        Me.LabelSizeTitle.Text = "Size:"
        '
        'ComboBoxSizeValue
        '
        Me.ComboBoxSizeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSizeValue.FormattingEnabled = True
        Me.ComboBoxSizeValue.Items.AddRange(New Object() {"50MB", "100MB", "500MB", "1GB", "2GB", "4GB"})
        Me.ComboBoxSizeValue.Location = New System.Drawing.Point(53, 36)
        Me.ComboBoxSizeValue.Name = "ComboBoxSizeValue"
        Me.ComboBoxSizeValue.Size = New System.Drawing.Size(295, 21)
        Me.ComboBoxSizeValue.TabIndex = 1
        Me.ToolTip_Main.SetToolTip(Me.ComboBoxSizeValue, "The total amout of computed data on drive.")
        '
        'LabelDriveTitle
        '
        Me.LabelDriveTitle.AutoSize = True
        Me.LabelDriveTitle.Location = New System.Drawing.Point(11, 67)
        Me.LabelDriveTitle.Name = "LabelDriveTitle"
        Me.LabelDriveTitle.Size = New System.Drawing.Size(36, 13)
        Me.LabelDriveTitle.TabIndex = 13
        Me.LabelDriveTitle.Text = "Drive:"
        '
        'ComboBoxDriveValue
        '
        Me.ComboBoxDriveValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDriveValue.FormattingEnabled = True
        Me.ComboBoxDriveValue.Location = New System.Drawing.Point(53, 64)
        Me.ComboBoxDriveValue.Name = "ComboBoxDriveValue"
        Me.ComboBoxDriveValue.Size = New System.Drawing.Size(295, 21)
        Me.ComboBoxDriveValue.TabIndex = 2
        Me.ToolTip_Main.SetToolTip(Me.ComboBoxDriveValue, "The drive where to execute the benchmark.")
        '
        'LabelWriteSequentialVelocityValue
        '
        Me.LabelWriteSequentialVelocityValue.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWriteSequentialVelocityValue.ForeColor = System.Drawing.Color.Black
        Me.LabelWriteSequentialVelocityValue.Location = New System.Drawing.Point(284, 169)
        Me.LabelWriteSequentialVelocityValue.Name = "LabelWriteSequentialVelocityValue"
        Me.LabelWriteSequentialVelocityValue.Size = New System.Drawing.Size(39, 13)
        Me.LabelWriteSequentialVelocityValue.TabIndex = 15
        Me.LabelWriteSequentialVelocityValue.Text = "-"
        Me.LabelWriteSequentialVelocityValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelWriteSequentialWriteUnit
        '
        Me.LabelWriteSequentialWriteUnit.AutoSize = True
        Me.LabelWriteSequentialWriteUnit.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWriteSequentialWriteUnit.Location = New System.Drawing.Point(327, 169)
        Me.LabelWriteSequentialWriteUnit.Name = "LabelWriteSequentialWriteUnit"
        Me.LabelWriteSequentialWriteUnit.Size = New System.Drawing.Size(22, 12)
        Me.LabelWriteSequentialWriteUnit.TabIndex = 16
        Me.LabelWriteSequentialWriteUnit.Text = "IO/s"
        '
        'LabelReadSequentialVelocityUnit
        '
        Me.LabelReadSequentialVelocityUnit.AutoSize = True
        Me.LabelReadSequentialVelocityUnit.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReadSequentialVelocityUnit.Location = New System.Drawing.Point(198, 169)
        Me.LabelReadSequentialVelocityUnit.Name = "LabelReadSequentialVelocityUnit"
        Me.LabelReadSequentialVelocityUnit.Size = New System.Drawing.Size(22, 12)
        Me.LabelReadSequentialVelocityUnit.TabIndex = 18
        Me.LabelReadSequentialVelocityUnit.Text = "IO/s"
        '
        'LabelReadSequentialVelocityValue
        '
        Me.LabelReadSequentialVelocityValue.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReadSequentialVelocityValue.ForeColor = System.Drawing.Color.Black
        Me.LabelReadSequentialVelocityValue.Location = New System.Drawing.Point(155, 169)
        Me.LabelReadSequentialVelocityValue.Name = "LabelReadSequentialVelocityValue"
        Me.LabelReadSequentialVelocityValue.Size = New System.Drawing.Size(39, 13)
        Me.LabelReadSequentialVelocityValue.TabIndex = 17
        Me.LabelReadSequentialVelocityValue.Text = "-"
        Me.LabelReadSequentialVelocityValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ProgressBarBenchmark
        '
        Me.ProgressBarBenchmark.Location = New System.Drawing.Point(0, 342)
        Me.ProgressBarBenchmark.Name = "ProgressBarBenchmark"
        Me.ProgressBarBenchmark.Size = New System.Drawing.Size(360, 25)
        Me.ProgressBarBenchmark.Step = 1
        Me.ProgressBarBenchmark.TabIndex = 19
        '
        'MenuStrip_Main
        '
        Me.MenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStrip_Main.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip_Main.Name = "MenuStrip_Main"
        Me.MenuStrip_Main.Size = New System.Drawing.Size(360, 24)
        Me.MenuStrip_Main.TabIndex = 701
        Me.MenuStrip_Main.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdvancedModeToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        Me.OptionsToolStripMenuItem.Visible = False
        '
        'AdvancedModeToolStripMenuItem
        '
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
        'ToolTip_Main
        '
        Me.ToolTip_Main.AutoPopDelay = 5000
        Me.ToolTip_Main.InitialDelay = 2000
        Me.ToolTip_Main.ReshowDelay = 1000
        '
        'ButtonSequential
        '
        Me.ButtonSequential.Location = New System.Drawing.Point(12, 146)
        Me.ButtonSequential.Name = "ButtonSequential"
        Me.ButtonSequential.Size = New System.Drawing.Size(75, 43)
        Me.ButtonSequential.TabIndex = 3
        Me.ButtonSequential.Text = "Sequential"
        Me.ButtonSequential.UseVisualStyleBackColor = True
        '
        'Button512KB
        '
        Me.Button512KB.Location = New System.Drawing.Point(12, 195)
        Me.Button512KB.Name = "Button512KB"
        Me.Button512KB.Size = New System.Drawing.Size(75, 43)
        Me.Button512KB.TabIndex = 4
        Me.Button512KB.Text = "512 KB"
        Me.Button512KB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 12)
        Me.Label1.TabIndex = 710
        Me.Label1.Text = "IO/s"
        '
        'LabelRead512KBVelocityValue
        '
        Me.LabelRead512KBVelocityValue.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRead512KBVelocityValue.ForeColor = System.Drawing.Color.Black
        Me.LabelRead512KBVelocityValue.Location = New System.Drawing.Point(155, 218)
        Me.LabelRead512KBVelocityValue.Name = "LabelRead512KBVelocityValue"
        Me.LabelRead512KBVelocityValue.Size = New System.Drawing.Size(39, 13)
        Me.LabelRead512KBVelocityValue.TabIndex = 709
        Me.LabelRead512KBVelocityValue.Text = "-"
        Me.LabelRead512KBVelocityValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 12)
        Me.Label3.TabIndex = 708
        Me.Label3.Text = "IO/s"
        '
        'LabelWrite512KBVelocityValue
        '
        Me.LabelWrite512KBVelocityValue.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWrite512KBVelocityValue.ForeColor = System.Drawing.Color.Black
        Me.LabelWrite512KBVelocityValue.Location = New System.Drawing.Point(284, 218)
        Me.LabelWrite512KBVelocityValue.Name = "LabelWrite512KBVelocityValue"
        Me.LabelWrite512KBVelocityValue.Size = New System.Drawing.Size(39, 13)
        Me.LabelWrite512KBVelocityValue.TabIndex = 707
        Me.LabelWrite512KBVelocityValue.Text = "-"
        Me.LabelWrite512KBVelocityValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelRead512KBBandwidthUnit
        '
        Me.LabelRead512KBBandwidthUnit.AutoSize = True
        Me.LabelRead512KBBandwidthUnit.Location = New System.Drawing.Point(196, 204)
        Me.LabelRead512KBBandwidthUnit.Name = "LabelRead512KBBandwidthUnit"
        Me.LabelRead512KBBandwidthUnit.Size = New System.Drawing.Size(23, 13)
        Me.LabelRead512KBBandwidthUnit.TabIndex = 706
        Me.LabelRead512KBBandwidthUnit.Text = "B/s"
        '
        'LabelRead512KBBandwidthValue
        '
        Me.LabelRead512KBBandwidthValue.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRead512KBBandwidthValue.ForeColor = System.Drawing.Color.Gray
        Me.LabelRead512KBBandwidthValue.Location = New System.Drawing.Point(97, 188)
        Me.LabelRead512KBBandwidthValue.Name = "LabelRead512KBBandwidthValue"
        Me.LabelRead512KBBandwidthValue.Size = New System.Drawing.Size(105, 38)
        Me.LabelRead512KBBandwidthValue.TabIndex = 705
        Me.LabelRead512KBBandwidthValue.Text = "-.--"
        Me.LabelRead512KBBandwidthValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelWrite512KBBandwidthUnit
        '
        Me.LabelWrite512KBBandwidthUnit.AutoSize = True
        Me.LabelWrite512KBBandwidthUnit.Location = New System.Drawing.Point(325, 204)
        Me.LabelWrite512KBBandwidthUnit.Name = "LabelWrite512KBBandwidthUnit"
        Me.LabelWrite512KBBandwidthUnit.Size = New System.Drawing.Size(23, 13)
        Me.LabelWrite512KBBandwidthUnit.TabIndex = 704
        Me.LabelWrite512KBBandwidthUnit.Text = "B/s"
        '
        'LabelWrite512KBBandwidthValue
        '
        Me.LabelWrite512KBBandwidthValue.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWrite512KBBandwidthValue.ForeColor = System.Drawing.Color.Gray
        Me.LabelWrite512KBBandwidthValue.Location = New System.Drawing.Point(226, 188)
        Me.LabelWrite512KBBandwidthValue.Name = "LabelWrite512KBBandwidthValue"
        Me.LabelWrite512KBBandwidthValue.Size = New System.Drawing.Size(105, 38)
        Me.LabelWrite512KBBandwidthValue.TabIndex = 703
        Me.LabelWrite512KBBandwidthValue.Text = "-.--"
        Me.LabelWrite512KBBandwidthValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button4KB
        '
        Me.Button4KB.Location = New System.Drawing.Point(12, 244)
        Me.Button4KB.Name = "Button4KB"
        Me.Button4KB.Size = New System.Drawing.Size(75, 43)
        Me.Button4KB.TabIndex = 5
        Me.Button4KB.Text = "4 KB"
        Me.Button4KB.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(198, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 12)
        Me.Label9.TabIndex = 719
        Me.Label9.Text = "IO/s"
        '
        'LabelRead4KBVelocityValue
        '
        Me.LabelRead4KBVelocityValue.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRead4KBVelocityValue.ForeColor = System.Drawing.Color.Black
        Me.LabelRead4KBVelocityValue.Location = New System.Drawing.Point(155, 267)
        Me.LabelRead4KBVelocityValue.Name = "LabelRead4KBVelocityValue"
        Me.LabelRead4KBVelocityValue.Size = New System.Drawing.Size(39, 13)
        Me.LabelRead4KBVelocityValue.TabIndex = 718
        Me.LabelRead4KBVelocityValue.Text = "-"
        Me.LabelRead4KBVelocityValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(327, 267)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 12)
        Me.Label11.TabIndex = 717
        Me.Label11.Text = "IO/s"
        '
        'LabelWrite4KBVelocityValue
        '
        Me.LabelWrite4KBVelocityValue.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWrite4KBVelocityValue.ForeColor = System.Drawing.Color.Black
        Me.LabelWrite4KBVelocityValue.Location = New System.Drawing.Point(284, 267)
        Me.LabelWrite4KBVelocityValue.Name = "LabelWrite4KBVelocityValue"
        Me.LabelWrite4KBVelocityValue.Size = New System.Drawing.Size(39, 13)
        Me.LabelWrite4KBVelocityValue.TabIndex = 716
        Me.LabelWrite4KBVelocityValue.Text = "-"
        Me.LabelWrite4KBVelocityValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelRead4KBBandwidthUnit
        '
        Me.LabelRead4KBBandwidthUnit.AutoSize = True
        Me.LabelRead4KBBandwidthUnit.Location = New System.Drawing.Point(196, 253)
        Me.LabelRead4KBBandwidthUnit.Name = "LabelRead4KBBandwidthUnit"
        Me.LabelRead4KBBandwidthUnit.Size = New System.Drawing.Size(23, 13)
        Me.LabelRead4KBBandwidthUnit.TabIndex = 715
        Me.LabelRead4KBBandwidthUnit.Text = "B/s"
        '
        'LabelRead4KBBandwidthValue
        '
        Me.LabelRead4KBBandwidthValue.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRead4KBBandwidthValue.ForeColor = System.Drawing.Color.Gray
        Me.LabelRead4KBBandwidthValue.Location = New System.Drawing.Point(97, 237)
        Me.LabelRead4KBBandwidthValue.Name = "LabelRead4KBBandwidthValue"
        Me.LabelRead4KBBandwidthValue.Size = New System.Drawing.Size(105, 38)
        Me.LabelRead4KBBandwidthValue.TabIndex = 714
        Me.LabelRead4KBBandwidthValue.Text = "-.--"
        Me.LabelRead4KBBandwidthValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelWrite4KBBandwidthUnit
        '
        Me.LabelWrite4KBBandwidthUnit.AutoSize = True
        Me.LabelWrite4KBBandwidthUnit.Location = New System.Drawing.Point(325, 253)
        Me.LabelWrite4KBBandwidthUnit.Name = "LabelWrite4KBBandwidthUnit"
        Me.LabelWrite4KBBandwidthUnit.Size = New System.Drawing.Size(23, 13)
        Me.LabelWrite4KBBandwidthUnit.TabIndex = 713
        Me.LabelWrite4KBBandwidthUnit.Text = "B/s"
        '
        'LabelWrite4KBBandwidthValue
        '
        Me.LabelWrite4KBBandwidthValue.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWrite4KBBandwidthValue.ForeColor = System.Drawing.Color.Gray
        Me.LabelWrite4KBBandwidthValue.Location = New System.Drawing.Point(226, 237)
        Me.LabelWrite4KBBandwidthValue.Name = "LabelWrite4KBBandwidthValue"
        Me.LabelWrite4KBBandwidthValue.Size = New System.Drawing.Size(105, 38)
        Me.LabelWrite4KBBandwidthValue.TabIndex = 712
        Me.LabelWrite4KBBandwidthValue.Text = "-.--"
        Me.LabelWrite4KBBandwidthValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button4KBQD32
        '
        Me.Button4KBQD32.Location = New System.Drawing.Point(12, 293)
        Me.Button4KBQD32.Name = "Button4KBQD32"
        Me.Button4KBQD32.Size = New System.Drawing.Size(75, 43)
        Me.Button4KBQD32.TabIndex = 6
        Me.Button4KBQD32.Text = "4 KB (QD=32)"
        Me.Button4KBQD32.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(198, 316)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 12)
        Me.Label17.TabIndex = 728
        Me.Label17.Text = "IO/s"
        '
        'LabelRead4KBQD32VelocityValue
        '
        Me.LabelRead4KBQD32VelocityValue.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRead4KBQD32VelocityValue.ForeColor = System.Drawing.Color.Black
        Me.LabelRead4KBQD32VelocityValue.Location = New System.Drawing.Point(155, 316)
        Me.LabelRead4KBQD32VelocityValue.Name = "LabelRead4KBQD32VelocityValue"
        Me.LabelRead4KBQD32VelocityValue.Size = New System.Drawing.Size(39, 13)
        Me.LabelRead4KBQD32VelocityValue.TabIndex = 727
        Me.LabelRead4KBQD32VelocityValue.Text = "-"
        Me.LabelRead4KBQD32VelocityValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(327, 316)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 12)
        Me.Label19.TabIndex = 726
        Me.Label19.Text = "IO/s"
        '
        'LabelWrite4KBQD32VelocityValue
        '
        Me.LabelWrite4KBQD32VelocityValue.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWrite4KBQD32VelocityValue.ForeColor = System.Drawing.Color.Black
        Me.LabelWrite4KBQD32VelocityValue.Location = New System.Drawing.Point(284, 316)
        Me.LabelWrite4KBQD32VelocityValue.Name = "LabelWrite4KBQD32VelocityValue"
        Me.LabelWrite4KBQD32VelocityValue.Size = New System.Drawing.Size(39, 13)
        Me.LabelWrite4KBQD32VelocityValue.TabIndex = 725
        Me.LabelWrite4KBQD32VelocityValue.Text = "-"
        Me.LabelWrite4KBQD32VelocityValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelRead4KBQD32BandwidthUnit
        '
        Me.LabelRead4KBQD32BandwidthUnit.AutoSize = True
        Me.LabelRead4KBQD32BandwidthUnit.Location = New System.Drawing.Point(196, 302)
        Me.LabelRead4KBQD32BandwidthUnit.Name = "LabelRead4KBQD32BandwidthUnit"
        Me.LabelRead4KBQD32BandwidthUnit.Size = New System.Drawing.Size(23, 13)
        Me.LabelRead4KBQD32BandwidthUnit.TabIndex = 724
        Me.LabelRead4KBQD32BandwidthUnit.Text = "B/s"
        '
        'LabelRead4KBQD32BandwidthValue
        '
        Me.LabelRead4KBQD32BandwidthValue.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRead4KBQD32BandwidthValue.ForeColor = System.Drawing.Color.Gray
        Me.LabelRead4KBQD32BandwidthValue.Location = New System.Drawing.Point(97, 286)
        Me.LabelRead4KBQD32BandwidthValue.Name = "LabelRead4KBQD32BandwidthValue"
        Me.LabelRead4KBQD32BandwidthValue.Size = New System.Drawing.Size(105, 38)
        Me.LabelRead4KBQD32BandwidthValue.TabIndex = 723
        Me.LabelRead4KBQD32BandwidthValue.Text = "-.--"
        Me.LabelRead4KBQD32BandwidthValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelWrite4KBQD32BandwidthUnit
        '
        Me.LabelWrite4KBQD32BandwidthUnit.AutoSize = True
        Me.LabelWrite4KBQD32BandwidthUnit.Location = New System.Drawing.Point(325, 302)
        Me.LabelWrite4KBQD32BandwidthUnit.Name = "LabelWrite4KBQD32BandwidthUnit"
        Me.LabelWrite4KBQD32BandwidthUnit.Size = New System.Drawing.Size(23, 13)
        Me.LabelWrite4KBQD32BandwidthUnit.TabIndex = 722
        Me.LabelWrite4KBQD32BandwidthUnit.Text = "B/s"
        '
        'LabelWrite4KBQD32BandwidthValue
        '
        Me.LabelWrite4KBQD32BandwidthValue.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWrite4KBQD32BandwidthValue.ForeColor = System.Drawing.Color.Gray
        Me.LabelWrite4KBQD32BandwidthValue.Location = New System.Drawing.Point(226, 286)
        Me.LabelWrite4KBQD32BandwidthValue.Name = "LabelWrite4KBQD32BandwidthValue"
        Me.LabelWrite4KBQD32BandwidthValue.Size = New System.Drawing.Size(105, 38)
        Me.LabelWrite4KBQD32BandwidthValue.TabIndex = 721
        Me.LabelWrite4KBQD32BandwidthValue.Text = "-.--"
        Me.LabelWrite4KBQD32BandwidthValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelReadTitle
        '
        Me.LabelReadTitle.AutoSize = True
        Me.LabelReadTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReadTitle.Location = New System.Drawing.Point(142, 99)
        Me.LabelReadTitle.Name = "LabelReadTitle"
        Me.LabelReadTitle.Size = New System.Drawing.Size(60, 30)
        Me.LabelReadTitle.TabIndex = 730
        Me.LabelReadTitle.Text = "Read"
        '
        'LabelWriteTitle
        '
        Me.LabelWriteTitle.AutoSize = True
        Me.LabelWriteTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWriteTitle.Location = New System.Drawing.Point(268, 99)
        Me.LabelWriteTitle.Name = "LabelWriteTitle"
        Me.LabelWriteTitle.Size = New System.Drawing.Size(63, 30)
        Me.LabelWriteTitle.TabIndex = 731
        Me.LabelWriteTitle.Text = "Write"
        '
        'ButtonAll
        '
        Me.ButtonAll.Location = New System.Drawing.Point(12, 97)
        Me.ButtonAll.Name = "ButtonAll"
        Me.ButtonAll.Size = New System.Drawing.Size(75, 43)
        Me.ButtonAll.TabIndex = 732
        Me.ButtonAll.Text = "All"
        Me.ButtonAll.UseVisualStyleBackColor = True
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'Simple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 367)
        Me.Controls.Add(Me.ButtonAll)
        Me.Controls.Add(Me.LabelWriteTitle)
        Me.Controls.Add(Me.LabelReadTitle)
        Me.Controls.Add(Me.Button4KBQD32)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LabelRead4KBQD32VelocityValue)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.LabelWrite4KBQD32VelocityValue)
        Me.Controls.Add(Me.LabelRead4KBQD32BandwidthUnit)
        Me.Controls.Add(Me.LabelRead4KBQD32BandwidthValue)
        Me.Controls.Add(Me.LabelWrite4KBQD32BandwidthUnit)
        Me.Controls.Add(Me.LabelWrite4KBQD32BandwidthValue)
        Me.Controls.Add(Me.Button4KB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabelRead4KBVelocityValue)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabelWrite4KBVelocityValue)
        Me.Controls.Add(Me.LabelRead4KBBandwidthUnit)
        Me.Controls.Add(Me.LabelRead4KBBandwidthValue)
        Me.Controls.Add(Me.LabelWrite4KBBandwidthUnit)
        Me.Controls.Add(Me.LabelWrite4KBBandwidthValue)
        Me.Controls.Add(Me.Button512KB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelRead512KBVelocityValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelWrite512KBVelocityValue)
        Me.Controls.Add(Me.LabelRead512KBBandwidthUnit)
        Me.Controls.Add(Me.LabelRead512KBBandwidthValue)
        Me.Controls.Add(Me.LabelWrite512KBBandwidthUnit)
        Me.Controls.Add(Me.LabelWrite512KBBandwidthValue)
        Me.Controls.Add(Me.ButtonSequential)
        Me.Controls.Add(Me.ProgressBarBenchmark)
        Me.Controls.Add(Me.LabelReadSequentialVelocityUnit)
        Me.Controls.Add(Me.LabelReadSequentialVelocityValue)
        Me.Controls.Add(Me.LabelWriteSequentialWriteUnit)
        Me.Controls.Add(Me.LabelWriteSequentialVelocityValue)
        Me.Controls.Add(Me.ComboBoxDriveValue)
        Me.Controls.Add(Me.LabelDriveTitle)
        Me.Controls.Add(Me.ComboBoxSizeValue)
        Me.Controls.Add(Me.LabelSizeTitle)
        Me.Controls.Add(Me.LabelReadSequentialBandwidthUnit)
        Me.Controls.Add(Me.LabelReadSequentialBandwidthValue)
        Me.Controls.Add(Me.LabelWriteSequentialBandwidthUnit)
        Me.Controls.Add(Me.LabelWriteSequentialBandwidthValue)
        Me.Controls.Add(Me.MenuStrip_Main)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip_Main
        Me.MaximizeBox = False
        Me.Name = "Simple"
        Me.Text = "IO Tester"
        Me.MenuStrip_Main.ResumeLayout(False)
        Me.MenuStrip_Main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelWriteSequentialBandwidthValue As System.Windows.Forms.Label
    Friend WithEvents LabelWriteSequentialBandwidthUnit As System.Windows.Forms.Label
    Friend WithEvents LabelReadSequentialBandwidthUnit As System.Windows.Forms.Label
    Friend WithEvents LabelReadSequentialBandwidthValue As System.Windows.Forms.Label
    Friend WithEvents LabelSizeTitle As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSizeValue As System.Windows.Forms.ComboBox
    Friend WithEvents LabelDriveTitle As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDriveValue As System.Windows.Forms.ComboBox
    Friend WithEvents LabelWriteSequentialVelocityValue As System.Windows.Forms.Label
    Friend WithEvents LabelWriteSequentialWriteUnit As System.Windows.Forms.Label
    Friend WithEvents LabelReadSequentialVelocityUnit As System.Windows.Forms.Label
    Friend WithEvents LabelReadSequentialVelocityValue As System.Windows.Forms.Label
    Friend WithEvents ProgressBarBenchmark As System.Windows.Forms.ProgressBar
    Friend WithEvents MenuStrip_Main As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip_Main As System.Windows.Forms.ToolTip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonSequential As System.Windows.Forms.Button
    Friend WithEvents Button512KB As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelRead512KBVelocityValue As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelWrite512KBVelocityValue As System.Windows.Forms.Label
    Friend WithEvents LabelRead512KBBandwidthUnit As System.Windows.Forms.Label
    Friend WithEvents LabelRead512KBBandwidthValue As System.Windows.Forms.Label
    Friend WithEvents LabelWrite512KBBandwidthUnit As System.Windows.Forms.Label
    Friend WithEvents LabelWrite512KBBandwidthValue As System.Windows.Forms.Label
    Friend WithEvents Button4KB As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LabelRead4KBVelocityValue As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelWrite4KBVelocityValue As System.Windows.Forms.Label
    Friend WithEvents LabelRead4KBBandwidthUnit As System.Windows.Forms.Label
    Friend WithEvents LabelRead4KBBandwidthValue As System.Windows.Forms.Label
    Friend WithEvents LabelWrite4KBBandwidthUnit As System.Windows.Forms.Label
    Friend WithEvents LabelWrite4KBBandwidthValue As System.Windows.Forms.Label
    Friend WithEvents Button4KBQD32 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LabelRead4KBQD32VelocityValue As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LabelWrite4KBQD32VelocityValue As System.Windows.Forms.Label
    Friend WithEvents LabelRead4KBQD32BandwidthUnit As System.Windows.Forms.Label
    Friend WithEvents LabelRead4KBQD32BandwidthValue As System.Windows.Forms.Label
    Friend WithEvents LabelWrite4KBQD32BandwidthUnit As System.Windows.Forms.Label
    Friend WithEvents LabelWrite4KBQD32BandwidthValue As System.Windows.Forms.Label
    Friend WithEvents LabelReadTitle As System.Windows.Forms.Label
    Friend WithEvents LabelWriteTitle As System.Windows.Forms.Label
    Friend WithEvents ButtonAll As System.Windows.Forms.Button
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
