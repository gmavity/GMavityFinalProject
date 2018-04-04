Public Class frmCreate
    Private Sub frmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttipRank.SetToolTip(lblRank, "1 being the lowest")
        ttipEffort.SetToolTip(lblEffort, "1 being the lowest")
    End Sub
End Class