Public Class frmCreate
    Private Sub frmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load tooltips
        ttipName.SetToolTip(lblName, "Assign a name for your task")
        ttipType.SetToolTip(lblType, "Schoolwork, housework, etc")
        ttipRank.SetToolTip(lblRank, "1 being the lowest")
        ttipEffort.SetToolTip(lblEffort, "1 being the lowest")
        ttipDueDate.SetToolTip(lblDueDate, "When is this due?")
        ttipDescription.SetToolTip(lblDescription, "Make some notes for yourself")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'adds the task to the database, if all fields are filled in
        Dim adapter As New TasksDataSetTableAdapters.TaskListTableAdapter
        If txtName.Text = "" Or txtType.Text = "" Then
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

            adapter.Insert(txtName.Text, txtType.Text, rank, effort, dtpDueDate.Value, txtDescription.Text)
            Me.Close()
        End If
    End Sub
End Class