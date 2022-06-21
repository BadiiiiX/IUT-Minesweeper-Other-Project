Imports System.Xml
Public Class startForm

    Const PLAYER_LENGTH_LIMIT As Integer = 3
    Const PLAYER_LENGTH_LIMIT_ERROR_MSG As String = "Le pseudonyme doit dépasser trois caractères, soyez plus créatif"
    Const QUIT_GAME_MSG As String = "Êtes-vous sûr de quitter ce magnifique jeu ? :c"

    Private Function checkPlayerName(playerName As String)
        If playerName.Length < PLAYER_LENGTH_LIMIT Then
            Me.ErrorProviderLauncher.SetError(ComboBoxNameGamer, PLAYER_LENGTH_LIMIT_ERROR_MSG)
            Return True
        End If
        Return False
    End Function

    Private Sub startParty()
        Me.Hide()
        gameForm.Show()
    End Sub

    Private Sub definePlayer(playerName As String, player As PlayerEntity)
        gameSettings.lastPlayer = playerName
        gameSettings.currentPlayer = player
    End Sub

    Private Sub addPlayer(playerName As String, player As PlayerEntity)
        gameSettings.playerList.Add(player)
        ComboBoxNameGamer.Items.Add(playerName)
    End Sub

    Private Sub onBtnPlayClick(sender As Object, e As EventArgs) Handles BtnNewGame.Click
        Dim player As PlayerEntity
        Dim playerName As String = ComboBoxNameGamer.Text
        If (checkPlayerName(playerName.Trim())) Then Return

        Me.ErrorProviderLauncher.Clear()

        Dim playerExist As Boolean = False
        For Each playerElement As PlayerEntity In gameSettings.playerList

            If (String.Compare(playerElement.getName(), playerName) = 0) Then
                playerExist = True
                player = playerElement
                Exit For
            End If
        Next

        If (Not playerExist) Then
            player = New PlayerEntity(playerName)
            addPlayer(playerName, player)
        End If

        definePlayer(playerName, player)

        startParty()
    End Sub

    Private Sub onBtnExitClick(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub onBaseLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        'Wanna a ternary condition :c
        If gameSettings.isDarkMode Then
            Main.SetThemeDark(Me)
        Else
            Main.SetThemeWhite(Me)
        End If

        ComboBoxNameGamer.Text = gameSettings.lastPlayer

        For Each gamer As PlayerEntity In gameSettings.playerList
            ComboBoxNameGamer.Items.Add(gamer.getName())
        Next
    End Sub

    Private Sub ShowElementOnClick(element As Object)
        Me.Hide()
        element.Show()
    End Sub

    Private Sub onButtonExitClick(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSettings.Click
        ShowElementOnClick(settingsForm)
    End Sub

    Private Sub onBtnStatClick(sender As Object, e As EventArgs) Handles BtnStats.Click
        ShowElementOnClick(statForm)
    End Sub

    Private Sub onBtnFormClsClick(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox(QUIT_GAME_MSG, MsgBoxStyle.YesNo, "Quitter") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub
End Class