Public Class Transaksi

    Private Sub TransaksiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransaksiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

    End Sub

    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApotekDataSet.transaksi' table. You can move, or remove it, as needed.Me.TransaksiTableAdapter.Fill(Me.ApotekDataSet.transaksi)

    End Sub
End Class