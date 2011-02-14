Public Class WebBrowserSourceCode

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        RichTextBox1.Text = Sapphire.WebBrowser1.Document.Body.InnerHtml.ToString()
    End Sub

End Class