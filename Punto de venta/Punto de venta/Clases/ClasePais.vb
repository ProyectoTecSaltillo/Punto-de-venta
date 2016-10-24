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
    Public Sub New(ByVal nuevoid As Integer)
        MyBase.New(nuevoid)
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
        strSql = "INSERT INTO " & pais & " (id_pais,nombre) VALUES(" & AutoIncrement(pais) & ",'" & nombre & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Overloads Function getNombre()
        Return MyBase.getNombre(pais)
    End Function

    Public Overloads Function getId()
        Return MyBase.getId(pais)
    End Function

    Public Overloads Function elimina()
        Return MyBase.elimina(pais)
    End Function
End Class
