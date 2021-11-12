Imports alfathNET
Imports MySql.Data.MySqlClient
Module Module_Diver
    Public db As New Database
    Public fs As New Fungsi
    Public Lap As New Laporan
    Public kondisi As Boolean

    Sub KoneksiDatabase()
        Try
            Dim ip, user, pwd, dbase, port As String
            With Form_Database
                ip = .txtIP.Text
                user = .txtUser.Text
                pwd = .txtPwd.Text
                dbase = .txtDB.Text
                port = .CbPort.Text

                db.Koneksi(ip, user, pwd, dbase, port, Master.StatusDB)
            End With
        Catch ex As Exception
        End Try

    End Sub

    Sub Rapigrid(ByVal Grid As DataGridView, ByVal tabel As String)
        Select Case tabel
            Case "tbl_jenis"
                With Grid
                    .Columns(0).Width = 120
                    .Columns(1).Width = 200
                    .Columns(2).Width = 971
                End With
            Case "tbl_merek"
                With Grid
                    .Columns(0).Width = 120
                    .Columns(1).Width = 200
                    .Columns(2).Width = 971
                End With
            Case "tbl_satuan"
                With Grid
                    .Columns(0).Width = 120
                    .Columns(1).Width = 200
                    .Columns(2).Width = 971
                End With
            Case "tbl_barang"
                With Grid
                    .Columns(0).Width = 167 'barcode

                    .Columns(1).Width = 200 ' nama barang
                    .Columns(1).HeaderText = "Nama Barang"

                    .Columns(2).Width = 150 'harga beli | rata kanan
                    .Columns(2).HeaderText = "Harga Beli"
                    .Columns(2).DefaultCellStyle.Format = "N0"
                    .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(2).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                    .Columns(3).Width = 150 ' harga jual | rata kanan
                    .Columns(3).HeaderText = "Harga Jual"
                    .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(3).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(3).DefaultCellStyle.Format = "N0"

                    .Columns(4).Width = 150 'selilih | rata kanan
                    .Columns(4).HeaderText = "Selisih"
                    .Columns(4).DefaultCellStyle.Format = "N0"
                    .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(4).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                    .Columns(5).Width = 100 'stok |rata tengah 
                    .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(5).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                    .Columns(6).Width = 125 'id jenis
                    .Columns(6).HeaderText = "ID Jenis"

                    .Columns(7).Width = 125 'id merek
                    .Columns(7).HeaderText = "ID Merek"

                    .Columns(8).Width = 125 'id satuan
                    .Columns(8).HeaderText = "ID Satuan"
                End With
        End Select
    End Sub


End Module
