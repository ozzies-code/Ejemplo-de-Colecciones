Public Class frmEjemploColecciones
    Private Sub btnMostrarNombres_Click(sender As Object, e As EventArgs) Handles btnMostrarNombres.Click

        Dim intIndice As Integer

        For intIndice = 0 To Me.Controls.Count - 1
            MessageBox.Show("El control Numero " & intIndice & " tiene el nombre " & Me.Controls(intIndice).Name)
        Next intIndice
    End Sub
End Class
