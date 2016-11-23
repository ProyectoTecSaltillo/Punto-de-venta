Public Class ClaseVenta
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


    Public Function consultaVenta(ByVal producto As Object) As Object
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM ventas WHERE id_venta = " & id & ";"
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            producto = xDT.Rows(0)
        End If
        cnx.Close()
        Return producto
    End Function
    ''Checar el metodo
    Public Sub inserta(ByVal nombre As String, ByVal descripcion As String, ByVal id_proveedor As Integer, ByVal id_empleado As Integer, ByVal precioVenta As String, ByVal precioCompra As String, ByVal observacion As String)
        Dim strSql As String
        strSql = "INSERT INTO Venta VALUES(" & AutoIncrement(ventas) & ",'" & nombre & "','" & descripcion & "'," & id_proveedor & "," & id_empleado & "," &
                                                precioVenta & "," & precioCompra & ",'" & observacion & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Producto registrado!")
        cnx.Close()
    End Sub

    Public Overloads Function getId() As String
        Dim strSql As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable

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


    Public Sub eliminar(ByVal id As Integer)
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "DELETE FROM ventas WHERE id_venta = " & id & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Producto eliminado")
        Catch
            MsgBox("No se pudo eliminar")
        End Try
        cnx.Close()
    End Sub
    Public Sub PoblarDataGridConFecha(ByVal DGV As DataGridView, ByVal Inicio As String, ByVal fin As String)
        DGV.DataSource = consultaTodosEntreFecha(Inicio, fin)
        DGV.Refresh()
        cnx.Close()
    End Sub
    Public Function consultaTodosEntreFecha(ByVal Inicio As String, ByVal fin As String) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT * FROM Ventas WHERE fecha between '" & CStr(Inicio) & "' AND '" & CStr(fin) & "'  ORDER BY fecha ASC;"
        consultaTodosEntreFecha = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub inserta(ByVal id_empleado As Integer, ByVal id_cliente As Integer, ByVal importe As Integer,
                       ByVal pago As String, ByVal id_producto As Integer, ByVal piezas As Integer)
        Dim strSql As String
        strSql = "INSERT INTO ventas(id_venta, id_empleado, id_cliente, importe, pago, id_producto, piezas) VALUES(" & AutoIncrement(ventas) & "," & id_empleado & "," & id_cliente & "," &
                    importe & ",'" & pago & "'," & id_producto & "," & piezas & ");"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        cnx.Close()
    End Sub

    Public Overloads Function getNombre()
        Return MyBase.getNombre(clientes)
    End Function

    Public Overloads Function getId()
        Return MyBase.getId(clientes)
    End Function

End Class
