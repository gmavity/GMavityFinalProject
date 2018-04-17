﻿Public Class frmSublist
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the form
        Me.Close()
    End Sub

    Private Sub frmSublist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads information into the form when it is opened
        Dim adapter As New TasksDataSetTableAdapters.TaskListTableAdapter
        Dim taskIDs As List(Of Integer) = frmMain.sublistTaskIDs
        Dim ids As String = ""
        For index As Integer = 0 To taskIDs.Count - 1
            ids = ids & taskIDs(index)
            If index < taskIDs.Count - 1 Then
                ids = ids & ","
            End If
        Next
        Dim table As TasksDataSet.TaskListDataTable
        table = adapter.GetSublistDataBy(ids)
        dgvTasks.DataSource = table
    End Sub
End Class