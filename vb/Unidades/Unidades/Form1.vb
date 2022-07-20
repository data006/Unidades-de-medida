Public Class frmUnidadesMedida

    Dim chkBoxes As CheckBox = Nothing
    Dim dato As Double = 0
    Dim resultado As Double = 0



    'Bloquear no numericos
    Private Sub txtUnidades_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidades.KeyPress

        If txtUnidades.Text = String.Empty Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-"

        ElseIf Not txtUnidades.Text.Contains(".") Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."

        ElseIf Not txtUnidades.Text.Contains("-") Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-"

        ElseIf txtUnidades.Text.Contains(".") And txtUnidades.Text.Contains("-") Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        End If

    End Sub





    'LongitudIn
    Private Sub chkMm_Click(sender As Object, e As EventArgs) Handles chkMm.Click

        'Desactivar los grp de salida no utiles
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpLongitudOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkMm.Checked = True Then

            If chkCm.Checked = True Then

                chkCm.Checked = False

            End If

            If chkM.Checked = True Then

                chkM.Checked = False

            End If

            If chkKm.Checked = True Then

                chkKm.Checked = False

            End If

            If chkIn.Checked = True Then

                chkIn.Checked = False

            End If

            If chkFt.Checked = True Then

                chkFt.Checked = False

            End If

            If chkYd.Checked = True Then

                chkYd.Checked = False

            End If

            If chkMi.Checked = True Then

                chkMi.Checked = False

            End If

            If grpLongitudOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpLongitudOut.Enabled = True

                For Each Item As Object In Me.grpLongitudOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkMmOut.Enabled = False

            End If

        End If

    End Sub



    Private Sub chkCm_Click(sender As Object, e As EventArgs) Handles chkCm.Click

        'Desactivar los grp de salida no utiles
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpLongitudOut.Enabled = True



        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkCm.Checked = True Then

            If chkMm.Checked = True Then

                chkMm.Checked = False

            End If

            If chkM.Checked = True Then

                chkM.Checked = False

            End If

            If chkKm.Checked = True Then

                chkKm.Checked = False

            End If

            If chkIn.Checked = True Then

                chkIn.Checked = False

            End If

            If chkFt.Checked = True Then

                chkFt.Checked = False

            End If

            If chkYd.Checked = True Then

                chkYd.Checked = False

            End If

            If chkMi.Checked = True Then

                chkMi.Checked = False

            End If

            If grpLongitudOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpLongitudOut.Enabled = True

                For Each Item As Object In Me.grpLongitudOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkCmOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkM_Click(sender As Object, e As EventArgs) Handles chkM.Click

        'Desactivar los grp de salida no utiles
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpLongitudOut.Enabled = True



        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkM.Checked = True Then

            If chkMm.Checked = True Then

                chkMm.Checked = False

            End If

            If chkCm.Checked = True Then

                chkCm.Checked = False

            End If

            If chkKm.Checked = True Then

                chkKm.Checked = False

            End If

            If chkIn.Checked = True Then

                chkIn.Checked = False

            End If

            If chkFt.Checked = True Then

                chkFt.Checked = False

            End If

            If chkYd.Checked = True Then

                chkYd.Checked = False

            End If

            If chkMi.Checked = True Then

                chkMi.Checked = False

            End If

            If grpLongitudOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpLongitudOut.Enabled = True

                For Each Item As Object In Me.grpLongitudOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkMOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkKm_Click(sender As Object, e As EventArgs) Handles chkKm.Click

        'Desactivar los grp de salida no utiles
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpLongitudOut.Enabled = True


        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkKm.Checked = True Then

            If chkMm.Checked = True Then

                chkMm.Checked = False

            End If

            If chkM.Checked = True Then

                chkM.Checked = False

            End If

            If chkCm.Checked = True Then

                chkCm.Checked = False

            End If

            If chkIn.Checked = True Then

                chkIn.Checked = False

            End If

            If chkFt.Checked = True Then

                chkFt.Checked = False

            End If

            If chkYd.Checked = True Then

                chkYd.Checked = False

            End If

            If chkMi.Checked = True Then

                chkMi.Checked = False

            End If

            If grpLongitudOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpLongitudOut.Enabled = True

                For Each Item As Object In Me.grpLongitudOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkKmOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkIn_Click(sender As Object, e As EventArgs) Handles chkIn.Click

        'Desactivar los grp de salida no utiles
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpLongitudOut.Enabled = True


        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkIn.Checked = True Then

            If chkMm.Checked = True Then

                chkMm.Checked = False

            End If

            If chkM.Checked = True Then

                chkM.Checked = False

            End If

            If chkKm.Checked = True Then

                chkKm.Checked = False

            End If

            If chkCm.Checked = True Then

                chkCm.Checked = False

            End If

            If chkFt.Checked = True Then

                chkFt.Checked = False

            End If

            If chkYd.Checked = True Then

                chkYd.Checked = False

            End If

            If chkMi.Checked = True Then

                chkMi.Checked = False

            End If

            If grpLongitudOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpLongitudOut.Enabled = True

                For Each Item As Object In Me.grpLongitudOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkInOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkFt_Click(sender As Object, e As EventArgs) Handles chkFt.Click

        'Desactivar los grp de salida no utiles
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpLongitudOut.Enabled = True


        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkFt.Checked = True Then

            If chkMm.Checked = True Then

                chkMm.Checked = False

            End If

            If chkM.Checked = True Then

                chkM.Checked = False

            End If

            If chkKm.Checked = True Then

                chkKm.Checked = False

            End If

            If chkIn.Checked = True Then

                chkIn.Checked = False

            End If

            If chkCm.Checked = True Then

                chkCm.Checked = False

            End If

            If chkYd.Checked = True Then

                chkYd.Checked = False

            End If

            If chkMi.Checked = True Then

                chkMi.Checked = False

            End If

            If grpLongitudOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpLongitudOut.Enabled = True

                For Each Item As Object In Me.grpLongitudOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkFtOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkYd_Click(sender As Object, e As EventArgs) Handles chkYd.Click
        'Desactivar los grp de salida no utiles
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpLongitudOut.Enabled = True


        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkYd.Checked = True Then

            If chkMm.Checked = True Then

                chkMm.Checked = False

            End If

            If chkM.Checked = True Then

                chkM.Checked = False

            End If

            If chkKm.Checked = True Then

                chkKm.Checked = False

            End If

            If chkIn.Checked = True Then

                chkIn.Checked = False

            End If

            If chkFt.Checked = True Then

                chkFt.Checked = False

            End If

            If chkCm.Checked = True Then

                chkCm.Checked = False

            End If

            If chkMi.Checked = True Then

                chkMi.Checked = False

            End If

            If grpLongitudOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpLongitudOut.Enabled = True

                For Each Item As Object In Me.grpLongitudOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkYdOut.Enabled = False

            End If

        End If
    End Sub

    Private Sub chkMi_Click(sender As Object, e As EventArgs) Handles chkMi.Click
        'Desactivar los grp de salida no utiles
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpLongitudOut.Enabled = True


        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkMi.Checked = True Then

            If chkMm.Checked = True Then

                chkMm.Checked = False

            End If

            If chkM.Checked = True Then

                chkM.Checked = False

            End If

            If chkKm.Checked = True Then

                chkKm.Checked = False

            End If

            If chkIn.Checked = True Then

                chkIn.Checked = False

            End If

            If chkFt.Checked = True Then

                chkFt.Checked = False

            End If

            If chkYd.Checked = True Then

                chkYd.Checked = False

            End If

            If chkCm.Checked = True Then

                chkCm.Checked = False

            End If

            If grpLongitudOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpLongitudOut.Enabled = True

                For Each Item As Object In Me.grpLongitudOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkMiOut.Enabled = False

            End If

        End If

    End Sub





    'MasaIn
    Private Sub chkMg_Click(sender As Object, e As EventArgs) Handles chkMg.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpMasaOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkMg.Checked = True Then

            If chkG.Checked = True Then

                chkG.Checked = False

            End If

            If chkKg.Checked = True Then

                chkKg.Checked = False

            End If

            If chkTon.Checked = True Then

                chkTon.Checked = False

            End If

            If chkOz.Checked = True Then

                chkOz.Checked = False

            End If

            If chkLb.Checked = True Then

                chkLb.Checked = False

            End If

            If chkTonInglesa.Checked = True Then

                chkTonInglesa.Checked = False

            End If



            If grpMasaOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpMasaOut.Enabled = True

                For Each Item As Object In Me.grpMasaOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkMgOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkG_Click(sender As Object, e As EventArgs) Handles chkG.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpMasaOut.Enabled = True



        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkG.Checked = True Then

            If chkMg.Checked = True Then

                chkMg.Checked = False

            End If

            If chkKg.Checked = True Then

                chkKg.Checked = False

            End If

            If chkTon.Checked = True Then

                chkTon.Checked = False

            End If

            If chkOz.Checked = True Then

                chkOz.Checked = False

            End If

            If chkLb.Checked = True Then

                chkLb.Checked = False

            End If

            If chkTonInglesa.Checked = True Then

                chkTonInglesa.Checked = False

            End If



            If grpMasaOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpMasaOut.Enabled = True

                For Each Item As Object In Me.grpMasaOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkGOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkKg_Click(sender As Object, e As EventArgs) Handles chkKg.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpMasaOut.Enabled = True



        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkKg.Checked = True Then

            If chkMg.Checked = True Then

                chkMg.Checked = False

            End If

            If chkG.Checked = True Then

                chkG.Checked = False

            End If

            If chkTon.Checked = True Then

                chkTon.Checked = False

            End If

            If chkOz.Checked = True Then

                chkOz.Checked = False

            End If

            If chkLb.Checked = True Then

                chkLb.Checked = False

            End If

            If chkTonInglesa.Checked = True Then

                chkTonInglesa.Checked = False

            End If



            If grpMasaOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpMasaOut.Enabled = True

                For Each Item As Object In Me.grpMasaOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkKgOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkTon_Click(sender As Object, e As EventArgs) Handles chkTon.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpMasaOut.Enabled = True



        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkTon.Checked = True Then

            If chkMg.Checked = True Then

                chkMg.Checked = False

            End If

            If chkKg.Checked = True Then

                chkKg.Checked = False

            End If

            If chkG.Checked = True Then

                chkG.Checked = False

            End If

            If chkOz.Checked = True Then

                chkOz.Checked = False

            End If

            If chkLb.Checked = True Then

                chkLb.Checked = False

            End If

            If chkTonInglesa.Checked = True Then

                chkTonInglesa.Checked = False

            End If



            If grpMasaOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpMasaOut.Enabled = True

                For Each Item As Object In Me.grpMasaOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkTonOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkOz_Click(sender As Object, e As EventArgs) Handles chkOz.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpMasaOut.Enabled = True



        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkOz.Checked = True Then

            If chkMg.Checked = True Then

                chkMg.Checked = False

            End If

            If chkKg.Checked = True Then

                chkKg.Checked = False

            End If

            If chkTon.Checked = True Then

                chkTon.Checked = False

            End If

            If chkG.Checked = True Then

                chkG.Checked = False

            End If

            If chkLb.Checked = True Then

                chkLb.Checked = False

            End If

            If chkTonInglesa.Checked = True Then

                chkTonInglesa.Checked = False

            End If



            If grpMasaOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpMasaOut.Enabled = True

                For Each Item As Object In Me.grpMasaOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkOzOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkLb_Click(sender As Object, e As EventArgs) Handles chkLb.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpMasaOut.Enabled = True



        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkLb.Checked = True Then

            If chkMg.Checked = True Then

                chkMg.Checked = False

            End If

            If chkKg.Checked = True Then

                chkKg.Checked = False

            End If

            If chkTon.Checked = True Then

                chkTon.Checked = False

            End If

            If chkOz.Checked = True Then

                chkOz.Checked = False

            End If

            If chkG.Checked = True Then

                chkG.Checked = False

            End If

            If chkTonInglesa.Checked = True Then

                chkTonInglesa.Checked = False

            End If



            If grpMasaOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpMasaOut.Enabled = True

                For Each Item As Object In Me.grpMasaOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkLbOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkTonInglesa_Click(sender As Object, e As EventArgs) Handles chkTonInglesa.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpMasaOut.Enabled = True



        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkTonInglesa.Checked = True Then

            If chkMg.Checked = True Then

                chkMg.Checked = False

            End If

            If chkKg.Checked = True Then

                chkKg.Checked = False

            End If

            If chkTon.Checked = True Then

                chkTon.Checked = False

            End If

            If chkOz.Checked = True Then

                chkOz.Checked = False

            End If

            If chkLb.Checked = True Then

                chkLb.Checked = False

            End If

            If chkG.Checked = True Then

                chkG.Checked = False

            End If



            If grpMasaOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpMasaOut.Enabled = True

                For Each Item As Object In Me.grpMasaOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkTonInglesaOut.Enabled = False

            End If

        End If

    End Sub





    'PresionIn
    Private Sub chkPsi_Click(sender As Object, e As EventArgs) Handles chkPsi.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpPresionOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkPsi.Checked = True Then

            If chkTorr.Checked = True Then

                chkTorr.Checked = False

            End If

            If chkAtm.Checked = True Then

                chkAtm.Checked = False

            End If

            If chkBar.Checked = True Then

                chkBar.Checked = False

            End If

            If chkPa.Checked = True Then

                chkPa.Checked = False

            End If





            If grpPresionOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpPresionOut.Enabled = True

                For Each Item As Object In Me.grpPresionOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkPsiOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkTorr_Click(sender As Object, e As EventArgs) Handles chkTorr.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpPresionOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkTorr.Checked = True Then

            If chkPsi.Checked = True Then

                chkPsi.Checked = False

            End If

            If chkAtm.Checked = True Then

                chkAtm.Checked = False

            End If

            If chkBar.Checked = True Then

                chkBar.Checked = False

            End If

            If chkPa.Checked = True Then

                chkPa.Checked = False

            End If





            If grpPresionOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpPresionOut.Enabled = True

                For Each Item As Object In Me.grpPresionOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkTorrOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkAtm_Click(sender As Object, e As EventArgs) Handles chkAtm.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpPresionOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkAtm.Checked = True Then

            If chkTorr.Checked = True Then

                chkTorr.Checked = False

            End If

            If chkPsi.Checked = True Then

                chkPsi.Checked = False

            End If

            If chkBar.Checked = True Then

                chkBar.Checked = False

            End If

            If chkPa.Checked = True Then

                chkPa.Checked = False

            End If





            If grpPresionOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpPresionOut.Enabled = True

                For Each Item As Object In Me.grpPresionOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkAtmOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkBar_Click(sender As Object, e As EventArgs) Handles chkBar.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpPresionOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkBar.Checked = True Then

            If chkTorr.Checked = True Then

                chkTorr.Checked = False

            End If

            If chkAtm.Checked = True Then

                chkAtm.Checked = False

            End If

            If chkPsi.Checked = True Then

                chkPsi.Checked = False

            End If

            If chkPa.Checked = True Then

                chkPa.Checked = False

            End If





            If grpPresionOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpPresionOut.Enabled = True

                For Each Item As Object In Me.grpPresionOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkBarOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkPa_Click(sender As Object, e As EventArgs) Handles chkPa.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpPresionOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkPa.Checked = True Then

            If chkTorr.Checked = True Then

                chkTorr.Checked = False

            End If

            If chkAtm.Checked = True Then

                chkAtm.Checked = False

            End If

            If chkBar.Checked = True Then

                chkBar.Checked = False

            End If

            If chkPsi.Checked = True Then

                chkPsi.Checked = False

            End If





            If grpPresionOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpPresionOut.Enabled = True

                For Each Item As Object In Me.grpPresionOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkPaOut.Enabled = False

            End If

        End If

    End Sub










    'VelocidadIn
    Private Sub chkMS_Click(sender As Object, e As EventArgs) Handles chkMS.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpVelocidadOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkMS.Checked = True Then

            If chkKMHR.Checked = True Then

                chkKMHR.Checked = False

            End If

            If chkFTS.Checked = True Then

                chkFTS.Checked = False

            End If

            If chkMIHR.Checked = True Then

                chkMIHR.Checked = False

            End If


            If grpVelocidadOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVelocidadOut.Enabled = True

                For Each Item As Object In Me.grpVelocidadOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkMSOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkKMHR_Click(sender As Object, e As EventArgs) Handles chkKMHR.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpVelocidadOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkKMHR.Checked = True Then

            If chkMS.Checked = True Then

                chkMS.Checked = False

            End If

            If chkFTS.Checked = True Then

                chkFTS.Checked = False

            End If

            If chkMIHR.Checked = True Then

                chkMIHR.Checked = False

            End If


            If grpVelocidadOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVelocidadOut.Enabled = True

                For Each Item As Object In Me.grpVelocidadOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkKMHROut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkFTS_Click(sender As Object, e As EventArgs) Handles chkFTS.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpVelocidadOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkFTS.Checked = True Then

            If chkKMHR.Checked = True Then

                chkKMHR.Checked = False

            End If

            If chkMS.Checked = True Then

                chkMS.Checked = False

            End If

            If chkMIHR.Checked = True Then

                chkMIHR.Checked = False

            End If


            If grpVelocidadOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVelocidadOut.Enabled = True

                For Each Item As Object In Me.grpVelocidadOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkFTSOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkMIHR_Click(sender As Object, e As EventArgs) Handles chkMIHR.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpVelocidadOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkMIHR.Checked = True Then

            If chkKMHR.Checked = True Then

                chkKMHR.Checked = False

            End If

            If chkFTS.Checked = True Then

                chkFTS.Checked = False

            End If

            If chkMS.Checked = True Then

                chkMS.Checked = False

            End If


            If grpVelocidadOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVelocidadOut.Enabled = True

                For Each Item As Object In Me.grpVelocidadOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkMIHROut.Enabled = False

            End If

        End If

    End Sub








    'Tiempo
    Private Sub chkS_Click(sender As Object, e As EventArgs) Handles chkS.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpTiempoOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkS.Checked = True Then

            If chkMin.Checked = True Then

                chkMin.Checked = False

            End If

            If chkHr.Checked = True Then

                chkHr.Checked = False

            End If

            If chkDias.Checked = True Then

                chkDias.Checked = False

            End If


            If grpTiempoOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpTiempoOut.Enabled = True

                For Each Item As Object In Me.grpTiempoOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkSOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkMin_Click(sender As Object, e As EventArgs) Handles chkMin.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpTiempoOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkMin.Checked = True Then

            If chkS.Checked = True Then

                chkS.Checked = False

            End If

            If chkHr.Checked = True Then

                chkHr.Checked = False

            End If

            If chkDias.Checked = True Then

                chkDias.Checked = False

            End If


            If grpTiempoOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpTiempoOut.Enabled = True

                For Each Item As Object In Me.grpTiempoOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkMinOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkHr_Click(sender As Object, e As EventArgs) Handles chkHr.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpTiempoOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkHr.Checked = True Then

            If chkMin.Checked = True Then

                chkMin.Checked = False

            End If

            If chkS.Checked = True Then

                chkS.Checked = False

            End If

            If chkDias.Checked = True Then

                chkDias.Checked = False

            End If


            If grpTiempoOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpTiempoOut.Enabled = True

                For Each Item As Object In Me.grpTiempoOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkHrOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkDias_Click(sender As Object, e As EventArgs) Handles chkDias.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpVolumenOut.Enabled = False
        grpTiempoOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVolumen.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkDias.Checked = True Then

            If chkMin.Checked = True Then

                chkMin.Checked = False

            End If

            If chkHr.Checked = True Then

                chkHr.Checked = False

            End If

            If chkS.Checked = True Then

                chkS.Checked = False

            End If


            If grpTiempoOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpTiempoOut.Enabled = True

                For Each Item As Object In Me.grpTiempoOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkDiasOut.Enabled = False

            End If

        End If

    End Sub









    'Volumen
    Private Sub chkML_Click(sender As Object, e As EventArgs) Handles chkML.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkML.Checked = True Then

            If chkL.Checked = True Then

                chkL.Checked = False

            End If

            If chkPinta.Checked = True Then

                chkPinta.Checked = False

            End If

            If chkCuarto.Checked = True Then

                chkCuarto.Checked = False

            End If

            If chkMCubico.Checked = True Then

                chkMCubico.Checked = False

            End If

            If chkOzVol.Checked = True Then

                chkOzVol.Checked = False

            End If

            If chkGalon.Checked = True Then

                chkGalon.Checked = False

            End If


            If grpVolumenOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVolumenOut.Enabled = True

                For Each Item As Object In Me.grpVolumenOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkMLOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkL_Click(sender As Object, e As EventArgs) Handles chkL.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkL.Checked = True Then

            If chkML.Checked = True Then

                chkML.Checked = False

            End If

            If chkPinta.Checked = True Then

                chkPinta.Checked = False

            End If

            If chkCuarto.Checked = True Then

                chkCuarto.Checked = False

            End If

            If chkMCubico.Checked = True Then

                chkMCubico.Checked = False

            End If

            If chkOzVol.Checked = True Then

                chkOzVol.Checked = False

            End If

            If chkGalon.Checked = True Then

                chkGalon.Checked = False

            End If


            If grpVolumenOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVolumenOut.Enabled = True

                For Each Item As Object In Me.grpVolumenOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkLOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkPinta_Click(sender As Object, e As EventArgs) Handles chkPinta.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkPinta.Checked = True Then

            If chkL.Checked = True Then

                chkL.Checked = False

            End If

            If chkML.Checked = True Then

                chkML.Checked = False

            End If

            If chkCuarto.Checked = True Then

                chkCuarto.Checked = False

            End If

            If chkMCubico.Checked = True Then

                chkMCubico.Checked = False

            End If

            If chkOzVol.Checked = True Then

                chkOzVol.Checked = False

            End If

            If chkGalon.Checked = True Then

                chkGalon.Checked = False

            End If


            If grpVolumenOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVolumenOut.Enabled = True

                For Each Item As Object In Me.grpVolumenOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkPintaOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkCuarto_Click(sender As Object, e As EventArgs) Handles chkCuarto.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkCuarto.Checked = True Then

            If chkL.Checked = True Then

                chkL.Checked = False

            End If

            If chkPinta.Checked = True Then

                chkPinta.Checked = False

            End If

            If chkML.Checked = True Then

                chkML.Checked = False

            End If

            If chkMCubico.Checked = True Then

                chkMCubico.Checked = False

            End If

            If chkOzVol.Checked = True Then

                chkOzVol.Checked = False

            End If

            If chkGalon.Checked = True Then

                chkGalon.Checked = False

            End If


            If grpVolumenOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVolumenOut.Enabled = True

                For Each Item As Object In Me.grpVolumenOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkCuartoOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkMCubico_Click(sender As Object, e As EventArgs) Handles chkMCubico.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkMCubico.Checked = True Then

            If chkL.Checked = True Then

                chkL.Checked = False

            End If

            If chkPinta.Checked = True Then

                chkPinta.Checked = False

            End If

            If chkCuarto.Checked = True Then

                chkCuarto.Checked = False

            End If

            If chkML.Checked = True Then

                chkML.Checked = False

            End If

            If chkOzVol.Checked = True Then

                chkOzVol.Checked = False

            End If

            If chkGalon.Checked = True Then

                chkGalon.Checked = False

            End If


            If grpVolumenOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVolumenOut.Enabled = True

                For Each Item As Object In Me.grpVolumenOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkMCubicoOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkOzVol_Click(sender As Object, e As EventArgs) Handles chkOzVol.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkOzVol.Checked = True Then

            If chkL.Checked = True Then

                chkL.Checked = False

            End If

            If chkPinta.Checked = True Then

                chkPinta.Checked = False

            End If

            If chkCuarto.Checked = True Then

                chkCuarto.Checked = False

            End If

            If chkMCubico.Checked = True Then

                chkMCubico.Checked = False

            End If

            If chkML.Checked = True Then

                chkML.Checked = False

            End If

            If chkGalon.Checked = True Then

                chkGalon.Checked = False

            End If


            If grpVolumenOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVolumenOut.Enabled = True

                For Each Item As Object In Me.grpVolumenOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkOzVolOut.Enabled = False

            End If

        End If

    End Sub

    Private Sub chkGalon_Click(sender As Object, e As EventArgs) Handles chkGalon.Click

        'Desactivar los grp de salida no utiles
        grpLongitudOut.Enabled = False
        grpMasaOut.Enabled = False
        grpPresionOut.Enabled = False
        grpVelocidadOut.Enabled = False
        grpTiempoOut.Enabled = False
        grpVolumenOut.Enabled = True




        'Limpiar chks de entrada de otros grupos
        For Each Item As Object In Me.grpLongitud.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpMasa.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpPresion.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpVelocidad.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next

        For Each Item As Object In Me.grpTiempo.Controls

            If TypeOf Item Is CheckBox Then
                chkBoxes = Item
                chkBoxes.Checked = False
            End If

        Next


        'Desactivar chks del mismo grupo
        If chkGalon.Checked = True Then

            If chkL.Checked = True Then

                chkL.Checked = False

            End If

            If chkPinta.Checked = True Then

                chkPinta.Checked = False

            End If

            If chkCuarto.Checked = True Then

                chkCuarto.Checked = False

            End If

            If chkMCubico.Checked = True Then

                chkMCubico.Checked = False

            End If

            If chkOzVol.Checked = True Then

                chkOzVol.Checked = False

            End If

            If chkML.Checked = True Then

                chkML.Checked = False

            End If


            If grpVolumenOut.Enabled = True Then

                'Activar grp util y desactivar la unidad de entrada en la salida
                grpVolumenOut.Enabled = True

                For Each Item As Object In Me.grpVolumenOut.Controls

                    If TypeOf Item Is CheckBox Then
                        chkBoxes = Item
                        chkBoxes.Enabled = True
                    End If

                Next

                chkGalonOut.Enabled = False

            End If

        End If

    End Sub




    'CONVERTIR
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click



        If txtUnidades.Text.Contains("-") Then

            MsgBox("Valor invalido")
            Exit Sub

        Else

            dato = Val(txtUnidades.Text)

            If dato <= 0 Then

                MsgBox("Valor invalido")
                Exit Sub

            End If

        End If

        If grpLongitudOut.Enabled = True Then

            If chkMm.Checked = True Then

                If chkCmOut.Checked = True Then

                    resultado = (dato / 10)
                    MsgBox("En Cm: " & resultado)
                    resultado = 0

                End If

                If chkMOut.Checked = True Then

                    resultado = (dato / 1000)
                    MsgBox("En m: " & resultado)
                    resultado = 0

                End If

                If chkKmOut.Checked = True Then

                    resultado = (dato / 1000000)
                    MsgBox("En Km: " & resultado)
                    resultado = 0

                End If

                If chkInOut.Checked = True Then

                    resultado = (dato / 25.4)
                    MsgBox("En In: " & resultado)
                    resultado = 0

                End If

                If chkFtOut.Checked = True Then

                    resultado = (dato / 305)
                    MsgBox("En Ft: " & resultado)
                    resultado = 0

                End If

                If chkYdOut.Checked = True Then

                    resultado = (dato / 914)
                    MsgBox("En Yd: " & resultado)
                    resultado = 0

                End If

                If chkMiOut.Checked = True Then

                    resultado = (dato / 1609000.0)
                    MsgBox("En Mi: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkCm.Checked = True Then

                If chkMmOut.Checked = True Then

                    resultado = (dato * 10)
                    MsgBox("En mm: " & resultado)
                    resultado = 0

                End If

                If chkMOut.Checked = True Then

                    resultado = (dato / 100)
                    MsgBox("En m: " & resultado)
                    resultado = 0

                End If

                If chkKmOut.Checked = True Then

                    resultado = (dato / 100000)
                    MsgBox("En Km: " & resultado)
                    resultado = 0

                End If

                If chkInOut.Checked = True Then

                    resultado = (dato / 2.54)
                    MsgBox("En In: " & resultado)
                    resultado = 0

                End If

                If chkFtOut.Checked = True Then

                    resultado = (dato / 30.48)
                    MsgBox("En Ft: " & resultado)
                    resultado = 0

                End If

                If chkYdOut.Checked = True Then

                    resultado = (dato / 91.44)
                    MsgBox("En Yd: " & resultado)
                    resultado = 0

                End If

                If chkMiOut.Checked = True Then

                    resultado = (dato / 160934)
                    MsgBox("En Mi: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkM.Checked = True Then

                If chkMmOut.Checked = True Then

                    resultado = (dato * 1000)
                    MsgBox("En mm: " & resultado)
                    resultado = 0

                End If

                If chkCmOut.Checked = True Then

                    resultado = (dato * 100)
                    MsgBox("En cm: " & resultado)
                    resultado = 0

                End If

                If chkKmOut.Checked = True Then

                    resultado = (dato / 1000)
                    MsgBox("En Km: " & resultado)
                    resultado = 0

                End If

                If chkInOut.Checked = True Then

                    resultado = (dato * 39.37)
                    MsgBox("En In: " & resultado)
                    resultado = 0

                End If

                If chkFtOut.Checked = True Then

                    resultado = (dato * 3.281)
                    MsgBox("En Ft: " & resultado)
                    resultado = 0

                End If

                If chkYdOut.Checked = True Then

                    resultado = (dato * 1.094)
                    MsgBox("En Yd: " & resultado)
                    resultado = 0

                End If

                If chkMiOut.Checked = True Then

                    resultado = (dato / 1609)
                    MsgBox("En Mi: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkKm.Checked = True Then

                If chkMmOut.Checked = True Then

                    resultado = (dato * 1000000.0)
                    MsgBox("En mm: " & resultado)
                    resultado = 0

                End If

                If chkCmOut.Checked = True Then

                    resultado = (dato * 100000)
                    MsgBox("En cm: " & resultado)
                    resultado = 0

                End If

                If chkMOut.Checked = True Then

                    resultado = (dato * 1000)
                    MsgBox("En m: " & resultado)
                    resultado = 0

                End If

                If chkInOut.Checked = True Then

                    resultado = (dato * 39370)
                    MsgBox("En In: " & resultado)
                    resultado = 0

                End If

                If chkFtOut.Checked = True Then

                    resultado = (dato * 3281)
                    MsgBox("En Ft: " & resultado)
                    resultado = 0

                End If

                If chkYdOut.Checked = True Then

                    resultado = (dato * 1094)
                    MsgBox("En Yd: " & resultado)
                    resultado = 0

                End If

                If chkMiOut.Checked = True Then

                    resultado = (dato / 1.609)
                    MsgBox("En Mi: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkIn.Checked = True Then

                If chkMmOut.Checked = True Then

                    resultado = (dato * 25.4)
                    MsgBox("En mm: " & resultado)
                    resultado = 0

                End If

                If chkCmOut.Checked = True Then

                    resultado = (dato * 2.54)
                    MsgBox("En cm: " & resultado)
                    resultado = 0

                End If

                If chkMOut.Checked = True Then

                    resultado = (dato / 39.37)
                    MsgBox("En m: " & resultado)
                    resultado = 0

                End If

                If chkKmOut.Checked = True Then

                    resultado = (dato / 39370)
                    MsgBox("En Km: " & resultado)
                    resultado = 0

                End If

                If chkFtOut.Checked = True Then

                    resultado = (dato / 12)
                    MsgBox("En Ft: " & resultado)
                    resultado = 0

                End If

                If chkYdOut.Checked = True Then

                    resultado = (dato / 36)
                    MsgBox("En Yd: " & resultado)
                    resultado = 0

                End If

                If chkMiOut.Checked = True Then

                    resultado = (dato / 63360)
                    MsgBox("En Mi: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkFt.Checked = True Then

                If chkMmOut.Checked = True Then

                    resultado = (dato * 305)
                    MsgBox("En mm: " & resultado)
                    resultado = 0

                End If

                If chkCmOut.Checked = True Then

                    resultado = (dato * 30.48)
                    MsgBox("En cm: " & resultado)
                    resultado = 0

                End If

                If chkMOut.Checked = True Then

                    resultado = (dato / 3.281)
                    MsgBox("En m: " & resultado)
                    resultado = 0

                End If

                If chkKmOut.Checked = True Then

                    resultado = (dato / 3281)
                    MsgBox("En Km: " & resultado)
                    resultado = 0

                End If

                If chkInOut.Checked = True Then

                    resultado = (dato * 12)
                    MsgBox("En In: " & resultado)
                    resultado = 0

                End If

                If chkYdOut.Checked = True Then

                    resultado = (dato / 3)
                    MsgBox("En Yd: " & resultado)
                    resultado = 0

                End If

                If chkMiOut.Checked = True Then

                    resultado = (dato / 5280)
                    MsgBox("En Mi: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkYd.Checked = True Then

                If chkMmOut.Checked = True Then

                    resultado = (dato * 914)
                    MsgBox("En mm: " & resultado)
                    resultado = 0

                End If

                If chkCmOut.Checked = True Then

                    resultado = (dato * 91.44)
                    MsgBox("En cm: " & resultado)
                    resultado = 0

                End If

                If chkMOut.Checked = True Then

                    resultado = (dato / 1.094)
                    MsgBox("En m: " & resultado)
                    resultado = 0

                End If

                If chkKmOut.Checked = True Then

                    resultado = (dato / 1094)
                    MsgBox("En Km: " & resultado)
                    resultado = 0

                End If

                If chkInOut.Checked = True Then

                    resultado = (dato * 36)
                    MsgBox("En In: " & resultado)
                    resultado = 0

                End If

                If chkFtOut.Checked = True Then

                    resultado = (dato * 3)
                    MsgBox("En Ft: " & resultado)
                    resultado = 0

                End If

                If chkMiOut.Checked = True Then

                    resultado = (dato / 1760)
                    MsgBox("En Mi: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkMi.Checked = True Then

                If chkMmOut.Checked = True Then

                    resultado = (dato * 1609000.0)
                    MsgBox("En mm: " & resultado)
                    resultado = 0

                End If

                If chkCmOut.Checked = True Then

                    resultado = (dato * 160934)
                    MsgBox("En cm: " & resultado)
                    resultado = 0

                End If

                If chkMOut.Checked = True Then

                    resultado = (dato * 1609)
                    MsgBox("En m: " & resultado)
                    resultado = 0

                End If

                If chkKmOut.Checked = True Then

                    resultado = (dato * 1.609)
                    MsgBox("En Km: " & resultado)
                    resultado = 0

                End If

                If chkInOut.Checked = True Then

                    resultado = (dato * 63360)
                    MsgBox("En In: " & resultado)
                    resultado = 0

                End If

                If chkFtOut.Checked = True Then

                    resultado = (dato * 5280)
                    MsgBox("En Ft: " & resultado)
                    resultado = 0

                End If

                If chkYdOut.Checked = True Then

                    resultado = (dato * 1760)
                    MsgBox("En Yd: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            End If

        ElseIf grpMasaOut.Enabled = True Then

            If chkMg.Checked = True Then

                If chkGOut.Checked = True Then

                    resultado = (dato / 1000)
                    MsgBox("En g: " & resultado)
                    resultado = 0

                End If

                If chkKgOut.Checked = True Then

                    resultado = (dato / 1000000.0)
                    MsgBox("En kg: " & resultado)
                    resultado = 0

                End If

                If chkTonOut.Checked = True Then

                    resultado = (dato / 1000000000.0)
                    MsgBox("En Ton: " & resultado)
                    resultado = 0

                End If

                If chkOzOut.Checked = True Then

                    resultado = (dato / 28350)
                    MsgBox("En Oz: " & resultado)
                    resultado = 0

                End If

                If chkLbOut.Checked = True Then

                    resultado = (dato / 453592)
                    MsgBox("En Lb: " & resultado)
                    resultado = 0

                End If

                If chkTonInglesaOut.Checked = True Then

                    resultado = (dato / 907200000.0)
                    MsgBox("En Tonelada Corta: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkG.Checked = True Then

                If chkMgOut.Checked = True Then

                    resultado = (dato * 1000)
                    MsgBox("En mg: " & resultado)
                    resultado = 0

                End If

                If chkKgOut.Checked = True Then

                    resultado = (dato / 1000)
                    MsgBox("En kg: " & resultado)
                    resultado = 0

                End If

                If chkTonOut.Checked = True Then

                    resultado = (dato / 1000000.0)
                    MsgBox("En Ton: " & resultado)
                    resultado = 0

                End If

                If chkOzOut.Checked = True Then

                    resultado = (dato / 28.35)
                    MsgBox("En Oz: " & resultado)
                    resultado = 0

                End If

                If chkLbOut.Checked = True Then

                    resultado = (dato / 454)
                    MsgBox("En Lb: " & resultado)
                    resultado = 0

                End If

                If chkTonInglesaOut.Checked = True Then

                    resultado = (dato / 907185)
                    MsgBox("En Tonelada Corta: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkKg.Checked = True Then

                If chkMgOut.Checked = True Then

                    resultado = (dato * 1000000.0)
                    MsgBox("En mg: " & resultado)
                    resultado = 0

                End If

                If chkGOut.Checked = True Then

                    resultado = (dato * 1000)
                    MsgBox("En g: " & resultado)
                    resultado = 0

                End If

                If chkTonOut.Checked = True Then

                    resultado = (dato / 1000)
                    MsgBox("En Ton: " & resultado)
                    resultado = 0

                End If

                If chkOzOut.Checked = True Then

                    resultado = (dato * 35.274)
                    MsgBox("En Oz: " & resultado)
                    resultado = 0

                End If

                If chkLbOut.Checked = True Then

                    resultado = (dato * 2.205)
                    MsgBox("En Lb: " & resultado)
                    resultado = 0

                End If

                If chkTonInglesaOut.Checked = True Then

                    resultado = (dato / 907)
                    MsgBox("En Tonelada Corta: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkTon.Checked = True Then

                If chkMgOut.Checked = True Then

                    resultado = (dato * 1000000000.0)
                    MsgBox("En mg: " & resultado)
                    resultado = 0

                End If

                If chkGOut.Checked = True Then

                    resultado = (dato * 1000000.0)
                    MsgBox("En g: " & resultado)
                    resultado = 0

                End If

                If chkKgOut.Checked = True Then

                    resultado = (dato * 1000)
                    MsgBox("En kg: " & resultado)
                    resultado = 0

                End If

                If chkOzOut.Checked = True Then

                    resultado = (dato * 35274)
                    MsgBox("En Oz: " & resultado)
                    resultado = 0

                End If

                If chkLbOut.Checked = True Then

                    resultado = (dato * 2205)
                    MsgBox("En Lb: " & resultado)
                    resultado = 0

                End If

                If chkTonInglesaOut.Checked = True Then

                    resultado = (dato * 1.102)
                    MsgBox("En Tonelada Corta: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkOz.Checked = True Then

                If chkMgOut.Checked = True Then

                    resultado = (dato * 28350)
                    MsgBox("En mg: " & resultado)
                    resultado = 0

                End If

                If chkGOut.Checked = True Then

                    resultado = (dato * 28.35)
                    MsgBox("En g: " & resultado)
                    resultado = 0

                End If

                If chkKgOut.Checked = True Then

                    resultado = (dato / 35.274)
                    MsgBox("En kg: " & resultado)
                    resultado = 0

                End If

                If chkTonOut.Checked = True Then

                    resultado = (dato / 35274)
                    MsgBox("En Ton: " & resultado)
                    resultado = 0

                End If

                If chkLbOut.Checked = True Then

                    resultado = (dato / 16)
                    MsgBox("En Lb: " & resultado)
                    resultado = 0

                End If

                If chkTonInglesaOut.Checked = True Then

                    resultado = (dato / 32000)
                    MsgBox("En Tonelada Corta: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkLb.Checked = True Then

                If chkMgOut.Checked = True Then

                    resultado = (dato * 453592)
                    MsgBox("En mg: " & resultado)
                    resultado = 0

                End If

                If chkGOut.Checked = True Then

                    resultado = (dato * 454)
                    MsgBox("En g: " & resultado)
                    resultado = 0

                End If

                If chkKgOut.Checked = True Then

                    resultado = (dato / 2.205)
                    MsgBox("En kg: " & resultado)
                    resultado = 0

                End If

                If chkTonOut.Checked = True Then

                    resultado = (dato / 2205)
                    MsgBox("En Ton: " & resultado)
                    resultado = 0

                End If

                If chkOzOut.Checked = True Then

                    resultado = (dato * 16)
                    MsgBox("En Oz: " & resultado)
                    resultado = 0

                End If

                If chkTonInglesaOut.Checked = True Then

                    resultado = (dato / 2000)
                    MsgBox("En Tonelada Corta: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            ElseIf chkTonInglesa.Checked = True Then

                If chkMgOut.Checked = True Then

                    resultado = (dato * 907200000.0)
                    MsgBox("En mg: " & resultado)
                    resultado = 0

                End If

                If chkGOut.Checked = True Then

                    resultado = (dato * 907185)
                    MsgBox("En g: " & resultado)
                    resultado = 0

                End If

                If chkKgOut.Checked = True Then

                    resultado = (dato * 907)
                    MsgBox("En kg: " & resultado)
                    resultado = 0

                End If

                If chkTonOut.Checked = True Then

                    resultado = (dato / 1.102)
                    MsgBox("En Ton: " & resultado)
                    resultado = 0

                End If

                If chkOzOut.Checked = True Then

                    resultado = (dato * 32000)
                    MsgBox("En Oz: " & resultado)
                    resultado = 0

                End If

                If chkLbOut.Checked = True Then

                    resultado = (dato * 2000)
                    MsgBox("En Lb: " & resultado)
                    resultado = 0
                    dato = 0

                End If

            End If

        ElseIf grpPresionOut.Enabled = True Then

            If chkPsi.Checked = True Then

                If chkTorrOut.Checked = True Then

                    resultado = (dato * 51.715)
                    MsgBox("En Torr: " & resultado)
                    resultado = 0

                End If

                If chkAtmOut.Checked = True Then

                    resultado = (dato / 14.696)
                    MsgBox("En Atm: " & resultado)
                    resultado = 0

                End If

                If chkBarOut.Checked = True Then

                    resultado = (dato / 14.504)
                    MsgBox("En Bar: " & resultado)
                    resultado = 0

                End If

                If chkPaOut.Checked = True Then

                    resultado = (dato * 6895)
                    MsgBox("En Pa: " & resultado)
                    resultado = 0

                End If

            ElseIf chkTorr.Checked = True Then

                If chkPsiOut.Checked = True Then

                    resultado = (dato / 51.715)
                    MsgBox("En Psi: " & resultado)
                    resultado = 0

                End If

                If chkAtmOut.Checked = True Then

                    resultado = (dato / 760)
                    MsgBox("En Atm: " & resultado)
                    resultado = 0

                End If

                If chkBarOut.Checked = True Then

                    resultado = (dato / 750)
                    MsgBox("En Bar: " & resultado)
                    resultado = 0

                End If

                If chkPaOut.Checked = True Then

                    resultado = (dato * 133)
                    MsgBox("En Pa: " & resultado)
                    resultado = 0

                End If

            ElseIf chkAtm.Checked = True Then

                If chkPsiOut.Checked = True Then

                    resultado = (dato * 14.696)
                    MsgBox("En Psi: " & resultado)
                    resultado = 0

                End If

                If chkTorrOut.Checked = True Then

                    resultado = (dato * 760)
                    MsgBox("En Torr: " & resultado)
                    resultado = 0

                End If

                If chkBarOut.Checked = True Then

                    resultado = (dato * 1.013)
                    MsgBox("En Bar: " & resultado)
                    resultado = 0

                End If

                If chkPaOut.Checked = True Then

                    resultado = (dato * 101325)
                    MsgBox("En Pa: " & resultado)
                    resultado = 0

                End If

            ElseIf chkBar.Checked = True Then

                If chkPsiOut.Checked = True Then

                    resultado = (dato * 14.696)
                    MsgBox("En Psi: " & resultado)
                    resultado = 0

                End If

                If chkTorrOut.Checked = True Then

                    resultado = (dato * 750)
                    MsgBox("En Torr: " & resultado)
                    resultado = 0

                End If

                If chkAtmOut.Checked = True Then

                    resultado = (dato / 1.013)
                    MsgBox("En Atm: " & resultado)
                    resultado = 0

                End If

                If chkPaOut.Checked = True Then

                    resultado = (dato * 100000)
                    MsgBox("En Pa: " & resultado)
                    resultado = 0

                End If

            ElseIf chkPa.Checked = True Then

                If chkPsiOut.Checked = True Then

                    resultado = (dato / 6895)
                    MsgBox("En Psi: " & resultado)
                    resultado = 0

                End If

                If chkTorrOut.Checked = True Then

                    resultado = (dato / 133)
                    MsgBox("En Torr: " & resultado)
                    resultado = 0

                End If

                If chkAtmOut.Checked = True Then

                    resultado = (dato / 101325)
                    MsgBox("En Atm: " & resultado)
                    resultado = 0

                End If

                If chkBarOut.Checked = True Then

                    resultado = (dato / 100000)
                    MsgBox("En Bar: " & resultado)
                    resultado = 0

                End If

            End If

        ElseIf grpVelocidadOut.Enabled = True Then

            If chkMS.Checked = True Then

                If chkKMHROut.Checked = True Then

                    resultado = (dato * 3.6)
                    MsgBox("En Km/Hr: " & resultado)
                    resultado = 0

                End If

                If chkFTSOut.Checked = True Then

                    resultado = (dato * 3.281)
                    MsgBox("En Ft/s: " & resultado)
                    resultado = 0

                End If

                If chkMIHROut.Checked = True Then

                    resultado = (dato * 2.237)
                    MsgBox("En Mi/Hr: " & resultado)
                    resultado = 0

                End If

            ElseIf chkKMHR.Checked = True Then

                If chkMSOut.Checked = True Then

                    resultado = (dato / 3.6)
                    MsgBox("En m/s: " & resultado)
                    resultado = 0

                End If

                If chkFTSOut.Checked = True Then

                    resultado = (dato / 1.097)
                    MsgBox("En Ft/s: " & resultado)
                    resultado = 0

                End If

                If chkMIHROut.Checked = True Then

                    resultado = (dato / 1.609)
                    MsgBox("En Mi/Hr: " & resultado)
                    resultado = 0

                End If

            ElseIf chkFTS.Checked = True Then

                If chkMSOut.Checked = True Then

                    resultado = (dato / 3.281)
                    MsgBox("En m/s: " & resultado)
                    resultado = 0

                End If

                If chkKMHROut.Checked = True Then

                    resultado = (dato * 1.097)
                    MsgBox("En km/Hr: " & resultado)
                    resultado = 0

                End If

                If chkMIHROut.Checked = True Then

                    resultado = (dato / 1.467)
                    MsgBox("En Mi/Hr: " & resultado)
                    resultado = 0

                End If

            ElseIf chkMIHR.Checked = True Then

                If chkMSOut.Checked = True Then

                    resultado = (dato / 2.237)
                    MsgBox("En m/s: " & resultado)
                    resultado = 0

                End If

                If chkKMHROut.Checked = True Then

                    resultado = (dato * 1.609)
                    MsgBox("En km/Hr: " & resultado)
                    resultado = 0

                End If

                If chkFTSOut.Checked = True Then

                    resultado = (dato * 1.467)
                    MsgBox("En Ft/s: " & resultado)
                    resultado = 0

                End If

            End If

        ElseIf grpTiempoOut.Enabled = True Then

            If chkS.Checked = True Then

                If chkMinOut.Checked = True Then

                    resultado = (dato / 60)
                    MsgBox("En minutos: " & resultado)
                    resultado = 0

                End If

                If chkHrOut.Checked = True Then

                    resultado = (dato / 3600)
                    MsgBox("En horas: " & resultado)
                    resultado = 0

                End If

                If chkDiasOut.Checked = True Then

                    resultado = (dato / 86400)
                    MsgBox("En dias: " & resultado)
                    resultado = 0

                End If

            ElseIf chkMin.Checked = True Then

                If chkSOut.Checked = True Then

                    resultado = (dato * 60)
                    MsgBox("En segundos: " & resultado)
                    resultado = 0

                End If

                If chkHrOut.Checked = True Then

                    resultado = (dato / 60)
                    MsgBox("En horas: " & resultado)
                    resultado = 0

                End If

                If chkDiasOut.Checked = True Then

                    resultado = (dato / 1440)
                    MsgBox("En dias: " & resultado)
                    resultado = 0

                End If

            ElseIf chkHr.Checked = True Then

                If chkSOut.Checked = True Then

                    resultado = (dato * 3600)
                    MsgBox("En segundos: " & resultado)
                    resultado = 0

                End If

                If chkMinOut.Checked = True Then

                    resultado = (dato * 60)
                    MsgBox("En minutos: " & resultado)
                    resultado = 0

                End If

                If chkDiasOut.Checked = True Then

                    resultado = (dato / 24)
                    MsgBox("En dias: " & resultado)
                    resultado = 0

                End If

            ElseIf chkDias.Checked = True Then

                If chkSOut.Checked = True Then

                    resultado = (dato * 86400)
                    MsgBox("En segundos: " & resultado)
                    resultado = 0

                End If

                If chkMinOut.Checked = True Then

                    resultado = (dato * 1440)
                    MsgBox("En minutos: " & resultado)
                    resultado = 0

                End If

                If chkHrOut.Checked = True Then

                    resultado = (dato * 24)
                    MsgBox("En Horas: " & resultado)
                    resultado = 0

                End If

            End If

        ElseIf grpVolumenOut.Enabled = True Then

            If chkML.Checked = True Then

                If chkLOut.Checked = True Then

                    resultado = (dato / 1000)
                    MsgBox("En Litros: " & resultado)
                    resultado = 0

                End If

                If chkPintaOut.Checked = True Then

                    resultado = (dato / 568)
                    MsgBox("En Pinta Imperial: " & resultado)
                    resultado = 0

                End If

                If chkCuartoOut.Checked = True Then

                    resultado = (dato / 1137)
                    MsgBox("En Cuarto Imperial: " & resultado)
                    resultado = 0

                End If

                If chkMCubicoOut.Checked = True Then

                    resultado = (dato / 1000000.0)
                    MsgBox("En metros cubicos: " & resultado)
                    resultado = 0

                End If

                If chkOzVolOut.Checked = True Then

                    resultado = (dato / 28.413)
                    MsgBox("En Onza liquida imperial: " & resultado)
                    resultado = 0

                End If

                If chkGalonOut.Checked = True Then

                    resultado = (dato / 4546)
                    MsgBox("En galones imperiales: " & resultado)
                    resultado = 0

                End If

            ElseIf chkL.Checked = True Then

                If chkMLOut.Checked = True Then

                    resultado = (dato * 1000)
                    MsgBox("En mililitros: " & resultado)
                    resultado = 0

                End If

                If chkPintaOut.Checked = True Then

                    resultado = (dato * 1.76)
                    MsgBox("En Pinta Imperial: " & resultado)
                    resultado = 0

                End If

                If chkCuartoOut.Checked = True Then

                    resultado = (dato / 1.137)
                    MsgBox("En Cuarto Imperial: " & resultado)
                    resultado = 0

                End If

                If chkMCubicoOut.Checked = True Then

                    resultado = (dato / 1000)
                    MsgBox("En metros cubicos: " & resultado)
                    resultado = 0

                End If

                If chkOzVolOut.Checked = True Then

                    resultado = (dato * 35.195)
                    MsgBox("En Onza liquida imperial: " & resultado)
                    resultado = 0

                End If

                If chkGalonOut.Checked = True Then

                    resultado = (dato / 4.546)
                    MsgBox("En galones imperiales: " & resultado)
                    resultado = 0

                End If

            ElseIf chkPinta.Checked = True Then

                If chkMLOut.Checked = True Then

                    resultado = (dato * 568)
                    MsgBox("En mililitros: " & resultado)
                    resultado = 0

                End If

                If chkLOut.Checked = True Then

                    resultado = (dato / 1.76)
                    MsgBox("En Litros: " & resultado)
                    resultado = 0

                End If

                If chkCuartoOut.Checked = True Then

                    resultado = (dato / 2)
                    MsgBox("En Cuarto Imperial: " & resultado)
                    resultado = 0

                End If

                If chkMCubicoOut.Checked = True Then

                    resultado = (dato / 1760)
                    MsgBox("En metros cubicos: " & resultado)
                    resultado = 0

                End If

                If chkOzVolOut.Checked = True Then

                    resultado = (dato * 20)
                    MsgBox("En Onza liquida imperial: " & resultado)
                    resultado = 0

                End If

                If chkGalonOut.Checked = True Then

                    resultado = (dato / 8)
                    MsgBox("En galones imperiales: " & resultado)
                    resultado = 0

                End If

            ElseIf chkCuarto.Checked = True Then

                If chkMLOut.Checked = True Then

                    resultado = (dato * 1137)
                    MsgBox("En mililitros: " & resultado)
                    resultado = 0

                End If

                If chkLOut.Checked = True Then

                    resultado = (dato * 1.137)
                    MsgBox("En Litros: " & resultado)
                    resultado = 0

                End If

                If chkPintaOut.Checked = True Then

                    resultado = (dato * 2)
                    MsgBox("En Pinta Imperial: " & resultado)
                    resultado = 0

                End If

                If chkMCubicoOut.Checked = True Then

                    resultado = (dato / 880)
                    MsgBox("En metros cubicos: " & resultado)
                    resultado = 0

                End If

                If chkOzVolOut.Checked = True Then

                    resultado = (dato * 40)
                    MsgBox("En Onza liquida imperial: " & resultado)
                    resultado = 0

                End If

                If chkGalonOut.Checked = True Then

                    resultado = (dato / 4)
                    MsgBox("En galones imperiales: " & resultado)
                    resultado = 0

                End If

            ElseIf chkMCubico.Checked = True Then

                If chkMLOut.Checked = True Then

                    resultado = (dato * 1000000.0)
                    MsgBox("En mililitros: " & resultado)
                    resultado = 0

                End If

                If chkLOut.Checked = True Then

                    resultado = (dato * 1000)
                    MsgBox("En Litros: " & resultado)
                    resultado = 0

                End If

                If chkPintaOut.Checked = True Then

                    resultado = (dato * 1760)
                    MsgBox("En Pinta Imperial: " & resultado)
                    resultado = 0

                End If

                If chkCuartoOut.Checked = True Then

                    resultado = (dato * 880)
                    MsgBox("En cuarto imperial: " & resultado)
                    resultado = 0

                End If

                If chkOzVolOut.Checked = True Then

                    resultado = (dato * 35195)
                    MsgBox("En Onza liquida imperial: " & resultado)
                    resultado = 0

                End If

                If chkGalonOut.Checked = True Then

                    resultado = (dato * 220)
                    MsgBox("En galones imperiales: " & resultado)
                    resultado = 0

                End If

            ElseIf chkOzVol.Checked = True Then

                If chkMLOut.Checked = True Then

                    resultado = (dato * 28.413)
                    MsgBox("En mililitros: " & resultado)
                    resultado = 0

                End If

                If chkLOut.Checked = True Then

                    resultado = (dato * 35.195)
                    MsgBox("En Litros: " & resultado)
                    resultado = 0

                End If

                If chkPintaOut.Checked = True Then

                    resultado = (dato / 20)
                    MsgBox("En Pinta Imperial: " & resultado)
                    resultado = 0

                End If

                If chkCuartoOut.Checked = True Then

                    resultado = (dato / 40)
                    MsgBox("En cuarto imperial: " & resultado)
                    resultado = 0

                End If

                If chkMCubicoOut.Checked = True Then

                    resultado = (dato / 35195)
                    MsgBox("En metros cubicos: " & resultado)
                    resultado = 0

                End If

                If chkGalonOut.Checked = True Then

                    resultado = (dato / 160)
                    MsgBox("En galones imperiales: " & resultado)
                    resultado = 0

                End If

            ElseIf chkGalon.Checked = True Then

                If chkMLOut.Checked = True Then

                    resultado = (dato * 4546)
                    MsgBox("En mililitros: " & resultado)
                    resultado = 0

                End If

                If chkLOut.Checked = True Then

                    resultado = (dato * 4.546)
                    MsgBox("En Litros: " & resultado)
                    resultado = 0

                End If

                If chkPintaOut.Checked = True Then

                    resultado = (dato * 8)
                    MsgBox("En Pinta Imperial: " & resultado)
                    resultado = 0

                End If

                If chkCuartoOut.Checked = True Then

                    resultado = (dato / 4)
                    MsgBox("En cuarto imperial: " & resultado)
                    resultado = 0

                End If

                If chkMCubicoOut.Checked = True Then

                    resultado = (dato / 220)
                    MsgBox("En metros cubicos: " & resultado)
                    resultado = 0

                End If

                If chkOzVolOut.Checked = True Then

                    resultado = (dato * 160)
                    MsgBox("En onzas imperiales: " & resultado)
                    resultado = 0

                End If

            End If

        End If

    End Sub


End Class
