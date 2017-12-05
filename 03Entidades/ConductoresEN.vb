Public Class ConductoresEN
#Region "Atributos"
    Dim _Cedula As String
    Dim _NombreCompleto As String
    Dim _Tel_Celular As String
    Dim _Tel_Casa As String
    Dim _Fecha_Nacimiento As Date
    Dim _E_Mail As String
    Dim _Dir_Completa As String
    Dim _Observaciones As String
    Dim _Ind_Activo As Boolean

#End Region
#Region "Constructores"
    Public Sub New()
        Cedula = String.Empty
        _NombreCompleto = String.Empty
        _Tel_Celular = String.Empty
        _Tel_Casa = String.Empty
        _Fecha_Nacimiento = CType("01/01/2000", Date)
        _E_Mail = String.Empty
        _Dir_Completa = String.Empty
        _Observaciones = String.Empty
        _Ind_Activo = False
    End Sub
    ''' <summary>
    ''' Constructor que recibe todos los datos de la clase
    ''' </summary>
    ''' <param name="pCedula">Cedula del conductor</param>
    ''' <param name="pNombreCompleto">Nombre del conductor</param>
    ''' <param name="pTel_Celular">Telefono celular del conductor</param>
    ''' <param name="pTel_Casa">Telefono de la casa del conductor</param>
    ''' <param name="pFecha_Nacimiento">Fecha de nacimiento del conductor</param>
    ''' <param name="pE_Mail">Correo electronico del conductor</param>
    ''' <param name="pDir_Completa">Direccion completa del conductor</param>
    ''' <param name="pObservaciones">Observaciones adicionales</param>
    ''' <param name="pInd_Activo">Indica si esta activo el conductor o no</param>
    Public Sub New(ByVal pCedula As String,
                   ByVal pNombreCompleto As String,
                   ByVal pTel_Celular As String,
                   ByVal pTel_Casa As String,
                   ByVal pFecha_Nacimiento As Date,
                   ByVal pE_Mail As String,
                   ByVal pDir_Completa As String,
                   ByVal pObservaciones As String,
                   ByVal pInd_Activo As Boolean)

        Cedula = pCedula
        _NombreCompleto = pNombreCompleto
        _Tel_Celular = pTel_Celular
        _Tel_Casa = pTel_Casa
        _Fecha_Nacimiento = pFecha_Nacimiento
        _E_Mail = pE_Mail
        _Dir_Completa = pDir_Completa
        _Observaciones = pObservaciones
        _Ind_Activo = pInd_Activo
    End Sub

#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Cedula del conductor
    ''' </summary>
    ''' <returns>Cedula del conductor</returns>
    Public Property Cedula As String
        Get
            Return _Cedula
        End Get
        Set(value As String)
            _Cedula = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre del conductor
    ''' </summary>
    ''' <returns>Nombre del conductor</returns>
    Public Property NombreCompleto As String
        Get
            Return _NombreCompleto
        End Get
        Set(value As String)
            _NombreCompleto = value
        End Set
    End Property
    ''' <summary>
    ''' Telefono celular del conductor
    ''' </summary>
    ''' <returns>Telefono celular del conductor</returns>
    Public Property Tel_Celular As String
        Get
            Return _Tel_Celular
        End Get
        Set(value As String)
            _Tel_Celular = value
        End Set
    End Property
    ''' <summary>
    ''' Telefono de la casa del conductor<
    ''' </summary>
    ''' <returns>Telefono de la casa del conductor<</returns>
    Public Property Tel_Casa As String
        Get
            Return _Tel_Casa
        End Get
        Set(value As String)
            _Tel_Casa = value
        End Set
    End Property
    ''' <summary>
    ''' Fecha de nacimiento del conductor
    ''' </summary>
    ''' <returns>Fecha de nacimiento del conductor</returns>
    Public Property Fecha_Nacimiento As Date
        Get
            Return _Fecha_Nacimiento
        End Get
        Set(value As Date)
            _Fecha_Nacimiento = value
        End Set
    End Property
    ''' <summary>
    ''' Correo electronico del conductor
    ''' </summary>
    ''' <returns>Correo electronico del conductor</returns>
    Public Property E_Mail As String
        Get
            Return _E_Mail
        End Get
        Set(value As String)
            _E_Mail = value
        End Set
    End Property
    ''' <summary>
    ''' Direccion completa del conductor
    ''' </summary>
    ''' <returns>Direccion completa del conductor</returns>
    Public Property Dir_Completa As String
        Get
            Return _Dir_Completa
        End Get
        Set(value As String)
            _Dir_Completa = value
        End Set
    End Property
    ''' <summary>
    ''' Observaciones adicionales
    ''' </summary>
    ''' <returns>Observaciones adicionales</returns>
    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
        End Set
    End Property
    ''' <summary>
    ''' Indica si esta activo el conductor o no
    ''' </summary>
    ''' <returns>Indica si esta activo el conductor o no</returns>
    Public Property Ind_Activo As Boolean
        Get
            Return _Ind_Activo
        End Get
        Set(value As Boolean)
            _Ind_Activo = value
        End Set
    End Property


#End Region
#Region "Metodos"
    Public Overrides Function ToString() As String
        Dim strValor As String
        strValor = "Cedula:" & _Cedula & vbCrLf &
                   "Nombre Completo:" & _NombreCompleto & vbCrLf &
                   "Telefono Celular:" & _Tel_Celular & vbCrLf &
                   "Telefono de Casa:" & _Tel_Casa & vbCrLf &
                   "Fecha de Nacimiento:" & _Fecha_Nacimiento.ToShortDateString & vbCrLf &
                   "Correo Electronico:" & _E_Mail & vbCrLf &
                   "Direccion Completa:" & _Dir_Completa & vbCrLf &
                   "Observaciones:" & _Observaciones & vbCrLf &
                   "Activo:" & IIf(_Ind_Activo, "Si", "No")
        'ToShortDateString pone la fecha corta, tambien esta la fecha larga
        Return strValor
    End Function
#End Region
End Class
