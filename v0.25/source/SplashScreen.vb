Public Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (My.Settings.SetupEnabled = "True") Then
            Me.Opacity = 0%
            Setup.Show()
        Else
            Me.Hide()
            Me.Opacity = 0%
            Me.Visible = False
            Login.Show()
        End If
    End Sub
End Class