Imports _02LogicaNegocios

Module Complementos
    '' Obtener todos los conductores
    Public Function ObtenerCondutoresData() As DataTable
        Dim ConductoresData As New DataTable
        Dim obtenerconductores As ConductoresLN
        ConductoresData.Load(obtenerconductores.ObtenerTodosConductores)
        Return ConductoresData
    End Function
End Module
