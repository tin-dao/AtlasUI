Public Class WebBrowser

    Private Sub WebBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        NetbookUI.Opacity = 100%

        For Each Item As String In My.Settings.History
            ToolStripComboBox1.Items.Add(Item)
        Next
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ToolStripComboBox1.Text = WebBrowser1.Url.ToString()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        WebBrowser1.Navigate(ToolStripComboBox1.Text)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim SecondForm As New WebBrowser
        SecondForm.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        WebBrowser1.ShowSaveAsDialog()
    End Sub
    Private Sub ToolStripComboBox1_Click() Handles ToolStripComboBox1.DropDown
        My.Settings.History.Add(ToolStripComboBox1.Text)
        ToolStripComboBox1.Items.Add(ToolStripComboBox1.Text)

        If ToolStripComboBox1.Text = "Clear All" Then
            My.Settings.History.Clear()
            ToolStripComboBox1.Items.Clear()
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        WebBrowser1.ShowPrintDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        WebBrowser1.ShowPrintPreviewDialog()
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click
        WebBrowser1.ShowPageSetupDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AtlasInitiativeGroupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtlasInitiativeGroupToolStripMenuItem.Click
        WebBrowser1.Navigate("http://atlasinitiativegroup.org/")
    End Sub

    Private Sub GlobalCommunityPortalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlobalCommunityPortalToolStripMenuItem.Click
        WebBrowser1.Navigate("http://globalcommunityportal.com")
    End Sub

    Private Sub RBEFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBEFToolStripMenuItem.Click
        WebBrowser1.Navigate("http://rbefoundation.com")
    End Sub

    Private Sub TheZeitgeistMovementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheZeitgeistMovementToolStripMenuItem.Click
        WebBrowser1.Navigate("http://thezeitgeistmovement.com")
    End Sub

    Private Sub AOLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AOLToolStripMenuItem.Click
        WebBrowser1.Navigate("http://aol.com")
    End Sub

    Private Sub AskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AskToolStripMenuItem.Click
        WebBrowser1.Navigate("http://ask.com")
    End Sub

    Private Sub BingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingToolStripMenuItem.Click
        WebBrowser1.Navigate("http://bing.com")
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        WebBrowser1.Navigate("http://google.com")
    End Sub

    Private Sub YahooToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YahooToolStripMenuItem.Click
        WebBrowser1.Navigate("http://yahoo.com")
    End Sub

    Private Sub ReportBugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBugToolStripMenuItem.Click
        Dim SecondForm As New WebBrowser
        SecondForm.Show()
        SecondForm.WebBrowser1.Navigate("http://globalcommunityportal.com/one/doku.php?id=reportatlasuibug")
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Dim SearchForm As New WebBrowser
        SearchForm.Show()
        SearchForm.WebBrowser1.Navigate("http://www.google.com/cse?cx=001764262542741302714:s4ae2ofjssu&ie=UTF-8&q=" & ToolStripTextBox2.Text)
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TabPage2 As New TabPage
        Dim WebBrowser2 As New WebBrowser
        Dim ToolStrip2 As New ToolStrip
    End Sub

    Private Sub AtlasInitiativeGroupInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtlasInitiativeGroupInfoToolStripMenuItem.Click
        WebBrowser1.Navigate("http://atlasinitiativegroup.info")
    End Sub

    Private Sub PagePropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagePropertiesToolStripMenuItem.Click
        WebBrowser1.ShowPropertiesDialog()
    End Sub

    Private Sub SourceCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SourceCodeToolStripMenuItem.Click
        WebBrowserSourceCode.Show()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub AskToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AskToolStripMenuItem1.Click
        Dim Ask As New WebBrowser
        Ask.Show()
        Ask.WebBrowser1.Navigate("http://www.ask.com/web?q=" & ToolStripTextBox2.Text)
    End Sub

    Private Sub BingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingToolStripMenuItem1.Click
        Dim Bing As New WebBrowser
        Bing.Show()
        Bing.WebBrowser1.Navigate("http://www.bing.com/search?q=" & ToolStripTextBox2.Text)
    End Sub

    Private Sub GCPCSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GCPCSEToolStripMenuItem.Click
        Dim GCP As New WebBrowser
        GCP.Show()
        GCP.WebBrowser1.Navigate("http://www.google.com/cse?oe=utf8&ie=utf8&source=uds&cx=016687041747781621312:dsw0xsx90b0&start=0&hl=en&q=" & ToolStripTextBox2.Text)
    End Sub

    Private Sub GoogleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem1.Click
        Dim Google As New WebBrowser
        Google.Show()
        Google.WebBrowser1.Navigate("http://www.google.com/search?hl=en&q=" & ToolStripTextBox2.Text)
    End Sub

    Private Sub YahooToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YahooToolStripMenuItem1.Click
        Dim Yahoo As New WebBrowser
        Yahoo.Show()
        Yahoo.WebBrowser1.Navigate("http://search.yahoo.com/search?p=" & ToolStripTextBox2.Text)
    End Sub

    Private Sub WikipediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WikipediaToolStripMenuItem.Click
        Dim Wikipedia_Search As New WebBrowser
        Wikipedia_Search.Show()
        Wikipedia_Search.WebBrowser1.Navigate("http://en.wikipedia.org/wiki/" & ToolStripTextBox2.Text)
    End Sub

    Private Sub ZeitgeistResourcesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZeitgeistResourcesToolStripMenuItem.Click
        WebBrowser1.Navigate("http://zeitgeistresources.com")
    End Sub
End Class