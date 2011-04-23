Public Class AppearanceManager

    Private Property ArgumentNullException As Object

    Public Function GetWallpapers()
        If (My.Settings.Wallpaper = "AtlasUI_Ripples") Then
            UI.PictureBox1.BackgroundImage = My.Resources.AtlasUI_Ripples
        ElseIf (My.Settings.Wallpaper = "capsule_jpeg") Then
            UI.PictureBox1.BackgroundImage = My.Resources.capsule_jpeg
        ElseIf (My.Settings.Wallpaper = "cloudymountains") Then
            UI.PictureBox1.BackgroundImage = My.Resources.cloudymountains
        ElseIf (My.Settings.Wallpaper = "erodedrocks") Then
            UI.PictureBox1.BackgroundImage = My.Resources.erodedrocks
        ElseIf (My.Settings.Wallpaper = "Grass") Then
            UI.PictureBox1.BackgroundImage = My.Resources.grass
        ElseIf (My.Settings.Wallpaper = "rainfall") Then
            UI.PictureBox1.BackgroundImage = My.Resources.rainfall
        ElseIf (My.Settings.Wallpaper = "sunset") Then
            UI.PictureBox1.BackgroundImage = My.Resources.sunset
        ElseIf (My.Settings.Wallpaper = "sunflower") Then
            UI.PictureBox1.BackgroundImage = My.Resources.sunflower
        ElseIf (My.Settings.Wallpaper = "tundra") Then
            UI.PictureBox1.BackgroundImage = My.Resources.tundra
        ElseIf (My.Settings.Wallpaper = "tundra2") Then
            UI.PictureBox1.BackgroundImage = My.Resources.tundra2
        Else
            Dim BGImage As Image
            BGImage = Image.FromFile(My.Settings.Wallpaper)
            PictureBox1.BackgroundImage = BGImage
        End If
    End Function

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If (ListBox1.SelectedItem.ToString = "AtlasUI Ripples") Then
            PictureBox1.Image = My.Resources.AtlasUI_Ripples
            My.Settings.Wallpaper = "AtlasUI_Ripples"
        ElseIf (ListBox1.SelectedItem.ToString = "Capsules") Then
            My.Settings.Wallpaper = "capsule_jpeg"
            PictureBox1.Image = My.Resources.capsule_jpeg
        ElseIf (ListBox1.SelectedItem.ToString = "Cloudy Mountains") Then
            My.Settings.Wallpaper = "cloudymountains"
            PictureBox1.Image = My.Resources.cloudymountains
        ElseIf (ListBox1.SelectedItem.ToString = "Eroded Rocks") Then
            My.Settings.Wallpaper = "erodedrocks"
            PictureBox1.Image = My.Resources.erodedrocks
        ElseIf (ListBox1.SelectedItem.ToString = "Majestic Lake") Then
            My.Settings.Wallpaper = "majesticlake"
            PictureBox1.Image = My.Resources.majesticlake
        ElseIf (ListBox1.SelectedItem.ToString = "Rainfall") Then
            My.Settings.Wallpaper = "rainfall"
            PictureBox1.Image = My.Resources.rainfall
        ElseIf (ListBox1.SelectedItem.ToString = "Sunflower") Then
            My.Settings.Wallpaper = "sunflower"
            PictureBox1.Image = My.Resources.sunflower
        ElseIf (ListBox1.SelectedItem.ToString = "Sunset") Then
            My.Settings.Wallpaper = "sunset"
            PictureBox1.Image = My.Resources.sunset
        ElseIf (ListBox1.SelectedItem.ToString = "Tundra") Then
            My.Settings.Wallpaper = "tundra"
            PictureBox1.Image = My.Resources.tundra
        ElseIf (ListBox1.SelectedItem.ToString = "Tundra2") Then
            My.Settings.Wallpaper = "tundra2"
            PictureBox1.Image = My.Resources.tundra2
        End If
    End Sub

    Public Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim BrowseBackgrounds As New OpenFileDialog
        Dim FilePath As String
        Dim BGImage As Image
        BrowseBackgrounds.ShowDialog()
        BrowseBackgrounds.Multiselect = False
        BrowseBackgrounds.OpenFile()
        FilePath = BrowseBackgrounds.FileName
        BGImage = Image.FromFile(FilePath)
        PictureBox1.BackgroundImage = BGImage
        My.Settings.Wallpaper = FilePath
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If (ListBox2.SelectedItem = ArgumentNullException) Then
            Dim GetTheme As String = My.Settings.Theme.ToString
            My.Settings.Theme = GetTheme
        Else
            If (ListBox2.SelectedItem.ToString = "Default") Then
                My.Settings.Theme = "Default"
            ElseIf (ListBox2.SelectedItem.ToString = "Clean") Then
                My.Settings.Theme = "Clean"
            ElseIf (ListBox2.SelectedItem.ToString = "Blue") Then
                My.Settings.Theme = "Blue"
            ElseIf (ListBox2.SelectedItem.ToString = "Green") Then
                My.Settings.Theme = "Green"
            ElseIf (ListBox2.SelectedItem.ToString = "Red") Then
                My.Settings.Theme = "Red"
            End If
        End If
            My.Settings.Save()
            UI.PictureBox1.Refresh()
            UI.GetThemes()
            UI.GetWallpapers()
    End Sub

    Private Sub AppearanceManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetWallpapers()
    End Sub

End Class