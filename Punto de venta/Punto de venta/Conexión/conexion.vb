Imports MySql.Data.MySqlClient
Public Class conexion
    Public Sub New()
        cnx.ConnectionString = "server=localhost; user=adminVentas; password=ventas; database=clase1"
        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open()
                'MsgBox("Sí")
            Catch ex As Exception
                MsgBox("No se pudo conectar a la base de datos")
                Throw New Exception("No se pudo establecer la conexión.", ex)
                'Finally
            End Try
        End If
    End Sub

    'SELECT
    Public Function objetoDataAdapter(ByVal query As String) As DataTable
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Try
            DA = New MySqlDataAdapter(query, cnx)
            DT = New DataTable
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
        End Try
        DT.Dispose()
    End Function

    'INSERT - UPDATE - DELETE
    Public Sub objetoCommand(ByVal strcmd As String)
        Dim query As New MySqlCommand(strcmd, cnx)
        Try
            query.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            query.Dispose()
        End Try
    End Sub

    'asdsd
    Function objetoDataReader(ByVal comando As String) As MySqlDataReader
        Dim cmd As New MySqlCommand(comando, cnx)
        Dim resultadoSQL As MySqlDataReader = cmd.ExecuteReader()
        Try
            Return resultadoSQL
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            cmd.Dispose()
        End Try
    End Function

    'asds
    Public Function objetoScalar(ByVal strcmd As String) As Object
        Dim sqlcmd As New MySqlCommand(strcmd, cnx)
        Try
            objetoScalar = sqlcmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function
End Class
