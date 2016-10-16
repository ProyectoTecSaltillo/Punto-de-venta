Imports MySql.Data.MySqlClient

Module Globales
    Public cnx As New MySqlConnection
    Public var, EL_nombre As String
    Public pais = "paises", estado = "estados", ciudad = "ciudades", colonia = "colonias"
    Public idPais, idEstado, idColonia, idCiudad, inc As Integer
    Public session As Object
End Module
