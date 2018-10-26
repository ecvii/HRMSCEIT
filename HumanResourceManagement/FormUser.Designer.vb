<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim FnameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CEITDataSet = New HumanResourceManagement.CEITDataSet()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TblUserDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblUserTableAdapter = New HumanResourceManagement.CEITDataSetTableAdapters.tblUserTableAdapter()
        Me.TableAdapterManager = New HumanResourceManagement.CEITDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        FnameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEITDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.TblUserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(119, 228)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 10
        IDLabel.Text = "ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(84, 280)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 11
        UsernameLabel.Text = "username:"
        '
        'FnameLabel
        '
        FnameLabel.AutoSize = True
        FnameLabel.Location = New System.Drawing.Point(98, 306)
        FnameLabel.Name = "FnameLabel"
        FnameLabel.Size = New System.Drawing.Size(42, 13)
        FnameLabel.TabIndex = 12
        FnameLabel.Text = "Fname:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(85, 254)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 14
        PasswordLabel.Text = "password:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(7, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(353, 459)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(PasswordLabel)
        Me.TabPage1.Controls.Add(Me.PasswordTextBox)
        Me.TabPage1.Controls.Add(FnameLabel)
        Me.TabPage1.Controls.Add(Me.FnameTextBox)
        Me.TabPage1.Controls.Add(UsernameLabel)
        Me.TabPage1.Controls.Add(Me.UsernameTextBox)
        Me.TabPage1.Controls.Add(IDLabel)
        Me.TabPage1.Controls.Add(Me.IDTextBox)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(345, 433)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Profile"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(146, 251)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 15
        '
        'TblUserBindingSource
        '
        Me.TblUserBindingSource.DataMember = "tblUser"
        Me.TblUserBindingSource.DataSource = Me.CEITDataSet
        '
        'CEITDataSet
        '
        Me.CEITDataSet.DataSetName = "CEITDataSet"
        Me.CEITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FnameTextBox
        '
        Me.FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "Fname", True))
        Me.FnameTextBox.Location = New System.Drawing.Point(146, 303)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FnameTextBox.TabIndex = 13
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(146, 277)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 12
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(146, 225)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(87, 185)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Upload/Browse"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblUserBindingSource, "Image", True))
        Me.PictureBox1.Location = New System.Drawing.Point(87, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(140, 365)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(196, 365)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(84, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.TblUserDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(345, 433)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TblUserDataGridView
        '
        Me.TblUserDataGridView.AllowUserToAddRows = False
        Me.TblUserDataGridView.AllowUserToDeleteRows = False
        Me.TblUserDataGridView.AutoGenerateColumns = False
        Me.TblUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblUserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblUserDataGridView.DataSource = Me.TblUserBindingSource
        Me.TblUserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblUserDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.TblUserDataGridView.Name = "TblUserDataGridView"
        Me.TblUserDataGridView.ReadOnly = True
        Me.TblUserDataGridView.Size = New System.Drawing.Size(339, 427)
        Me.TblUserDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'TblUserTableAdapter
        '
        Me.TblUserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAttendance1TableAdapter = Nothing
        Me.TableAdapterManager.tblAttendanceTableAdapter = Nothing
        Me.TableAdapterManager.tblemployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblSeminarsTableAdapter = Nothing
        Me.TableAdapterManager.tblUserTableAdapter = Me.TblUserTableAdapter
        Me.TableAdapterManager.UpdateOrder = HumanResourceManagement.CEITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 473)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEITDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.TblUserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CEITDataSet As HumanResourceManagement.CEITDataSet
    Friend WithEvents TblUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUserTableAdapter As HumanResourceManagement.CEITDataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents TableAdapterManager As HumanResourceManagement.CEITDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblUserDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
