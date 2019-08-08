<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class passwordGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passwordLengthofTen = New System.Windows.Forms.RadioButton()
        Me.passwordLengthofTwelve = New System.Windows.Forms.RadioButton()
        Me.passwordLengthofSpec = New System.Windows.Forms.RadioButton()
        Me.passwordLength = New System.Windows.Forms.TextBox()
        Me.selectpasswordLengthlabel = New System.Windows.Forms.Label()
        Me.tempPassword = New System.Windows.Forms.TextBox()
        Me.tempPasswordLabel = New System.Windows.Forms.Label()
        Me.generatePasswordbutton = New System.Windows.Forms.Button()
        Me.selectUpperCase = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.selectLowerCase = New System.Windows.Forms.CheckBox()
        Me.selectNumbers = New System.Windows.Forms.CheckBox()
        Me.selectSpecialChar = New System.Windows.Forms.CheckBox()
        Me.selectRequireUniqueChar = New System.Windows.Forms.CheckBox()
        Me.MaxUpper = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaxLower = New System.Windows.Forms.TextBox()
        Me.MaxNumbers = New System.Windows.Forms.TextBox()
        Me.MaxSymbols = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Length:"
        '
        'passwordLengthofTen
        '
        Me.passwordLengthofTen.AutoSize = True
        Me.passwordLengthofTen.Location = New System.Drawing.Point(112, 8)
        Me.passwordLengthofTen.Name = "passwordLengthofTen"
        Me.passwordLengthofTen.Size = New System.Drawing.Size(90, 17)
        Me.passwordLengthofTen.TabIndex = 2
        Me.passwordLengthofTen.TabStop = True
        Me.passwordLengthofTen.Text = "10 characters"
        Me.passwordLengthofTen.UseVisualStyleBackColor = True
        '
        'passwordLengthofTwelve
        '
        Me.passwordLengthofTwelve.AutoSize = True
        Me.passwordLengthofTwelve.Location = New System.Drawing.Point(231, 8)
        Me.passwordLengthofTwelve.Name = "passwordLengthofTwelve"
        Me.passwordLengthofTwelve.Size = New System.Drawing.Size(90, 17)
        Me.passwordLengthofTwelve.TabIndex = 3
        Me.passwordLengthofTwelve.TabStop = True
        Me.passwordLengthofTwelve.Text = "12 characters"
        Me.passwordLengthofTwelve.UseVisualStyleBackColor = True
        '
        'passwordLengthofSpec
        '
        Me.passwordLengthofSpec.AutoSize = True
        Me.passwordLengthofSpec.Location = New System.Drawing.Point(351, 8)
        Me.passwordLengthofSpec.Name = "passwordLengthofSpec"
        Me.passwordLengthofSpec.Size = New System.Drawing.Size(140, 17)
        Me.passwordLengthofSpec.TabIndex = 4
        Me.passwordLengthofSpec.TabStop = True
        Me.passwordLengthofSpec.Text = "Select Password Length"
        Me.passwordLengthofSpec.UseVisualStyleBackColor = True
        '
        'passwordLength
        '
        Me.passwordLength.Location = New System.Drawing.Point(112, 32)
        Me.passwordLength.Name = "passwordLength"
        Me.passwordLength.Size = New System.Drawing.Size(100, 20)
        Me.passwordLength.TabIndex = 5
        '
        'selectpasswordLengthlabel
        '
        Me.selectpasswordLengthlabel.AutoSize = True
        Me.selectpasswordLengthlabel.Location = New System.Drawing.Point(219, 38)
        Me.selectpasswordLengthlabel.Name = "selectpasswordLengthlabel"
        Me.selectpasswordLengthlabel.Size = New System.Drawing.Size(156, 13)
        Me.selectpasswordLengthlabel.TabIndex = 6
        Me.selectpasswordLengthlabel.Text = "Enter Desired Password Length"
        '
        'tempPassword
        '
        Me.tempPassword.Location = New System.Drawing.Point(112, 209)
        Me.tempPassword.Multiline = True
        Me.tempPassword.Name = "tempPassword"
        Me.tempPassword.Size = New System.Drawing.Size(418, 46)
        Me.tempPassword.TabIndex = 7
        '
        'tempPasswordLabel
        '
        Me.tempPasswordLabel.AutoSize = True
        Me.tempPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.tempPasswordLabel.Location = New System.Drawing.Point(13, 209)
        Me.tempPasswordLabel.Name = "tempPasswordLabel"
        Me.tempPasswordLabel.Size = New System.Drawing.Size(75, 18)
        Me.tempPasswordLabel.TabIndex = 8
        Me.tempPasswordLabel.Text = "Password"
        '
        'generatePasswordbutton
        '
        Me.generatePasswordbutton.Location = New System.Drawing.Point(403, 261)
        Me.generatePasswordbutton.Name = "generatePasswordbutton"
        Me.generatePasswordbutton.Size = New System.Drawing.Size(134, 20)
        Me.generatePasswordbutton.TabIndex = 9
        Me.generatePasswordbutton.Text = "Generate Password"
        Me.generatePasswordbutton.UseVisualStyleBackColor = True
        '
        'selectUpperCase
        '
        Me.selectUpperCase.AutoSize = True
        Me.selectUpperCase.Checked = True
        Me.selectUpperCase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.selectUpperCase.Location = New System.Drawing.Point(112, 95)
        Me.selectUpperCase.Name = "selectUpperCase"
        Me.selectUpperCase.Size = New System.Drawing.Size(112, 17)
        Me.selectUpperCase.TabIndex = 10
        Me.selectUpperCase.Text = "Upper case letters"
        Me.selectUpperCase.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Select required characters:"
        '
        'selectLowerCase
        '
        Me.selectLowerCase.AutoSize = True
        Me.selectLowerCase.Checked = True
        Me.selectLowerCase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.selectLowerCase.Location = New System.Drawing.Point(112, 119)
        Me.selectLowerCase.Name = "selectLowerCase"
        Me.selectLowerCase.Size = New System.Drawing.Size(112, 17)
        Me.selectLowerCase.TabIndex = 12
        Me.selectLowerCase.Text = "Lower case letters"
        Me.selectLowerCase.UseVisualStyleBackColor = True
        '
        'selectNumbers
        '
        Me.selectNumbers.AutoSize = True
        Me.selectNumbers.Checked = True
        Me.selectNumbers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.selectNumbers.Location = New System.Drawing.Point(112, 143)
        Me.selectNumbers.Name = "selectNumbers"
        Me.selectNumbers.Size = New System.Drawing.Size(92, 17)
        Me.selectNumbers.TabIndex = 13
        Me.selectNumbers.Text = "Numbers (0-9)"
        Me.selectNumbers.UseVisualStyleBackColor = True
        '
        'selectSpecialChar
        '
        Me.selectSpecialChar.AutoSize = True
        Me.selectSpecialChar.Checked = True
        Me.selectSpecialChar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.selectSpecialChar.Location = New System.Drawing.Point(112, 167)
        Me.selectSpecialChar.Name = "selectSpecialChar"
        Me.selectSpecialChar.Size = New System.Drawing.Size(162, 17)
        Me.selectSpecialChar.TabIndex = 14
        Me.selectSpecialChar.Text = "Special characters (!@#$%*)"
        Me.selectSpecialChar.UseVisualStyleBackColor = True
        '
        'selectRequireUniqueChar
        '
        Me.selectRequireUniqueChar.AutoSize = True
        Me.selectRequireUniqueChar.Checked = True
        Me.selectRequireUniqueChar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.selectRequireUniqueChar.Location = New System.Drawing.Point(112, 190)
        Me.selectRequireUniqueChar.Name = "selectRequireUniqueChar"
        Me.selectRequireUniqueChar.Size = New System.Drawing.Size(182, 17)
        Me.selectRequireUniqueChar.TabIndex = 15
        Me.selectRequireUniqueChar.Text = "No Duplicate Characters Allowed"
        Me.selectRequireUniqueChar.UseVisualStyleBackColor = True
        '
        'MaxUpper
        '
        Me.MaxUpper.Location = New System.Drawing.Point(291, 92)
        Me.MaxUpper.Name = "MaxUpper"
        Me.MaxUpper.Size = New System.Drawing.Size(39, 20)
        Me.MaxUpper.TabIndex = 16
        Me.MaxUpper.Text = "3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Max:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Max:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Max:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Max:"
        '
        'MaxLower
        '
        Me.MaxLower.Location = New System.Drawing.Point(291, 116)
        Me.MaxLower.Name = "MaxLower"
        Me.MaxLower.Size = New System.Drawing.Size(39, 20)
        Me.MaxLower.TabIndex = 21
        Me.MaxLower.Text = "2"
        '
        'MaxNumbers
        '
        Me.MaxNumbers.Location = New System.Drawing.Point(291, 140)
        Me.MaxNumbers.Name = "MaxNumbers"
        Me.MaxNumbers.Size = New System.Drawing.Size(39, 20)
        Me.MaxNumbers.TabIndex = 22
        Me.MaxNumbers.Text = "2"
        '
        'MaxSymbols
        '
        Me.MaxSymbols.Location = New System.Drawing.Point(351, 164)
        Me.MaxSymbols.Name = "MaxSymbols"
        Me.MaxSymbols.Size = New System.Drawing.Size(39, 20)
        Me.MaxSymbols.TabIndex = 23
        Me.MaxSymbols.Text = "1"
        '
        'passwordGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 293)
        Me.Controls.Add(Me.MaxSymbols)
        Me.Controls.Add(Me.MaxNumbers)
        Me.Controls.Add(Me.MaxLower)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MaxUpper)
        Me.Controls.Add(Me.selectRequireUniqueChar)
        Me.Controls.Add(Me.selectSpecialChar)
        Me.Controls.Add(Me.selectNumbers)
        Me.Controls.Add(Me.selectLowerCase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.selectUpperCase)
        Me.Controls.Add(Me.generatePasswordbutton)
        Me.Controls.Add(Me.tempPasswordLabel)
        Me.Controls.Add(Me.tempPassword)
        Me.Controls.Add(Me.selectpasswordLengthlabel)
        Me.Controls.Add(Me.passwordLength)
        Me.Controls.Add(Me.passwordLengthofSpec)
        Me.Controls.Add(Me.passwordLengthofTwelve)
        Me.Controls.Add(Me.passwordLengthofTen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "passwordGenerator"
        Me.Text = "Password Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents Label1 As Label
    'Friend WithEvents passwordLengthofEight As RadioButton
    Friend WithEvents passwordLengthofTen As RadioButton
    Friend WithEvents passwordLengthofTwelve As RadioButton
    Friend WithEvents passwordLengthofSpec As RadioButton
    Friend WithEvents passwordLength As TextBox
    Friend WithEvents selectpasswordLengthlabel As Label
    Friend WithEvents tempPassword As TextBox
    Friend WithEvents tempPasswordLabel As Label
    Friend WithEvents generatePasswordbutton As Button
    Friend WithEvents selectUpperCase As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents selectLowerCase As CheckBox
    Friend WithEvents selectNumbers As CheckBox
    Friend WithEvents selectSpecialChar As CheckBox
    Friend WithEvents selectRequireUniqueChar As CheckBox
    Friend WithEvents MaxUpper As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MaxLower As TextBox
    Friend WithEvents MaxNumbers As TextBox
    Friend WithEvents MaxSymbols As TextBox
End Class
