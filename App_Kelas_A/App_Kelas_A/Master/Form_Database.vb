Public Class Form_Database

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If txtIP.Text = "" Or txtUser.Text = "" Or txtDB.Text = "" Or CbPort.Text = "" Then
            MsgBox("Lengkapi Settingan Database", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Call KoneksiDatabase()
        End If
    End Sub
End Class