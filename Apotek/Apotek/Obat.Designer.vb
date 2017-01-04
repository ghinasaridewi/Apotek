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
        Dim ID_OBATLabel As System.Windows.Forms.Label
        Dim NAMA_OBATLabel As System.Windows.Forms.Label
        Dim PASIEN_ID_PASIENLabel As System.Windows.Forms.Label
        Dim PASIEN_RESEP_ID_RESEPLabel As System.Windows.Forms.Label
        Me.ApotekDataSet = New Apotek.apotekDataSet()
        Me.ObatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObatTableAdapter = New Apotek.apotekDataSetTableAdapters.obatTableAdapter()
        Me.TableAdapterManager = New Apotek.apotekDataSetTableAdapters.TableAdapterManager()
        Me.ObatDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ID_OBATTextBox = New System.Windows.Forms.TextBox()
        Me.NAMA_OBATTextBox = New System.Windows.Forms.TextBox()
        Me.PASIEN_ID_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.PASIEN_RESEP_ID_RESEPTextBox = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        ID_OBATLabel = New System.Windows.Forms.Label()
        NAMA_OBATLabel = New System.Windows.Forms.Label()
        PASIEN_ID_PASIENLabel = New System.Windows.Forms.Label()
        PASIEN_RESEP_ID_RESEPLabel = New System.Windows.Forms.Label()
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'NAMA_OBATLabel
        '
        NAMA_OBATLabel.AutoSize = True
        NAMA_OBATLabel.Location = New System.Drawing.Point(6, 51)
        NAMA_OBATLabel.Name = "NAMA_OBATLabel"
        NAMA_OBATLabel.Size = New System.Drawing.Size(73, 13)
        NAMA_OBATLabel.TabIndex = 2
        NAMA_OBATLabel.Text = "NAMA OBAT:"
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
        'PASIEN_RESEP_ID_RESEPLabel
        '
        PASIEN_RESEP_ID_RESEPLabel.AutoSize = True
        PASIEN_RESEP_ID_RESEPLabel.Location = New System.Drawing.Point(6, 103)
        PASIEN_RESEP_ID_RESEPLabel.Name = "PASIEN_RESEP_ID_RESEPLabel"
        PASIEN_RESEP_ID_RESEPLabel.Size = New System.Drawing.Size(141, 13)
        PASIEN_RESEP_ID_RESEPLabel.TabIndex = 6
        PASIEN_RESEP_ID_RESEPLabel.Text = "PASIEN RESEP ID RESEP:"
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
        'ObatDataGridView
        '
        Me.ObatDataGridView.AutoGenerateColumns = False
        Me.ObatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ObatDataGridView.DataSource = Me.ObatBindingSource
        Me.ObatDataGridView.Location = New System.Drawing.Point(341, 60)
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
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 277)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(85, 230)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 29)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Batal"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(142, 199)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Refresh"
        Me.Button6.UseVisualStyleBackColor = True
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(142, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 27)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 27)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
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
        'ID_OBATTextBox
        '
        Me.ID_OBATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "ID_OBAT", True))
        Me.ID_OBATTextBox.Location = New System.Drawing.Point(153, 22)
        Me.ID_OBATTextBox.Name = "ID_OBATTextBox"
        Me.ID_OBATTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_OBATTextBox.TabIndex = 1
        '
        'NAMA_OBATTextBox
        '
        Me.NAMA_OBATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "NAMA_OBAT", True))
        Me.NAMA_OBATTextBox.Location = New System.Drawing.Point(153, 48)
        Me.NAMA_OBATTextBox.Name = "NAMA_OBATTextBox"
        Me.NAMA_OBATTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAMA_OBATTextBox.TabIndex = 3
        '
        'PASIEN_ID_PASIENTextBox
        '
        Me.PASIEN_ID_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "PASIEN_ID_PASIEN", True))
        Me.PASIEN_ID_PASIENTextBox.Location = New System.Drawing.Point(153, 74)
        Me.PASIEN_ID_PASIENTextBox.Name = "PASIEN_ID_PASIENTextBox"
        Me.PASIEN_ID_PASIENTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PASIEN_ID_PASIENTextBox.TabIndex = 5
        '
        'PASIEN_RESEP_ID_RESEPTextBox
        '
        Me.PASIEN_RESEP_ID_RESEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "PASIEN_RESEP_ID_RESEP", True))
        Me.PASIEN_RESEP_ID_RESEPTextBox.Location = New System.Drawing.Point(153, 100)
        Me.PASIEN_RESEP_ID_RESEPTextBox.Name = "PASIEN_RESEP_ID_RESEPTextBox"
        Me.PASIEN_RESEP_ID_RESEPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PASIEN_RESEP_ID_RESEPTextBox.TabIndex = 7
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(649, 15)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 31)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Cari"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(341, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DATA OBAT"
        '
        'Obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 345)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ObatDataGridView)
        Me.Name = "Obat"
        Me.Text = "Obat"
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
