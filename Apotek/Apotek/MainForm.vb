Public Class MainForm

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        Pasien.ShowDialog()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatToolStripMenuItem.Click
        Resep.ShowDialog()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        Transaksi.ShowDialog()
    End Sub
End Class
