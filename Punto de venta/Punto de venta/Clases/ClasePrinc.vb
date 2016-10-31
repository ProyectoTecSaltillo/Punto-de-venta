Public Class ClasePrinc
    Protected id As Integer
    Protected nombre As String
    Public Sub New()
        id = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal nuevoNombre As String)
        nombre = nuevoNombre
    End Sub

    Public Sub New(ByVal nuevoid As Integer)
        id = nuevoid
    End Sub
    Public Property getSetid() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Overloads Function actualiza(ByVal Tabla As String, ByVal NuevoNombre As String) As Boolean
        Dim strSql As String
        Dim xCnx As New conexion
        If NuevoNombre <> "" Then
            strSql = "UPDATE " & Tabla & " SET nombre = '" & NuevoNombre & "' WHERE nombre = '" & nombre & "';"
            xCnx.objetoCommand(strSql)
            MsgBox("Registro modificado")
            cnx.Close()
            Return True
        Else
            MsgBox("Ingrese el Nuevo Nombre")
            cnx.Close()
            Return False
        End If
    End Function
    Public Overloads Function elimina(ByVal tabla As String) As Boolean
        Dim strSql As String
        Dim xCnx As New conexion

        If nombre <> "" Then
            strSql = "DELETE FROM " & tabla & " WHERE nombre='" & nombre & "';"
            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro Eliminado")
            cnx.Close()
            Return True
        Else
            MsgBox("Falta el Nombre a Eliminar", MsgBoxStyle.Critical)
            cnx.Close()
            Return False
        End If
    End Function
    Public Function AutoIncrement(ByVal tabla As String) As Integer
        id = getMaxId(tabla) + 1
        Return id
    End Function
    Public Function getMaxId(ByVal tabla As String) As String
        Dim strSql As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable
        Select Case (tabla)
            Case pais
                strSql = "SELECT max(id_pais) as Columna FROM " & pais & ";"
            Case estado
                strSql = "SELECT max(id_estado) as Columna FROM " & estado & ";"
            Case ciudad
                strSql = "SELECT max(id_ciudad) as Columna FROM " & ciudad & ";"
            Case colonia
                strSql = "SELECT max(id_colonia) as Columna FROM " & colonia & ";"
            Case proveedores
                strSql = "SELECT max(id_proveedor) as Columna FROM " & proveedores & ";"

            Case usuarios
                strSql = "SELECT max(id_usuario) as Columna FROM " & usuarios & ";"
            Case clientes
                strSql = "SELECT MAX(id_cliente) AS Columna FROM " & clientes & ";"
        End Select
        Try
            xDT = xCnx.objetoDataAdapter(strSql)
            id = CStr(xDT.Rows(0)("Columna"))
            'cnx.Close()
            Return id
        Catch
        End Try
        id = 0
        cnx.Close()
        Return id
    End Function
    Public Overloads Function getId(ByVal tabla As String) As String
        Dim strSql As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable
        Select Case (tabla)
            Case pais
                strSql = "SELECT id_pais as Columna FROM " & pais & " WHERE nombre='" & nombre & "';"
            Case estado
                strSql = "SELECT id_estado as Columna FROM " & estado & " WHERE nombre='" & nombre & "';"
            Case ciudad
                strSql = "SELECT id_ciudad as Columna FROM " & ciudad & " WHERE nombre='" & nombre & "';"
            Case colonia
                strSql = "SELECT id_colonia as Columna FROM " & colonia & " WHERE nombre='" & nombre & "';"
            Case proveedores
                strSql = "select id_proveedores as columna from " & proveedores & " where nombre =" & nombre & "';"
            Case usuarios
                strSql = "SELECT id_usuario as Columna FROM " & usuarios & " WHERE CONCAT( nombre, ' ', paterno, ' ', materno ) ='" & nombre & "';"
            Case clientes
                strSql = "SELECT id_cliente as Columna FROM " & clientes & " WHERE CONCAT( nombre, ' ', paterno, ' ', materno ) = '" & nombre & "';"
        End Select
        Try
            xDT = xCnx.objetoDataAdapter(strSql)
            id = CStr(xDT.Rows(0)("Columna"))
            cnx.Close()
            Return id
        Catch
        End Try
        id = 0
        cnx.Close()
        Return id
    End Function
    Public Function consultaUno(ByVal Tabla As String) As Boolean
        Dim strSQL As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM " & Tabla & " WHERE nombre = '" & nombre & "';"
        consultaUno = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombre = ""
            Else
                nombre = CStr(xDT.Rows(0)("nombre"))
                EL_nombre = CStr(xDT.Rows(0)("nombre"))
            End If
            consultaUno = True
        End If
        cnx.Close()
    End Function
    Public Function consultaAlgo(ByVal Tabla As String, ByVal id As String) As Boolean
        Dim strSQL As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable
        Select Case (Tabla)
            Case estado
                strSQL = "SELECT * FROM " & Tabla & " WHERE id_pais = '" & id & "';"
            Case ciudad
                strSQL = "SELECT * FROM " & Tabla & " WHERE id_estado = '" & id & "';"
            Case colonia
                strSQL = "SELECT * FROM " & Tabla & " WHERE id_ciudad = '" & id & "';"
        End Select
        consultaAlgo = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            consultaAlgo = True
        End If
        cnx.Close()
    End Function
    Public Overloads Function getNombre(ByVal tabla As String)
        Dim strSQL As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable
        Select Case (tabla)
            Case pais
                strSQL = "SELECT nombre FROM " & pais & " WHERE id_pais= " & id & ";"
            Case estado
                strSQL = "SELECT nombre FROM " & estado & " WHERE id_estado= " & id & ";"
            Case ciudad
                strSQL = "SELECT nombre FROM " & colonia & " WHERE id_ciudad= " & id & ";"
            Case colonia
                strSQL = "SELECT nombre FROM " & colonia & " WHERE id_colonia= " & id & ";"
            Case usuarios
                strSQL = "SELECT CONCAT( nombre, ' ', paterno, ' ', materno ) as nombre FROM usuarios WHERE id_usuario = " & id & ";"
            Case clientes
                strSQL = "SELECT CONCAT( nombre, ' ', paterno, ' ', materno ) AS nombre FROM clientes WHERE id_cliente = " & id & ";"
        End Select
        xDT = xCnx.objetoDataAdapter(strSQL)
        nombre = CStr(xDT.Rows(0)("nombre"))
        cnx.Close()
        Return nombre
    End Function
End Class
