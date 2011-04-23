Public Class FlexiWindow

    Private Sub Meebo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = "1"
    End Sub
    Private Sub Meebo_Close() Handles Me.FormClosing
        Me.Label1.Text = "0"
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class