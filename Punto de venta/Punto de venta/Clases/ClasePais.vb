Imports MySql.Data.MySqlClient
Public Class ClasePais
    Private id As Integer
    Private nombre As String

    Public Sub New()
        id = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal nuevoNombre As String)
        nombre = nuevoNombre
    End Sub
    ' No se utiliza
    '   Public Sub New(ByVal id As Integer)
    '      idPais = id
    ' End Sub

    Public Property getSetidPais() As Integer
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

    'Consulta el nombre de todos los paises de la base de datos
    Public Function consultaTodosPaises() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre AS País FROM paises ORDER BY nombre ASC;"
        consultaTodosPaises = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Function consultaTodosEstados(ByVal idpais As String) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre AS Estado FROM estados WHERE id_pais = '" & idpais & "' ORDER BY nombre ASC;"
        consultaTodosEstados = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Function consultaTodosCiudades(ByVal idpais As String, ByVal idestado As String) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre AS Ciudad FROM ciudades WHERE id_pais = '" & idpais & "'AND id_estado = '" & idestado & "'  ORDER BY nombre ASC;"
        consultaTodosCiudades = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Function consultaTodosColonias(ByVal idpais As String, ByVal idestado As String, ByVal idciudad As String) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre AS Colonia FROM colonias WHERE id_pais = '" & idpais & "'AND id_estado = '" & idestado & "' AND id_ciudad'" & idciudad & "' ORDER BY nombre ASC;"
        consultaTodosColonias = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    'Rellena el Combobox con la base de datos
    Public Sub poblarComboPaises(ByVal ComboP As ComboBox)
        Dim ds As DataTable
        ds = consultaTodosPaises()
        ComboP.ValueMember = ds.Columns(0).ToString()
        ComboP.DataSource = ds
        ComboP.Refresh()
    End Sub
    Public Sub poblarComboEstados(ByVal ComboE As ComboBox, ByVal idpais As String)
        Dim ds As DataTable
        ds = consultaTodosEstados(idpais)
        ComboE.ValueMember = ds.Columns(0).ToString()
        ComboE.DataSource = ds
        ComboE.Refresh()
    End Sub
    Public Sub poblarComboCiudades(ByVal ComboC As ComboBox, ByVal idpais As String, ByVal idestado As String)
        Dim ds As DataTable
        ds = consultaTodosCiudades(idpais, idestado)
        ComboC.ValueMember = ds.Columns(0).ToString()
        ComboC.DataSource = ds
        ComboC.Refresh()
    End Sub
    Public Sub poblarComboColonias(ByVal ComboCo As ComboBox, ByVal idpais As String, ByVal idestado As String, ByVal idciudad As String)
        Dim ds As DataTable
        ds = consultaTodosColonias(idpais, idestado, idciudad)
        ComboCo.ValueMember = ds.Columns(0).ToString()
        ComboCo.DataSource = ds
        ComboCo.Refresh()
    End Sub

    'Consulta todos los estados de la base de datos que estén relacionados con el nombre del país brindado
    Public Function consultaAlgoP(ByVal Tabla As String, ByVal idPais As String) As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM " & Tabla & " WHERE id_pais = '" & idPais & "';"
        consultaAlgoP = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            consultaAlgoP = True
        End If
        cnx.Close()
    End Function
    Public Function consultaAlgoE(ByVal Tabla As String, ByVal idEstado As String) As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM " & Tabla & " WHERE id_estado = '" & idEstado & "';"
        consultaAlgoE = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            consultaAlgoE = True
        End If
        cnx.Close()
    End Function

    Public Function consultaUno(ByVal Tabla As String) As Boolean
        Dim strSQL As String
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

    Public Sub insertaP()
        Dim strSql As String
        Dim xCnx As New conexion
        strSql = "INSERT INTO " & pais & " (nombre) VALUES('" & nombre & "');"
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Sub insertaE(ByVal idPais As String)
        Dim strSql As String
        'Buscar id Pais ¿como? y agregar el primer campo 
        strSql = "INSERT INTO " & estado & " (id_pais,id_estado,nombre) VALUES(" & idPais & "," & AutoIncrementE(estado) & ",'" & nombre & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Sub insertaC(ByVal idPais As String, ByVal idEstado As String)
        Dim strSql As String
        'Buscar id Pais ¿como? y agregar el primer campo 
        strSql = "INSERT INTO " & ciudad & " (id_pais,id_estado,id_ciudad,nombre) VALUES(" & idPais & "," & idEstado & "," & AutoIncrementE(ciudad) & ",'" & nombre & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub

    Public Function actualiza(ByVal Tabla As String, ByVal NuevoNombre As String) As Boolean
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
    Public Function elimina(ByVal tabla As String) As Boolean
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
    Public Function getIdPais() As String
        Dim strSql As String
        Dim xCnx As New conexion
        Dim xDT As DataTable
        strSql = "SELECT id_pais FROM " & pais & " WHERE nombre='" & nombre & "';"
        xDT = xCnx.objetoDataAdapter(strSql)
        id = CStr(xDT.Rows(0)("id_pais"))
        cnx.Close()
        Return id
    End Function
    Public Function getIdEstado() As String
        Dim strSql As String
        Dim xCnx As New conexion
        Dim xDT As DataTable
        strSql = "SELECT id_estado FROM " & estado & " WHERE nombre='" & nombre & "';"
        xDT = xCnx.objetoDataAdapter(strSql)
        id = CStr(xDT.Rows(0)("id_estado"))
        cnx.Close()
        Return id
    End Function
    Public Function getIdCiudad() As String
        Dim strSql As String
        Dim xCnx As New conexion
        Dim xDT As DataTable
        strSql = "SELECT id_ciudad FROM " & ciudad & " WHERE nombre='" & nombre & "';"
        xDT = xCnx.objetoDataAdapter(strSql)
        id = CStr(xDT.Rows(0)("id_ciudad"))
        cnx.Close()
        Return id
    End Function
    Public Function getIdColonia() As String
        Dim strSql As String
        Dim xCnx As New conexion
        Dim xDT As DataTable
        strSql = "SELECT id_colonia FROM " & colonia & " WHERE nombre='" & nombre & "';"
        xDT = xCnx.objetoDataAdapter(strSql)
        id = CStr(xDT.Rows(0)("id_colonia"))
        cnx.Close()
        Return id
    End Function
    Public Function getMaxIdEstado() As String
        Dim strSql As String
        Dim xCnx As New conexion
        Dim xDT As DataTable
        strSql = "SELECT max(id_estado) as Estado FROM " & estado & ";"
        xDT = xCnx.objetoDataAdapter(strSql)
        id = CStr(xDT.Rows(0)("Estado"))
        cnx.Close()
        Return id
    End Function
    Public Function getMaxIdCiudad() As String
        Dim strSql As String
        Dim xCnx As New conexion
        Dim xDT As DataTable
        strSql = "SELECT max(id_ciudad) as Ciudad FROM " & ciudad & ";"
        xDT = xCnx.objetoDataAdapter(strSql)
        id = CStr(xDT.Rows(0)("Ciudad"))
        cnx.Close()
        Return id
    End Function
    Public Function getMaxIdColonia() As String
        Dim strSql As String
        Dim xCnx As New conexion
        Dim xDT As DataTable
        strSql = "SELECT max(id_colonia) as Colonia FROM " & colonia & ";"
        xDT = xCnx.objetoDataAdapter(strSql)
        id = CStr(xDT.Rows(0)("Colonia"))
        cnx.Close()
        Return id
    End Function
    Public Function AutoIncrementE(ByVal tabla As String) As Integer
        If tabla = estado Then
            idEstado = getMaxIdEstado() + 1
            Return idEstado
        ElseIf tabla = ciudad Then
            idCiudad = getMaxIdCiudad() + 1
            Return idCiudad
        ElseIf tabla = colonia Then
            idColonia = getMaxIdColonia() + 1
            Return idColonia
        End If
        Return 0
    End Function
End Class
