Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim numero As Integer
        For numero = 1 To 10
            Me.TextBox1.Text = Me.TextBox1.Text & Str(numero) & vbCrLf
        Next
        For numero = 10 To 1 Step -1
            Me.TextBox1.Text = Me.TextBox1.Text & Str(numero) & vbCrLf
        Next
    End Sub
End Class
