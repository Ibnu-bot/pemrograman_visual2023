Module MyMod
    Public api_folder As String = "appakademik"
    Public users_api As String = "http://f0833871.xsph.ru/" & api_folder & "/users_api.php"
    Public sparepart_api As String = "http://f0833871.xsph.ru/" & api_folder & "/sparepart_api.php"
    Public sparepart_baru As Boolean = False
    Public penjualan_api As String = "http://f0833871.xsph.ru/" & api_folder & "/penjualan_api.php"
    Public penjualan_baru As Boolean = False

    Public Dashboard As New Form1
    Public Admin1Form As New FormSparepart
    Public Admin2Form As New FormPenjualan
    Public LoginForm As New Login

    Public admin_role As Boolean = False
    Public pembeli_role As Boolean = False
    Public login_valid As Boolean = False


End Module
