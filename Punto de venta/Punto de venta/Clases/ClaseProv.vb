Public Class ClaseProv
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

    Public Overloads Function getNombre()
        Return MyBase.getNombre(proveedores)
    End Function

    Public Overloads Function getId()
        Return MyBase.getId(proveedores)
    End Function

    Public Function consultaTodos() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT nombre_representante AS nombre FROM proveedores ORDER BY nombre ASC;"
        consultaTodos = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub poblarComboProveedores(ByVal ComboProv As ComboBox)
        Dim ds As DataTable
        ds = consultaTodos()
        ComboProv.ValueMember = ds.Columns(0).ToString()
        ComboProv.DataSource = ds
        ComboProv.Refresh()
    End Sub

    Public Function consultaProveedoresID() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT id_proveedor FROM proveedores;"
        consultaProveedoresID = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub poblarComboIDP(ByVal ComboIDP As ComboBox)
        Dim ds As DataTable
        ds = consultaProveedoresID()
        ComboIDP.ValueMember = ds.Columns(0).ToString()
        ComboIDP.DataSource = ds
        ComboIDP.Refresh()
    End Sub
End Class
