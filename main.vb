Imports System.IO
Imports System.Security.Cryptography

Module Main
    Public gameSettings As Settings = New Settings
    Public Sub Main()
        Application.Run(startForm)
    End Sub

    Public Sub setTheme(Form As Form)
        If (gameSettings.isDarkMode) Then
            SetThemeDark(Form)
        Else
            SetThemeWhite(Form)
        End If
    End Sub

    Public Sub SetThemeDark(Form As Form)
        Form.BackColor = Color.FromArgb(68, 68, 68)
        For Each child As Control In Form.Controls
            child.ForeColor = Color.FromArgb(244, 212, 124)
            child.BackColor = Color.FromArgb(68, 68, 68)
        Next
    End Sub

    Public Sub SetThemeWhite(Form As Form)
        Form.BackColor = Color.FromArgb(190, 190, 190)
        For Each child As Control In Form.Controls
            child.ForeColor = Color.FromArgb(8, 44, 108)
            child.BackColor = Color.FromArgb(190, 190, 190)
        Next
    End Sub

End Module
