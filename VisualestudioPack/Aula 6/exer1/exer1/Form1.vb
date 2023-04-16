Public Class Form1
    Dim n1, n2 As Double
    Dim resp As Char
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        
        n1 = CDbl(Me.TextBox1.Text)
        n2 = CDbl(Me.TextBox2.Text)
        resp = Me.TextBox3.Text

       
        Select Case resp

            Case "a"
                Me.TextBox4.Text = n1 * n2
            Case "b"
                Me.TextBox4.Text = (n1 * n2) / 2
            Case "c"

                Me.TextBox4.Text = n1 + n2
            Case Else
                Me.TextBox4.Text = "invalido"
        End Select
    End Sub

    
End Class
