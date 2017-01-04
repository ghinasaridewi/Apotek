Public Class Pasien

    Private Sub PasienBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

    End Sub

    Private Sub Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApotekDataSet.pasien' table. You can move, or remove it, as needed.
        Me.PasienTableAdapter.Fill(Me.ApotekDataSet.pasien)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ID_PASIENTextBox.Enabled = True
        NAMA_PASIENTextBox.Enabled = True
        TELP_PASIENTextBox.Enabled = True
        ALAMAT_PASIENTextBox.Enabled = True
        RESEP_ID_RESEPTextBox.Enabled = True

        PasienBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

        MessageBox.Show("SUSKES TAMBAH DATA")

        ID_PASIENTextBox.Enabled = False
        NAMA_PASIENTextBox.Enabled = False
        TELP_PASIENTextBox.Enabled = False
        ALAMAT_PASIENTextBox.Enabled = False
        RESEP_ID_RESEPTextBox.Enabled = False

    End Sub
End Class