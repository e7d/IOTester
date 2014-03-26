Public Class Status
    Private Sub Status_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        e.Cancel = True
    End Sub
End Class