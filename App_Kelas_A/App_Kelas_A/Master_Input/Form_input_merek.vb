Public Class Form_input_merek
    Private Sub ID_Otomatis()
        Dim tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hms")
        Dim ID As String = "IDM-" & tgl & Jam
        txtIDmerek.Text = ID
    End Sub

    Private Sub Form_input_merek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If kondisi = True Then
            Call ID_Otomatis()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIDmerek.Text = "" Or txtKeterangan.Text = "" Or txtmerek.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            If kondisi = True Then
                Call db.manipulasi("insert ignore into tbl_merek values('" & txtIDmerek.Text & "','" & txtmerek.Text & "','" & txtKeterangan.Text & "')", "Simpan")
            Else
                Call db.manipulasi("update tbl_merek Set Merek  = '" & txtmerek.Text &
                                   "',Keterangan ='" & txtKeterangan.Text &
                                   "' where ID_merek ='" & txtIDmerek.Text & "')", "Ubah")
            End If
        Call db.tampilTabel1(Form_Merek.DataGridView1, "select * from tbl_merek")
        Call ID_Otomatis()
        End If
    End Sub
End Class