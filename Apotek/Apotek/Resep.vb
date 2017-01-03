Public Class Resep

    Private Sub ResepBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResepBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ResepBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApotekDataSet)

    End Sub

    Private Sub Resep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApotekDataSet.resep' table. You can move, or remove it, as needed.
        Me.ResepTableAdapter.Fill(Me.ApotekDataSet.resep)

    End Sub
End Class