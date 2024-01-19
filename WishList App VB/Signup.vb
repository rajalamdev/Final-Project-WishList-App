Imports Microsoft.VisualBasic.ApplicationServices

Public Class Signup
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Implementasikan logika pendaftaran pengguna di sini
        Dim username As String = Guna2TextBox1.Text
        Dim password As String = Guna2TextBox2.Text

        ' Validate jika ada input kosong
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the click event handler
        End If

        ' Periksa apakah pengguna sudah terdaftar
        If Form1.UserManager.Users.Any(Function(u) u.Username = username) Then
            MessageBox.Show("Username is already taken. Please choose a different one.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Tambahkan pengguna baru ke UserManager
            Form1.UserManager.Users.Add(New Form1.User(username, password, 0))

            ' Beri pesan bahwa pendaftaran berhasil
            MessageBox.Show("Signup successful. You can now log in.", "Signup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Tutup form signup
            Guna2TextBox1.Text = ""
            Guna2TextBox2.Text = ""
            Me.Hide()
            Login.Show()
        End If
    End Sub
    Private Sub LoginLink_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Me.Hide()
        Login.Show()
    End Sub

End Class