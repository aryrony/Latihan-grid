Public Class Form_input_jenis
    Private Sub ID_Otomatis()
        Dim tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hms")
        Dim ID As String = "IDJ-" & tgl & Jam
        txtIDJenis.Text = ID
    End Sub
    Private Sub Form_input_jenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If kondisi = True Then
            Call ID_Otomatis()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIDJenis.Text = "" Or txtKeterangan.Text = "" Or txtJenis.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            If kondisi = True Then
                Call db.manipulasi("insert ignore into tbl_jenis values('" & txtIDJenis.Text & "','" & txtJenis.Text & "','" & txtKeterangan.Text & "')", "Simpan")
            Else
                Call db.manipulasi("update tbl_jenis Set Jenis = '" & txtJenis.Text &
                                   "',Keterangan ='" & txtKeterangan.Text &
                                   "' where ID_Jenis ='" & txtIDJenis.Text & "'", "Ubah")
            End If
            Call db.tampilTabel1(Form_Jenis.DataGridView1, "select * from tbl_jenis")
            Call ID_Otomatis()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim tanya
        tanya = MessageBox.Show("Yakin ingin menghapus data ?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Call db.manipulasi("delete from tbl_jenis where ID_Jenis= '" & txtIDJenis.Text & "'", "Hapus")
            Call db.tampilTabel1(Form_Jenis.DataGridView1, "select * from tbl_jenis")
            MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Information")
            Call ID_Otomatis()
            Me.Close()
        End If
    End Sub
End Class