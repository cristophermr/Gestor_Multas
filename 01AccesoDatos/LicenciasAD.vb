Imports System.Data.OleDb
Imports _03Entidades
Public Class LicenciasAD
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProyectoLicencias.accdb")
    Public Sub New()

    End Sub
    Public Sub InsertarLicencias(ByVal pLicencias As LicenciasEN)
        Try
            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Licencias(Cod_Licencia,Cedula,Puntos,Fec_Emision,Fec_Vencimiento,Codigo_Tipo_Licencia)
                         VALUES (@Cod_Licencia,@Cedula,@Puntos,@Fec_Emision,@Fec_Vencimiento,@Codigo_Tipo_Licencia)"

            Dim cmdLicencia As New OleDbCommand(strInsert, miConexion)
            cmdLicencia.Parameters.Add("@Cod_Licencia", OleDbType.VarChar).Value = pLicencias.Cod_Licencia
            cmdLicencia.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pLicencias.Cedula
            cmdLicencia.Parameters.Add("@Puntos", OleDbType.VarChar).Value = pLicencias.Puntos
            cmdLicencia.Parameters.Add("@Fec_Emision", OleDbType.VarChar).Value = pLicencias.Fec_Emision.ToShortDateString
            cmdLicencia.Parameters.Add("@Fec_Vencimiento", OleDbType.Boolean).Value = pLicencias.Fec_Vencimiento.ToShortDateString
            cmdLicencia.Parameters.Add("@Codigo_Tipo_Licencia", OleDbType.Boolean).Value = pLicencias.Codigo_Tipo_Licencia
            cmdLicencia.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerLicenciaPorCodigo(ByVal pLicencias As String) As LicenciasEN
        Try
            miConexion.Open()
            Dim myLicencia As LicenciasEN = Nothing
            Dim strSelect As String
            strSelect = "SELECT Cod_Licencia,Cedula,Puntos,Fec_Emision,Fec_Vencimiento,Codigo_Tipo_Licencia 
                         FROM Licencias WHERE Cod_Licencia = @Cod_Licencia"

            Dim cmdLicencia As New OleDbCommand(strSelect, miConexion)
            cmdLicencia.Parameters.Add("@Cod_Licencia", OleDbType.VarChar).Value = pLicencias

            Dim drLicencia As OleDbDataReader = cmdLicencia.ExecuteReader()

            While (drLicencia.Read())
                myLicencia = New LicenciasEN
                myLicencia.Cod_Licencia = drLicencia("Cod_Licencia")
                myLicencia.Cedula = drLicencia("Cedula")
                myLicencia.Puntos = drLicencia("Puntos")
                myLicencia.Fec_Emision = drLicencia("Fec_Emision")
                myLicencia.Fec_Vencimiento = drLicencia("Fec_Vencimiento")
                myLicencia.Codigo_Tipo_Licencia = drLicencia("Codigo_Tipo_Licencia")

            End While
            drLicencia.Close()

            miConexion.Close()
            Return myLicencia

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
    Public Sub ModificarLicencia(ByVal pLicencias As LicenciasEN)
        Try

            miConexion.Open()
            Dim strUpdate As String
            strUpdate = "UPDATE Licencias SET Cod_Licencia=@Cod_Licencia,Cedula=@Cedula,Puntos=@Puntos,
                                                Fec_Emision=@Fec_Emision,Fec_Vencimiento=@Fec_Vencimiento, Codigo_Tipo_Licencia=@Codigo_Tipo_Licencia
                         WHERE Cod_Licencia=@Cod_Licencia"

            Dim cmdLicencia As New OleDbCommand(strUpdate, miConexion)

            cmdLicencia.Parameters.Add("@Cod_Licencia", OleDbType.VarChar).Value = pLicencias.Cod_Licencia
            cmdLicencia.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pLicencias.Cedula
            cmdLicencia.Parameters.Add("@Puntos", OleDbType.VarChar).Value = pLicencias.Puntos
            cmdLicencia.Parameters.Add("@Fec_Emision", OleDbType.VarChar).Value = pLicencias.Fec_Emision
            cmdLicencia.Parameters.Add("@Fec_Vencimiento", OleDbType.Boolean).Value = pLicencias.Fec_Vencimiento
            cmdLicencia.Parameters.Add("@Codigo_Tipo_Licencia", OleDbType.Boolean).Value = pLicencias.Codigo_Tipo_Licencia
            cmdLicencia.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub BorrarLicencia(ByVal pLicencias As LicenciasEN)
        Try
            Dim SQL_DELETE_CLIENTE As String = "DELETE FROM Licencias WHERE Cod_Licencia=@Cod_Licencia"
            miConexion.Open()
            Dim cmdLicencia As New OleDbCommand(SQL_DELETE_CLIENTE, miConexion)
            cmdLicencia.Parameters.Add("@Cod_Licencia", OleDbType.VarChar).Value = pLicencias.Cod_Licencia
            cmdLicencia.ExecuteNonQuery() ' Ejecuta la sentencia
            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then miConexion.Close()
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerTodasLasLicencias() As List(Of LicenciasEN)
        Try
            Dim strSelect As String = "SELECT Cod_Licencia,Cedula,Puntos,Fec_Emision,Fec_Vencimiento,Codigo_Tipo_Licencia
                                       FROM Licencias"
            miConexion.Open()
            Dim cmdLicencia As New OleDbCommand(strSelect, miConexion)
            Dim drLicencia As OleDbDataReader
            drLicencia = cmdLicencia.ExecuteReader()
            Dim lstLicencias As New List(Of LicenciasEN)

            While drLicencia.Read
                Dim miUser As New LicenciasEN
                miUser.Cod_Licencia = drLicencia("Cod_Licencia")
                miUser.Cedula = drLicencia("Cedula")
                miUser.Puntos = drLicencia("Puntos")
                miUser.Fec_Emision = drLicencia("Fec_Emision")
                miUser.Fec_Vencimiento = drLicencia("Fec_Vencimiento")
                miUser.Codigo_Tipo_Licencia = drLicencia("Codigo_Tipo_Licencia")
                lstLicencias.Add(miUser)
            End While
            drLicencia.Close()
            miConexion.Close()
            Return lstLicencias
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
