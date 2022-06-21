<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startForm))
        Me.ComboBoxNameGamer = New System.Windows.Forms.ComboBox()
        Me.BtnStats = New System.Windows.Forms.Button()
        Me.BtnNewGame = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LabelNameGamer = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProviderLauncher = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProviderLauncher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxNameGamer
        '
        Me.ComboBoxNameGamer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxNameGamer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxNameGamer.FormattingEnabled = True
        Me.ComboBoxNameGamer.Location = New System.Drawing.Point(68, 81)
        Me.ComboBoxNameGamer.Name = "ComboBoxNameGamer"
        Me.ComboBoxNameGamer.Size = New System.Drawing.Size(241, 23)
        Me.ComboBoxNameGamer.TabIndex = 0
        '
        'BtnStats
        '
        Me.BtnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStats.Location = New System.Drawing.Point(68, 213)
        Me.BtnStats.Name = "BtnStats"
        Me.BtnStats.Size = New System.Drawing.Size(75, 30)
        Me.BtnStats.TabIndex = 1
        Me.BtnStats.Text = "Stats"
        Me.BtnStats.UseVisualStyleBackColor = True
        '
        'BtnNewGame
        '
        Me.BtnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewGame.Location = New System.Drawing.Point(136, 165)
        Me.BtnNewGame.Name = "BtnNewGame"
        Me.BtnNewGame.Size = New System.Drawing.Size(111, 30)
        Me.BtnNewGame.TabIndex = 2
        Me.BtnNewGame.Text = "Jouer !"
        Me.BtnNewGame.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(234, 213)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 30)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Quitter"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LabelNameGamer
        '
        Me.LabelNameGamer.AutoSize = True
        Me.LabelNameGamer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameGamer.Location = New System.Drawing.Point(32, 54)
        Me.LabelNameGamer.Name = "LabelNameGamer"
        Me.LabelNameGamer.Size = New System.Drawing.Size(217, 15)
        Me.LabelNameGamer.TabIndex = 4
        Me.LabelNameGamer.Text = "Choisissez ou entrez un pseudonyme :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(359, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemSettings})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "Options"
        '
        'ToolStripMenuItemSettings
        '
        Me.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings"
        Me.ToolStripMenuItemSettings.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItemSettings.Text = "Paramètres"
        '
        'ErrorProviderLauncher
        '
        Me.ErrorProviderLauncher.ContainerControl = Me
        '
        'startForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(359, 272)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelNameGamer)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnNewGame)
        Me.Controls.Add(Me.BtnStats)
        Me.Controls.Add(Me.ComboBoxNameGamer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "startForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le démineur :o"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProviderLauncher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxNameGamer As ComboBox
    Friend WithEvents BtnStats As Button
    Friend WithEvents BtnNewGame As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LabelNameGamer As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSettings As ToolStripMenuItem
    Friend WithEvents ErrorProviderLauncher As ErrorProvider
End Class
