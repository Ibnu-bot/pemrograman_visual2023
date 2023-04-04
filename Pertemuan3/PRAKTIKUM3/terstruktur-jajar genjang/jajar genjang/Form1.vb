Public Class Form1
    Private Function HitungLuas(a As Integer, t As Integer) As Integer
        Dim luas As Integer
        luas = a * t
        Return luas
    End Function

    Private Function HitungKeliling(a As Integer, b As Integer) As Integer
        Dim keliling As Integer
        keliling = 2 * (a + b)
        Return keliling
    End Function

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim a, t, b, luas, keliling As Integer

        a = Val(txtalas.Text)
        t = Val(txttinggi.Text)
        b = Val(txtsisimiring.Text)

        luas = HitungLuas(a, t)
        keliling = HitungKeliling(a, b)

        txtluas.Text = Str(luas)
        txtkeliling.Text = Str(keliling)

    End Sub
End Class
