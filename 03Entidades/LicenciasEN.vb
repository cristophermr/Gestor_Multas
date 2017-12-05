Public Class LicenciasEN
#Region "Atributos"
    Dim _Cod_Licencia As String
    Dim _Cedula As String
    Dim _Puntos As Double
    Dim _Fec_Emision As Date
    Dim _Fec_Vencimiento As Date
    Dim _Codigo_Tipo_Licencia As String
#End Region
#Region "Constructores"
    Public Sub New()
        Cod_Licencia = String.Empty
        Cedula = String.Empty
        Puntos = 0
        Fec_Emision = CType("01/01/2000", Date)
        Fec_Vencimiento = CType("01/01/2000", Date)
        Codigo_Tipo_Licencia = String.Empty
    End Sub
    ''' <summary>
    ''' Constructor que recibe todos los datos de la clase
    ''' </summary>
    ''' <param name="pCod_Lic">Codigo de la licencia</param>
    ''' <param name="pCedula">Cedula del conductor</param>
    ''' <param name="pPuntos">Puntos de la licencia</param>
    ''' <param name="pFec_Emision">Fecha de emision de la licencia</param>
    ''' <param name="pFec_Vencimiento">Fecha de vencimiento de la licencia</param>
    ''' <param name="pCod_Tipo_Lic">Codigo del tipo de licencia</param>
    Public Sub New(ByVal pCod_Lic As String,
                   ByVal pCedula As String,
                   ByVal pPuntos As String,
                   ByVal pFec_Emision As String,
                   ByVal pFec_Vencimiento As Date,
                   ByVal pCod_Tipo_Lic As String)

        Cod_Licencia = pCod_Lic
        Cedula = pCedula
        Puntos = pPuntos
        Fec_Emision = Fec_Emision
        Fec_Vencimiento = Fec_Vencimiento
        Codigo_Tipo_Licencia = pCod_Tipo_Lic

    End Sub

#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Codigo de la licencia
    ''' </summary>
    ''' <returns>Codigo de la licencia</returns>
    Public Property Cod_Licencia As String
        Get
            Return _Cod_Licencia
        End Get
        Set(value As String)
            _Cod_Licencia = value
        End Set
    End Property
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
    ''' Puntos de la licencia
    ''' </summary>
    ''' <returns>Puntos de la licencia</returns>
    Public Property Puntos As Double
        Get
            Return _Puntos
        End Get
        Set(value As Double)
            _Puntos = value
        End Set
    End Property
    ''' <summary>
    ''' Fecha de emision de la licencia
    ''' </summary>
    ''' <returns>Fecha de emision de la licencia</returns>
    Public Property Fec_Emision As Date
        Get
            Return _Fec_Emision
        End Get
        Set(value As Date)
            _Fec_Emision = value
        End Set
    End Property
    ''' <summary>
    ''' Fecha de vencimiento de la licencia
    ''' </summary>
    ''' <returns>Fecha de vencimiento de la licencia</returns>
    Public Property Fec_Vencimiento As Date
        Get
            Return _Fec_Vencimiento
        End Get
        Set(value As Date)
            _Fec_Vencimiento = value
        End Set
    End Property
    ''' <summary>
    ''' Codigo del tipo de licencia
    ''' </summary>
    ''' <returns>Codigo del tipo de licencia</returns>
    Public Property Codigo_Tipo_Licencia As String
        Get
            Return _Codigo_Tipo_Licencia
        End Get
        Set(value As String)
            _Codigo_Tipo_Licencia = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Overrides Function ToString() As String
        Dim strValor As String
        strValor = "Codigo Licencia:" & _Cod_Licencia & vbCrLf &
                   "Cedula:" & _Cedula & vbCrLf &
                   "Puntos:" & _Puntos & vbCrLf &
                   "Fecha Emision:" & _Fec_Emision.ToShortDateString & vbCrLf &
                   "Fecha Vencimiento:" & _Fec_Vencimiento.ToShortDateString & vbCrLf &
                   "Codigo Tipo Licencia:" & _Codigo_Tipo_Licencia & vbCrLf
        'ToShortDateString pone la fecha corta, tambien esta la fecha larga
        Return strValor
    End Function
#End Region
End Class
