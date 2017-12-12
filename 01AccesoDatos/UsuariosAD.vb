Imports System.Data.OleDb
Imports _03Entidades
Public Class UsuariosAD
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProyectoLicencias.accdb")
    Public Sub New()

    End Sub
    Public Sub InsertarUsuarios(ByVal pUsuarios As UsuariosEN)
        Try
            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Usuarios(Login,Nom_Completo,Contraseña,Ind_Administrador,Ind_Digitador)
                         VALUES (@Login,@Nom_Completo,@Contraseña,@Ind_Administrador,@Ind_Digitador)"

            Dim cmdUsuario As New OleDbCommand(strInsert, miConexion)
            cmdUsuario.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuarios.Login
            cmdUsuario.Parameters.Add("@Nom_Completo", OleDbType.VarChar).Value = pUsuarios.Nom_Completo
            cmdUsuario.Parameters.Add("@Contraseña", OleDbType.VarChar).Value = pUsuarios.Contraseña
            cmdUsuario.Parameters.Add("@Ind_Administrador", OleDbType.VarChar).Value = pUsuarios.Ind_Admin
            cmdUsuario.Parameters.Add("@Ind_Digitador", OleDbType.Boolean).Value = pUsuarios.Ind_Digita
            cmdUsuario.ExecuteNonQuery()

            miConexion.Close()

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerUsuarioPorLogin(ByVal pUsuarios As String) As UsuariosEN
        Try
            miConexion.Open()
            Dim MyUser As UsuariosEN = Nothing
            Dim strSelect As String
            strSelect = "SELECT Login,Nom_Completo,Contraseña,Ind_Administrador,Ind_Digitador 
                         FROM Usuarios WHERE Login = @Login"

            Dim cmdUsuario As New OleDbCommand(strSelect, miConexion)
            cmdUsuario.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuarios

            Dim drUsuario As OleDbDataReader = cmdUsuario.ExecuteReader()

            While (drUsuario.Read())
                MyUser = New UsuariosEN
                MyUser.Login = drUsuario("Login")
                MyUser.Nom_Completo = drUsuario("Nom_Completo")
                MyUser.Contraseña = drUsuario("Contraseña")
                MyUser.Ind_Admin = drUsuario("Ind_Administrador")
                MyUser.Ind_Digita = drUsuario("Ind_Digitador")
            End While
            drUsuario.Close()

            miConexion.Close()
            Return MyUser

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
    Public Sub ModificarUsuario(ByVal pUsuarios As UsuariosEN)
        Try

            miConexion.Open()
            Dim strUpdate As String
            strUpdate = "UPDATE Usuarios SET Login=@Login,Nom_Completo=@Nom_Completo,Contraseña=@Contraseña,
                                                Ind_Administrador=@Ind_Administrador,Ind_Digitador=@Ind_Digitador
                         WHERE Login=@Login"

            Dim cmdUsuario As New OleDbCommand(strUpdate, miConexion)

            cmdUsuario.Parameters.Add("@Login", OleDbType.VarChar).Value = pUsuarios.Login
            cmdUsuario.Parameters.Add("@Nom_Completo", OleDbType.VarChar).Value = pUsuarios.Nom_Completo
            cmdUsuario.Parameters.Add("@Contraseña", OleDbType.VarChar).Value = pUsuarios.Contraseña
            cmdUsuario.Parameters.Add("@Ind_Administrador", OleDbType.VarChar).Value = pUsuarios.Ind_Admin
            cmdUsuario.Parameters.Add("@Ind_Digitador", OleDbType.Boolean).Value = pUsuarios.Ind_Digita
            cmdUsuario.ExecuteNonQuery()

            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub BorrarUsuario(ByVal pUsuarios As UsuariosEN)
        Try
            Dim SQL_DELETE_CLIENTE As String = "DELETE FROM Usuarios WHERE Login=@Login"
            miConexion.Open()
            Dim cmdUsuario As New OleDbCommand(SQL_DELETE_CLIENTE, miConexion)
            cmdUsuario.Parameters.Add("@Cod_Licencia", OleDbType.VarChar).Value = pUsuarios.Login
            cmdUsuario.ExecuteNonQuery() ' Ejecuta la sentencia
            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then miConexion.Close()
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerTodosLosUsuarios() As List(Of UsuariosEN)
        Try
            Dim strSelect As String = "SELECT Login,Nom_Completo,Contraseña,Ind_Administrador,Ind_Digitador
                                       FROM Usuarios"
            miConexion.Open()
            Dim cmdUsuario As New OleDbCommand(strSelect, miConexion)
            Dim drUsuario As OleDbDataReader
            drUsuario = cmdUsuario.ExecuteReader()
            Dim lstUsuarios As New List(Of UsuariosEN)

            While drUsuario.Read
                Dim miUser As New UsuariosEN
                miUser.Login = drUsuario("Login")
                miUser.Nom_Completo = drUsuario("Nom_Completo")
                miUser.Contraseña = drUsuario("Contraseña")
                miUser.Ind_Admin = drUsuario("Ind_Administrador")
                miUser.Ind_Digita = drUsuario("Ind_Digitador")
                lstUsuarios.Add(miUser)
            End While
            drUsuario.Close()
            miConexion.Close()
            Return lstUsuarios
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
