Public Class Form1

    Dim userstr As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Public Sub loaddata()
        DataGridView1.Rows.Clear()
        cmd.CommandText = "Select Uname from Accounts"
        rs = cmd.Execute
        Do While Not rs.EOF
            DataGridView1.Rows.Add(rs.Fields(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd.CommandText = $"Insert into Accounts (uname, pass) Values('{TextBox1.Text}','{TextBox2.Text}')"
        cmd.Execute()
        MsgBox("Account added")
        TextBox1.Clear()
        TextBox2.Clear()
        loaddata()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmd.CommandText = $"Delete from Accounts Where uname = '{userstr}'"
        cmd.Execute()
        MsgBox("Successfully Deleted!")
        TextBox1.Clear()
        TextBox2.Clear()
        loaddata()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If DataGridView1.SelectedRows.Count > 0 Then
            userstr = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd.CommandText = $"Update Accounts set pass = '{TextBox2.Text}' where uname = '{userstr}'"
        cmd.Execute()
        MsgBox("Password Updated")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class