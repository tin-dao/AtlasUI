Public Class Sapphire

    Private Sub WebBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = "1"
        If (My.Settings.Homepage = "") Then
            WebBrowserPreferences.Show()
            WebBrowserPreferences.StartPosition = FormStartPosition.CenterScreen
            WebBrowser1.Navigate("http://aosdt.org")
            ToolStripTextBox1.Text = "http://aosdt.org"
        Else
            WebBrowser1.Navigate(My.Settings.Homepage)
            ToolStripTextBox1.Text = My.Settings.Homepage
        End If
    End Sub

    Private Sub WebBrowser_Close() Handles Me.FormClosing
        Me.Label1.Text = "0"
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
        Me.Text = WebBrowser1.DocumentTitle & " (Sapphire)"
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TabPage2 As New TabPage
        Dim WebBrowser2 As New Sapphire
        Dim ToolStrip2 As New ToolStrip
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub ToolStripTextBox1_Paint() Handles ToolStripTextBox1.TextChanged
        If (ToolStripTextBox1.Text = My.Settings.Homepage) Then
            WebBrowser1.Navigate(My.Settings.Homepage)
        Else
            If (ToolStripTextBox1.Text.Contains("http://")) Then
                WebBrowser1.Navigate(ToolStripTextBox1.Text)
            Else
                WebBrowser1.Navigate("https://encrypted.google.com/search?q=" & ToolStripTextBox1.Text)
            End If
        End If
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim SecondForm As New Sapphire
        SecondForm.Show()
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem1.Click
        WebBrowser1.ShowSaveAsDialog()
    End Sub

    Private Sub PagePropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagePropertiesToolStripMenuItem1.Click
        WebBrowser1.ShowPropertiesDialog()
    End Sub

    Private Sub PageSetupToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem1.Click
        WebBrowser1.ShowPageSetupDialog()
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        WebBrowser1.ShowPrintDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.ShowPrintPreviewDialog()
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Close()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        WebBrowser1.Navigate("https://encrypted.google.com/search?q=" & ToolStripTextBox1.Text)
    End Sub

    Private Sub ViewSourceCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceCodeToolStripMenuItem.Click
        WebBrowserSourceCode.Show()
    End Sub

    Private Sub ReportBugToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBugToolStripMenuItem1.Click
        WebBrowser1.Navigate("http://atlasui-reportbug.aosdt.org")
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreferencesToolStripMenuItem.Click
        WebBrowserPreferences.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        WebBrowser1.Navigate(My.Settings.Homepage)
    End Sub
End Class