Public Class Form1



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, co, re As Integer
        n = (Me.TextBox1.Text)
        CalculaSoma(n, co, re)

       
        TextBox1.Text = ""
    End Sub
    Private Function CalculaSoma(ByRef Numero As Integer, ByRef contador As Integer, ByRef Resultado As Integer)
        If Numero Mod 2 > 0 Then
            MessageBox.Show("Este numero é impar ")

        ElseIf Numero Mod 2 = 0 Then


            For contador = 0 To Numero
                If (contador Mod 2) = 0 Then


                    Resultado = Resultado + contador

                End If

            Next

            MessageBox.Show("Soma dos pares " & Str(Resultado))


        End If

    End Function
End Class
