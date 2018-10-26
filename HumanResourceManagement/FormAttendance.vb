Public Class FormAttendance
    Dim datenow As Date = Now

    Private Sub TblAttendanceBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblAttendanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CEITDataSet)

    End Sub

    Private Sub FormAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CEITDataSet.tblAttendance1' table. You can move, or remove it, as needed.
        Me.TblAttendance1TableAdapter.Fill(Me.CEITDataSet.tblAttendance1)
        'TODO: This line of code loads data into the 'CEITDataSet.tblAttendance' table. You can move, or remove it, as needed.
        Me.TblAttendanceTableAdapter.Fill(Me.CEITDataSet.tblAttendance)
        'TODO: This line of code loads data into the 'CEITDataSet.EmployeeAttendance1' table. You can move, or remove it, as needed.
        Me.EmployeeAttendance1TableAdapter.Fill(Me.CEITDataSet.EmployeeAttendance1)
        'TODO: This line of code loads data into the 'CEITDataSet.EmployeeAttendance' table. You can move, or remove it, as needed.
        Me.EmployeeAttendanceTableAdapter.Fill(Me.CEITDataSet.EmployeeAttendance)
        'TODO: This line of code loads data into the 'CEITDataSet.EmployeeAttendance1' table. You can move, or remove it, as needed.
        Me.EmployeeAttendance1TableAdapter.Fill(Me.CEITDataSet.EmployeeAttendance1)
        'TODO: This line of code loads data into the 'CEITDataSet.tblAttendance1' table. You can move, or remove it, as needed.
        Me.TblAttendance1TableAdapter.Fill(Me.CEITDataSet.tblAttendance1)
        'TODO: This line of code loads data into the 'CEITDataSet.tblAttendance' table. You can move, or remove it, as needed.
        Me.TblAttendanceTableAdapter.Fill(Me.CEITDataSet.tblAttendance)
        'TODO: This line of code loads data into the 'CEITDataSet.EmployeeAttendance' table. You can move, or remove it, as needed.
        Me.EmployeeAttendanceTableAdapter.Fill(Me.CEITDataSet.EmployeeAttendance)
        WorkIDTextBox.Visible = False
        WorkIDTextBox1.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox1.Text = datenow.ToString("MM/d/yyyy") & " " & TimeOfDay
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TblAttendanceBindingSource.AddNew()
        'TblAttendance1BindingSource.AddNew()
        WorkIDTextBox.Visible = True
        WorkIDTextBox1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If WorkIDTextBox.Text = "" Then
            MsgBox("Unable to save, please enter your WorkID.", MsgBoxStyle.Exclamation)
        Else
            LoginDateTextBox.Text = datenow.ToString("MM/d/yyyy")
            LoginTimeTextBox.Text = TimeOfDay
            Me.Validate()
            Me.TblAttendanceBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CEITDataSet)
            Me.TblAttendanceTableAdapter.Fill(Me.CEITDataSet.tblAttendance)
            Me.EmployeeAttendanceTableAdapter.Fill(Me.CEITDataSet.EmployeeAttendance)
            MsgBox("Information has been added/updated to the database.", MsgBoxStyle.Information)
        End If
        WorkIDTextBox.Visible = False
        Button1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If WorkIDTextBox1.Text = "" Then
            MsgBox("Unable to save, please enter your WorkID.", MsgBoxStyle.Exclamation)
        Else
            LogoutDateTextBox.Text = datenow.ToString("MM/d/yyyy")
            LogoutTimeTextBox.Text = TimeOfDay
            Me.Validate()
            Me.TblAttendance1BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CEITDataSet)
            Me.TblAttendance1TableAdapter.Fill(Me.CEITDataSet.tblAttendance1)
            Me.EmployeeAttendance1TableAdapter.Fill(Me.CEITDataSet.EmployeeAttendance1)
            MsgBox("Information has been added/updated to the database.", MsgBoxStyle.Information)
        End If
        WorkIDTextBox1.Visible = False
        Button2.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TblAttendance1BindingSource.AddNew()
        WorkIDTextBox1.Visible = True
        WorkIDTextBox.Visible = False
    End Sub

    Private Sub RadialMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem1.Click
        TblAttendanceBindingSource.AddNew()
        'TblAttendance1BindingSource.AddNew()
        WorkIDTextBox.Visible = True
        WorkIDTextBox1.Visible = False
        Button1.Visible = True
        Label1.Visible = True
    End Sub

    Private Sub RadialMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem2.Click
        TblAttendance1BindingSource.AddNew()
        WorkIDTextBox1.Visible = True
        WorkIDTextBox.Visible = False
        Button2.Visible = True
        Label1.Visible = True
    End Sub

    Private Sub RadialMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem3.Click
        Me.Close()
    End Sub
End Class