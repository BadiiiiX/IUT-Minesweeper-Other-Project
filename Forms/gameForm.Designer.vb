<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gameForm))
        Me.mainGrid = New System.Windows.Forms.Panel()
        Me.imgListCell = New System.Windows.Forms.ImageList(Me.components)
        Me.pInformations = New System.Windows.Forms.Panel()
        Me.lRemainingTime = New System.Windows.Forms.Label()
        Me.lRemainingFlags = New System.Windows.Forms.Label()
        Me.pFlag = New System.Windows.Forms.PictureBox()
        Me.lPlayer = New System.Windows.Forms.Label()
        Me.dPlayer = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ImageListCountdown = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnPausePlay = New System.Windows.Forms.Button()
        Me.timerHided = New System.Windows.Forms.Timer(Me.components)
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.pInformations.SuspendLayout()
        CType(Me.pFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainGrid
        '
        Me.mainGrid.BackColor = System.Drawing.SystemColors.Window
        Me.mainGrid.Location = New System.Drawing.Point(12, 129)
        Me.mainGrid.Name = "mainGrid"
        Me.mainGrid.Size = New System.Drawing.Size(186, 158)
        Me.mainGrid.TabIndex = 1
        '
        'imgListCell
        '
        Me.imgListCell.ImageStream = CType(resources.GetObject("imgListCell.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListCell.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListCell.Images.SetKeyName(0, "unknown.png")
        Me.imgListCell.Images.SetKeyName(1, "1.png")
        Me.imgListCell.Images.SetKeyName(2, "2.png")
        Me.imgListCell.Images.SetKeyName(3, "3.png")
        Me.imgListCell.Images.SetKeyName(4, "4.png")
        Me.imgListCell.Images.SetKeyName(5, "5.png")
        Me.imgListCell.Images.SetKeyName(6, "6.png")
        Me.imgListCell.Images.SetKeyName(7, "7.png")
        Me.imgListCell.Images.SetKeyName(8, "8.png")
        Me.imgListCell.Images.SetKeyName(9, "0.png")
        Me.imgListCell.Images.SetKeyName(10, "flagCell.png")
        Me.imgListCell.Images.SetKeyName(11, "mine.png")
        '
        'pInformations
        '
        Me.pInformations.Controls.Add(Me.lRemainingTime)
        Me.pInformations.Controls.Add(Me.lRemainingFlags)
        Me.pInformations.Controls.Add(Me.pFlag)
        Me.pInformations.Dock = System.Windows.Forms.DockStyle.Top
        Me.pInformations.Location = New System.Drawing.Point(0, 0)
        Me.pInformations.Name = "pInformations"
        Me.pInformations.Size = New System.Drawing.Size(407, 72)
        Me.pInformations.TabIndex = 2
        '
        'lRemainingTime
        '
        Me.lRemainingTime.AutoSize = True
        Me.lRemainingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lRemainingTime.Location = New System.Drawing.Point(241, 27)
        Me.lRemainingTime.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.lRemainingTime.Name = "lRemainingTime"
        Me.lRemainingTime.Size = New System.Drawing.Size(138, 26)
        Me.lRemainingTime.TabIndex = 11
        Me.lRemainingTime.Text = "00:00 restant"
        '
        'lRemainingFlags
        '
        Me.lRemainingFlags.AutoSize = True
        Me.lRemainingFlags.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lRemainingFlags.Location = New System.Drawing.Point(48, 27)
        Me.lRemainingFlags.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.lRemainingFlags.Name = "lRemainingFlags"
        Me.lRemainingFlags.Size = New System.Drawing.Size(124, 26)
        Me.lRemainingFlags.TabIndex = 10
        Me.lRemainingFlags.Text = "0 Drapeaux"
        '
        'pFlag
        '
        Me.pFlag.Image = Global.Projet_IHM_VB.net.My.Resources.Resources.flag
        Me.pFlag.Location = New System.Drawing.Point(12, 25)
        Me.pFlag.Name = "pFlag"
        Me.pFlag.Size = New System.Drawing.Size(28, 28)
        Me.pFlag.TabIndex = 9
        Me.pFlag.TabStop = False
        '
        'lPlayer
        '
        Me.lPlayer.AutoSize = True
        Me.lPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPlayer.Location = New System.Drawing.Point(207, 117)
        Me.lPlayer.Name = "lPlayer"
        Me.lPlayer.Size = New System.Drawing.Size(95, 15)
        Me.lPlayer.TabIndex = 8
        Me.lPlayer.Text = "Nom du joueur :"
        '
        'dPlayer
        '
        Me.dPlayer.AutoSize = True
        Me.dPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dPlayer.Location = New System.Drawing.Point(331, 117)
        Me.dPlayer.Name = "dPlayer"
        Me.dPlayer.Size = New System.Drawing.Size(45, 15)
        Me.dPlayer.TabIndex = 7
        Me.dPlayer.Text = "Label1"
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 1000
        '
        'ImageListCountdown
        '
        Me.ImageListCountdown.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListCountdown.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListCountdown.TransparentColor = System.Drawing.Color.Transparent
        '
        'BtnQuit
        '
        Me.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuit.Location = New System.Drawing.Point(322, 155)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(65, 26)
        Me.BtnQuit.TabIndex = 7
        Me.BtnQuit.Text = "Quitter"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnPausePlay
        '
        Me.BtnPausePlay.Enabled = False
        Me.BtnPausePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPausePlay.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.BtnPausePlay.Location = New System.Drawing.Point(275, 211)
        Me.BtnPausePlay.Name = "BtnPausePlay"
        Me.BtnPausePlay.Size = New System.Drawing.Size(80, 40)
        Me.BtnPausePlay.TabIndex = 8
        Me.BtnPausePlay.Text = ";"
        Me.BtnPausePlay.UseVisualStyleBackColor = True
        '
        'timerHided
        '
        Me.timerHided.Interval = 1000
        '
        'btnPlay
        '
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(237, 155)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(65, 25)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'gameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(407, 299)
        Me.Controls.Add(Me.BtnPausePlay)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.dPlayer)
        Me.Controls.Add(Me.lPlayer)
        Me.Controls.Add(Me.pInformations)
        Me.Controls.Add(Me.mainGrid)
        Me.Controls.Add(Me.btnPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "L'endroit le plus dangereux (Euh, le démineur*)"
        Me.pInformations.ResumeLayout(False)
        Me.pInformations.PerformLayout()
        CType(Me.pFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainGrid As Panel
    Friend WithEvents imgListCell As ImageList
    Friend WithEvents pInformations As Panel
    Friend WithEvents gameTimer As Timer
    Friend WithEvents ImageListCountdown As ImageList
    Friend WithEvents dPlayer As Label
    Friend WithEvents lPlayer As Label
    Friend WithEvents pFlag As PictureBox
    Friend WithEvents BtnQuit As Button
    Friend WithEvents BtnPausePlay As Button
    Friend WithEvents timerHided As Timer
    Friend WithEvents btnPlay As Button
    Friend WithEvents lRemainingFlags As Label
    Friend WithEvents lRemainingTime As Label
End Class
