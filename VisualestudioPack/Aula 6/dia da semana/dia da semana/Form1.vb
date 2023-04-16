Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Dow As Integer
        Dow = Val(Me.TextBox1.Text)
        Select Case Dow
            Case 1
                Me.TextBox2.Text = "Domingo"
            Case 2
                Me.TextBox2.Text = "Segunda"
            Case 3
                Me.TextBox2.Text = "Terça"
            Case 4
                Me.TextBox2.Text = "Quarta"
            Case 5
                Me.TextBox2.Text = "Quinta"
            Case 6
                Me.TextBox2.Text = "Sexta"
            Case 7
                Me.TextBox2.Text = "Dia inválido"
        End Select
    End Sub
End Class
