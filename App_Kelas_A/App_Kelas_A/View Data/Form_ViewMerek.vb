Public Class Form_ViewMerek

    Private Sub DataGridViewMerek_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridViewMerek.MouseClick
        Form_input_barang.txtIDmerek.Text = DataGridViewMerek.Item(0, DataGridViewMerek.CurrentRow.Index).Value
        Me.Close()
    End Sub

    Sub RefreshDataMerek()
        db.tampilTabel1(DataGridViewMerek, "select * from tbl_merek")
        With DataGridViewMerek
            .Columns(0).Width = 150
            .Columns(1).Width = 300
            .Columns(2).Width = 300
        End With
    End Sub

    Private Sub Form_ViewMerek_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RefreshDataMerek()

    End Sub
End Class