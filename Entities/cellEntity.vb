Public Class cellEntity
    Inherits Panel

    Public Const cellWidth As Integer = 16
    Public Const cellHeight As Integer = 16

    Public Enum CellStates

        Safed = 0
        Unknowned = 9
        Flagged = 10
        Trapped = 11

    End Enum



    Private discovered As Boolean = False
    Dim ImageListPictures As ImageList
    Dim isFlagged As Boolean = False
    Dim value As Integer = CellStates.Safed
    Dim x As Integer
    Dim y As Integer

    Sub New(img As ImageList, Index As Integer, positionX As Integer, positionY As Integer)
        ImageListPictures = img
        x = positionX
        y = positionY
        Width = cellWidth
        Height = cellHeight
        Location = New Point(positionX * cellWidth, positionY * cellHeight)
        BackgroundImage = Me.ImageListPictures.Images(Index)
    End Sub

    Private Sub removeFlag()
        GameModule.removeFlag()
        isFlagged = False
    End Sub

    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        MyBase.OnMouseClick(e)


        If e.Button = MouseButtons.Right And Not discovered Then

            If isFlagged Then
                removeFlag()
                Me.BackgroundImage = Me.ImageListPictures.Images(CellStates.Unknowned)
            Else
                If Not GameModule.useFlag() Then
                    Me.BackgroundImage = Me.ImageListPictures.Images(CellStates.Flagged)
                    isFlagged = True
                    GameModule.gameWon()
                End If
            End If

        ElseIf e.Button = MouseButtons.Left And Not discovered Then
            discover()
            GameModule.updateLastReveal()
            If value = CellStates.Safed Then
                If isFlagged Then
                    removeFlag()
                End If
                GameModule.Discover(Me)
            End If
            If value = CellStates.Trapped Then
                If isFlagged Then
                    removeFlag()
                End If
                GameModule.gameOver()
            End If
        End If

    End Sub

    Public Sub discover()
        Me.BackgroundImage = Me.ImageListPictures.Images(Me.value)
        discovered = True
        If isFlagged Then
            removeFlag()
        End If
        If Not value = CellStates.Trapped Then
            GameModule.countDiscoveredCells()
        End If
    End Sub

    Public Sub setSelfBomb()
        Me.value = CellStates.Trapped
    End Sub

    Public Function getCellValue()
        Return Me.value
    End Function

    Public Function getPoint()
        Return New Point(x, y)
    End Function

    Public Sub addVoisin()
        If Me.value <> CellStates.Trapped Then
            value += 1
        End If
    End Sub

    Public Function isDiscovered()
        Return discovered
    End Function

End Class
