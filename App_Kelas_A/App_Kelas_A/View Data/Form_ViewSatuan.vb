Public Class Form_ViewSatuan

    Private Sub DataGridViewSatuan_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridViewSatuan.MouseClick
        Form_input_barang.txtIDsatuan.Text = DataGridViewSatuan.Item(0, DataGridViewSatuan.CurrentRow.Index).Value
        Me.Close()
    End Sub

    Sub RefreshDataSatuan()
        db.tampilTabel1(DataGridViewSatuan, "select * from tbl_satuan")
        With DataGridViewSatuan
            .Columns(0).Width = 150
            .Columns(1).Width = 300
            .Columns(2).Width = 300
        End With
    End Sub
    Private Sub Form_ViewSatuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshDataSatuan()
    End Sub

End Class