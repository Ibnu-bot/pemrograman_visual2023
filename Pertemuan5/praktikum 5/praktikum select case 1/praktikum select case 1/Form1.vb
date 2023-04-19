Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtplat.Text
            Case "A" : txtketerangan.Text = "Banten"

            Case "B" : txtketerangan.Text = "Jakarta"

            Case "D" : txtketerangan.Text = "Bandung"

            Case "E" : txtketerangan.Text = "Cirebon"

            Case Else : txtketerangan.Text = "Plat belum terdaftar"
        End Select
    End Sub
End Class