Imports MySql.Data.MySqlClient
Public Class ClasePais
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

        strSQL = "SELECT nombre AS País FROM paises ORDER BY nombre ASC;"
        consultaTodos = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Sub poblarCombo(ByVal ComboP As ComboBox)
        Dim ds As DataTable
        ds = consultaTodos()
        ComboP.ValueMember = ds.Columns(0).ToString()
        ComboP.DataSource = ds
        ComboP.Refresh()
    End Sub

    Public Sub inserta()
        Dim strSql As String
        Dim xCnx As New conexion
        strSql = "INSERT INTO " & pais & " (nombre) VALUES('" & nombre & "');"
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
End Class
