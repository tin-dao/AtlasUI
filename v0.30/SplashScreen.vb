Public Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (My.Settings.SetupEnabled = "True") Then
            Me.Opacity = 0%
            Setup.Show()
        Else
            If (My.Settings.SkipLogin = "True") Then
                UI.Show()
                Me.Close()
            Else
                Login.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class