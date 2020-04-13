<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.LabelWaktu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelWaktu
        '
        Me.LabelWaktu.AutoSize = True
        Me.LabelWaktu.Location = New System.Drawing.Point(13, 9)
        Me.LabelWaktu.Name = "LabelWaktu"
        Me.LabelWaktu.Size = New System.Drawing.Size(19, 13)
        Me.LabelWaktu.TabIndex = 0
        Me.LabelWaktu.Text = "----"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 137)
        Me.Controls.Add(Me.LabelWaktu)
        Me.Name = "FormUtama"
        Me.Text = "Pengecek Waktu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelWaktu As Label
End Class
