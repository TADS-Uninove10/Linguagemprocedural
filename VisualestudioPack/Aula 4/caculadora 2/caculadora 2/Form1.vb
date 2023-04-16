Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim N1 As Integer
        Dim N2 As Integer
        Dim N3 As Integer
        N1 = Val(Me.TextBox1.Text)
        N2 = Val(Me.TextBox2.Text)
        N3 = Val(Me.TextBox3.Text)

        If N1 >= N2 And N1 >= N3 Then ' Then

            Me.TextBox4.Text = Str(N1) & " é o maior "

        Else

            If N2 >= N3 Then

                Me.TextBox4.Text = Str(N3) & "é o maior "
            End If
        End If
    End Sub
End Class
