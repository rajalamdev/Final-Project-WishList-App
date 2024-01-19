<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        Panel2 = New Panel()
        btnProfile = New Guna.UI2.WinForms.Guna2Button()
        btnWishList = New Guna.UI2.WinForms.Guna2Button()
        btnCustomWish = New Guna.UI2.WinForms.Guna2Button()
        btnHome = New Guna.UI2.WinForms.Guna2Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(101), CByte(84), CByte(175))
        Panel1.Controls.Add(Guna2Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(909, 60)
        Panel1.TabIndex = 2
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 8
        Guna2Button1.CustomizableEdges = CustomizableEdges11
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Firebrick
        Guna2Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(782, 12)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Button1.Size = New Size(102, 35)
        Guna2Button1.TabIndex = 4
        Guna2Button1.Text = "LOGOUT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(19, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 21)
        Label1.TabIndex = 2
        Label1.Text = "WISHLIST APP"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(btnProfile)
        Panel2.Controls.Add(btnWishList)
        Panel2.Controls.Add(btnCustomWish)
        Panel2.Controls.Add(btnHome)
        Panel2.Location = New Point(0, 59)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(909, 40)
        Panel2.TabIndex = 3
        ' 
        ' btnProfile
        ' 
        btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnProfile.CheckedState.CustomBorderColor = Color.FromArgb(CByte(101), CByte(84), CByte(175))
        btnProfile.CheckedState.FillColor = Color.Transparent
        btnProfile.CheckedState.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnProfile.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btnProfile.CustomizableEdges = CustomizableEdges13
        btnProfile.DisabledState.BorderColor = Color.DarkGray
        btnProfile.DisabledState.CustomBorderColor = Color.DarkGray
        btnProfile.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnProfile.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnProfile.FillColor = Color.Transparent
        btnProfile.Font = New Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnProfile.ForeColor = Color.Black
        btnProfile.Location = New Point(423, 0)
        btnProfile.Name = "btnProfile"
        btnProfile.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnProfile.Size = New Size(141, 40)
        btnProfile.TabIndex = 3
        btnProfile.Text = "Profile"
        ' 
        ' btnWishList
        ' 
        btnWishList.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnWishList.CheckedState.CustomBorderColor = Color.FromArgb(CByte(101), CByte(84), CByte(175))
        btnWishList.CheckedState.FillColor = Color.Transparent
        btnWishList.CheckedState.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnWishList.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btnWishList.CustomizableEdges = CustomizableEdges15
        btnWishList.DisabledState.BorderColor = Color.DarkGray
        btnWishList.DisabledState.CustomBorderColor = Color.DarkGray
        btnWishList.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnWishList.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnWishList.FillColor = Color.Transparent
        btnWishList.Font = New Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnWishList.ForeColor = Color.Black
        btnWishList.Location = New Point(282, 0)
        btnWishList.Name = "btnWishList"
        btnWishList.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btnWishList.Size = New Size(141, 40)
        btnWishList.TabIndex = 2
        btnWishList.Text = "WishList"
        ' 
        ' btnCustomWish
        ' 
        btnCustomWish.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnCustomWish.CheckedState.CustomBorderColor = Color.FromArgb(CByte(101), CByte(84), CByte(175))
        btnCustomWish.CheckedState.FillColor = Color.Transparent
        btnCustomWish.CheckedState.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnCustomWish.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btnCustomWish.CustomizableEdges = CustomizableEdges17
        btnCustomWish.DisabledState.BorderColor = Color.DarkGray
        btnCustomWish.DisabledState.CustomBorderColor = Color.DarkGray
        btnCustomWish.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCustomWish.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCustomWish.FillColor = Color.Transparent
        btnCustomWish.Font = New Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnCustomWish.ForeColor = Color.Black
        btnCustomWish.Location = New Point(141, 0)
        btnCustomWish.Name = "btnCustomWish"
        btnCustomWish.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnCustomWish.Size = New Size(141, 40)
        btnCustomWish.TabIndex = 1
        btnCustomWish.Text = "Custom"
        ' 
        ' btnHome
        ' 
        btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnHome.Checked = True
        btnHome.CheckedState.CustomBorderColor = Color.FromArgb(CByte(101), CByte(84), CByte(175))
        btnHome.CheckedState.FillColor = Color.Transparent
        btnHome.CheckedState.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnHome.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btnHome.CustomizableEdges = CustomizableEdges19
        btnHome.DisabledState.BorderColor = Color.DarkGray
        btnHome.DisabledState.CustomBorderColor = Color.DarkGray
        btnHome.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnHome.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnHome.FillColor = Color.Transparent
        btnHome.Font = New Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnHome.ForeColor = Color.Black
        btnHome.Location = New Point(0, 0)
        btnHome.Name = "btnHome"
        btnHome.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        btnHome.Size = New Size(141, 40)
        btnHome.TabIndex = 0
        btnHome.Text = "Home"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(244), CByte(236))
        ClientSize = New Size(909, 494)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnWishList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCustomWish As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
