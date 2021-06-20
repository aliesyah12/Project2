Public Class CustomerOrder
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim strName As String = txtName.Text
        Dim strItem As String = txtItems.Text
        Dim strPrice As String = txtPrice.Text

        If strName = "" Then
            MessageBox.Show("Incomplete Form")
        Else
            AdminOrder.txtName.Text = txtName.Text
            AdminOrder.txtItem.Text = txtItems.Text
            AdminOrder.txtPrice.Text = txtPrice.Text
            Dim result = MessageBox.Show("Thankyou for your order!" & vbCrLf & "We have notify seller about your order", "Clothing Store", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If result = DialogResult.OK Then
                txtName.Clear()
                txtItems.Clear()
                txtPrice.Clear()
                Me.Hide()
                Customer.Show()
            End If

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Customer.Show()

    End Sub
End Class