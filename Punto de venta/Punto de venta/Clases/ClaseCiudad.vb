Public Class ClaseCiudad
    Inherits ClasePrinc
    Public Sub New()
        id = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal nuevoNombre As String)
        MyBase.New(nuevoNombre)
    End Sub
    Public Sub New(ByVal nuevoid As Integer)
        MyBase.New(nuevoid)
    End Sub
    Public Sub inserta(ByVal idPais As String, ByVal idEstado As String)
        Dim strSql As String
        'Buscar id Pais ¿como? y agregar el primer campo 
        strSql = "INSERT INTO " & ciudad & " (id_pais,id_estado,id_ciudad,nombre) VALUES(" & idPais & "," & idEstado & "," & AutoIncrement(ciudad) & ",'" & nombre & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Sub poblarCombo(ByVal ComboC As ComboBox, ByVal idpais As String, ByVal idestado As String)
        Dim ds As DataTable
        ds = consultaTodos(idpais, idestado)
        ComboC.ValueMember = ds.Columns(0).ToString()
        ComboC.DataSource = ds
        ComboC.Refresh()
    End Sub
    Public Function consultaTodos(ByVal idpais As String, ByVal idestado As String) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre AS Ciudad FROM ciudades WHERE id_pais = '" & idpais & "'AND id_estado = '" & idestado & "'  ORDER BY nombre ASC;"
        consultaTodos = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Overloads Function getNombre()
        Return MyBase.getNombre(ciudad)
    End Function
    Public Overloads Function elimina()
        Return MyBase.elimina(ciudad)
    End Function
    Public Overloads Function getId()
        Return MyBase.getId(ciudad)
    End Function
End Class
