Public Class login
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        cmd.CommandText = $"Select * from Accounts where Uname = '{logusernametxt.Text}' and Pass = '{logpasswordtxt.Text}'"
        rs = cmd.Execute
        If rs.EOF = False Then
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error")
        End If


    End Sub

    Private Sub rgherebtn_Click(sender As Object, e As EventArgs) Handles rgherebtn.Click
        register.Show()
        Me.Hide()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open(constr)
        cmd.ActiveConnection = con
    End Sub
End Class
