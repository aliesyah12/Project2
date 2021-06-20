Public Class AdminOrder
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        FrmAdminUpdate.Show()
    End Sub
End Class