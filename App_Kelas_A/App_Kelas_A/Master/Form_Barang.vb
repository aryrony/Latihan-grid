Public Class Form_Barang
    'Sub RefreshDataBarang()
    '  Call db.tampilTabel1(DataGridView1, "select * from tbl_barang")
    ' Call Rapigrid(DataGridView1, "tbl_barang")
    'End Sub
    Private Sub Form_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call db.tampilTabel1(DataGridView1, "select * from tbl_barang")
        Call Rapigrid(DataGridView1, "tbl_barang")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        kondisi = True
        fs.FormShow(False, Form_input_barang, Me)
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PilihDataToolStripMenuItem.Click
        With DataGridView1
            Form_input_barang.txtbarcode.Text = .Item(0, .CurrentRow.Index).Value
            Form_input_barang.txtnamabarang.Text = .Item(1, .CurrentRow.Index).Value
            Form_input_barang.txthargabeli.Text = .Item(2, .CurrentRow.Index).Value
            Form_input_barang.txthargajual.Text = .Item(3, .CurrentRow.Index).Value
            Form_input_barang.txtSelisih.Text = .Item(4, .CurrentRow.Index).Value
            Form_input_barang.txtStok.Text = .Item(5, .CurrentRow.Index).Value
            Form_input_barang.txtIDjenis.Text = .Item(6, .CurrentRow.Index).Value
            Form_input_barang.txtIDsatuan.Text = .Item(7, .CurrentRow.Index).Value
            Form_input_barang.txtIDmerek.Text = .Item(8, .CurrentRow.Index).Value
            kondisi = False
            Form_input_barang.ShowDialog()
        End With
    End Sub
End Class