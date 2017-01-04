Public Class Obat

    Private Sub ObatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ObatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

    End Sub

    Private Sub Obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApotekDataSet.obat' table. You can move, or remove it, as needed.Me.ObatTableAdapter.Fill(Me.ApotekDataSet.obat)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ID_OBATTextBox.Enabled = False
        NAMA_OBATTextBox.Enabled = False
        PASIEN_ID_PASIENTextBox.Enabled = False
        PASIEN_RESEP_ID_RESEPTextBox.Enabled = False

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = False

        Me.ObatBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.ObatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

        MessageBox.Show("data telah disimpan")

        ID_OBATTextBox.Enabled = False
        NAMA_OBATTextBox.Enabled = False
        PASIEN_ID_PASIENTextBox.Enabled = False
        PASIEN_RESEP_ID_RESEPTextBox.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ID_OBATTextBox.Enabled = True
        NAMA_OBATTextBox.Enabled = True
        PASIEN_ID_PASIENTextBox.Enabled = True
        PASIEN_RESEP_ID_RESEPTextBox.Enabled = True

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("hapus data", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ObatBindingSource.RemoveCurrent()

            Me.Validate()
            Me.ObatBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ObatBindingSource.CancelEdit()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button6.Enabled = False
        Button7.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.ObatTableAdapter.Fill(Me.ApotekDataSet.obat)
    End Sub
End Class