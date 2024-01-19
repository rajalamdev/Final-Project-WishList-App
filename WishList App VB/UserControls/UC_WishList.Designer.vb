<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_WishList
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        SortByPriceBtn = New Button()
        SortBySaldoButton = New Button()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.ForeColor = Color.White
        FlowLayoutPanel1.Location = New Point(21, 168)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(829, 295)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' SortByPriceBtn
        ' 
        SortByPriceBtn.BackColor = Color.White
        SortByPriceBtn.ForeColor = Color.Black
        SortByPriceBtn.Location = New Point(21, 130)
        SortByPriceBtn.Name = "SortByPriceBtn"
        SortByPriceBtn.Size = New Size(128, 32)
        SortByPriceBtn.TabIndex = 5
        SortByPriceBtn.Tag = "2"
        SortByPriceBtn.Text = "Sort By Price"
        SortByPriceBtn.UseVisualStyleBackColor = False
        ' 
        ' SortBySaldoButton
        ' 
        SortBySaldoButton.BackColor = Color.White
        SortBySaldoButton.ForeColor = Color.Black
        SortBySaldoButton.Location = New Point(155, 130)
        SortBySaldoButton.Name = "SortBySaldoButton"
        SortBySaldoButton.Size = New Size(120, 32)
        SortBySaldoButton.TabIndex = 6
        SortBySaldoButton.Tag = "2"
        SortBySaldoButton.Text = "Sort By Saldo"
        SortBySaldoButton.UseVisualStyleBackColor = False
        ' 
        ' UC_WishList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(SortBySaldoButton)
        Controls.Add(SortByPriceBtn)
        Controls.Add(FlowLayoutPanel1)
        Name = "UC_WishList"
        Size = New Size(879, 487)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SortByPriceBtn As Button
    Friend WithEvents SortBySaldoButton As Button
End Class
