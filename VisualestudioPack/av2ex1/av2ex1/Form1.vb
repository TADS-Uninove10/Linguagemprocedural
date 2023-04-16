Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, co, re As Integer
        n = (Me.TextBox1.Text)
        CalculaSoma(n, co, re)
        If n Mod 2 > 0 Then
            MessageBox.Show("Este numero é impar ")
        ElseIf n Mod 2 = 0 Then

            MessageBox.Show("Soma dos pares " & Str(re))
        End If
        TextBox1.Text = ""
    End Sub
    Private Function CalculaSoma(ByVal Numero As Integer, ByVal contador As Integer, ByVal Resultado As Integer)

        For contador = 0 To Numero 'contar do zero ate que o usu digitar
            If (contador Mod 2) = 0 Then 'ferificar se e par
                Resultado = Resultado + contador 'somar os pares

            End If

        Next
    End Function
End Class
