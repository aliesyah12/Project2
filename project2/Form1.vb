Public Class Form1
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        LoginAdmin.Show()
    End Sub

    Private Sub btnCust_Click(sender As Object, e As EventArgs) Handles btnCust.Click
        Me.Hide()
        Customer.Show()
    End Sub
End Class
