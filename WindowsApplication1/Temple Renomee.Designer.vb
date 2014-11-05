<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Temple
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
        Me.LblIntro = New System.Windows.Forms.Label()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.TBTemple = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblIntro
        '
        Me.LblIntro.BackColor = System.Drawing.Color.Transparent
        Me.LblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntro.ForeColor = System.Drawing.Color.White
        Me.LblIntro.Location = New System.Drawing.Point(12, 9)
        Me.LblIntro.Name = "LblIntro"
        Me.LblIntro.Size = New System.Drawing.Size(451, 89)
        Me.LblIntro.TabIndex = 0
        Me.LblIntro.Text = "Ici est gravé à tout jamais les noms de ceux qui ont parcouru l'histoire, qui ont" & _
            " vaincu le mal, et ont sauvé notre monde." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Que votre flamme ne s'épuise jamais, " & _
            "vaillant héros."
        Me.LblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.Location = New System.Drawing.Point(180, 270)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(120, 43)
        Me.BtnQuitter.TabIndex = 3
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'TBTemple
        '
        Me.TBTemple.Location = New System.Drawing.Point(105, 106)
        Me.TBTemple.Multiline = True
        Me.TBTemple.Name = "TBTemple"
        Me.TBTemple.ReadOnly = True
        Me.TBTemple.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBTemple.Size = New System.Drawing.Size(269, 144)
        Me.TBTemple.TabIndex = 4
        '
        'Temple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TuEsLeChampion.My.Resources.Resources.BlackWall
        Me.ClientSize = New System.Drawing.Size(475, 325)
        Me.Controls.Add(Me.LblIntro)
        Me.Controls.Add(Me.TBTemple)
        Me.Controls.Add(Me.BtnQuitter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Temple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tu es le Champion - Temple"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblIntro As System.Windows.Forms.Label
    Friend WithEvents BtnQuitter As System.Windows.Forms.Button
    Friend WithEvents TBTemple As System.Windows.Forms.TextBox
End Class
