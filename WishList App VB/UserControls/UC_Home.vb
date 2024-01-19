Imports System.Globalization

Public Class UC_Home
    Public Event AddToWishList As Action(Of Form1.WishListItem)

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button_1.Click, Button_2.Click, Button_3.Click, Button_4.Click, Button_5.Click, Button_6.Click
        ' Mendapatkan referensi tombol yang diklik
        Dim clickedButton As Button = DirectCast(sender, Button)

        ' Mendapatkan referensi ke kotak kartu yang berisi tombol yang diklik
        Dim cardPanel As Panel = DirectCast(clickedButton.Parent, Panel)

        ' Memanggil fungsi untuk menampilkan nilai di dalam kartu
        ShowCardValues(cardPanel, clickedButton)
    End Sub

    ' Fungsi untuk menambahkan item ke dalam wishlist
    Private Sub ShowCardValues(cardPanel As Panel, clickedButton As Button)
        ' Inisialisasi variabel untuk menyimpan nama dan harga
        Dim itemName As String = ""
        Dim itemPrice As Double = 0.0

        ' Loop melalui kontrol di dalam kartu
        For Each control As Control In cardPanel.Controls
            If TypeOf control Is Label Then
                ' Jika kontrol adalah label, ambil nilai label
                Dim labelName As String = control.Name
                Dim labelValue As String = DirectCast(control, Label).Text

                ' Tentukan bagaimana Anda ingin menentukan nilai untuk item wish list
                ' Misalnya, jika labelName mengandung "Name", anggap itu adalah label nama
                If labelName.ToLower().Contains("name") Then
                    itemName = labelValue
                ElseIf labelName.ToLower().Contains("price") Then
                    ' Hilangkan simbol mata uang dan tanda koma ribuan
                    Dim cleanString As String = labelValue.Replace("Rp ", "").Replace(".", "")

                    ' Jika labelName mengandung "Price", anggap itu adalah label harga
                    If Double.TryParse(cleanString, itemPrice) Then
                        ' Jika harga dapat di-parse sebagai Double
                    Else
                        MessageBox.Show("Invalid price. Skipping item.")
                        Exit Sub
                    End If
                End If
            End If
        Next

        ' Validasi apakah nilai item berhasil didapatkan
        If Not String.IsNullOrEmpty(itemName) AndAlso itemPrice > 0.0 Then
            ' Membuat objek WishListItem
            Dim newItem As New Form1.WishListItem(itemName, itemPrice, clickedButton.Tag)

            ' Mengecek apakah item sudah ada di dalam wish list berdasarkan ID
            If Not Form1.WishListItem.GetWishList().Any(Function(item) item.ID = newItem.ID) Then
                ' Item belum ada di dalam wish list, tambahkan ke dalam array
                Form1.WishListItem.TambahWishlist(newItem)

                ' Memicu event untuk menambahkan wish list
                RaiseEvent AddToWishList(newItem)

                ' Menonaktifkan tombol di kartu
                clickedButton.Enabled = False
                clickedButton.Text = "Added"

                ' Tambahkan logika untuk mengubah warna kartu jika uang cukup
                Dim user As Form1.User = Form1.UserManager.GetUserByUsername(Form1.UserManager.CurrentUser.Username)
                If user IsNot Nothing AndAlso user.Dompet >= newItem.Price Then
                    cardPanel.BackColor = ColorTranslator.FromHtml("#6554AF")
                End If

                ' Menambahkan tombol yang akan terdisable
                Form1.ButtonDisabledHandler(clickedButton.Tag)

            Else
                ' Item sudah ada di dalam wish list, tampilkan informasi atau lakukan sesuai kebutuhan
                MessageBox.Show("Item is already in the wish list.")
            End If
        Else
            MessageBox.Show("Failed to get item information. Please check card structure.")
        End If
    End Sub

    Private Sub UC_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mendapatkan tombol-tombol yang sudah dinonaktifkan dari Form1
        Dim disabledButtons As List(Of Integer) = Form1.DisabledButtonsList

        ' Mendapatkan semua tombol yang berada di UC_Home
        Dim allButtons As IEnumerable(Of Button) = GetAllButtons(Me)
        Dim allPanels As IEnumerable(Of Panel) = GetAllPanels(FlowLayoutPanel1)


        ' Menonaktifkan tombol-tombol berdasarkan daftar tombol yang sudah dinonaktifkan
        For Each button As Button In allButtons
            If disabledButtons.Contains(button.Tag) Then
                button.Enabled = False
                button.Text = "Added"
            Else
                button.Enabled = True
                button.Text = "Add"
            End If
        Next

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
                        cardPanel.BackColor = ColorTranslator.FromHtml("#6554AF")
                    End If
                End If
            End If
        Next

    End Sub

    ' Fungsi rekursif untuk mendapatkan semua tombol di dalam suatu kontrol dan kontrol anaknya
    Private Function GetAllButtons(container As Control) As IEnumerable(Of Button)

        Dim buttons As New List(Of Button)

        For Each control As Control In container.Controls
            If TypeOf control Is Button Then
                buttons.Add(DirectCast(control, Button))
            End If

            ' Jika kontrol memiliki kontrol anak, panggil fungsi ini secara rekursif
            If control.HasChildren Then
                buttons.AddRange(GetAllButtons(control))
            End If
        Next

        Return buttons
    End Function

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
End Class
