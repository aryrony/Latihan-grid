Public Class Form_Merek

    Private Sub Form_Merek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call db.tampilTabel1(DataGridView1, "select * from tbl_merek")
        Call Rapigrid(DataGridView1, "tbl_merek")
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        kondisi = True
        fs.FormShow(False, Form_input_merek, Me)
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PilihDataToolStripMenuItem.Click
        With DataGridView1
            Form_input_merek.txtIDmerek.Text = .Item(0, .CurrentRow.Index).Value
            Form_input_merek.txtmerek.Text = .Item(1, .CurrentRow.Index).Value
            Form_input_merek.txtKeterangan.Text = .Item(2, .CurrentRow.Index).Value
            kondisi = False
            Form_input_merek.ShowDialog()

        End With
    End Sub
End Class