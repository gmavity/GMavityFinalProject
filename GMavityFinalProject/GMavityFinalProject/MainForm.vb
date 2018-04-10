Public Class frmMain
    Private mTypes As New TaskTypes
    Private currentTask As Integer
    Private adapter As New TasksDataSetTableAdapters.TaskListTableAdapter
    Private formLoading As Boolean = True

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
        'load tooltips and information into form elements
        ttipEdit.SetToolTip(btnEdit, "Edit the selected task")
        ttipDelete.SetToolTip(btnDelete, "Delete the selected task")
        ttipSublist.SetToolTip(btnSublist, "Create a sublist of the selected tasks")

        'Fill the Type combobox with the various types, pulled from the TaskType class
        cmbTasks.DisplayMember = "Type"
        cmbTasks.ValueMember = "Type"
        cmbTasks.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTasks.SelectedIndex = -1

        updateView()

        formLoading = False
    End Sub

    Private Sub updateView()
        'updates the datagridview and the type combobox with fresh information
        'TODO: This line of code loads data into the 'TasksDataSet.TaskList' table. You can move, or remove it, as needed.
        Dim table As DataTable = adapter.GetData()
        dgvTasks.DataSource = table
        formLoading = True 'make sure that refreshing the combobox doesn't also filter the datagridview accidentally
        cmbTasks.DataSource = mTypes.Items
        formLoading = False
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

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        'allow the user to view all the tasks again after filtering on the type
        updateView()
    End Sub

    Private Sub cmbTasks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTasks.SelectedIndexChanged
        'filters the tasks based on the type selected
        If Not formLoading Then
            Dim type As String = cmbTasks.SelectedValue
            Dim table As DataTable = adapter.GetDataByType(type)
            dgvTasks.DataSource = table
        End If
    End Sub
End Class
