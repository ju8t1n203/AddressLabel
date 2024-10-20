'Justin Bell
'RCET0265
'Fall24
'Address Label Maker
'https://github.com/ju8t1n203/AddressLabel
Public Class AddressLabel
    'combines the first and laast name for the label
    Sub UserName()
        Dim nameLabel As New Label()
        nameLabel.Text = FNTextBox.Text & " " & LNTextBox.Text
        nameLabel.AutoSize = True
        OutputGroupBox.Controls.Clear()
        OutputGroupBox.Controls.Add(nameLabel)
        nameLabel.Location = New Point(10, 20)
    End Sub
    'displays the street for the label
    Sub Street()
        Dim streetLabel As New Label()
        streetLabel.Text = SATextBox.Text
        streetLabel.AutoSize = True
        OutputGroupBox.Controls.Add(streetLabel)
        streetLabel.Location = New Point(10, 40)
    End Sub
    'combines the city, state and zip code for the label
    Sub CSZip()
        Dim cszipLabel As New Label()
        cszipLabel.Text = CTextBox.Text & ", " & STextBox.Text & " " & ZCTextBox.Text
        cszipLabel.AutoSize = True
        OutputGroupBox.Controls.Add(cszipLabel)
        cszipLabel.Location = New Point(10, 60)
    End Sub
    'creates and displays the label
    Private Sub DLButton_Click(sender As Object, e As EventArgs) Handles DLButton.Click
        UserName()
        Street()
        CSZip()
    End Sub
    'clears the user inputs and created label
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FNTextBox.Clear()
        LNTextBox.Clear()
        SATextBox.Clear()
        CTextBox.Clear()
        STextBox.Clear()
        ZCTextBox.Clear()
        DLButton.PerformClick()
    End Sub
    'closes the application
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
