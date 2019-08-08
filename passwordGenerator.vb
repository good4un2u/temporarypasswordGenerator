'Generates a Random password based On the criteria selected
'Created by Jason Rippel jason.w.rippel@wellsfargo.com July 27th 2018
Public Class passwordGenerator

    Private Sub passwordGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Removes the Label from the password length field when the form loads
        selectpasswordLengthlabel.Visible = False
    End Sub
    '****Removed the Radio button for a password length of 8 on 10/10/2018 per request ****
    '****Request completed by Jason Rippel


    'Private Sub passwordLengthofEight_CheckedChanged(sender As Object, e As EventArgs) Handles passwordLengthofEight.CheckedChanged
    '    'Sets the length of the password based on the radio button selected
    '    If passwordLengthofEight.Checked Then
    '        passwordLength.Text = "8"
    '        'removes the label from the password length if the radio button for 8 is selected
    '        selectpasswordLengthlabel.Visible = False
    '        'makes the password length text box read only so it can't be changed
    '        passwordLength.ReadOnly = True

    '        'If the different character types are selected it sets the max numbers based on the password length
    '        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
    '            And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
    '            Select Case passwordLength.Text
    '                Case 8
    '                    MaxUpper.Text = "3"
    '                    MaxLower.Text = "2"
    '                    MaxNumbers.Text = "2"
    '                    MaxSymbols.Text = "1"
    '                Case 10
    '                    MaxUpper.Text = "4"
    '                    MaxLower.Text = "3"
    '                    MaxNumbers.Text = "2"
    '                    MaxSymbols.Text = "1"
    '                Case 12
    '                    MaxUpper.Text = "5"
    '                    MaxLower.Text = "4"
    '                    MaxNumbers.Text = "2"
    '                    MaxSymbols.Text = "1"
    '                Case Else
    '                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
    '                    MaxSymbols.Text = "1"
    '                    If Val(passwordLength.Text) = 4 Then
    '                        MaxNumbers.Text = "1"
    '                    ElseIf Val(passwordLength.Text) = 5 Then
    '                        MaxNumbers.Text = "1"
    '                    Else
    '                        MaxNumbers.Text = "2"
    '                    End If
    '                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
    '                        MaxLower.Text = "0"
    '                    Else
    '                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
    '                    End If
    '            End Select
    '        Else
    '            'If the different character types are selected it sets the max numbers based on the password length
    '            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
    '            And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
    '                Select Case passwordLength.Text
    '                    Case 8
    '                        MaxUpper.Text = "0"
    '                        MaxLower.Text = "5"
    '                        MaxNumbers.Text = "2"
    '                        MaxSymbols.Text = "1"
    '                    Case 10
    '                        MaxUpper.Text = "0"
    '                        MaxLower.Text = "5"
    '                        MaxNumbers.Text = "4"
    '                        MaxSymbols.Text = "1"
    '                    Case 12
    '                        MaxUpper.Text = "0"
    '                        MaxLower.Text = "6"
    '                        MaxNumbers.Text = "4"
    '                        MaxSymbols.Text = "2"
    '                    Case Else
    '                        MaxUpper.Text = "0"
    '                        MaxSymbols.Text = "1"
    '                        If Val(passwordLength.Text) = 4 Then
    '                            MaxNumbers.Text = "1"
    '                        ElseIf Val(passwordLength.Text) = 5 Then
    '                            MaxNumbers.Text = "1"
    '                        Else
    '                            MaxNumbers.Text = "2"
    '                        End If
    '                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
    '                            MaxLower.Text = "0"
    '                        Else
    '                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
    '                        End If

    '                End Select
    '            Else
    '                'If the different character types are selected it sets the max numbers based on the password length
    '                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
    '                    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
    '                    Select Case passwordLength.Text
    '                        Case 8
    '                            MaxUpper.Text = "5"
    '                            MaxLower.Text = "0"
    '                            MaxNumbers.Text = "2"
    '                            MaxSymbols.Text = "1"
    '                        Case 10
    '                            MaxUpper.Text = "5"
    '                            MaxLower.Text = "0"
    '                            MaxNumbers.Text = "4"
    '                            MaxSymbols.Text = "1"
    '                        Case 12
    '                            MaxUpper.Text = "6"
    '                            MaxLower.Text = "0"
    '                            MaxNumbers.Text = "4"
    '                            MaxSymbols.Text = "2"
    '                        Case Else
    '                            MaxLower.Text = "0"
    '                            MaxSymbols.Text = "1"
    '                            If Val(passwordLength.Text) = 4 Then
    '                                MaxNumbers.Text = "1"
    '                            ElseIf Val(passwordLength.Text) = 5 Then
    '                                MaxNumbers.Text = "1"
    '                            Else
    '                                MaxNumbers.Text = "2"
    '                            End If
    '                            If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
    '                                MaxUpper.Text = "0"
    '                            Else
    '                                MaxUpper.Text = Val(passwordLength.Text) - Val(MaxLower.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
    '                            End If
    '                    End Select
    '                Else
    '                    'If the different character types are selected it sets the max numbers based on the password length
    '                    If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
    '                        And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
    '                        Select Case passwordLength.Text
    '                            Case 8
    '                                MaxUpper.Text = "5"
    '                                MaxLower.Text = "2"
    '                                MaxNumbers.Text = "0"
    '                                MaxSymbols.Text = "1"
    '                            Case 10
    '                                MaxUpper.Text = "5"
    '                                MaxLower.Text = "4"
    '                                MaxNumbers.Text = "0"
    '                                MaxSymbols.Text = "1"
    '                            Case 12
    '                                MaxUpper.Text = "6"
    '                                MaxLower.Text = "4"
    '                                MaxNumbers.Text = "0"
    '                                MaxSymbols.Text = "2"
    '                            Case Else
    '                                MaxNumbers.Text = "0"
    '                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
    '                                MaxSymbols.Text = "1"
    '                                If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
    '                                    MaxLower.Text = "0"
    '                                Else
    '                                    MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
    '                                End If
    '                        End Select
    '                    Else
    '                        'If the different character types are selected it sets the max numbers based on the password length
    '                        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
    '                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
    '                            Select Case passwordLength.Text
    '                                Case 8
    '                                    MaxUpper.Text = "5"
    '                                    MaxLower.Text = "2"
    '                                    MaxNumbers.Text = "1"
    '                                    MaxSymbols.Text = "0"
    '                                Case 10
    '                                    MaxUpper.Text = "5"
    '                                    MaxLower.Text = "4"
    '                                    MaxNumbers.Text = "1"
    '                                    MaxSymbols.Text = "0"
    '                                Case 12
    '                                    MaxUpper.Text = "6"
    '                                    MaxLower.Text = "4"
    '                                    MaxNumbers.Text = "2"
    '                                    MaxSymbols.Text = "0"
    '                                Case Else
    '                                    MaxSymbols.Text = "0"
    '                                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
    '                                    If Val(passwordLength.Text) = 4 Then
    '                                        MaxNumbers.Text = "1"
    '                                    ElseIf Val(passwordLength.Text) = 5 Then
    '                                        MaxNumbers.Text = "1"
    '                                    Else
    '                                        MaxNumbers.Text = "2"
    '                                    End If
    '                                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
    '                                        MaxLower.Text = "0"
    '                                    Else
    '                                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
    '                                    End If
    '                            End Select
    '                        Else
    '                            'If the different character types are selected it sets the max numbers based on the password length
    '                            If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
    '                                And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
    '                                Select Case passwordLength.Text
    '                                    Case 8
    '                                        MaxUpper.Text = "5"
    '                                        MaxLower.Text = "3"
    '                                        MaxNumbers.Text = "0"
    '                                        MaxSymbols.Text = "0"
    '                                    Case 10
    '                                        MaxUpper.Text = "5"
    '                                        MaxLower.Text = "5"
    '                                        MaxNumbers.Text = "0"
    '                                        MaxSymbols.Text = "0"
    '                                    Case 12
    '                                        MaxUpper.Text = "6"
    '                                        MaxLower.Text = "6"
    '                                        MaxNumbers.Text = "0"
    '                                        MaxSymbols.Text = "0"
    '                                    Case Else
    '                                        MaxNumbers.Text = "0"
    '                                        MaxSymbols.Text = "0"
    '                                        MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
    '                                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
    '                                            MaxLower.Text = "0"
    '                                        Else
    '                                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
    '                                        End If
    '                                End Select
    '                            Else
    '                                'If the different character types are selected it sets the max numbers based on the password length
    '                                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
    '                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
    '                                    Select Case passwordLength.Text
    '                                        Case 8
    '                                            MaxUpper.Text = "8"
    '                                            MaxLower.Text = "0"
    '                                            MaxNumbers.Text = "0"
    '                                            MaxSymbols.Text = "0"
    '                                        Case 10
    '                                            MaxUpper.Text = "10"
    '                                            MaxLower.Text = "0"
    '                                            MaxNumbers.Text = "0"
    '                                            MaxSymbols.Text = "0"
    '                                        Case 12
    '                                            MaxUpper.Text = "12"
    '                                            MaxLower.Text = "0"
    '                                            MaxNumbers.Text = "0"
    '                                            MaxSymbols.Text = "0"
    '                                        Case Else
    '                                            MaxUpper.Text = Val(passwordLength.Text)
    '                                            MaxLower.Text = "0"
    '                                            MaxNumbers.Text = "0"
    '                                            MaxSymbols.Text = "0"
    '                                    End Select
    '                                Else
    '                                    'If the different character types are selected it sets the max numbers based on the password length
    '                                    If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
    '                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
    '                                        Select Case passwordLength.Text
    '                                            Case 8
    '                                                MaxUpper.Text = "0"
    '                                                MaxLower.Text = "0"
    '                                                MaxNumbers.Text = "4"
    '                                                MaxSymbols.Text = "4"
    '                                            Case 10
    '                                                MaxUpper.Text = "0"
    '                                                MaxLower.Text = "0"
    '                                                MaxNumbers.Text = "5"
    '                                                MaxSymbols.Text = "5"
    '                                            Case 12
    '                                                MaxUpper.Text = "0"
    '                                                MaxLower.Text = "0"
    '                                                MaxNumbers.Text = "6"
    '                                                MaxSymbols.Text = "6"
    '                                            Case Else
    '                                                Val(passwordLength.Text)
    '                                                MaxUpper.Text = "0"
    '                                                MaxLower.Text = "0"
    '                                                MaxNumbers.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
    '                                                MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

    '                                        End Select
    '                                    Else
    '                                        'If the different character types are selected it sets the max numbers based on the password length
    '                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
    '                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
    '                                            Select Case passwordLength.Text
    '                                                Case 8
    '                                                    MaxUpper.Text = "0"
    '                                                    MaxLower.Text = "8"
    '                                                    MaxNumbers.Text = "0"
    '                                                    MaxSymbols.Text = "0"
    '                                                Case 10
    '                                                    MaxUpper.Text = "0"
    '                                                    MaxLower.Text = "10"
    '                                                    MaxNumbers.Text = "0"
    '                                                    MaxSymbols.Text = ""
    '                                                Case 12
    '                                                    MaxUpper.Text = "0"
    '                                                    MaxLower.Text = "12"
    '                                                    MaxNumbers.Text = "0"
    '                                                    MaxSymbols.Text = "0"
    '                                                Case Else
    '                                                    MaxUpper.Text = "0"
    '                                                    MaxLower.Text = Val(passwordLength.Text)
    '                                                    MaxNumbers.Text = "0"
    '                                                    MaxSymbols.Text = "0"
    '                                            End Select
    '                                        Else
    '                                            'If the different character types are selected it sets the max numbers based on the password length
    '                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
    '                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
    '                                                Select Case passwordLength.Text
    '                                                    Case 8
    '                                                        MaxUpper.Text = "0"
    '                                                        MaxLower.Text = "0"
    '                                                        MaxNumbers.Text = "8"
    '                                                        MaxSymbols.Text = "0"
    '                                                    Case 10
    '                                                        MaxUpper.Text = "0"
    '                                                        MaxLower.Text = "0"
    '                                                        MaxNumbers.Text = "10"
    '                                                        MaxSymbols.Text = "0"
    '                                                    Case 12
    '                                                        MaxUpper.Text = "0"
    '                                                        MaxLower.Text = "0"
    '                                                        MaxNumbers.Text = "12"
    '                                                        MaxSymbols.Text = "0"
    '                                                    Case Else
    '                                                        MaxUpper.Text = "0"
    '                                                        MaxLower.Text = "0"
    '                                                        MaxNumbers.Text = Val(passwordLength.Text)
    '                                                        MaxSymbols.Text = "0"

    '                                                End Select
    '                                            Else
    '                                                'If the different character types are selected it sets the max numbers based on the password length
    '                                                If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
    '                                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
    '                                                    Select Case passwordLength.Text
    '                                                        Case 8
    '                                                            MaxUpper.Text = "0"
    '                                                            MaxLower.Text = "0"
    '                                                            MaxNumbers.Text = "0"
    '                                                            MaxSymbols.Text = "8"
    '                                                        Case 10
    '                                                            MaxUpper.Text = "0"
    '                                                            MaxLower.Text = "0"
    '                                                            MaxNumbers.Text = "0"
    '                                                            MaxSymbols.Text = "10"
    '                                                        Case 12
    '                                                            MaxUpper.Text = "0"
    '                                                            MaxLower.Text = "0"
    '                                                            MaxNumbers.Text = "0"
    '                                                            MaxSymbols.Text = "12"
    '                                                        Case Else
    '                                                            MaxUpper.Text = "0"
    '                                                            MaxLower.Text = "0"
    '                                                            MaxNumbers.Text = "0"
    '                                                            MaxSymbols.Text = Val(passwordLength.Text)
    '                                                    End Select
    '                                                Else
    '                                                    'If the different character types are selected it sets the max numbers based on the password length
    '                                                    If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
    '                                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
    '                                                        Select Case passwordLength.Text
    '                                                            Case 8
    '                                                                MaxUpper.Text = "6"
    '                                                                MaxLower.Text = "0"
    '                                                                MaxNumbers.Text = "2"
    '                                                                MaxSymbols.Text = "0"
    '                                                            Case 10
    '                                                                MaxUpper.Text = "6"
    '                                                                MaxLower.Text = "0"
    '                                                                MaxNumbers.Text = "4"
    '                                                                MaxSymbols.Text = "0"
    '                                                            Case 12
    '                                                                MaxUpper.Text = "8"
    '                                                                MaxLower.Text = "0"
    '                                                                MaxNumbers.Text = "4"
    '                                                                MaxSymbols.Text = "0"
    '                                                            Case Else
    '                                                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
    '                                                                MaxLower.Text = "0"
    '                                                                MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
    '                                                                MaxSymbols.Text = "0"
    '                                                        End Select
    '                                                    Else
    '                                                        'If the different character types are selected it sets the max numbers based on the password length
    '                                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
    '                                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
    '                                                            Select Case passwordLength.Text
    '                                                                Case 8
    '                                                                    MaxUpper.Text = "0"
    '                                                                    MaxLower.Text = "6"
    '                                                                    MaxNumbers.Text = "0"
    '                                                                    MaxSymbols.Text = "2"
    '                                                                Case 10
    '                                                                    MaxUpper.Text = "0"
    '                                                                    MaxLower.Text = "6"
    '                                                                    MaxNumbers.Text = "0"
    '                                                                    MaxSymbols.Text = "4"
    '                                                                Case 12
    '                                                                    MaxUpper.Text = "0"
    '                                                                    MaxLower.Text = "8"
    '                                                                    MaxNumbers.Text = "0"
    '                                                                    MaxSymbols.Text = "4"
    '                                                                Case Else
    '                                                                    MaxUpper.Text = "0"
    '                                                                    MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
    '                                                                    MaxNumbers.Text = "0"
    '                                                                    MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)
    '                                                            End Select
    '                                                        Else
    '                                                            'If the different character types are selected it sets the max numbers based on the password length
    '                                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
    '                                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
    '                                                                Select Case passwordLength.Text
    '                                                                    Case 8
    '                                                                        MaxUpper.Text = "0"
    '                                                                        MaxLower.Text = "6"
    '                                                                        MaxNumbers.Text = "2"
    '                                                                        MaxSymbols.Text = "0"
    '                                                                    Case 10
    '                                                                        MaxUpper.Text = "0"
    '                                                                        MaxLower.Text = "6"
    '                                                                        MaxNumbers.Text = "4"
    '                                                                        MaxSymbols.Text = "0"
    '                                                                    Case 12
    '                                                                        MaxUpper.Text = "0"
    '                                                                        MaxLower.Text = "8"
    '                                                                        MaxNumbers.Text = "4"
    '                                                                        MaxSymbols.Text = "0"
    '                                                                    Case Else
    '                                                                        MaxUpper.Text = "0"
    '                                                                        MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
    '                                                                        MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
    '                                                                        MaxSymbols.Text = "0"
    '                                                                End Select
    '                                                            End If
    '                                                        End If
    '                                                    End If
    '                                                End If
    '                                            End If
    '                                        End If
    '                                    End If
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub passwordLengthofTen_CheckedChanged(sender As Object, e As EventArgs) Handles passwordLengthofTen.CheckedChanged
        If passwordLengthofTen.Checked Then
            passwordLength.Text = "10"
            selectpasswordLengthlabel.Visible = False
            passwordLength.ReadOnly = True
            If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                Select Case passwordLength.Text
                    Case 8
                        MaxUpper.Text = "3"
                        MaxLower.Text = "2"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case 10
                        MaxUpper.Text = "4"
                        MaxLower.Text = "3"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case 12
                        MaxUpper.Text = "5"
                        MaxLower.Text = "4"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case Else
                        MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                        MaxSymbols.Text = "1"
                        If Val(passwordLength.Text) = 4 Then
                            MaxNumbers.Text = "1"
                        ElseIf Val(passwordLength.Text) = 5 Then
                            MaxNumbers.Text = "1"
                        Else
                            MaxNumbers.Text = "2"
                        End If
                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                            MaxLower.Text = "0"
                        Else
                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                        End If
                End Select
            Else
                If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                    Select Case passwordLength.Text
                        Case 8
                            MaxUpper.Text = "0"
                            MaxLower.Text = "5"
                            MaxNumbers.Text = "2"
                            MaxSymbols.Text = "1"
                        Case 10
                            MaxUpper.Text = "0"
                            MaxLower.Text = "5"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "1"
                        Case 12
                            MaxUpper.Text = "0"
                            MaxLower.Text = "6"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "2"
                        Case Else
                            MaxUpper.Text = "0"
                            MaxSymbols.Text = "1"
                            If Val(passwordLength.Text) = 4 Then
                                MaxNumbers.Text = "1"
                            ElseIf Val(passwordLength.Text) = 5 Then
                                MaxNumbers.Text = "1"
                            Else
                                MaxNumbers.Text = "2"
                            End If
                            If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                MaxLower.Text = "0"
                            Else
                                MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                            End If

                    End Select
                Else
                    If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                        And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                        Select Case passwordLength.Text
                            Case 8
                                MaxUpper.Text = "5"
                                MaxLower.Text = "0"
                                MaxNumbers.Text = "2"
                                MaxSymbols.Text = "1"
                            Case 10
                                MaxUpper.Text = "5"
                                MaxLower.Text = "0"
                                MaxNumbers.Text = "4"
                                MaxSymbols.Text = "1"
                            Case 12
                                MaxUpper.Text = "6"
                                MaxLower.Text = "0"
                                MaxNumbers.Text = "4"
                                MaxSymbols.Text = "2"
                            Case Else
                                MaxLower.Text = "0"
                                MaxSymbols.Text = "1"
                                If Val(passwordLength.Text) = 4 Then
                                    MaxNumbers.Text = "1"
                                ElseIf Val(passwordLength.Text) = 5 Then
                                    MaxNumbers.Text = "1"
                                Else
                                    MaxNumbers.Text = "2"
                                End If
                                If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                    MaxUpper.Text = "0"
                                Else
                                    MaxUpper.Text = Val(passwordLength.Text) - Val(MaxLower.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                End If
                        End Select
                    Else
                        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                            And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                            Select Case passwordLength.Text
                                Case 8
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "2"
                                    MaxNumbers.Text = "0"
                                    MaxSymbols.Text = "1"
                                Case 10
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "0"
                                    MaxSymbols.Text = "1"
                                Case 12
                                    MaxUpper.Text = "6"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "0"
                                    MaxSymbols.Text = "2"
                                Case Else
                                    MaxNumbers.Text = "0"
                                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                    MaxSymbols.Text = "1"
                                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                        MaxLower.Text = "0"
                                    Else
                                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                    End If
                            End Select
                        Else
                            If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                            And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                Select Case passwordLength.Text
                                    Case 8
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "2"
                                        MaxNumbers.Text = "1"
                                        MaxSymbols.Text = "0"
                                    Case 10
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "4"
                                        MaxNumbers.Text = "1"
                                        MaxSymbols.Text = "0"
                                    Case 12
                                        MaxUpper.Text = "6"
                                        MaxLower.Text = "4"
                                        MaxNumbers.Text = "2"
                                        MaxSymbols.Text = "0"
                                    Case Else
                                        MaxSymbols.Text = "0"
                                        MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                        If Val(passwordLength.Text) = 4 Then
                                            MaxNumbers.Text = "1"
                                        ElseIf Val(passwordLength.Text) = 5 Then
                                            MaxNumbers.Text = "1"
                                        Else
                                            MaxNumbers.Text = "2"
                                        End If
                                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                            MaxLower.Text = "0"
                                        Else
                                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                        End If
                                End Select
                            Else
                                If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                    Select Case passwordLength.Text
                                        Case 8
                                            MaxUpper.Text = "5"
                                            MaxLower.Text = "3"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 10
                                            MaxUpper.Text = "5"
                                            MaxLower.Text = "5"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 12
                                            MaxUpper.Text = "6"
                                            MaxLower.Text = "6"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case Else
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                            MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                            If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                                MaxLower.Text = "0"
                                            Else
                                                MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                            End If
                                    End Select
                                Else
                                    If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                        And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                        Select Case passwordLength.Text
                                            Case 8
                                                MaxUpper.Text = "8"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "0"
                                                MaxSymbols.Text = "0"
                                            Case 10
                                                MaxUpper.Text = "10"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "0"
                                                MaxSymbols.Text = "0"
                                            Case 12
                                                MaxUpper.Text = "12"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "0"
                                                MaxSymbols.Text = "0"
                                            Case Else
                                                MaxUpper.Text = Val(passwordLength.Text)
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "0"
                                                MaxSymbols.Text = "0"
                                        End Select
                                    Else
                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                            And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                                            Select Case passwordLength.Text
                                                Case 8
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "0"
                                                    MaxNumbers.Text = "4"
                                                    MaxSymbols.Text = "4"
                                                Case 10
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "0"
                                                    MaxNumbers.Text = "5"
                                                    MaxSymbols.Text = "5"
                                                Case 12
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "0"
                                                    MaxNumbers.Text = "6"
                                                    MaxSymbols.Text = "6"
                                                Case Else
                                                    Val(passwordLength.Text)
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "0"
                                                    MaxNumbers.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                    MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                            End Select
                                        Else
                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                                Select Case passwordLength.Text
                                                    Case 8
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "8"
                                                        MaxNumbers.Text = "0"
                                                        MaxSymbols.Text = "0"
                                                    Case 10
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "10"
                                                        MaxNumbers.Text = "0"
                                                        MaxSymbols.Text = ""
                                                    Case 12
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "12"
                                                        MaxNumbers.Text = "0"
                                                        MaxSymbols.Text = "0"
                                                    Case Else
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = Val(passwordLength.Text)
                                                        MaxNumbers.Text = "0"
                                                        MaxSymbols.Text = "0"
                                                End Select
                                            Else
                                                If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                    And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                    Select Case passwordLength.Text
                                                        Case 8
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "8"
                                                            MaxSymbols.Text = "0"
                                                        Case 10
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "10"
                                                            MaxSymbols.Text = "0"
                                                        Case 12
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "12"
                                                            MaxSymbols.Text = "0"
                                                        Case Else
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = Val(passwordLength.Text)
                                                            MaxSymbols.Text = "0"

                                                    End Select
                                                Else
                                                    If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                        And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                        Select Case passwordLength.Text
                                                            Case 8
                                                                MaxUpper.Text = "0"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "0"
                                                                MaxSymbols.Text = "8"
                                                            Case 10
                                                                MaxUpper.Text = "0"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "0"
                                                                MaxSymbols.Text = "10"
                                                            Case 12
                                                                MaxUpper.Text = "0"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "0"
                                                                MaxSymbols.Text = "12"
                                                            Case Else
                                                                MaxUpper.Text = "0"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "0"
                                                                MaxSymbols.Text = Val(passwordLength.Text)

                                                        End Select
                                                    Else
                                                        If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                                            And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                            Select Case passwordLength.Text
                                                                Case 8
                                                                    MaxUpper.Text = "6"
                                                                    MaxLower.Text = "0"
                                                                    MaxNumbers.Text = "2"
                                                                    MaxSymbols.Text = "0"
                                                                Case 10
                                                                    MaxUpper.Text = "6"
                                                                    MaxLower.Text = "0"
                                                                    MaxNumbers.Text = "4"
                                                                    MaxSymbols.Text = "0"
                                                                Case 12
                                                                    MaxUpper.Text = "8"
                                                                    MaxLower.Text = "0"
                                                                    MaxNumbers.Text = "4"
                                                                    MaxSymbols.Text = "0"
                                                                Case Else
                                                                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                    MaxLower.Text = "0"
                                                                    MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                    MaxSymbols.Text = "0"

                                                            End Select
                                                        Else
                                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                                And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                                Select Case passwordLength.Text
                                                                    Case 8
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "0"
                                                                        MaxSymbols.Text = "2"
                                                                    Case 10
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "0"
                                                                        MaxSymbols.Text = "4"
                                                                    Case 12
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "8"
                                                                        MaxNumbers.Text = "0"
                                                                        MaxSymbols.Text = "4"
                                                                    Case Else
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                        MaxNumbers.Text = "0"
                                                                        MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                                                End Select
                                                            Else
                                                                If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                                    And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                                    Select Case passwordLength.Text
                                                                        Case 8
                                                                            MaxUpper.Text = "0"
                                                                            MaxLower.Text = "6"
                                                                            MaxNumbers.Text = "2"
                                                                            MaxSymbols.Text = "0"
                                                                        Case 10
                                                                            MaxUpper.Text = "0"
                                                                            MaxLower.Text = "6"
                                                                            MaxNumbers.Text = "4"
                                                                            MaxSymbols.Text = "0"
                                                                        Case 12
                                                                            MaxUpper.Text = "0"
                                                                            MaxLower.Text = "8"
                                                                            MaxNumbers.Text = "4"
                                                                            MaxSymbols.Text = "0"
                                                                        Case Else
                                                                            MaxUpper.Text = "0"
                                                                            MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                            MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                            MaxSymbols.Text = "0"
                                                                    End Select
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub passwordLengthofTwelve_CheckedChanged(sender As Object, e As EventArgs) Handles passwordLengthofTwelve.CheckedChanged
        If passwordLengthofTwelve.Checked Then
            passwordLength.Text = "12"
            selectpasswordLengthlabel.Visible = False
            passwordLength.ReadOnly = True
            If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                Select Case passwordLength.Text
                    Case 8
                        MaxUpper.Text = "3"
                        MaxLower.Text = "2"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case 10
                        MaxUpper.Text = "4"
                        MaxLower.Text = "3"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case 12
                        MaxUpper.Text = "5"
                        MaxLower.Text = "4"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case Else
                        MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                        MaxSymbols.Text = "1"
                        If Val(passwordLength.Text) = 4 Then
                            MaxNumbers.Text = "1"
                        ElseIf Val(passwordLength.Text) = 5 Then
                            MaxNumbers.Text = "1"
                        Else
                            MaxNumbers.Text = "2"
                        End If
                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                            MaxLower.Text = "0"
                        Else
                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                        End If
                End Select
            Else
                If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                    Select Case passwordLength.Text
                        Case 8
                            MaxUpper.Text = "0"
                            MaxLower.Text = "5"
                            MaxNumbers.Text = "2"
                            MaxSymbols.Text = "1"
                        Case 10
                            MaxUpper.Text = "0"
                            MaxLower.Text = "5"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "1"
                        Case 12
                            MaxUpper.Text = "0"
                            MaxLower.Text = "6"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "2"
                        Case Else
                            MaxUpper.Text = "0"
                            MaxSymbols.Text = "1"
                            If Val(passwordLength.Text) = 4 Then
                                MaxNumbers.Text = "1"
                            ElseIf Val(passwordLength.Text) = 5 Then
                                MaxNumbers.Text = "1"
                            Else
                                MaxNumbers.Text = "2"
                            End If
                            If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                MaxLower.Text = "0"
                            Else
                                MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                            End If

                    End Select
                Else
                    If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                        And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                        Select Case passwordLength.Text
                            Case 8
                                MaxUpper.Text = "5"
                                MaxLower.Text = "0"
                                MaxNumbers.Text = "2"
                                MaxSymbols.Text = "1"
                            Case 10
                                MaxUpper.Text = "5"
                                MaxLower.Text = "0"
                                MaxNumbers.Text = "4"
                                MaxSymbols.Text = "1"
                            Case 12
                                MaxUpper.Text = "6"
                                MaxLower.Text = "0"
                                MaxNumbers.Text = "4"
                                MaxSymbols.Text = "2"
                            Case Else
                                MaxLower.Text = "0"
                                MaxSymbols.Text = "1"
                                If Val(passwordLength.Text) = 4 Then
                                    MaxNumbers.Text = "1"
                                ElseIf Val(passwordLength.Text) = 5 Then
                                    MaxNumbers.Text = "1"
                                Else
                                    MaxNumbers.Text = "2"
                                End If
                                If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                    MaxUpper.Text = "0"
                                Else
                                    MaxUpper.Text = Val(passwordLength.Text) - Val(MaxLower.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                End If
                        End Select
                    Else
                        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                            And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                            Select Case passwordLength.Text
                                Case 8
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "2"
                                    MaxNumbers.Text = "0"
                                    MaxSymbols.Text = "1"
                                Case 10
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "0"
                                    MaxSymbols.Text = "1"
                                Case 12
                                    MaxUpper.Text = "6"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "0"
                                    MaxSymbols.Text = "2"
                                Case Else
                                    MaxNumbers.Text = "0"
                                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                    MaxSymbols.Text = "1"
                                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                        MaxLower.Text = "0"
                                    Else
                                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                    End If
                            End Select
                        Else
                            If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                            And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                Select Case passwordLength.Text
                                    Case 8
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "2"
                                        MaxNumbers.Text = "1"
                                        MaxSymbols.Text = "0"
                                    Case 10
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "4"
                                        MaxNumbers.Text = "1"
                                        MaxSymbols.Text = "0"
                                    Case 12
                                        MaxUpper.Text = "6"
                                        MaxLower.Text = "4"
                                        MaxNumbers.Text = "2"
                                        MaxSymbols.Text = "0"
                                    Case Else
                                        MaxSymbols.Text = "0"
                                        MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                        If Val(passwordLength.Text) = 4 Then
                                            MaxNumbers.Text = "1"
                                        ElseIf Val(passwordLength.Text) = 5 Then
                                            MaxNumbers.Text = "1"
                                        Else
                                            MaxNumbers.Text = "2"
                                        End If
                                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                            MaxLower.Text = "0"
                                        Else
                                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                        End If
                                End Select
                            Else
                                If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                    Select Case passwordLength.Text
                                        Case 8
                                            MaxUpper.Text = "5"
                                            MaxLower.Text = "3"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 10
                                            MaxUpper.Text = "5"
                                            MaxLower.Text = "5"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 12
                                            MaxUpper.Text = "6"
                                            MaxLower.Text = "6"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case Else
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                            MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                            If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                                MaxLower.Text = "0"
                                            Else
                                                MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                            End If
                                    End Select
                                Else
                                    If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                        And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                        Select Case passwordLength.Text
                                            Case 8
                                                MaxUpper.Text = "8"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "0"
                                                MaxSymbols.Text = "0"
                                            Case 10
                                                MaxUpper.Text = "10"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "0"
                                                MaxSymbols.Text = "0"
                                            Case 12
                                                MaxUpper.Text = "12"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "0"
                                                MaxSymbols.Text = "0"
                                            Case Else
                                                MaxUpper.Text = Val(passwordLength.Text)
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "0"
                                                MaxSymbols.Text = "0"
                                        End Select
                                    Else
                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                            And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                                            Select Case passwordLength.Text
                                                Case 8
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "0"
                                                    MaxNumbers.Text = "4"
                                                    MaxSymbols.Text = "4"
                                                Case 10
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "0"
                                                    MaxNumbers.Text = "5"
                                                    MaxSymbols.Text = "5"
                                                Case 12
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "0"
                                                    MaxNumbers.Text = "6"
                                                    MaxSymbols.Text = "6"
                                                Case Else
                                                    Val(passwordLength.Text)
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "0"
                                                    MaxNumbers.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                    MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                            End Select
                                        Else
                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                                Select Case passwordLength.Text
                                                    Case 8
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "8"
                                                        MaxNumbers.Text = "0"
                                                        MaxSymbols.Text = "0"
                                                    Case 10
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "10"
                                                        MaxNumbers.Text = "0"
                                                        MaxSymbols.Text = ""
                                                    Case 12
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "12"
                                                        MaxNumbers.Text = "0"
                                                        MaxSymbols.Text = "0"
                                                    Case Else
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = Val(passwordLength.Text)
                                                        MaxNumbers.Text = "0"
                                                        MaxSymbols.Text = "0"
                                                End Select
                                            Else
                                                If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                    And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                    Select Case passwordLength.Text
                                                        Case 8
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "8"
                                                            MaxSymbols.Text = "0"
                                                        Case 10
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "10"
                                                            MaxSymbols.Text = "0"
                                                        Case 12
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "12"
                                                            MaxSymbols.Text = "0"
                                                        Case Else
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = Val(passwordLength.Text)
                                                            MaxSymbols.Text = "0"

                                                    End Select
                                                Else
                                                    If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                        And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                        Select Case passwordLength.Text
                                                            Case 8
                                                                MaxUpper.Text = "0"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "0"
                                                                MaxSymbols.Text = "8"
                                                            Case 10
                                                                MaxUpper.Text = "0"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "0"
                                                                MaxSymbols.Text = "10"
                                                            Case 12
                                                                MaxUpper.Text = "0"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "0"
                                                                MaxSymbols.Text = "12"
                                                            Case Else
                                                                MaxUpper.Text = "0"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "0"
                                                                MaxSymbols.Text = Val(passwordLength.Text)

                                                        End Select
                                                    Else
                                                        If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                                            And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                            Select Case passwordLength.Text
                                                                Case 8
                                                                    MaxUpper.Text = "6"
                                                                    MaxLower.Text = "0"
                                                                    MaxNumbers.Text = "2"
                                                                    MaxSymbols.Text = "0"
                                                                Case 10
                                                                    MaxUpper.Text = "6"
                                                                    MaxLower.Text = "0"
                                                                    MaxNumbers.Text = "4"
                                                                    MaxSymbols.Text = "0"
                                                                Case 12
                                                                    MaxUpper.Text = "8"
                                                                    MaxLower.Text = "0"
                                                                    MaxNumbers.Text = "4"
                                                                    MaxSymbols.Text = "0"
                                                                Case Else
                                                                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                    MaxLower.Text = "0"
                                                                    MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                    MaxSymbols.Text = "0"

                                                            End Select
                                                        Else
                                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                                And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                                Select Case passwordLength.Text
                                                                    Case 8
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "0"
                                                                        MaxSymbols.Text = "2"
                                                                    Case 10
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "0"
                                                                        MaxSymbols.Text = "4"
                                                                    Case 12
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "8"
                                                                        MaxNumbers.Text = "0"
                                                                        MaxSymbols.Text = "4"
                                                                    Case Else
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                        MaxNumbers.Text = "0"
                                                                        MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                                                End Select
                                                            Else
                                                                If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                                    And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                                    Select Case passwordLength.Text
                                                                        Case 8
                                                                            MaxUpper.Text = "0"
                                                                            MaxLower.Text = "6"
                                                                            MaxNumbers.Text = "2"
                                                                            MaxSymbols.Text = "0"
                                                                        Case 10
                                                                            MaxUpper.Text = "0"
                                                                            MaxLower.Text = "6"
                                                                            MaxNumbers.Text = "4"
                                                                            MaxSymbols.Text = "0"
                                                                        Case 12
                                                                            MaxUpper.Text = "0"
                                                                            MaxLower.Text = "8"
                                                                            MaxNumbers.Text = "4"
                                                                            MaxSymbols.Text = "0"
                                                                        Case Else
                                                                            MaxUpper.Text = "0"
                                                                            MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                            MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                            MaxSymbols.Text = "0"
                                                                    End Select
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub passwordLengthofSpec_CheckedChanged(sender As Object, e As EventArgs) Handles passwordLengthofSpec.CheckedChanged
        If passwordLengthofSpec.Checked Then
            passwordLength.Text = ""
            selectpasswordLengthlabel.Visible = True
            passwordLength.ReadOnly = False
        End If
    End Sub

    Private Sub generatePasswordbutton_Click(sender As Object, e As EventArgs) Handles generatePasswordbutton.Click

        If Val(passwordLength.Text) < 4 Then
            MsgBox("Password minimum Length is 4.")
            Exit Sub
        End If

        If Val(passwordLength.Text) > Val(MaxUpper.Text) + Val(MaxLower.Text) + Val(MaxNumbers.Text) + Val(MaxSymbols.Text) Then
            MsgBox("Max values Of characters needed must add up To password Length!!")
            Exit Sub
        End If

        Dim strResult = ""
        Dim newaddition = ""
        Dim teststring
        Dim UpperTotal = 0
        Dim LowerTotal = 0
        Dim NumberTotal = 0
        Dim SymbolTotal = 0
        Dim passwordTotalLength = Val(passwordLength.Text)
        Dim stringSpec = "!@#$%*"
        Dim stringUpp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim stringLow = "abcdefghijklmnopqrstuvwxyz"
        Dim stringNum = "0123456789"
        Dim stringAll = ""


        If selectUpperCase.Checked = True Then stringAll = stringAll + stringUpp
        If selectLowerCase.Checked = True Then stringAll = stringAll + stringLow
        If selectNumbers.Checked = True Then stringAll = stringAll + stringNum
        If selectSpecialChar.Checked = True Then stringAll = stringAll + stringSpec

        Randomize()

        'if upper case character is needed
        If selectUpperCase.Checked = True Then
            strResult = strResult + Mid(stringUpp, Int(Rnd() * Len(stringUpp)) + 1, 1)
            UpperTotal = 1
        Else
            passwordTotalLength = passwordTotalLength + 1
        End If

        'if lower case character is needed
        If selectLowerCase.Checked = True Then
            strResult = strResult + Mid(stringLow, Int(Rnd() * Len(stringLow)) + 1, 1)
            LowerTotal = 1
        Else
            passwordTotalLength = passwordTotalLength + 1
        End If

        'if number character is needed
        If selectNumbers.Checked = True Then
            strResult = strResult + Mid(stringNum, Int(Rnd() * Len(stringNum)) + 1, 1)
            NumberTotal = 1
        Else
            passwordTotalLength = passwordTotalLength + 1
        End If

        'make sure we have a special character in the password
        If selectSpecialChar.Checked = True Then
            strResult = strResult + Mid(stringSpec, Int(Rnd() * Len(stringSpec)) + 1, 1)
            SymbolTotal = 1
        Else
            passwordTotalLength = passwordTotalLength + 1
        End If

        'get the remainging characters needed for the password
        For c = 1 To passwordTotalLength - 4
            newaddition = Mid(stringAll, Int(Rnd() * Len(stringAll)) + 1, 1)
            strResult = strResult + newaddition
            teststring = Strings.Left(strResult, Len(strResult) - 1)

            'make sure the character does not repeat
            If selectRequireUniqueChar.Checked = True Then
                If InStr(teststring, Strings.Right(strResult, 1)) = 0 Then
                    If InStr(stringUpp, newaddition) > 0 Then ' uppercase
                        If UpperTotal = Val(MaxUpper.Text) Then ' we are at the limit
                            strResult = Strings.Left(strResult, Len(strResult) - 1)
                            c = c - 1
                        Else
                            UpperTotal = UpperTotal + 1
                        End If
                    End If

                    If InStr(stringLow, newaddition) > 0 Then ' lowercase
                        If LowerTotal = Val(MaxLower.Text) Then ' we are at the limit
                            strResult = Strings.Left(strResult, Len(strResult) - 1)
                            c = c - 1
                        Else
                            LowerTotal = LowerTotal + 1
                        End If
                    End If

                    If InStr(stringNum, newaddition) > 0 Then ' number
                        If NumberTotal = Val(MaxNumbers.Text) Then ' we are at the limit
                            strResult = Strings.Left(strResult, Len(strResult) - 1)
                            c = c - 1
                        Else
                            NumberTotal = NumberTotal + 1
                        End If
                    End If

                    If InStr(stringSpec, newaddition) > 0 Then ' number
                        If SymbolTotal = Val(MaxSymbols.Text) Then ' we are at the limit
                            strResult = Strings.Left(strResult, Len(strResult) - 1)
                            c = c - 1
                        Else
                            SymbolTotal = SymbolTotal + 1
                        End If
                    End If
                Else
                    strResult = Strings.Left(strResult, Len(strResult) - 1)
                    c = c - 1
                End If
            Else
                If InStr(stringUpp, newaddition) > 0 Then ' uppercase
                    If UpperTotal = Val(MaxUpper.Text) Then ' we are at the limit
                        strResult = Strings.Left(strResult, Len(strResult) - 1)
                        c = c - 1
                    Else
                        UpperTotal = UpperTotal + 1
                    End If
                End If

                If InStr(stringLow, newaddition) > 0 Then ' lowercase
                    If LowerTotal = Val(MaxLower.Text) Then ' we are at the limit
                        strResult = Strings.Left(strResult, Len(strResult) - 1)
                        c = c - 1
                    Else
                        LowerTotal = LowerTotal + 1
                    End If
                End If

                If InStr(stringNum, newaddition) > 0 Then ' number
                    If NumberTotal = Val(MaxNumbers.Text) Then ' we are at the limit
                        strResult = Strings.Left(strResult, Len(strResult) - 1)
                        c = c - 1
                    Else
                        NumberTotal = NumberTotal + 1
                    End If
                End If

                If InStr(stringSpec, newaddition) > 0 Then ' number
                    If SymbolTotal = Val(MaxSymbols.Text) Then ' we are at the limit
                        strResult = Strings.Left(strResult, Len(strResult) - 1)
                        c = c - 1
                    Else
                        SymbolTotal = SymbolTotal + 1
                    End If
                End If
            End If

        Next c

        tempPassword.Text = strResult

    End Sub

    Private Sub MaxSymbols_TextChanged(sender As Object, e As EventArgs) Handles MaxSymbols.TextChanged
        If selectRequireUniqueChar.Checked = True Then
            If Val(MaxSymbols.Text) > 6 Then
                MaxSymbols.Text = "6"
                MsgBox("Max Symbols allowed if duplicate characters are not allowed is 6.")
            End If
        End If
    End Sub

    Private Sub MaxNumbers_TextChanged(sender As Object, e As EventArgs) Handles MaxNumbers.TextChanged
        If selectRequireUniqueChar.Checked = True Then
            If Val(MaxNumbers.Text) > 10 Then
                MaxNumbers.Text = "10"
                MsgBox("Max Numbers allowed if duplicate characters are not allowed is 10.")
            End If
        End If
    End Sub

    Private Sub MaxUpper_TextChanged(sender As Object, e As EventArgs) Handles MaxUpper.TextChanged
        If selectRequireUniqueChar.Checked = True Then
            If Val(MaxUpper.Text) > 26 Then
                MaxUpper.Text = "26"
                MsgBox("Max Upper case characters allowed if duplicate characters are not allowed is 26.")
            End If
        End If
    End Sub

    Private Sub MaxLower_TextChanged(sender As Object, e As EventArgs) Handles MaxLower.TextChanged
        If selectRequireUniqueChar.Checked = True Then
            If Val(MaxLower.Text) > 26 Then
                MaxLower.Text = "26"
                MsgBox("Max Lower case characters allowed if duplicate characters are not allowed is 26.")
            End If
        End If
    End Sub

    Private Sub selectUpperCase_CheckedChanged(sender As Object, e As EventArgs) Handles selectUpperCase.CheckedChanged
        If selectUpperCase.Checked = False Then
            MaxUpper.Text = "0"
            MaxUpper.ReadOnly = True
        ElseIf selectUpperCase.Checked = True Then
            MaxUpper.Text = Val(passwordLength.Text) - Val(MaxSymbols.Text) - Val(MaxLower.Text) - Val(MaxNumbers.Text)
            MaxUpper.ReadOnly = False
        End If

        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
            Select Case passwordLength.Text
                Case 8
                    MaxUpper.Text = "3"
                    MaxLower.Text = "2"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case 10
                    MaxUpper.Text = "4"
                    MaxLower.Text = "3"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case 12
                    MaxUpper.Text = "5"
                    MaxLower.Text = "4"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case Else
                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                    MaxSymbols.Text = "1"
                    If Val(passwordLength.Text) = 4 Then
                        MaxNumbers.Text = "1"
                    ElseIf Val(passwordLength.Text) = 5 Then
                        MaxNumbers.Text = "1"
                    Else
                        MaxNumbers.Text = "2"
                    End If
                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                        MaxLower.Text = "0"
                    Else
                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                    End If
            End Select
        Else
            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
            And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                Select Case passwordLength.Text
                    Case 8
                        MaxUpper.Text = "0"
                        MaxLower.Text = "5"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case 10
                        MaxUpper.Text = "0"
                        MaxLower.Text = "5"
                        MaxNumbers.Text = "4"
                        MaxSymbols.Text = "1"
                    Case 12
                        MaxUpper.Text = "0"
                        MaxLower.Text = "6"
                        MaxNumbers.Text = "4"
                        MaxSymbols.Text = "2"
                    Case Else
                        MaxUpper.Text = "0"
                        MaxSymbols.Text = "1"
                        If Val(passwordLength.Text) = 4 Then
                            MaxNumbers.Text = "1"
                        ElseIf Val(passwordLength.Text) = 5 Then
                            MaxNumbers.Text = "1"
                        Else
                            MaxNumbers.Text = "2"
                        End If
                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                            MaxLower.Text = "0"
                        Else
                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                        End If

                End Select
            Else
                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                    Select Case passwordLength.Text
                        Case 8
                            MaxUpper.Text = "5"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "2"
                            MaxSymbols.Text = "1"
                        Case 10
                            MaxUpper.Text = "5"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "1"
                        Case 12
                            MaxUpper.Text = "6"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "2"
                        Case Else
                            MaxLower.Text = "0"
                            MaxSymbols.Text = "1"
                            If Val(passwordLength.Text) = 4 Then
                                MaxNumbers.Text = "1"
                            ElseIf Val(passwordLength.Text) = 5 Then
                                MaxNumbers.Text = "1"
                            Else
                                MaxNumbers.Text = "2"
                            End If
                            If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                MaxUpper.Text = "0"
                            Else
                                MaxUpper.Text = Val(passwordLength.Text) - Val(MaxLower.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                            End If
                    End Select
                Else
                    If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                        And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                        Select Case passwordLength.Text
                            Case 8
                                MaxUpper.Text = "5"
                                MaxLower.Text = "2"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "1"
                            Case 10
                                MaxUpper.Text = "5"
                                MaxLower.Text = "4"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "1"
                            Case 12
                                MaxUpper.Text = "6"
                                MaxLower.Text = "4"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "2"
                            Case Else
                                MaxNumbers.Text = "0"
                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                MaxSymbols.Text = "1"
                                If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                    MaxLower.Text = "0"
                                Else
                                    MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                End If
                        End Select
                    Else
                        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                            Select Case passwordLength.Text
                                Case 8
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "2"
                                    MaxNumbers.Text = "1"
                                    MaxSymbols.Text = "0"
                                Case 10
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "1"
                                    MaxSymbols.Text = "0"
                                Case 12
                                    MaxUpper.Text = "6"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "2"
                                    MaxSymbols.Text = "0"
                                Case Else
                                    MaxSymbols.Text = "0"
                                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                    If Val(passwordLength.Text) = 4 Then
                                        MaxNumbers.Text = "1"
                                    ElseIf Val(passwordLength.Text) = 5 Then
                                        MaxNumbers.Text = "1"
                                    Else
                                        MaxNumbers.Text = "2"
                                    End If
                                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                        MaxLower.Text = "0"
                                    Else
                                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                    End If
                            End Select
                        Else
                            If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                                And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                Select Case passwordLength.Text
                                    Case 8
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "3"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case 10
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "5"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case 12
                                        MaxUpper.Text = "6"
                                        MaxLower.Text = "6"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case Else
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                        MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                            MaxLower.Text = "0"
                                        Else
                                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                        End If
                                End Select
                            Else
                                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                    Select Case passwordLength.Text
                                        Case 8
                                            MaxUpper.Text = "8"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 10
                                            MaxUpper.Text = "10"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 12
                                            MaxUpper.Text = "12"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case Else
                                            MaxUpper.Text = Val(passwordLength.Text)
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                    End Select
                                Else
                                    If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                                        Select Case passwordLength.Text
                                            Case 8
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "4"
                                                MaxSymbols.Text = "4"
                                            Case 10
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "5"
                                                MaxSymbols.Text = "5"
                                            Case 12
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "6"
                                                MaxSymbols.Text = "6"
                                            Case Else
                                                Val(passwordLength.Text)
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                        End Select
                                    Else
                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                            Select Case passwordLength.Text
                                                Case 8
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "8"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                                Case 10
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "10"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = ""
                                                Case 12
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "12"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                                Case Else
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = Val(passwordLength.Text)
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                            End Select
                                        Else
                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                Select Case passwordLength.Text
                                                    Case 8
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "8"
                                                        MaxSymbols.Text = "0"
                                                    Case 10
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "10"
                                                        MaxSymbols.Text = "0"
                                                    Case 12
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "12"
                                                        MaxSymbols.Text = "0"
                                                    Case Else
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = Val(passwordLength.Text)
                                                        MaxSymbols.Text = "0"

                                                End Select
                                            Else
                                                If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                    Select Case passwordLength.Text
                                                        Case 8
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "8"
                                                        Case 10
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "10"
                                                        Case 12
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "12"
                                                        Case Else
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = Val(passwordLength.Text)

                                                    End Select
                                                Else
                                                    If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                        Select Case passwordLength.Text
                                                            Case 8
                                                                MaxUpper.Text = "6"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "2"
                                                                MaxSymbols.Text = "0"
                                                            Case 10
                                                                MaxUpper.Text = "6"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "4"
                                                                MaxSymbols.Text = "0"
                                                            Case 12
                                                                MaxUpper.Text = "8"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "4"
                                                                MaxSymbols.Text = "0"
                                                            Case Else
                                                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                MaxSymbols.Text = "0"

                                                        End Select
                                                    Else
                                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                            Select Case passwordLength.Text
                                                                Case 8
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "6"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "2"
                                                                Case 10
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "6"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "4"
                                                                Case 12
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "8"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "4"
                                                                Case Else
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                                            End Select
                                                        Else
                                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                                Select Case passwordLength.Text
                                                                    Case 8
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "2"
                                                                        MaxSymbols.Text = "0"
                                                                    Case 10
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "4"
                                                                        MaxSymbols.Text = "0"
                                                                    Case 12
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "8"
                                                                        MaxNumbers.Text = "4"
                                                                        MaxSymbols.Text = "0"
                                                                    Case Else
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                        MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                        MaxSymbols.Text = "0"
                                                                End Select
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub selectLowerCase_CheckedChanged(sender As Object, e As EventArgs) Handles selectLowerCase.CheckedChanged
        If selectLowerCase.Checked = False Then
            MaxLower.Text = "0"
            MaxLower.ReadOnly = True
        ElseIf selectLowerCase.Checked = True Then
            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxSymbols.Text) - Val(MaxNumbers.Text)
            MaxLower.ReadOnly = False
        End If

        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
            Select Case passwordLength.Text
                Case 8
                    MaxUpper.Text = "3"
                    MaxLower.Text = "2"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case 10
                    MaxUpper.Text = "4"
                    MaxLower.Text = "3"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case 12
                    MaxUpper.Text = "5"
                    MaxLower.Text = "4"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case Else
                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                    MaxSymbols.Text = "1"
                    If Val(passwordLength.Text) = 4 Then
                        MaxNumbers.Text = "1"
                    ElseIf Val(passwordLength.Text) = 5 Then
                        MaxNumbers.Text = "1"
                    Else
                        MaxNumbers.Text = "2"
                    End If
                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                        MaxLower.Text = "0"
                    Else
                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                    End If
            End Select
        Else
            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
            And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                Select Case passwordLength.Text
                    Case 8
                        MaxUpper.Text = "0"
                        MaxLower.Text = "5"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case 10
                        MaxUpper.Text = "0"
                        MaxLower.Text = "5"
                        MaxNumbers.Text = "4"
                        MaxSymbols.Text = "1"
                    Case 12
                        MaxUpper.Text = "0"
                        MaxLower.Text = "6"
                        MaxNumbers.Text = "4"
                        MaxSymbols.Text = "2"
                    Case Else
                        MaxUpper.Text = "0"
                        MaxSymbols.Text = "1"
                        If Val(passwordLength.Text) = 4 Then
                            MaxNumbers.Text = "1"
                        ElseIf Val(passwordLength.Text) = 5 Then
                            MaxNumbers.Text = "1"
                        Else
                            MaxNumbers.Text = "2"
                        End If
                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                            MaxLower.Text = "0"
                        Else
                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                        End If

                End Select
            Else
                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                    Select Case passwordLength.Text
                        Case 8
                            MaxUpper.Text = "5"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "2"
                            MaxSymbols.Text = "1"
                        Case 10
                            MaxUpper.Text = "5"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "1"
                        Case 12
                            MaxUpper.Text = "6"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "2"
                        Case Else
                            MaxLower.Text = "0"
                            MaxSymbols.Text = "1"
                            If Val(passwordLength.Text) = 4 Then
                                MaxNumbers.Text = "1"
                            ElseIf Val(passwordLength.Text) = 5 Then
                                MaxNumbers.Text = "1"
                            Else
                                MaxNumbers.Text = "2"
                            End If
                            If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                MaxUpper.Text = "0"
                            Else
                                MaxUpper.Text = Val(passwordLength.Text) - Val(MaxLower.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                            End If
                    End Select
                Else
                    If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                        And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                        Select Case passwordLength.Text
                            Case 8
                                MaxUpper.Text = "5"
                                MaxLower.Text = "2"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "1"
                            Case 10
                                MaxUpper.Text = "5"
                                MaxLower.Text = "4"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "1"
                            Case 12
                                MaxUpper.Text = "6"
                                MaxLower.Text = "4"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "2"
                            Case Else
                                MaxNumbers.Text = "0"
                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                MaxSymbols.Text = "1"
                                If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                    MaxLower.Text = "0"
                                Else
                                    MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                End If
                        End Select
                    Else
                        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                            Select Case passwordLength.Text
                                Case 8
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "2"
                                    MaxNumbers.Text = "1"
                                    MaxSymbols.Text = "0"
                                Case 10
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "1"
                                    MaxSymbols.Text = "0"
                                Case 12
                                    MaxUpper.Text = "6"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "2"
                                    MaxSymbols.Text = "0"
                                Case Else
                                    MaxSymbols.Text = "0"
                                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                    If Val(passwordLength.Text) = 4 Then
                                        MaxNumbers.Text = "1"
                                    ElseIf Val(passwordLength.Text) = 5 Then
                                        MaxNumbers.Text = "1"
                                    Else
                                        MaxNumbers.Text = "2"
                                    End If
                                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                        MaxLower.Text = "0"
                                    Else
                                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                    End If
                            End Select
                        Else
                            If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                                And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                Select Case passwordLength.Text
                                    Case 8
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "3"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case 10
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "5"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case 12
                                        MaxUpper.Text = "6"
                                        MaxLower.Text = "6"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case Else
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                        MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                            MaxLower.Text = "0"
                                        Else
                                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                        End If
                                End Select
                            Else
                                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                    Select Case passwordLength.Text
                                        Case 8
                                            MaxUpper.Text = "8"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 10
                                            MaxUpper.Text = "10"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 12
                                            MaxUpper.Text = "12"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case Else
                                            MaxUpper.Text = Val(passwordLength.Text)
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                    End Select
                                Else
                                    If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                                        Select Case passwordLength.Text
                                            Case 8
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "4"
                                                MaxSymbols.Text = "4"
                                            Case 10
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "5"
                                                MaxSymbols.Text = "5"
                                            Case 12
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "6"
                                                MaxSymbols.Text = "6"
                                            Case Else
                                                Val(passwordLength.Text)
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                        End Select
                                    Else
                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                            Select Case passwordLength.Text
                                                Case 8
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "8"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                                Case 10
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "10"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = ""
                                                Case 12
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "12"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                                Case Else
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = Val(passwordLength.Text)
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                            End Select
                                        Else
                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                Select Case passwordLength.Text
                                                    Case 8
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "8"
                                                        MaxSymbols.Text = "0"
                                                    Case 10
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "10"
                                                        MaxSymbols.Text = "0"
                                                    Case 12
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "12"
                                                        MaxSymbols.Text = "0"
                                                    Case Else
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = Val(passwordLength.Text)
                                                        MaxSymbols.Text = "0"

                                                End Select
                                            Else
                                                If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                    Select Case passwordLength.Text
                                                        Case 8
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "8"
                                                        Case 10
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "10"
                                                        Case 12
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "12"
                                                        Case Else
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = Val(passwordLength.Text)

                                                    End Select
                                                Else
                                                    If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                        Select Case passwordLength.Text
                                                            Case 8
                                                                MaxUpper.Text = "6"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "2"
                                                                MaxSymbols.Text = "0"
                                                            Case 10
                                                                MaxUpper.Text = "6"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "4"
                                                                MaxSymbols.Text = "0"
                                                            Case 12
                                                                MaxUpper.Text = "8"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "4"
                                                                MaxSymbols.Text = "0"
                                                            Case Else
                                                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                MaxSymbols.Text = "0"

                                                        End Select
                                                    Else
                                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                            Select Case passwordLength.Text
                                                                Case 8
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "6"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "2"
                                                                Case 10
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "6"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "4"
                                                                Case 12
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "8"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "4"
                                                                Case Else
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                                            End Select
                                                        Else
                                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                                Select Case passwordLength.Text
                                                                    Case 8
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "2"
                                                                        MaxSymbols.Text = "0"
                                                                    Case 10
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "4"
                                                                        MaxSymbols.Text = "0"
                                                                    Case 12
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "8"
                                                                        MaxNumbers.Text = "4"
                                                                        MaxSymbols.Text = "0"
                                                                    Case Else
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                        MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                        MaxSymbols.Text = "0"
                                                                End Select
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub selectNumbers_CheckedChanged(sender As Object, e As EventArgs) Handles selectNumbers.CheckedChanged
        If selectNumbers.Checked = False Then
            MaxNumbers.Text = "0"
            MaxNumbers.ReadOnly = True
        ElseIf selectNumbers.Checked = True Then
            MaxNumbers.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxLower.Text) - Val(MaxSymbols.Text)
            MaxNumbers.ReadOnly = False
        End If

        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
            Select Case passwordLength.Text
                Case 8
                    MaxUpper.Text = "3"
                    MaxLower.Text = "2"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case 10
                    MaxUpper.Text = "4"
                    MaxLower.Text = "3"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case 12
                    MaxUpper.Text = "5"
                    MaxLower.Text = "4"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case Else
                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                    MaxSymbols.Text = "1"
                    If Val(passwordLength.Text) = 4 Then
                        MaxNumbers.Text = "1"
                    ElseIf Val(passwordLength.Text) = 5 Then
                        MaxNumbers.Text = "1"
                    Else
                        MaxNumbers.Text = "2"
                    End If
                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                        MaxLower.Text = "0"
                    Else
                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                    End If
            End Select
        Else
            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
            And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                Select Case passwordLength.Text
                    Case 8
                        MaxUpper.Text = "0"
                        MaxLower.Text = "5"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case 10
                        MaxUpper.Text = "0"
                        MaxLower.Text = "5"
                        MaxNumbers.Text = "4"
                        MaxSymbols.Text = "1"
                    Case 12
                        MaxUpper.Text = "0"
                        MaxLower.Text = "6"
                        MaxNumbers.Text = "4"
                        MaxSymbols.Text = "2"
                    Case Else
                        MaxUpper.Text = "0"
                        MaxSymbols.Text = "1"
                        If Val(passwordLength.Text) = 4 Then
                            MaxNumbers.Text = "1"
                        ElseIf Val(passwordLength.Text) = 5 Then
                            MaxNumbers.Text = "1"
                        Else
                            MaxNumbers.Text = "2"
                        End If
                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                            MaxLower.Text = "0"
                        Else
                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                        End If

                End Select
            Else
                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                    Select Case passwordLength.Text
                        Case 8
                            MaxUpper.Text = "5"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "2"
                            MaxSymbols.Text = "1"
                        Case 10
                            MaxUpper.Text = "5"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "1"
                        Case 12
                            MaxUpper.Text = "6"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "2"
                        Case Else
                            MaxLower.Text = "0"
                            MaxSymbols.Text = "1"
                            If Val(passwordLength.Text) = 4 Then
                                MaxNumbers.Text = "1"
                            ElseIf Val(passwordLength.Text) = 5 Then
                                MaxNumbers.Text = "1"
                            Else
                                MaxNumbers.Text = "2"
                            End If
                            If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                MaxUpper.Text = "0"
                            Else
                                MaxUpper.Text = Val(passwordLength.Text) - Val(MaxLower.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                            End If
                    End Select
                Else
                    If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                        And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                        Select Case passwordLength.Text
                            Case 8
                                MaxUpper.Text = "5"
                                MaxLower.Text = "2"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "1"
                            Case 10
                                MaxUpper.Text = "5"
                                MaxLower.Text = "4"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "1"
                            Case 12
                                MaxUpper.Text = "6"
                                MaxLower.Text = "4"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "2"
                            Case Else
                                MaxNumbers.Text = "0"
                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                MaxSymbols.Text = "1"
                                If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                    MaxLower.Text = "0"
                                Else
                                    MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                End If
                        End Select
                    Else
                        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                            Select Case passwordLength.Text
                                Case 8
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "2"
                                    MaxNumbers.Text = "1"
                                    MaxSymbols.Text = "0"
                                Case 10
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "1"
                                    MaxSymbols.Text = "0"
                                Case 12
                                    MaxUpper.Text = "6"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "2"
                                    MaxSymbols.Text = "0"
                                Case Else
                                    MaxSymbols.Text = "0"
                                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                    If Val(passwordLength.Text) = 4 Then
                                        MaxNumbers.Text = "1"
                                    ElseIf Val(passwordLength.Text) = 5 Then
                                        MaxNumbers.Text = "1"
                                    Else
                                        MaxNumbers.Text = "2"
                                    End If
                                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                        MaxLower.Text = "0"
                                    Else
                                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                    End If
                            End Select
                        Else
                            If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                                And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                Select Case passwordLength.Text
                                    Case 8
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "3"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case 10
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "5"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case 12
                                        MaxUpper.Text = "6"
                                        MaxLower.Text = "6"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case Else
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                        MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                            MaxLower.Text = "0"
                                        Else
                                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                        End If
                                End Select
                            Else
                                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                    Select Case passwordLength.Text
                                        Case 8
                                            MaxUpper.Text = "8"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 10
                                            MaxUpper.Text = "10"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 12
                                            MaxUpper.Text = "12"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case Else
                                            MaxUpper.Text = Val(passwordLength.Text)
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                    End Select
                                Else
                                    If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                                        Select Case passwordLength.Text
                                            Case 8
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "4"
                                                MaxSymbols.Text = "4"
                                            Case 10
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "5"
                                                MaxSymbols.Text = "5"
                                            Case 12
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "6"
                                                MaxSymbols.Text = "6"
                                            Case Else
                                                Val(passwordLength.Text)
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                        End Select
                                    Else
                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                            Select Case passwordLength.Text
                                                Case 8
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "8"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                                Case 10
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "10"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = ""
                                                Case 12
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "12"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                                Case Else
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = Val(passwordLength.Text)
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                            End Select
                                        Else
                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                Select Case passwordLength.Text
                                                    Case 8
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "8"
                                                        MaxSymbols.Text = "0"
                                                    Case 10
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "10"
                                                        MaxSymbols.Text = "0"
                                                    Case 12
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "12"
                                                        MaxSymbols.Text = "0"
                                                    Case Else
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = Val(passwordLength.Text)
                                                        MaxSymbols.Text = "0"

                                                End Select
                                            Else
                                                If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                    Select Case passwordLength.Text
                                                        Case 8
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "8"
                                                        Case 10
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "10"
                                                        Case 12
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "12"
                                                        Case Else
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = Val(passwordLength.Text)

                                                    End Select
                                                Else
                                                    If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                        Select Case passwordLength.Text
                                                            Case 8
                                                                MaxUpper.Text = "6"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "2"
                                                                MaxSymbols.Text = "0"
                                                            Case 10
                                                                MaxUpper.Text = "6"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "4"
                                                                MaxSymbols.Text = "0"
                                                            Case 12
                                                                MaxUpper.Text = "8"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "4"
                                                                MaxSymbols.Text = "0"
                                                            Case Else
                                                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                MaxSymbols.Text = "0"

                                                        End Select
                                                    Else
                                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                            Select Case passwordLength.Text
                                                                Case 8
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "6"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "2"
                                                                Case 10
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "6"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "4"
                                                                Case 12
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "8"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "4"
                                                                Case Else
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                                            End Select
                                                        Else
                                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                                Select Case passwordLength.Text
                                                                    Case 8
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "2"
                                                                        MaxSymbols.Text = "0"
                                                                    Case 10
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "4"
                                                                        MaxSymbols.Text = "0"
                                                                    Case 12
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "8"
                                                                        MaxNumbers.Text = "4"
                                                                        MaxSymbols.Text = "0"
                                                                    Case Else
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                        MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                        MaxSymbols.Text = "0"
                                                                End Select
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub selectSpecialChar_CheckedChanged(sender As Object, e As EventArgs) Handles selectSpecialChar.CheckedChanged
        If selectSpecialChar.Checked = False Then
            MaxSymbols.Text = "0"
            MaxSymbols.ReadOnly = True
        ElseIf selectSpecialChar.Checked = True Then
            MaxSymbols.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxLower.Text) - Val(MaxNumbers.Text)
            MaxSymbols.ReadOnly = False
        End If

        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
            Select Case passwordLength.Text
                Case 8
                    MaxUpper.Text = "3"
                    MaxLower.Text = "2"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case 10
                    MaxUpper.Text = "4"
                    MaxLower.Text = "3"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case 12
                    MaxUpper.Text = "5"
                    MaxLower.Text = "4"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case Else
                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                    MaxSymbols.Text = "1"
                    If Val(passwordLength.Text) = 4 Then
                        MaxNumbers.Text = "1"
                    ElseIf Val(passwordLength.Text) = 5 Then
                        MaxNumbers.Text = "1"
                    Else
                        MaxNumbers.Text = "2"
                    End If
                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                        MaxLower.Text = "0"
                    Else
                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                    End If
            End Select
        Else
            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
            And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                Select Case passwordLength.Text
                    Case 8
                        MaxUpper.Text = "0"
                        MaxLower.Text = "5"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case 10
                        MaxUpper.Text = "0"
                        MaxLower.Text = "5"
                        MaxNumbers.Text = "4"
                        MaxSymbols.Text = "1"
                    Case 12
                        MaxUpper.Text = "0"
                        MaxLower.Text = "6"
                        MaxNumbers.Text = "4"
                        MaxSymbols.Text = "2"
                    Case Else
                        MaxUpper.Text = "0"
                        MaxSymbols.Text = "1"
                        If Val(passwordLength.Text) = 4 Then
                            MaxNumbers.Text = "1"
                        ElseIf Val(passwordLength.Text) = 5 Then
                            MaxNumbers.Text = "1"
                        Else
                            MaxNumbers.Text = "2"
                        End If
                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                            MaxLower.Text = "0"
                        Else
                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                        End If

                End Select
            Else
                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                    Select Case passwordLength.Text
                        Case 8
                            MaxUpper.Text = "5"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "2"
                            MaxSymbols.Text = "1"
                        Case 10
                            MaxUpper.Text = "5"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "1"
                        Case 12
                            MaxUpper.Text = "6"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "2"
                        Case Else
                            MaxLower.Text = "0"
                            MaxSymbols.Text = "1"
                            If Val(passwordLength.Text) = 4 Then
                                MaxNumbers.Text = "1"
                            ElseIf Val(passwordLength.Text) = 5 Then
                                MaxNumbers.Text = "1"
                            Else
                                MaxNumbers.Text = "2"
                            End If
                            If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                MaxUpper.Text = "0"
                            Else
                                MaxUpper.Text = Val(passwordLength.Text) - Val(MaxLower.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                            End If
                    End Select
                Else
                    If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                        And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                        Select Case passwordLength.Text
                            Case 8
                                MaxUpper.Text = "5"
                                MaxLower.Text = "2"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "1"
                            Case 10
                                MaxUpper.Text = "5"
                                MaxLower.Text = "4"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "1"
                            Case 12
                                MaxUpper.Text = "6"
                                MaxLower.Text = "4"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "2"
                            Case Else
                                MaxNumbers.Text = "0"
                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                MaxSymbols.Text = "1"
                                If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                    MaxLower.Text = "0"
                                Else
                                    MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                End If
                        End Select
                    Else
                        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                            Select Case passwordLength.Text
                                Case 8
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "2"
                                    MaxNumbers.Text = "1"
                                    MaxSymbols.Text = "0"
                                Case 10
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "1"
                                    MaxSymbols.Text = "0"
                                Case 12
                                    MaxUpper.Text = "6"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "2"
                                    MaxSymbols.Text = "0"
                                Case Else
                                    MaxSymbols.Text = "0"
                                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                    If Val(passwordLength.Text) = 4 Then
                                        MaxNumbers.Text = "1"
                                    ElseIf Val(passwordLength.Text) = 5 Then
                                        MaxNumbers.Text = "1"
                                    Else
                                        MaxNumbers.Text = "2"
                                    End If
                                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                        MaxLower.Text = "0"
                                    Else
                                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                    End If
                            End Select
                        Else
                            If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                                And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                Select Case passwordLength.Text
                                    Case 8
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "3"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case 10
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "5"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case 12
                                        MaxUpper.Text = "6"
                                        MaxLower.Text = "6"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case Else
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                        MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                            MaxLower.Text = "0"
                                        Else
                                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                        End If
                                End Select
                            Else
                                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                    Select Case passwordLength.Text
                                        Case 8
                                            MaxUpper.Text = "8"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 10
                                            MaxUpper.Text = "10"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 12
                                            MaxUpper.Text = "12"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case Else
                                            MaxUpper.Text = Val(passwordLength.Text)
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                    End Select
                                Else
                                    If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                                        Select Case passwordLength.Text
                                            Case 8
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "4"
                                                MaxSymbols.Text = "4"
                                            Case 10
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "5"
                                                MaxSymbols.Text = "5"
                                            Case 12
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "6"
                                                MaxSymbols.Text = "6"
                                            Case Else
                                                Val(passwordLength.Text)
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                        End Select
                                    Else
                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                            Select Case passwordLength.Text
                                                Case 8
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "8"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                                Case 10
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "10"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = ""
                                                Case 12
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "12"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                                Case Else
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = Val(passwordLength.Text)
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                            End Select
                                        Else
                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                Select Case passwordLength.Text
                                                    Case 8
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "8"
                                                        MaxSymbols.Text = "0"
                                                    Case 10
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "10"
                                                        MaxSymbols.Text = "0"
                                                    Case 12
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "12"
                                                        MaxSymbols.Text = "0"
                                                    Case Else
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = Val(passwordLength.Text)
                                                        MaxSymbols.Text = "0"

                                                End Select
                                            Else
                                                If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                    Select Case passwordLength.Text
                                                        Case 8
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "8"
                                                        Case 10
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "10"
                                                        Case 12
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "12"
                                                        Case Else
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = Val(passwordLength.Text)

                                                    End Select
                                                Else
                                                    If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                        Select Case passwordLength.Text
                                                            Case 8
                                                                MaxUpper.Text = "6"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "2"
                                                                MaxSymbols.Text = "0"
                                                            Case 10
                                                                MaxUpper.Text = "6"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "4"
                                                                MaxSymbols.Text = "0"
                                                            Case 12
                                                                MaxUpper.Text = "8"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "4"
                                                                MaxSymbols.Text = "0"
                                                            Case Else
                                                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                MaxSymbols.Text = "0"

                                                        End Select
                                                    Else
                                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                            Select Case passwordLength.Text
                                                                Case 8
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "6"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "2"
                                                                Case 10
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "6"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "4"
                                                                Case 12
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "8"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "4"
                                                                Case Else
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                                            End Select
                                                        Else
                                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                                Select Case passwordLength.Text
                                                                    Case 8
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "2"
                                                                        MaxSymbols.Text = "0"
                                                                    Case 10
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "4"
                                                                        MaxSymbols.Text = "0"
                                                                    Case 12
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "8"
                                                                        MaxNumbers.Text = "4"
                                                                        MaxSymbols.Text = "0"
                                                                    Case Else
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                        MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                        MaxSymbols.Text = "0"
                                                                End Select
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub passwordLength_TextChanged(sender As Object, e As EventArgs) Handles passwordLength.TextChanged
        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
            Select Case passwordLength.Text
                Case 8
                    MaxUpper.Text = "3"
                    MaxLower.Text = "2"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case 10
                    MaxUpper.Text = "4"
                    MaxLower.Text = "3"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case 12
                    MaxUpper.Text = "5"
                    MaxLower.Text = "4"
                    MaxNumbers.Text = "2"
                    MaxSymbols.Text = "1"
                Case Else
                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                    MaxSymbols.Text = "1"
                    If Val(passwordLength.Text) = 4 Then
                        MaxNumbers.Text = "1"
                    ElseIf Val(passwordLength.Text) = 5 Then
                        MaxNumbers.Text = "1"
                    Else
                        MaxNumbers.Text = "2"
                    End If
                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                        MaxLower.Text = "0"
                    Else
                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                    End If
            End Select
        Else
            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
            And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                Select Case passwordLength.Text
                    Case 8
                        MaxUpper.Text = "0"
                        MaxLower.Text = "5"
                        MaxNumbers.Text = "2"
                        MaxSymbols.Text = "1"
                    Case 10
                        MaxUpper.Text = "0"
                        MaxLower.Text = "5"
                        MaxNumbers.Text = "4"
                        MaxSymbols.Text = "1"
                    Case 12
                        MaxUpper.Text = "0"
                        MaxLower.Text = "6"
                        MaxNumbers.Text = "4"
                        MaxSymbols.Text = "2"
                    Case Else
                        MaxUpper.Text = "0"
                        MaxSymbols.Text = "1"
                        If Val(passwordLength.Text) = 4 Then
                            MaxNumbers.Text = "1"
                        ElseIf Val(passwordLength.Text) = 5 Then
                            MaxNumbers.Text = "1"
                        Else
                            MaxNumbers.Text = "2"
                        End If
                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                            MaxLower.Text = "0"
                        Else
                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                        End If

                End Select
            Else
                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                    And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                    Select Case passwordLength.Text
                        Case 8
                            MaxUpper.Text = "5"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "2"
                            MaxSymbols.Text = "1"
                        Case 10
                            MaxUpper.Text = "5"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "1"
                        Case 12
                            MaxUpper.Text = "6"
                            MaxLower.Text = "0"
                            MaxNumbers.Text = "4"
                            MaxSymbols.Text = "2"
                        Case Else
                            MaxLower.Text = "0"
                            MaxSymbols.Text = "1"
                            If Val(passwordLength.Text) = 4 Then
                                MaxNumbers.Text = "1"
                            ElseIf Val(passwordLength.Text) = 5 Then
                                MaxNumbers.Text = "1"
                            Else
                                MaxNumbers.Text = "2"
                            End If
                            If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                MaxUpper.Text = "0"
                            Else
                                MaxUpper.Text = Val(passwordLength.Text) - Val(MaxLower.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                            End If
                    End Select
                Else
                    If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                        And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                        Select Case passwordLength.Text
                            Case 8
                                MaxUpper.Text = "5"
                                MaxLower.Text = "2"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "1"
                            Case 10
                                MaxUpper.Text = "5"
                                MaxLower.Text = "4"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "1"
                            Case 12
                                MaxUpper.Text = "6"
                                MaxLower.Text = "4"
                                MaxNumbers.Text = "0"
                                MaxSymbols.Text = "2"
                            Case Else
                                MaxNumbers.Text = "0"
                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                MaxSymbols.Text = "1"
                                If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                    MaxLower.Text = "0"
                                Else
                                    MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                End If
                        End Select
                    Else
                        If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                            Select Case passwordLength.Text
                                Case 8
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "2"
                                    MaxNumbers.Text = "1"
                                    MaxSymbols.Text = "0"
                                Case 10
                                    MaxUpper.Text = "5"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "1"
                                    MaxSymbols.Text = "0"
                                Case 12
                                    MaxUpper.Text = "6"
                                    MaxLower.Text = "4"
                                    MaxNumbers.Text = "2"
                                    MaxSymbols.Text = "0"
                                Case Else
                                    MaxSymbols.Text = "0"
                                    MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                    If Val(passwordLength.Text) = 4 Then
                                        MaxNumbers.Text = "1"
                                    ElseIf Val(passwordLength.Text) = 5 Then
                                        MaxNumbers.Text = "1"
                                    Else
                                        MaxNumbers.Text = "2"
                                    End If
                                    If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                        MaxLower.Text = "0"
                                    Else
                                        MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                    End If
                            End Select
                        Else
                            If selectUpperCase.Checked = True And selectLowerCase.Checked = True _
                                And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                Select Case passwordLength.Text
                                    Case 8
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "3"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case 10
                                        MaxUpper.Text = "5"
                                        MaxLower.Text = "5"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case 12
                                        MaxUpper.Text = "6"
                                        MaxLower.Text = "6"
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                    Case Else
                                        MaxNumbers.Text = "0"
                                        MaxSymbols.Text = "0"
                                        MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                        If Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text) <= 0 Then
                                            MaxLower.Text = "0"
                                        Else
                                            MaxLower.Text = Val(passwordLength.Text) - Val(MaxUpper.Text) - Val(MaxNumbers.Text) - Val(MaxSymbols.Text)
                                        End If
                                End Select
                            Else
                                If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                    Select Case passwordLength.Text
                                        Case 8
                                            MaxUpper.Text = "8"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 10
                                            MaxUpper.Text = "10"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case 12
                                            MaxUpper.Text = "12"
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                        Case Else
                                            MaxUpper.Text = Val(passwordLength.Text)
                                            MaxLower.Text = "0"
                                            MaxNumbers.Text = "0"
                                            MaxSymbols.Text = "0"
                                    End Select
                                Else
                                    If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = True Then
                                        Select Case passwordLength.Text
                                            Case 8
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "4"
                                                MaxSymbols.Text = "4"
                                            Case 10
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "5"
                                                MaxSymbols.Text = "5"
                                            Case 12
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = "6"
                                                MaxSymbols.Text = "6"
                                            Case Else
                                                Val(passwordLength.Text)
                                                MaxUpper.Text = "0"
                                                MaxLower.Text = "0"
                                                MaxNumbers.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                        End Select
                                    Else
                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = False Then
                                            Select Case passwordLength.Text
                                                Case 8
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "8"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                                Case 10
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "10"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = ""
                                                Case 12
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = "12"
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                                Case Else
                                                    MaxUpper.Text = "0"
                                                    MaxLower.Text = Val(passwordLength.Text)
                                                    MaxNumbers.Text = "0"
                                                    MaxSymbols.Text = "0"
                                            End Select
                                        Else
                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                Select Case passwordLength.Text
                                                    Case 8
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "8"
                                                        MaxSymbols.Text = "0"
                                                    Case 10
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "10"
                                                        MaxSymbols.Text = "0"
                                                    Case 12
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = "12"
                                                        MaxSymbols.Text = "0"
                                                    Case Else
                                                        MaxUpper.Text = "0"
                                                        MaxLower.Text = "0"
                                                        MaxNumbers.Text = Val(passwordLength.Text)
                                                        MaxSymbols.Text = "0"

                                                End Select
                                            Else
                                                If selectUpperCase.Checked = False And selectLowerCase.Checked = False _
                                                    And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                    Select Case passwordLength.Text
                                                        Case 8
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "8"
                                                        Case 10
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "10"
                                                        Case 12
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = "12"
                                                        Case Else
                                                            MaxUpper.Text = "0"
                                                            MaxLower.Text = "0"
                                                            MaxNumbers.Text = "0"
                                                            MaxSymbols.Text = Val(passwordLength.Text)

                                                    End Select
                                                Else
                                                    If selectUpperCase.Checked = True And selectLowerCase.Checked = False _
                                                        And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                        Select Case passwordLength.Text
                                                            Case 8
                                                                MaxUpper.Text = "6"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "2"
                                                                MaxSymbols.Text = "0"
                                                            Case 10
                                                                MaxUpper.Text = "6"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "4"
                                                                MaxSymbols.Text = "0"
                                                            Case 12
                                                                MaxUpper.Text = "8"
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = "4"
                                                                MaxSymbols.Text = "0"
                                                            Case Else
                                                                MaxUpper.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                MaxLower.Text = "0"
                                                                MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                MaxSymbols.Text = "0"

                                                        End Select
                                                    Else
                                                        If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                            And selectNumbers.Checked = False And selectSpecialChar.Checked = True Then
                                                            Select Case passwordLength.Text
                                                                Case 8
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "6"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "2"
                                                                Case 10
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "6"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "4"
                                                                Case 12
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = "8"
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = "4"
                                                                Case Else
                                                                    MaxUpper.Text = "0"
                                                                    MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                    MaxNumbers.Text = "0"
                                                                    MaxSymbols.Text = Math.Floor(Val(passwordLength.Text) / 2)

                                                            End Select
                                                        Else
                                                            If selectUpperCase.Checked = False And selectLowerCase.Checked = True _
                                                                And selectNumbers.Checked = True And selectSpecialChar.Checked = False Then
                                                                Select Case passwordLength.Text
                                                                    Case 8
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "2"
                                                                        MaxSymbols.Text = "0"
                                                                    Case 10
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "6"
                                                                        MaxNumbers.Text = "4"
                                                                        MaxSymbols.Text = "0"
                                                                    Case 12
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = "8"
                                                                        MaxNumbers.Text = "4"
                                                                        MaxSymbols.Text = "0"
                                                                    Case Else
                                                                        MaxUpper.Text = "0"
                                                                        MaxLower.Text = Math.Ceiling(Val(passwordLength.Text) / 2)
                                                                        MaxNumbers.Text = Math.Floor(Val(passwordLength.Text) / 2)
                                                                        MaxSymbols.Text = "0"
                                                                End Select
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class
