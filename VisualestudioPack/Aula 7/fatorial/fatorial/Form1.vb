Public Class Form1

  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim numero, Cont, resultado As Integer
        numero = Val(Me.TextBox1.Text)
        Cont = 1

        For resultado = 1 To numero
            Cont = Cont * resultado

        Next
        Me.TextBox2.Text = Cont
    End Sub


End Class
