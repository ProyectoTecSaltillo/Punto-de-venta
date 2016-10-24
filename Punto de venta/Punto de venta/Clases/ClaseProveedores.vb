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
        id_proveedor = ""
        razonSocial = ""
        pais = ""
        estado = ""
        ciudad = ""
        colonia = ""
        nombre = ""
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

    Public Sub PoblarDataGridProveedores(ByVal DGVproveedores As DataGridView)
        DGVproveedores.DataSource = consultaTodosProveedores()
        DGVproveedores.Refresh()

    End Sub
    Public Function consultaTodosProveedores() As Object
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT id_proveedor, razon social, correo, nombre, telefono, telefono_representante, paises.nombre as Pais, estados.nombre as Estado, ciudades.nombre as Ciudad, colonias.nombre as Colonia," &
            "correo , telefono, telefono_representante from " &
            "paises, estados, ciudades, colonias, proveedores where " &
            "paises.id_pais = estados.id_pais and estados.id_pais = ciudades.id_pais and estados.id_estado = ciudades.id_estado and ciudades.id_pais = colonias.id_pais and " &
            "ciudades.id_Estado = colonias.id_estado and ciudades.id_ciudad = colonias.id_ciudad and colonias.id_pais = proveedores.id_pais and colonias.id_estado = proveedores.id_Estado and " &
            "colonias.id_ciudad = proveedores.id_ciudad and colonias.id_colonia= proveedores.id_colonia order by id_proveedor asc"
        consultaTodosProveedores = xCnx.objetoDataAdapter(strSQL)
    End Function
    Public Sub eliminaProveedor()
        Dim strSql As String
        Dim xCnx As New conexion

        If id_proveedor <> "" And razonSocial <> "" And pais <> "" And estado <> "" And ciudad <> "" And colonia <> "" And
            nombre <> "" And correo <> "" And telefono <> "" And tel_repr <> "" Then
            strSql = "DELETE FROM proveedores WHERE id_proveedor='" & id_proveedor & "' and id_pais=(select id_pais from paises where nombre='" & pais & "') and id_estado=(select id_estado from paises p, estados e where p.id_pais= e.id_pais and p.nombre='" & pais & "' and e.nombre='" & estado & "') and " &
                     "id_ciudad=(select id_ciudad from paises, estados, ciudades where paises.id_pais = estados.id_pais and estados.id_pais = ciudades.id_pais and estados.id_estado = ciudades.id_estado and paises.nombre='" & pais & "' and estados.nombre='" & estado & "' and ciudades.nombre= '" & ciudad & "') and id_colonia=(select id_colonia from paises, estados, ciudades, colonias where paises.id_pais = estados.id_pais and estados.id_pais = ciudades.id_pais and estados.id_estado = ciudades.id_estado and ciudades.id_pais = colonias.id_pais and ciudades.id_estado = colonias.id_estado and ciudades.id_ciudad = colonias.id_ciudad and paises.nombre='" & pais & "' and estados.nombre='" & estado & "' and ciudades.nombre= '" & ciudad & "' and colonia.nombre='" & colonia & "') " &
                     "and nombre='" & nombre & "' " &
                " and correo= '" & correo & "' and telefono= '" & telefono & "' and  telefono_representante='" & tel_repr


            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro Eliminado")
        Else
            MsgBox("Faltan datos del proveedor!!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function consultaUnProveedor() As Boolean
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM proveedores " &
                 "WHERE id_proveedor='" & id_proveedor & "'"

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
    End Function

    Public Sub insertaProveedor()
        Dim strSql As String
        Dim xCnx As New conexion


        If id_proveedor <> "" And razonSocial <> "" And pais <> "" And estado <> "" And ciudad <> "" And colonia <> "" And
         nombre <> "" And correo <> "" And telefono <> "" And tel_repr <> "" Then
            'Realiza inserción de datos
            strSql = "INSERT INTO proveedores " &
                     "VALUES('" & id_proveedor & "',(select id_pais from paises where nombre='" & pais & "'),(select id_estado from paises p, estados e where p.id_pais= e.id_pais and p.nombre='" & pais & "' and e.nombre='" & estado & "')," &
                     "(select id_ciudad from paises, estados, ciudades where paises.id_pais = estados.id_pais and estados.id_pais = ciudades.id_pais and estados.id_estado = ciudades.id_estado and paises.nombre='" & pais & "' and estados.nombre='" & estado & "' and ciudades.nombre= '" & ciudad & "'),(select id_colonia from paises, estados, ciudades, colonias where paises.id_pais = estados.id_pais and estados.id_pais = ciudades.id_pais and estados.id_estado = ciudades.id_estado and ciudades.id_pais = colonias.id_pais and ciudades.id_estado = colonias.id_estado and ciudades.id_ciudad = colonias.id_ciudad and paises.nombre='" & pais & "' and estados.nombre='" & estado & "' and ciudades.nombre= '" & ciudad & "' and colonias.nombre='" & colonia & "')," &
                     "'" & nombre & "','" & correo & "','" & telefono & "','" & tel_repr & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos del proveedor!!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
    Public Sub actualizaProveedor()
        Dim strSql As String
        Dim xCnx As New conexion

        If id_proveedor <> "" And razonSocial <> "" And pais <> "" And estado <> "" And ciudad <> "" And colonia <> "" And
           nombre <> "" And correo <> "" And telefono <> "" And tel_repr <> "" Then
            strSql = "UPDATE proveedores set id_proveedor='" & id_proveedor & "',id_pais=(select id_pais from paises where nombre='" & pais & "'), id_estado=(select id_estado from paises, estados where paises.id_pais= estados.id_pais and paises.nombre='" & pais & "' and estados.nombre='" & estado & "')," &
                     "id_ciudad = ( select id_ciudad from paises, estados, ciudades where paises.id_pais = estados.id_pais and estados.id_pais = ciudades.id_pais and estados.id_estado = ciudades.id_estado and paises.nombre='" & pais & "' and estados.nombre='" & estado & "' and ciudades.nombre= '" & ciudad & "'), id_colonia = (select id_colonia from paises, estados, ciudades, colonias where paises.id_pais = estados.id_pais and estados.id_pais = ciudades.id_pais and estados.id_estado = ciudades.id_estado and ciudades.id_pais = colonias.id_pais and ciudades.id_estado = colonias.id_estado and ciudades.id_ciudad = colonias.id_ciudad and paises.nombre='" & pais & "' and estados.nombre='" & estado & "' and ciudades.nombre= '" & ciudad & "' and colonias.nombre='" & colonia & "')" &
                     ", nombre='" & nombre & "', " &
                "correo='" & correo & "',telefono='" & telefono & "',telefono_representante='" & tel_repr & "' where id_proveedor='" & id_proveedor & "'"

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos del proveedor!!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class
