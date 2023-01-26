<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cstatus = New System.Windows.Forms.ComboBox()
        Me.tpassword = New System.Windows.Forms.TextBox()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.tkuser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BersihBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cstatus)
        Me.GroupBox1.Controls.Add(Me.tpassword)
        Me.GroupBox1.Controls.Add(Me.tnama)
        Me.GroupBox1.Controls.Add(Me.tkuser)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cstatus
        '
        Me.cstatus.FormattingEnabled = True
        Me.cstatus.Items.AddRange(New Object() {"Admin", "User"})
        Me.cstatus.Location = New System.Drawing.Point(184, 127)
        Me.cstatus.Name = "cstatus"
        Me.cstatus.Size = New System.Drawing.Size(276, 21)
        Me.cstatus.TabIndex = 7
        '
        'tpassword
        '
        Me.tpassword.Location = New System.Drawing.Point(184, 93)
        Me.tpassword.Name = "tpassword"
        Me.tpassword.Size = New System.Drawing.Size(276, 20)
        Me.tpassword.TabIndex = 6
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(184, 62)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(276, 20)
        Me.tnama.TabIndex = 5
        '
        'tkuser
        '
        Me.tkuser.Location = New System.Drawing.Point(184, 24)
        Me.tkuser.Name = "tkuser"
        Me.tkuser.Size = New System.Drawing.Size(276, 20)
        Me.tkuser.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "STATUS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE USER"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TutupBtn)
        Me.GroupBox2.Controls.Add(Me.BersihBtn)
        Me.GroupBox2.Controls.Add(Me.HapusBtn)
        Me.GroupBox2.Controls.Add(Me.UbahBtn)
        Me.GroupBox2.Controls.Add(Me.SimpanBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 54)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'TutupBtn
        '
        Me.TutupBtn.Location = New System.Drawing.Point(424, 19)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(75, 23)
        Me.TutupBtn.TabIndex = 21
        Me.TutupBtn.Text = "TUTUP"
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'BersihBtn
        '
        Me.BersihBtn.Location = New System.Drawing.Point(316, 19)
        Me.BersihBtn.Name = "BersihBtn"
        Me.BersihBtn.Size = New System.Drawing.Size(75, 23)
        Me.BersihBtn.TabIndex = 20
        Me.BersihBtn.Text = "BERSIH"
        Me.BersihBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(214, 19)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.HapusBtn.TabIndex = 19
        Me.HapusBtn.Text = "HAPUS"
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'UbahBtn
        '
        Me.UbahBtn.Location = New System.Drawing.Point(106, 19)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(75, 23)
        Me.UbahBtn.TabIndex = 18
        Me.UbahBtn.Text = "UBAH"
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Location = New System.Drawing.Point(6, 19)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(75, 23)
        Me.SimpanBtn.TabIndex = 17
        Me.SimpanBtn.Text = "SIMPAN"
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 261)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormUser"
        Me.Text = "FORM USER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cstatus As ComboBox
    Friend WithEvents tpassword As TextBox
    Friend WithEvents tnama As TextBox
    Friend WithEvents tkuser As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TutupBtn As Button
    Friend WithEvents BersihBtn As Button
    Friend WithEvents HapusBtn As Button
    Friend WithEvents UbahBtn As Button
    Friend WithEvents SimpanBtn As Button
End Class
