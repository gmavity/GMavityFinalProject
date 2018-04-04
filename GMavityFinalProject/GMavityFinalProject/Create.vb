Public Class frmCreate
    Private Sub frmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttipRank.SetToolTip(lblRank, "1 being the lowest")
        ttipEffort.SetToolTip(lblEffort, "1 being the lowest")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'adds the task to the database, if all fields are filled in
        Dim adapter As New TasksDataSetTableAdapters.TaskListTableAdapter
        If txtName.Text = "" Or txtType.Text = "" Or txtRank.Text = "" Or txtEffort.Text = "" Then
            MessageBox.Show("Please fill in all fields")
        Else
            adapter.Insert(txtName.Text, txtType.Text, txtRank.Text, txtEffort.Text, dtpDueDate.Value, txtDescription.Text)
            Me.Close()
        End If
    End Sub
End Class