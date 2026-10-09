Public Class UserControl1
    Private Sub txtDia_TextChanged(sender As Object, e As EventArgs) Handles txtDia.TextChanged
        Dim dia As Integer

        If Integer.TryParse(txtDia.Text.Trim(), dia) Then

            If dia >= 1 AndAlso dia <= 7 Then

                Dim dias() As String = {
                    "Lunes",
                    "Martes",
                    "Miércoles",
                    "Jueves",
                    "Viernes",
                    "Sábado",
                    "Domingo"
                }

                MessageBox.Show(dias(dia - 1))

            Else
                MessageBox.Show("Ingrese un número del 1 al 7")
            End If

        Else
            MessageBox.Show("Ingrese un número válido")
        End If



    End Sub
End Class
