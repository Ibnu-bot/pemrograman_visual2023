﻿Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtusia.Text) >= 18) Then
            txtketerangan.Text = "Silahkan Membuat SIM"
        Else
            txtketerangan.Text = "Belum Bisa Membuat SIM"
        End If
    End Sub
End Class
