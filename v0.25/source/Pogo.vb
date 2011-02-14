Public Class Pogo

    Private Sub Pogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = "1"
    End Sub
    Private Sub Pogo_Close() Handles Me.FormClosing
        Me.Label1.Text = "0"
    End Sub
End Class