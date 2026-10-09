Public Class UserControl1


    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Select Case txtOpcion.Text.Trim()

            Case "1"
                MessageBox.Show("Seleccionaste la opción 1")

            Case "2"
                MessageBox.Show("Seleccionaste la opción 2")

            Case "3"
                MessageBox.Show("Seleccionaste la opción 3")

            Case Else
                MessageBox.Show("Ingresa una opción válida: 1, 2 o 3")

        End Select
    End Sub
End Class
