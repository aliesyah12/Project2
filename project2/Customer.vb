Imports MySql.Data.MySqlClient
Public Class Customer
    Public Sub ReadDataFromDB()
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMysql

        Try
            retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM product")
            If retrieveTable.CreateDataReader.HasRows = False Then
                MessageBox.Show("Tiada data ditemui.", "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim row As DataRow
            dgvList.Rows.Clear()

            For Each row In retrieveTable.Rows
                dgvList.Rows.Add(row("Id"), row("Item"), row("Price"))
            Next
            retrieveTable = Nothing
        Catch ex As Exception
            MessageBox.Show("Proses baca data gagal." & vbCrLf & ex.Message, "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmAdminUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadDataFromDB()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub btnOrder_Click(sender As Object, e As EventArgs)
        CustomerOrder.Show()
    End Sub

    Private Sub dgvList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim strBenda As String = dgvList.Item(0, e.RowIndex).Value.ToString()
        Dim Result As New ArrayList
        Dim retrieveRow As New VBMysql
        Dim strSql As String = "SELECT * FROM product WHERE Id = '" + strBenda + "'"
        Try
            Result = retrieveRow.Retrieve_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Proses baca data gagal." & vbCrLf & ex.Message, "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For Each row As Dictionary(Of String, Object) In Result
            With CustomerOrder
                .txtItems.Text = row("Item").ToString()
                .txtPrice.Text = row("Price").ToString()
            End With
        Next
        Me.Hide()
        CustomerOrder.Show()
    End Sub
End Class