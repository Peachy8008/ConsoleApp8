Public Class register
    Private Sub registerbtn_Click(sender As Object, e As EventArgs)
        cmd.CommandText = $"Insert into Accounts (uname, pass) Values('{regusernametxt.Text}','{regpasswordtxt.Text}')"
        cmd.Execute()
        MsgBox("Account registered")
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub logherebtn_Click(sender As Object, e As EventArgs) Handles logherebtn.Click
        login.Show()
        Me.Hide()

    End Sub
End Class