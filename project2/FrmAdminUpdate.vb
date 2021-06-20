Public Class FrmAdminUpdate
    Public Sub ReadDataFromDB()
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMysql

        Try
            retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM product")
            If retrieveTable.CreateDataReader.HasRows = False Then
                MessageBox.Show("Tiada data ditemui.", "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim row As DataRow
            dgvProduct.Rows.Clear()

            For Each row In retrieveTable.Rows
                dgvProduct.Rows.Add(row("Id"), row("Item"), row("Price"))
            Next
            retrieveTable = Nothing
        Catch ex As Exception
            MessageBox.Show("Proses baca data gagal." & vbCrLf & ex.Message, "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmAdminUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadDataFromDB()
    End Sub

    Private Sub dgvList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim strBenda As String = dgvProduct.Item(0, e.RowIndex).Value.ToString()
        Dim Result As New ArrayList
        Dim retrieveRow As New VBMysql
        Dim strSql As String = "SELECT * FROM product WHERE Id = '" + strBenda + "'"
        Try
            Result = retrieveRow.Retrieve_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Proses baca data gagal." & vbCrLf & ex.Message, "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For Each row As Dictionary(Of String, Object) In Result
            With FrmUpdate
                .Id = row("Id").ToString()
                .txtItem.Text = row("Item").ToString()
                .txtPrice.Text = row("Price").ToString()
            End With
        Next
        Me.Hide()
        FrmUpdate.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        FrmAddNew.Show()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Me.Hide()
        AdminOrder.Show()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class