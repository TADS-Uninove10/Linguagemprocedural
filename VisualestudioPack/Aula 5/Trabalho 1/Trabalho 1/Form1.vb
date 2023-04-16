Public Class Form1
    Dim pata As Integer
    Dim cab As Integer
    Dim coe As Integer
    Dim duck As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pata = Val(Me.TextBox1.Text)
        cab = Val(Me.TextBox2.Text)

        coe = (pata - 2 * cab) / 2
        duck = cab - coe
        Label6.Text = Str(coe)
        Label5.Text = Str(duck)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
