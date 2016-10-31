Public Class ClaseCliente
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

        strSQL = "SELECT CONCAT( nombre, ' ', paterno, ' ', materno ) AS Nombre FROM clientes ORDER BY Nombre ASC;"
        consultaTodos = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub poblarCombo(ByVal ComboNombre As ComboBox)
        Dim ds As DataTable
        ds = consultaTodos()
        ComboNombre.ValueMember = ds.Columns(0).ToString()
        ComboNombre.DataSource = ds
        ComboNombre.Refresh()
    End Sub

    Public Function consultaCliente(ByVal nombreCompleto As String) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT * FROM clientes WHERE CONCAT(nombre, ' ', paterno, ' ', materno) = '" & nombreCompleto & "';"
        clientee = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
        Return clientee
        'consultaCliente = xCnx.objetoDataAdapter(strSQL)
        'clientee.Clear()
        'clientee = consultaCliente

    End Function

    Public Sub inserta(ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal edad As String, ByVal rfc As String,
                       ByVal curp As String, ByVal sexo As String, ByVal email As String, ByVal telefono As String, ByVal numExt As String,
                       ByVal calle As String, ByVal idColonia As String)
        Dim strSql As String
        strSql = "INSERT INTO clientes VALUES(" & AutoIncrement(clientes) & ",'" & nombre & "','" & paterno & "','" & materno & "','" & edad & "','" &
                                                rfc & "','" & curp & "','" & sexo & "','" & email & "','" & telefono & "','" & numExt & "','" &
                                               calle & "'," & idColonia & ");"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
End Class
