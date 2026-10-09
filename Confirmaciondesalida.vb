Public Class UserControl1

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show(
            "¿Desea salir del programa?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If respuesta = DialogResult.Yes Then
            Me.FindForm().Close()
        End If
    End Sub
End Class
