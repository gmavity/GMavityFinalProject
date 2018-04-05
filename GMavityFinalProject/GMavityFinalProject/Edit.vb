Public Class frmEdit
    Private adapter As New TasksDataSetTableAdapters.TaskListTableAdapter
    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill in all datafields with the associated information
        ttipRank.SetToolTip(lblRank, "1 being the lowest")
        ttipEffort.SetToolTip(lblEffort, "1 being the lowest")

        Dim table As TasksDataSet.TaskListDataTable
        table = adapter.GetData()
        Dim row As TasksDataSet.TaskListRow
        row = table.FindById(frmMain.currentTaskID)

        txtName.Text = row.Name
        txtType.Text = row.Type
        txtRank.Text = row.Rank
        txtEffort.Text = row.Effort
        txtDescription.Text = row.Description
        dtpDueDate.Value = row.DueDate

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'edits the task in the database, if all fields are filled in
        If txtName.Text = "" Or txtType.Text = "" Or txtRank.Text = "" Or txtEffort.Text = "" Then
            MessageBox.Show("Please fill in all fields")
        Else
            adapter.Update(txtName.Text, txtType.Text, txtRank.Text, txtEffort.Text, dtpDueDate.Value, txtDescription.Text, frmMain.currentTaskID, frmMain.currentTaskID)
            Me.Close()
        End If
    End Sub
End Class