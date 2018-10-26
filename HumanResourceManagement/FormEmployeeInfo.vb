Public Class FormEmployeeInfo

    Private Sub TblemployeeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblemployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CEITDataSet)

    End Sub

    Private Sub FormEmployeeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CEITDataSet.tblemployee' table. You can move, or remove it, as needed.
        Me.TblemployeeTableAdapter.Fill(Me.CEITDataSet.tblemployee)
        'Button1.PerformClick()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If WorkIDTextBox.Text = "" Then
            MsgBox("Unable to save, please fill up all the blank fields.", MsgBoxStyle.Exclamation)
        Else
            Me.Validate()
            Me.TblemployeeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CEITDataSet)
            Me.TblemployeeTableAdapter.Fill(Me.CEITDataSet.tblemployee)
            'Button1.Enabled = True
            'Button1.PerformClick()
            'Button1.Enabled = False
            MsgBox("Information has been added/updated to the database.", MsgBoxStyle.Information)
        End If
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TblemployeeBindingSource.AddNew()
        'Button1.Enabled = False
        WorkIDTextBox.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.TblemployeeBindingSource.Filter = "WorkID like '%" & TextBox1.Text & "%' "
    End Sub
End Class