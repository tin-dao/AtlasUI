Public Class WebBrowserPreferences

    Private Sub WebBrowserPreferences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Homepage
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Homepage = TextBox1.Text
        My.Settings.Save()
        Close()
    End Sub
End Class