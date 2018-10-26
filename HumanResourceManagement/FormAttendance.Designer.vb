<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAttendance
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
        Dim LoginDateLabel As System.Windows.Forms.Label
        Dim LoginTimeLabel As System.Windows.Forms.Label
        Dim LogoutDateLabel As System.Windows.Forms.Label
        Dim LogoutTimeLabel As System.Windows.Forms.Label
        Me.WorkIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CEITDataSet = New HumanResourceManagement.CEITDataSet()
        Me.LoginDateTextBox = New System.Windows.Forms.TextBox()
        Me.LoginTimeTextBox = New System.Windows.Forms.TextBox()
        Me.LogoutDateTextBox = New System.Windows.Forms.TextBox()
        Me.TblAttendance1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogoutTimeTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EmployeeAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeAttendanceTableAdapter = New HumanResourceManagement.CEITDataSetTableAdapters.EmployeeAttendanceTableAdapter()
        Me.TableAdapterManager = New HumanResourceManagement.CEITDataSetTableAdapters.TableAdapterManager()
        Me.TblAttendance1TableAdapter = New HumanResourceManagement.CEITDataSetTableAdapters.tblAttendance1TableAdapter()
        Me.TblAttendanceTableAdapter = New HumanResourceManagement.CEITDataSetTableAdapters.tblAttendanceTableAdapter()
        Me.EmployeeAttendanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeAttendance1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeAttendance1TableAdapter = New HumanResourceManagement.CEITDataSetTableAdapters.EmployeeAttendance1TableAdapter()
        Me.EmployeeAttendance1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RadialMenu1 = New DevComponents.DotNetBar.RadialMenu()
        Me.RadialMenuItem1 = New DevComponents.DotNetBar.RadialMenuItem()
        Me.RadialMenuItem2 = New DevComponents.DotNetBar.RadialMenuItem()
        Me.RadialMenuItem3 = New DevComponents.DotNetBar.RadialMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        LoginDateLabel = New System.Windows.Forms.Label()
        LoginTimeLabel = New System.Windows.Forms.Label()
        LogoutDateLabel = New System.Windows.Forms.Label()
        LogoutTimeLabel = New System.Windows.Forms.Label()
        CType(Me.TblAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEITDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAttendance1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeAttendanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeAttendance1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeAttendance1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginDateLabel
        '
        LoginDateLabel.AutoSize = True
        LoginDateLabel.Location = New System.Drawing.Point(87, 514)
        LoginDateLabel.Name = "LoginDateLabel"
        LoginDateLabel.Size = New System.Drawing.Size(62, 13)
        LoginDateLabel.TabIndex = 3
        LoginDateLabel.Text = "Login Date:"
        '
        'LoginTimeLabel
        '
        LoginTimeLabel.AutoSize = True
        LoginTimeLabel.Location = New System.Drawing.Point(87, 540)
        LoginTimeLabel.Name = "LoginTimeLabel"
        LoginTimeLabel.Size = New System.Drawing.Size(62, 13)
        LoginTimeLabel.TabIndex = 5
        LoginTimeLabel.Text = "Login Time:"
        '
        'LogoutDateLabel
        '
        LogoutDateLabel.AutoSize = True
        LogoutDateLabel.Location = New System.Drawing.Point(80, 566)
        LogoutDateLabel.Name = "LogoutDateLabel"
        LogoutDateLabel.Size = New System.Drawing.Size(69, 13)
        LogoutDateLabel.TabIndex = 7
        LogoutDateLabel.Text = "Logout Date:"
        '
        'LogoutTimeLabel
        '
        LogoutTimeLabel.AutoSize = True
        LogoutTimeLabel.Location = New System.Drawing.Point(80, 592)
        LogoutTimeLabel.Name = "LogoutTimeLabel"
        LogoutTimeLabel.Size = New System.Drawing.Size(69, 13)
        LogoutTimeLabel.TabIndex = 9
        LogoutTimeLabel.Text = "Logout Time:"
        '
        'WorkIDTextBox
        '
        Me.WorkIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendanceBindingSource, "WorkID", True))
        Me.WorkIDTextBox.Location = New System.Drawing.Point(426, 353)
        Me.WorkIDTextBox.Name = "WorkIDTextBox"
        Me.WorkIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WorkIDTextBox.TabIndex = 2
        Me.WorkIDTextBox.Visible = False
        '
        'TblAttendanceBindingSource
        '
        Me.TblAttendanceBindingSource.DataMember = "tblAttendance"
        Me.TblAttendanceBindingSource.DataSource = Me.CEITDataSet
        '
        'CEITDataSet
        '
        Me.CEITDataSet.DataSetName = "CEITDataSet"
        Me.CEITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginDateTextBox
        '
        Me.LoginDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendanceBindingSource, "LoginDate", True))
        Me.LoginDateTextBox.Location = New System.Drawing.Point(155, 511)
        Me.LoginDateTextBox.Name = "LoginDateTextBox"
        Me.LoginDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LoginDateTextBox.TabIndex = 4
        '
        'LoginTimeTextBox
        '
        Me.LoginTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendanceBindingSource, "LoginTime", True))
        Me.LoginTimeTextBox.Location = New System.Drawing.Point(155, 537)
        Me.LoginTimeTextBox.Name = "LoginTimeTextBox"
        Me.LoginTimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LoginTimeTextBox.TabIndex = 6
        '
        'LogoutDateTextBox
        '
        Me.LogoutDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendance1BindingSource, "LogoutDate", True))
        Me.LogoutDateTextBox.Location = New System.Drawing.Point(155, 563)
        Me.LogoutDateTextBox.Name = "LogoutDateTextBox"
        Me.LogoutDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LogoutDateTextBox.TabIndex = 8
        '
        'TblAttendance1BindingSource
        '
        Me.TblAttendance1BindingSource.DataMember = "tblAttendance1"
        Me.TblAttendance1BindingSource.DataSource = Me.CEITDataSet
        '
        'LogoutTimeTextBox
        '
        Me.LogoutTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendance1BindingSource, "LogoutTime", True))
        Me.LogoutTimeTextBox.Location = New System.Drawing.Point(155, 589)
        Me.LogoutTimeTextBox.Name = "LogoutTimeTextBox"
        Me.LogoutTimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LogoutTimeTextBox.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(929, 42)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(426, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(426, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(12, 340)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Enter ID"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'EmployeeAttendanceBindingSource
        '
        Me.EmployeeAttendanceBindingSource.DataMember = "EmployeeAttendance"
        Me.EmployeeAttendanceBindingSource.DataSource = Me.CEITDataSet
        '
        'EmployeeAttendanceTableAdapter
        '
        Me.EmployeeAttendanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAttendance1TableAdapter = Me.TblAttendance1TableAdapter
        Me.TableAdapterManager.tblAttendanceTableAdapter = Me.TblAttendanceTableAdapter
        Me.TableAdapterManager.tblemployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblSeminarsTableAdapter = Nothing
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HumanResourceManagement.CEITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblAttendance1TableAdapter
        '
        Me.TblAttendance1TableAdapter.ClearBeforeFill = True
        '
        'TblAttendanceTableAdapter
        '
        Me.TblAttendanceTableAdapter.ClearBeforeFill = True
        '
        'EmployeeAttendanceDataGridView
        '
        Me.EmployeeAttendanceDataGridView.AllowUserToAddRows = False
        Me.EmployeeAttendanceDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeAttendanceDataGridView.AutoGenerateColumns = False
        Me.EmployeeAttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeAttendanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.EmployeeAttendanceDataGridView.DataSource = Me.EmployeeAttendanceBindingSource
        Me.EmployeeAttendanceDataGridView.Location = New System.Drawing.Point(12, 102)
        Me.EmployeeAttendanceDataGridView.Name = "EmployeeAttendanceDataGridView"
        Me.EmployeeAttendanceDataGridView.ReadOnly = True
        Me.EmployeeAttendanceDataGridView.Size = New System.Drawing.Size(417, 220)
        Me.EmployeeAttendanceDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WorkID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "WorkID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LoginDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LoginDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LoginTime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LoginTime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'EmployeeAttendance1BindingSource
        '
        Me.EmployeeAttendance1BindingSource.DataMember = "EmployeeAttendance1"
        Me.EmployeeAttendance1BindingSource.DataSource = Me.CEITDataSet
        '
        'EmployeeAttendance1TableAdapter
        '
        Me.EmployeeAttendance1TableAdapter.ClearBeforeFill = True
        '
        'EmployeeAttendance1DataGridView
        '
        Me.EmployeeAttendance1DataGridView.AllowUserToAddRows = False
        Me.EmployeeAttendance1DataGridView.AllowUserToDeleteRows = False
        Me.EmployeeAttendance1DataGridView.AutoGenerateColumns = False
        Me.EmployeeAttendance1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeAttendance1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.EmployeeAttendance1DataGridView.DataSource = Me.EmployeeAttendance1BindingSource
        Me.EmployeeAttendance1DataGridView.Location = New System.Drawing.Point(524, 102)
        Me.EmployeeAttendance1DataGridView.Name = "EmployeeAttendance1DataGridView"
        Me.EmployeeAttendance1DataGridView.ReadOnly = True
        Me.EmployeeAttendance1DataGridView.Size = New System.Drawing.Size(417, 220)
        Me.EmployeeAttendance1DataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "WorkID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "WorkID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn16.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn15.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "LogoutDate"
        Me.DataGridViewTextBoxColumn13.HeaderText = "LogoutDate"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "LogoutTime"
        Me.DataGridViewTextBoxColumn14.HeaderText = "LogoutTime"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'WorkIDTextBox1
        '
        Me.WorkIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendance1BindingSource, "WorkID", True))
        Me.WorkIDTextBox1.Location = New System.Drawing.Point(426, 353)
        Me.WorkIDTextBox1.Name = "WorkIDTextBox1"
        Me.WorkIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.WorkIDTextBox1.TabIndex = 18
        Me.WorkIDTextBox1.Visible = False
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(174, 340)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(156, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Enter ID"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'RadialMenu1
        '
        Me.RadialMenu1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RadialMenuItem1, Me.RadialMenuItem2, Me.RadialMenuItem3})
        Me.RadialMenu1.Location = New System.Drawing.Point(462, 206)
        Me.RadialMenu1.Name = "RadialMenu1"
        Me.RadialMenu1.Size = New System.Drawing.Size(28, 28)
        Me.RadialMenu1.Symbol = ""
        Me.RadialMenu1.TabIndex = 20
        Me.RadialMenu1.Text = "RadialMenu1"
        '
        'RadialMenuItem1
        '
        Me.RadialMenuItem1.Name = "RadialMenuItem1"
        Me.RadialMenuItem1.Text = "LOG IN"
        '
        'RadialMenuItem2
        '
        Me.RadialMenuItem2.Name = "RadialMenuItem2"
        Me.RadialMenuItem2.Text = "LOG OUT"
        '
        'RadialMenuItem3
        '
        Me.RadialMenuItem3.Name = "RadialMenuItem3"
        Me.RadialMenuItem3.Text = "CLOSE"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(423, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ENTER YOUR ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'FormAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 451)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadialMenu1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.WorkIDTextBox1)
        Me.Controls.Add(Me.EmployeeAttendance1DataGridView)
        Me.Controls.Add(Me.EmployeeAttendanceDataGridView)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(LogoutTimeLabel)
        Me.Controls.Add(Me.LogoutTimeTextBox)
        Me.Controls.Add(LogoutDateLabel)
        Me.Controls.Add(Me.LogoutDateTextBox)
        Me.Controls.Add(LoginTimeLabel)
        Me.Controls.Add(Me.LoginTimeTextBox)
        Me.Controls.Add(LoginDateLabel)
        Me.Controls.Add(Me.LoginDateTextBox)
        Me.Controls.Add(Me.WorkIDTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance"
        CType(Me.TblAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEITDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAttendance1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeAttendanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeAttendance1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeAttendance1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WorkIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogoutDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogoutTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CEITDataSet As HumanResourceManagement.CEITDataSet
    Friend WithEvents EmployeeAttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeAttendanceTableAdapter As HumanResourceManagement.CEITDataSetTableAdapters.EmployeeAttendanceTableAdapter
    Friend WithEvents TableAdapterManager As HumanResourceManagement.CEITDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeAttendanceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeeAttendance1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeAttendance1TableAdapter As HumanResourceManagement.CEITDataSetTableAdapters.EmployeeAttendance1TableAdapter
    Friend WithEvents EmployeeAttendance1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblAttendanceTableAdapter As HumanResourceManagement.CEITDataSetTableAdapters.tblAttendanceTableAdapter
    Friend WithEvents TblAttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAttendance1TableAdapter As HumanResourceManagement.CEITDataSetTableAdapters.tblAttendance1TableAdapter
    Friend WithEvents TblAttendance1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkIDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RadialMenu1 As DevComponents.DotNetBar.RadialMenu
    Friend WithEvents RadialMenuItem1 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents RadialMenuItem2 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadialMenuItem3 As DevComponents.DotNetBar.RadialMenuItem
End Class
