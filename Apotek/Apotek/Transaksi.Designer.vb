<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
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
        Dim ID_TRANSAKSILabel As System.Windows.Forms.Label
        Dim TGL_TRANSAKSILabel As System.Windows.Forms.Label
        Dim BIAYA_TRANSAKSILabel As System.Windows.Forms.Label
        Dim OBAT_ID_OBATLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.ApotekDataSet = New Apotek.apotekDataSet()
        Me.TransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransaksiTableAdapter = New Apotek.apotekDataSetTableAdapters.transaksiTableAdapter()
        Me.TableAdapterManager = New Apotek.apotekDataSetTableAdapters.TableAdapterManager()
        Me.TransaksiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TransaksiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TransaksiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ID_TRANSAKSITextBox = New System.Windows.Forms.TextBox()
        Me.TGL_TRANSAKSIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BIAYA_TRANSAKSITextBox = New System.Windows.Forms.TextBox()
        Me.OBAT_ID_OBATTextBox = New System.Windows.Forms.TextBox()
        ID_TRANSAKSILabel = New System.Windows.Forms.Label()
        TGL_TRANSAKSILabel = New System.Windows.Forms.Label()
        BIAYA_TRANSAKSILabel = New System.Windows.Forms.Label()
        OBAT_ID_OBATLabel = New System.Windows.Forms.Label()
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransaksiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransaksiBindingNavigator.SuspendLayout()
        CType(Me.TransaksiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_TRANSAKSILabel
        '
        ID_TRANSAKSILabel.AutoSize = True
        ID_TRANSAKSILabel.Location = New System.Drawing.Point(14, 31)
        ID_TRANSAKSILabel.Name = "ID_TRANSAKSILabel"
        ID_TRANSAKSILabel.Size = New System.Drawing.Size(85, 13)
        ID_TRANSAKSILabel.TabIndex = 0
        ID_TRANSAKSILabel.Text = "ID TRANSAKSI:"
        '
        'TGL_TRANSAKSILabel
        '
        TGL_TRANSAKSILabel.AutoSize = True
        TGL_TRANSAKSILabel.Location = New System.Drawing.Point(14, 58)
        TGL_TRANSAKSILabel.Name = "TGL_TRANSAKSILabel"
        TGL_TRANSAKSILabel.Size = New System.Drawing.Size(95, 13)
        TGL_TRANSAKSILabel.TabIndex = 2
        TGL_TRANSAKSILabel.Text = "TGL TRANSAKSI:"
        '
        'BIAYA_TRANSAKSILabel
        '
        BIAYA_TRANSAKSILabel.AutoSize = True
        BIAYA_TRANSAKSILabel.Location = New System.Drawing.Point(14, 83)
        BIAYA_TRANSAKSILabel.Name = "BIAYA_TRANSAKSILabel"
        BIAYA_TRANSAKSILabel.Size = New System.Drawing.Size(105, 13)
        BIAYA_TRANSAKSILabel.TabIndex = 4
        BIAYA_TRANSAKSILabel.Text = "BIAYA TRANSAKSI:"
        '
        'OBAT_ID_OBATLabel
        '
        OBAT_ID_OBATLabel.AutoSize = True
        OBAT_ID_OBATLabel.Location = New System.Drawing.Point(14, 109)
        OBAT_ID_OBATLabel.Name = "OBAT_ID_OBATLabel"
        OBAT_ID_OBATLabel.Size = New System.Drawing.Size(85, 13)
        OBAT_ID_OBATLabel.TabIndex = 6
        OBAT_ID_OBATLabel.Text = "OBAT ID OBAT:"
        '
        'ApotekDataSet
        '
        Me.ApotekDataSet.DataSetName = "apotekDataSet"
        Me.ApotekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransaksiBindingSource
        '
        Me.TransaksiBindingSource.DataMember = "transaksi"
        Me.TransaksiBindingSource.DataSource = Me.ApotekDataSet
        '
        'TransaksiTableAdapter
        '
        Me.TransaksiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.obatTableAdapter = Nothing
        Me.TableAdapterManager.pasienTableAdapter = Nothing
        Me.TableAdapterManager.resepTableAdapter = Nothing
        Me.TableAdapterManager.transaksiTableAdapter = Me.TransaksiTableAdapter
        Me.TableAdapterManager.UpdateOrder = Apotek.apotekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TransaksiBindingNavigator
        '
        Me.TransaksiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TransaksiBindingNavigator.BindingSource = Me.TransaksiBindingSource
        Me.TransaksiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TransaksiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TransaksiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TransaksiBindingNavigatorSaveItem})
        Me.TransaksiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TransaksiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TransaksiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TransaksiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TransaksiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TransaksiBindingNavigator.Name = "TransaksiBindingNavigator"
        Me.TransaksiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TransaksiBindingNavigator.Size = New System.Drawing.Size(834, 25)
        Me.TransaksiBindingNavigator.TabIndex = 0
        Me.TransaksiBindingNavigator.Text = "BindingNavigator1"
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
        'TransaksiBindingNavigatorSaveItem
        '
        Me.TransaksiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TransaksiBindingNavigatorSaveItem.Image = CType(resources.GetObject("TransaksiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TransaksiBindingNavigatorSaveItem.Name = "TransaksiBindingNavigatorSaveItem"
        Me.TransaksiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TransaksiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TransaksiDataGridView
        '
        Me.TransaksiDataGridView.AutoGenerateColumns = False
        Me.TransaksiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransaksiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TransaksiDataGridView.DataSource = Me.TransaksiBindingSource
        Me.TransaksiDataGridView.Location = New System.Drawing.Point(369, 28)
        Me.TransaksiDataGridView.Name = "TransaksiDataGridView"
        Me.TransaksiDataGridView.Size = New System.Drawing.Size(448, 220)
        Me.TransaksiDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_TRANSAKSI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_TRANSAKSI"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TGL_TRANSAKSI"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TGL_TRANSAKSI"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BIAYA_TRANSAKSI"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BIAYA_TRANSAKSI"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OBAT_ID_OBAT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OBAT_ID_OBAT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(ID_TRANSAKSILabel)
        Me.GroupBox1.Controls.Add(Me.ID_TRANSAKSITextBox)
        Me.GroupBox1.Controls.Add(TGL_TRANSAKSILabel)
        Me.GroupBox1.Controls.Add(Me.TGL_TRANSAKSIDateTimePicker)
        Me.GroupBox1.Controls.Add(BIAYA_TRANSAKSILabel)
        Me.GroupBox1.Controls.Add(Me.BIAYA_TRANSAKSITextBox)
        Me.GroupBox1.Controls.Add(OBAT_ID_OBATLabel)
        Me.GroupBox1.Controls.Add(Me.OBAT_ID_OBATTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 252)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Transaksi"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(26, 208)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 24)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(141, 177)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 24)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 24)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 24)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 24)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ID_TRANSAKSITextBox
        '
        Me.ID_TRANSAKSITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransaksiBindingSource, "ID_TRANSAKSI", True))
        Me.ID_TRANSAKSITextBox.Location = New System.Drawing.Point(125, 28)
        Me.ID_TRANSAKSITextBox.Name = "ID_TRANSAKSITextBox"
        Me.ID_TRANSAKSITextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_TRANSAKSITextBox.TabIndex = 1
        '
        'TGL_TRANSAKSIDateTimePicker
        '
        Me.TGL_TRANSAKSIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TransaksiBindingSource, "TGL_TRANSAKSI", True))
        Me.TGL_TRANSAKSIDateTimePicker.Location = New System.Drawing.Point(125, 54)
        Me.TGL_TRANSAKSIDateTimePicker.Name = "TGL_TRANSAKSIDateTimePicker"
        Me.TGL_TRANSAKSIDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TGL_TRANSAKSIDateTimePicker.TabIndex = 3
        '
        'BIAYA_TRANSAKSITextBox
        '
        Me.BIAYA_TRANSAKSITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransaksiBindingSource, "BIAYA_TRANSAKSI", True))
        Me.BIAYA_TRANSAKSITextBox.Location = New System.Drawing.Point(125, 80)
        Me.BIAYA_TRANSAKSITextBox.Name = "BIAYA_TRANSAKSITextBox"
        Me.BIAYA_TRANSAKSITextBox.Size = New System.Drawing.Size(200, 20)
        Me.BIAYA_TRANSAKSITextBox.TabIndex = 5
        '
        'OBAT_ID_OBATTextBox
        '
        Me.OBAT_ID_OBATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransaksiBindingSource, "OBAT_ID_OBAT", True))
        Me.OBAT_ID_OBATTextBox.Location = New System.Drawing.Point(125, 106)
        Me.OBAT_ID_OBATTextBox.Name = "OBAT_ID_OBATTextBox"
        Me.OBAT_ID_OBATTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OBAT_ID_OBATTextBox.TabIndex = 7
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 335)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TransaksiDataGridView)
        Me.Controls.Add(Me.TransaksiBindingNavigator)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransaksiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransaksiBindingNavigator.ResumeLayout(False)
        Me.TransaksiBindingNavigator.PerformLayout()
        CType(Me.TransaksiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApotekDataSet As Apotek.apotekDataSet
    Friend WithEvents TransaksiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransaksiTableAdapter As Apotek.apotekDataSetTableAdapters.transaksiTableAdapter
    Friend WithEvents TableAdapterManager As Apotek.apotekDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TransaksiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TransaksiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransaksiDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents ID_TRANSAKSITextBox As System.Windows.Forms.TextBox
    Friend WithEvents TGL_TRANSAKSIDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BIAYA_TRANSAKSITextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBAT_ID_OBATTextBox As System.Windows.Forms.TextBox
End Class
