Public Class Form1
    Dim n1 As Integer
    Dim n2, resultado As Integer
    Private Sub Buttonsoma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsoma.Click
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        resultado = n1 + n2
    End Sub

    Private Sub Buttonsub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsub.Click
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        resultado = n1 - n2
    End Sub

    Private Sub Buttonmult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonmult.Click
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        resultado = n1 * n2
    End Sub

    Private Sub Buttondiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttondiv.Click
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        resultado = n1 / n2
    End Sub

    Private Sub Buttonresultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonresultado.Click
        TextBox3.Text = resultado
    End Sub

    Private Sub Buttonlimp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonlimp.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
    End Sub
End Class
