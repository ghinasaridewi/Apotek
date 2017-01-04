Public Class Pasien

    Private Sub PasienBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

    End Sub

    Private Sub Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApotekDataSet.pasien' table. You can move, or remove it, as needed.Me.PasienTableAdapter.Fill(Me.ApotekDataSet.pasien)

    End Sub
End Class