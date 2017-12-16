Imports System.Data.OleDb
Imports _02LogicaNegocios
Imports _03Entidades

Public Class Conductores

    'Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub pnlContenido_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenido.Paint

    'End Sub

    'Private Sub dgvConductores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    'End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim myDriver As New ConductoresEN()
            myDriver.Cedula = txtCedula.Text
            myDriver.NombreCompleto = txtNombre.Text
            myDriver.Tel_Celular = txtTel_Cel.Text
            myDriver.Tel_Casa = txtTel_Casa.Text
            myDriver.Fecha_Nacimiento = dtpNacimiento.Value
            myDriver.E_Mail = txtEmail.Text
            myDriver.Dir_Completa = txtDireccion.Text
            myDriver.Observaciones = txtObservaciones.Text
            If rdbtnSi.Checked Then myDriver.Ind_Activo = False
            If rdbtnNo.Checked Then myDriver.Ind_Activo = True

            Dim myDriverAD As New ConductoresLN
            myDriverAD.InsertarConductor(myDriver)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            Dim myDriver As New ConductoresEN()
            myDriver.Cedula = txtCedula.Text
            myDriver.NombreCompleto =
            myDriver.Tel_Celular =
            myDriver.Tel_Casa =
            myDriver.Fecha_Nacimiento =
            myDriver.E_Mail =
            myDriver.Dir_Completa =
            myDriver.Observaciones =
            Dim myDriverAD As New ConductoresLN
            myDriverAD.ModificarConductor(myDriver)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub


End Class