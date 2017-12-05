Imports _01AccesoDatos
Imports _03Entidades
Public Class LicenciasLN
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub
    Public Sub InsertarLicencia(ByVal pLicencia As LicenciasEN)
        Try
            'Codigo Licencia'
            If (pLicencia.Cod_Licencia.Trim().Length = 0) Then
                Throw New Exception("El Codigo es Obligatorio")
            ElseIf (pLicencia.Cod_Licencia.Trim().Length > 10) Then
                Throw New Exception("El Codigo debe tener maximo 10 caracteres")
            ElseIf String.IsNullOrEmpty(pLicencia.Cod_Licencia) Then
                Throw New Exception("El Codigo es obligatoria")
                'Cedula'
            ElseIf (pLicencia.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es Obligatoria")
            ElseIf (pLicencia.Cedula.Trim().Length > 15) Then
                Throw New Exception("Cedula debe tener maximo 15 caracteres")
            ElseIf String.IsNullOrEmpty(pLicencia.Cedula) Then
                Throw New Exception("La Cedula es Obligatoria")
                'Codigo Tipo Licencia'
            ElseIf (pLicencia.Codigo_Tipo_Licencia.Trim().Length = 0) Then
                Throw New Exception("El Codigo del tipo de la licencia es Obligatorio")
                ElseIf (pLicencia.Codigo_Tipo_Licencia.Trim().Length > 3) Then
                    Throw New Exception("El Codigo del tipo de la licencia debe tener maximo 3 caracteres")
                ElseIf String.IsNullOrEmpty(pLicencia.Codigo_Tipo_Licencia) Then
                    Throw New Exception("El Codigo del tipo de la licencia es Obligatorio")
                End If
                Dim LicAD As New LicenciasAD
            If IsNothing(LicAD.ObtenerLicenciaPorCodigo(pLicencia.Cod_Licencia)) Then
                LicAD.InsertarLicencias(pLicencia)
            Else
                Throw New Exception("La Licencia ya esta registrada")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub ModificarLicencia(ByVal pLicencia As LicenciasEN)
        Try
            'Codigo Licencia'
            If (pLicencia.Cod_Licencia.Trim().Length = 0) Then
                Throw New Exception("El Codigo es Obligatorio")
            ElseIf (pLicencia.Cod_Licencia.Trim().Length > 10) Then
                Throw New Exception("El Codigo debe tener maximo 10 caracteres")
            ElseIf String.IsNullOrEmpty(pLicencia.Cod_Licencia) Then
                Throw New Exception("El Codigo es obligatoria")
                'Cedula'
            ElseIf (pLicencia.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es Obligatoria")
            ElseIf (pLicencia.Cedula.Trim().Length > 15) Then
                Throw New Exception("Cedula debe tener maximo 15 caracteres")
            ElseIf String.IsNullOrEmpty(pLicencia.Cedula) Then
                Throw New Exception("La Cedula es Obligatoria")
                'Codigo Tipo Licencia'
            ElseIf (pLicencia.Codigo_Tipo_Licencia.Trim().Length = 0) Then
                Throw New Exception("El Codigo del tipo de la licencia es Obligatorio")
            ElseIf (pLicencia.Codigo_Tipo_Licencia.Trim().Length > 3) Then
                Throw New Exception("El Codigo del tipo de la licencia debe tener maximo 3 caracteres")
            ElseIf String.IsNullOrEmpty(pLicencia.Codigo_Tipo_Licencia) Then
                Throw New Exception("El Codigo del tipo de la licencia es Obligatorio")
            End If

            Dim myLicAD As New LicenciasAD
            If IsNothing(myLicAD.ObtenerLicenciaPorCodigo(pLicencia.Cod_Licencia)) Then
                Throw New Exception("La licencia No existe")
            End If
            myLicAD.ModificarLicencia(pLicencia)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub BorrarLicencia(ByVal pLicencia As LicenciasEN)
        Try
            Try
                ' VALIDAR QUE SI EXISTA ESE CONDUCTOR 
                ' VALIDAR QUE ESE CONDUCTOR NO TENGA REGISTROS ASOCIADOS
                Dim myLicAD As New LicenciasAD
                myLicAD.BorrarLicencia(pLicencia)
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Sub
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerLicenciaPorCodigo(ByVal pLicencia As String) As LicenciasEN
        Try
            If pLicencia.Trim.Length = 0 Then
                Throw New Exception("El Codigo es Obligatorio")
            ElseIf pLicencia.Trim.Length > 15 Then
                Throw New Exception("El Codigo debe tener maximo 10 caracteres")
            End If
            Dim LicAD As New LicenciasAD
            Return LicAD.ObtenerLicenciaPorCodigo(pLicencia)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
    Public Function ObtenerTodosConductores() As List(Of LicenciasEN)
        Try
            Dim LicAD As New LicenciasAD
            Return LicAD.ObtenerTodasLasLicencias()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
