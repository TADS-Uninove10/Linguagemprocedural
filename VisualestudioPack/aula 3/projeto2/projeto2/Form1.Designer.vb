<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Buttonsoma = New System.Windows.Forms.Button()
        Me.Buttonsub = New System.Windows.Forms.Button()
        Me.Buttonresultado = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Buttonmult = New System.Windows.Forms.Button()
        Me.Buttondiv = New System.Windows.Forms.Button()
        Me.Buttonlimp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Buttonsoma
        '
        Me.Buttonsoma.Location = New System.Drawing.Point(12, 165)
        Me.Buttonsoma.Name = "Buttonsoma"
        Me.Buttonsoma.Size = New System.Drawing.Size(75, 23)
        Me.Buttonsoma.TabIndex = 0
        Me.Buttonsoma.Text = "+"
        Me.Buttonsoma.UseVisualStyleBackColor = True
        '
        'Buttonsub
        '
        Me.Buttonsub.Location = New System.Drawing.Point(93, 165)
        Me.Buttonsub.Name = "Buttonsub"
        Me.Buttonsub.Size = New System.Drawing.Size(75, 23)
        Me.Buttonsub.TabIndex = 1
        Me.Buttonsub.Text = "-"
        Me.Buttonsub.UseVisualStyleBackColor = True
        '
        'Buttonresultado
        '
        Me.Buttonresultado.Location = New System.Drawing.Point(185, 165)
        Me.Buttonresultado.Name = "Buttonresultado"
        Me.Buttonresultado.Size = New System.Drawing.Size(75, 23)
        Me.Buttonresultado.TabIndex = 2
        Me.Buttonresultado.Text = "="
        Me.Buttonresultado.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(36, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(36, 105)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(160, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Buttonmult
        '
        Me.Buttonmult.Location = New System.Drawing.Point(12, 213)
        Me.Buttonmult.Name = "Buttonmult"
        Me.Buttonmult.Size = New System.Drawing.Size(75, 23)
        Me.Buttonmult.TabIndex = 6
        Me.Buttonmult.Text = "*"
        Me.Buttonmult.UseVisualStyleBackColor = True
        '
        'Buttondiv
        '
        Me.Buttondiv.Location = New System.Drawing.Point(93, 213)
        Me.Buttondiv.Name = "Buttondiv"
        Me.Buttondiv.Size = New System.Drawing.Size(75, 23)
        Me.Buttondiv.TabIndex = 7
        Me.Buttondiv.Text = "/"
        Me.Buttondiv.UseVisualStyleBackColor = True
        '
        'Buttonlimp
        '
        Me.Buttonlimp.Location = New System.Drawing.Point(186, 213)
        Me.Buttonlimp.Name = "Buttonlimp"
        Me.Buttonlimp.Size = New System.Drawing.Size(75, 23)
        Me.Buttonlimp.TabIndex = 8
        Me.Buttonlimp.Text = "limpar"
        Me.Buttonlimp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Buttonlimp)
        Me.Controls.Add(Me.Buttondiv)
        Me.Controls.Add(Me.Buttonmult)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Buttonresultado)
        Me.Controls.Add(Me.Buttonsub)
        Me.Controls.Add(Me.Buttonsoma)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Buttonsoma As System.Windows.Forms.Button
    Friend WithEvents Buttonsub As System.Windows.Forms.Button
    Friend WithEvents Buttonresultado As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Buttonmult As System.Windows.Forms.Button
    Friend WithEvents Buttondiv As System.Windows.Forms.Button
    Friend WithEvents Buttonlimp As System.Windows.Forms.Button

End Class
