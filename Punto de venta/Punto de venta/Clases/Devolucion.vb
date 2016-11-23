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
    Public Sub PoblarDataGrid(ByVal DGV As DataGridView)
        DGV.DataSource = consultaTodos()
        DGV.Refresh()
        cnx.Close()
    End Sub
    Public Function consultaTodos() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT * FROM Devoluciones ORDER BY fecha ASC;"
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

        strSQL = "SELECT * FROM Devoluciones WHERE fecha between '" & CStr(Inicio) & "' AND '" & CStr(fin) & "'  ORDER BY fecha ASC;"
        consultaTodosEntreFecha = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

End Class
