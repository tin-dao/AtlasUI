Public Class Logout

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        aTyper.Close()
        Contributors.Close()
        FlexiWindow.Close()
        JavaScript.Close()
        LinuxCompatibility.Close()
        PHP.Close()
        QuickPad.Close()
        Sapphire.Close()
        SysInfo.Close()
        Welcome.Close()
        WebBrowserSourceCode.Close()
        UI.Close()
        Login.Opacity = 100%
        Login.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        aTyper.Close()
        Contributors.Close()
        FlexiWindow.Close()
        JavaScript.Close()
        LinuxCompatibility.Close()
        PHP.Close()
        QuickPad.Close()
        Sapphire.Close()
        SysInfo.Close()
        Welcome.Close()
        WebBrowserSourceCode.Close()
        UI.Hide()
        UI.Opacity = 0%
        UI.Show()
        UI.Opacity = 100%
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        aTyper.Close()
        Contributors.Close()
        FlexiWindow.Close()
        JavaScript.Close()
        LinuxCompatibility.Close()
        FlexiWindow.Close()
        PHP.Close()
        QuickPad.Close()
        Sapphire.Close()
        SysInfo.Close()
        Welcome.Close()
        WebBrowserSourceCode.Close()
        UI.Close()
        Login.Close()
        SplashScreen.Close()
        Me.Close()
    End Sub

    Public Sub WhileClosing() Handles Me.FormClosing
        Process.Start("explorer")
    End Sub
End Class