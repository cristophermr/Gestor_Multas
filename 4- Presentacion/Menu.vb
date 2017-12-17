Imports _04Presentacion
Module Menu
    Dim master As New Master
    Public Function Catalogos()
        master.pnlProcesos.Hide()
        master.pnlReportes.Hide()

    End Function
    Public Function Procesos()
        master.pnlCatalogos.Hide()
        master.pnlReportes.Hide()
    End Function
    Public Function Reportes()
        master.pnlProcesos.Hide()
        master.pnlCatalogos.Hide()
    End Function
End Module
