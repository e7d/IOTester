<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddJob
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
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ComboBoxDriveValue = New System.Windows.Forms.ComboBox()
        Me.LabelDriveTitle = New System.Windows.Forms.Label()
        Me.CheckBoxSequential = New System.Windows.Forms.CheckBox()
        Me.ComboBoxSizeValue = New System.Windows.Forms.ComboBox()
        Me.LabelSizeTitle = New System.Windows.Forms.Label()
        Me.ComboBoxBufferSizeValue = New System.Windows.Forms.ComboBox()
        Me.LabelBufferSizeTitle = New System.Windows.Forms.Label()
        Me.LabelDirectionTitle = New System.Windows.Forms.Label()
        Me.ComboBoxDirectionValue = New System.Windows.Forms.ComboBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.NumericUpDownQueueDepthValue = New System.Windows.Forms.NumericUpDown()
        Me.LabelQueueDepthTitle = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownQueueDepthValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.Location = New System.Drawing.Point(128, 209)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 0
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOK.Location = New System.Drawing.Point(47, 209)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 1
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ComboBoxDriveValue
        '
        Me.ComboBoxDriveValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDriveValue.FormattingEnabled = True
        Me.ComboBoxDriveValue.Location = New System.Drawing.Point(67, 65)
        Me.ComboBoxDriveValue.Name = "ComboBoxDriveValue"
        Me.ComboBoxDriveValue.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxDriveValue.TabIndex = 404
        '
        'LabelDriveTitle
        '
        Me.LabelDriveTitle.AutoSize = True
        Me.LabelDriveTitle.Location = New System.Drawing.Point(12, 68)
        Me.LabelDriveTitle.Name = "LabelDriveTitle"
        Me.LabelDriveTitle.Size = New System.Drawing.Size(35, 13)
        Me.LabelDriveTitle.TabIndex = 403
        Me.LabelDriveTitle.Text = "Drive:"
        '
        'CheckBoxSequential
        '
        Me.CheckBoxSequential.AutoSize = True
        Me.CheckBoxSequential.Location = New System.Drawing.Point(67, 172)
        Me.CheckBoxSequential.Name = "CheckBoxSequential"
        Me.CheckBoxSequential.Size = New System.Drawing.Size(76, 17)
        Me.CheckBoxSequential.TabIndex = 407
        Me.CheckBoxSequential.Text = "Sequential"
        Me.CheckBoxSequential.UseVisualStyleBackColor = True
        '
        'ComboBoxSizeValue
        '
        Me.ComboBoxSizeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSizeValue.FormattingEnabled = True
        Me.ComboBoxSizeValue.Items.AddRange(New Object() {"1MB", "10MB", "100MB", "1GB", "4GB"})
        Me.ComboBoxSizeValue.Location = New System.Drawing.Point(67, 92)
        Me.ComboBoxSizeValue.Name = "ComboBoxSizeValue"
        Me.ComboBoxSizeValue.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxSizeValue.TabIndex = 406
        '
        'LabelSizeTitle
        '
        Me.LabelSizeTitle.AutoSize = True
        Me.LabelSizeTitle.Location = New System.Drawing.Point(12, 95)
        Me.LabelSizeTitle.Name = "LabelSizeTitle"
        Me.LabelSizeTitle.Size = New System.Drawing.Size(30, 13)
        Me.LabelSizeTitle.TabIndex = 402
        Me.LabelSizeTitle.Text = "Size:"
        '
        'ComboBoxBufferSizeValue
        '
        Me.ComboBoxBufferSizeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBufferSizeValue.FormattingEnabled = True
        Me.ComboBoxBufferSizeValue.Items.AddRange(New Object() {"4KB", "512KB", "32MB"})
        Me.ComboBoxBufferSizeValue.Location = New System.Drawing.Point(67, 119)
        Me.ComboBoxBufferSizeValue.Name = "ComboBoxBufferSizeValue"
        Me.ComboBoxBufferSizeValue.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxBufferSizeValue.TabIndex = 405
        '
        'LabelBufferSizeTitle
        '
        Me.LabelBufferSizeTitle.AutoSize = True
        Me.LabelBufferSizeTitle.Location = New System.Drawing.Point(12, 122)
        Me.LabelBufferSizeTitle.Name = "LabelBufferSizeTitle"
        Me.LabelBufferSizeTitle.Size = New System.Drawing.Size(38, 13)
        Me.LabelBufferSizeTitle.TabIndex = 401
        Me.LabelBufferSizeTitle.Text = "Buffer:"
        '
        'LabelDirectionTitle
        '
        Me.LabelDirectionTitle.AutoSize = True
        Me.LabelDirectionTitle.Location = New System.Drawing.Point(12, 41)
        Me.LabelDirectionTitle.Name = "LabelDirectionTitle"
        Me.LabelDirectionTitle.Size = New System.Drawing.Size(34, 13)
        Me.LabelDirectionTitle.TabIndex = 408
        Me.LabelDirectionTitle.Text = "Type:"
        '
        'ComboBoxDirectionValue
        '
        Me.ComboBoxDirectionValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDirectionValue.FormattingEnabled = True
        Me.ComboBoxDirectionValue.Items.AddRange(New Object() {"Read", "Write"})
        Me.ComboBoxDirectionValue.Location = New System.Drawing.Point(67, 38)
        Me.ComboBoxDirectionValue.Name = "ComboBoxDirectionValue"
        Me.ComboBoxDirectionValue.Size = New System.Drawing.Size(136, 21)
        Me.ComboBoxDirectionValue.TabIndex = 409
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(67, 12)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxName.TabIndex = 410
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(12, 15)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(38, 13)
        Me.LabelName.TabIndex = 411
        Me.LabelName.Text = "Name:"
        '
        'NumericUpDownQueueDepthValue
        '
        Me.NumericUpDownQueueDepthValue.Location = New System.Drawing.Point(67, 146)
        Me.NumericUpDownQueueDepthValue.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.NumericUpDownQueueDepthValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownQueueDepthValue.Name = "NumericUpDownQueueDepthValue"
        Me.NumericUpDownQueueDepthValue.Size = New System.Drawing.Size(136, 20)
        Me.NumericUpDownQueueDepthValue.TabIndex = 412
        Me.NumericUpDownQueueDepthValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelQueueDepthTitle
        '
        Me.LabelQueueDepthTitle.AutoSize = True
        Me.LabelQueueDepthTitle.Location = New System.Drawing.Point(12, 148)
        Me.LabelQueueDepthTitle.Name = "LabelQueueDepthTitle"
        Me.LabelQueueDepthTitle.Size = New System.Drawing.Size(26, 13)
        Me.LabelQueueDepthTitle.TabIndex = 413
        Me.LabelQueueDepthTitle.Text = "QD:"
        '
        'AddJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 244)
        Me.Controls.Add(Me.LabelQueueDepthTitle)
        Me.Controls.Add(Me.NumericUpDownQueueDepthValue)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.ComboBoxDirectionValue)
        Me.Controls.Add(Me.LabelDirectionTitle)
        Me.Controls.Add(Me.ComboBoxDriveValue)
        Me.Controls.Add(Me.LabelDriveTitle)
        Me.Controls.Add(Me.CheckBoxSequential)
        Me.Controls.Add(Me.ComboBoxSizeValue)
        Me.Controls.Add(Me.LabelSizeTitle)
        Me.Controls.Add(Me.ComboBoxBufferSizeValue)
        Me.Controls.Add(Me.LabelBufferSizeTitle)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimumSize = New System.Drawing.Size(231, 200)
        Me.Name = "AddJob"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Add Job"
        CType(Me.NumericUpDownQueueDepthValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ComboBoxDriveValue As System.Windows.Forms.ComboBox
    Friend WithEvents LabelDriveTitle As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSequential As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxSizeValue As System.Windows.Forms.ComboBox
    Friend WithEvents LabelSizeTitle As System.Windows.Forms.Label
    Friend WithEvents ComboBoxBufferSizeValue As System.Windows.Forms.ComboBox
    Friend WithEvents LabelBufferSizeTitle As System.Windows.Forms.Label
    Friend WithEvents LabelDirectionTitle As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDirectionValue As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownQueueDepthValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelQueueDepthTitle As System.Windows.Forms.Label
End Class
