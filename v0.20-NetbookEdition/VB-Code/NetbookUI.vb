Public Class NetbookUI
    Private Sub NetbookUI_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        SplashScreen.Close()
    End Sub
    Private Sub NetbookUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        keepingmonth()
        Timer1.Start()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Accessories.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Games.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Graphics.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Internet.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Office.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        SoundAndVideo.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CompSystem.Show()
    End Sub

    Private Sub DesktopModeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesktopModeToolStripMenuItem1.Click
        DesktopMode.Show()
        Me.Opacity = 0%
        Me.ShowInTaskbar = False
    End Sub

    Private Sub Timer1_Tick() Handles TimeToolStripMenuItem.Paint
        TimeToolStripMenuItem.Text = TimeOfDay()
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        For Each item As String In My.Settings.History
            WebBrowser.ToolStripComboBox1.Items.Add(item)
        Next
    End Sub

    Private Sub keepingmonth() Handles MonthToolStripMenuItem.Click
        MonthToolStripMenuItem.Text = Today
    End Sub

    Private Sub ShutDownToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutDownToolStripMenuItem1.Click
        SplashScreen.Close()
        Me.Close()
    End Sub

    Private Sub SuspendToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspendToolStripMenuItem1.Click
        Suspend.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DeveloperModule.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Donate.Show()
    End Sub

    Private Sub RestartToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem1.Click
        Me.Opacity = 0%

    End Sub
End Class
