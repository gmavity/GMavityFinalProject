Public Class frmMain
    Private mTypes As New TaskTypes
    Private currentTask As Integer
    Private adapter As New TasksDataSetTableAdapters.TaskListTableAdapter

    Public ReadOnly Property currentTaskID() As Integer
        Get
            Return currentTask
        End Get
    End Property

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'closes program
        Me.Close()
    End Sub

    Private Sub CreateTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateTaskToolStripMenuItem.Click
        'opens form to create new task
        frmCreate.ShowDialog()
        updateView()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'opens About form
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'edits selected task
        If dgvTasks.SelectedRows.Count > 0 Then
            currentTask = CType(dgvTasks.SelectedRows(0).Cells(0).Value, Integer)
            frmEdit.ShowDialog()
            updateView()
        Else
            MessageBox.Show("Please select the task to edit")
        End If
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'deletes selected task
        If dgvTasks.SelectedRows.Count > 0 Then
            currentTask = CType(dgvTasks.SelectedRows(0).Cells(0).Value, Integer)
            adapter.Delete(currentTask)
            updateView()
        Else
            MessageBox.Show("Please select the task to delete")
        End If
    End Sub
End Class
