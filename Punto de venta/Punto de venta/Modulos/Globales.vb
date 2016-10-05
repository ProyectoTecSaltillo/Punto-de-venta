Imports MySql.Data.MySqlClient

Module Globales
    Public var As String
    Public cnx As New MySqlConnection
    Public EL_nombre As String
    Public idpais As String
    Public inc As Integer
    Public pais = "paises", estado = "estados", cuidad = "ciudades", colonia = "colonias"
    Public idEstado, idCiuadad, idColonia, idCiudad As Integer
End Module
