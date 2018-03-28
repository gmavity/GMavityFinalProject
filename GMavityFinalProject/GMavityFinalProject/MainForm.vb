Public Class frmMain
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CreateTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateTaskToolStripMenuItem.Click
        frmCreate.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEdit.ShowDialog()
    End Sub

    Private Sub btnSublist_Click(sender As Object, e As EventArgs) Handles btnSublist.Click
        frmSublist.ShowDialog()
    End Sub
End Class
