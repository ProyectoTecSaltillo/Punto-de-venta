﻿Imports MySql.Data.MySqlClient

Module Globales
    Public cnx As New MySqlConnection
    Public pais = "paises", estado = "estados", ciudad = "ciudades", colonia = "colonias", usuarios = "usuarios",
            clientes = "clientes", productos = "productos", proveedores = "proveedores"
    Public var, EL_nombre As String
    Public idPais, idEstado, idColonia, idCiudad, inc As Integer
    Public session As Object
End Module
