<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FakturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.FormBarangToolStripMenuItem, Me.FormLoginToolStripMenuItem, Me.FormPenjualanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangToolStripMenuItem, Me.UserToolStripMenuItem1})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.UserToolStripMenuItem.Text = "Input"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'UserToolStripMenuItem1
        '
        Me.UserToolStripMenuItem1.Name = "UserToolStripMenuItem1"
        Me.UserToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.UserToolStripMenuItem1.Text = "User"
        '
        'FormBarangToolStripMenuItem
        '
        Me.FormBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem})
        Me.FormBarangToolStripMenuItem.Name = "FormBarangToolStripMenuItem"
        Me.FormBarangToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FormBarangToolStripMenuItem.Text = "Proses"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'FormLoginToolStripMenuItem
        '
        Me.FormLoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FakturToolStripMenuItem, Me.PenjualanToolStripMenuItem1})
        Me.FormLoginToolStripMenuItem.Name = "FormLoginToolStripMenuItem"
        Me.FormLoginToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.FormLoginToolStripMenuItem.Text = "Laporan"
        '
        'FakturToolStripMenuItem
        '
        Me.FakturToolStripMenuItem.Name = "FakturToolStripMenuItem"
        Me.FakturToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FakturToolStripMenuItem.Text = "Faktur"
        '
        'PenjualanToolStripMenuItem1
        '
        Me.PenjualanToolStripMenuItem1.Name = "PenjualanToolStripMenuItem1"
        Me.PenjualanToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PenjualanToolStripMenuItem1.Text = "Penjualan"
        '
        'FormPenjualanToolStripMenuItem
        '
        Me.FormPenjualanToolStripMenuItem.Name = "FormPenjualanToolStripMenuItem"
        Me.FormPenjualanToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.FormPenjualanToolStripMenuItem.Text = "Log out"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.Text = "FormMenuUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FakturToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem1 As ToolStripMenuItem
End Class
