Public Class Form2
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim producto As New Producto2()
        Dim precio As Double

        If txtNombre.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el nombre del producto.")
            txtNombre.Focus()
            Return
        End If

        If Not Double.TryParse(txtPrecio.Text, precio) Then
            MessageBox.Show("Ingrese un precio válido.")
            txtPrecio.Focus()
            Return
        End If

        Try
            producto.Nombre = txtNombre.Text
            producto.Precio = precio
            producto.MostrarInfo()

        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Clear()
        txtPrecio.Clear()
        txtNombre.Focus()
    End Sub
End Class