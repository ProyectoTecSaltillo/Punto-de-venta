Imports MySql.Data.MySqlClient

Module Globales
    Public var As String
    Public cnx As New MySqlConnection
    Public EL_nombre As String
    Public inc As Integer
    Public pais = "paises", estado = "estados", ciudad = "ciudades", colonia = "colonias", empleados = "empleados"
    Public idPais, idEstado, idColonia, idCiudad As Integer
End Module
