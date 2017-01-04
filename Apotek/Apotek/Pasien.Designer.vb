<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pasien
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
        Dim ID_PASIENLabel As System.Windows.Forms.Label
        Dim NAMA_PASIENLabel As System.Windows.Forms.Label
        Dim TELP_PASIENLabel As System.Windows.Forms.Label
        Dim ALAMAT_PASIENLabel As System.Windows.Forms.Label
        Dim RESEP_ID_RESEPLabel As System.Windows.Forms.Label
        Me.ApotekDataSet = New Apotek.apotekDataSet()
        Me.PasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasienTableAdapter = New Apotek.apotekDataSetTableAdapters.pasienTableAdapter()
        Me.TableAdapterManager = New Apotek.apotekDataSetTableAdapters.TableAdapterManager()
        Me.PasienDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TambahButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.KeluarButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.BatalButton = New System.Windows.Forms.Button()
        Me.ID_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.NAMA_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.TELP_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.ALAMAT_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.RESEP_ID_RESEPTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CariText = New System.Windows.Forms.TextBox()
        Me.CariButton = New System.Windows.Forms.Button()
        ID_PASIENLabel = New System.Windows.Forms.Label()
        NAMA_PASIENLabel = New System.Windows.Forms.Label()
        TELP_PASIENLabel = New System.Windows.Forms.Label()
        ALAMAT_PASIENLabel = New System.Windows.Forms.Label()
        RESEP_ID_RESEPLabel = New System.Windows.Forms.Label()
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_PASIENLabel
        '
        ID_PASIENLabel.AutoSize = True
        ID_PASIENLabel.Location = New System.Drawing.Point(6, 27)
        ID_PASIENLabel.Name = "ID_PASIENLabel"
        ID_PASIENLabel.Size = New System.Drawing.Size(63, 13)
        ID_PASIENLabel.TabIndex = 0
        ID_PASIENLabel.Text = "ID PASIEN:"
        '
        'NAMA_PASIENLabel
        '
        NAMA_PASIENLabel.AutoSize = True
        NAMA_PASIENLabel.Location = New System.Drawing.Point(6, 53)
        NAMA_PASIENLabel.Name = "NAMA_PASIENLabel"
        NAMA_PASIENLabel.Size = New System.Drawing.Size(83, 13)
        NAMA_PASIENLabel.TabIndex = 2
        NAMA_PASIENLabel.Text = "NAMA PASIEN:"
        '
        'TELP_PASIENLabel
        '
        TELP_PASIENLabel.AutoSize = True
        TELP_PASIENLabel.Location = New System.Drawing.Point(6, 79)
        TELP_PASIENLabel.Name = "TELP_PASIENLabel"
        TELP_PASIENLabel.Size = New System.Drawing.Size(79, 13)
        TELP_PASIENLabel.TabIndex = 4
        TELP_PASIENLabel.Text = "TELP PASIEN:"
        '
        'ALAMAT_PASIENLabel
        '
        ALAMAT_PASIENLabel.AutoSize = True
        ALAMAT_PASIENLabel.Location = New System.Drawing.Point(6, 105)
        ALAMAT_PASIENLabel.Name = "ALAMAT_PASIENLabel"
        ALAMAT_PASIENLabel.Size = New System.Drawing.Size(95, 13)
        ALAMAT_PASIENLabel.TabIndex = 6
        ALAMAT_PASIENLabel.Text = "ALAMAT PASIEN:"
        '
        'RESEP_ID_RESEPLabel
        '
        RESEP_ID_RESEPLabel.AutoSize = True
        RESEP_ID_RESEPLabel.Location = New System.Drawing.Point(6, 131)
        RESEP_ID_RESEPLabel.Name = "RESEP_ID_RESEPLabel"
        RESEP_ID_RESEPLabel.Size = New System.Drawing.Size(99, 13)
        RESEP_ID_RESEPLabel.TabIndex = 8
        RESEP_ID_RESEPLabel.Text = "RESEP ID RESEP:"
        '
        'ApotekDataSet
        '
        Me.ApotekDataSet.DataSetName = "apotekDataSet"
        Me.ApotekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PasienBindingSource
        '
        Me.PasienBindingSource.DataMember = "pasien"
        Me.PasienBindingSource.DataSource = Me.ApotekDataSet
        '
        'PasienTableAdapter
        '
        Me.PasienTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.obatTableAdapter = Nothing
        Me.TableAdapterManager.pasienTableAdapter = Me.PasienTableAdapter
        Me.TableAdapterManager.resepTableAdapter = Nothing
        Me.TableAdapterManager.transaksiTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Apotek.apotekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PasienDataGridView
        '
        Me.PasienDataGridView.AutoGenerateColumns = False
        Me.PasienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PasienDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PasienDataGridView.DataSource = Me.PasienBindingSource
        Me.PasienDataGridView.Location = New System.Drawing.Point(294, 50)
        Me.PasienDataGridView.Name = "PasienDataGridView"
        Me.PasienDataGridView.Size = New System.Drawing.Size(540, 220)
        Me.PasienDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_PASIEN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_PASIEN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAMA_PASIEN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAMA_PASIEN"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TELP_PASIEN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TELP_PASIEN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ALAMAT_PASIEN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ALAMAT_PASIEN"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RESEP_ID_RESEP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "RESEP_ID_RESEP"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(13, 175)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(92, 24)
        Me.TambahButton.TabIndex = 12
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(123, 175)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(92, 24)
        Me.EditButton.TabIndex = 13
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'HapusButton
        '
        Me.HapusButton.Location = New System.Drawing.Point(13, 205)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(92, 24)
        Me.HapusButton.TabIndex = 14
        Me.HapusButton.Text = "Hapus"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Location = New System.Drawing.Point(123, 205)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(92, 24)
        Me.SimpanButton.TabIndex = 15
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'KeluarButton
        '
        Me.KeluarButton.Location = New System.Drawing.Point(13, 263)
        Me.KeluarButton.Name = "KeluarButton"
        Me.KeluarButton.Size = New System.Drawing.Size(92, 24)
        Me.KeluarButton.TabIndex = 16
        Me.KeluarButton.Text = "Keluar"
        Me.KeluarButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.BatalButton)
        Me.GroupBox1.Controls.Add(ID_PASIENLabel)
        Me.GroupBox1.Controls.Add(Me.KeluarButton)
        Me.GroupBox1.Controls.Add(Me.ID_PASIENTextBox)
        Me.GroupBox1.Controls.Add(Me.SimpanButton)
        Me.GroupBox1.Controls.Add(NAMA_PASIENLabel)
        Me.GroupBox1.Controls.Add(Me.HapusButton)
        Me.GroupBox1.Controls.Add(Me.EditButton)
        Me.GroupBox1.Controls.Add(Me.NAMA_PASIENTextBox)
        Me.GroupBox1.Controls.Add(Me.TambahButton)
        Me.GroupBox1.Controls.Add(TELP_PASIENLabel)
        Me.GroupBox1.Controls.Add(Me.TELP_PASIENTextBox)
        Me.GroupBox1.Controls.Add(ALAMAT_PASIENLabel)
        Me.GroupBox1.Controls.Add(Me.ALAMAT_PASIENTextBox)
        Me.GroupBox1.Controls.Add(RESEP_ID_RESEPLabel)
        Me.GroupBox1.Controls.Add(Me.RESEP_ID_RESEPTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 305)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(123, 234)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(92, 24)
        Me.RefreshButton.TabIndex = 18
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'BatalButton
        '
        Me.BatalButton.Enabled = False
        Me.BatalButton.Location = New System.Drawing.Point(13, 235)
        Me.BatalButton.Name = "BatalButton"
        Me.BatalButton.Size = New System.Drawing.Size(92, 24)
        Me.BatalButton.TabIndex = 17
        Me.BatalButton.Text = "Batal"
        Me.BatalButton.UseVisualStyleBackColor = True
        '
        'ID_PASIENTextBox
        '
        Me.ID_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "ID_PASIEN", True))
        Me.ID_PASIENTextBox.Enabled = False
        Me.ID_PASIENTextBox.Location = New System.Drawing.Point(111, 24)
        Me.ID_PASIENTextBox.Name = "ID_PASIENTextBox"
        Me.ID_PASIENTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_PASIENTextBox.TabIndex = 1
        '
        'NAMA_PASIENTextBox
        '
        Me.NAMA_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "NAMA_PASIEN", True))
        Me.NAMA_PASIENTextBox.Enabled = False
        Me.NAMA_PASIENTextBox.Location = New System.Drawing.Point(111, 50)
        Me.NAMA_PASIENTextBox.Name = "NAMA_PASIENTextBox"
        Me.NAMA_PASIENTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAMA_PASIENTextBox.TabIndex = 3
        '
        'TELP_PASIENTextBox
        '
        Me.TELP_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "TELP_PASIEN", True))
        Me.TELP_PASIENTextBox.Enabled = False
        Me.TELP_PASIENTextBox.Location = New System.Drawing.Point(111, 76)
        Me.TELP_PASIENTextBox.Name = "TELP_PASIENTextBox"
        Me.TELP_PASIENTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TELP_PASIENTextBox.TabIndex = 5
        '
        'ALAMAT_PASIENTextBox
        '
        Me.ALAMAT_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "ALAMAT_PASIEN", True))
        Me.ALAMAT_PASIENTextBox.Enabled = False
        Me.ALAMAT_PASIENTextBox.Location = New System.Drawing.Point(111, 102)
        Me.ALAMAT_PASIENTextBox.Name = "ALAMAT_PASIENTextBox"
        Me.ALAMAT_PASIENTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ALAMAT_PASIENTextBox.TabIndex = 7
        '
        'RESEP_ID_RESEPTextBox
        '
        Me.RESEP_ID_RESEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "RESEP_ID_RESEP", True))
        Me.RESEP_ID_RESEPTextBox.Enabled = False
        Me.RESEP_ID_RESEPTextBox.Location = New System.Drawing.Point(111, 128)
        Me.RESEP_ID_RESEPTextBox.Name = "RESEP_ID_RESEPTextBox"
        Me.RESEP_ID_RESEPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RESEP_ID_RESEPTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 33)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "DATA PASIEN"
        '
        'CariText
        '
        Me.CariText.Location = New System.Drawing.Point(310, 16)
        Me.CariText.Name = "CariText"
        Me.CariText.Size = New System.Drawing.Size(233, 20)
        Me.CariText.TabIndex = 19
        '
        'CariButton
        '
        Me.CariButton.Location = New System.Drawing.Point(549, 16)
        Me.CariButton.Name = "CariButton"
        Me.CariButton.Size = New System.Drawing.Size(102, 20)
        Me.CariButton.TabIndex = 20
        Me.CariButton.Text = "Cari"
        Me.CariButton.UseVisualStyleBackColor = True
        '
        'Pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 358)
        Me.Controls.Add(Me.CariButton)
        Me.Controls.Add(Me.CariText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PasienDataGridView)
        Me.Name = "Pasien"
        Me.Text = "Pasien"
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApotekDataSet As Apotek.apotekDataSet
    Friend WithEvents PasienBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PasienTableAdapter As Apotek.apotekDataSetTableAdapters.pasienTableAdapter
    Friend WithEvents TableAdapterManager As Apotek.apotekDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PasienDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TambahButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents KeluarButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ID_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMA_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TELP_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ALAMAT_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RESEP_ID_RESEPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents BatalButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CariText As System.Windows.Forms.TextBox
    Friend WithEvents CariButton As System.Windows.Forms.Button
End Class
