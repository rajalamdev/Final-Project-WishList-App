Public Class Form1
    Public Class User
        Public Property Username As String
        Public Property Password As String
        Public Property Dompet As Double

        Public Sub New(username As String, password As String, dompet As Double)
            Me.Username = username
            Me.Password = password
            Me.Dompet = dompet
        End Sub

        ' Properti untuk memformat nilai dompet sebagai string
        Public ReadOnly Property DompetFormatted As String
            Get
                Return Me.Dompet.ToString("C0", New Globalization.CultureInfo("id-ID"))
            End Get
        End Property

        Public Function IsValidLogin(username As String, password As String) As Boolean
            Return Me.Username = username AndAlso Me.Password = password
        End Function
    End Class

    Public Class UserManager
        Public Shared Users As New List(Of User)()
        Public Shared Property CurrentUser As User

        ' Metode untuk menambah saldo pada user tertentu
        Public Shared Sub TambahSaldo(user As User, jumlah As Double)
            user.Dompet += jumlah
        End Sub

        Public Shared Function GetUserByUsername(username As String) As User
            Return Users.FirstOrDefault(Function(u) u.Username = username)
        End Function
    End Class

    Public Class WishListItem
        Public Property ID As Integer
        Public Property Name As String
        Public Property Price As Double
        Public Property PriceFormatted As String

        Private Shared NextID As Integer = 1
        Public Shared WishListArray As New List(Of WishListItem)

        Public Enum SortingType
            DefaultSort
            PriceSort
            SaldoSort
        End Enum

        Public Shared currentSorting As SortingType = SortingType.DefaultSort

        Public Sub New(name As String, price As Double, Optional id As Integer = 0)
            If id = 0 Then
                ' Jika ID tidak disediakan, gunakan nilai berikut dari NextID
                Me.ID = NextID
                NextID += 1
            Else
                ' Jika ID disediakan, gunakan nilai tersebut
                Me.ID = id

                ' Update NextID jika ID yang disediakan lebih besar
                If id >= NextID Then
                    NextID = id + 1
                End If
            End If

            Me.Name = name
            Me.Price = price
            Me.PriceFormatted = Me.Price.ToString("C0", New Globalization.CultureInfo("id-ID"))
        End Sub

        Public Shared Function GetWishList() As List(Of WishListItem)
            Return WishListArray
        End Function

        Public Shared Sub TambahWishlist(newItem As WishListItem)
            WishListArray.Add(newItem)
        End Sub

        Public Shared Sub HapusWishlist(id As Integer)
            Dim itemToRemove As WishListItem = WishListArray.Find(Function(item) item.ID = id)
            If itemToRemove IsNot Nothing Then
                WishListArray.Remove(itemToRemove)
            End If
        End Sub
    End Class


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Menampilkan halaman beranda (UC_Home) sebagai halaman default
        ShowUserControl(New UC_Home())
    End Sub

    ' Menyimpan status tombol yang dinonaktifkan
    Private ReadOnly disabledButtons As New List(Of Integer)

    ' Event handler untuk menanggapi tombol yang dinonaktifkan di UC_Home
    Public Sub ButtonDisabledHandler(disabledButton As Integer)
        ' Menambahkan tombol yang dinonaktifkan ke dalam daftar
        disabledButtons.Add(disabledButton)
    End Sub

    ' Metode untuk menghapus tombol dari daftar tombol yang dinonaktifkan
    Public Sub RemoveDisabledButton(buttonToRemove As Integer)
        disabledButtons.Remove(buttonToRemove)
    End Sub


    ' Metode untuk menampilkan MessageBox dengan daftar tombol yang dinonaktifkan
    Public Sub ShowDisabledButtonsMessage()
        Dim disabledButtonsText As String = String.Join(Environment.NewLine, disabledButtons.Select(Function(button) button))
        MessageBox.Show($"Tombol yang dinonaktifkan:{Environment.NewLine}{disabledButtonsText}", "Tombol Dinonaktifkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Properti untuk mengakses disabledButtons dari luar
    Public ReadOnly Property DisabledButtonsList As List(Of Integer)
        Get
            Return disabledButtons
        End Get
    End Property

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ' Show the default UserControl when the form loads
        ShowUserControl(New UC_Home())
    End Sub

    Private Sub btnCustomWish_Click(sender As Object, e As EventArgs) Handles btnCustomWish.Click
        ' Show the default UserControl when the form loads
        ShowUserControl(New UC_CustomWish())
    End Sub

    Private Sub btnWishList_Click(sender As Object, e As EventArgs) Handles btnWishList.Click
        ' Show the default UserControl when the form loads
        ShowUserControl(New UC_WishList())
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ' Show the default UserControl when the form loads
        ShowUserControl(New UC_Profile())
    End Sub


    Private Sub ShowUserControl(userControl As UserControl)
        ' Hapus semua kontrol di form utama kecuali tombol navigasi
        For Each control As Control In Me.Controls
            If TypeOf control IsNot Panel Then
                Me.Controls.Remove(control)
            End If
        Next

        ' Tambahkan UserControl baru ke form utama
        Me.Controls.Add(userControl)
        userControl.Dock = DockStyle.Fill
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        WishListItem.currentSorting = WishListItem.SortingType.DefaultSort
        UserManager.CurrentUser = Nothing
        WishListItem.WishListArray.Clear()
        Login.Show()
        Me.Hide()
    End Sub
End Class
