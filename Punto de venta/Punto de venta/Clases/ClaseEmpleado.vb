Public Class ClaseEmpleado
    Inherits ClasePrinc
    Public Sub New()
        id = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal nuevoNombre As String)
        MyBase.New(nuevoNombre)
    End Sub
    Public Function consultaTodos() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT CONCAT( nombre, ' ', apellidoP, ' ', apellidoM ) as Nombre FROM empleados ORDER BY Nombre ASC;"
        consultaTodos = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Sub poblarCombo(ByVal ComboCo As ComboBox)
        Dim ds As DataTable
        ds = consultaTodos()
        ComboCo.ValueMember = ds.Columns(0).ToString()
        ComboCo.DataSource = ds
        ComboCo.Refresh()
    End Sub
    Public Sub inserta(ByVal idPais As String, ByVal idEstado As String, ByVal idCiudad As String)
        Dim strSql As String
        'Buscar id Pais ¿como? y agregar el primer campo 
        strSql = "INSERT INTO " & colonia & " (id_pais,id_estado,id_ciudad,id_colonia,nombre) VALUES(" & idPais & "," & idEstado & "," & idCiudad & "," & AutoIncrement(colonia) & ",'" & nombre & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
End Class
