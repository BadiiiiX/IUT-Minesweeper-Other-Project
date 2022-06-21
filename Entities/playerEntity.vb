Public Class PlayerEntity
    Private name As String
    Private countCellDiscovered, timePlayed, gamePlayed, timeCumulative As Integer

    Sub New(n As String, Optional cells As Integer = 0, Optional time As Integer = 0, Optional GameCount As Integer = 0, Optional cumulTime As Integer = 0)
        name = n
        countCellDiscovered = cells
        timePlayed = time
        gamePlayed = GameCount
        timeCumulative = cumulTime
    End Sub


    'Getters

    Public Function getName()
        Return name
    End Function

    Public Function getCellDiscovered()
        Return countCellDiscovered
    End Function

    Public Function getTimePlayed()
        Return timePlayed
    End Function

    Public Function getGamePlayed()
        Return gamePlayed
    End Function

    Public Function getTimeCumulative()
        Return timeCumulative
    End Function

    'Setters

    Public Sub setCellDiscovered(cell As Integer)
        countCellDiscovered = cell
    End Sub

    Public Sub setTimePlayed(time As Integer)
        timePlayed = time
    End Sub

    Public Sub setGamePlayed(number As Integer)
        gamePlayed = number
    End Sub

    Public Sub setTimeCumulative(time As Integer)
        timeCumulative = time
    End Sub


    'Utilities

    Public Shared Function comparatorCellAsc(p1 As PlayerEntity, p2 As PlayerEntity)
        Return If(p2.countCellDiscovered.CompareTo(p1.countCellDiscovered) <> 0,
            p2.countCellDiscovered.CompareTo(p1.countCellDiscovered),
            p1.timePlayed.CompareTo(p2.timePlayed))
    End Function

    Public Shared Function comparatorCellDesc(p1 As PlayerEntity, p2 As PlayerEntity)
        Return If(p1.countCellDiscovered.CompareTo(p2.countCellDiscovered) <> 0,
            p1.countCellDiscovered.CompareTo(p2.countCellDiscovered),
            p2.timePlayed.CompareTo(p1.timePlayed))
    End Function

End Class
