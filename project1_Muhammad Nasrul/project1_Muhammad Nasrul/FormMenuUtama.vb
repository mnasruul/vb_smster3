Public Class FormMenuUtama

    Private Sub FormLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormLoginToolStripMenuItem.Click
    End Sub

    Private Sub FormPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormPenjualanToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call checkLogin()
    End Sub
    Sub checkLogin()
        While True
            If koneksi.stLogin = False Then
                FormLogin.ShowDialog()
            Else
                Exit While
            End If
        End While
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FormDataBarang.ShowDialog()
    End Sub

    Private Sub UserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem1.Click
        FormUser.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormPenjualan.ShowDialog()
    End Sub

    Private Sub FakturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FakturToolStripMenuItem.Click
        FormDataPenjualan.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click

    End Sub
End Class