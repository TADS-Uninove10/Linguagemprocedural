Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, n2 As Integer
        n1 = Val(Me.TextBox1.Text)
        n2 = Val(Me.TextBox2.Text)
        Soma(n1, n2)
    End Sub
    Private Sub Soma(ByRef Numero1 As Integer, ByVal Numero2 As Integer)
        MessageBox.Show("A soma é " & Str(Numero1 + Numero2)) 'byval: copia o que tenho pra você  , byref: ponteiro pro mesmo
        ' endereço de memoria  um atalho alcontrario do bayval ele altera


    End Sub
End Class
