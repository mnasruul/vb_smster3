Public Class FormPenjualan
    Dim sql As String
    Dim proses As New koneksi
    Dim penjualan As DataTable
    Sub data_record()
        penjualan = proses.executequery("select * from barang order by kdbrg asc")
        'dgvpenjualan.DataSource = penjualan
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
    Sub bersih()
        tfaktur.Text = ""
        dttglbeli.Value = Now
        ttbayar.Text = ""
        tbayar.Text = ""
        tkembalian.Text = ""
        Call data_record()
        Call kode_otomatis()
    End Sub

    Sub kode_otomatis()
        penjualan = proses.executequery("select * from faktur order by nofaktur desc")
        If penjualan.Rows.Count = 0 Then
            tfaktur.Text = "0001" + Format(Now, "yyMMdd")
        Else
            With penjualan.Rows(0)
                tfaktur.Text = .Item("nofaktur")
            End With
            tfaktur.Text = Val(Microsoft.VisualBasic.Left(tfaktur.Text, 4)) + 1
            If Len(tfaktur.Text) = 1 Then
                tfaktur.Text = "0000" & tfaktur.Text & "" + Format(Now, "yyMMdd")
            ElseIf Len(tfaktur.Text) = 2 Then
                tfaktur.Text = "000" & tfaktur.Text & "" + Format(Now, "yyMMdd")
            ElseIf Len(tfaktur.Text) = 3 Then
                tfaktur.Text = "00" & tfaktur.Text & "" + Format(Now, "yyMMdd")
            ElseIf Len(tfaktur.Text) = 4 Then
                tfaktur.Text = "0" & tfaktur.Text & "" + Format(Now, "yyMMdd")
            End If
        End If
    End Sub

    Sub TotalHarga()
        Dim HitungHarga As Integer = 0
        For i As Integer = 0 To dgvpenjualan.Rows.Count - 1
            HitungHarga = HitungHarga + Val(dgvpenjualan.Rows(i).Cells(6).Value)
            ttbayar.Text = HitungHarga
        Next
    End Sub

    Sub Gridjual()
        dgvpenjualan.Columns.Add("kdbrg", "Kode Barang")
        dgvpenjualan.Columns.Add("Nmbrg", "Nama Barang")
        dgvpenjualan.Columns.Add("Jumlah barang", "Jumlah Barang")
        dgvpenjualan.Columns.Add("hjual", "Harga Barang")
        dgvpenjualan.Columns.Add("jmlbeli", "Jumlah Beli")
        dgvpenjualan.Columns.Add("stok", "Sisa Stok")
        dgvpenjualan.Columns.Add("subtotal", "Sub Total")
    End Sub
    Sub AturKolomjual()
        dgvpenjualan.Columns(0).Width = 75
        dgvpenjualan.Columns(1).Width = 100
        dgvpenjualan.Columns(2).Width = 75
        dgvpenjualan.Columns(3).Width = 75
        dgvpenjualan.Columns(4).Width = 75
        dgvpenjualan.Columns(5).Width = 75
        dgvpenjualan.Columns(6).Width = 75

        dgvpenjualan.Columns(1).ReadOnly = True
        dgvpenjualan.Columns(2).ReadOnly = True

    End Sub

    Private Sub dgvpenjualan_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpenjualan.CellEndEdit
        penjualan = proses.executequery("select * from barang where barang.Kdbrg = '" & dgvpenjualan.Rows(e.RowIndex).Cells(0).Value & "'")
        If penjualan.Rows.Count = 0 Then
            MessageBox.Show("Data Tidak Ada..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            With penjualan.Rows(0)
                dgvpenjualan.Rows(e.RowIndex).Cells(1).Value = .Item("Nmbrg")
                dgvpenjualan.Rows(e.RowIndex).Cells(2).Value = .Item("jumlah")
                dgvpenjualan.Rows(e.RowIndex).Cells(3).Value = .Item("hjual")
            End With
        End If

        dgvpenjualan.Rows(e.RowIndex).Cells(5).Value = dgvpenjualan.Rows(e.RowIndex).Cells(2).Value - dgvpenjualan.Rows(e.RowIndex).Cells(4).Value

        dgvpenjualan.Rows(e.RowIndex).Cells(6).Value = dgvpenjualan.Rows(e.RowIndex).Cells(3).Value - dgvpenjualan.Rows(e.RowIndex).Cells(4).Value

        If e.ColumnIndex = 4 Then
            With penjualan.Rows(0)
                If dgvpenjualan.Rows(e.RowIndex).Cells(4).Value >= .Item("jumlah") Then
                    MsgBox("Stok barang hanya ada" & .Item("jumlah") & "")
                    dgvpenjualan.Rows(e.RowIndex).Cells(4).Value = 1
                    dgvpenjualan.Rows(e.RowIndex).Cells(6).Value = dgvpenjualan.Rows(e.RowIndex).Cells(3).Value * dgvpenjualan.Rows(e.RowIndex).Cells(4).Value
                    Call TotalHarga()
                Else
                    dgvpenjualan.Rows(e.RowIndex).Cells(6).Value = dgvpenjualan.Rows(e.RowIndex).Cells(3).Value * dgvpenjualan.Rows(e.RowIndex).Cells(4).Value
                    Call TotalHarga()
                End If
            End With
        End If

        dgvpenjualan.CurrentCell = dgvpenjualan.Rows(1).Cells(0)
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tkodeuser.Text = koneksi.Kduser
        'lblNamaUser.Text = koneksi.Nmuser
        Call kode_otomatis()
        Call Gridjual()
        Call data_record()

        Call TotalHarga()
    End Sub

    Private Sub tkodeuser_TextChanged(sender As Object, e As EventArgs) Handles tkodeuser.TextChanged

    End Sub

    Private Sub tkodeuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tkodeuser.KeyPress
        If e.KeyChar = Chr(13) Then
            penjualan = proses.executequery("select * from Petugas where Kduser='" & tkodeuser.Text & "'")
            If penjualan.Rows.Count = 0 Then
                MessageBox.Show("Data Tidak Ada Dalam Database, Silahkan Inputkan Data..!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                With penjualan.Rows(0)
                    lblNamaUser.Text = .Item("Nmuser")
                End With
            End If
        End If
    End Sub

    Private Sub dgvpenjualan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpenjualan.CellContentClick

    End Sub

    Private Sub dgvpenjualan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvpenjualan.KeyPress
        If e.KeyChar = Chr(27) Then
            dgvpenjualan.Rows.RemoveAt(dgvpenjualan.CurrentCell.RowIndex)

            Call TotalHarga()
            tbayar.Clear()
            tkembalian.Text = ""
        End If
    End Sub

    Private Sub tbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            tkembalian.Text = Val(ttbayar.Text) - Val(tbayar.Text)
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Me.Close()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call bersih()
    End Sub

    Private Sub ttbayar_TextChanged(sender As Object, e As EventArgs) Handles ttbayar.TextChanged
        lblTotalPenjualan.Text = Val(ttbayar.Text)
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        If tfaktur.Text = "" Or ttbayar.Text = "" Or tbayar.Text = "" Or tkembalian.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            penjualan = proses.executequery("select * from faktur where nofaktur='" & tfaktur.Text & "'")
            If penjualan.Rows.Count = 0 Then
                sql = "Insert into faktur values ('" & tfaktur.Text & "','" & dttglbeli.Value & "','" & ttbayar.Text & "','" & lblNamaUser.Text & "')"
                proses.executenonquery (sql)
                MessageBox.Show("data telah disimpan..!!", "penyimpanan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        For baris As Integer = 0 To dgvpenjualan.Rows.Count - 2
            'simpan ke tabel detail
            sql = "Insert into detailfaktur values ('" & tfaktur.Text & "','" & dgvpenjualan.Rows(baris).Cells(0).Value & "','" & dgvpenjualan.Rows(baris).Cells(1).Value & "','" & dgvpenjualan.Rows(baris).Cells(3).Value & "','" & dgvpenjualan.Rows(baris).Cells(4).Value & "','" & dgvpenjualan.Rows(baris).Cells(6).Value & "')"
            proses.executenonquery(sql)
            'kurangi stok barang

            sql = "update barang set jumlah= " & dgvpenjualan.Rows(baris).Cells(5).Value & " where kdbrg='" & dgvpenjualan.Rows(baris).Cells(0).Value & "'"
            proses.executenonquery(sql)
        Next baris
        laporan.Show()
        laporan.CrystalReportViewer1.ReportSource = Nothing
        laporan.CrystalReportViewer1.RefreshReport()
        laporan.CrystalReportViewer1.SelectionFormula = "{faktur.Nofaktur}='" & tfaktur.Text & "'"
        laporan.CrystalReportViewer1.ReportSource = "D:\KULIAH\SEMESTER 3\VB\PERTEMUAN\project1_Muhammad Nasrul\project1_Muhammad Nasrul\LaporanPenjualan.rpt"
        laporan.WindowState = FormWindowState.Maximized
        dgvpenjualan.Columns.Clear()
        dgvpenjualan.Columns.Clear()
        Call Gridjual()
        ttbayar.Text = 0
        tbayar.Text = 0
        tkembalian.Text = 0
        Call data_record()
        Call kode_otomatis()
    End Sub
End Class