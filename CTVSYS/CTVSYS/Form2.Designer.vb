<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.CTVInfoDBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTVInfoDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New CTVSYS.DatabaseDataSet()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.CTVInfoDBTableAdapter = New CTVSYS.DatabaseDataSetTableAdapters.CTVInfoDBTableAdapter()
        Me.TableAdapterManager = New CTVSYS.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.CTVInfoDBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTVInfoDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CTVInfoDBDataGridView
        '
        Me.CTVInfoDBDataGridView.AllowUserToOrderColumns = True
        Me.CTVInfoDBDataGridView.AutoGenerateColumns = False
        Me.CTVInfoDBDataGridView.BackgroundColor = System.Drawing.Color.Teal
        Me.CTVInfoDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CTVInfoDBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4})
        Me.CTVInfoDBDataGridView.DataSource = Me.CTVInfoDBBindingSource
        Me.CTVInfoDBDataGridView.Location = New System.Drawing.Point(12, 57)
        Me.CTVInfoDBDataGridView.Name = "CTVInfoDBDataGridView"
        Me.CTVInfoDBDataGridView.Size = New System.Drawing.Size(945, 353)
        Me.CTVInfoDBDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Customer Ph"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Customer Ph"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Area"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Plan"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Plan"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Monthly Charge"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Monthly Charge"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Due"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Due"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Remark"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Remark"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Customer Status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Customer Status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Employee"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Employee"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'CTVInfoDBBindingSource
        '
        Me.CTVInfoDBBindingSource.DataMember = "CTVInfoDB"
        Me.CTVInfoDBBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(98, 12)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(377, 26)
        Me.txtsearch.TabIndex = 3
        '
        'CTVInfoDBTableAdapter
        '
        Me.CTVInfoDBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CTVInfoDBTableAdapter = Me.CTVInfoDBTableAdapter
        Me.TableAdapterManager.UpdateOrder = CTVSYS.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(872, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Pint"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 416)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.CTVInfoDBDataGridView)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.CTVInfoDBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTVInfoDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As CTVSYS.DatabaseDataSet
    Friend WithEvents CTVInfoDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTVInfoDBTableAdapter As CTVSYS.DatabaseDataSetTableAdapters.CTVInfoDBTableAdapter
    Friend WithEvents TableAdapterManager As CTVSYS.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CTVInfoDBDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class
