Public Class Transaksi

    Private Sub TransaksiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransaksiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

    End Sub

    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApotekDataSet.transaksi' table. You can move, or remove it, as needed.Me.TransaksiTableAdapter.Fill(Me.ApotekDataSet.transaksi)
        Me.TransaksiTableAdapter.Fill(Me.ApotekDataSet.transaksi)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahButton.Click
        ID_TRANSAKSITextBox.Enabled = True
        BIAYA_TRANSAKSITextBox.Enabled = True
        OBAT_ID_OBATTextBox.Enabled = True

        tambahButton.Enabled = False
        editButton.Enabled = False
        hapusButton.Enabled = False
        refreshButton.Enabled = False
        batalButton.Enabled = True
        simpanButton.Enabled = True

        TransaksiBindingSource.AddNew()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Me.Validate()
        Me.TransaksiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

        MessageBox.Show("Data Telah Tersimpan")

        ID_TRANSAKSITextBox.Enabled = False
        BIAYA_TRANSAKSITextBox.Enabled = False
        OBAT_ID_OBATTextBox.Enabled = False


        tambahButton.Enabled = True
        editButton.Enabled = True
        hapusButton.Enabled = True
        simpanButton.Enabled = False
    End Sub

    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        ID_TRANSAKSITextBox.Enabled = True
        BIAYA_TRANSAKSITextBox.Enabled = True
        OBAT_ID_OBATTextBox.Enabled = True

        tambahButton.Enabled = False
        editButton.Enabled = False
        hapusButton.Enabled = False
        refreshButton.Enabled = False
        batalButton.Enabled = True
        simpanButton.Enabled = True
    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        If MessageBox.Show("Hapus Data ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            TransaksiBindingSource.RemoveCurrent()

            Me.Validate()
            Me.TransaksiBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

            MessageBox.Show("Data Telah Terhapus")
        End If

    End Sub

    Private Sub keluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarButton.Click
        Me.Close()

    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalButton.Click
        TransaksiBindingSource.CancelEdit()

        tambahButton.Enabled = True
        editButton.Enabled = True
        hapusButton.Enabled = True
        refreshButton.Enabled = True
        simpanButton.Enabled = False
        batalButton.Enabled = False
    End Sub

    Private Sub refreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Me.TransaksiTableAdapter.Fill(Me.ApotekDataSet.transaksi)
    End Sub
End Class