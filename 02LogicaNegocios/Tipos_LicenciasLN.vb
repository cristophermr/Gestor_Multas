Imports _01AccesoDatos
Imports _03Entidades
Public Class Tipos_LicenciasLN
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub
    Public Sub InsertarTip_Lic(ByVal pTipos_Lic As Tipos_LicenciasEN)
        Try
            'Codigo Tipo Licencia' 
            If (pTipos_Lic.Codigo_Tipo_Licencia.Trim().Length = 0) Then
                Throw New Exception("El Codigo del tipo de la licencia es Obligatorio")
            ElseIf (pTipos_Lic.Codigo_Tipo_Licencia.Trim().Length > 3) Then
                Throw New Exception("El Codigo del tipo de la licencia debe tener maximo 3 caracteres")
            ElseIf String.IsNullOrEmpty(pTipos_Lic.Codigo_Tipo_Licencia) Then
                Throw New Exception("El Codigo del tipo de la licencia es Obligatorio")
                'Nombre tipo de licencia'
            ElseIf (pTipos_Lic.Nombre_Tipo.Trim().Length = 0) Then
                Throw New Exception("El Nombre tipo de licencia es obligatorio")
            ElseIf (pTipos_Lic.Nombre_Tipo.Trim().Length > 15) Then
                Throw New Exception("El Nombre tipo de licencia debe tener maximo 15 caracteres")
            ElseIf String.IsNullOrEmpty(pTipos_Lic.Nombre_Tipo) Then
                Throw New Exception("El Nombre tipo de licencia es obligatoria")
            End If
            Dim Tip_LicAD As New Tipos_LicenciasAD
            If IsNothing(Tip_LicAD.ObtenerTipo_LicPorCodigo(pTipos_Lic.Codigo_Tipo_Licencia)) Then
                Tip_LicAD.InsertarTipos_Lic(pTipos_Lic)
            Else
                Throw New Exception("El tipo de licencia ya esta registro")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub ModificarTip_Lic(ByVal pTipos_Lic As Tipos_LicenciasEN)
        Try
            'Codigo Tipo Licencia' 
            If (pTipos_Lic.Codigo_Tipo_Licencia.Trim().Length = 0) Then
                Throw New Exception("El Codigo del tipo de la licencia es Obligatorio")
            ElseIf (pTipos_Lic.Codigo_Tipo_Licencia.Trim().Length > 3) Then
                Throw New Exception("El Codigo del tipo de la licencia debe tener maximo 3 caracteres")
            ElseIf String.IsNullOrEmpty(pTipos_Lic.Codigo_Tipo_Licencia) Then
                Throw New Exception("El Codigo del tipo de la licencia es Obligatorio")
                'Nombre tipo de licencia'
            ElseIf (pTipos_Lic.Nombre_Tipo.Trim().Length = 0) Then
                Throw New Exception("El Nombre tipo de licencia es obligatorio")
            ElseIf (pTipos_Lic.Nombre_Tipo.Trim().Length > 15) Then
                Throw New Exception("El Nombre tipo de licencia debe tener maximo 15 caracteres")
            ElseIf String.IsNullOrEmpty(pTipos_Lic.Nombre_Tipo) Then
                Throw New Exception("El Nombre tipo de licencia es obligatoria")
            End If

            Dim myTip_Lic As New Tipos_LicenciasAD
            If IsNothing(myTip_Lic.ObtenerTipo_LicPorCodigo(pTipos_Lic.Codigo_Tipo_Licencia)) Then
                Throw New Exception("El tipo de licencia No existe")
            End If
            myTip_Lic.ModificarTip_Lic(pTipos_Lic)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub BorrarTip_Lic(ByVal pTipos_Lic As Tipos_LicenciasEN)
        Try
            Try
                ' VALIDAR QUE SI EXISTA ESE CONDUCTOR 
                ' VALIDAR QUE ESE CONDUCTOR NO TENGA REGISTROS ASOCIADOS
                Dim myTip_Lic As New Tipos_LicenciasAD
                myTip_Lic.BorrarTip_Lic(pTipos_Lic)
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Sub
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerTip_LicPorCodigo(ByVal pTipos_Lic As String) As Tipos_LicenciasEN
        Try
            If pTipos_Lic.Trim.Length = 0 Then
                Throw New Exception("El Codigo del tipo de la licencia es Obligatorio")
            ElseIf pTipos_Lic.Trim.Length > 3 Then
                Throw New Exception("El Codigo del tipo de la licencia debe tener maximo 3 caracteres")
            End If
            Dim Tip_LicAD As New Tipos_LicenciasAD
            Return Tip_LicAD.ObtenerTipo_LicPorCodigo(pTipos_Lic)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
    Public Function ObtenerTodosLosTip_Lic() As List(Of Tipos_LicenciasEN)
        Try
            Dim Tip_LicAD As New Tipos_LicenciasAD
            Return Tip_LicAD.ObtenerTodosLosTip_Lic()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
