Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim numero As Integer
        numero = 1
        Do While numero < 11


            numero = numero + 1

            Me.TextBox1.Text = Me.TextBox1.Text & Str(numero) & vbCrLf
        Loop
        numero = 10
        Do While numero > 0
            Me.TextBox1.Text = Me.TextBox1.Text & Str(numero) & vbCrLf
            numero = numero - 1
        Loop
    End Sub
End Class
