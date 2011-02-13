Public Class SplashScreen

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NetbookUI.Show()
        Me.Opacity = 0%
        Me.ShowInTaskbar = False
    End Sub

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class