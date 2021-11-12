Public Class Form_Satuan
    Private Sub Form_Satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call db.tampilTabel1(DataGridView1, "select * from tbl_satuan")
        Call Rapigrid(DataGridView1, "tbl_satuan")
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        kondisi = True
        fs.FormShow(False, Form_input_satuan, Me)
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PilihDataToolStripMenuItem.Click
        With DataGridView1
            Form_input_satuan.txtIDsatuan.Text = .Item(0, .CurrentRow.Index).Value
            Form_input_satuan.txtSatuan.Text = .Item(1, .CurrentRow.Index).Value
            Form_input_satuan.txtKeterangan.Text = .Item(2, .CurrentRow.Index).Value
            kondisi = False
            Form_input_satuan.ShowDialog()

        End With
    End Sub
End Class