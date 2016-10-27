Public Class ClaseEstado
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
    Public Function consultaTodos(ByVal id As String) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre AS Estado FROM estados WHERE id_pais = '" & id & "' ORDER BY nombre ASC;"
        consultaTodos = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Sub poblarCombo(ByVal ComboEstados As ComboBox, ByVal id As String)
        Dim ds As DataTable
        ds = consultaTodos(id)
        ComboEstados.ValueMember = ds.Columns(0).ToString()
        ComboEstados.DataSource = ds
        ComboEstados.Refresh()
    End Sub
    Public Sub inserta(ByVal idPais As String)
        Dim strSql As String
        'Buscar id Pais ¿como? y agregar el primer campo 
        strSql = "INSERT INTO " & estado & " (id_pais,id_estado,nombre) VALUES(" & idPais & "," & AutoIncrement(estado) & ",'" & nombre & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Overloads Function getNombre()
        Return MyBase.getNombre(estado)
    End Function
    Public Overloads Function getId()
        Return MyBase.getId(estado)
    End Function

    Public Overloads Function elimina()
        Return MyBase.elimina(estado)
    End Function
End Class
