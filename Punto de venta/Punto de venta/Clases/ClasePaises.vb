Imports MySql.Data.MySqlClient
Public Class ClasePaises
    Private idPais As Integer
    Private nombre As String

    Public Sub New()
        idPais = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal idCarr As Integer, ByVal nuevoNombre As String)
        idPais = idCarr
        nombre = nuevoNombre
    End Sub

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

    Public Sub insertaPais()
        Dim strSql As String
        Dim xCnx As New conexion

        If idPais <> 0 And nombre <> "" Then
            strSql = "INSERT INTO paises VALUES(" & idPais & ",'" & nombre & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos del país", MsgBoxStyle.Critical)
        End If
        cnx.Close()
    End Sub

    Public Sub actualizaPais()
        Dim strSql As String
        Dim xCnx As New conexion

        If idPais <> 0 And nombre <> "" Then
            strSql = "UPDATE paises SET nombre='" & nombre & "' WHERE id_pais=" & idPais
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos del país", MsgBoxStyle.Critical)
        End If
        cnx.Close()
    End Sub

    Public Function consultaUnPais() As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM paises WHERE id_pais=" & idPais
        consultaUnPais = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_pais")) Then
                idPais = ""
            Else
                idPais = CStr(xDT.Rows(0)("id_pais"))
            End If
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombre = ""
            Else
                nombre = CStr(xDT.Rows(0)("nombre"))
                El_nombre = CStr(xDT.Rows(0)("nombre"))
            End If
            consultaUnPais = True
        End If
        cnx.Close()
    End Function

    Public Function consultaNombrePais() As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM paises WHERE nombre='" & nombre & "'"
        consultaNombrePais = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            If IsDBNull(xDT.Rows(0)("id_pais")) Then
                idPais = ""
            Else
                idPais = CStr(xDT.Rows(0)("id_pais"))
            End If
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombre = ""
            Else
                nombre = CStr(xDT.Rows(0)("nombre"))
                El_nombre = CStr(xDT.Rows(0)("nombre"))
            End If
            consultaNombrePais = True
        End If
        cnx.Close()
    End Function

    Public Function consultaMaxPais() As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT MAX(id_pais) AS IDMAX FROM paises"
        consultaMaxPais = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If (xDT.Rows.Count = 1) Then
            idPais = CStr(xDT.Rows(0)("IDMAX")) + 1
        Else
            idPais = 1
        End If
        consultaMaxPais = True
        cnx.Close()
    End Function

    Public Function consultaTodosPaises() As Object
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT id_pais AS ID, nombre AS País FROM paises ORDER BY nombre ASC"
        consultaTodosPaises = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub poblarDataGridPaises(ByVal DGVpaises As DataGridView)
        DGVpaises.DataSource = consultaTodosPaises()
        DGVpaises.Refresh()
        DGVpaises.Columns.Item(0).Width = 50
        DGVpaises.Columns.Item(1).Width = 100
    End Sub

    Public Sub poblarComboCarreras(ByVal objeto As ComboBox)
        Dim Lista As MySqlDataReader
        Dim strSql As String
        Dim xCnx As New conexion

        strSql = "SELECT nombre FROM paises ORDER BY nombre ASC"
        Lista = xCnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
        cnx.Close()
    End Sub

    Public Sub eliminaPais()
        Dim strSql As String
        Dim xCnx As New conexion

        If idPais > 0 And nombre <> "" Then
            strSql = "DELETE FROM paises WHERE id_pais=" & idPais
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos del país", MsgBoxStyle.Critical)
        End If
        cnx.Close()
    End Sub

    Public Function consultaUnEstado() As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM estados WHERE id_pais=" & idPais
        consultaUnEstado = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            consultaUnEstado = True
        End If
        cnx.Close()
    End Function
End Class
