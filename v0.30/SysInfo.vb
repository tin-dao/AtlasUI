Public Class SysInfo


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Paint
        Label1.Text = SystemInformation.UserName()
    End Sub

    Private Sub SysInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label7.Show()
        Label8.Show()
        Label9.Show()
        Label10.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label16.Show()
        Label17.Show()
        Label18.Show()
        Label19.Show()
        Label20.Show()
        Label21.Show()
        Label22.Show()
        Label23.Show()
        Label24.Show()
        Label25.Show()
        Timer1.Start()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Paint
        Label2.Text = SystemInformation.ComputerName()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Paint
        Label5.Text = SystemInformation.BootMode()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Paint
        Label8.Text = SystemInformation.UserDomainName.ToString()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Paint
        If (SystemInformation.PowerStatus.PowerLineStatus = PowerLineStatus.Offline) Then
            If (SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.Critical) Then
                Label10.Text = "Critical"
            End If
            If (SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.High) Then
                Label10.Text = "High"
            End If
            If (SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.Low) Then
                Label10.Text = "Low"
            End If
        Else
            Label10.Text = "Normal"
        End If
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Paint
        Label13.Text = SystemInformation.PrimaryMonitorSize.Width()
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Paint
        Label15.Text = SystemInformation.PrimaryMonitorSize.Height()
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Paint
        Label17.Text = SystemInformation.MonitorCount()
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Paint
        Label19.Text = SystemInformation.MonitorsSameDisplayFormat()
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Paint
        Label21.Text = SystemInformation.ScreenOrientation()
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label19.Paint

    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label21.Paint

    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Paint
        Label24.Text = SystemInformation.Network()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label8.Paint

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Paint
        If (SystemInformation.PowerStatus.PowerLineStatus = PowerLineStatus.Online) Then
            Label11.Text = "AC Power"
        End If
        If (SystemInformation.PowerStatus.PowerLineStatus = PowerLineStatus.Offline) Then
            Label11.Text = "Battery Power"
        End If
        If (SystemInformation.PowerStatus.PowerLineStatus = PowerLineStatus.Unknown) Then
            Label11.Text = "Unknown"
        End If
    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label10.Paint

    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Paint
        If (Label11.Text = "AC Power") Then
            Label9.Show()
        End If
        If (Label11.Text = "Battery Power") Then
            Label9.Show()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Label1.Refresh()
        Label2.Refresh()
        Label3.Refresh()
        Label4.Refresh()
        Label5.Refresh()
        Label6.Refresh()
        Label7.Refresh()
        Label8.Refresh()
        Label9.Refresh()
        Label10.Refresh()
        Label11.Refresh()
        Label12.Refresh()
        Label13.Refresh()
        Label14.Refresh()
        Label15.Refresh()
        Label16.Refresh()
        Label17.Refresh()
        Label18.Refresh()
        Label19.Refresh()
        Label20.Refresh()
        Label21.Refresh()
        Label22.Refresh()
        Label23.Refresh()
        Label24.Refresh()
        Label25.Refresh()
        Label26.Refresh()
        Label27.Refresh()
        Label28.Refresh()
        Label29.Refresh()
        Label30.Refresh()
        Label31.Refresh()
        Label32.Refresh()
        Label33.Refresh()
        Label34.Refresh()
        Label35.Refresh()
        Label36.Refresh()
        Label37.Refresh()
        Label38.Refresh()
        Label39.Refresh()
        Label40.Refresh()
        Label41.Refresh()
        Label42.Refresh()
        Label43.Refresh()
        Label45.Refresh()
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Paint
        Label27.Text = My.Computer.Info.OSFullName.ToString()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinuxCompatibility.Show()
    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Paint
        Label31.Text = My.Computer.Keyboard.CtrlKeyDown.ToString()
    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Paint
        Label32.Text = My.Computer.Keyboard.AltKeyDown.ToString()
    End Sub

    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Paint
        Label35.Text = My.Computer.Keyboard.NumLock.ToString()
    End Sub

    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.Paint
        Label37.Text = My.Computer.Keyboard.ScrollLock.ToString()
    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Paint
        Label39.Text = My.Computer.Keyboard.ShiftKeyDown.ToString()
    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Paint
        Label41.Text = My.Computer.Screen.WorkingArea.Height.ToString()
    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Paint
        Label42.Text = My.Computer.Screen.WorkingArea.Width.ToString()
    End Sub

    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label33.Paint
        Label33.Text = My.Computer.Keyboard.CapsLock.ToString()
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label45.Paint
        Label45.Text = SystemInformation.Secure()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label9.Paint

    End Sub

    Private Sub Label45_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label45.Paint

    End Sub
    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label27.Paint

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label11.Paint

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label5.Paint

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label1.Paint

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label2.Paint

    End Sub
    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label42.Paint

    End Sub
    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label41.Paint

    End Sub
    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label17.Paint

    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label15.Paint

    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label13.Paint

    End Sub
    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label39.Paint

    End Sub
    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label37.Paint

    End Sub
    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label35.Paint

    End Sub
    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label33.Paint

    End Sub
    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label32.Paint

    End Sub
    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label31.Paint

    End Sub
    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label24.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label47.Text = My.Computer.Info.AvailablePhysicalMemory.ToString()
        Label49.Text = My.Computer.Info.AvailableVirtualMemory.ToString()
        Label51.Text = My.Computer.Info.TotalPhysicalMemory.ToString
        Label53.Text = My.Computer.Info.TotalVirtualMemory.ToString()
    End Sub
End Class