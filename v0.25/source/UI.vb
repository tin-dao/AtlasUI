Public Class UI

    Public Sub UI_Load() Handles Me.Load
        Timer1.Start()
        Timer2.Start()
        WelcomeUSERToolStripMenuItem.Text = "Welcome " & My.Settings.Username
        If (My.Settings.FirstRun = "True") Then
            Welcome.Show()
        Else

        End If
    End Sub

    Public Sub UI_Close() Handles Me.FormClosing
        If (My.Settings.FirstRun = "True") Then
            My.Settings.FirstRun = "False"
            My.Settings.Save()
        Else

        End If
        Process.Start("explorer.exe")
    End Sub

    Sub CheckDate() Handles Timer2.Tick
        ToolStripLabel1.ToolTipText = My.Computer.Clock.LocalTime.Date
        If (SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.Critical Or SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.Low) Then
            ToolStripLabel3.Image = My.Resources.battery_25tolow
        ElseIf (SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.Unknown) Then
            ToolStripLabel3.Image = My.Resources.battery_50
        ElseIf (SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.High) Then
            ToolStripLabel3.Image = My.Resources.battery_75
        ElseIf (SystemInformation.PowerStatus.PowerLineStatus = PowerLineStatus.Online) Then
            ToolStripLabel3.Image = My.Resources.battery_charging
        End If

        If (SystemInformation.Network = True) Then
            ToolStripLabel4.Image = My.Resources.network_online
            ToolStripLabel4.ToolTipText = "Online"
        Else
            ToolStripLabel4.Image = My.Resources.network_offline
        End If
    End Sub

    Sub time() Handles Timer1.Tick
        ToolStripLabel1.Text = TimeOfDay
    End Sub

    Public Sub HoverOver() Handles ToolStripLabel1.Click
        ToolStripLabel1.ToolTipText = My.Computer.Clock.LocalTime.Date
    End Sub

    Private Sub MinesweeperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinesweeperToolStripMenuItem.Click
        Dim ParentDirectory As String = System.Windows.Forms.Application.StartupPath
        Dim ProgramPath As String = ParentDirectory & "\OtherSoftware\Minesweeper.exe"
        System.Diagnostics.Process.Start(ProgramPath)
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

    Private Sub ATyperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ATyperToolStripMenuItem.Click
        aTyper.Show()
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Sapphire.Show()
    End Sub

    Private Sub JavaScriptEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JavaScriptEditorToolStripMenuItem.Click
        JavaScript.Show()
    End Sub

    Private Sub SapphireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SapphireToolStripMenuItem.Click
        Sapphire.Show()
    End Sub

    Private Sub PixlrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PixlrToolStripMenuItem.Click
        Pixlr.Show()
    End Sub

    Private Sub AviaryPheonixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviaryPheonixToolStripMenuItem.Click
        Pheonix.Show()
    End Sub

    Private Sub AviaryRavenVectorEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviaryRavenVectorEditorToolStripMenuItem.Click
        Raven.Show()
    End Sub

    Private Sub AviaryRocMusicCreatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviaryRocMusicCreatorToolStripMenuItem.Click
        Roc.Show()
    End Sub

    Private Sub DubstepOnlineStudioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DubstepOnlineStudioToolStripMenuItem.Click
        DubstepStudio.Show()
    End Sub

    Private Sub SysInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SysInfoToolStripMenuItem.Click
        SysInfo.Show()
    End Sub

    Private Sub GoogleDocsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleDocsToolStripMenuItem.Click
        GoogleDocs.Show()
    End Sub

    Private Sub SplashupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplashupToolStripMenuItem.Click
        Splashup.Show()
    End Sub

    Private Sub AviaryMynaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviaryMynaToolStripMenuItem1.Click
        Myna.Show()
    End Sub

    Private Sub ToolStripLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel5.Click
        Logout.Show()
    End Sub

    Private Sub BespinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BespinToolStripMenuItem.Click
        Bespin.Show()
    End Sub

    Private Sub ZohoCalendarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZohoCalendarToolStripMenuItem.Click
        ZohoOfficeSuite.Show()
        ZohoOfficeSuite.WebBrowser1.Navigate("http://calendar.zoho.com")

    End Sub

    Private Sub ZohoNotebookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZohoNotebookToolStripMenuItem.Click
        ZohoOfficeSuite.Show()
        ZohoOfficeSuite.WebBrowser1.Navigate("http://notebook.zoho.com")
    End Sub

    Private Sub ZohoPlannerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZohoPlannerToolStripMenuItem.Click
        ZohoOfficeSuite.Show()
        ZohoOfficeSuite.WebBrowser1.Navigate("http://planner.zoho.com")
    End Sub

    Private Sub ZohoWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZohoWordToolStripMenuItem.Click
        ZohoOfficeSuite.Show()
        ZohoOfficeSuite.WebBrowser1.Navigate("http://writer.zoho.com")
    End Sub

    Private Sub ContributorsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContributorsListToolStripMenuItem.Click
        Contributors.Show()
    End Sub

    Private Sub WelcomeScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WelcomeScreenToolStripMenuItem.Click
        Welcome.Show()
    End Sub

    Private Sub ProjectUnityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectUnityToolStripMenuItem.Click
        AOSDT.Show()
    End Sub

    Private Sub SymphonyManagementSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SymphonyManagementSystemToolStripMenuItem.Click
        Sapphire.Show()
        Sapphire.WebBrowser1.Navigate("http://symphony.aosdt.org")
    End Sub

    Private Sub ReportBugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBugToolStripMenuItem.Click
        Sapphire.Show()
        Sapphire.WebBrowser1.Navigate("http://atlasui-reportbug.aosdt.org")
    End Sub

    Private Sub MeeboToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Meebo.Show()
    End Sub

    Private Sub ToolStripLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel6.Click
        Meebo.Show()
    End Sub

    Private Sub ToolStripLabel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel7.Click
        AOSDT.Show()
    End Sub

    Private Sub MeeboToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeeboToolStripMenuItem.Click
        Meebo.Show()
    End Sub
End Class
