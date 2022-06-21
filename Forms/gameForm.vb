Public Class gameForm


    Const QUIT_GAME_MSG = "Etes-vous sûr d'abandonner la partie ?"

    Dim isPlaying As Boolean = True

    Private Const Play As Char = "4" 'Affichage du signe Play
    Private Const Pause As Char = ";" 'Affichage du signe Pause

    Private Const xPosBtnPauseStart As Integer = 105
    Private Const xPosBtnStart As Integer = 110



    Public Sub setRemainingFlags(number As Integer)
        lRemainingFlags.Text = number.ToString() & " drapeau" & If(number > 1, "x", "")
    End Sub

    Public Sub setRemainingTime(number As Integer)
        Dim minutes As Integer = number \ 60
        Dim seconds As Integer = number Mod 60

        lRemainingTime.Text = If(minutes < 10, "0" & minutes, minutes) & ":" & If(seconds < 10, "0" & seconds, seconds) & " restant"
    End Sub


    Private Sub ResizeAll()

        Dim x = 425, y = 425
        If gameSettings.columnsCount > 10 Then
            x += (gameSettings.columnsCount - 10) * cellEntity.cellWidth
        End If
        If gameSettings.linesCount > 10 Then
            y += (gameSettings.linesCount - 10) * cellEntity.cellWidth
        End If
        Me.Size = New Size(x, y)
        Dim point As Point = New Point((gameSettings.columnsCount * cellEntity.cellWidth) + xPosBtnStart, btnPlay.Location.Y)
        btnPlay.Location = point
        point.Y = BtnQuit.Location.Y
        BtnQuit.Location = point
        point.X = (gameSettings.columnsCount * cellEntity.cellWidth) + xPosBtnPauseStart
        point.Y = BtnPausePlay.Location.Y
        BtnPausePlay.Location = point

    End Sub

    Private Sub updateCountdown(sender As Object, e As EventArgs) Handles gameTimer.Tick

        If (GameModule.countdown = 10) Then
            gameOver()
            Return
        End If

        GameModule.countdown -= 1

        setRemainingTime(GameModule.countdown)

    End Sub

    Private Sub updateTimer(sender As Object, e As EventArgs) Handles timerHided.Tick
        GameModule.countdown += 1
    End Sub


    Private Sub onFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeAll()

        Main.setTheme(Me)

        BtnQuit.Visible = False
        BtnPausePlay.Visible = False
        dPlayer.Text = gameSettings.currentPlayer.getName()
        mainGrid.Enabled = False
        BtnPausePlay.Enabled = False
        BtnPausePlay.Text = Pause

        If gameSettings.isTimeEnabled Then GameModule.countdown = gameSettings.playTime


        setRemainingTime(GameModule.countdown)
        setRemainingFlags(flagNumber)

        GameModule.generateGrid()

        btnPlay.Enabled = True
    End Sub


    Private Sub onBtnPlayClick(sender As Object, e As EventArgs) Handles btnPlay.Click
        If gameSettings.isTimeEnabled Then
            gameTimer.Start()
        Else
            timerHided.Start()
        End If
        mainGrid.Enabled = True
        BtnPausePlay.Enabled = True
        btnPlay.Enabled = False
        btnPlay.Visible = False
        BtnQuit.Visible = True
        BtnPausePlay.Visible = True
    End Sub



    Private Sub pauseGameSteps()
        GameModule.pauseGame()
        BtnPausePlay.Text = Play
        isPlaying = Not isPlaying
    End Sub

    Private Sub resumeGameSteps(timer As Timer)
        timer.Start()
        mainGrid.Enabled = True
        BtnPausePlay.Text = Pause
        isPlaying = Not isPlaying
    End Sub

    Private Sub onPauseClick(sender As Object, e As EventArgs) Handles BtnPausePlay.Click
        If GameModule.isEnd Then
            Return
        End If

        Dim timer As Timer = If(gameSettings.isTimeEnabled, gameTimer, timerHided)

        If isPlaying Then pauseGameSteps() Else resumeGameSteps(timer)


    End Sub


    Private Sub onBtnGiveUpClick(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub


    Private Sub onGameQuitForm(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        startForm.Show()
    End Sub

    Private Sub onQuitForm(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If GameModule.isEnd Then
            Return
        End If
        If MsgBox(QUIT_GAME_MSG, MsgBoxStyle.YesNo, "Quitter") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

End Class