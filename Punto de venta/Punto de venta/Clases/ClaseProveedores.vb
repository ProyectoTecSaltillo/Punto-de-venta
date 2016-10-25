Public Class ClaseProveedores
    Private id_proveedor As String
    Private razonSocial As String
    Private pais As String
    Private estado As String
    Private ciudad As String
    Private colonia As String
    Private nombre As String
    Private correo As String
    Private telefono As String
    Private tel_repr As String

    Public Sub New()
        Dim pro As New ClasePrinc
        id_proveedor = pro.getId(proveedores)
        razonSocial = ""
        pais = ""
        estado = ""
        ciudad = ""
        colonia = ""
        nombre = pro.getSetNombre
        correo = ""
        telefono = ""
        tel_repr = ""
    End Sub
    Public Sub New(ByVal n_id_proveedor As String, ByVal n_razon As String, ByVal n_pais As String, ByVal n_estado As String, ByVal n_ciudad As String, ByVal n_colonia As String,
                   ByVal n_nombre As String, ByVal n_correo As String, ByVal n_telefono As String, ByVal n_tel_repr As String)
        id_proveedor = n_id_proveedor
        razonSocial = n_razon
        pais = n_pais
        estado = n_estado
        ciudad = n_ciudad
        colonia = n_colonia
        nombre = n_nombre
        correo = n_correo
        telefono = n_telefono
        tel_repr = n_tel_repr
    End Sub

    Public Property getSetId_proveedor() As String
        Get
            Return id_proveedor
        End Get
        Set(ByVal Value As String)
            id_proveedor = Value
        End Set
    End Property
    Public Property getSetRazonSocial() As String
        Get
            Return razonSocial
        End Get
        Set(ByVal Value As String)
            razonSocial = Value
        End Set
    End Property
    Public Property getSetPais() As String
        Get
            Return pais
        End Get
        Set(ByVal Value As String)
            pais = Value
        End Set
    End Property
    Public Property getSetEstado() As String
        Get
            Return estado
        End Get
        Set(ByVal Value As String)
            estado = Value
        End Set
    End Property
    Public Property getSetCiudad() As String
        Get
            Return ciudad
        End Get
        Set(ByVal Value As String)
            ciudad = Value
        End Set
    End Property
    Public Property getSetColonia() As String
        Get
            Return colonia
        End Get
        Set(ByVal Value As String)
            colonia = Value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property

    Public Property getSetCorreo() As String
        Get
            Return correo
        End Get
        Set(ByVal Value As String)
            correo = Value
        End Set
    End Property
    Public Property getSetTelefono() As String
        Get
            Return telefono
        End Get
        Set(ByVal Value As String)
            telefono = Value
        End Set
    End Property
    Public Property getSetTelefonoRepresentante() As String
        Get
            Return tel_repr
        End Get
        Set(ByVal Value As String)
            tel_repr = Value
        End Set
    End Property
    Public Function consultaTodosProveedores() As Object
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT * from proveedores order by id_proveedor asc"
        consultaTodosProveedores = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub PoblarDataGridProveedores(ByVal DGVproveedores As DataGridView)
        DGVproveedores.DataSource = consultaTodosProveedores()
        DGVproveedores.Refresh()
        cnx.Close()

    End Sub

    Public Sub eliminaProveedor()
        Dim strSql As String
        Dim xCnx As New conexion
        If id_proveedor <> "" And razonSocial <> "" And telefono <> "" And correo <> "" And pais <> "" And estado <> "" And ciudad <> "" And colonia <> "" And
         nombre <> "" And tel_repr <> "" Then

            strSql = "Delete from proveedores where id_proveedor=" & id_proveedor
            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro Eliminado")
        Else
            MsgBox("Faltan datos del proveedor!!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
        cnx.Close()

    End Sub

    Public Function consultaUnProveedor() As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "select * from proveedores where id_proveedor =" & idProveedor

        consultaUnProveedor = False

        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then

            If IsDBNull(xDT.Rows(0)("id_proveedor")) Then
                id_proveedor = ""
            Else
                id_proveedor = CStr(xDT.Rows(0)("id_proveedor"))

            End If

            consultaUnProveedor = True

        End If
        cnx.Close()
    End Function

    Public Sub insertaProveedor()
        Dim strSql As String
        Dim xCnx As New conexion
        Dim pr As New ClasePrinc

        id_proveedor = pr.AutoIncrement(proveedores)


        If id_proveedor <> "" And razonSocial <> "" And telefono <> "" And correo <> "" And idPais <> "" And idEstado <> "" And idCiudad <> "" And idColonia <> "" And
         nombre <> "" And tel_repr <> "" Then
            'Realiza inserción de dato
            strSql = "insert into proveedores(id_proveedor, id_pais, id_estado, id_ciudad, id_colonia, razon_social, nombre_representante, correo, telefono, telefono_representante)" &
                " values (" & id_proveedor & "," & idPais & "," & idEstado & "," & idCiudad & "," & idColonia & "," & razonSocial & "," & nombre & ", " & correo & ", " & telefono & ", " & tel_repr & ")"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos del proveedor!!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
        cnx.Close()
    End Sub
    Public Sub actualizaProveedor()
        Dim strSql As String
        Dim xCnx As New conexion

        If id_proveedor <> "" And razonSocial <> "" And telefono <> "" And correo <> "" And idPais <> "" And idEstado <> "" And idCiudad <> "" And idColonia <> "" And
         nombre <> "" And tel_repr <> "" Then

            strSql = "UPDATE proveedores set id_proveedor='" & id_proveedor & "',id_pais=" & idPais & ",id_estado=" & idEstado & ",id_ciudad=" & idCiudad & ",id_colonia=" & idColonia & ", razon_social=" & razonSocial & ", nombre=" & nombre & ", correo=" & correo & ",telefono=" & telefono & ", telefono_representante=" & tel_repr & "
            where id_proveedor='" & id_proveedor & "'"

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos del proveedor!!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
        cnx.Close()
    End Sub
    Public Sub PoblamCmBxPais(ByVal CmbBxPais As ComboBox)
        Dim strSql As String
        Dim xCnx As New conexion

        strSql = "select id_pais, nombre from paises"
        CmbBxPais.DataSource = xCnx.objetoDataAdapter(strSql)

        CmbBxPais.DisplayMember = "nombre"
        CmbBxPais.ValueMember = "id_pais"
        CmbBxPais.Refresh()
    End Sub
    Public Sub PoblamCmBxEstado(ByVal CmbBxEstado As ComboBox, ByVal idPais As Integer)
        Dim strSql As String
        Dim xCnx As New conexion

        strSql = "select id_estado, nombre from estados where id_pais='" & idPais
        CmbBxEstado.DataSource = xCnx.objetoDataAdapter(strSql)

        CmbBxEstado.DisplayMember = "nombre"
        CmbBxEstado.ValueMember = "id_estado"
        CmbBxEstado.Refresh()
    End Sub
    Public Sub PoblamCmBxCiudades(ByVal CmbBxCiudades As ComboBox, ByVal idPais As Integer, ByVal idEstado As Integer)
        Dim strSql As String
        Dim xCnx As New conexion

        strSql = "select id_ciudad, nombre from estados where id_pais='" & idPais & "and id_estado=" & idEstado
        CmbBxCiudades.DataSource = xCnx.objetoDataAdapter(strSql)

        CmbBxCiudades.DisplayMember = "nombre"
        CmbBxCiudades.ValueMember = "id_ciudad"
        CmbBxCiudades.Refresh()
    End Sub
    Public Sub PoblaCmBxColonias(ByVal CmbBxColonias As ComboBox, ByVal idPais As Integer, ByVal idEstado As Integer, ByVal idCiudad As Integer)
        Dim strSql As String
        Dim xCnx As New conexion

        strSql = "select id_ciudad, nombre from estados where id_pais='" & idPais & "and id_estado=" & idEstado & "and id_ciudad=" & idCiudad
        CmbBxColonias.DataSource = xCnx.objetoDataAdapter(strSql)

        CmbBxColonias.DisplayMember = "nombre"
        CmbBxColonias.ValueMember = "id_ciudad"
        CmbBxColonias.Refresh()
    End Sub
End Class
