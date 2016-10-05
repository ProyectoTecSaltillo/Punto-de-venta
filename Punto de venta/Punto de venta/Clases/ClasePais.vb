Imports MySql.Data.MySqlClient
Public Class ClasePais
    Private id As Integer
    Private nombre As String
    Private ds As DataTable

    Public Sub New()
        idPais = 0
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
    Public Function consultaTodosEstados() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre AS Estado FROM estados ORDER BY nombre ASC;"
        consultaTodosEstados = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Function consultaTodosCiudades() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre AS Ciudad FROM ciudades ORDER BY nombre ASC;"
        consultaTodosCiudades = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Function consultaTodosColonias() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre AS Colonia FROM colonias ORDER BY nombre ASC;"
        consultaTodosColonias = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    'Rellena el Combobox con la base de datos
    Public Sub poblarComboPaises(ByVal ComboP As ComboBox)
        ds = consultaTodosPaises()
        ComboP.ValueMember = ds.Columns(0).ToString()
        ComboP.DataSource = ds
        ComboP.Refresh()
    End Sub
    Public Sub poblarComboEstados(ByVal ComboE As ComboBox)
        ds = consultaTodosEstados()
        ComboE.ValueMember = ds.Columns(0).ToString()
        ComboE.DataSource = ds
        ComboE.Refresh()
    End Sub
    Public Sub poblarComboCiudades(ByVal ComboC As ComboBox)
        ds = consultaTodosCiudades()
        ComboC.ValueMember = ds.Columns(0).ToString()
        ComboC.DataSource = ds
        ComboC.Refresh()
    End Sub
    Public Sub poblarComboColonias(ByVal ComboCo As ComboBox)
        ds = consultaTodosColonias()
        ComboCo.ValueMember = ds.Columns(0).ToString()
        ComboCo.DataSource = ds
        ComboCo.Refresh()
    End Sub

    'Consulta todos los estados de la base de datos que estén relacionados con el nombre del país brindado
    Public Function consultaUnEstado() As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM estados WHERE nombre = '" & nombre & "';"
        consultaUnEstado = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            consultaUnEstado = True
        End If
        cnx.Close()
    End Function

    Public Function consultaUno(ByRef Tabla As String) As Boolean
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

    Public Sub inserta(ByVal Tabla As String)
        Dim strSql As String
        Dim xCnx As New conexion
        If Tabla = pais Then
            strSql = "INSERT INTO " & Tabla & " (nombre) VALUES('" & nombre & "');"
            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro insertado!")
            cnx.Close()
        ElseIf Tabla = estado Then
            'Buscar id Pais ¿como? y agregar el primer campo 
            strSql = "INSERT INTO " & Tabla & " (id_pais,id_estado,nombre) VALUES(" & AutoIncrementE(Tabla) & "," & nombre & "');"
            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro insertado!")
            cnx.Close()
        End If
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
            MsgBox("Faltan datos del país", MsgBoxStyle.Critical)
            cnx.Close()
            Return False
        End If
    End Function

    Public Function AutoIncrementE(ByVal tabla As String) As Integer
        If tabla = estado Then
            idEstado += 1
            Return idEstado
        ElseIf tabla = cuidad Then
            idCiudad += 1
            Return idCiudad
        ElseIf tabla = colonia Then
            idColonia += 1
            Return idColonia
        End If
        Return 0
    End Function
End Class
