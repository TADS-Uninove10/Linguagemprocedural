Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, n2, result As Integer
        n1 = Val(Me.TextBox1.Text)
        n2 = Val(Me.TextBox2.Text)
        result = max(n1, n2)
        MessageBox.Show("o maior é " & Str(result))

        TextBox1.Text = ""
        TextBox2.Text = ""
        
    End Sub

    Private Function max(ByVal Numero1 As Integer, ByVal Numero2 As Integer)
        If Numero1 <= Numero2 Then
            max = (Numero1)
        ElseIf Numero1 >= Numero2 Then
            max = (Numero2)
            
        End If
    End Function
End Class








