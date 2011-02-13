<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetbookUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NetbookUI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShutDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SuspendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.DesktopModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.DesktopModeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.RestartToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ShutDownToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SuspendToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthToolStripMenuItem, Me.TimeToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1074, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MonthToolStripMenuItem
        '
        Me.MonthToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MonthToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MonthToolStripMenuItem.Name = "MonthToolStripMenuItem"
        Me.MonthToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.MonthToolStripMenuItem.Text = "Month"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TimeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.TimeToolStripMenuItem.Text = "time"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ShutDownToolStripMenuItem
        '
        Me.ShutDownToolStripMenuItem.Name = "ShutDownToolStripMenuItem"
        Me.ShutDownToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShutDownToolStripMenuItem.Text = "Shut Down"
        '
        'SuspendToolStripMenuItem
        '
        Me.SuspendToolStripMenuItem.Name = "SuspendToolStripMenuItem"
        Me.SuspendToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SuspendToolStripMenuItem.Text = "Suspend"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'DesktopModeToolStripMenuItem
        '
        Me.DesktopModeToolStripMenuItem.Name = "DesktopModeToolStripMenuItem"
        Me.DesktopModeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DesktopModeToolStripMenuItem.Text = "Desktop Mode"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button6)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1074, 538)
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Development"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(959, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "System"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(817, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Sound And Video"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(714, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Office"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(574, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Internet"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(446, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Graphics"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(322, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Games"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Accessories"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1074, 380)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1066, 354)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Welcome"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "How Can You Help?"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(1060, 173)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1066, 354)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contributors"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1060, 348)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Contributors List:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "-----Graphics-----" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Eden Prime" & Global.Microsoft.VisualBasic.ChrW(10) & "TimeWarrior" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "-----Programming-" & _
            "----" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Joshua Strobl (Main Programmer)"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.WebBrowser1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1066, 354)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Source Code"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1060, 348)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://globalcommunityportal.com/AtlasUI/AtlasSourceCodev0.25", System.UriKind.Absolute)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(94, 20)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.Resource_Hacker
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(157, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 120)
        Me.Button2.TabIndex = 32
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.System
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(913, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 120)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.HP_MediaPlayer
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(787, 8)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(120, 120)
        Me.Button11.TabIndex = 26
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.office_v3
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(661, 8)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(120, 120)
        Me.Button10.TabIndex = 25
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.dossier_internet
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(535, 8)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(120, 120)
        Me.Button9.TabIndex = 24
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.Graphics
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(409, 8)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(120, 120)
        Me.Button8.TabIndex = 22
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.gamepad
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(283, 8)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 120)
        Me.Button7.TabIndex = 20
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.Misc_Stuff
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(31, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(120, 120)
        Me.Button6.TabIndex = 18
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.donate
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(59, 182)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 48)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesktopModeToolStripMenuItem1, Me.ToolStripSeparator1, Me.RestartToolStripMenuItem1, Me.ShutDownToolStripMenuItem1, Me.SuspendToolStripMenuItem1})
        Me.ToolStripMenuItem3.Image = Global.AtlasUI_NetbookLauncher.My.Resources.Resources.atlasicon
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(72, 20)
        Me.ToolStripMenuItem3.Text = "AtlasUI"
        '
        'DesktopModeToolStripMenuItem1
        '
        Me.DesktopModeToolStripMenuItem1.Name = "DesktopModeToolStripMenuItem1"
        Me.DesktopModeToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DesktopModeToolStripMenuItem1.Text = "Desktop Mode"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'RestartToolStripMenuItem1
        '
        Me.RestartToolStripMenuItem1.Name = "RestartToolStripMenuItem1"
        Me.RestartToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.RestartToolStripMenuItem1.Text = "Restart"
        '
        'ShutDownToolStripMenuItem1
        '
        Me.ShutDownToolStripMenuItem1.Name = "ShutDownToolStripMenuItem1"
        Me.ShutDownToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ShutDownToolStripMenuItem1.Text = "Shut Down"
        '
        'SuspendToolStripMenuItem1
        '
        Me.SuspendToolStripMenuItem1.Name = "SuspendToolStripMenuItem1"
        Me.SuspendToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SuspendToolStripMenuItem1.Text = "Suspend"
        '
        'NetbookUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1074, 562)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "NetbookUI"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "AtlasUI"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutDownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspendToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesktopModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesktopModeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RestartToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutDownToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspendToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MonthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
