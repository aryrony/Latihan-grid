Public Class Form_input_satuan
    Private Sub ID_Otomatis()
        Dim tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hms")
        Dim ID As String = "IDS-" & tgl & Jam
        txtIDsatuan.Text = ID
    End Sub
    Private Sub Form_input_satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If kondisi = True Then
            Call ID_Otomatis()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIDsatuan.Text = "" Or txtKeterangan.Text = "" Or txtSatuan.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            If kondisi = True Then
                Call db.manipulasi("insert ignore into tbl_satuan values('" & txtIDsatuan.Text & "','" & txtSatuan.Text & "','" & txtKeterangan.Text & "')", "Simpan")
            Else
                Call db.manipulasi("update tbl_satuan Set satuan  = '" & txtSatuan.Text &
                                   "',Keterangan ='" & txtKeterangan.Text &
                                   "' where ID_satuan ='" & txtIDsatuan.Text & "')", "Ubah")
            End If
            Call db.tampilTabel1(Form_Satuan.DataGridView1, "select * from tbl_satuan")
            Call ID_Otomatis()
        End If
    End Sub
End Class