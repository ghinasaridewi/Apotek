Public Class Obat

    Private Sub ObatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ObatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

    End Sub

    Private Sub Obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApotekDataSet.obat' table. You can move, or remove it, as needed.Me.ObatTableAdapter.Fill(Me.ApotekDataSet.obat)

    End Sub
End Class