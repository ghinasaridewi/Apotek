Public Class Resep

    Private Sub ResepBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ResepBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

    End Sub

    Private Sub Resep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApotekDataSet.resep' table. You can move, or remove it, as needed.Me.ResepTableAdapter.Fill(Me.ApotekDataSet.resep)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ID_RESEPTextBox.Enabled = True
        TRANSAKSI_ID_TRANSAKSITextBox.Enabled = True

        Button1.Enabled = True
        Button3.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = False
        Me.ResepBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TRANSAKSI_ID_TRANSAKSITextBox.Enabled = True


        Button1.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("hapus data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ResepBindingSource.RemoveCurrent()

            Me.Validate()
            Me.ResepBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.ResepBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

        MessageBox.Show("data telah disimpan")

        ID_RESEPTextBox.Enabled = False
        TRANSAKSI_ID_TRANSAKSITextBox.Enabled = False

        Button1.Enabled = True
        Button3.Enabled = True
        Button2.Enabled = True
        Button4.Enabled = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button1.Enabled = True
        Button3.Enabled = True
        Button2.Enabled = True
        Button7.Enabled = True
        Button4.Enabled = False
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.ResepTableAdapter.Fill(Me.ApotekDataSet.resep)
    End Sub
End Class