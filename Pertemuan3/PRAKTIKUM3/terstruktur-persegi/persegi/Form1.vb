Public Class Form1
    Private Function HitungLuas(sisi As Integer) As Integer
        Dim luas As Integer
        luas = sisi * sisi
        Return luas
    End Function

    Private Function HitungKeliling(sisi As Integer) As Integer
        Dim keliling As Integer
        keliling = 4 * sisi
        Return keliling
    End Function

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim sisi, luas, keliling As Integer

        sisi = Val(txtsisi.Text)

        luas = HitungLuas(sisi)
        keliling = HitungKeliling(sisi)

        txtluas.Text = Str(luas)
        txtkeliling.Text = Str(keliling)
    End Sub
End Class
