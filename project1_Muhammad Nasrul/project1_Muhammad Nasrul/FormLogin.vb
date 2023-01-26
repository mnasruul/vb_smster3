Public Class FormLogin
    Dim sql As String
    Dim proses As New koneksi
    Dim user As DataTable
    Private Sub bersih()
        tusername.Text = ""
        tpassword.Text = ""
    End Sub
    Sub Login()
        user = proses.executequery("SELECT Petugas.Kduser, Petugas.Nmuser, Petugas.Password, Petugas.status FROM Petugas where Petugas.Kduser='" & tusername.Text & "' 
        AND Petugas.Password='" & tpassword.Text & "'")
        'AND Petugas.status='" & cstatus.Text & "'")
        If user.Rows.Count = 0 Then
            MessageBox.Show("Username, Password atau status, Salah!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            MsgBox("Berhasil Login")
            koneksi.stLogin = True
            koneksi.Kduser = user.Rows(0).Item("Kduser")
            koneksi.Nmuser = user.Rows(0).Item("Nmuser")
            FormMenuUtama.Activate()
            FormMenuUtama.ShowDialog()
            Call bersih()
            Me.Close()
        End If
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Call Login()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call koneksi.CloseAllForm()
    End Sub

    Private Sub tusername_TextChanged(sender As Object, e As EventArgs) Handles tusername.TextChanged

    End Sub

    Private Sub tusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tusername.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub

    Private Sub tpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub

    Private Sub cstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cstatus.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class