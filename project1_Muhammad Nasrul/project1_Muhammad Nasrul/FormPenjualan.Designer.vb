<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalPenjualan = New System.Windows.Forms.Label()
        Me.tfaktur = New System.Windows.Forms.TextBox()
        Me.dttglbeli = New System.Windows.Forms.DateTimePicker()
        Me.dgvpenjualan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNamaUser = New System.Windows.Forms.Label()
        Me.tkodeuser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ttbayar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbayar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tkembalian = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btncetak = New System.Windows.Forms.Button()
        CType(Me.dgvpenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NO FAKTUR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TGL BELI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rp"
        '
        'lblTotalPenjualan
        '
        Me.lblTotalPenjualan.AutoSize = True
        Me.lblTotalPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPenjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPenjualan.Location = New System.Drawing.Point(463, 40)
        Me.lblTotalPenjualan.Name = "lblTotalPenjualan"
        Me.lblTotalPenjualan.Size = New System.Drawing.Size(164, 27)
        Me.lblTotalPenjualan.TabIndex = 3
        Me.lblTotalPenjualan.Text = "Total Penjualan"
        '
        'tfaktur
        '
        Me.tfaktur.Location = New System.Drawing.Point(105, 29)
        Me.tfaktur.Name = "tfaktur"
        Me.tfaktur.Size = New System.Drawing.Size(200, 20)
        Me.tfaktur.TabIndex = 4
        '
        'dttglbeli
        '
        Me.dttglbeli.Location = New System.Drawing.Point(105, 66)
        Me.dttglbeli.Name = "dttglbeli"
        Me.dttglbeli.Size = New System.Drawing.Size(200, 20)
        Me.dttglbeli.TabIndex = 5
        '
        'dgvpenjualan
        '
        Me.dgvpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpenjualan.Location = New System.Drawing.Point(12, 135)
        Me.dgvpenjualan.Name = "dgvpenjualan"
        Me.dgvpenjualan.Size = New System.Drawing.Size(695, 150)
        Me.dgvpenjualan.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dttglbeli)
        Me.GroupBox1.Controls.Add(Me.tfaktur)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblTotalPenjualan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 117)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNamaUser)
        Me.GroupBox2.Controls.Add(Me.tkodeuser)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 59)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'lblNamaUser
        '
        Me.lblNamaUser.AutoSize = True
        Me.lblNamaUser.Location = New System.Drawing.Point(264, 22)
        Me.lblNamaUser.Name = "lblNamaUser"
        Me.lblNamaUser.Size = New System.Drawing.Size(71, 13)
        Me.lblNamaUser.TabIndex = 7
        Me.lblNamaUser.Text = "NAMA USER"
        '
        'tkodeuser
        '
        Me.tkodeuser.Location = New System.Drawing.Point(99, 19)
        Me.tkodeuser.Name = "tkodeuser"
        Me.tkodeuser.Size = New System.Drawing.Size(129, 20)
        Me.tkodeuser.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "KODE USER"
        '
        'ttbayar
        '
        Me.ttbayar.Location = New System.Drawing.Point(578, 291)
        Me.ttbayar.Name = "ttbayar"
        Me.ttbayar.Size = New System.Drawing.Size(129, 20)
        Me.ttbayar.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(484, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "TOTAL BAYAR"
        '
        'tbayar
        '
        Me.tbayar.Location = New System.Drawing.Point(578, 317)
        Me.tbayar.Name = "tbayar"
        Me.tbayar.Size = New System.Drawing.Size(129, 20)
        Me.tbayar.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(484, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "BAYAR"
        '
        'tkembalian
        '
        Me.tkembalian.Location = New System.Drawing.Point(578, 343)
        Me.tkembalian.Name = "tkembalian"
        Me.tkembalian.Size = New System.Drawing.Size(129, 20)
        Me.tkembalian.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(484, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "KEMBALIAN"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btntutup)
        Me.GroupBox3.Controls.Add(Me.btnbatal)
        Me.GroupBox3.Controls.Add(Me.btncetak)
        Me.GroupBox3.Location = New System.Drawing.Point(409, 369)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 54)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'btntutup
        '
        Me.btntutup.Location = New System.Drawing.Point(198, 19)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(75, 23)
        Me.btntutup.TabIndex = 22
        Me.btntutup.Text = "TUTUP"
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(107, 19)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 21
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(6, 19)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(75, 23)
        Me.btncetak.TabIndex = 20
        Me.btncetak.Text = "CETAK"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 449)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tkembalian)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbayar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ttbayar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvpenjualan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPenjualan"
        Me.Text = "FORM PENJUALAN"
        CType(Me.dgvpenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalPenjualan As Label
    Friend WithEvents tfaktur As TextBox
    Friend WithEvents dttglbeli As DateTimePicker
    Friend WithEvents dgvpenjualan As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblNamaUser As Label
    Friend WithEvents tkodeuser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ttbayar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbayar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tkembalian As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btntutup As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btncetak As Button
End Class
