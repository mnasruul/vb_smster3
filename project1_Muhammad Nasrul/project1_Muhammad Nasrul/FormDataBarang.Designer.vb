<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataBarang
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tkode = New System.Windows.Forms.TextBox()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.th_beli = New System.Windows.Forms.TextBox()
        Me.th_jual = New System.Windows.Forms.TextBox()
        Me.tjumlah = New System.Windows.Forms.TextBox()
        Me.cjenis = New System.Windows.Forms.ComboBox()
        Me.csatuan = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BersihBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE BARANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA BARANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JENIS BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SATUAN BARANG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "HARGA BELI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "HARGA JUAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "JUMLAH BARANG"
        '
        'tkode
        '
        Me.tkode.Location = New System.Drawing.Point(199, 19)
        Me.tkode.Name = "tkode"
        Me.tkode.Size = New System.Drawing.Size(192, 20)
        Me.tkode.TabIndex = 1
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(199, 48)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(192, 20)
        Me.tnama.TabIndex = 2
        '
        'th_beli
        '
        Me.th_beli.Location = New System.Drawing.Point(199, 156)
        Me.th_beli.Name = "th_beli"
        Me.th_beli.Size = New System.Drawing.Size(192, 20)
        Me.th_beli.TabIndex = 5
        '
        'th_jual
        '
        Me.th_jual.Location = New System.Drawing.Point(199, 190)
        Me.th_jual.Name = "th_jual"
        Me.th_jual.Size = New System.Drawing.Size(192, 20)
        Me.th_jual.TabIndex = 6
        '
        'tjumlah
        '
        Me.tjumlah.Location = New System.Drawing.Point(199, 224)
        Me.tjumlah.Name = "tjumlah"
        Me.tjumlah.Size = New System.Drawing.Size(192, 20)
        Me.tjumlah.TabIndex = 7
        '
        'cjenis
        '
        Me.cjenis.FormattingEnabled = True
        Me.cjenis.Location = New System.Drawing.Point(199, 84)
        Me.cjenis.Name = "cjenis"
        Me.cjenis.Size = New System.Drawing.Size(192, 21)
        Me.cjenis.TabIndex = 3
        '
        'csatuan
        '
        Me.csatuan.FormattingEnabled = True
        Me.csatuan.Location = New System.Drawing.Point(199, 119)
        Me.csatuan.Name = "csatuan"
        Me.csatuan.Size = New System.Drawing.Size(192, 21)
        Me.csatuan.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cjenis)
        Me.GroupBox1.Controls.Add(Me.csatuan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tjumlah)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.th_jual)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.th_beli)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tnama)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tkode)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 265)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Location = New System.Drawing.Point(6, 19)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(75, 23)
        Me.SimpanBtn.TabIndex = 8
        Me.SimpanBtn.Text = "SIMPAN"
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TutupBtn)
        Me.GroupBox2.Controls.Add(Me.BersihBtn)
        Me.GroupBox2.Controls.Add(Me.HapusBtn)
        Me.GroupBox2.Controls.Add(Me.UbahBtn)
        Me.GroupBox2.Controls.Add(Me.SimpanBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 54)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'TutupBtn
        '
        Me.TutupBtn.Location = New System.Drawing.Point(424, 19)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(75, 23)
        Me.TutupBtn.TabIndex = 14
        Me.TutupBtn.Text = "TUTUP"
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'BersihBtn
        '
        Me.BersihBtn.Location = New System.Drawing.Point(316, 19)
        Me.BersihBtn.Name = "BersihBtn"
        Me.BersihBtn.Size = New System.Drawing.Size(75, 23)
        Me.BersihBtn.TabIndex = 12
        Me.BersihBtn.Text = "BERSIH"
        Me.BersihBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(214, 19)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.HapusBtn.TabIndex = 10
        Me.HapusBtn.Text = "HAPUS"
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'UbahBtn
        '
        Me.UbahBtn.Location = New System.Drawing.Point(106, 19)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(75, 23)
        Me.UbahBtn.TabIndex = 9
        Me.UbahBtn.Text = "UBAH"
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'dgvbarang
        '
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(12, 343)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.Size = New System.Drawing.Size(516, 162)
        Me.dgvbarang.TabIndex = 22
        '
        'FormDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 518)
        Me.Controls.Add(Me.dgvbarang)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormDataBarang"
        Me.Text = "FORM DATA BARANG"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tkode As TextBox
    Friend WithEvents tnama As TextBox
    Friend WithEvents th_beli As TextBox
    Friend WithEvents th_jual As TextBox
    Friend WithEvents tjumlah As TextBox
    Friend WithEvents cjenis As ComboBox
    Friend WithEvents csatuan As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SimpanBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TutupBtn As Button
    Friend WithEvents BersihBtn As Button
    Friend WithEvents HapusBtn As Button
    Friend WithEvents UbahBtn As Button
    Friend WithEvents dgvbarang As DataGridView
End Class
