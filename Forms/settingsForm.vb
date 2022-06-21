Public Class settingsForm

    Const INCORRECT_VALUE_MSG = "Valeur incorrect"
    Const QUIT_WITHOUT_SAVE_MSG = "Voulez-vous quitter sans sauvegarder vos modifications ?"
    Const MAX_VALUE_COLUMN_LINE = 20

    Dim isSaved As Boolean = False
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Main.setTheme(Me)

        Main.setTheme(startForm)

        cbTheme.Text = If(gameSettings.isDarkMode, "Sombre", "Clair")

        cbTheme.Items.Add("Sombre")
        cbTheme.Items.Add("Clair")

        tbColumns.Text = gameSettings.columnsCount
        tbLines.Text = gameSettings.linesCount
        tbMines.Text = gameSettings.minesCount

        tbTime.Text = gameSettings.playTime
        cbTime.Checked = gameSettings.isTimeEnabled
        tbTime.Enabled = cbTime.Checked
    End Sub

    Private Sub showLauncher(classObject As Object)
        startForm.Show()
        classObject.Close()
    End Sub

    Private Sub setError(ctx As Object, condition As Boolean, control As Control, message As String)

        If (condition) Then ctx.ErrorProviderSettings.SetError(control, message)

    End Sub

    Private Sub onBtnPassClick(sender As Object, e As EventArgs) Handles btnPass.Click


        Dim columnCount As Integer
        Dim lineCount As Integer
        Dim mineCount As Integer
        Dim countdown As Integer


        Me.ErrorProviderSettings.Clear()

        setError(Me, Not Integer.TryParse(tbColumns.Text, columnCount), tbColumns, INCORRECT_VALUE_MSG)
        setError(Me, Not Integer.TryParse(tbLines.Text, lineCount), tbLines, INCORRECT_VALUE_MSG)
        setError(Me, Not Integer.TryParse(tbMines.Text, mineCount), tbMines, INCORRECT_VALUE_MSG)
        setError(Me, Not Integer.TryParse(tbTime.Text, countdown), tbTime, INCORRECT_VALUE_MSG)

        setError(Me, columnCount > MAX_VALUE_COLUMN_LINE, tbColumns, INCORRECT_VALUE_MSG)
        setError(Me, lineCount > MAX_VALUE_COLUMN_LINE, tbLines, INCORRECT_VALUE_MSG)
        setError(Me, mineCount >= columnCount * lineCount, tbMines, INCORRECT_VALUE_MSG)
        setError(Me, tbTime.Text > 60 * 59, tbTime, INCORRECT_VALUE_MSG)


        gameSettings.columnsCount = columnCount
        gameSettings.linesCount = lineCount
        gameSettings.minesCount = mineCount
        gameSettings.playTime = countdown
        gameSettings.isDarkMode = (cbTheme.Text = "Sombre")

        Main.setTheme(startForm)

        gameSettings.isTimeEnabled = cbTime.Checked

        isSaved = True
        showLauncher(Me)
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        showLauncher(Me)
    End Sub

    Private Sub CheckBoxCountdown_CheckedChanged(sender As Object, e As EventArgs) Handles cbTime.CheckedChanged
        tbTime.Enabled = cbTime.Checked
    End Sub

    Private Sub FormSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isSaved Then
            startForm.Show()
            Return
        End If

        If MsgBox(QUIT_WITHOUT_SAVE_MSG, MsgBoxStyle.YesNo, "Quitter") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            startForm.Show()
        End If
    End Sub

    Private Sub TBColumns_TextChanged(sender As Object, e As EventArgs) Handles tbColumns.TextChanged

    End Sub
End Class