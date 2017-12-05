Imports System.Data.OleDb
Imports _03Entidades
Public Class Tipos_LicenciasAD
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProyectoLicencias.accdb")
    Public Sub New()

    End Sub
    Public Sub InsertarTipos_Lic(ByVal pTipos_Lic As Tipos_LicenciasEN)
        Try
            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Tipos_Licencias(Codigo_Tipo_Licencia,Nombre_Tipo,Observaciones)
                         VALUES (@Codigo_Tipo_Licencia,@Nombre_Tipo,@Observaciones)"

            Dim cmdTipo As New OleDbCommand(strInsert, miConexion)
            cmdTipo.Parameters.Add("@Codigo_Tipo_Licencia", OleDbType.VarChar).Value = pTipos_Lic.Codigo_Tipo_Licencia
            cmdTipo.Parameters.Add("@Nombre_Tipo", OleDbType.VarChar).Value = pTipos_Lic.Nombre_Tipo
            cmdTipo.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pTipos_Lic.Observaciones
            cmdTipo.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerTipo_LicPorCodigo(ByVal pTipos_Lic As String) As Tipos_LicenciasEN
        Try
            miConexion.Open()
            Dim myTip_Lic As Tipos_LicenciasEN = Nothing
            Dim strSelect As String
            strSelect = "SELECT Codigo_Tipo_Licencia,Nombre_Tipo,Observaciones
                         FROM Tipos_Licencias WHERE Codigo_Tipo_Licencia = @Codigo_Tipo_Licencia"

            Dim cmdTipo As New OleDbCommand(strSelect, miConexion)
            cmdTipo.Parameters.Add("@Codigo_Tipo_Licencia", OleDbType.VarChar).Value = pTipos_Lic

            Dim drMulta As OleDbDataReader = cmdTipo.ExecuteReader()

            While (drMulta.Read())
                myTip_Lic = New Tipos_LicenciasEN
                myTip_Lic.Codigo_Tipo_Licencia = drMulta("Codigo_Tipo_Licencia")
                myTip_Lic.Nombre_Tipo = drMulta("Nombre_Tipo")
                myTip_Lic.Observaciones = drMulta("Observaciones")

            End While
            drMulta.Close()

            miConexion.Close()
            Return myTip_Lic

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
    Public Sub ModificarTip_Lic(ByVal pTipos_Lic As Tipos_LicenciasEN)
        Try

            miConexion.Open()
            Dim strUpdate As String
            strUpdate = "UPDATE Tipos_Licencias SET Codigo_Tipo_Licencia=@Codigo_Tipo_Licencia,Nombre_Tipo=@Nombre_Tipo,Observaciones=@Observaciones
                         WHERE Codigo_Tipo_Licencia=@Codigo_Tipo_Licencia"

            Dim cmdTipo As New OleDbCommand(strUpdate, miConexion)
            cmdTipo.Parameters.Add("@Codigo_Tipo_Licencia", OleDbType.VarChar).Value = pTipos_Lic.Codigo_Tipo_Licencia
            cmdTipo.Parameters.Add("@Nombre_Tipo", OleDbType.VarChar).Value = pTipos_Lic.Nombre_Tipo
            cmdTipo.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pTipos_Lic.Observaciones
            cmdTipo.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub BorrarTip_Lic(ByVal pTipos_Lic As Tipos_LicenciasEN)
        Try
            Dim SQL_DELETE_CLIENTE As String = "DELETE FROM Tipos_Licencias WHERE Codigo_Tipo_Licencia=@Codigo_Tipo_Licencia"
            miConexion.Open()
            Dim cmdTipo As New OleDbCommand(SQL_DELETE_CLIENTE, miConexion)
            cmdTipo.Parameters.Add("@Codigo_Tipo_Licencia", OleDbType.VarChar).Value = pTipos_Lic.Codigo_Tipo_Licencia
            cmdTipo.ExecuteNonQuery() ' Ejecuta la sentencia
            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then miConexion.Close()
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerTodosLosTip_Lic() As List(Of Tipos_LicenciasEN)
        Try
            Dim strSelect As String = "SELECT Codigo_Tipo_Licencia,Nombre_Tipo,Observaciones
                                       FROM Tipos_Licencias"
            miConexion.Open()
            Dim cmdTipo As New OleDbCommand(strSelect, miConexion)
            Dim drMulta As OleDbDataReader
            drMulta = cmdTipo.ExecuteReader()
            Dim lstTip_Lic As New List(Of Tipos_LicenciasEN)

            While drMulta.Read
                Dim miUser As New Tipos_LicenciasEN
                miUser.Codigo_Tipo_Licencia = drMulta("Codigo_Tipo_Licencia")
                miUser.Nombre_Tipo = drMulta("Nombre_Tipo")
                miUser.Observaciones = drMulta("Observaciones")
                lstTip_Lic.Add(miUser)
            End While
            drMulta.Close()
            miConexion.Close()
            Return lstTip_Lic
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
