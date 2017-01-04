<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resep
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resep))
        Dim ID_RESEPLabel As System.Windows.Forms.Label
        Dim TRANSAKSI_ID_TRANSAKSILabel As System.Windows.Forms.Label
        Me.ApotekDataSet = New Apotek.apotekDataSet()
        Me.ResepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResepTableAdapter = New Apotek.apotekDataSetTableAdapters.resepTableAdapter()
        Me.TableAdapterManager = New Apotek.apotekDataSetTableAdapters.TableAdapterManager()
        Me.ResepBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ResepBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ResepDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ID_RESEPTextBox = New System.Windows.Forms.TextBox()
        Me.TRANSAKSI_ID_TRANSAKSITextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        ID_RESEPLabel = New System.Windows.Forms.Label()
        TRANSAKSI_ID_TRANSAKSILabel = New System.Windows.Forms.Label()
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResepBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResepBindingNavigator.SuspendLayout()
        CType(Me.ResepDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApotekDataSet
        '
        Me.ApotekDataSet.DataSetName = "apotekDataSet"
        Me.ApotekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResepBindingSource
        '
        Me.ResepBindingSource.DataMember = "resep"
        Me.ResepBindingSource.DataSource = Me.ApotekDataSet
        '
        'ResepTableAdapter
        '
        Me.ResepTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.obatTableAdapter = Nothing
        Me.TableAdapterManager.pasienTableAdapter = Nothing
        Me.TableAdapterManager.resepTableAdapter = Me.ResepTableAdapter
        Me.TableAdapterManager.transaksiTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Apotek.apotekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ResepBindingNavigator
        '
        Me.ResepBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ResepBindingNavigator.BindingSource = Me.ResepBindingSource
        Me.ResepBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ResepBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ResepBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ResepBindingNavigatorSaveItem})
        Me.ResepBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ResepBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ResepBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ResepBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ResepBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ResepBindingNavigator.Name = "ResepBindingNavigator"
        Me.ResepBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ResepBindingNavigator.Size = New System.Drawing.Size(729, 25)
        Me.ResepBindingNavigator.TabIndex = 0
        Me.ResepBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ResepBindingNavigatorSaveItem
        '
        Me.ResepBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ResepBindingNavigatorSaveItem.Image = CType(resources.GetObject("ResepBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ResepBindingNavigatorSaveItem.Name = "ResepBindingNavigatorSaveItem"
        Me.ResepBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ResepBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ResepDataGridView
        '
        Me.ResepDataGridView.AutoGenerateColumns = False
        Me.ResepDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResepDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ResepDataGridView.DataSource = Me.ResepBindingSource
        Me.ResepDataGridView.Location = New System.Drawing.Point(290, 38)
        Me.ResepDataGridView.Name = "ResepDataGridView"
        Me.ResepDataGridView.Size = New System.Drawing.Size(427, 220)
        Me.ResepDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_RESEP"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_RESEP"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TRANSAKSI_ID_TRANSAKSI"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TRANSAKSI_ID_TRANSAKSI"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(ID_RESEPLabel)
        Me.GroupBox1.Controls.Add(Me.ID_RESEPTextBox)
        Me.GroupBox1.Controls.Add(TRANSAKSI_ID_TRANSAKSILabel)
        Me.GroupBox1.Controls.Add(Me.TRANSAKSI_ID_TRANSAKSITextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 220)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Resep"
        '
        'ID_RESEPLabel
        '
        ID_RESEPLabel.AutoSize = True
        ID_RESEPLabel.Location = New System.Drawing.Point(6, 26)
        ID_RESEPLabel.Name = "ID_RESEPLabel"
        ID_RESEPLabel.Size = New System.Drawing.Size(60, 13)
        ID_RESEPLabel.TabIndex = 0
        ID_RESEPLabel.Text = "ID RESEP:"
        '
        'ID_RESEPTextBox
        '
        Me.ID_RESEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResepBindingSource, "ID_RESEP", True))
        Me.ID_RESEPTextBox.Location = New System.Drawing.Point(161, 23)
        Me.ID_RESEPTextBox.Name = "ID_RESEPTextBox"
        Me.ID_RESEPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_RESEPTextBox.TabIndex = 1
        '
        'TRANSAKSI_ID_TRANSAKSILabel
        '
        TRANSAKSI_ID_TRANSAKSILabel.AutoSize = True
        TRANSAKSI_ID_TRANSAKSILabel.Location = New System.Drawing.Point(6, 52)
        TRANSAKSI_ID_TRANSAKSILabel.Name = "TRANSAKSI_ID_TRANSAKSILabel"
        TRANSAKSI_ID_TRANSAKSILabel.Size = New System.Drawing.Size(149, 13)
        TRANSAKSI_ID_TRANSAKSILabel.TabIndex = 2
        TRANSAKSI_ID_TRANSAKSILabel.Text = "TRANSAKSI ID TRANSAKSI:"
        '
        'TRANSAKSI_ID_TRANSAKSITextBox
        '
        Me.TRANSAKSI_ID_TRANSAKSITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResepBindingSource, "TRANSAKSI_ID_TRANSAKSI", True))
        Me.TRANSAKSI_ID_TRANSAKSITextBox.Location = New System.Drawing.Point(161, 49)
        Me.TRANSAKSI_ID_TRANSAKSITextBox.Name = "TRANSAKSI_ID_TRANSAKSITextBox"
        Me.TRANSAKSI_ID_TRANSAKSITextBox.Size = New System.Drawing.Size(100, 20)
        Me.TRANSAKSI_ID_TRANSAKSITextBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 21)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 21)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 21)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(124, 110)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 21)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(9, 137)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 21)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Resep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 302)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ResepDataGridView)
        Me.Controls.Add(Me.ResepBindingNavigator)
        Me.Name = "Resep"
        Me.Text = "Resep"
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResepBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResepBindingNavigator.ResumeLayout(False)
        Me.ResepBindingNavigator.PerformLayout()
        CType(Me.ResepDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApotekDataSet As Apotek.apotekDataSet
    Friend WithEvents ResepBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResepTableAdapter As Apotek.apotekDataSetTableAdapters.resepTableAdapter
    Friend WithEvents TableAdapterManager As Apotek.apotekDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ResepBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResepBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ResepDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ID_RESEPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRANSAKSI_ID_TRANSAKSITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
