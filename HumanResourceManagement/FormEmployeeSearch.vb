Public Class FormEmployeeSearch

    Private Sub TblemployeeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblemployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CEITDataSet)

    End Sub

    Private Sub FormEmployeeSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CEITDataSet.tblemployee' table. You can move, or remove it, as needed.
        Me.TblemployeeTableAdapter.Fill(Me.CEITDataSet.tblemployee)

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        Me.TblemployeeBindingSource.Filter = "LastName like '%" & ToolStripTextBox1.Text & "%' "
    End Sub

    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.TextChanged
        Me.TblemployeeBindingSource.Filter = "WorkID like '%" & ToolStripTextBox2.Text & "%' "
    End Sub
End Class