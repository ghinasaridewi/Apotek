Public Class Pasien
    Private Sub Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApotekDataSet.pasien' table. You can move, or remove it, as needed.
        Me.PasienTableAdapter.Fill(Me.ApotekDataSet.pasien)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahButton.Click
        ID_PASIENTextBox.Enabled = True
        NAMA_PASIENTextBox.Enabled = True
        TELP_PASIENTextBox.Enabled = True
        ALAMAT_PASIENTextBox.Enabled = True
        RESEP_ID_RESEPTextBox.Enabled = True

        TambahButton.Enabled = True
        HapusButton.Enabled = False
        EditButton.Enabled = False
        RefreshButton.Enabled = False
        BatalButton.Enabled = True
        SimpanButton.Enabled = True
        KeluarButton.Enabled = True

        PasienBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

        MessageBox.Show("DATA TELAH DISIMPAN")

        ID_PASIENTextBox.Enabled = False
        NAMA_PASIENTextBox.Enabled = False
        TELP_PASIENTextBox.Enabled = False
        ALAMAT_PASIENTextBox.Enabled = False
        RESEP_ID_RESEPTextBox.Enabled = False

        TambahButton.Enabled = True
        HapusButton.Enabled = True
        EditButton.Enabled = True
        SimpanButton.Enabled = False

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        NAMA_PASIENTextBox.Enabled = True
        TELP_PASIENTextBox.Enabled = True
        ALAMAT_PASIENTextBox.Enabled = True

        TambahButton.Enabled = False
        HapusButton.Enabled = False
        EditButton.Enabled = True
        RefreshButton.Enabled = False
        BatalButton.Enabled = True
        SimpanButton.Enabled = True
        KeluarButton.Enabled = True
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        If MessageBox.Show("HAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PasienBindingSource.RemoveCurrent()

            Me.Validate()
            Me.PasienBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

            MessageBox.Show("DATA TELAH TERHAPUS")
        End If
    End Sub

    Private Sub KeluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarButton.Click
        Me.Close()
    End Sub

    Private Sub BatalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalButton.Click
        TambahButton.Enabled = True
        HapusButton.Enabled = True
        EditButton.Enabled = True
        RefreshButton.Enabled = True
        SimpanButton.Enabled = False
        BatalButton.Enabled = False
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Me.PasienTableAdapter.Fill(Me.ApotekDataSet.pasien)
    End Sub
End Class