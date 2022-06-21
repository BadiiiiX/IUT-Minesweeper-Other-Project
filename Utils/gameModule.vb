Module GameModule

    Public grid As New Hashtable

    Dim countCells As Integer = 0
    Dim lastElement As Integer = 0

    Public flagNumber As Integer = gameSettings.minesCount

    Public countdown As Integer

    Public isEnd As Boolean = False


    Private LOOSED_GAME_MSG = "Perdu !"
    Private WINNED_GAME_MSG = "Bravo ! Vous avez gagné."

    Private Sub resetValues()

        grid.Clear()

        countCells = 0
        lastElement = 0

        flagNumber = gameSettings.minesCount

        isEnd = False

    End Sub

    Private Function generateRandomNumber()
        Return CInt(Int((gameSettings.columnsCount * Rnd()) + 1))
    End Function

    Private Function isLogicalCell(x As Integer, y As Integer)

        Return x >= 0 And x <= gameSettings.columnsCount - 1 And y >= 0 And y <= gameSettings.linesCount - 1

    End Function

    Public Sub generateGrid()

        resetValues()

        gameForm.mainGrid.Width = gameSettings.columnsCount * cellEntity.cellWidth
        gameForm.mainGrid.Height = gameSettings.linesCount * cellEntity.cellHeight


        For line As Integer = 0 To gameSettings.linesCount - 1
            For column As Integer = 0 To gameSettings.columnsCount - 1
                grid.Add(New Point(column, line), New cellEntity(gameForm.imgListCell, 9, column, line))
            Next
        Next

        For i As Integer = 0 To gameSettings.minesCount - 1

            While (True)
                Randomize()
                Dim x As Integer = generateRandomNumber()
                Dim y As Integer = generateRandomNumber()

                Dim cellMine As cellEntity = grid.Item(New Point(x Mod gameSettings.columnsCount, y Mod gameSettings.linesCount))

                If cellMine.getCellValue() <> cellEntity.CellStates.Trapped Then
                    cellMine.setSelfBomb()
                    setVoisins(cellMine)
                    Exit While
                End If
            End While
        Next

        For Each cell As cellEntity In grid.Values
            gameForm.mainGrid.Controls.Add(cell)
        Next

    End Sub

    Public Sub setVoisins(cell As cellEntity)
        Dim point As Point = cell.getPoint()
        Dim x As Integer = point.X
        Dim y As Integer = point.Y


        Dim cellElm As cellEntity

        Dim pointPossibilities() As (Integer, Integer) =
            {
                (x - 1, y + 0),
                (x + 1, y + 0),
                (x + 0, y + 1),
                (x - 0, y - 1),
                (x - 1, y - 1),
                (x + 1, y + 1),
                (x + 1, y - 1),
                (x - 1, y + 1)
            }

        For Each item As (Integer, Integer) In pointPossibilities

            If (isLogicalCell(item.Item1, item.Item2)) Then

                cellElm = grid.Item(New Point(item.Item1, item.Item2))
                cellElm.addVoisin()

            End If

        Next


    End Sub

    Private Sub discoverIfPossible(cell As cellEntity)

        If cell.getCellValue < cellEntity.CellStates.Unknowned And Not cell.isDiscovered Then
            cell.discover()
            If cell.getCellValue = cellEntity.CellStates.Safed Then
                Discover(cell)
            End If
        End If

    End Sub

    Public Sub Discover(cell As cellEntity)
        Dim point As Point = cell.getPoint
        Dim x As Integer = point.X
        Dim y As Integer = point.Y
        Dim cellElm As cellEntity

        Dim pointPossibilities() As (Integer, Integer) =
            {
                (x - 1, y + 0),
                (x + 1, y + 0),
                (x + 0, y + 1),
                (x - 0, y - 1),
                (x - 1, y - 1),
                (x + 1, y + 1),
                (x + 1, y - 1),
                (x - 1, y + 1)
            }

        For Each item As (Integer, Integer) In pointPossibilities

            If (isLogicalCell(item.Item1, item.Item2)) Then

                cellElm = grid.Item(New Point(item.Item1, item.Item2))
                discoverIfPossible(cellElm)

            End If

        Next

    End Sub

    Public Sub gameOver()
        For Each cell As cellEntity In grid.Values
            If cell.getCellValue = cellEntity.CellStates.Trapped Then
                cell.discover()
            End If
        Next

        pauseGame()
        EndGame(LOOSED_GAME_MSG)
    End Sub

    Public Sub gameWon()
        If flagNumber = 0 And countCells = (gameSettings.columnsCount * gameSettings.linesCount - gameSettings.minesCount) Then
            pauseGame()
            EndGame(WINNED_GAME_MSG)
        End If
    End Sub

    Public Sub pauseGame()

        Dim timer As Timer = If(gameSettings.isTimeEnabled, gameForm.gameTimer, gameForm.timerHided)

        timer.Stop()

        gameForm.mainGrid.Enabled = False
    End Sub


    Public Sub EndGame(result As String)
        gameForm.BtnPausePlay.Visible = False

        Dim player As PlayerEntity = gameSettings.currentPlayer

        If player.getCellDiscovered() < countCells Then
            player.setCellDiscovered(countCells)
            player.setTimePlayed(lastElement)
        End If

        If player.getCellDiscovered() = countCells And player.getTimePlayed() > lastElement Then
            player.setCellDiscovered(countCells)
            player.setTimePlayed(lastElement)
        End If

        player.setGamePlayed(player.getGamePlayed() + 1)

        If gameSettings.isTimeEnabled Then
            player.setTimeCumulative(player.getTimeCumulative() + gameSettings.playTime - countdown)
        Else
            player.setTimeCumulative(player.getTimeCumulative() + countdown)
        End If

        Dim time = If(gameSettings.isTimeEnabled, gameSettings.playTime - countdown, countdown)

        Dim endMessage As String = result & vbNewLine
        endMessage += "Nombre de case trouvé : " & countCells & " (en plus sans mourir :o)" & vbNewLine
        endMessage += "En plus vous avez survécu pour " & lastElement & " sec. " & vbNewLine
        endMessage += "vous avez en tout joué " & time & "sec. (je suis un robot, je ne sais pas ce que ça vaut !)"

        MsgBox(endMessage, MsgBoxStyle.OkOnly)

        isEnd = True
    End Sub

    Public Sub updateLastReveal()
        lastElement = If(gameSettings.isTimeEnabled, gameSettings.playTime - countdown, countdown)
    End Sub

    Public Function useFlag()
        Dim canSetAnotherFlag As Boolean = False
        If flagNumber > 0 Then
            flagNumber -= 1
        Else
            canSetAnotherFlag = Not canSetAnotherFlag
        End If

        gameForm.setRemainingFlags(GameModule.flagNumber)

        Return canSetAnotherFlag
    End Function

    Public Sub removeFlag()
        flagNumber += 1
        gameForm.setRemainingFlags(GameModule.flagNumber)
    End Sub

    Public Sub countDiscoveredCells()
        countCells += 1
        If countCells = (gameSettings.columnsCount * gameSettings.linesCount - gameSettings.minesCount) Then
            gameWon()
        End If
    End Sub
End Module
