Public Class Master

    Private Sub DatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click
        fs.FormShow(False, Form_Database, Me)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        fs.formChildClose(Me, "APP KASIR")
        fs.FormShow(True, Form_Jenis, Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        fs.formChildClose(Me, "APP KASIR")
        fs.FormShow(True, Form_Satuan, Me)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        fs.formChildClose(Me, "APP KASIR")
        fs.FormShow(True, Form_Merek, Me)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        fs.formChildClose(Me, "APP KASIR")
        fs.FormShow(True, Form_Barang, Me)
    End Sub
End Class
