<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.cmdCalcular = New System.Windows.Forms.Button()
        Me.optMetalica = New System.Windows.Forms.RadioButton()
        Me.OptPerolizada = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor do " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Carro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor do carro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "com a Cor"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(109, 33)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 2
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Location = New System.Drawing.Point(181, 157)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTotal.TabIndex = 3
        '
        'cmdCalcular
        '
        Me.cmdCalcular.Location = New System.Drawing.Point(109, 81)
        Me.cmdCalcular.Name = "cmdCalcular"
        Me.cmdCalcular.Size = New System.Drawing.Size(110, 38)
        Me.cmdCalcular.TabIndex = 4
        Me.cmdCalcular.Text = "Calcular com a cor"
        Me.cmdCalcular.UseVisualStyleBackColor = True
        '
        'optMetalica
        '
        Me.optMetalica.AutoSize = True
        Me.optMetalica.Location = New System.Drawing.Point(259, 33)
        Me.optMetalica.Name = "optMetalica"
        Me.optMetalica.Size = New System.Drawing.Size(64, 30)
        Me.optMetalica.TabIndex = 5
        Me.optMetalica.TabStop = True
        Me.optMetalica.Text = "Cor " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "metalica"
        Me.optMetalica.UseVisualStyleBackColor = False
        '
        'OptPerolizada
        '
        Me.OptPerolizada.AutoSize = True
        Me.OptPerolizada.Location = New System.Drawing.Point(259, 89)
        Me.OptPerolizada.Name = "OptPerolizada"
        Me.OptPerolizada.Size = New System.Drawing.Size(74, 30)
        Me.OptPerolizada.TabIndex = 6
        Me.OptPerolizada.TabStop = True
        Me.OptPerolizada.Text = "Cor " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Perolizada"
        Me.OptPerolizada.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 220)
        Me.Controls.Add(Me.OptPerolizada)
        Me.Controls.Add(Me.optMetalica)
        Me.Controls.Add(Me.cmdCalcular)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents txtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdCalcular As System.Windows.Forms.Button
    Friend WithEvents optMetalica As System.Windows.Forms.RadioButton
    Friend WithEvents OptPerolizada As System.Windows.Forms.RadioButton

End Class
