Public Class Welcome

    Private Sub Me_Load() Handles Me.Load

    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        RichTextBox1.Text = "AtlasUI is a Windows Shell Replacement software. In essence, it removes the Windows user interface and replaces it with the AtlasUI interface. AtlasUI, unlike the majority (if not all) of windows shell replacement software is built around providing Windows users an environment similar to that of a Linux distribution. In this version and versions in the future, it will be based around the KDE interface, however with a touch of GNOME."
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Sapphire.Show()
        Sapphire.WebBrowser1.Navigate("http://aosdt.org")
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Sapphire.Show()
        Sapphire.WebBrowser1.Navigate("http://atlasui.aosdt.org")
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Sapphire.Show()
        Sapphire.WebBrowser1.Navigate("http://atlasui-reportbug.aosdt.org")
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Sapphire.Show()
        Sapphire.WebBrowser1.Navigate("http://atlasui-features.aosdt.org")
    End Sub
End Class