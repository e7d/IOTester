Imports System.IO
Imports IOTester

Public Class AddJob
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each LogicalDrive As String In Directory.GetLogicalDrives()
            ComboBoxDriveValue.Items.Add(LogicalDrive)
        Next

        TextBoxName.Text = "New Job"
        ComboBoxDriveValue.SelectedItem = "C:\"
        ComboBoxBufferSizeValue.SelectedItem = "32MB"
        ComboBoxSizeValue.SelectedItem = "1GB"
        ComboBoxDirectionValue.SelectedItem = "Read"

        TextBoxName.Focus()
    End Sub

    Private Sub GUI_CheckboxSequentialChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxSequential.CheckedChanged
        If CheckBoxSequential.Checked Then
            ComboBoxBufferSizeValue.SelectedItem = "32MB"
            ComboBoxBufferSizeValue.Enabled = False
        Else
            ComboBoxBufferSizeValue.Enabled = True
        End If
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim ID As Guid = Guid.NewGuid()

        Advanced.ListViewJobs.Items.Add( _
            New ListViewItem({ _
                New ListViewItem.ListViewSubItem() With {.Name = "Name", .Text = TextBoxName.Text}, _
                New ListViewItem.ListViewSubItem() With {.Name = "Direction", .Text = ComboBoxDirectionValue.SelectedItem}, _
                New ListViewItem.ListViewSubItem() With {.Name = "Drive", .Text = ComboBoxDriveValue.SelectedItem}, _
                New ListViewItem.ListViewSubItem() With {.Name = "Size", .Text = ComboBoxSizeValue.SelectedItem}, _
                New ListViewItem.ListViewSubItem() With {.Name = "BufferSize", .Text = ComboBoxBufferSizeValue.SelectedItem}, _
                New ListViewItem.ListViewSubItem() With {.Name = "QueueDepth", .Text = NumericUpDownQueueDepthValue.Value.ToString}, _
                New ListViewItem.ListViewSubItem() With {.Name = "Sequential", .Text = IIf(CheckBoxSequential.Checked, "Yes", "No")}, _
                New ListViewItem.ListViewSubItem() With {.Name = "Status", .Text = "Waiting"}, _
                New ListViewItem.ListViewSubItem() With {.Name = "Owner", .Text = ""}, _
                New ListViewItem.ListViewSubItem() With {.Name = "Start", .Text = ""}, _
                New ListViewItem.ListViewSubItem() With {.Name = "End", .Text = ""}, _
                New ListViewItem.ListViewSubItem() With {.Name = "Bandwidth", .Text = ""}, _
                New ListViewItem.ListViewSubItem() With {.Name = "Velocity", .Text = ""}, _
                New ListViewItem.ListViewSubItem() With {.Name = "ID", .Text = ID.ToString}, _
                New ListViewItem.ListViewSubItem() With {.Name = "StatusWindow", .Tag = New Status()} _
            }, 0) With {.Tag = New IOJob(New IOTest() With { _
                .ID = ID.ToString, _
                .Name = TextBoxName.Text, _
                .Direction = IIf((ComboBoxDirectionValue.SelectedItem = "Read"), IODirection.Read, IODirection.Write), _
                .Drive = ComboBoxDriveValue.SelectedItem, _
                .Size = New Bytes(ComboBoxSizeValue.SelectedItem.ToString), _
                .BufferSize = New Bytes(ComboBoxBufferSizeValue.SelectedItem.ToString), _
                .QueueDepth = CInt(NumericUpDownQueueDepthValue.Value), _
                .Sequential = CheckBoxSequential.Checked _
            }, True, 1000)} _
        )
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub
End Class