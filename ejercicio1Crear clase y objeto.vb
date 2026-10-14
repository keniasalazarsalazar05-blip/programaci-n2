Public Class Form1

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Dim producto1 As New Producto()
        Dim precio As Double

        If Double.TryParse(txtPrecio.Text, precio) Then

            producto1.Nombre = txtNombre.Text
            producto1.Precio = precio

            producto1.MostrarInfo()

        Else
            MessageBox.Show("Por favor, ingrese un precio válido.")
        End If

    End Sub

End Class