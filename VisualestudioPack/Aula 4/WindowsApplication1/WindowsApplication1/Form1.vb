Public Class Form1

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim N1 As Integer
        Dim N2 As Integer
        Dim N3 As Integer
        N1 = Val(Me.TextBox1.Text)
        N2 = Val(Me.TextBox2.Text)
        N3 = Val(Me.TextBox3.Text)
        If N1 >= N2 And N1 >= N3 Then 'Then
            Me.Label5.Text = Str(N1) & " é o maior número"
        ElseIf N2 >= N3 Then
            Me.Label5.Text = Str(N2) & " é o maior número"
        Else
            Me.Label5.Text = Str(N3) & " é o maior número"


        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
