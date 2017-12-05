Imports _01AccesoDatos
Imports _03Entidades
Public Class MultasLN
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub
    Public Sub InsertarMulta(ByVal pMulta As MultasEN)
        Try
            'Codigo Multa' 
            If (pMulta.Codigo_Multa.Trim().Length = 0) Then
                Throw New Exception("El Codigo es obligatorio")
            ElseIf (pMulta.Codigo_Multa.Trim().Length > 15) Then
                Throw New Exception("El Codigo debe tener maximo 15 caracteres")
            ElseIf String.IsNullOrEmpty(pMulta.Codigo_Multa) Then
                Throw New Exception("El Codigo es obligatoria")
                'Nombre del Trafico'
            ElseIf (pMulta.Nombre_Trafico.Trim().Length = 0) Then
                Throw New Exception("El nombre del trafico es obligatorio")
            ElseIf String.IsNullOrEmpty(pMulta.Nombre_Trafico) Then
                Throw New Exception("El nombre del trafico es obligatorio")
                'Monto Multa'
            ElseIf (pMulta.Monto_Multa = 0) Then
                Throw New Exception("El monto de la multa es obligatorio")
            ElseIf (pMulta.Monto_Multa < 0) Then
                Throw New Exception("El monto de la multa debe tener mas caracteres")
                'Cedula Conductor' 
            ElseIf (pMulta.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es Obligatoria")
            ElseIf (pMulta.Cedula.Trim().Length > 15) Then
                Throw New Exception("Cedula debe tener maximo 15 caracteres")
            ElseIf String.IsNullOrEmpty(pMulta.Cedula) Then
                Throw New Exception("La Cedula es Obligatoria")
            End If
            Dim MultAD As New MultasAD
            If IsNothing(MultAD.ObtenerMultasPorCodigo(pMulta.Codigo_Multa)) Then
                MultAD.InsertarMultas(pMulta)
            Else
                Throw New Exception("La multa ya esta registrada")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub ModificarMulta(ByVal pMulta As MultasEN)
        Try
            'Codigo Multa' 
            If (pMulta.Codigo_Multa.Trim().Length = 0) Then
                Throw New Exception("El Codigo es obligatorio")
            ElseIf (pMulta.Codigo_Multa.Trim().Length > 15) Then
                Throw New Exception("El Codigo debe tener maximo 15 caracteres")
            ElseIf String.IsNullOrEmpty(pMulta.Codigo_Multa) Then
                Throw New Exception("El Codigo es obligatoria")
                'Nombre del Trafico'
            ElseIf (pMulta.Nombre_Trafico.Trim().Length = 0) Then
                Throw New Exception("El nombre del trafico es obligatorio")
            ElseIf String.IsNullOrEmpty(pMulta.Nombre_Trafico) Then
                Throw New Exception("El nombre del trafico es obligatorio")
                'Monto Multa'
            ElseIf (pMulta.Monto_Multa = 0) Then
                Throw New Exception("El monto de la multa es obligatorio")
            ElseIf (pMulta.Monto_Multa < 0) Then
                Throw New Exception("El monto de la multa debe tener mas caracteres")
                'Cedula Conductor' 
            ElseIf (pMulta.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es Obligatoria")
            ElseIf (pMulta.Cedula.Trim().Length > 15) Then
                Throw New Exception("Cedula debe tener maximo 15 caracteres")
            ElseIf String.IsNullOrEmpty(pMulta.Cedula) Then
                Throw New Exception("La Cedula es Obligatoria")
            End If

            Dim myMultaAD As New MultasAD
            If IsNothing(myMultaAD.ObtenerMultasPorCodigo(pMulta.Codigo_Multa)) Then
                Throw New Exception("La multa No existe")
            End If
            myMultaAD.ModificarMulta(pMulta)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub BorrarMulta(ByVal pMulta As MultasEN)
        Try
            Try
                ' VALIDAR QUE SI EXISTA ESE CONDUCTOR 
                ' VALIDAR QUE ESE CONDUCTOR NO TENGA REGISTROS ASOCIADOS
                Dim myMultaAD As New MultasAD
                myMultaAD.BorrarMulta(pMulta)
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Sub
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerMultaPorCodigo(ByVal pMulta As String) As MultasEN
        Try
            If pMulta.Trim.Length = 0 Then
                Throw New Exception("El Codigo es Obligatorio")
            ElseIf pMulta.Trim.Length > 15 Then
                Throw New Exception("El Codigo debe tener maximo 15 caracteres")
            End If
            Dim MultAD As New MultasAD
            Return MultAD.ObtenerMultasPorCodigo(pMulta)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
    Public Function ObtenerTodosConductores() As List(Of MultasEN)
        Try
            Dim MultAD As New MultasAD
            Return MultAD.ObtenerTodasLasMultas()

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
