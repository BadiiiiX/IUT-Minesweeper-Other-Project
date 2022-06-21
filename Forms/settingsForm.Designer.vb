<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settingsForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settingsForm))
        Me.lColumns = New System.Windows.Forms.Label()
        Me.lLines = New System.Windows.Forms.Label()
        Me.lMines = New System.Windows.Forms.Label()
        Me.btnPass = New System.Windows.Forms.Button()
        Me.tbColumns = New System.Windows.Forms.TextBox()
        Me.tbLines = New System.Windows.Forms.TextBox()
        Me.tbMines = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ErrorProviderSettings = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tbTime = New System.Windows.Forms.TextBox()
        Me.lTime = New System.Windows.Forms.Label()
        Me.cbTime = New System.Windows.Forms.CheckBox()
        Me.FolderBrowserDialogPathXml = New System.Windows.Forms.FolderBrowserDialog()
        Me.lTheme = New System.Windows.Forms.Label()
        Me.cbTheme = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProviderSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lColumns
        '
        Me.lColumns.AutoSize = True
        Me.lColumns.Location = New System.Drawing.Point(43, 10)
        Me.lColumns.Name = "lColumns"
        Me.lColumns.Size = New System.Drawing.Size(106, 13)
        Me.lColumns.TabIndex = 0
        Me.lColumns.Text = "Nombre de Colonnes"
        '
        'lLines
        '
        Me.lLines.AutoSize = True
        Me.lLines.Location = New System.Drawing.Point(177, 10)
        Me.lLines.Name = "lLines"
        Me.lLines.Size = New System.Drawing.Size(89, 13)
        Me.lLines.TabIndex = 1
        Me.lLines.Text = "Nombre de lignes"
        '
        'lMines
        '
        Me.lMines.AutoSize = True
        Me.lMines.Location = New System.Drawing.Point(300, 10)
        Me.lMines.Name = "lMines"
        Me.lMines.Size = New System.Drawing.Size(89, 13)
        Me.lMines.TabIndex = 2
        Me.lMines.Text = "Nombre de mines"
        '
        'btnPass
        '
        Me.btnPass.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPass.Location = New System.Drawing.Point(232, 169)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(75, 23)
        Me.btnPass.TabIndex = 3
        Me.btnPass.Text = "Valider"
        Me.btnPass.UseVisualStyleBackColor = True
        '
        'tbColumns
        '
        Me.tbColumns.Location = New System.Drawing.Point(66, 30)
        Me.tbColumns.Name = "tbColumns"
        Me.tbColumns.Size = New System.Drawing.Size(51, 20)
        Me.tbColumns.TabIndex = 4
        '
        'tbLines
        '
        Me.tbLines.Location = New System.Drawing.Point(191, 30)
        Me.tbLines.Name = "tbLines"
        Me.tbLines.Size = New System.Drawing.Size(51, 20)
        Me.tbLines.TabIndex = 5
        '
        'tbMines
        '
        Me.tbMines.Location = New System.Drawing.Point(318, 30)
        Me.tbMines.Name = "tbMines"
        Me.tbMines.Size = New System.Drawing.Size(51, 20)
        Me.tbMines.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(125, 169)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ErrorProviderSettings
        '
        Me.ErrorProviderSettings.ContainerControl = Me
        '
        'tbTime
        '
        Me.tbTime.Location = New System.Drawing.Point(154, 84)
        Me.tbTime.Name = "tbTime"
        Me.tbTime.Size = New System.Drawing.Size(46, 20)
        Me.tbTime.TabIndex = 10
        '
        'lTime
        '
        Me.lTime.AutoSize = True
        Me.lTime.Location = New System.Drawing.Point(63, 87)
        Me.lTime.Name = "lTime"
        Me.lTime.Size = New System.Drawing.Size(77, 13)
        Me.lTime.TabIndex = 9
        Me.lTime.Text = "Temps de jeu :"
        '
        'cbTime
        '
        Me.cbTime.AutoSize = True
        Me.cbTime.Location = New System.Drawing.Point(232, 87)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.Size = New System.Drawing.Size(117, 17)
        Me.cbTime.TabIndex = 11
        Me.cbTime.Text = "Activer le compteur"
        Me.cbTime.UseVisualStyleBackColor = True
        '
        'lTheme
        '
        Me.lTheme.AutoSize = True
        Me.lTheme.Location = New System.Drawing.Point(63, 121)
        Me.lTheme.Name = "lTheme"
        Me.lTheme.Size = New System.Drawing.Size(46, 13)
        Me.lTheme.TabIndex = 15
        Me.lTheme.Text = "Thème :"
        '
        'cbTheme
        '
        Me.cbTheme.FormattingEnabled = True
        Me.cbTheme.Location = New System.Drawing.Point(154, 118)
        Me.cbTheme.Name = "cbTheme"
        Me.cbTheme.Size = New System.Drawing.Size(117, 21)
        Me.cbTheme.TabIndex = 16
        '
        'FormSettings
        '
        Me.AcceptButton = Me.btnPass
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(417, 230)
        Me.Controls.Add(Me.cbTheme)
        Me.Controls.Add(Me.lTheme)
        Me.Controls.Add(Me.cbTime)
        Me.Controls.Add(Me.tbTime)
        Me.Controls.Add(Me.lTime)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.tbMines)
        Me.Controls.Add(Me.tbLines)
        Me.Controls.Add(Me.tbColumns)
        Me.Controls.Add(Me.btnPass)
        Me.Controls.Add(Me.lMines)
        Me.Controls.Add(Me.lLines)
        Me.Controls.Add(Me.lColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres du Jeu"
        CType(Me.ErrorProviderSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lColumns As Label
    Friend WithEvents lLines As Label
    Friend WithEvents lMines As Label
    Friend WithEvents btnPass As Button
    Friend WithEvents tbColumns As TextBox
    Friend WithEvents tbLines As TextBox
    Friend WithEvents tbMines As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents ErrorProviderSettings As ErrorProvider
    Friend WithEvents tbTime As TextBox
    Friend WithEvents lTime As Label
    Friend WithEvents cbTime As CheckBox
    Friend WithEvents FolderBrowserDialogPathXml As FolderBrowserDialog
    Friend WithEvents cbTheme As ComboBox
    Friend WithEvents lTheme As Label
End Class
