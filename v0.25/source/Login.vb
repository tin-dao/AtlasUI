Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = My.Settings.Username And TextBox2.Text = My.Settings.Password) Then
            Process.Start("taskkill", "/F /IM explorer.exe")
            UI.Show()
            Close()
        Else
            If (TextBox1.Text = My.Settings.Username) Then
                Me.Opacity = 0%
                TextBox2.Text = ""
                Label7.Visible = True
                Me.Opacity = 100%
            ElseIf (TextBox2.Text = My.Settings.Password) Then
                Me.Opacity = 0%
                TextBox1.Text = ""
                Label6.Visible = True
                Me.Opacity = 100%
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start("taskkill", "/F /IM AtlasUI.exe")
        Process.Start("taskkill", "/F /IM AtlasUIv0.25.vshost.exe")
        Close()
    End Sub

    Private Sub Label4_Paint() Handles Label4.Paint
        Label4.Text = My.Settings.NameOfSystem
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class