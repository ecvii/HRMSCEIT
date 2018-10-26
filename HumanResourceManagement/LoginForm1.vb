Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.TblUserBindingSource.Filter = "username = '" & UsernameTextBox.Text & "' AND password = '" & PasswordTextBox.Text & "' "
        Dim count As Integer
        count = TblUserDataGridView.Rows.Count
        If count <= 1 Then
            MsgBox("LOL! Try and try until you die.")
        Else
            MsgBox("Welcome!", MsgBoxStyle.Information)
            'FormMain.MenuToolStripMenuItem.Enabled = True
            'FormMain.ReportsToolStripMenuItem.Enabled = True
            'FormMain.UserAccessToolStripMenuItem.Enabled = True
            'FormMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub TblUserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CEITDataSet)

    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CEITDataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.CEITDataSet.tblUser)

    End Sub
End Class
