Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net
Public Class FormPenjualan
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim kode_penjualan As String = txtKodePenjualan.Text
        Dim nama_sparepart As String = txtNamaSparepart.Text
        Dim harga As String = txtHarga.Text
        Dim bayar As String = txtBayar.Text
        Dim kembalian As String = txtKembalian.Text

        Dim postData As String = $"&kode_penjualan={kode_penjualan}&nama_sparepart={nama_sparepart}&harga={harga}&bayar={bayar}&kembalian={kembalian}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(penjualan_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub CalculateTotalBiaya()
        ' Get the data from the textboxes
        Dim harga As Integer
        Dim bayar As Integer

        If Integer.TryParse(txtHarga.Text, harga) AndAlso Integer.TryParse(txtBayar.Text, bayar) Then
            ' Calculate the total_biaya
            Dim kembalian As Integer = bayar - harga

            ' Display the calculated total_biaya in the txtTOTALBIAYA textbox
            txtKembalian.Text = kembalian.ToString()
        End If
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim kode_penjualan As String = txtKodePenjualan.Text
        Dim nama_sparepart As String = txtNamaSparepart.Text
        Dim harga As String = txtHarga.Text
        Dim bayar As String = txtBayar.Text
        Dim kembalian As String = txtKembalian.Text

        Dim postData As String = $"&kode_penjualan={kode_penjualan}&nama_sparepart={nama_sparepart}&harga={harga}&bayar={bayar}&kembalian={kembalian}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(penjualan_api & "?kode_penjualan=" & txtKodePenjualan.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim kode_penjualan As String = txtKodePenjualan.Text
        Dim nama_sparepart As String = txtNamaSparepart.Text
        Dim harga As String = txtHarga.Text
        Dim bayar As String = txtBayar.Text
        Dim kembalian As String = txtKembalian.Text

        Dim postData As String = $"&kode_penjualan={kode_penjualan}&nama_sparepart={nama_sparepart}&harga={harga}&bayar={bayar}&kembalian={kembalian}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(penjualan_api & "?kode_penjualan=" & txtKodePenjualan.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(penjualan_api & "?kode_penjualan=" & txtKodePenjualan.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        penjualan_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        penjualan_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (penjualan_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Penjualan) = JsonConvert.DeserializeObject(Of List(Of Penjualan))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Penjualan In data
                            txtKodePenjualan.Text = mydata.kode_penjualan
                            txtNamaSparepart.Text = mydata.nama_sparepart
                            txtHarga.Text = mydata.harga
                            txtBayar.Text = mydata.bayar
                            txtKembalian.Text = mydata.kembalian
                        Next
                    End If

                End Try

            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub
    Private Sub GetClear()
        txtKodePenjualan.Clear()
        txtNamaSparepart.Clear()
        txtHarga.Clear()
        txtBayar.Clear()
        txtKembalian.Clear()
        Reloaded()
        txtKodePenjualan.Focus()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (penjualan_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (penjualan_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(penjualan_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Penjualan) = JsonConvert.DeserializeObject(Of List(Of Penjualan))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub txtKodePenjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodePenjualan.KeyDown
        If e.KeyCode = Keys.Enter Then
            GetData()
        End If
    End Sub

    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged
        CalculateTotalBiaya()
    End Sub
End Class