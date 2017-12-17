Public Class Login
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    End Sub

    Private Sub BunifuTextbox2_OnTextChange(sender As Object, e As EventArgs) Handles txtPassword.OnTextChange

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword._TextBox.PasswordChar = "*"
    End Sub
End Class