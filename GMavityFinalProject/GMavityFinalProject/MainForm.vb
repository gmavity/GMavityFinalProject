Public Class frmMain
    Private mTypes As New TaskTypes
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CreateTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateTaskToolStripMenuItem.Click
        frmCreate.ShowDialog()
        updateView()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEdit.ShowDialog()
        updateView()
    End Sub

    Private Sub btnSublist_Click(sender As Object, e As EventArgs) Handles btnSublist.Click
        frmSublist.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateView()
        'Fill the Type combobox with the various types, pulled from the TaskType class
        cmbTasks.DisplayMember = "Type"
        cmbTasks.ValueMember = "TypeId"
        cmbTasks.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTasks.SelectedIndex = -1
    End Sub

    Private Sub updateView()
        'updates the datagridview and the type combobox with fresh information
        'TODO: This line of code loads data into the 'TasksDataSet.TaskList' table. You can move, or remove it, as needed.
        Me.TaskListTableAdapter.Fill(Me.TasksDataSet.TaskList)
        cmbTasks.DataSource = mTypes.Items
    End Sub
End Class
