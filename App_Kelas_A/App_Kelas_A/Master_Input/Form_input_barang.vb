Public Class Form_input_barang
    Dim hargabeli1, hargabeli2, hargajual1, hargajual2, selisih1, selisih2 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fs.FormShow(False, Form_ViewJenis, Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fs.FormShow(False, Form_ViewSatuan, Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        fs.FormShow(False, Form_ViewMerek, Me)
    End Sub
    Private Sub Barcode_Otomatis()
        Dim tgl As String = Format(Now, "dMyy")
        Dim Jam As String = Format(Now, "hms")
        Dim ID As String = "" & tgl & Jam
        txtbarcode.Text = ID
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtbarcode.Text = "" Or txtnamabarang.Text = "" Or txthargabeli.Text = "" Or txthargajual.Text = "" Or txtStok.Text = "" Or txtIDjenis.Text = "" Or txtIDmerek.Text = "" Or txtIDsatuan.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            txtSelisih.Text = (txthargajual.Text - txthargabeli.Text)
            If kondisi = True Then

                Call db.manipulasi("insert ignore into tbl_barang values('" & txtbarcode.Text &
                                   "','" & txtnamabarang.Text & "','" & hargabeli2 &
                                   "','" & hargajual2 & "','" & selisih2 &
                                   "','" & txtStok.Text & "','" & txtIDjenis.Text &
                                   "','" & txtIDsatuan.Text & "','" & txtIDmerek.Text & "')", "Simpan")
                'txtSelisih.Visible = True
                'txtSelisih.Enabled = True
            Else
                Call db.manipulasi("update tbl_barang Set Nama_Barang = '" & txtnamabarang.Text &
                                   "',Harga_Beli ='" & hargabeli2 &
                                   "',Harga_Jual ='" & hargajual2 &
                                   "',Selisih_Harga ='" & selisih2 &
                                   "',Stok ='" & txtStok.Text &
                                   "',ID_Jenis ='" & txtIDjenis.Text &
                                   "',ID_Satuan ='" & txtIDsatuan.Text &
                                   "',ID_Merek ='" & txtIDmerek.Text &
                                   "' where Barcode ='" & txtbarcode.Text & "'", "Ubah")
            End If
            Call bersih()
            Call db.tampilTabel1(Form_Barang.DataGridView1, "select * from tbl_barang")
            Call Rapigrid(Form_Barang.DataGridView1, "tbl_barang")
            Call Barcode_Otomatis()
        End If
    End Sub

    Private Sub Form_input_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If kondisi = True Then
            Call Barcode_Otomatis()
        End If
    End Sub
    Private Sub txtbarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbarcode.KeyPress
        If e.KeyChar = Chr(13) Then 'chr(13) = tombol ENTER
            txtnamabarang.Focus()

        End If
    End Sub

    Private Sub txthargabeli_TextChanged(sender As Object, e As EventArgs) Handles txthargabeli.TextChanged
        Try
            hargabeli1 = CDbl(txthargabeli.Text)
            hargabeli2 = CDbl(txthargabeli.Text)
            '------------------------------------------'
            txthargabeli.Text = Format(Val(hargabeli1), "#,#")
            txthargabeli.SelectionStart = Len(txthargabeli.Text)
        Catch ex As Exception
        End Try
        
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim tanya
        tanya = MessageBox.Show("Yakin ingin menghapus data ?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Call db.manipulasi("delete from tbl_barang where Barcode= '" & txtbarcode.Text & "'", "Hapus")
            Call db.tampilTabel1(Form_Barang.DataGridView1, "select * from tbl_barang")
            MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Information")
            Call Barcode_Otomatis()
            Me.Close()
        End If
    End Sub
    
    Private Sub txthargajual_TextChanged(sender As Object, e As EventArgs) Handles txthargajual.TextChanged
        Try
            hargajual1 = CDbl(txthargajual.Text)
            hargajual2 = CDbl(txthargajual.Text)
            '------------------------------------------'
            txthargajual.Text = Format(Val(hargajual1), "#,#")
            txthargajual.SelectionStart = Len(txthargajual.Text)
            '------------------------------------------'
            selisih1 = CDbl(hargajual2) - CDbl(hargabeli2)
            selisih2 = CDbl(hargajual2) - CDbl(hargabeli2)
            txtSelisih.Text = selisih1
            
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtSelisih_TextChanged(sender As Object, e As EventArgs) Handles txtSelisih.TextChanged
        selisih1 = CDbl(txtSelisih.Text)
        selisih2 = CDbl(txtSelisih.Text)
        '------------------------------------------'
        txtSelisih.Text = Format(Val(selisih1), "#,#")
        txtSelisih.SelectionStart = Len(txtSelisih.Text)
    End Sub

    Private Sub bersih()
        txtbarcode.Clear()
        txtnamabarang.Clear()
        txthargabeli.Clear()
        txthargajual.Clear()
        txtSelisih.Clear()
        txtStok.Clear()
        txtIDjenis.Clear()
        txtIDmerek.Clear()
        txtIDsatuan.Clear()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

    End Sub

    Private Sub ToolStripSeparator2_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator2.Click

    End Sub

    Private Sub ToolStripSeparator1_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator1.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub txtnamabarang_TextChanged(sender As Object, e As EventArgs) Handles txtnamabarang.TextChanged

    End Sub

    Private Sub txtStok_TextChanged(sender As Object, e As EventArgs) Handles txtStok.TextChanged

    End Sub

    Private Sub txtIDjenis_TextChanged(sender As Object, e As EventArgs) Handles txtIDjenis.TextChanged

    End Sub

    Private Sub txtIDsatuan_TextChanged(sender As Object, e As EventArgs) Handles txtIDsatuan.TextChanged

    End Sub

    Private Sub txtIDmerek_TextChanged(sender As Object, e As EventArgs) Handles txtIDmerek.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class