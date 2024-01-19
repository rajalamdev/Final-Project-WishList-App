<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Profile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Label1 = New Label()
        Label2 = New Label()
        username = New Label()
        dompet = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(89, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 21)
        Label1.TabIndex = 2
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(89, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 21)
        Label2.TabIndex = 3
        Label2.Text = "Saldo:"
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        username.Location = New Point(182, 165)
        username.Name = "username"
        username.Size = New Size(31, 21)
        username.TabIndex = 4
        username.Text = "???"
        ' 
        ' dompet
        ' 
        dompet.AutoSize = True
        dompet.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dompet.Location = New Point(182, 210)
        dompet.Name = "dompet"
        dompet.Size = New Size(31, 21)
        dompet.TabIndex = 5
        dompet.Text = "???"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Location = New Point(89, 271)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 23)
        Button1.TabIndex = 6
        Button1.Text = "Isi Saldo"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' UC_Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button1)
        Controls.Add(dompet)
        Controls.Add(username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "UC_Profile"
        Size = New Size(879, 487)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username As Label
    Friend WithEvents dompet As Label
    Friend WithEvents Button1 As Button
End Class
