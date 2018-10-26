Public Class FormUser

    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CEITDataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.CEITDataSet.tblUser)
        'TODO: This line of code loads data into the 'CEITDataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.CEITDataSet.tblUser)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim open As New OpenFileDialog
            open.Filter = "JPG|*.jpg|BMP|*.bmp|GIF|*.gif |All Files|*.*"
            If open.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = (System.Drawing.Bitmap.FromFile(open.FileName))
            End If
        Catch ex As Exception
            MsgBox("Error while uploading image please try again later.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Or FnameTextBox.Text = "" Then
            MsgBox("Unable to save, please fill up all the blank fields.", MsgBoxStyle.Exclamation)
        Else
            Me.Validate()
            Me.TblUserBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CEITDataSet)
            Me.TblUserTableAdapter.Fill(Me.CEITDataSet.tblUser)
            MsgBox("User has been added/updated to the database.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If MsgBox("Are you sure you want to remove selected data?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TblUserBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblUserBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.CEITDataSet)
                Me.TblUserTableAdapter.Fill(Me.CEITDataSet.tblUser)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TblUserBindingSource.AddNew()
        UsernameTextBox.Focus()
    End Sub

    Private Sub TblUserDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        TabControl1.SelectTab(0)
    End Sub

    Private Sub TblUserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CEITDataSet)

    End Sub
End Class