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
        Me.bt1 = New System.Windows.Forms.Button()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt1
        '
        Me.bt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt1.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bt1.Location = New System.Drawing.Point(29, 23)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(75, 23)
        Me.bt1.TabIndex = 0
        Me.bt1.Text = "ok"
        Me.bt1.UseVisualStyleBackColor = False
        '
        'bt2
        '
        Me.bt2.BackColor = System.Drawing.Color.Black
        Me.bt2.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt2.ForeColor = System.Drawing.Color.White
        Me.bt2.Location = New System.Drawing.Point(29, 62)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(75, 23)
        Me.bt2.TabIndex = 1
        Me.bt2.Text = "fantasma"
        Me.bt2.UseVisualStyleBackColor = False
        Me.bt2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(134, 121)
        Me.Controls.Add(Me.bt2)
        Me.Controls.Add(Me.bt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt1 As System.Windows.Forms.Button
    Friend WithEvents bt2 As System.Windows.Forms.Button

End Class
