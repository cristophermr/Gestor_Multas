Imports System.Data.OleDb
Imports _03Entidades

Public Class ConductoresAD
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProyectoLicencias.accdb")
    Public Sub New()

    End Sub
    Public Sub InsertarConductores(ByVal pConductor As ConductoresEN)


        Try
            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Conductores(Cedula,NombreCompleto,Tel_Celular,Tel_Casa,Fec_Nacimiento,E_Mail,Dir_Completa,Observaciones,Ind_Activo)
                         VALUES (@Cedula,@NombreCompleto,@Tel_Celular,@Tel_Casa,@Fec_Nacimiento,@E_Mail,@Dir_Completa,@Observaciones,@Ind_Activo)"

            Dim cmdConductor As New OleDbCommand(strInsert, miConexion)
            cmdConductor.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pConductor.Cedula
            cmdConductor.Parameters.Add("@NombreCompleto", OleDbType.VarChar).Value = pConductor.NombreCompleto
            cmdConductor.Parameters.Add("@Tel_Celular", OleDbType.VarChar).Value = pConductor.Tel_Celular
            cmdConductor.Parameters.Add("@Tel_Casa", OleDbType.VarChar).Value = pConductor.Tel_Casa
            cmdConductor.Parameters.Add("@Fec_Nacimiento", OleDbType.Date).Value = pConductor.Fecha_Nacimiento.ToShortDateString
            cmdConductor.Parameters.Add("@E_Mail", OleDbType.VarChar).Value = pConductor.E_Mail
            cmdConductor.Parameters.Add("@Dir_Completa", OleDbType.VarChar).Value = pConductor.Dir_Completa
            cmdConductor.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pConductor.Observaciones
            cmdConductor.Parameters.Add("@Ind_Activo", OleDbType.Boolean).Value = pConductor.Ind_Activo
            cmdConductor.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerConductorPorCedula(ByVal pConductor As String) As ConductoresEN
        Try
            miConexion.Open()
            Dim myConductor As ConductoresEN = Nothing
            Dim strSelect As String
            strSelect = "SELECT Cedula,NombreCompleto,Tel_Celular,Tel_Casa,Fec_Nacimiento,E_Mail,Dir_Completa,Observaciones,Ind_Activo 
                         FROM Conductores WHERE Cedula = @Cedula"

            Dim cmdConductor As New OleDbCommand(strSelect, miConexion)
            cmdConductor.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pConductor

            Dim drConductor As OleDbDataReader = cmdConductor.ExecuteReader()

            While (drConductor.Read())
                myConductor = New ConductoresEN
                myConductor.Cedula = drConductor("Cedula")
                myConductor.NombreCompleto = drConductor("NombreCompleto")
                myConductor.Tel_Celular = drConductor("Tel_Celular")
                myConductor.Tel_Casa = drConductor("Tel_Casa")
                myConductor.Fecha_Nacimiento = drConductor("Fec_Nacimiento")
                myConductor.E_Mail = drConductor("E_Mail")
                myConductor.Dir_Completa = drConductor("Dir_Completa")
                myConductor.Observaciones = drConductor("Observaciones")
                myConductor.Ind_Activo = drConductor("Ind_Activo")

            End While
            drConductor.Close()

            miConexion.Close()
            Return myConductor

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
    Public Sub ModificarConductor(ByVal pConductor As ConductoresEN)
        Try

            miConexion.Open()
            Dim strUpdate As String
            strUpdate = "UPDATE Conductores SET Cedula=@Cedula,NombreCompleto=@NombreCompleto,Tel_Celular=@Tel_Celular,Tel_Casa=@Tel_Casa,Fec_Nacimiento=@Fec_Nacimiento,
                                            E_Mail=@E_Mail,Dir_Completa=@Dir_Completa,Observaciones=@Observaciones,Ind_Activo=@Ind_Activo
                         WHERE Cedula=@Cedula"

            Dim cmdConductor As New OleDbCommand(strUpdate, miConexion)

            cmdConductor.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pConductor.Cedula
            cmdConductor.Parameters.Add("@NombreCompleto", OleDbType.VarChar).Value = pConductor.NombreCompleto
            cmdConductor.Parameters.Add("@Tel_Celular", OleDbType.VarChar).Value = pConductor.Tel_Celular
            cmdConductor.Parameters.Add("@Tel_Casa", OleDbType.VarChar).Value = pConductor.Tel_Casa
            cmdConductor.Parameters.Add("@Fec_Nacimiento", OleDbType.Date).Value = pConductor.Fecha_Nacimiento
            cmdConductor.Parameters.Add("@E_Mail", OleDbType.VarChar).Value = pConductor.E_Mail
            cmdConductor.Parameters.Add("@Dir_Completa", OleDbType.VarChar).Value = pConductor.Dir_Completa
            cmdConductor.Parameters.Add("@Observaciones", OleDbType.VarChar).Value = pConductor.Observaciones
            cmdConductor.Parameters.Add("@Ind_Activo", OleDbType.Boolean).Value = pConductor.Ind_Activo
            cmdConductor.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub BorrarConductor(ByVal pConductor As ConductoresEN)
        Try
            Dim SQL_DELETE_CLIENTE As String = "DELETE FROM Conductores WHERE Cedula=@Cedula"
            miConexion.Open()
            Dim cmdConductor As New OleDbCommand(SQL_DELETE_CLIENTE, miConexion)
            cmdConductor.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pConductor.Cedula
            cmdConductor.ExecuteNonQuery() ' Ejecuta la sentencia
            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then miConexion.Close()
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerTodosLosConductores() As List(Of ConductoresEN)
        Try
            Dim strSelect As String = "SELECT Cedula,NombreCompleto,Tel_Celular,Tel_Casa,Fec_Nacimiento,E_Mail,Dir_Completa,Observaciones,Ind_Activo
                                       FROM Conductores"
            miConexion.Open()
            Dim cmdConductor As New OleDbCommand(strSelect, miConexion)
            Dim drConductor As OleDbDataReader
            drConductor = cmdConductor.ExecuteReader()
            Dim lstConductores As New List(Of ConductoresEN)

            While drConductor.Read
                Dim miUser As New ConductoresEN
                miUser.Cedula = drConductor("Num_Cliente")
                miUser.NombreCompleto = drConductor("Nombre")
                miUser.Tel_Celular = drConductor("Telefono")
                miUser.Tel_Casa = drConductor("Direccion")
                miUser.Fecha_Nacimiento = drConductor("Indicador_Empresa")
                miUser.E_Mail = drConductor("Indicador_Persona")
                miUser.Dir_Completa = drConductor("Cedula_Juridica")
                miUser.Observaciones = drConductor("Cedula_Juridica")
                miUser.Ind_Activo = drConductor("Cedula_Juridica")
                lstConductores.Add(miUser)
            End While
            drConductor.Close()
            miConexion.Close()
            Return lstConductores
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
