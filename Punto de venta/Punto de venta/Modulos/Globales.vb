Imports MySql.Data.MySqlClient

Module Globales
    Public cnx As New MySqlConnection
    Public pais = "paises", estado = "estados", ciudad = "ciudades", colonia = "colonias", empleados = "empleados", proveedores = "proveedores", clientes = "clientes"
    Public var, EL_nombre As String
    Public idPais, idEstado, idColonia, idCiudad, inc As Integer
    Public session, clientee As Object
End Module
