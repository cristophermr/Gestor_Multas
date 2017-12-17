Imports _02LogicaNegocios
Imports _03Entidades

Public Class LicencesTypes
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles bntCod.Click
        txtCodLicen.Text = CInt(Math.Ceiling(Rnd() * 999)) + 1
    End Sub

    Private Sub pnlContenido_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenido.Paint

    End Sub
    Private Sub Tipos_Licencias(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim myDriver As New Tipos_LicenciasEN()
            myDriver.Codigo_Tipo_Licencia = txtCodLicen.Text
            myDriver.Nombre_Tipo = txtTipo.Text
            myDriver.Observaciones = txtObservacion.Text

            Dim myDriverAD As New Tipos_LicenciasLN
            myDriverAD.InsertarTip_Lic(myDriver)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            Dim myDriver As New Tipos_LicenciasEN()
            bntCod.Enabled = False
            myDriver.Codigo_Tipo_Licencia = txtCodLicen.Text
            myDriver.Nombre_Tipo = txtTipo.Text
            myDriver.Observaciones = txtObservacion.Text

            Dim myDriverAD As New Tipos_LicenciasLN
            myDriverAD.ModificarTip_Lic(myDriver)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim Preguntar = MsgBox("Desea Borrar este tipo de licencia?", MsgBoxStyle.YesNo, "Confirmacion")
        If Preguntar = MsgBoxResult.Yes Then
            Try

                Dim myDriver As New Tipos_LicenciasEN

                myDriver.Codigo_Tipo_Licencia = txtCodLicen.Text
                myDriver.Nombre_Tipo = txtTipo.Text
                myDriver.Observaciones = txtObservacion.Text

                Dim myDriverLN As New Tipos_LicenciasLN
                myDriverLN.BorrarTip_Lic(myDriver)
                MessageBox.Show("Conductor Borrado con Exito")
                txtCodLicen.Clear()
                txtTipo.Clear()
                txtObservacion.Clear()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim myDriver As Tipos_LicenciasEN = Nothing
        Dim ValidaPro As New Tipos_LicenciasLN
        myDriver = ValidaPro.ObtenerTip_LicPorCodigo(txtBuscar.Text)
        If IsNothing(myDriver) Then
            MessageBox.Show("No Existe")
        Else
            txtCodLicen.Text = myDriver.Codigo_Tipo_Licencia
            txtTipo.Text = myDriver.Nombre_Tipo
            txtObservacion.Text = myDriver.Observaciones
        End If
    End Sub
End Class
