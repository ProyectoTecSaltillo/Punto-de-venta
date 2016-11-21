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
