Public Class TaskTypes
    Private adapter As New TasksDataSetTableAdapters.TaskListTableAdapter 'allows access to the database
    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetDistinctTypeData() 'get only distinct types, no need for 8 instances of "schoolwork" to show up in the dropdown
            table.DefaultView.Sort = "Type"
            Return table
        End Get
    End Property
End Class
