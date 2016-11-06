﻿Public Class ClaseProductos
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
    Public Function consultaTodosPorProveedor(ByVal id_proveedor As Integer) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre FROM productos WHERE id_proveedor = " & id_proveedor & ";"
        consultaTodosPorProveedor = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub poblarComboProducto(ByVal ComboProducto As ComboBox, ByVal id_proveedor As Integer)
        Dim ds As DataTable
        ds = consultaTodosPorProveedor(id_proveedor)
        ComboProducto.ValueMember = ds.Columns(0).ToString()
        ComboProducto.DataSource = ds
        ComboProducto.Refresh()
    End Sub

    Public Function consultaProductosID(ByVal id_proveedor As Integer) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT id_producto FROM productos WHERE id_proveedor = " & id_proveedor & ";"
        consultaProductosID = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub poblarComboID(ByVal ComboID As ComboBox, ByVal id_proveedor As Integer)
        Dim ds As DataTable
        ds = consultaProductosID(id_proveedor)
        ComboID.ValueMember = ds.Columns(0).ToString()
        ComboID.DataSource = ds
        ComboID.Refresh()
    End Sub

    Public Function consultaProducto(ByVal producto As Object) As Object
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM productos WHERE id_producto = " & id & ";"
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            producto = xDT.Rows(0)
        End If
        cnx.Close()
        Return producto
    End Function

    Public Sub inserta(ByVal nombre As String, ByVal descripcion As String, ByVal id_proveedor As Integer, ByVal id_empleado As Integer, ByVal precioVenta As String, ByVal precioCompra As String, ByVal observacion As String)
        Dim strSql As String
        strSql = "INSERT INTO productos VALUES(" & AutoIncrement(productos) & ",'" & nombre & "','" & descripcion & "'," & id_proveedor & "," & id_empleado & "," &
                                                precioVenta & "," & precioCompra & ",'" & observacion & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Producto registrado!")
        cnx.Close()
    End Sub

    Public Overloads Function getNombre()
        Return MyBase.getNombre(productos)
    End Function

    Public Overloads Function getId()
        Return MyBase.getId(productos)
    End Function

    'Public Overloads Function elimina()
    '    Return MyBase.elimina(clientes)
    'End Function

    Public Overloads Sub actualiza(ByVal idProducto As Integer, ByVal nombre As String, ByVal precioVenta As String, ByVal precioCompra As String, ByVal descripcion As String, ByVal observacion As String)
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "UPDATE productos SET nombre = '" & nombre & "', descripcion = '" & descripcion & "' , precioVenta = " &
                        precioVenta & ", precioCompra = " & precioCompra & ", observacion = '" & observacion & "' WHERE id_producto = " & idProducto & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Producto actualizado!")
        Catch
            MsgBox("No se pudo actualizar")
        End Try
        cnx.Close()
    End Sub

    Public Sub eliminar(ByVal id As Integer)
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "DELETE FROM productos WHERE id_producto = " & id & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Producto eliminado")
        Catch
            MsgBox("No se pudo eliminar")
        End Try
        cnx.Close()
    End Sub
End Class
