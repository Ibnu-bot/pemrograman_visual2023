Public Class Form1
    Private Function HitungLuas(d1 As Integer, d2 As Integer) As Integer
        Dim luas As Integer
        luas = 0.5 * (d1 * d2)
        Return luas
    End Function

    Private Function HitungKeliling(sipan As Integer, sipen As Integer) As Integer
        Dim keliling As Integer
        keliling = 2 * (sipan * sipen)
        Return keliling
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d1, d2, sipan, sipen, luas, keliling As Integer

        d1 = Val(txtdiagonal1.Text)
        d2 = Val(txtdiagonal2.Text)
        sipan = Val(txtsipan.Text)
        sipen = Val(txtsipen.Text)

        luas = HitungLuas(d1, d2)
        keliling = 2 * (sipan * sipen)

        txtluas.Text = Str(luas)
        txtkeliling.Text = Str(keliling)
    End Sub
End Class
