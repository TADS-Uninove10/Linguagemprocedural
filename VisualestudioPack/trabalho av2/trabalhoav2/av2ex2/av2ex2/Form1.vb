Public Class Form1
    Private Sub Calcularvalor(ByRef Numero1 As Integer, ByRef Numero2 As Integer)
        Select Case True
            Case optMetalica.Checked
                Numero2 = Numero1 + 800.0

            Case OptPerolizada.Checked
                Numero2 = Numero1 + 1000.0

        End Select
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalcular.Click
        Dim valor As Double
        Dim todal As Double

        valor = Me.txtvalor.Text

        Calcularvalor(valor, todal)

        Me.txtValorTotal.Text = todal



    End Sub

    



    Private Sub optMetalica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMetalica.CheckedChanged

    End Sub

    Private Sub OptPerolizada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptPerolizada.CheckedChanged

    End Sub

    Private Sub cmdCalcular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmdCalcular.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtValorTotal.Focus()

        End If
    End Sub
End Class
