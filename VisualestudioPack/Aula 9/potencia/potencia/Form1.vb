Public Class Form1
    Private Function Potencia(ByVal Num As Integer, ByVal Exp As Integer)
        Dim K, Base As Integer
        If Exp = 0 Then
            Potencia = 1
        Else
            If Num = 0 Then
                Potencia = 0
            Else
                Base = Num
                For K = 1 To Exp - 1
                    Num = Num * Base
                Next
                Potencia = Num
                    End if
        End If
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Valor, Expoente, Resultado As Integer
        Valor = Val(Me.TextBox1.Text)
        Expoente = Val(Me.TextBox2.Text)
        Resultado = potencia(Valor, Expoente)
        MessageBox.Show("O numero" & Str(Valor) & " elevado" + vbCrLf + " a potencia de " & Str(Expoente) & " é " & Str(Resultado)))
    End Sub
End Class
