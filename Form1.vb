Public Class evaluacion
    Private Sub cmdResultado_Click(sender As Object, e As EventArgs) Handles cmdResultado.Click

        If cbbCali.Text > 5 Then

            lblResultado.Text = "Aprobaste la materia beibi"
            lblResultado.ForeColor = Color.Green

        Else

            lblResultado.Text = "eres de lo peor de este mundo, no paste"
            lblResultado.ForeColor = Color.Red

        End If

    End Sub
End Class
