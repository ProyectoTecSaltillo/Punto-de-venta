Public Class ClaseDevolucion
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
    Public Sub inserta(ByVal idproducto As String, ByVal idusuario As String, ByVal motivo As String, ByVal cantidad As String)
        Dim strSql As String
        strSql = "INSERT INTO " & devolucion & " (id_devolucion,id_producto,id_usuario,motivo,piezas) VALUES(" & AutoIncrement(devolucion) & ",'" & idproducto & "','" & idusuario & "','" & motivo & "','" & cantidad & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Overloads Sub actualiza(ByVal idProducto As Integer, ByVal nombre As String, ByVal precioVenta As String, ByVal precioCompra As String, ByVal descripcion As String, ByVal observacion As String)
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "UPDATE devoluciones SET nombre = '" & nombre & "', descripcion = '" & descripcion & "' , precioVenta = " &
                        precioVenta & ", precioCompra = " & precioCompra & ", observacion = '" & observacion & "' WHERE id_producto = " & idProducto & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Producto actualizado!")
        Catch
            MsgBox("No se pudo actualizar")
        End Try
        cnx.Close()
    End Sub
    Public Sub eliminar(ByVal Nombre As String)
        Dim strSql As String
        Dim xCnx As New conexion
        Dim id_dev As String = Nothing
        Dim xDT As DataTable
        Try
            strSql = "Select id_devolucion as Columna
                        From devoluciones Join productos On devoluciones.id_producto = productos.id_producto  
                        Where CONCAT(productos.nombre, ' ' ,productos.fecha) = '" & Nombre & "';"
            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count = 1 Then
                id_dev = CStr(xDT.Rows(0)("Columna"))
            End If
            strSql = "DELETE FROM Devoluciones WHERE id_devolucion = '" & id_dev & "';"
            xCnx.objetoCommand(strSql)
            MsgBox("DEvolucion eliminada")
        Catch
            MsgBox("No se pudo eliminar")
        End Try
        cnx.Close()
    End Sub
    Public Sub modificar(ByVal Nombre As String, ByVal motivo As String, ByVal id_producto As String, ByVal cantidad As String)
        Dim strSql As String
        Dim xCnx As New conexion
        Dim id_dev As String = Nothing
        Dim xDT As DataTable
        Try
            strSql = "Select id_devolucion as Columna
                        From devoluciones Join productos On devoluciones.id_producto = productos.id_producto  
                        Where CONCAT(productos.nombre, ' ' ,productos.fecha) = '" & Nombre & "';"
            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count = 1 Then
                id_dev = CStr(xDT.Rows(0)("Columna"))
            End If
            strSql = "UPDATE devoluciones set motivo = '" & motivo & "', id_producto = '" & id_producto & "', piezas = '" & cantidad & "' WHERE id_devolucion = '" & id_dev & "';"
            xCnx.objetoCommand(strSql)
            MsgBox("Devolucion Modificada")
        Catch
            MsgBox("No se pudo Modificar")
        End Try
        cnx.Close()
    End Sub
    Public Sub PoblarDataGrid(ByVal DGV As DataGridView)
        DGV.DataSource = consultaTodos()
        DGV.Refresh()
        cnx.Close()
    End Sub
    Public Function consultaTodos() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT CONCAT (productos.nombre , ' ' ,productos.fecha) as Columna FROM Devoluciones join productos on devoluciones.id_producto = productos.id_producto ORDER BY productos.fecha ASC;"
        consultaTodos = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Sub PoblarDataGridConFecha(ByVal DGV As DataGridView, ByVal Inicio As String, ByVal fin As String)
        DGV.DataSource = consultaTodosEntreFecha(Inicio, fin)
        DGV.Refresh()
        cnx.Close()
    End Sub
    Public Function consultaTodosEntreFecha(ByVal Inicio As String, ByVal fin As String) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT * FROM Devoluciones WHERE devoluciones.fecha between '" & CStr(Inicio) & "' AND '" & CStr(fin) & "'  ORDER BY devoluciones.fecha ASC;"
        consultaTodosEntreFecha = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Function DatosDevolucion(ByVal devolucion As Object, ByVal Nombre As String) As Object
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM Devoluciones join productos on devoluciones.id_producto = productos.id_producto WHERE CONCAT (productos.nombre , ' ' ,productos.fecha) = '" & Nombre & "' order by devoluciones.fecha asc;"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            devolucion = xDT.Rows(0)
        End If
        cnx.Close()
        Return devolucion
    End Function
    Public Sub poblarCombo(ByVal ComboCo As ComboBox)
        Dim ds As DataTable
        ds = consultaTodos()
        ComboCo.ValueMember = ds.Columns(0).ToString()
        ComboCo.DisplayMember = "Columna"
        ComboCo.DataSource = ds
        ComboCo.Refresh()
    End Sub
End Class
