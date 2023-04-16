Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, n2, somatoria As Integer
        n1 = Val(Me.TextBox1.Text)
        n2 = Val(Me.TextBox2.Text)
        somatoria = soma(n1, n2)
        MessageBox.Show("A Soma é" & Str(somatoria))
    End Sub


    Private Function soma(ByVal Numero1 As Integer, ByVal numero2 As Integer)
        soma = Numero1 + numero2
    End Function
End Class