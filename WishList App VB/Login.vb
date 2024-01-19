Imports Microsoft.VisualBasic.ApplicationServices
Imports WishList_App_VB.Form1

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Implementasikan logika login di sini
        Dim username As String = Guna2TextBox1.Text
        Dim password As String = Guna2TextBox2.Text


        ' Periksa apakah login berhasil menggunakan UserManager
        Dim user As Form1.User = Form1.UserManager.Users.FirstOrDefault(Function(u) u.IsValidLogin(username, password))

        If user IsNot Nothing Then
            ' Jika login berhasil, atur currentUser dan show message berhasil login
            Form1.UserManager.CurrentUser = user
            MessageBox.Show("Login berhasil!")
            Guna2TextBox1.Text = ""
            Guna2TextBox2.Text = ""
            Me.Hide()
            Form1.Show()
        Else
            ' Jika login gagal, beri pesan kepada pengguna
            MessageBox.Show("Login failed. Please check your username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SignupLink_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Me.Hide()
        Signup.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.UserManager.Users.Add(New Form1.User("user1", "123", 100000))
    End Sub
End Class