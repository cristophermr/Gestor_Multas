Public Class UsuariosEN
#Region "Atributos"
    Dim _Login As String
    Dim _Nom_Completo As String
    Dim _Contraseña As Double
    Dim _Ind_Admin As Boolean
    Dim _Ind_Digita As Boolean

#End Region
#Region "Constructores"
    Public Sub New()
        Login = String.Empty
        Nom_Completo = String.Empty
        Contraseña = 0
        Ind_Admin = False
        Ind_Digita = False
    End Sub
    ''' <summary>
    ''' Constructor que recibe todos los datos de la clase
    ''' </summary>
    ''' <param name="pLogin">Usuario de inicio de sesion</param>
    ''' <param name="pNom_Comp">Nombre completo del usuario</param>
    ''' <param name="pContraseña">Contraseña para iniciar sesion</param>
    ''' <param name="pInd_Admin">Indica si es administrador</param>
    ''' <param name="pInd_Digita">Indica si es digitador</param>
    Public Sub New(ByVal pLogin As String,
                   ByVal pNom_Comp As String,
                   ByVal pContraseña As Double,
                   ByVal pInd_Admin As Boolean,
                   ByVal pInd_Digita As Boolean)

        Login = pLogin
        Nom_Completo = pNom_Comp
        Contraseña = pContraseña
        Ind_Admin = pInd_Admin
        Ind_Digita = pInd_Digita

    End Sub

#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Usuario de inicio de sesion
    ''' </summary>
    ''' <returns>Usuario de inicio de sesion</returns>
    Public Property Login As String
        Get
            Return _Login
        End Get
        Set(value As String)
            _Login = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre completo del usuario
    ''' </summary>
    ''' <returns>Nombre completo del usuario</returns>
    Public Property Nom_Completo As String
        Get
            Return _Nom_Completo
        End Get
        Set(value As String)
            _Nom_Completo = value
        End Set
    End Property
    ''' <summary>
    ''' Contraseña para iniciar sesion
    ''' </summary>
    ''' <returns>Contraseña para iniciar sesion</returns>
    Public Property Contraseña As Double
        Get
            Return _Contraseña
        End Get
        Set(value As Double)
            _Contraseña = value
        End Set
    End Property
    ''' <summary>
    ''' Indica si es administrador
    ''' </summary>
    ''' <returns>Indica si es administrador</returns>
    Public Property Ind_Admin As Boolean
        Get
            Return _Ind_Admin
        End Get
        Set(value As Boolean)
            _Ind_Admin = value
        End Set
    End Property
    ''' <summary>
    ''' Indica si es digitador
    ''' </summary>
    ''' <returns>Indica si es digitador</returns>
    Public Property Ind_Digita As Boolean
        Get
            Return _Ind_Digita
        End Get
        Set(value As Boolean)
            _Ind_Digita = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Overrides Function ToString() As String
        Dim strValor As String
        strValor = "Login:" & Login & vbCrLf &
                   "Nombre Completo:" & Nom_Completo & vbCrLf &
                   "Contraseña:" & Contraseña & vbCrLf &
                   "Indica Administradot:" & Ind_Admin & vbCrLf &
                   "Indica Digitador:" & Ind_Digita & vbCrLf
        Return strValor
    End Function
#End Region
End Class
