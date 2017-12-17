Imports System.ComponentModel
Imports _02LogicaNegocios
Imports _03Entidades

Public Class Master
    Private ConductoresDataSource As List(Of ConductoresEN) = New List(Of ConductoresEN)()

    Private Conductorlista As New ConductoresLN
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Close()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        If Me.WindowState = FormWindowState.Maximized Then

            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Tipos_Licencias As New LicencesTypes
        pnlCatalogos.Location = New Point(7, 124)
        pnlProcesos.Location = New Point(8, 173)
        pnlCatalogos.Hide()
        pnlProcesos.Hide()
        pnlReportes.Hide()
        bntProcesos.Location = New Point(3, 130)
        btnReportes.Location = New Point(3, 179)
        btnSalir.Location = New Point(0, 227)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles bntCatalogos.Click
        ''Verifica que ningun panel este activo
        If pnlProcesos.Visible = True Or pnlReportes.Visible = True Then
            Procesos()

        End If

        If pnlCatalogos.Visible = True Then
            pnlCatalogos.Visible = False
            bntProcesos.Location = New Point(3, 130)
            btnReportes.Location = New Point(3, 179)
            btnSalir.Location = New Point(0, 227)

            SubMenus.HideSync(pnlCatalogos)
        Else
            pnlCatalogos.Visible = True
            bntProcesos.Location = New Point(8, 248)
            btnReportes.Location = New Point(11, 296)
            btnSalir.Location = New Point(11, 344)
            SubMenus.ShowSync(pnlCatalogos)

        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Environment.Exit(0)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SlideMenu.Paint

    End Sub

    Private Sub bntMenu_Click(sender As Object, e As EventArgs) Handles bntMenu.Click
        ''Se agregan animaciones a nivel del boton
        If SlideMenu.Width = 43 Then
            SlideMenu.Visible = False
            SlideMenu.Width = 250
            PanelAnimation.ShowSync(SlideMenu)
            LogoAnimation.ShowSync(Logo)

        Else
            LogoAnimation.HideSync(Logo)
            SlideMenu.Visible = True
            SlideMenu.Width = 43
            PanelAnimation.ShowSync(SlideMenu)

        End If

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Dim Acerca As New About
        DialogResult = Acerca.ShowDialog
    End Sub

    Private Sub bntProcesos_Click(sender As Object, e As EventArgs) Handles bntProcesos.Click
        If pnlCatalogos.Visible = True Or pnlReportes.Visible = True Then
            Call Procesos()

        End If
        If pnlProcesos.Visible = True Then
            pnlProcesos.Visible = False
            btnReportes.Location = New Point(3, 179)
            btnSalir.Location = New Point(0, 227)

            SubMenus.HideSync(pnlProcesos)
        Else
            pnlProcesos.Visible = True
            btnReportes.Location = New Point(1, 257)
            btnSalir.Location = New Point(3, 305)
            SubMenus.ShowSync(pnlProcesos)

        End If
    End Sub

    Private Sub header_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    End Sub

    Private Sub btnConductores_Click(sender As Object, e As EventArgs)
        Conductores1.BringToFront()
    End Sub

    Private Sub Example1_Load(sender As Object, e As EventArgs) Handles Example1.Load

    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        If pnlProcesos.Visible = True Or pnlCatalogos.Visible = True Then
            Call Reportes()

        End If
        If pnlReportes.Visible = True Then
            pnlReportes.Visible = False
            btnSalir.Location = New Point(0, 227)
            SubMenus.HideSync(pnlReportes)
        Else
            pnlReportes.Visible = True
            btnSalir.Location = New Point(3, 305)
            SubMenus.ShowSync(pnlReportes)

        End If
    End Sub

    Private Sub btnConductores_Click_1(sender As Object, e As EventArgs) Handles btnConductores.Click
        Conductores1.BringToFront()
    End Sub

    Private Sub bntTiposLic_Click(sender As Object, e As EventArgs) Handles bntTiposLic.Click
        LicencesTypes1.BringToFront()

    End Sub
End Class