Public Class Logout

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AddictingGames.Close()
        aTyper.Close()
        Bespin.Close()
        Contributors.Close()
        DubstepStudio.Close()
        GoogleDocs.Close()
        JavaScript.Close()
        LinuxCompatibility.Close()
        Myna.Close()
        Pheonix.Close()
        PHP.Close()
        Pixlr.Close()
        Pogo.Close()
        QuickPad.Close()
        Roc.Close()
        Sapphire.Close()
        SysInfo.Close()
        Welcome.Close()
        WebBrowserSourceCode.Close()
        ZohoOfficeSuite.Close()
        UI.Close()
        Login.Opacity = 100%
        Login.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AddictingGames.Close()
        aTyper.Close()
        Bespin.Close()
        Contributors.Close()
        DubstepStudio.Close()
        GoogleDocs.Close()
        JavaScript.Close()
        LinuxCompatibility.Close()
        Myna.Close()
        Pheonix.Close()
        PHP.Close()
        Pixlr.Close()
        Pogo.Close()
        QuickPad.Close()
        Roc.Close()
        Sapphire.Close()
        SysInfo.Close()
        Welcome.Close()
        WebBrowserSourceCode.Close()
        ZohoOfficeSuite.Close()
        UI.Hide()
        UI.Opacity = 0%
        UI.Show()
        UI.Opacity = 100%
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        UI.Close()
        Login.Close()
        SplashScreen.Close()
        Process.Start("taskkill", "/F /IM AtlasUI.exe")
        Process.Start("taskkill", "/F /IM AtlasUIv0.25.vshost.exe")
        Process.Start("explorer")
    End Sub
End Class