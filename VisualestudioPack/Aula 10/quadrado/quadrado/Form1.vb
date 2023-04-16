Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, calc As Integer
        n1 = CInt(Me.TextBox1.Text)
        calc = quadrado(n1)
        MessageBox.Show("O Quadrado de " & Str(n1) & "é" & Str(calc))


    End Sub
    Private Function quadrado(ByVal numero1 As Integer)
        quadrado = numero1 ^ 2
    End Function
End Class
