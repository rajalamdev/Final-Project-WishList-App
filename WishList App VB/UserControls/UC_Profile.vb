Public Class UC_Profile
    Private Sub UC_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = Form1.UserManager.CurrentUser.Username
        dompet.Text = Form1.UserManager.CurrentUser.DompetFormatted
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.UserManager.TambahSaldo(Form1.UserManager.CurrentUser, 1000000)
        ' Perbarui Label dompet setelah mengubah nilai dompet
        dompet.Text = Form1.UserManager.CurrentUser.DompetFormatted
    End Sub
End Class
