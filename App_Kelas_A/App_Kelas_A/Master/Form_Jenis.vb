Public Class Form_Jenis

    Private Sub Form_Jenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call db.tampilTabel1(DataGridView1, "select * from tbl_jenis")
        Call Rapigrid(DataGridView1, "tbl_jenis")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        kondisi = True
        fs.FormShow(False, Form_input_jenis, Me)
    End Sub

    Private Sub EditDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDataToolStripMenuItem.Click
        With DataGridView1
            Form_input_jenis.txtIDJenis.Text = .Item(0, .CurrentRow.Index).Value
            Form_input_jenis.txtJenis.Text = .Item(1, .CurrentRow.Index).Value
            Form_input_jenis.txtKeterangan.Text = .Item(2, .CurrentRow.Index).Value
            kondisi = False
            Form_input_jenis.ShowDialog()

        End With
    End Sub
End Class