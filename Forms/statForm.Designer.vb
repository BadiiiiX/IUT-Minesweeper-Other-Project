<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class statForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(statForm))
        Me.lbPlayerList = New System.Windows.Forms.ListBox()
        Me.sortButton = New System.Windows.Forms.Button()
        Me.cbPlayerList = New System.Windows.Forms.ComboBox()
        Me.lPlayerData = New System.Windows.Forms.Label()
        Me.redoButton = New System.Windows.Forms.Button()
        Me.lSearchPlayers = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbPlayerList
        '
        Me.lbPlayerList.FormattingEnabled = True
        Me.lbPlayerList.Location = New System.Drawing.Point(53, 44)
        Me.lbPlayerList.Name = "lbPlayerList"
        Me.lbPlayerList.Size = New System.Drawing.Size(222, 199)
        Me.lbPlayerList.TabIndex = 0
        '
        'sortButton
        '
        Me.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sortButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortButton.Location = New System.Drawing.Point(12, 120)
        Me.sortButton.Name = "sortButton"
        Me.sortButton.Size = New System.Drawing.Size(35, 35)
        Me.sortButton.TabIndex = 1
        Me.sortButton.Text = "↑"
        Me.sortButton.UseVisualStyleBackColor = True
        '
        'cbPlayerList
        '
        Me.cbPlayerList.FormattingEnabled = True
        Me.cbPlayerList.Location = New System.Drawing.Point(335, 76)
        Me.cbPlayerList.Name = "cbPlayerList"
        Me.cbPlayerList.Size = New System.Drawing.Size(202, 21)
        Me.cbPlayerList.TabIndex = 2
        '
        'lPlayerData
        '
        Me.lPlayerData.AutoSize = True
        Me.lPlayerData.Location = New System.Drawing.Point(304, 133)
        Me.lPlayerData.Name = "lPlayerData"
        Me.lPlayerData.Size = New System.Drawing.Size(16, 13)
        Me.lPlayerData.TabIndex = 3
        Me.lPlayerData.Text = "..."
        '
        'redoButton
        '
        Me.redoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.redoButton.Location = New System.Drawing.Point(462, 232)
        Me.redoButton.Name = "redoButton"
        Me.redoButton.Size = New System.Drawing.Size(75, 23)
        Me.redoButton.TabIndex = 4
        Me.redoButton.Text = "Retour"
        Me.redoButton.UseVisualStyleBackColor = True
        '
        'lSearchPlayers
        '
        Me.lSearchPlayers.AutoSize = True
        Me.lSearchPlayers.Location = New System.Drawing.Point(304, 44)
        Me.lSearchPlayers.Name = "lSearchPlayers"
        Me.lSearchPlayers.Size = New System.Drawing.Size(116, 13)
        Me.lSearchPlayers.TabIndex = 5
        Me.lSearchPlayers.Text = "Rechercher un joueur :"
        '
        'statForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 270)
        Me.Controls.Add(Me.lSearchPlayers)
        Me.Controls.Add(Me.redoButton)
        Me.Controls.Add(Me.lPlayerData)
        Me.Controls.Add(Me.cbPlayerList)
        Me.Controls.Add(Me.sortButton)
        Me.Controls.Add(Me.lbPlayerList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "statForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stats (Pas les maths)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPlayerList As ListBox
    Friend WithEvents sortButton As Button
    Friend WithEvents cbPlayerList As ComboBox
    Friend WithEvents lPlayerData As Label
    Friend WithEvents redoButton As Button
    Friend WithEvents lSearchPlayers As Label
End Class
