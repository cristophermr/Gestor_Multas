Public Class MultasEN
#Region "Atributos"
    Dim _Codigo_Multa As String
    Dim _Fecha_Multa As Date
    Dim _Nombre_Trafico As String
    Dim _Monto_Multa As Integer
    Dim _Ind_Pagada As Boolean
    Dim _Cedula As String


#End Region
#Region "Constructores"
    Public Sub New()
        Codigo_Multa = String.Empty
        Fecha_Multa = CType("01/01/2000", Date)
        Nombre_Trafico = String.Empty
        Monto_Multa = 0
        Ind_Pagada = False
        Cedula = String.Empty
    End Sub
    ''' <summary>
    ''' Constructor que recibe todos los datos de la clase
    ''' </summary>
    ''' <param name="pCod_Multa">Codigo de la multa</param>
    ''' <param name="pFec_Multa">Fecha que se registro la multa</param>
    ''' <param name="pNombreTrafico">Nombre del trafico que realizo la multa</param>
    ''' <param name="pMonto_Multa">Monto de la multa realizada</param>
    ''' <param name="pInd_Pagada">Indica si la multa esta paga o no</param>
    ''' <param name="pCedula">Cedula del conductor multado</param>
    Public Sub New(ByVal pCod_Multa As String,
                   ByVal pFec_Multa As Date,
                   ByVal pNombreTrafico As String,
                   ByVal pMonto_Multa As String,
                   ByVal pInd_Pagada As Integer,
                   ByVal pCedula As String)

        Codigo_Multa = pCod_Multa
        Fecha_Multa = pFec_Multa
        Nombre_Trafico = pNombreTrafico
        Monto_Multa = pMonto_Multa
        Ind_Pagada = pInd_Pagada
        Cedula = pCedula
    End Sub

#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Codigo de la multa
    ''' </summary>
    ''' <returns>Codigo de la multa</returns>
    Public Property Codigo_Multa As String
        Get
            Return _Codigo_Multa
        End Get
        Set(value As String)
            _Codigo_Multa = value
        End Set
    End Property
    ''' <summary>
    ''' Fecha que se registro la multa
    ''' </summary>
    ''' <returns>Fecha que se registro la multa</returns>
    Public Property Fecha_Multa As Date
        Get
            Return _Fecha_Multa
        End Get
        Set(value As Date)
            _Fecha_Multa = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre del trafico que realizo la multa
    ''' </summary>
    ''' <returns>Nombre del trafico que realizo la multa</returns>
    Public Property Nombre_Trafico As String
        Get
            Return _Nombre_Trafico
        End Get
        Set(value As String)
            _Nombre_Trafico = value
        End Set
    End Property
    ''' <summary>
    ''' Monto de la multa realizada
    ''' </summary>
    ''' <returns>Monto de la multa realizada</returns>
    Public Property Monto_Multa As Integer
        Get
            Return _Monto_Multa
        End Get
        Set(value As Integer)
            _Monto_Multa = value
        End Set
    End Property
    ''' <summary>
    ''' Indica si la multa esta paga o no
    ''' </summary>
    ''' <returns>Indica si la multa esta paga o no</returns>
    Public Property Ind_Pagada As Boolean
        Get
            Return _Ind_Pagada
        End Get
        Set(value As Boolean)
            _Ind_Pagada = value
        End Set
    End Property
    ''' <summary>
    ''' Cedula del conductor multado
    ''' </summary>
    ''' <returns>Cedula del conductor multado</returns>
    Public Property Cedula As String
        Get
            Return _Cedula
        End Get
        Set(value As String)
            _Cedula = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Overrides Function ToString() As String
        Dim strValor As String
        strValor = "Codigo Multa:" & Codigo_Multa & vbCrLf &
                   "Fecha Multa:" & Fecha_Multa.ToShortDateString & vbCrLf &
                   "Nombre Trafico:" & Nombre_Trafico & vbCrLf &
                   "Monto Multa:" & Monto_Multa & vbCrLf &
                   "Indica Paga:" & Ind_Pagada & vbCrLf &
                   "Cedula:" & Cedula & vbCrLf
        'ToShortDateString pone la fecha corta, tambien esta la fecha larga
        Return strValor
    End Function
#End Region
End Class
