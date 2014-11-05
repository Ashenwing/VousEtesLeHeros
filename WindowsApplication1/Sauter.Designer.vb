<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sauter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sauter))
        Me.LblIntro = New System.Windows.Forms.Label()
        Me.RBSaute = New System.Windows.Forms.RadioButton()
        Me.RBPont = New System.Windows.Forms.RadioButton()
        Me.BtnSoumettre = New System.Windows.Forms.Button()
        Me.BtnCommencer = New System.Windows.Forms.Button()
        Me.BtnGrimpe1 = New System.Windows.Forms.Button()
        Me.TimeSaute1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnGrimpe2 = New System.Windows.Forms.Button()
        Me.TimeSaute2 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnGrimpe3 = New System.Windows.Forms.Button()
        Me.TimeSaute3 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnGrimpe4 = New System.Windows.Forms.Button()
        Me.TimeSaute4 = New System.Windows.Forms.Timer(Me.components)
        Me.LblFail = New System.Windows.Forms.Label()
        Me.BtnFail = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblVictoire = New System.Windows.Forms.Label()
        Me.BtnVictoire = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIntro
        '
        Me.LblIntro.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntro.Location = New System.Drawing.Point(12, 9)
        Me.LblIntro.Name = "LblIntro"
        Me.LblIntro.Size = New System.Drawing.Size(427, 82)
        Me.LblIntro.TabIndex = 1
        Me.LblIntro.Text = resources.GetString("LblIntro.Text")
        '
        'RBSaute
        '
        Me.RBSaute.AutoSize = True
        Me.RBSaute.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBSaute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBSaute.Location = New System.Drawing.Point(51, 103)
        Me.RBSaute.Name = "RBSaute"
        Me.RBSaute.Size = New System.Drawing.Size(217, 19)
        Me.RBSaute.TabIndex = 2
        Me.RBSaute.TabStop = True
        Me.RBSaute.Text = "Sauter par dessus la crevasse"
        Me.RBSaute.UseVisualStyleBackColor = False
        '
        'RBPont
        '
        Me.RBPont.AutoSize = True
        Me.RBPont.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBPont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBPont.Location = New System.Drawing.Point(51, 187)
        Me.RBPont.Name = "RBPont"
        Me.RBPont.Size = New System.Drawing.Size(339, 19)
        Me.RBPont.TabIndex = 3
        Me.RBPont.TabStop = True
        Me.RBPont.Text = "Prendre le vieux pont (Il est en très mauvais état)"
        Me.RBPont.UseVisualStyleBackColor = False
        '
        'BtnSoumettre
        '
        Me.BtnSoumettre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSoumettre.Location = New System.Drawing.Point(166, 266)
        Me.BtnSoumettre.Name = "BtnSoumettre"
        Me.BtnSoumettre.Size = New System.Drawing.Size(169, 36)
        Me.BtnSoumettre.TabIndex = 4
        Me.BtnSoumettre.Text = "Choisir"
        Me.BtnSoumettre.UseVisualStyleBackColor = True
        '
        'BtnCommencer
        '
        Me.BtnCommencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCommencer.Location = New System.Drawing.Point(289, 146)
        Me.BtnCommencer.Name = "BtnCommencer"
        Me.BtnCommencer.Size = New System.Drawing.Size(101, 58)
        Me.BtnCommencer.TabIndex = 6
        Me.BtnCommencer.Text = "Commencer à grimper"
        Me.BtnCommencer.UseVisualStyleBackColor = True
        Me.BtnCommencer.Visible = False
        '
        'BtnGrimpe1
        '
        Me.BtnGrimpe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrimpe1.Location = New System.Drawing.Point(3, 94)
        Me.BtnGrimpe1.Name = "BtnGrimpe1"
        Me.BtnGrimpe1.Size = New System.Drawing.Size(81, 58)
        Me.BtnGrimpe1.TabIndex = 7
        Me.BtnGrimpe1.Text = "Grimper !"
        Me.BtnGrimpe1.UseVisualStyleBackColor = True
        Me.BtnGrimpe1.Visible = False
        '
        'TimeSaute1
        '
        Me.TimeSaute1.Interval = 1000
        '
        'BtnGrimpe2
        '
        Me.BtnGrimpe2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrimpe2.Location = New System.Drawing.Point(320, 83)
        Me.BtnGrimpe2.Name = "BtnGrimpe2"
        Me.BtnGrimpe2.Size = New System.Drawing.Size(91, 57)
        Me.BtnGrimpe2.TabIndex = 8
        Me.BtnGrimpe2.Text = "Grimper !"
        Me.BtnGrimpe2.UseVisualStyleBackColor = True
        Me.BtnGrimpe2.Visible = False
        '
        'TimeSaute2
        '
        Me.TimeSaute2.Interval = 800
        '
        'BtnGrimpe3
        '
        Me.BtnGrimpe3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrimpe3.Location = New System.Drawing.Point(3, 277)
        Me.BtnGrimpe3.Name = "BtnGrimpe3"
        Me.BtnGrimpe3.Size = New System.Drawing.Size(81, 58)
        Me.BtnGrimpe3.TabIndex = 9
        Me.BtnGrimpe3.Text = "Grimper !"
        Me.BtnGrimpe3.UseVisualStyleBackColor = True
        Me.BtnGrimpe3.Visible = False
        '
        'TimeSaute3
        '
        Me.TimeSaute3.Interval = 750
        '
        'BtnGrimpe4
        '
        Me.BtnGrimpe4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrimpe4.Location = New System.Drawing.Point(587, 266)
        Me.BtnGrimpe4.Name = "BtnGrimpe4"
        Me.BtnGrimpe4.Size = New System.Drawing.Size(81, 58)
        Me.BtnGrimpe4.TabIndex = 10
        Me.BtnGrimpe4.Text = "Grimper !"
        Me.BtnGrimpe4.UseVisualStyleBackColor = True
        Me.BtnGrimpe4.Visible = False
        '
        'TimeSaute4
        '
        Me.TimeSaute4.Interval = 750
        '
        'LblFail
        '
        Me.LblFail.AutoSize = True
        Me.LblFail.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblFail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFail.Location = New System.Drawing.Point(12, 258)
        Me.LblFail.Name = "LblFail"
        Me.LblFail.Size = New System.Drawing.Size(656, 17)
        Me.LblFail.TabIndex = 11
        Me.LblFail.Text = "Vous n'avez pas grimpé à temps ! Vous devez vous dépêcher à grimper si vous ne vo" & _
    "ulez pas tomber."
        Me.LblFail.Visible = False
        '
        'BtnFail
        '
        Me.BtnFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFail.Location = New System.Drawing.Point(93, 146)
        Me.BtnFail.Name = "BtnFail"
        Me.BtnFail.Size = New System.Drawing.Size(112, 71)
        Me.BtnFail.TabIndex = 12
        Me.BtnFail.Text = "Réessayer !"
        Me.BtnFail.UseVisualStyleBackColor = True
        Me.BtnFail.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(459, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(209, 196)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'LblVictoire
        '
        Me.LblVictoire.AutoSize = True
        Me.LblVictoire.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.LblVictoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVictoire.Location = New System.Drawing.Point(32, 17)
        Me.LblVictoire.Name = "LblVictoire"
        Me.LblVictoire.Size = New System.Drawing.Size(584, 105)
        Me.LblVictoire.TabIndex = 13
        Me.LblVictoire.Text = resources.GetString("LblVictoire.Text")
        Me.LblVictoire.Visible = False
        '
        'BtnVictoire
        '
        Me.BtnVictoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVictoire.Location = New System.Drawing.Point(275, 214)
        Me.BtnVictoire.Name = "BtnVictoire"
        Me.BtnVictoire.Size = New System.Drawing.Size(136, 23)
        Me.BtnVictoire.TabIndex = 14
        Me.BtnVictoire.Text = "Aller vers l'objet!"
        Me.BtnVictoire.UseVisualStyleBackColor = True
        Me.BtnVictoire.Visible = False
        '
        'Sauter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 336)
        Me.Controls.Add(Me.BtnVictoire)
        Me.Controls.Add(Me.BtnGrimpe4)
        Me.Controls.Add(Me.BtnGrimpe3)
        Me.Controls.Add(Me.BtnGrimpe2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblIntro)
        Me.Controls.Add(Me.BtnGrimpe1)
        Me.Controls.Add(Me.BtnCommencer)
        Me.Controls.Add(Me.BtnFail)
        Me.Controls.Add(Me.BtnSoumettre)
        Me.Controls.Add(Me.RBPont)
        Me.Controls.Add(Me.RBSaute)
        Me.Controls.Add(Me.LblFail)
        Me.Controls.Add(Me.LblVictoire)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Sauter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tu es le Champion - Crevasse"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblIntro As System.Windows.Forms.Label
    Friend WithEvents RBSaute As System.Windows.Forms.RadioButton
    Friend WithEvents RBPont As System.Windows.Forms.RadioButton
    Friend WithEvents BtnSoumettre As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCommencer As System.Windows.Forms.Button
    Friend WithEvents BtnGrimpe1 As System.Windows.Forms.Button
    Friend WithEvents TimeSaute1 As System.Windows.Forms.Timer
    Friend WithEvents BtnGrimpe2 As System.Windows.Forms.Button
    Friend WithEvents TimeSaute2 As System.Windows.Forms.Timer
    Friend WithEvents BtnGrimpe3 As System.Windows.Forms.Button
    Friend WithEvents TimeSaute3 As System.Windows.Forms.Timer
    Friend WithEvents BtnGrimpe4 As System.Windows.Forms.Button
    Friend WithEvents TimeSaute4 As System.Windows.Forms.Timer
    Friend WithEvents LblFail As System.Windows.Forms.Label
    Friend WithEvents BtnFail As System.Windows.Forms.Button
    Friend WithEvents LblVictoire As System.Windows.Forms.Label
    Friend WithEvents BtnVictoire As System.Windows.Forms.Button

End Class
