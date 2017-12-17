Imports System.Data.OleDb
Imports _02LogicaNegocios
Imports _03Entidades

Public Class Conductores

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim myDriver As New ConductoresEN()
            myDriver.Cedula = txtCedul.Text
            myDriver.NombreCompleto = txtNombre.Text
            myDriver.Tel_Celular = txtTel_Cel.Text
            myDriver.Tel_Casa = txtTel_Casa.Text
            myDriver.Fecha_Nacimiento = dtpNacimiento.Value
            myDriver.E_Mail = txtEmail.Text
            myDriver.Dir_Completa = txtAdress.Text
            myDriver.Observaciones = txtObser.Text
            If swtActivo.Value = True Then
                myDriver.Ind_Activo = True
            Else
                myDriver.Ind_Activo = False
            End If


            Dim myDriverAD As New ConductoresLN
            myDriverAD.InsertarConductor(myDriver)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            Dim myDriver As New ConductoresEN()
            myDriver.Cedula = txtCedul.Text
            myDriver.NombreCompleto = txtNombre.Text
            myDriver.Tel_Celular = txtTel_Cel.Text
            myDriver.Tel_Casa = txtTel_Casa.Text
            myDriver.Fecha_Nacimiento = dtpNacimiento.Value
            myDriver.E_Mail = txtEmail.Text
            myDriver.Dir_Completa = txtAdress.Text
            myDriver.Observaciones = txtObser.Text
            If swtActivo.Value = True Then
                myDriver.Ind_Activo = True
            Else
                myDriver.Ind_Activo = False
            End If

            Dim myDriverAD As New ConductoresLN
            myDriverAD.ModificarConductor(myDriver)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim Preguntar = MsgBox("Desea Borrar este conductor?", MsgBoxStyle.YesNo, "Confirmacion")
        If Preguntar = MsgBoxResult.Yes Then
            Try

                Dim myDriver As New ConductoresEN

                myDriver.NombreCompleto = txtNombre.Text
                myDriver.Tel_Celular = txtTel_Cel.Text
                myDriver.Tel_Casa = txtTel_Casa.Text
                myDriver.Fecha_Nacimiento = dtpNacimiento.Value
                myDriver.E_Mail = txtEmail.Text
                myDriver.Dir_Completa = txtAdress.Text
                myDriver.Observaciones = txtObser.Text
                If swtActivo.Value = True Then
                    myDriver.Ind_Activo = True
                Else
                    myDriver.Ind_Activo = False
                End If


                myDriver.Cedula = txtCedul.Text

                Dim myDriverLN As New ConductoresLN
                myDriverLN.BorrarConductor(myDriver)
                MessageBox.Show("Conductor Borrado con Exito")
                txtCedul.Clear()
                txtNombre.Clear()
                txtTel_Cel.Clear()
                txtTel_Casa.Clear()
                txtEmail.Clear()
                txtAdress.Clear()
                txtObser.Clear()
                swtActivo.Value = False
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim myDriver As ConductoresEN = Nothing
        Dim ValidaPro As New ConductoresLN
        myDriver = ValidaPro.ObtenerConductorPorCedula(txtBuscar.Text)
        If IsNothing(myDriver) Then
            MessageBox.Show("No Existe")
        Else
            txtCedul.Text = myDriver.Cedula
            txtNombre.Text = myDriver.NombreCompleto
            txtTel_Cel.Text = myDriver.Tel_Celular
            txtTel_Casa.Text = myDriver.Tel_Casa
            dtpNacimiento.Text = myDriver.Fecha_Nacimiento
            txtEmail.Text = myDriver.E_Mail
            txtAdress.Text = myDriver.Dir_Completa
            txtObser.Text = myDriver.Observaciones
            If swtActivo.Value = True Then
                myDriver.Ind_Activo = True
            Else
                myDriver.Ind_Activo = False
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)

    End Sub


End Class