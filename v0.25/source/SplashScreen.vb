Public NotInheritable Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick() Handles Timer1.Tick
        Timer1.Stop()
        If (My.Settings.SetupEnabled = "True") Then
            Setup.Show()
            Close()
        Else
            Login.Show()
            Close()
        End If
    End Sub
End Class
