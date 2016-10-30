Public Class ClaseCliente
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

    Public Function consultaTodos() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT CONCAT( nombre, ' ', paterno, ' ', materno ) AS Nombre FROM clientes ORDER BY Nombre ASC;"
        consultaTodos = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub poblarComboN(ByVal ComboNombre As ComboBox)
        Dim ds As DataTable
        ds = consultaTodos()
        ComboNombre.ValueMember = ds.Columns(0).ToString()
        ComboNombre.DataSource = ds
        ComboNombre.Refresh()
    End Sub

    Public Function consultaTodosID() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT id_cliente FROM clientes;"
        consultaTodosID = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Sub poblarComboID(ByVal ComboCo As ComboBox)
        Dim ds As DataTable
        ds = consultaTodosID()
        ComboCo.ValueMember = ds.Columns(0).ToString()
        ComboCo.DataSource = ds
        ComboCo.Refresh()
    End Sub

    Public Function consultaCliente(ByVal cliente As Object) As Object
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM clientes WHERE id_cliente = " & id & ";"
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            cliente = xDT.Rows(0)
        End If
        cnx.Close()
        Return cliente
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
        MessageBox.Show("Cliente registrado!")
        cnx.Close()
    End Sub

    Public Overloads Function getNombre()
        Return MyBase.getNombre(clientes)
    End Function

    Public Overloads Function getId()
        Return MyBase.getId(clientes)
    End Function

    Public Overloads Function elimina()
        Return MyBase.elimina(clientes)
    End Function

    Public Overloads Sub actualiza(ByVal idCliente As String, ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal edad As String, ByVal rfc As String,
                       ByVal curp As String, ByVal sexo As String, ByVal email As String, ByVal telefono As String, ByVal numExt As String,
                       ByVal calle As String, ByVal idColonia As String)
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "UPDATE clientes SET nombre = '" & nombre & "', paterno = '" & paterno & "' , materno = '" &
                        materno & "' , edad = " & edad & ", rfc = '" & rfc & "' , curp = '" & curp & "' , sexo = '" &
                        sexo & "' , email = '" & email & "' , telefono = '" & telefono & "' , numeroExt = '" & numExt &
                        "' , calle = '" & calle & "' , id_colonia = " & idColonia & " WHERE id_cliente = " & idCliente & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Cliente actualizado!")
        Catch
            MsgBox("No se pudo actualizar")
        End Try
        cnx.Close()
    End Sub

    Public Sub eliminar(ByVal id As Integer)
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "DELETE FROM clientes WHERE id_cliente = " & id & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Cliente eliminado")
        Catch
            MsgBox("No se pudo eliminar")
        End Try
        cnx.Close()
    End Sub
End Class
