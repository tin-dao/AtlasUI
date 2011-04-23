Public Class WebBrowserSourceCode

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim CurrentBrowser As WebBrowser
        CurrentBrowser = Sapphire.TabControl1.SelectedTab.Tag
        RichTextBox1.Text = CurrentBrowser.Document.Body.InnerHtml.ToString()
    End Sub

End Class