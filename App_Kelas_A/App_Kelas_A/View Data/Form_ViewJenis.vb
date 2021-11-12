Public Class Form_ViewJenis

    Sub RefreshDataJenis()
        db.tampilTabel1(DataGridViewJenis, "select * from tbl_jenis")
        With DataGridViewJenis
            .Columns(0).Width = 150
            .Columns(1).Width = 300
            .Columns(2).Width = 300
        End With
    End Sub

    Private Sub Form_ViewJenis_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RefreshDataJenis()
    End Sub


    Private Sub DataGridViewJenis_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridViewJenis.MouseClick
        With DataGridViewJenis
            Form_input_barang.txtIDjenis.Text = DataGridViewJenis.Item(0, DataGridViewJenis.CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub

End Class