Imports _01AccesoDatos
Imports _03Entidades
Public Class UsuariosLN
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub
    Public Sub InsertarUsuario(ByVal pUsuarios As UsuariosEN)
        Try
            'Login'
            If (pUsuarios.Login.Trim().Length = 0) Then
                Throw New Exception("El login es Obligatorio")
            ElseIf (pUsuarios.Login.Trim().Length > 10) Then
                Throw New Exception("El login debe tener maximo 10 caracteres")
            ElseIf String.IsNullOrEmpty(pUsuarios.Login) Then
                Throw New Exception("El login es obligatorio")
                'Nombre Completo'
            ElseIf (pUsuarios.Nom_Completo.Trim().Length = 0) Then
                Throw New Exception("El Nombre es Obligatorio")
            ElseIf String.IsNullOrEmpty(pUsuarios.Nom_Completo) Then
                Throw New Exception("El Nombre es Obligatorio")
                'Contraseña'
            ElseIf (pUsuarios.Contraseña = 0) Then
                Throw New Exception("La contraseña es obligatoria")
            ElseIf (pUsuarios.Contraseña > 10) Then
                Throw New Exception("La contraseña debe tener maximo 10 caracteres")
            ElseIf String.IsNullOrEmpty(pUsuarios.Contraseña) Then
                Throw New Exception("La contraseña es obligatoria")
            End If
            Dim UserAD As New UsuariosAD
            If IsNothing(UserAD.ObtenerUsuarioPorLogin(pUsuarios.Login)) Then
                UserAD.InsertarUsuarios(pUsuarios)
            Else
                Throw New Exception("El Login ya esta registrado")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub ModificarUsuario(ByVal pUsuarios As UsuariosEN)
        Try
            'Login'
            If (pUsuarios.Login.Trim().Length = 0) Then
                Throw New Exception("El login es Obligatorio")
            ElseIf (pUsuarios.Login.Trim().Length > 10) Then
                Throw New Exception("El login debe tener maximo 10 caracteres")
            ElseIf String.IsNullOrEmpty(pUsuarios.Login) Then
                Throw New Exception("El login es obligatorio")
                'Nombre Completo'
            ElseIf (pUsuarios.Nom_Completo.Trim().Length = 0) Then
                Throw New Exception("El Nombre es Obligatorio")
            ElseIf String.IsNullOrEmpty(pUsuarios.Nom_Completo) Then
                Throw New Exception("El Nombre es Obligatorio")
                'Contraseña'
            ElseIf (pUsuarios.Contraseña = 0) Then
                Throw New Exception("La contraseña es obligatoria")
            ElseIf (pUsuarios.Contraseña > 10) Then
                Throw New Exception("La contraseña debe tener maximo 10 caracteres")
            ElseIf String.IsNullOrEmpty(pUsuarios.Contraseña) Then
                Throw New Exception("La contraseña es obligatoria")
            End If

            Dim myuserAD As New UsuariosAD
            If IsNothing(myuserAD.ObtenerUsuarioPorLogin(pUsuarios.Login)) Then
                Throw New Exception("El login No existe")
            End If
            myuserAD.ModificarUsuario(pUsuarios)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub BorrarUsuario(ByVal pUsuarios As UsuariosEN)
        Try
            Try
                ' VALIDAR QUE SI EXISTA ESE USUARIO 
                ' VALIDAR QUE ESE USUARIO NO TENGA REGISTROS ASOCIADOS
                Dim myUserAD As New UsuariosAD
                myUserAD.BorrarUsuario(pUsuarios)
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Sub
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerUsuarioPorLogin(ByVal pUsuarios As String) As UsuariosEN
        Try
            If pUsuarios.Trim.Length = 0 Then
                Throw New Exception("El login es Obligatorio")
            ElseIf pUsuarios.Trim.Length > 10 Then
                Throw New Exception("El login debe tener maximo 10 caracteres")
            End If
            Dim UserAD As New UsuariosAD
            Return UserAD.ObtenerUsuarioPorLogin(pUsuarios)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
    Public Function ObtenerTodosLosUsuarios() As List(Of UsuariosEN)
        Try
            Dim UserAD As New UsuariosAD
            Return UserAD.ObtenerTodosLosUsuarios()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
