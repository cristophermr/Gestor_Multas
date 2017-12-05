Imports System.Data.OleDb
Imports _03Entidades
Public Class MultasAD
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProyectoLicencias.accdb")
    Public Sub New()

    End Sub
    Public Sub InsertarMultas(ByVal pMultas As MultasEN)
        Try
            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Multas(Codigo_Multa,Fecha_Multa,Nombre_Trafico,Monto_Multa,Ind_Pagada,Cedula)
                         VALUES (@Codigo_Multa,@Fecha_Multa,@Nombre_Trafico,@Monto_Multa,@Ind_Pagada,@Cedula)"

            Dim cmdMulta As New OleDbCommand(strInsert, miConexion)
            cmdMulta.Parameters.Add("@Codigo_Multa", OleDbType.VarChar).Value = pMultas.Codigo_Multa
            cmdMulta.Parameters.Add("@Fecha_Multa", OleDbType.VarChar).Value = pMultas.Fecha_Multa.ToShortDateString
            cmdMulta.Parameters.Add("@Nombre_Trafico", OleDbType.VarChar).Value = pMultas.Nombre_Trafico
            cmdMulta.Parameters.Add("@Monto_Multa", OleDbType.VarChar).Value = pMultas.Monto_Multa
            cmdMulta.Parameters.Add("@Ind_Pagada", OleDbType.Boolean).Value = pMultas.Ind_Pagada
            cmdMulta.Parameters.Add("@Cedula", OleDbType.Boolean).Value = pMultas.Cedula
            cmdMulta.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerMultasPorCodigo(ByVal pMultas As String) As MultasEN
        Try
            miConexion.Open()
            Dim myMulta As MultasEN = Nothing
            Dim strSelect As String
            strSelect = "SELECT Codigo_Multa,Fecha_Multa,Nombre_Trafico,Monto_Multa,Ind_Pagada,Cedula 
                         FROM Multas WHERE Codigo_Multa = @Codigo_Multa"

            Dim cmdMulta As New OleDbCommand(strSelect, miConexion)
            cmdMulta.Parameters.Add("@Codigo_Multa", OleDbType.VarChar).Value = pMultas

            Dim drMulta As OleDbDataReader = cmdMulta.ExecuteReader()

            While (drMulta.Read())
                myMulta = New MultasEN
                myMulta.Codigo_Multa = drMulta("Codigo_Multa")
                myMulta.Fecha_Multa = drMulta("Fecha_Multa")
                myMulta.Nombre_Trafico = drMulta("Nombre_Trafico")
                myMulta.Monto_Multa = drMulta("Monto_Multa")
                myMulta.Ind_Pagada = drMulta("Ind_Pagada")
                myMulta.Cedula = drMulta("Cedula")

            End While
            drMulta.Close()

            miConexion.Close()
            Return myMulta

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
    Public Sub ModificarMulta(ByVal pMultas As MultasEN)
        Try

            miConexion.Open()
            Dim strUpdate As String
            strUpdate = "UPDATE Multas SET Codigo_Multa=@Codigo_Multa,Fecha_Multa=@Fecha_Multa,Nombre_Trafico=@Nombre_Trafico,
                                                Monto_Multa=@Monto_Multa,Ind_Pagada=@Ind_Pagada, Cedula=@Cedula
                         WHERE Codigo_Multa=@Codigo_Multa"

            Dim cmdMulta As New OleDbCommand(strUpdate, miConexion)
            cmdMulta.Parameters.Add("@Codigo_Multa", OleDbType.VarChar).Value = pMultas.Codigo_Multa
            cmdMulta.Parameters.Add("@Fecha_Multa", OleDbType.VarChar).Value = pMultas.Fecha_Multa.ToShortDateString
            cmdMulta.Parameters.Add("@Nombre_Trafico", OleDbType.VarChar).Value = pMultas.Nombre_Trafico
            cmdMulta.Parameters.Add("@Monto_Multa", OleDbType.VarChar).Value = pMultas.Monto_Multa
            cmdMulta.Parameters.Add("@Ind_Pagada", OleDbType.Boolean).Value = pMultas.Ind_Pagada
            cmdMulta.Parameters.Add("@Cedula", OleDbType.Boolean).Value = pMultas.Cedula
            cmdMulta.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub BorrarMulta(ByVal pMultas As MultasEN)
        Try
            Dim SQL_DELETE_CLIENTE As String = "DELETE FROM Multas WHERE Codigo_Multa=@Codigo_Multa"
            miConexion.Open()
            Dim cmdMulta As New OleDbCommand(SQL_DELETE_CLIENTE, miConexion)
            cmdMulta.Parameters.Add("@Codigo_Multa", OleDbType.VarChar).Value = pMultas.Codigo_Multa
            cmdMulta.ExecuteNonQuery() ' Ejecuta la sentencia
            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then miConexion.Close()
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerTodasLasMultas() As List(Of MultasEN)
        Try
            Dim strSelect As String = "SELECT Codigo_Multa,Fecha_Multa,Nombre_Trafico,Monto_Multa,Ind_Pagada,Cedula
                                       FROM Multas"
            miConexion.Open()
            Dim cmdMulta As New OleDbCommand(strSelect, miConexion)
            Dim drMulta As OleDbDataReader
            drMulta = cmdMulta.ExecuteReader()
            Dim lstMultas As New List(Of MultasEN)

            While drMulta.Read
                Dim miUser As New MultasEN
                miUser.Codigo_Multa = drMulta("Codigo_Multa")
                miUser.Fecha_Multa = drMulta("Fecha_Multa")
                miUser.Nombre_Trafico = drMulta("Nombre_Trafico")
                miUser.Monto_Multa = drMulta("Monto_Multa")
                miUser.Ind_Pagada = drMulta("Ind_Pagada")
                miUser.Cedula = drMulta("Cedula")
                lstMultas.Add(miUser)
            End While
            drMulta.Close()
            miConexion.Close()
            Return lstMultas
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
