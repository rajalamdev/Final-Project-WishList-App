Imports System.Globalization

Public Class UC_WishList

    ' Daftar wishlist awal sebelum diurutkan
    Private originalWishList As List(Of Form1.WishListItem)
    Private Sub UC_WishList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Tampilkan kembali daftar wishlist berdasarkan jenis pengurutan yang sedang aktif
        Select Case Form1.WishListItem.currentSorting
            Case Form1.WishListItem.currentSorting.DefaultSort
                SortByDefault()
            Case Form1.WishListItem.currentSorting.PriceSort
                SortByPrice()
            Case Form1.WishListItem.currentSorting.SaldoSort
                SortBySaldo()
        End Select

        ' Loop melalui semua panel di dalam form
        For Each cardPanel As Panel In GetAllPanels(Me)
            ' Lakukan pemeriksaan saldo untuk setiap kartu
            Dim itemNameLabel As Label = cardPanel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.ToLower().Contains("name"))
            Dim itemPriceLabel As Label = cardPanel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.ToLower().Contains("price"))

            ' Pastikan label nama dan harga ada di dalam kartu
            If itemNameLabel IsNot Nothing AndAlso itemPriceLabel IsNot Nothing Then
                Dim itemName As String = itemNameLabel.Text

                ' Pastikan harga dapat di-parse sebagai Double
                Dim itemPrice As Double
                If Double.TryParse(itemPriceLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, itemPrice) Then
                    ' Cek jika saldo cukup, dan jika ya, ubah warna kartu menjadi hijau
                    If Form1.UserManager.CurrentUser IsNot Nothing AndAlso Form1.UserManager.CurrentUser.Dompet >= itemPrice Then
                        cardPanel.BackColor = Color.LightGreen
                    End If
                End If
            End If
        Next
    End Sub

    ' Menampilkan daftar wishlist
    Private Sub DisplayWishList(wishList As List(Of Form1.WishListItem))
        ' Clear existing controls
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoSize = False
        FlowLayoutPanel1.WrapContents = True

        ' Check if wishlist is empty
        If Form1.WishListItem.WishListArray.Count = 0 Then
            ' Add label to center of page
            Dim label As New Label()
            label.Text = "No items yet"
            label.AutoSize = False
            label.ForeColor = Color.Black
            FlowLayoutPanel1.Controls.Add(label)
        End If


        ' Tambahkan kontrol untuk setiap item dalam wishlist
        For Each item As Form1.WishListItem In wishList
            Dim panel As New Panel()
            Dim labelName As New Label()
            Dim labelPrice As New Label()
            Dim buttonDelete As New Button()

            ' Konfigurasi panel
            panel.BorderStyle = BorderStyle.FixedSingle
            panel.Size = New Size(230, 100)

            ' Konfigurasi labelName
            labelName.Text = item.Name
            labelName.Location = New Point(10, 10)

            ' Konfigurasi labelPrice
            labelPrice.Text = item.PriceFormatted
            labelPrice.Location = New Point(10, 40)

            ' Konfigurasi buttonDelete
            buttonDelete.Text = "Delete"
            buttonDelete.Tag = item.ID
            buttonDelete.Location = New Point(10, 70)
            AddHandler buttonDelete.Click, AddressOf DeleteButtonClick

            ' Tambahkan kontrol ke Panel
            panel.Controls.Add(labelName)
            panel.Controls.Add(labelPrice)
            panel.Controls.Add(buttonDelete)

            ' Tambahkan logika untuk mengubah warna kartu jika uang cukup
            Dim user As Form1.User = Form1.UserManager.GetUserByUsername(Form1.UserManager.CurrentUser.Username)
            If user IsNot Nothing AndAlso user.Dompet >= item.Price Then
                panel.BackColor = ColorTranslator.FromHtml("#6554AF")
            Else
                panel.BackColor = ColorTranslator.FromHtml("#2B2730")
            End If

            ' Tambahkan Panel ke FlowLayoutPanel1
            FlowLayoutPanel1.Controls.Add(panel)
        Next
    End Sub

    ' Penanganan klik tombol hapus
    Private Sub DeleteButtonClick(sender As Object, e As EventArgs)
        ' Dapatkan ID dari tombol yang diklik
        Dim itemId As Integer = CInt(DirectCast(sender, Button).Tag)

        ' Hapus item dari wishlist menggunakan WishListItem.HapusWishlist(itemId)
        Form1.WishListItem.HapusWishlist(itemId)

        ' Hapus id button disable
        Form1.RemoveDisabledButton(itemId)

        ' Perbarui originalWishList
        originalWishList = Form1.WishListItem.GetWishList().ToList()

        ' Tampilkan kembali daftar wishlist berdasarkan jenis pengurutan yang sedang aktif
        Select Case Form1.WishListItem.currentSorting
            Case Form1.WishListItem.currentSorting.DefaultSort
                SortByDefault()
            Case Form1.WishListItem.currentSorting.PriceSort
                SortByPrice()
            Case Form1.WishListItem.currentSorting.SaldoSort
                SortBySaldo()
        End Select
    End Sub

    ' Fungsi rekursif untuk mendapatkan semua panel di dalam suatu kontrol dan kontrol anaknya
    Private Function GetAllPanels(container As Control) As IEnumerable(Of Panel)
        Dim panels As New List(Of Panel)

        For Each control As Control In container.Controls
            If TypeOf control Is Panel Then
                panels.Add(DirectCast(control, Panel))
            End If

            ' Jika kontrol memiliki kontrol anak, panggil fungsi ini secara rekursif
            If control.HasChildren Then
                panels.AddRange(GetAllPanels(control))
            End If
        Next

        Return panels
    End Function

    ' Fungsi untuk mengurutkan wishlist secara default by id
    Private Sub SortByDefault()
        Form1.WishListItem.currentSorting = Form1.WishListItem.SortingType.DefaultSort

        ' Dapatkan daftar wishlist dari WishListItem.GetWishList()
        Dim wishList As List(Of Form1.WishListItem) = Form1.WishListItem.GetWishList()

        DisplayWishList(wishList)
    End Sub


    ' Fungsi untuk mengurutkan wishlist berdasarkan saldo
    Private Sub SortBySaldo()
        Form1.WishListItem.currentSorting = Form1.WishListItem.SortingType.SaldoSort

        ' Sinkron data agar selalu update
        originalWishList = Form1.WishListItem.GetWishList().ToList()

        ' Urutkan berdasarkan harga dari daftar asli
        Dim sortedList = originalWishList.OrderBy(Function(item) item.Price).ToList()

        ' Tampilkan ulang daftar wishlist yang sudah diurutkan
        DisplayWishList(sortedList)
    End Sub

    ' Fungsi untuk mengurutkan wishlist berdasarkan price
    Private Sub SortByPrice()
        Form1.WishListItem.currentSorting = Form1.WishListItem.SortingType.PriceSort

        ' Sinkron data agar selalu update
        originalWishList = Form1.WishListItem.GetWishList().ToList()

        ' Urutkan berdasarkan saldo dari daftar asli
        Dim sortedList = originalWishList.OrderBy(Function(item) item.Price <= Form1.UserManager.CurrentUser.Dompet).ToList()

        ' Tampilkan ulang daftar wishlist yang sudah diurutkan
        DisplayWishList(sortedList)
    End Sub

    Private Sub SortByPriceBtn_Click(sender As Object, e As EventArgs) Handles SortByPriceBtn.Click
        SortByPrice()
    End Sub

    Private Sub SortBySaldoButton_Click(sender As Object, e As EventArgs) Handles SortBySaldoButton.Click
        SortBySaldo()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
