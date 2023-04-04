Public Class Form1
    Private Function HitungLuas(jari As Integer) As Integer
        Dim luas As Integer
        luas = 22 / 7 * (jari * jari)
        Return luas
    End Function

    Private Function HitungKeliling(jari As Integer) As Integer
        Dim keliling As Integer
        keliling = 2 * 22 / 7 * jari
        Return keliling
    End Function

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim jari, luas, keliling As Integer

        jari = Val(txtjari.Text)

        luas = HitungLuas(jari)
        keliling = HitungKeliling(jari)

        txtluas.Text = Str(luas)
        txtkeliling.Text = Str(keliling)

    End Sub
End Class
