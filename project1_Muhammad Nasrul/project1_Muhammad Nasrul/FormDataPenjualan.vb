Public Class FormDataPenjualan
    Dim sql As String
    Dim proses As New koneksi
    Dim penjualan As DataTable
    Sub data_record()
        penjualan = proses.executequery("select * from barang order by kdbrg asc")
        dgvfaktur.DataSource = penjualan
        'For i As Integer = 0 To penjualan.Rows.Count - 1
        '    dgvpenjualan.Rows.Add(
        '        penjualan.Rows(i).Item("Kdbrg"),
        '        penjualan.Rows(i).Item("Nmbrg"),
        '        penjualan.Rows(i).Item("jumlah"),
        '        penjualan.Rows(i).Item("hjual"),
        '        0,
        '        penjualan.Rows(i).Item("jumlah"),
        '        0)
        'Next    
    End Sub
    Private Sub FormDataPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call data_record()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If dgvfaktur.RowCount = 0 Then MsgBox("Data belum ada!", MsgBoxStyle.Exclamation, "Pesan") : Exit Sub
        laporan.Show()
        laporan.CrystalReportViewer1.ReportSource = Nothing
        laporan.CrystalReportViewer1.RefreshReport()
        laporan.CrystalReportViewer1.SelectionFormula = "{faktur.Nofaktur}='" & dgvfaktur.Rows(dgvfaktur.CurrentRow.Index).Cells(1).Value & "'"
        laporan.CrystalReportViewer1.ReportSource = "D:\KULIAH\SEMESTER 3\VB\PERTEMUAN\project1_Muhammad Nasrul\project1_Muhammad Nasrul\LaporanPenjualan.rpt"
        laporan.WindowState = FormWindowState.Maximized

    End Sub
End Class