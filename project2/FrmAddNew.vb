Public Class FrmAddNew
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMysql
        Dim row As DataRow

        Dim strItem As String = txt_Item.Text
        Dim strPrice As Decimal = txt_Price.Text
        Dim strSql = "INSERT INTO product VALUES (null, '" & strItem & "', '" & strPrice & "')"

        Dim CreateMySQL As New VBMysql

        If strItem = "" Then
            MessageBox.Show("Incomplete form")
        Else
            Try
                CreateMySQL.Insert_Row(strSql)
            Catch ex As Exception
                MessageBox.Show("Process data is not saved." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                txt_Item.Clear()
                txt_Price.Clear()
                Me.Hide()
                FrmAdminUpdate.ReadDataFromDB()
                FrmAdminUpdate.Show()
            End Try
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Hide()
        FrmAdminUpdate.Show()
    End Sub
End Class