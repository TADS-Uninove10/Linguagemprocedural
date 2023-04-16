Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Resultado As Single
        Valor1 = Me.TextBox1.Text
        Valor2 = Me.TextBox2.Text
        Calculo(Valor1, Valor2, "+", Resultado)
        MessageBox.Show("A Soma é " & Str(Resultado))
        Calculo(Valor1, Valor2, "-", Resultado)
        MessageBox.Show("A Subtração é " & Str(Resultado))
        Calculo(Valor1, Valor2, "*", Resultado)
        MessageBox.Show("A Multiplicação é " & Str(Resultado))
        Calculo(Valor1, Valor2, "/", Resultado)
        MessageBox.Show("A Divisão é " & Str(Resultado))
    End Sub

    Private Sub Calculo(ByVal Numero1 As Integer, ByVal Numero2 As Integer,
    ByVal Operacao As String, ByRef Resultado As Single)

        Select Case Operacao
            Case "+"
                Resultado = Numero1 + Numero2
            Case "-"
                Resultado = Numero1 - Numero2
            Case "*"
                Resultado = Numero1 * Numero2
            Case "/"
                Resultado = Numero1 / Numero2
            Case Else
                Resultado = 0
                MessageBox.Show("Não é uma Operação valida")
        End Select
    End Sub
End Class
