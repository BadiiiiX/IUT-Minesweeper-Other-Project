Public Class statForm

    Private Sub loadStats(sender As Object, e As EventArgs) Handles MyBase.Load
        gameSettings.playerList.Sort(AddressOf PlayerEntity.comparatorCellAsc)

        DisplayList()

        Main.setTheme(Me)

        foundPlayer(gameSettings.lastPlayer)

        cbPlayerList.Text = gameSettings.lastPlayer

        For Each gamer As PlayerEntity In gameSettings.playerList
            cbPlayerList.Items.Add(gamer.getName())
        Next
    End Sub


    Private Sub foundPlayer(playerName As String)
        Dim playerToFound As PlayerEntity
        Dim isFounded As Boolean = False

        For Each player As PlayerEntity In gameSettings.playerList

            If (String.Compare(player.getName(), playerName, True) = 0) Then
                isFounded = Not isFounded
                playerToFound = player
                Exit For
            End If

        Next

        If (Not isFounded) Then Return

        updatePlayerData(playerToFound)
    End Sub


    Private Sub DisplayList()
        lbPlayerList.Items.Clear()

        For Each gamer As PlayerEntity In gameSettings.playerList
            lbPlayerList.Items.Add(gamer.getName() & " | " & gamer.getCellDiscovered() & " cases | " & gamer.getTimePlayed() & " sec")
        Next
    End Sub


    Private Sub updatePlayerData(Gamer As PlayerEntity)
        Dim Stats As String = ""
        Stats += "Nom : " & Gamer.getName() & vbNewLine
        Stats += "Nombre Case relevé en une partie : " & Gamer.getCellDiscovered() & " cases." & vbNewLine
        Stats += "Total joué : " & Gamer.getTimeCumulative() & " sec." & vbNewLine
        Stats += "Total parties : " & Gamer.getGamePlayed() & " parties." & vbNewLine
        lPlayerData.Text = Stats
    End Sub

    Private Sub onButtonSortClick(sender As Object, e As EventArgs) Handles sortButton.Click
        If sortButton.Text = "↑" Then
            sortButton.Text = "↓"
            gameSettings.playerList.Sort(AddressOf PlayerEntity.comparatorCellDesc)
        Else
            sortButton.Text = "↑"
            gameSettings.playerList.Sort(AddressOf PlayerEntity.comparatorCellAsc)
        End If

        DisplayList()
    End Sub

    Private Sub onComboBoxIndexChange(sender As Object, e As EventArgs) Handles cbPlayerList.SelectedIndexChanged
        foundPlayer(cbPlayerList.Text)
    End Sub

    Private Sub onPlayerListIndexChange(sender As Object, e As EventArgs) Handles lbPlayerList.SelectedIndexChanged
        foundPlayer(lbPlayerList.Text.Split(",")(0))
    End Sub

    Private Sub onBtnExitClicked(sender As Object, e As EventArgs) Handles redoButton.Click
        Me.Close()
    End Sub

    Private Sub OnFormClosed(sender As Object, e As EventArgs) Handles MyBase.Closed
        startForm.Show()
    End Sub

End Class