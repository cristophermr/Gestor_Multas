Imports _01AccesoDatos
Imports _03Entidades
Public Class ConductoresLN
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub
    Public Sub InsertarConductor(ByVal pConductor As ConductoresEN)
        Try
            'Cedula'
            If (pConductor.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es Obligatoria")
            ElseIf (pConductor.Cedula.Trim().Length > 15) Then
                Throw New Exception("Cedula debe tener maximo 15 caracteres")
            ElseIf String.IsNullOrEmpty(pConductor.Cedula) Then
                Throw New Exception("La Cedula es obligatoria")
                'Nombre'
            ElseIf (pConductor.NombreCompleto.Trim().Length = 0) Then
                Throw New Exception("El Nombre es Obligatorio")
            ElseIf (pConductor.NombreCompleto.Trim().Length > 60) Then
                Throw New Exception("El Nombre debe tener maximo 60 caracteres")
            ElseIf String.IsNullOrEmpty(pConductor.NombreCompleto) Then
                Throw New Exception("El Nombre es obligatorio")
                'Telefono Celular'
            ElseIf (pConductor.Tel_Celular.Trim().Length = 0) Then
                Throw New Exception("El telefono celular es Obligatorio")
            ElseIf (pConductor.Tel_Celular.Trim().Length > 9) Then
                Throw New Exception("El telefono celular debe tener maximo 9 caracteres")
            ElseIf String.IsNullOrEmpty(pConductor.Tel_Celular) Then
                Throw New Exception("El telefono celular es obligatorio")
                'Telefono Casa'
            ElseIf (pConductor.Tel_Casa.Trim().Length = 0) Then
                Throw New Exception("El telefono fijo es Obligatorio")
            ElseIf (pConductor.Tel_Casa.Trim().Length > 9) Then
                Throw New Exception("El telefono fijo debe tener maximo 9 caracteres")
            ElseIf String.IsNullOrEmpty(pConductor.Tel_Casa) Then
                Throw New Exception("El telefono fijo es obligatorio")
            End If
            Dim ConductAD As New ConductoresAD
            If IsNothing(ConductAD.ObtenerConductorPorCedula(pConductor.Cedula)) Then
                ConductAD.InsertarConductores(pConductor)
            Else
                Throw New Exception("El conductor ya esta registrado")
            End If


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub ModificarConductor(ByVal pConductor As ConductoresEN)
        Try
            'Cedula'
            If (pConductor.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es Obligatoria")
            ElseIf (pConductor.Cedula.Trim().Length > 15) Then
                Throw New Exception("Cedula debe tener maximo 15 caracteres")
            ElseIf String.IsNullOrEmpty(pConductor.Cedula) Then
                Throw New Exception("La Cedula es obligatoria")
                'Nombre'
            ElseIf (pConductor.NombreCompleto.Trim().Length = 0) Then
                Throw New Exception("El Nombre es Obligatorio")
            ElseIf (pConductor.NombreCompleto.Trim().Length > 60) Then
                Throw New Exception("El Nombre debe tener maximo 60 caracteres")
            ElseIf String.IsNullOrEmpty(pConductor.NombreCompleto) Then
                Throw New Exception("El Nombre es obligatorio")
                'Telefono Celular'
            ElseIf (pConductor.Tel_Celular.Trim().Length = 0) Then
                Throw New Exception("El telefono celular es Obligatorio")
            ElseIf (pConductor.Tel_Celular.Trim().Length > 9) Then
                Throw New Exception("El telefono celular debe tener maximo 9 caracteres")
            ElseIf String.IsNullOrEmpty(pConductor.Tel_Celular) Then
                Throw New Exception("El telefono celular es obligatorio")
                'Telefono Casa'
            ElseIf (pConductor.Tel_Casa.Trim().Length = 0) Then
                Throw New Exception("El telefono fijo es Obligatorio")
            ElseIf (pConductor.Tel_Casa.Trim().Length > 9) Then
                Throw New Exception("El telefono fijo debe tener maximo 9 caracteres")
            ElseIf String.IsNullOrEmpty(pConductor.Tel_Casa) Then
                Throw New Exception("El telefono fijo es obligatorio")
            End If

            Dim myConductAD As New ConductoresAD
            If IsNothing(myConductAD.ObtenerConductorPorCedula(pConductor.Cedula)) Then
                Throw New Exception("El conductor No existe")
            End If
            myConductAD.ModificarConductor(pConductor)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub BorrarConductor(ByVal pConductor As ConductoresEN)
        Try
            Try
                ' VALIDAR QUE SI EXISTA ESE CONDUCTOR 
                ' VALIDAR QUE ESE CONDUCTOR NO TENGA REGISTROS ASOCIADOS
                Dim myConductAD As New ConductoresAD
                myConductAD.BorrarConductor(pConductor)
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Exit Sub
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function ObtenerConductorPorCedula(ByVal pConductor As String) As ConductoresEN
        Try
            If pConductor.Trim.Length = 0 Then
                Throw New Exception("Cedula es Obligatoria")
            ElseIf pConductor.Trim.Length > 15 Then
                Throw New Exception("Cedula debe tener maximo 15 caracteres")
            End If
            Dim ConductAD As New ConductoresAD
            Return ConductAD.ObtenerConductorPorCedula(pConductor)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
    Public Function ObtenerTodosConductores() As List(Of ConductoresEN)
        Try
            Dim ConductorAD As New ConductoresAD
            Dim query = (From n In ConductorAD.ObtenerTodosLosConductores
                         Select New ConductoresEN With {.Cedula = n.Cedula, .NombreCompleto = n.NombreCompleto, .Fecha_Nacimiento = n.Fecha_Nacimiento, .E_Mail = n.E_Mail, .Dir_Completa = n.Dir_Completa, .Tel_Celular = n.Tel_Celular, .Tel_Casa = n.Tel_Casa, .Observaciones = n.Observaciones, .Ind_Activo = n.Ind_Activo}).ToList
            Return query

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function
End Class
