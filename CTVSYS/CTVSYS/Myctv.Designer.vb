<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Myctv
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CTVInfoDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New CTVSYS.DatabaseDataSet()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CTVInfoDBTableAdapter = New CTVSYS.DatabaseDataSetTableAdapters.CTVInfoDBTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyChargeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.CTVInfoDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(21, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 81)
        Me.Panel1.TabIndex = 0
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(225, 37)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(95, 27)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Search"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Welcome to CTVM System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CTVInfoDBBindingSource, "Customer Name", True))
        Me.TextBox1.Location = New System.Drawing.Point(129, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 20)
        Me.TextBox1.TabIndex = 2
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
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CTVInfoDBBindingSource, "Customer Ph", True))
        Me.TextBox2.Location = New System.Drawing.Point(129, 68)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(212, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer Ph"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CTVInfoDBBindingSource, "Area", True))
        Me.TextBox3.Location = New System.Drawing.Point(129, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(212, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Area"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CTVInfoDBBindingSource, "Plan", True))
        Me.TextBox4.Location = New System.Drawing.Point(129, 152)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(212, 20)
        Me.TextBox4.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Plan"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CTVInfoDBBindingSource, "Monthly Charge", True))
        Me.TextBox5.Location = New System.Drawing.Point(129, 195)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(212, 20)
        Me.TextBox5.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Monthly Charge"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CTVInfoDBBindingSource, "Due", True))
        Me.TextBox6.Location = New System.Drawing.Point(129, 237)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(212, 20)
        Me.TextBox6.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Due"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CTVInfoDBBindingSource, "Remark", True))
        Me.TextBox7.Location = New System.Drawing.Point(129, 280)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(212, 20)
        Me.TextBox7.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Remark"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CTVInfoDBBindingSource, "Customer Status", True))
        Me.TextBox8.Location = New System.Drawing.Point(129, 323)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(212, 20)
        Me.TextBox8.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 326)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Customer Status"
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CTVInfoDBBindingSource, "Employee", True))
        Me.TextBox9.Location = New System.Drawing.Point(129, 364)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(212, 20)
        Me.TextBox9.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Employee"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Add New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(266, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(266, 457)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Log Out"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(143, 457)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(21, 457)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "Save"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 480)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'CTVInfoDBTableAdapter
        '
        Me.CTVInfoDBTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Teal
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerPhDataGridViewTextBoxColumn, Me.AreaDataGridViewTextBoxColumn, Me.PlanDataGridViewTextBoxColumn, Me.MonthlyChargeDataGridViewTextBoxColumn, Me.DueDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn, Me.CustomerStatusDataGridViewTextBoxColumn, Me.EmployeeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CTVInfoDBBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(943, 563)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'CustomerPhDataGridViewTextBoxColumn
        '
        Me.CustomerPhDataGridViewTextBoxColumn.DataPropertyName = "Customer Ph"
        Me.CustomerPhDataGridViewTextBoxColumn.HeaderText = "Customer Ph"
        Me.CustomerPhDataGridViewTextBoxColumn.Name = "CustomerPhDataGridViewTextBoxColumn"
        '
        'AreaDataGridViewTextBoxColumn
        '
        Me.AreaDataGridViewTextBoxColumn.DataPropertyName = "Area"
        Me.AreaDataGridViewTextBoxColumn.HeaderText = "Area"
        Me.AreaDataGridViewTextBoxColumn.Name = "AreaDataGridViewTextBoxColumn"
        '
        'PlanDataGridViewTextBoxColumn
        '
        Me.PlanDataGridViewTextBoxColumn.DataPropertyName = "Plan"
        Me.PlanDataGridViewTextBoxColumn.HeaderText = "Plan"
        Me.PlanDataGridViewTextBoxColumn.Name = "PlanDataGridViewTextBoxColumn"
        '
        'MonthlyChargeDataGridViewTextBoxColumn
        '
        Me.MonthlyChargeDataGridViewTextBoxColumn.DataPropertyName = "Monthly Charge"
        Me.MonthlyChargeDataGridViewTextBoxColumn.HeaderText = "Monthly Charge"
        Me.MonthlyChargeDataGridViewTextBoxColumn.Name = "MonthlyChargeDataGridViewTextBoxColumn"
        '
        'DueDataGridViewTextBoxColumn
        '
        Me.DueDataGridViewTextBoxColumn.DataPropertyName = "Due"
        Me.DueDataGridViewTextBoxColumn.HeaderText = "Due"
        Me.DueDataGridViewTextBoxColumn.Name = "DueDataGridViewTextBoxColumn"
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        '
        'CustomerStatusDataGridViewTextBoxColumn
        '
        Me.CustomerStatusDataGridViewTextBoxColumn.DataPropertyName = "Customer Status"
        Me.CustomerStatusDataGridViewTextBoxColumn.HeaderText = "Customer Status"
        Me.CustomerStatusDataGridViewTextBoxColumn.Name = "CustomerStatusDataGridViewTextBoxColumn"
        '
        'EmployeeDataGridViewTextBoxColumn
        '
        Me.EmployeeDataGridViewTextBoxColumn.DataPropertyName = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn.HeaderText = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn.Name = "EmployeeDataGridViewTextBoxColumn"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(385, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(949, 582)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'Myctv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1331, 591)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Myctv"
        Me.Text = "CTVM SYSTEM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CTVInfoDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DatabaseDataSet As CTVSYS.DatabaseDataSet
    Friend WithEvents CTVInfoDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTVInfoDBTableAdapter As CTVSYS.DatabaseDataSetTableAdapters.CTVInfoDBTableAdapter
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthlyChargeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
