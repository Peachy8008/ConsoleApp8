Public Class calcu
    Private Sub calcu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles ButtonZero.Click, ButtonPoint.Click, Button9.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button.Click
        Dim button As Button = CType(sender, Button)
        TextBox1.Text = TextBox1.Text & button.Text
    End Sub

    Private Sub ButtonOperators(sender As Object, e As EventArgs) Handles ButtonPlus.Click, ButtonMultiply.Click, ButtonMinus.Click, ButtonDivide.Click
        Dim button As Button = CType(sender, Button)
        TextBox1.Text = TextBox1.Text & "" & button.Text & ""
    End Sub

    Private Sub ButtonEqualsto(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        Try
            Dim result = New DataTable().Compute(TextBox1.Text, Nothing)
            TextBox1.Text = result.ToString()
        Catch ex As Exception
            TextBox1.Text = "Syntax Error"
        End Try
    End Sub

    Private Sub ButtonClearbox(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If

        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
    End Sub
End Class