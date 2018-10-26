Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class FormMain

    Private Sub FormMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormUser.ShowDialog()
    End Sub

    Private Sub EmployeeInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormEmployeeInfo.ShowDialog()
    End Sub

    Private Sub SearchEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormEmployeeSearch.ShowDialog()
    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormAttendance.ShowDialog()
    End Sub

    Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'AttendanceToolStripMenuItem.PerformClick()
        'MenuToolStripMenuItem.Enabled = False
        'ReportsToolStripMenuItem.Enabled = False
        'UserAccessToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LogInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoginForm1.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MenuToolStripMenuItem.Enabled = False
        'ReportsToolStripMenuItem.Enabled = False
        'UserAccessToolStripMenuItem.Enabled = False
        'MsgBox("You are now signed out.", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub RadialMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem1.Click
        FormAttendance.Show()
    End Sub

    Private Sub RadialMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem2.Click
        FormEmployeeSearch.Show()
    End Sub

    Private Sub RadialMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem3.Click
        FormEmployeeInfo.Show()
    End Sub

    Private Sub RadialMenuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem4.Click
        FormUser.Show()
    End Sub

    Private Sub RadialMenuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem5.Click
        LoginForm1.ShowDialog()
    End Sub

    Private Sub RadialMenuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem6.Click
        Me.Close()
    End Sub
End Class
