Imports MySql.Data.MySqlClient
Public Class ClasePais
    Private idPais As Integer
    Private nombre As String

    Public Sub New()
        idPais = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal nuevoNombre As String)
        nombre = nuevoNombre
    End Sub
    ' No se utiliza
    '   Public Sub New(ByVal id As Integer)
    '      idPais = id
    ' End Sub

    Public Property getSetidPais() As Integer
        Get
            Return idPais
        End Get
        Set(ByVal value As Integer)
            idPais = value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    'Consulta el nombre de todos los paises de la base de datos
    Public Function consultaTodosPaises() As Object
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre AS País FROM paises ORDER BY nombre ASC;"
        consultaTodosPaises = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    'Rellena el DataGridView con los paises de la base de datos
    Public Sub poblarComboPaises(ByVal ComboP As ComboBox)
        ComboP.DataSource = consultaTodosPaises()
        ComboP.Refresh()
    End Sub

    'Consulta todos los estados de la base de datos que estén relacionados con el nombre del país brindado
    Public Function consultaUnEstado() As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM estados WHERE nombre = '" & nombre & "';"
        consultaUnEstado = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            consultaUnEstado = True
        End If
        cnx.Close()
    End Function

    Public Function consultaUnPais() As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM paises WHERE nombre = '" & nombre & "';"
        consultaUnPais = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombre = ""
            Else
                nombre = CStr(xDT.Rows(0)("nombre"))
                EL_nombre = CStr(xDT.Rows(0)("nombre"))
            End If
            consultaUnPais = True
        End If
        cnx.Close()
    End Function

    Public Sub insertaPais()
        Dim strSql As String
        Dim xCnx As New conexion

        strSql = "INSERT INTO paises (nombre) VALUES('" & nombre & "');"
        xCnx.objetoCommand(strSql)
        cnx.Close()
    End Sub

    Public Sub actualizaPais()
        Dim strSql As String
        Dim xCnx As New conexion

        strSql = "UPDATE paises SET nombre = '" & nombre & "' WHERE nombre = " & nombre
        xCnx.objetoCommand(strSql)
        cnx.Close()
    End Sub
End Class
