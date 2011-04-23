Public Class UI

    Public Function DrawWindow(ByVal winTitle As String, ByVal winNav As String)
        Dim DrawWin As New FlexiWindow
        DrawWin.Show()
        DrawWin.Text = winTitle
        DrawWin.WebBrowser1.Navigate(winNav)
    End Function

    Public Function GetThemes()
        If (My.Settings.Theme = "Default") Then
            ToolStrip1.BackgroundImage = My.Resources.bar
            ToolStripLabel1.ForeColor = Color.White
        ElseIf (My.Settings.Theme = "Clean") Then
            ToolStrip1.BackgroundImage = My.Resources.nullbg
            ToolStrip1.BackColor = Color.White
            ToolStripLabel1.ForeColor = Color.Black
        ElseIf (My.Settings.Theme = "Blue") Then
            ToolStrip1.BackgroundImage = My.Resources.nullbg
            ToolStrip1.BackColor = Color.MediumBlue
            ToolStripLabel1.ForeColor = Color.White
        ElseIf (My.Settings.Theme = "Green") Then
            ToolStrip1.BackgroundImage = My.Resources.nullbg
            ToolStrip1.BackColor = Color.ForestGreen
        ElseIf (My.Settings.Theme = "Red") Then
            ToolStrip1.BackgroundImage = My.Resources.nullbg
            ToolStrip1.BackColor = Color.Red
        End If
    End Function

    Public Function GetWallpapers()
        If (My.Settings.Wallpaper = "AtlasUI_Ripples") Then
            PictureBox1.BackgroundImage = My.Resources.AtlasUI_Ripples
        ElseIf (My.Settings.Wallpaper = "capsule_jpeg") Then
            PictureBox1.BackgroundImage = My.Resources.capsule_jpeg
        ElseIf (My.Settings.Wallpaper = "cloudymountains") Then
            PictureBox1.BackgroundImage = My.Resources.cloudymountains
        ElseIf (My.Settings.Wallpaper = "erodedrocks") Then
            PictureBox1.BackgroundImage = My.Resources.erodedrocks
        ElseIf (My.Settings.Wallpaper = "Grass") Then
            PictureBox1.BackgroundImage = My.Resources.grass
        ElseIf (My.Settings.Wallpaper = "majesticlake") Then
            PictureBox1.BackgroundImage = My.Resources.majesticlake
        ElseIf (My.Settings.Wallpaper = "rainfall") Then
            PictureBox1.BackgroundImage = My.Resources.rainfall
        ElseIf (My.Settings.Wallpaper = "sunflower") Then
            PictureBox1.BackgroundImage = My.Resources.sunflower
        ElseIf (My.Settings.Wallpaper = "sunset") Then
            PictureBox1.BackgroundImage = My.Resources.sunset
        ElseIf (My.Settings.Wallpaper = "tundra") Then
            PictureBox1.BackgroundImage = My.Resources.tundra
        ElseIf (My.Settings.Wallpaper = "tundra2") Then
            PictureBox1.BackgroundImage = My.Resources.tundra2
        Else
            Dim BGImage As Image
            BGImage = Image.FromFile(My.Settings.Wallpaper)
            PictureBox1.BackgroundImage = BGImage
        End If
    End Function

    Public Sub UI_Load() Handles Me.Load
        Timer1.Start()
        Timer2.Start()
        WelcomeUSERToolStripMenuItem.Text = "Welcome " & My.Settings.Username
        GetWallpapers()
        GetThemes()
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
        GetThemes()
    End Sub

    Sub time() Handles Timer1.Tick
        ToolStripLabel1.Text = TimeOfDay
    End Sub

    Private Sub MinesweeperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinesweeperToolStripMenuItem.Click
        Dim Minesweeper As System.Diagnostics.Process
        Dim ProgramPath As String = Application.StartupPath & "\OtherSoftware\Minesweeper.exe"
        Minesweeper.Start(ProgramPath)
    End Sub

    Private Sub QuickPadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickPadToolStripMenuItem.Click
        QuickPad.Show()
    End Sub

    Private Sub AddictingGamesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddictingGamesToolStripMenuItem.Click
        DrawWindow("AddictingGames", "http://addictinggames.com")
    End Sub

    Private Sub PogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PogoToolStripMenuItem.Click
        DrawWindow("Pogo", "http://pogo.com")
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
        DrawWindow("Pixlr", "http://pixlr.com")
    End Sub

    Private Sub AviaryPheonixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviaryPheonixToolStripMenuItem.Click
        DrawWindow("Aviary Phoenix", "http://www.aviary.com/online/image-editor")
    End Sub

    Private Sub AviaryRavenVectorEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviaryRavenVectorEditorToolStripMenuItem.Click
        DrawWindow("Aviary Raven", "http://www.aviary.com/online/vector-editor")
    End Sub

    Private Sub AviaryRocMusicCreatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviaryRocMusicCreatorToolStripMenuItem.Click
        DrawWindow("Aviary Roc", "http://www.aviary.com/online/music-creator")
    End Sub

    Private Sub DubstepOnlineStudioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DubstepOnlineStudioToolStripMenuItem.Click
        DrawWindow("Dubstep Studio", "http://remixer.clubcreate.com/v1/dubstep/launch.html")
    End Sub

    Private Sub SysInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SysInfoToolStripMenuItem.Click
        SysInfo.Show()
    End Sub

    Private Sub GoogleDocsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleDocsToolStripMenuItem.Click
        DrawWindow("Google Docs", "http://docs.google.com")
    End Sub

    Private Sub SplashupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplashupToolStripMenuItem.Click
        Splashup.Show()
    End Sub

    Private Sub AviaryMynaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviaryMynaToolStripMenuItem1.Click
        DrawWindow("Aviary Myna", "http://www.aviary.com/online/audio-editor")
    End Sub

    Private Sub ToolStripLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel5.Click
        Logout.Show()
    End Sub

    Private Sub BespinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BespinToolStripMenuItem.Click
        DrawWindow("Bespin", "http://run.cloud9ide.com")
    End Sub

    Private Sub ZohoCalendarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZohoCalendarToolStripMenuItem.Click
        DrawWindow("Zoho Calendar", "http://calendar.zoho.com")

    End Sub

    Private Sub ZohoNotebookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZohoNotebookToolStripMenuItem.Click
        DrawWindow("Zoho Notebook", "http://notebook.zoho.com")
    End Sub

    Private Sub ZohoPlannerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZohoPlannerToolStripMenuItem.Click
        DrawWindow("Zoho Planner", "http://planner.zoho.com")
    End Sub

    Private Sub ZohoWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZohoWordToolStripMenuItem.Click
        DrawWindow("Zoho Writer", "http://writer.zoho.com")
    End Sub

    Private Sub ContributorsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContributorsListToolStripMenuItem.Click
        Contributors.Show()
    End Sub

    Private Sub WelcomeScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WelcomeScreenToolStripMenuItem.Click
        Welcome.Show()
    End Sub

    Private Sub ProjectUnityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectUnityToolStripMenuItem.Click
        Sapphire.Show()
        Sapphire.NewTab("http://aosdt.org", Sapphire.TabControl1)
    End Sub

    Private Sub SymphonyManagementSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SymphonyManagementSystemToolStripMenuItem.Click
        Sapphire.Show()
        Sapphire.NewTab("http://symphony.aosdt.org", Sapphire.TabControl1)
    End Sub

    Private Sub ReportBugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBugToolStripMenuItem.Click
        Sapphire.Show()
        Dim CurrentBrowser As WebBrowser
        CurrentBrowser = Sapphire.TabControl1.SelectedTab.Tag
        CurrentBrowser.Navigate("http://atlasui-reportbug.aosdt.org")
    End Sub

    Private Sub MeeboToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrawWindow("Meebo", "http://meebo.com")
    End Sub

    Private Sub ToolStripLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel6.Click
        DrawWindow("Meebo", "http://meebo.com")
    End Sub

    Private Sub ToolStripLabel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel7.Click
        Sapphire.Show()
    End Sub

    Private Sub AppearanceManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppearanceManagerToolStripMenuItem.Click
        AppearanceManager.Show()
    End Sub

    Private Sub HoverOver(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub ImoIMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImoIMToolStripMenuItem.Click
        DrawWindow("IMO.IM", "https://imo.im")
    End Sub

    Private Sub AWebIDEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AWebIDEToolStripMenuItem.Click
        Dim aWebIDE As String = Application.StartupPath & "\OtherSoftware\aWebIDE.exe"
        Process.Start(aWebIDE)
    End Sub
End Class
