Public Class Tipos_LicenciasEN
#Region "Atributos"
    Dim _Codigo_Tipo_Licencia As String
    Dim _Nombre_Tipo As String
    Dim _Observaciones As String
#End Region
#Region "Constructores"
    Public Sub New()
        _Codigo_Tipo_Licencia = String.Empty
        _Nombre_Tipo = String.Empty
        _Observaciones = String.Empty
    End Sub
    ''' <summary>
    ''' Constructor que recibe todos los datos de la clase
    ''' </summary>
    ''' <param name="pCod_Tipo_Lic">Codigo del tipo de la licencia</param>
    ''' <param name="pNomb_Tipo">Nombre del tipo de la licencia</param>
    ''' <param name="pObservaciones">Observaciones adicionales</param>
    Public Sub New(ByVal pCod_Tipo_Lic As String,
                   ByVal pNomb_Tipo As String,
                   ByVal pObservaciones As String)

        _Codigo_Tipo_Licencia = pCod_Tipo_Lic
        _Nombre_Tipo = pNomb_Tipo
        _Observaciones = pObservaciones

    End Sub

#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Codigo del tipo de la licencia
    ''' </summary>
    ''' <returns>Codigo del tipo de la licencia</returns>
    Public Property Codigo_Tipo_Licencia As String
        Get
            Return _Codigo_Tipo_Licencia
        End Get
        Set(value As String)
            _Codigo_Tipo_Licencia = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre del tipo de la licencia
    ''' </summary>
    ''' <returns>Nombre del tipo de la licencia</returns>
    Public Property Nombre_Tipo As String
        Get
            Return _Nombre_Tipo
        End Get
        Set(value As String)
            _Nombre_Tipo = value
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
#End Region
#Region "Metodos"
    Public Overrides Function ToString() As String
        Dim strValor As String
        strValor = "Codigo Tipo Licencia:" & Codigo_Tipo_Licencia & vbCrLf &
                   "Nombre Tipo:" & Nombre_Tipo & vbCrLf &
                   "Observaciones:" & Observaciones & vbCrLf
        'ToShortDateString pone la fecha corta, tambien esta la fecha larga
        Return strValor
    End Function
#End Region
End Class
