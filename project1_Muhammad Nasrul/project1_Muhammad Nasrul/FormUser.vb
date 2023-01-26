Public Class FormUser
    Dim sql As String
    Dim proses As New koneksi
    Dim user As DataTable
    Sub bersih()
        tkuser.Text = ""
        tnama.Text = ""
        tpassword.Text = ""
        cstatus.Text = ""
    End Sub
    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        If tkuser.Text = "" Or tnama.Text = "" Or tpassword.Text = "" Or cstatus.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            user = proses.executequery("select * from Petugas where Kduser='" & tkuser.Text & "'")
            If user.Rows.Count = 0 Then
                sql = "insert into Petugas values ('" & tkuser.Text & "','" & tnama.Text & "','" & tpassword.Text & "','" & cstatus.Text & "')"
                proses.executenonquery(sql)
                MessageBox.Show("data telah disimpan..!!", "penyimpanan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call bersih()
            Else
                MsgBox("data sudah ada")
            End If
        End If
    End Sub

    Private Sub UbahBtn_Click(sender As Object, e As EventArgs) Handles UbahBtn.Click
        If MsgBox("Apakah Anda Yakin Ingin Mengedit Data user??", MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            sql = "UPDATE Petugas SET Petugas.Nmuser = '" & tnama.Text & "', Petugas.Password = '" & tpassword.Text & "', Petugas.status='" & cstatus.Text & "' where  Petugas.Kduser='" & tkuser.Text & "'"
            proses.executenonquery(sql)
            MessageBox.Show("Data telah Diedit..!!", "Pengeditan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Silahkan Pilih Data lain..!!", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        Call bersih()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        If MsgBox("apakah anda yakin mau menghapus data?", MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            sql = "delete from Petugas where  Kduser='" & tkuser.Text & "'"
            proses.executenonquery(sql)
            MessageBox.Show("data telah dihapus..!!", "penghapusan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Silahkan HAPUS data yang lain..!!", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Call bersih()
    End Sub

    Private Sub tkuser_TextChanged(sender As Object, e As EventArgs) Handles tkuser.TextChanged

    End Sub

    Private Sub tkuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tkuser.KeyPress
        If e.KeyChar = Chr(13) Then
            user = proses.executequery("select * from Petugas where Kduser='" & tkuser.Text & "'")
            If user.Rows.Count = 0 Then
                MessageBox.Show("Data Tidak Ada Dalam Database, Silahkan Inputkan Data..!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                With user.Rows(0)
                    tkuser.Text = .Item("Kduser")
                    tnama.Text = .Item("Nmuser")
                    tpassword.Text = .Item("Password")
                    cstatus.Text = .Item("status")
                End With
            End If
        End If
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BersihBtn_Click(sender As Object, e As EventArgs) Handles BersihBtn.Click
        Call bersih()
    End Sub

    Private Sub TutupBtn_Click(sender As Object, e As EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub
End Class