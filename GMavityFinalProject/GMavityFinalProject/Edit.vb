Public Class frmEdit
    Private adapter As New TasksDataSetTableAdapters.TaskListTableAdapter 'allows access to the database
    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load tooltips and fill in all datafields with the associated information
        ttipName.SetToolTip(lblName, "Assign a name for your task")
        ttipType.SetToolTip(lblType, "Schoolwork, housework, etc")
        ttipRank.SetToolTip(lblRank, "1 being the lowest")
        ttipEffort.SetToolTip(lblEffort, "1 being the lowest")
        ttipDueDate.SetToolTip(lblDueDate, "When is this due?")
        ttipDescription.SetToolTip(lblDescription, "Make some notes for yourself")

        'get the db information on the selected task
        Dim table As TasksDataSet.TaskListDataTable
        table = adapter.GetData()
        Dim row As TasksDataSet.TaskListRow
        row = table.FindById(frmMain.currentTaskID)

        'fill in the form with the db information
        txtName.Text = row.Name
        txtType.Text = row.Type

        Dim rank As Integer = row.Rank
        Dim effort As Integer = row.Effort

        If rank = 1 Then
            radRank1.Checked = True
        ElseIf rank = 2 Then
            radRank2.Checked = True
        ElseIf rank = 3 Then
            radRank3.Checked = True
        ElseIf rank = 4 Then
            radRank4.Checked = True
        Else
            radRank5.Checked = True
        End If
        If effort = 1 Then
            radEffort1.Checked = True
        ElseIf effort = 2 Then
            radEffort2.Checked = True
        ElseIf effort = 3 Then
            radEffort3.Checked = True
        ElseIf effort = 4 Then
            radEffort4.Checked = True
        Else
            radEffort5.Checked = True
        End If

        txtDescription.Text = row.Description
        dtpDueDate.Value = row.DueDate

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'edits the task in the database, if all fields are filled in
        If txtName.Text = "" Or txtType.Text = "" Then 'make sure the name and type aren't blank (rank and effort are radio buttons, and description is ok if it's blank)
            MessageBox.Show("Please fill in all fields")
        Else
            Dim rank As Integer = 5
            Dim effort As Integer = 5

            If radRank1.Checked Then
                rank = 1
            ElseIf radRank2.Checked Then
                rank = 2
            ElseIf radRank3.Checked Then
                rank = 3
            ElseIf radRank4.Checked Then
                rank = 4
            End If
            If radEffort1.Checked Then
                effort = 1
            ElseIf radEffort2.Checked Then
                effort = 2
            ElseIf radEffort3.Checked Then
                effort = 3
            ElseIf radEffort4.Checked Then
                effort = 4
            End If

            adapter.Update(txtName.Text, txtType.Text, rank, effort, dtpDueDate.Value, txtDescription.Text, frmMain.currentTaskID, frmMain.currentTaskID)
            Me.Close() 'once the entry is logged, the form should close automatically
        End If
    End Sub
End Class