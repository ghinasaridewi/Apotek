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
        Dim ID_RESEPLabel As System.Windows.Forms.Label
        Dim TRANSAKSI_ID_TRANSAKSILabel As System.Windows.Forms.Label
        Me.ApotekDataSet = New Apotek.apotekDataSet()
        Me.ResepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResepTableAdapter = New Apotek.apotekDataSetTableAdapters.resepTableAdapter()
        Me.TableAdapterManager = New Apotek.apotekDataSetTableAdapters.TableAdapterManager()
        Me.ResepDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ID_RESEPTextBox = New System.Windows.Forms.TextBox()
        Me.TRANSAKSI_ID_TRANSAKSITextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        ID_RESEPLabel = New System.Windows.Forms.Label()
        TRANSAKSI_ID_TRANSAKSILabel = New System.Windows.Forms.Label()
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResepDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'TRANSAKSI_ID_TRANSAKSILabel
        '
        TRANSAKSI_ID_TRANSAKSILabel.AutoSize = True
        TRANSAKSI_ID_TRANSAKSILabel.Location = New System.Drawing.Point(6, 52)
        TRANSAKSI_ID_TRANSAKSILabel.Name = "TRANSAKSI_ID_TRANSAKSILabel"
        TRANSAKSI_ID_TRANSAKSILabel.Size = New System.Drawing.Size(149, 13)
        TRANSAKSI_ID_TRANSAKSILabel.TabIndex = 2
        TRANSAKSI_ID_TRANSAKSILabel.Text = "TRANSAKSI ID TRANSAKSI:"
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
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(124, 110)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 21)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 21)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
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
        'ID_RESEPTextBox
        '
        Me.ID_RESEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResepBindingSource, "ID_RESEP", True))
        Me.ID_RESEPTextBox.Location = New System.Drawing.Point(161, 23)
        Me.ID_RESEPTextBox.Name = "ID_RESEPTextBox"
        Me.ID_RESEPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_RESEPTextBox.TabIndex = 1
        '
        'TRANSAKSI_ID_TRANSAKSITextBox
        '
        Me.TRANSAKSI_ID_TRANSAKSITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResepBindingSource, "TRANSAKSI_ID_TRANSAKSI", True))
        Me.TRANSAKSI_ID_TRANSAKSITextBox.Location = New System.Drawing.Point(161, 49)
        Me.TRANSAKSI_ID_TRANSAKSITextBox.Name = "TRANSAKSI_ID_TRANSAKSITextBox"
        Me.TRANSAKSI_ID_TRANSAKSITextBox.Size = New System.Drawing.Size(100, 20)
        Me.TRANSAKSI_ID_TRANSAKSITextBox.TabIndex = 3
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(124, 137)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(89, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Batal"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(9, 164)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(89, 23)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Refresh"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DATA RESEP"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(596, 9)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(121, 23)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "Cari"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(290, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(289, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Resep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 302)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ResepDataGridView)
        Me.Name = "Resep"
        Me.Text = "Resep"
        CType(Me.ApotekDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
