Public Class Setup

    Private Sub Setup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.SetupEnabled = "True"
    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Username = Me.TextBox1.Text
        My.Settings.Password = Me.TextBox2.Text
        My.Settings.Homepage = Me.TextBox4.Text
        If (TextBox3.Text = "") Then
            My.Settings.NameOfSystem = "AtlasUI"
        Else
            My.Settings.NameOfSystem = Me.TextBox3.Text
        End If
        My.Settings.SetupEnabled = "False"
        My.Settings.Save()
        Me.Opacity = 0
        Me.Close()
    End Sub

    Private Sub Button1_Click() Handles MyBase.FormClosing
        Login.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        SplashScreen.Close()
        Process.Start("taskkill", "/F /IM AtlasUI.exe")
        Process.Start("taskkill", "/F /IM AtlasUI-v0.25.exe")
    End Sub

End Class