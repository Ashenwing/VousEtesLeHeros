<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pont
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pont))
        Me.LblIntro = New System.Windows.Forms.Label()
        Me.LBObjets = New System.Windows.Forms.ListBox()
        Me.BtnSoumettre = New System.Windows.Forms.Button()
        Me.LblRefus = New System.Windows.Forms.Label()
        Me.BtnVictoire = New System.Windows.Forms.Button()
        Me.LblVictoire = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIntro
        '
        Me.LblIntro.BackColor = System.Drawing.Color.Olive
        Me.LblIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntro.Location = New System.Drawing.Point(12, 9)
        Me.LblIntro.Name = "LblIntro"
        Me.LblIntro.Size = New System.Drawing.Size(447, 216)
        Me.LblIntro.TabIndex = 0
        Me.LblIntro.Text = resources.GetString("LblIntro.Text")
        '
        'LBObjets
        '
        Me.LBObjets.BackColor = System.Drawing.Color.Olive
        Me.LBObjets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBObjets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBObjets.FormattingEnabled = True
        Me.LBObjets.ItemHeight = 15
        Me.LBObjets.Items.AddRange(New Object() {"Épée & Sac à dos", "Armure & Bouclier", "Arc à flèches & Carquois", "Runes magiques & potions"})
        Me.LBObjets.Location = New System.Drawing.Point(12, 239)
        Me.LBObjets.Name = "LBObjets"
        Me.LBObjets.Size = New System.Drawing.Size(308, 62)
        Me.LBObjets.TabIndex = 2
        '
        'BtnSoumettre
        '
        Me.BtnSoumettre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSoumettre.Location = New System.Drawing.Point(16, 309)
        Me.BtnSoumettre.Name = "BtnSoumettre"
        Me.BtnSoumettre.Size = New System.Drawing.Size(189, 35)
        Me.BtnSoumettre.TabIndex = 3
        Me.BtnSoumettre.Text = "Valider mon choix"
        Me.BtnSoumettre.UseVisualStyleBackColor = True
        '
        'LblRefus
        '
        Me.LblRefus.BackColor = System.Drawing.Color.Olive
        Me.LblRefus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRefus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRefus.Location = New System.Drawing.Point(496, 264)
        Me.LblRefus.Name = "LblRefus"
        Me.LblRefus.Size = New System.Drawing.Size(262, 71)
        Me.LblRefus.TabIndex = 4
        Me.LblRefus.Text = "Ces objets me sont vitales, je ne peux pas m'en débarasser. De plus, ils ne sont " & _
    "pas assez lourd. Je dois trouver la combinaison parfaite."
        '
        'BtnVictoire
        '
        Me.BtnVictoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVictoire.Location = New System.Drawing.Point(301, 228)
        Me.BtnVictoire.Name = "BtnVictoire"
        Me.BtnVictoire.Size = New System.Drawing.Size(187, 33)
        Me.BtnVictoire.TabIndex = 5
        Me.BtnVictoire.Text = "Aller vers la clairière!"
        Me.BtnVictoire.UseVisualStyleBackColor = True
        Me.BtnVictoire.Visible = False
        '
        'LblVictoire
        '
        Me.LblVictoire.AutoSize = True
        Me.LblVictoire.BackColor = System.Drawing.Color.Olive
        Me.LblVictoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVictoire.Location = New System.Drawing.Point(96, 38)
        Me.LblVictoire.Name = "LblVictoire"
        Me.LblVictoire.Size = New System.Drawing.Size(641, 120)
        Me.LblVictoire.TabIndex = 6
        Me.LblVictoire.Text = resources.GetString("LblVictoire.Text")
        Me.LblVictoire.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TuEsLeChampion.My.Resources.Resources.guard
        Me.PictureBox1.Location = New System.Drawing.Point(465, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 249)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Pont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(848, 356)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnVictoire)
        Me.Controls.Add(Me.LblRefus)
        Me.Controls.Add(Me.BtnSoumettre)
        Me.Controls.Add(Me.LBObjets)
        Me.Controls.Add(Me.LblIntro)
        Me.Controls.Add(Me.LblVictoire)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Pont"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tu es le Champion - Le vieux pont"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblIntro As System.Windows.Forms.Label
    Friend WithEvents LBObjets As System.Windows.Forms.ListBox
    Friend WithEvents BtnSoumettre As System.Windows.Forms.Button
    Friend WithEvents LblRefus As System.Windows.Forms.Label
    Friend WithEvents BtnVictoire As System.Windows.Forms.Button
    Friend WithEvents LblVictoire As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
