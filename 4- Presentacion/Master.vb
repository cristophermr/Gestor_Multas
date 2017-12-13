﻿Imports _02LogicaNegocios

Public Class Master

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Close()
    End Sub

    Private Sub header_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    End Sub

    Private Sub bntListaMultas_Click(sender As Object, e As EventArgs)

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
        pnlCatalogos.Hide()
        pnlProcesos.Hide()
        Dim Conductores As Conductores
        bntProcesos.Location = New Point(3, 130)
        btnReportes.Location = New Point(3, 179)
        btnSalir.Location = New Point(0, 227)
        ObtenerCondutoresData()

    End Sub

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles bntCatalogos.Click
        If pnlCatalogos.Visible = True Then
            pnlCatalogos.Visible = False
            bntProcesos.Location = New Point(3, 130)
            btnReportes.Location = New Point(3, 179)
            btnSalir.Location = New Point(0, 227)

            SubMenus.HideSync(pnlCatalogos)
        Else
            pnlCatalogos.Visible = True
            bntProcesos.Location = New Point(1, 257)
            btnReportes.Location = New Point(1, 350)
            btnSalir.Location = New Point(1, 398)
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Dim Acerca As New About
        DialogResult = Acerca.ShowDialog
    End Sub

    Private Sub bntProcesos_Click(sender As Object, e As EventArgs) Handles bntProcesos.Click
        If pnlProcesos.Visible = True Then
            pnlProcesos.Visible = False
            btnReportes.Location = New Point(3, 179)
            btnSalir.Location = New Point(0, 227)

            SubMenus.HideSync(pnlProcesos)
        Else
            pnlProcesos.Visible = True
            btnReportes.Location = New Point(1, 257)
            btnSalir.Location = New Point(-2, 305)
            SubMenus.ShowSync(pnlProcesos)

        End If
    End Sub

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs) Handles btnConductores.Click

    End Sub

    Private Sub Conductores1_Load(sender As Object, e As EventArgs) Handles Conductores1.Load

    End Sub
End Class