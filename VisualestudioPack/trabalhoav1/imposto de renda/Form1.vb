Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim salario As Decimal
        Dim result As Decimal
        salario = Val(Me.TextBox1.Text)
        
        If salario <= 1566.61 Then
            MsgBox("insento", MsgBoxStyle.Critical, "aula de bv")

        End If


        If salario > 1566.62 And salario <= 2347.85 Then


            result = (salario * 7.5 / 100) - 117.49
            Me.Label2.Text = "I.R a ser pago...R$" & result
        ElseIf salario > 2347.86 And salario <= 3130.51 Then

            result = (salario * 15 / 100) - 293.58
            Me.Label2.Text = "I.R a ser pago...R$" & result
        ElseIf salario > 3130.52 And salario <= 3911.63 Then


            result = (salario * 22.5 / 100) - 528.37
            Me.Label2.Text = "I.R a ser pago...R$" & result
        ElseIf salario > 3911.63 Then
            result = (salario * 27.5 / 100) - 723.95
            Me.Label2.Text = "I.R a ser pago...R$" & result
        End If






    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Deseja Realmente Sair", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "sair") = vbYes Then
            MsgBox("Ate Breve!!", MsgBoxStyle.Information, "Sair")
            End

        Else
            Button3.PerformClick()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
    End Sub
End Class
