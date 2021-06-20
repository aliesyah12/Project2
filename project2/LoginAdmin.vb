Public Class LoginAdmin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtName.Text = "admin" And txtPass.Text = "admin123" Then
            FrmAdminUpdate.Show()
            Me.Hide()
        Else
            Dim result = MessageBox.Show(" Invalid username/password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Clear()
            txtPass.Clear()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class