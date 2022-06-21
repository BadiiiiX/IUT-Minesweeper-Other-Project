
Public Class Settings

    Private Const DEFAULT_MINE As Integer = 10
    Private Const DEFAULT_LINES_OR_COLUMNS As Integer = 8
    Private Const DEFAULT_TIME_LIMIT As Integer = 60

    Public minesCount = DEFAULT_MINE
    Public columnsCount As Integer = DEFAULT_LINES_OR_COLUMNS
    Public linesCount As Integer = DEFAULT_LINES_OR_COLUMNS

    Public lastPlayer As String
    Public currentPlayer As PlayerEntity

    Public playerList As List(Of PlayerEntity) = New List(Of PlayerEntity)
    Public playTime As Integer = DEFAULT_TIME_LIMIT

    Public isTimeEnabled As Boolean = True

    Public isDarkMode As Boolean = False

End Class
