Public Class UC_CustomWish
    ' Event untuk menambahkan wish list
    Public Event AddToWishList As Action(Of Form1.WishListItem)

    Private Sub AddToWishListButton_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Mendapatkan informasi dari input
        Dim itemName As String = Guna2TextBox1.Text
        Dim itemPrice As Double

        ' Validasi harga
        If Double.TryParse(Guna2TextBox2.Text, itemPrice) Then
            ' Membuat objek WishListItem
            Dim newItem As New Form1.WishListItem(itemName, itemPrice)

            ' Item belum ada di dalam wish list, tambahkan ke dalam array
            Form1.WishListItem.TambahWishlist(newItem)

            ' Memicu event untuk menambahkan wish list
            RaiseEvent AddToWishList(newItem)
            MessageBox.Show("Success.")
            Guna2TextBox1.Text = ""
            Guna2TextBox2.Text = ""
        Else
            MessageBox.Show("Invalid price. Please enter a valid number.")
        End If
    End Sub
End Class
