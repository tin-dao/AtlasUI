<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Office
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Atlas Typer"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.WordSZ
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(12, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 64)
        Me.Button5.TabIndex = 2
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Office
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(577, 333)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.MaximizeBox = False
        Me.Name = "Office"
        Me.ShowIcon = False
        Me.Text = "Office"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
