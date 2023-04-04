Public Class Form1
    Private Function HitungLuas(alas As Integer, tinggi As Integer) As Integer
        Dim luas As Integer
        luas = 0.5 * alas * tinggi
        Return luas
    End Function

    Private Function HitungKeliling(sisi1 As Integer, sisi2 As Integer, sisi3 As Integer) As Integer
        Dim keliling As Integer
        keliling = sisi1 + sisi2 + sisi3
        Return keliling
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim alas, tinggi, sisi1, sisi2, sisi3, luas, keliling As Integer

        alas = Val(txtalas.Text)
        tinggi = Val(txttinggi.Text)
        sisi1 = Val(txtsisi1.Text)
        sisi2 = Val(txtsisi2.Text)
        sisi3 = Val(txtsisi3.Text)

        luas = HitungLuas(alas, tinggi)
        keliling = HitungKeliling(sisi1, sisi2, sisi3)

        txtluas.Text = Str(luas)
        txtkeliling.Text = Str(keliling)

    End Sub
End Class
