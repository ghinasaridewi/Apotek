<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Obat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Obat))
        Dim ID_OBATLabel As System.Windows.Forms.Label
        Dim NAMA_OBATLabel As System.Windows.Forms.Label
        Dim PASIEN_ID_PASIENLabel As System.Windows.Forms.Label
        Dim PASIEN_RESEP_ID_RESEPLabel As System.Windows.Forms.Label
        Me.ApotekDataSet = New Apotek.apotekDataSet()
        Me.ObatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObatTableAdapter = New Apotek.apotekDataSetTableAdapters.obatTableAdapter()
        Me.TableAdapterManager = New Apotek.apotekDataSetTableAdapters.TableAdapterManager()
        Me.ObatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ObatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ObatDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ID_OBATTextBox = New System.Windows.Forms.TextBox()
        Me.NAMA_OBATTextBox = New System.Windows.Forms.TextBox()
        Me.PASIEN_ID_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.PASIEN_RESEP_ID_RESEPTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        ID_OBATLabel = New System.Windows.Forms.Label()
        NAMA_OBATLabel = New System.Windows.Forms.Label()
        PASIEN_ID_PASIENLabel = New System.Windows.Forms.Label()
        PASIEN_RESEP_ID_RESEPLabel = New System.Windows.Forms.Label()
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ObatBindingNavigator.SuspendLayout()
        CType(Me.ObatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApotekDataSet
        '
        Me.ApotekDataSet.DataSetName = "apotekDataSet"
        Me.ApotekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ObatBindingSource
        '
        Me.ObatBindingSource.DataMember = "obat"
        Me.ObatBindingSource.DataSource = Me.ApotekDataSet
        '
        'ObatTableAdapter
        '
        Me.ObatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.obatTableAdapter = Me.ObatTableAdapter
        Me.TableAdapterManager.pasienTableAdapter = Nothing
        Me.TableAdapterManager.resepTableAdapter = Nothing
        Me.TableAdapterManager.transaksiTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Apotek.apotekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ObatBindingNavigator
        '
        Me.ObatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ObatBindingNavigator.BindingSource = Me.ObatBindingSource
        Me.ObatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ObatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ObatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ObatBindingNavigatorSaveItem})
        Me.ObatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ObatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ObatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ObatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ObatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ObatBindingNavigator.Name = "ObatBindingNavigator"
        Me.ObatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ObatBindingNavigator.Size = New System.Drawing.Size(799, 25)
        Me.ObatBindingNavigator.TabIndex = 0
        Me.ObatBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ObatBindingNavigatorSaveItem
        '
        Me.ObatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ObatBindingNavigatorSaveItem.Image = CType(resources.GetObject("ObatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ObatBindingNavigatorSaveItem.Name = "ObatBindingNavigatorSaveItem"
        Me.ObatBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ObatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ObatDataGridView
        '
        Me.ObatDataGridView.AutoGenerateColumns = False
        Me.ObatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ObatDataGridView.DataSource = Me.ObatBindingSource
        Me.ObatDataGridView.Location = New System.Drawing.Point(341, 28)
        Me.ObatDataGridView.Name = "ObatDataGridView"
        Me.ObatDataGridView.Size = New System.Drawing.Size(443, 220)
        Me.ObatDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_OBAT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_OBAT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAMA_OBAT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAMA_OBAT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PASIEN_ID_PASIEN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PASIEN_ID_PASIEN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PASIEN_RESEP_ID_RESEP"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PASIEN_RESEP_ID_RESEP"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(ID_OBATLabel)
        Me.GroupBox1.Controls.Add(Me.ID_OBATTextBox)
        Me.GroupBox1.Controls.Add(NAMA_OBATLabel)
        Me.GroupBox1.Controls.Add(Me.NAMA_OBATTextBox)
        Me.GroupBox1.Controls.Add(PASIEN_ID_PASIENLabel)
        Me.GroupBox1.Controls.Add(Me.PASIEN_ID_PASIENTextBox)
        Me.GroupBox1.Controls.Add(PASIEN_RESEP_ID_RESEPLabel)
        Me.GroupBox1.Controls.Add(Me.PASIEN_RESEP_ID_RESEPTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 277)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Obat"
        '
        'ID_OBATLabel
        '
        ID_OBATLabel.AutoSize = True
        ID_OBATLabel.Location = New System.Drawing.Point(6, 25)
        ID_OBATLabel.Name = "ID_OBATLabel"
        ID_OBATLabel.Size = New System.Drawing.Size(53, 13)
        ID_OBATLabel.TabIndex = 0
        ID_OBATLabel.Text = "ID OBAT:"
        '
        'ID_OBATTextBox
        '
        Me.ID_OBATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "ID_OBAT", True))
        Me.ID_OBATTextBox.Location = New System.Drawing.Point(153, 22)
        Me.ID_OBATTextBox.Name = "ID_OBATTextBox"
        Me.ID_OBATTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_OBATTextBox.TabIndex = 1
        '
        'NAMA_OBATLabel
        '
        NAMA_OBATLabel.AutoSize = True
        NAMA_OBATLabel.Location = New System.Drawing.Point(6, 51)
        NAMA_OBATLabel.Name = "NAMA_OBATLabel"
        NAMA_OBATLabel.Size = New System.Drawing.Size(73, 13)
        NAMA_OBATLabel.TabIndex = 2
        NAMA_OBATLabel.Text = "NAMA OBAT:"
        '
        'NAMA_OBATTextBox
        '
        Me.NAMA_OBATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "NAMA_OBAT", True))
        Me.NAMA_OBATTextBox.Location = New System.Drawing.Point(153, 48)
        Me.NAMA_OBATTextBox.Name = "NAMA_OBATTextBox"
        Me.NAMA_OBATTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAMA_OBATTextBox.TabIndex = 3
        '
        'PASIEN_ID_PASIENLabel
        '
        PASIEN_ID_PASIENLabel.AutoSize = True
        PASIEN_ID_PASIENLabel.Location = New System.Drawing.Point(6, 77)
        PASIEN_ID_PASIENLabel.Name = "PASIEN_ID_PASIENLabel"
        PASIEN_ID_PASIENLabel.Size = New System.Drawing.Size(105, 13)
        PASIEN_ID_PASIENLabel.TabIndex = 4
        PASIEN_ID_PASIENLabel.Text = "PASIEN ID PASIEN:"
        '
        'PASIEN_ID_PASIENTextBox
        '
        Me.PASIEN_ID_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "PASIEN_ID_PASIEN", True))
        Me.PASIEN_ID_PASIENTextBox.Location = New System.Drawing.Point(153, 74)
        Me.PASIEN_ID_PASIENTextBox.Name = "PASIEN_ID_PASIENTextBox"
        Me.PASIEN_ID_PASIENTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PASIEN_ID_PASIENTextBox.TabIndex = 5
        '
        'PASIEN_RESEP_ID_RESEPLabel
        '
        PASIEN_RESEP_ID_RESEPLabel.AutoSize = True
        PASIEN_RESEP_ID_RESEPLabel.Location = New System.Drawing.Point(6, 103)
        PASIEN_RESEP_ID_RESEPLabel.Name = "PASIEN_RESEP_ID_RESEPLabel"
        PASIEN_RESEP_ID_RESEPLabel.Size = New System.Drawing.Size(141, 13)
        PASIEN_RESEP_ID_RESEPLabel.TabIndex = 6
        PASIEN_RESEP_ID_RESEPLabel.Text = "PASIEN RESEP ID RESEP:"
        '
        'PASIEN_RESEP_ID_RESEPTextBox
        '
        Me.PASIEN_RESEP_ID_RESEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "PASIEN_RESEP_ID_RESEP", True))
        Me.PASIEN_RESEP_ID_RESEPTextBox.Location = New System.Drawing.Point(153, 100)
        Me.PASIEN_RESEP_ID_RESEPTextBox.Name = "PASIEN_RESEP_ID_RESEPTextBox"
        Me.PASIEN_RESEP_ID_RESEPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PASIEN_RESEP_ID_RESEPTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 27)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(25, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 27)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(142, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 27)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(25, 197)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 27)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 345)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ObatDataGridView)
        Me.Controls.Add(Me.ObatBindingNavigator)
        Me.Name = "Obat"
        Me.Text = "Obat"
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ObatBindingNavigator.ResumeLayout(False)
        Me.ObatBindingNavigator.PerformLayout()
        CType(Me.ObatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApotekDataSet As Apotek.apotekDataSet
    Friend WithEvents ObatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObatTableAdapter As Apotek.apotekDataSetTableAdapters.obatTableAdapter
    Friend WithEvents TableAdapterManager As Apotek.apotekDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ObatBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ObatBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ObatDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ID_OBATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMA_OBATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PASIEN_ID_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PASIEN_RESEP_ID_RESEPTextBox As System.Windows.Forms.TextBox
End Class
