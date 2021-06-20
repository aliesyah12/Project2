Public Class FrmEdit
    Public Id As Integer
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMysql
        Dim row As DataRow
        Dim CreateMySQL As New VBMysql

        Dim strItem As String = txtItem.Text
        Dim strPrice As Decimal = txtPrice.Text

        Dim strSql = "UPDATE product SET Item = '" & strItem & "', Price ='" & strPrice & "' WHERE Id = '" & Id & "'"

        Try
            CreateMySQL.Insert_Row(strSql)
            Dim strList(3, 2) As String
            Static row1 As Integer = 0
            Dim i, j As Integer

            strList(row1, 0) = strItem
            strList(row1, 1) = strPrice
            row1 += 1

            FrmAdminUpdate.dgvProduct.RowCount = row1
            For i = 0 To row1 - 1
                For j = 0 To 2
                    FrmAdminUpdate.dgvProduct.Rows(i).Cells(j).Value = strList(i, j)
                Next
            Next
        Catch ex As Exception
            MessageBox.Show("Process data is not saved." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Hide()
            FrmAdminUpdate.ReadDataFromDB()
            FrmAdminUpdate.Show()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        FrmAdminUpdate.Show()
    End Sub
End Class