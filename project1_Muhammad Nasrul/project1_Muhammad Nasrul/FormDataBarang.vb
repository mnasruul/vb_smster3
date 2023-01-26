Public Class FormDataBarang
    Dim sql As String
    Dim proses As New koneksi
    Dim barang As DataTable
    Sub data_record()
        barang = proses.executequery("select * from barang order by kdbrg asc")
        dgvbarang.DataSource = barang
    End Sub
    Sub bersih()
        tkode.Text = ""
        tnama.Text = ""
        cjenis.Text = ""
        csatuan.Text = ""
        th_beli.Text = ""
        th_jual.Text = ""
        tjumlah.Text = ""

        tkode.Focus()

        Call data_record()
    End Sub
    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        If tkode.Text = "" Or tnama.Text = "" Or cjenis.Text = "" Or csatuan.Text = "" Or th_beli.Text = "" Or th_jual.Text = "" Or tjumlah.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            barang = proses.executequery("select * from barang where kdbrg='" & tkode.Text & "'")
            If barang.Rows.Count = 0 Then
                sql = "insert into barang values ('" & tkode.Text & "','" & tnama.Text & "','" & cjenis.Text & "','" & csatuan.Text & "','" & th_beli.Text & "','" & th_jual.Text & "','" & tjumlah.Text & "')"
                proses.executenonquery(sql)
                MessageBox.Show("data telah disimpan..!!", "penyimpanan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("data sudah ada")
            End If
        End If
        Call bersih()
    End Sub

    Private Sub UbahBtn_Click(sender As Object, e As EventArgs) Handles UbahBtn.Click
        If MsgBox("Apakah Anda Yakin Ingin Mengedit Data barang??", MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            sql = "update barang set nmbrg='" & tnama.Text & "' ,jnsbrg='" & cjenis.Text & "' ,satuan='" & csatuan.Text & "' ,hbeli='" & th_beli.Text & "' ,hjual='" & th_jual.Text & "' ,jumlah='" & tjumlah.Text & "' where  kdbrg='" & tkode.Text & "'"
            proses.executenonquery(sql)
            MessageBox.Show("Data telah Diedit..!!", "Pengeditan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Silahkan Pilih Data lain..!!", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        Call bersih()
    End Sub



    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        If MsgBox("apakah anda yakin mau menghapus data?", MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            sql = "delete from barang where  kdbrg='" & tkode.Text & "'"
            proses.executenonquery(sql)
            MessageBox.Show("data telah dihapus..!!", "penghapusan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Silahkan HAPUS data yang lain..!!", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Call bersih()
    End Sub

    Private Sub BersihBtn_Click(sender As Object, e As EventArgs) Handles BersihBtn.Click
        Call bersih()
    End Sub
    Private Sub TutupBtn_Click(sender As Object, e As EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub


    Private Sub tkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tkode.KeyPress
        If e.KeyChar = Chr(13) Then
            barang = proses.executequery("select * from barang where kdbrg='" & tkode.Text & "'")
            If barang.Rows.Count = 0 Then
                MessageBox.Show("Data Tidak Ada Dalam Database, Silahkan Inputkan Data..!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                With barang.Rows(0)
                    tnama.Text = .Item("nmbrg")
                    cjenis.Text = .Item("jnsbrg")
                    csatuan.Text = .Item("satuan")
                    th_beli.Text = .Item("hbeli")
                    th_jual.Text = .Item("hjual")
                    tjumlah.Text = .Item("jumlah")
                End With
            End If
        End If
    End Sub


    Private Sub dgvbarang_DoubleClick(sender As Object, e As EventArgs) Handles dgvbarang.DoubleClick
        Try
            tkode.Text = dgvbarang.SelectedCells(0).Value
            tnama.Text = dgvbarang.SelectedCells(1).Value
            cjenis.Text = dgvbarang.SelectedCells(2).Value
            csatuan.Text = dgvbarang.SelectedCells(3).Value
            th_beli.Text = dgvbarang.SelectedCells(4).Value
            th_jual.Text = dgvbarang.SelectedCells(5).Value
            tjumlah.Text = dgvbarang.SelectedCells(6).Value
        Catch ex As Exception
            MsgBox(e.ToString)
        End Try
    End Sub

    Private Sub FormDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call data_record()
    End Sub

End Class