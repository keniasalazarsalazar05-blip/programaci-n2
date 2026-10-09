Public Class UserControl1
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Dim numero As Integer

        If Not Integer.TryParse(txtnúmero.Text, numero) Then
            MessageBox.Show("Error: debes ingresar un número entero.")
            Exit Sub
        End If

        Select Case numero
            Case 1
                MessageBox.Show("Elegiste la opción uno")
            Case 2
                MessageBox.Show("Bienvenido a la opción dos")
            Case 3
                MessageBox.Show("Has seleccionado la opción tres")
            Case 4
                MessageBox.Show("Esta es la opción cuatro")
            Case Else
                MessageBox.Show("Error: ingresa un número del 1 al 4")
        End Select
    End Sub
End Class
