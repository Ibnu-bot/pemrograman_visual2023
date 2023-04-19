Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtpabrik.Text
            Case "TMMIN" : txtketerangan.Text = "Toyota Motor Manufacturing Indonesia"

            Case "AHM" : txtketerangan.Text = "Astra Hpnda Motor"

            Case "ADM" : txtketerangan.Text = "Astea Daihatsu Motor"

            Case "HMMI" : txtketerangan.Text = "Hyundai Motor Manufacturing Indonesia"

            Case Else : txtketerangan.Text = "apaan Tuh"
        End Select
    End Sub
End Class