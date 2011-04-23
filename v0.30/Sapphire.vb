Imports MSHTML

Public Class Sapphire
    Dim doclink As HTMLDocument

    Public Sub Browser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        ToolStripLabel1.Text = TimeOfDay() & " on " & Date.Today
        If (My.Settings.DefaultLoad = "Show AOSDT") Then
            NewTab("http://aosdt.org", TabControl1)
            Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
            Browser.Navigate("http://aosdt.org")
            ToolStripTextBox1.Text = "http://aosdt.org"
        ElseIf (My.Settings.DefaultLoad = "Show Home Page") Then
            NewTab(My.Settings.Homepage, TabControl1)
            Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
            Browser.Navigate(My.Settings.Homepage)
            ToolStripTextBox1.Text = My.Settings.Homepage
        ElseIf (My.Settings.DefaultLoad = "Show Blank Page") Then
            NewTab("about:blank", TabControl1)
        End If
    End Sub

    Public Sub Timer1_Ticker() Handles Timer1.Tick
        ToolStripLabel1.Text = TimeOfDay() & " on " & Date.Today
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Me.TabControl1.SelectedTab.Text = Browser.DocumentTitle
        Dim htm As IHTMLDocument2
        On Error Resume Next
        htm = Browser.Document
        doclink = htm
        TabControl1.Dock = DockStyle.Fill
    End Sub

    Private Function doclink_onclick() As Boolean
        NewTab(doclink.toString, TabControl1)
    End Function

    Public Sub NewTab(ByVal p1 As String, ByVal tabControl As TabControl)
        Dim GetIP As New WebBrowser
        Dim AddTab As New TabPage
        Dim AddBrowser As New WebBrowser
        AddBrowser.Tag = AddTab
        AddTab.Tag = AddBrowser
        TabControl1.TabPages.Add(AddTab)
        AddTab.Controls.Add(AddBrowser)
        AddBrowser.Dock = DockStyle.Fill
        AddBrowser.Navigate("")
        AddTab.Text = "New Tab"
        TabControl1.SelectedTab = AddTab
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Browser.GoBack()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Browser.Refresh()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Browser.Navigate(My.Settings.HomePage)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Browser.GoForward()
    End Sub

    Private Sub NavigateToURLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavigateToURLToolStripMenuItem.Click
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Browser.Navigate(ToolStripTextBox1.Text)
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTabToolStripMenuItem.Click
        NewTab("about:blank", TabControl1)
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreferencesToolStripMenuItem.Click
        Preferences.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Browser.ShowPropertiesDialog()
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim NewWindow As New Sapphire
        NewWindow.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Browser.ShowSaveAsDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Browser.ShowPrintPreviewDialog()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Browser.ShowPrintDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub TextBoxHasChanged() Handles ToolStripTextBox1.TextChanged
        If (ToolStripTextBox1.Text.Contains("http://")) Then
            Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
            Browser.Navigate(ToolStripTextBox1.Text)
        ElseIf (ToolStripTextBox1.Text.Contains("https://")) Then
            Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
            Browser.Navigate(ToolStripTextBox1.Text)
        ElseIf (ToolStripTextBox1.Text.Contains("www.")) Then
            Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
            Browser.Navigate(ToolStripTextBox1.Text)
        Else
            Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
            Browser.Navigate("https://duckduckgo.com/?q=" & ToolStripTextBox1.Text)
        End If
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim Browser As WebBrowser = Me.TabControl1.SelectedTab.Tag
        Browser.Navigate("https://duckduckgo.com/?q=" & ToolStripTextBox1.Text)
    End Sub

    Private Sub ViewCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCodeToolStripMenuItem.Click
        WebBrowserSourceCode.Show()
    End Sub
End Class