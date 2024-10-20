<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLabel
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
        Me.components = New System.ComponentModel.Container()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ZCLabel = New System.Windows.Forms.Label()
        Me.SLabel = New System.Windows.Forms.Label()
        Me.CLabel = New System.Windows.Forms.Label()
        Me.SALabel = New System.Windows.Forms.Label()
        Me.FNLabel = New System.Windows.Forms.Label()
        Me.LNLabel = New System.Windows.Forms.Label()
        Me.LNTextBox = New System.Windows.Forms.TextBox()
        Me.FNTextBox = New System.Windows.Forms.TextBox()
        Me.ZCTextBox = New System.Windows.Forms.TextBox()
        Me.STextBox = New System.Windows.Forms.TextBox()
        Me.CTextBox = New System.Windows.Forms.TextBox()
        Me.SATextBox = New System.Windows.Forms.TextBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.DLButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.ZCLabel)
        Me.InputGroupBox.Controls.Add(Me.SLabel)
        Me.InputGroupBox.Controls.Add(Me.CLabel)
        Me.InputGroupBox.Controls.Add(Me.SALabel)
        Me.InputGroupBox.Controls.Add(Me.FNLabel)
        Me.InputGroupBox.Controls.Add(Me.LNLabel)
        Me.InputGroupBox.Controls.Add(Me.LNTextBox)
        Me.InputGroupBox.Controls.Add(Me.FNTextBox)
        Me.InputGroupBox.Controls.Add(Me.ZCTextBox)
        Me.InputGroupBox.Controls.Add(Me.STextBox)
        Me.InputGroupBox.Controls.Add(Me.CTextBox)
        Me.InputGroupBox.Controls.Add(Me.SATextBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(319, 239)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Mailing Address"
        '
        'ZCLabel
        '
        Me.ZCLabel.AutoSize = True
        Me.ZCLabel.Location = New System.Drawing.Point(172, 196)
        Me.ZCLabel.Name = "ZCLabel"
        Me.ZCLabel.Size = New System.Drawing.Size(50, 13)
        Me.ZCLabel.TabIndex = 0
        Me.ZCLabel.Text = "Zip Code"
        '
        'SLabel
        '
        Me.SLabel.AutoSize = True
        Me.SLabel.Location = New System.Drawing.Point(6, 196)
        Me.SLabel.Name = "SLabel"
        Me.SLabel.Size = New System.Drawing.Size(32, 13)
        Me.SLabel.TabIndex = 0
        Me.SLabel.Text = "State"
        '
        'CLabel
        '
        Me.CLabel.AutoSize = True
        Me.CLabel.Location = New System.Drawing.Point(6, 151)
        Me.CLabel.Name = "CLabel"
        Me.CLabel.Size = New System.Drawing.Size(24, 13)
        Me.CLabel.TabIndex = 0
        Me.CLabel.Text = "City"
        '
        'SALabel
        '
        Me.SALabel.AutoSize = True
        Me.SALabel.Location = New System.Drawing.Point(6, 107)
        Me.SALabel.Name = "SALabel"
        Me.SALabel.Size = New System.Drawing.Size(76, 13)
        Me.SALabel.TabIndex = 0
        Me.SALabel.Text = "Street Address"
        '
        'FNLabel
        '
        Me.FNLabel.AutoSize = True
        Me.FNLabel.Location = New System.Drawing.Point(6, 23)
        Me.FNLabel.Name = "FNLabel"
        Me.FNLabel.Size = New System.Drawing.Size(57, 13)
        Me.FNLabel.TabIndex = 0
        Me.FNLabel.Text = "First Name"
        '
        'LNLabel
        '
        Me.LNLabel.AutoSize = True
        Me.LNLabel.Location = New System.Drawing.Point(6, 67)
        Me.LNLabel.Name = "LNLabel"
        Me.LNLabel.Size = New System.Drawing.Size(58, 13)
        Me.LNLabel.TabIndex = 0
        Me.LNLabel.Text = "Last Name"
        '
        'LNTextBox
        '
        Me.LNTextBox.Location = New System.Drawing.Point(6, 83)
        Me.LNTextBox.Name = "LNTextBox"
        Me.LNTextBox.Size = New System.Drawing.Size(307, 20)
        Me.LNTextBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.LNTextBox, "Enter last name for label creation.")
        '
        'FNTextBox
        '
        Me.FNTextBox.Location = New System.Drawing.Point(6, 39)
        Me.FNTextBox.Name = "FNTextBox"
        Me.FNTextBox.Size = New System.Drawing.Size(307, 20)
        Me.FNTextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.FNTextBox, "Enter first name for label creation.")
        '
        'ZCTextBox
        '
        Me.ZCTextBox.Location = New System.Drawing.Point(166, 212)
        Me.ZCTextBox.Name = "ZCTextBox"
        Me.ZCTextBox.Size = New System.Drawing.Size(147, 20)
        Me.ZCTextBox.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.ZCTextBox, "Enter zip code for label creation.")
        '
        'STextBox
        '
        Me.STextBox.Location = New System.Drawing.Point(9, 212)
        Me.STextBox.Name = "STextBox"
        Me.STextBox.Size = New System.Drawing.Size(134, 20)
        Me.STextBox.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.STextBox, "Enter state for label creation.")
        '
        'CTextBox
        '
        Me.CTextBox.Location = New System.Drawing.Point(6, 167)
        Me.CTextBox.Name = "CTextBox"
        Me.CTextBox.Size = New System.Drawing.Size(307, 20)
        Me.CTextBox.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.CTextBox, "Enter city for label creation.")
        '
        'SATextBox
        '
        Me.SATextBox.Location = New System.Drawing.Point(6, 123)
        Me.SATextBox.Name = "SATextBox"
        Me.SATextBox.Size = New System.Drawing.Size(307, 20)
        Me.SATextBox.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.SATextBox, "Enter street for label creation.")
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Location = New System.Drawing.Point(337, 13)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(316, 238)
        Me.OutputGroupBox.TabIndex = 1
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Address Label"
        '
        'DLButton
        '
        Me.DLButton.Location = New System.Drawing.Point(12, 257)
        Me.DLButton.Name = "DLButton"
        Me.DLButton.Size = New System.Drawing.Size(197, 49)
        Me.DLButton.TabIndex = 2
        Me.DLButton.Text = "&Display Label"
        Me.ToolTip.SetToolTip(Me.DLButton, "Creates the address label.")
        Me.DLButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(236, 257)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(197, 49)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip.SetToolTip(Me.ClearButton, "Clears inputs and created label.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(456, 257)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(197, 49)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Closes window")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AddressLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 318)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DLButton)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.Name = "AddressLabel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adress Label Viewer"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents CLabel As Label
    Friend WithEvents SALabel As Label
    Friend WithEvents FNLabel As Label
    Friend WithEvents LNLabel As Label
    Friend WithEvents LNTextBox As TextBox
    Friend WithEvents FNTextBox As TextBox
    Friend WithEvents CTextBox As TextBox
    Friend WithEvents SATextBox As TextBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents SLabel As Label
    Friend WithEvents ZCTextBox As TextBox
    Friend WithEvents STextBox As TextBox
    Friend WithEvents ZCLabel As Label
    Friend WithEvents DLButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip As ToolTip
End Class
