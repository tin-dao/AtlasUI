Public Class Preferences

    Private Sub Preferences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = My.Settings.DefaultLoad
        TextBox1.Text = My.Settings.HomePage
    End Sub

    Private Sub ComboBox1_Change() Handles ComboBox1.SelectedValueChanged
        My.Settings.Save()
    End Sub

    Public Sub TextBox1_Change() Handles TextBox1.TextChanged
        My.Settings.Save()
    End Sub

End Class