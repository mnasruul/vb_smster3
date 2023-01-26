<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataPenjualan
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvfaktur = New System.Windows.Forms.DataGridView()
        Me.KlikKanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvfaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KlikKanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvfaktur
        '
        Me.dgvfaktur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfaktur.Location = New System.Drawing.Point(12, 12)
        Me.dgvfaktur.Name = "dgvfaktur"
        Me.dgvfaktur.Size = New System.Drawing.Size(727, 237)
        Me.dgvfaktur.TabIndex = 23
        '
        'KlikKanan
        '
        Me.KlikKanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.KlikKanan.Name = "KlikKanan"
        Me.KlikKanan.Size = New System.Drawing.Size(153, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Print"
        '
        'FormDataPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 261)
        Me.Controls.Add(Me.dgvfaktur)
        Me.Name = "FormDataPenjualan"
        Me.Text = "FormDataPenjualan"
        CType(Me.dgvfaktur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KlikKanan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvfaktur As DataGridView
    Friend WithEvents KlikKanan As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
