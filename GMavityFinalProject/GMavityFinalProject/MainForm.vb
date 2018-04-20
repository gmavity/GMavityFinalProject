'frmMain is the startup form of the project, and carries out most of the main functionality, like reading/deleting the data, filtering it, creating sublists, 
'and accessing the create/update functions and the help window
Public Class frmMain
    Private mTypes As New TaskTypes 'allows interfacing with the TaskTypes class to get only distinct task types
    Private currentTask As Integer 'keeps track of the current task ID, for use between forms
    Private adapter As New TasksDataSetTableAdapters.TaskListTableAdapter 'to interface with the database
    Private formLoading As Boolean = True 'to keep track of if the form is being popoulated
    Private sublistTasks = New List(Of Integer) 'keeps track of all task ids selected for sublisting

    Public ReadOnly Property currentTaskID() As Integer
        Get
            Return currentTask
        End Get
    End Property

    Public ReadOnly Property sublistTaskIDs() As List(Of Integer)
        Get
            Return sublistTasks
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
        If dgvTasks.SelectedRows.Count > 0 Then 'make sure the user selected a task to edit
            currentTask = CType(dgvTasks.SelectedRows(0).Cells(0).Value, Integer)
            frmEdit.ShowDialog()
            updateView()
        Else
            MessageBox.Show("Please select the task to edit")
        End If
    End Sub

    Private Sub btnSublist_Click(sender As Object, e As EventArgs) Handles btnSublist.Click
        'creates a list of the selected tasks to sublist, then opens a sublist form with those tasks
        sublistTasks = New List(Of Integer)
        If dgvTasks.SelectedRows.Count > 0 Then 'make sure the user selected tasks
            For index As Integer = 0 To dgvTasks.SelectedRows.Count - 1
                sublistTasks.add(CType(dgvTasks.SelectedRows(index).Cells(0).Value, Integer))
            Next
            frmSublist.ShowDialog()
        Else
            MessageBox.Show("Please select one or more tasks to create a sublist")
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load tooltips and information into form elements
        ttipEdit.SetToolTip(btnEdit, "Edit the selected task")
        ttipDelete.SetToolTip(btnDelete, "Delete the selected task")
        ttipSublist.SetToolTip(btnSublist, "Create a sublist of the selected tasks")
        ttipAll.SetToolTip(btnAll, "Show all tasks")
        ttipFilter.SetToolTip(cmbTasks, "Filter by type of task")

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
        Dim table As DataTable = adapter.GetData()
        dgvTasks.DataSource = table
        formLoading = True 'make sure that refreshing the combobox doesn't also filter the datagridview accidentally
        cmbTasks.DataSource = mTypes.Items
        formLoading = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'deletes selected task
        If dgvTasks.SelectedRows.Count > 0 Then 'make sure that the user selected a task to delete
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
