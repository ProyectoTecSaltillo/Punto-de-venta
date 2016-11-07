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
End Class
