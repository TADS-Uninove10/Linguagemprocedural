Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mc, peso, altura As Double
        peso = CDbl(Me.TextBox1.Text)
        altura = CDbl(Me.TextBox2.Text)
        mc = peso / (altura ^ 2)
        If mc < 18.5 Then
            Me.Label3.Text = "Abaixo do peso ideal"

        ElseIf mc >= 18.5 And mc <= 24.9 Then
            Me.Label3.Text = "Parabéns – Peso normal"
        ElseIf mc >= 25.0 And mc <= 29.9 Then
            Me.Label3.Text = "Acima do peso – sobrepeso"
        ElseIf mc >= 30.0 And mc <= 34.9 Then
            Me.Label3.Text = "Obesidade Grau I"
        ElseIf mc >= 35.0 And mc <= 39.9 Then
            Me.Label3.Text = "Obesidade Grau II"
        ElseIf mc = 40.0 Then
            Me.Label3.Text = "Obesidade Grau III"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()



    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBox2.Focus()

        End If
    End Sub

    
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1.PerformClick()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Deseja Realmente Sair", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "sair") = vbYes Then
            MsgBox("Ate Breve!!", MsgBoxStyle.Information, "Sair")
            End

        Else
            Button3.PerformClick()

        End If

    End Sub
End Class
