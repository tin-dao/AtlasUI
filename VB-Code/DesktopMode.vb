Public Class DesktopMode

    Private Sub CalendarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarToolStripMenuItem.Click
        Calendar.Show()
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Process.Start("C:\Windows\System32\Notepad.exe")
    End Sub

    Private Sub FileSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileSystemToolStripMenuItem.Click
        Process.Start("C:\Windows\Explorer.exe")
    End Sub

    Private Sub QuickPadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickPadToolStripMenuItem.Click
        QuickPad.Show()
    End Sub


    Private Sub AddictingGamesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddictingGamesToolStripMenuItem.Click
        AddictingGames.Show()
    End Sub

    Private Sub PogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PogoToolStripMenuItem.Click
        Pogo.Show()
    End Sub

    Private Sub AviaryPheonixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviaryPheonixToolStripMenuItem.Click
        Pheonix.Show()
    End Sub

    Private Sub AtlasBrowserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtlasBrowserToolStripMenuItem.Click
        WebBrowser.Show()
    End Sub

    Private Sub NetbookModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetbookModeToolStripMenuItem.Click
        NetbookUI.Show()
        NetbookUI.Opacity = 100%
        NetbookUI.ShowInTaskbar = True
        Me.Close()
    End Sub

    Private Sub ShutDownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutDownToolStripMenuItem.Click
        NetbookUI.Close()
        Me.Close()
        SplashScreen.Close()
    End Sub

    Private Sub Timer1_Tick() Handles TimeToolStripMenuItem.Click
        TimeToolStripMenuItem.Text = TimeOfDay()
    End Sub

    Private Sub keepingmonth() Handles MonthToolStripMenuItem.Click
        MonthToolStripMenuItem.Text = Today
    End Sub

    Private Sub DesktopMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        keepingmonth()
        Timer1.Start()
    End Sub

    Private Sub AviaryMynaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviaryMynaToolStripMenuItem.Click
        Myna.Show()
    End Sub

    Private Sub MSDOSTerminalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSDOSTerminalToolStripMenuItem.Click
        Process.Start("C:\Windows\System32\cmd.exe")
    End Sub

    Private Sub AdvancedDiskBurningOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancedDiskBurningOptionsToolStripMenuItem.Click
        DiskBurn.Show()
    End Sub

    Private Sub LinuxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinuxToolStripMenuItem.Click
        LinuxCompatibility.Show()
    End Sub

    Private Sub EnhancedAntiSpywareAntiVirusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnhancedAntiSpywareAntiVirusToolStripMenuItem.Click
        AntiSpyware.Show()
    End Sub

    Private Sub EnhancedFirewallOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnhancedFirewallOptionsToolStripMenuItem.Click
        FireWall.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Credits.Show()
    End Sub
End Class