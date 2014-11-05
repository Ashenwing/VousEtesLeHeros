<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Magicien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Magicien))
        Me.LblIntro = New System.Windows.Forms.Label()
        Me.LbLChiffre2 = New System.Windows.Forms.Label()
        Me.LbLChiffre3 = New System.Windows.Forms.Label()
        Me.LbLChiffre4 = New System.Windows.Forms.Label()
        Me.LbLChiffre5 = New System.Windows.Forms.Label()
        Me.LbLChiffre1 = New System.Windows.Forms.Label()
        Me.BtnSoumettre = New System.Windows.Forms.Button()
        Me.TBchiffre1 = New System.Windows.Forms.TextBox()
        Me.TBChiffre2 = New System.Windows.Forms.TextBox()
        Me.PanelQuestions = New System.Windows.Forms.Panel()
        Me.Lblquestion2 = New System.Windows.Forms.Label()
        Me.BtnAttaque = New System.Windows.Forms.Button()
        Me.PanelLink = New System.Windows.Forms.Panel()
        Me.PicLink = New System.Windows.Forms.PictureBox()
        Me.BtnKill = New System.Windows.Forms.Button()
        Me.TimeLink = New System.Windows.Forms.Timer(Me.components)
        Me.Timelink2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timelink3 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLink4 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnVictoire = New System.Windows.Forms.Button()
        Me.LblVictoire = New System.Windows.Forms.Label()
        Me.BtnAvancer = New System.Windows.Forms.Button()
        Me.CBMusic = New System.Windows.Forms.CheckBox()
        Me.TimeAttaque = New System.Windows.Forms.Timer(Me.components)
        Me.LblAie = New System.Windows.Forms.Label()
        Me.PicGanon2 = New System.Windows.Forms.PictureBox()
        Me.PicGanon = New System.Windows.Forms.PictureBox()
        Me.PicGandalf = New System.Windows.Forms.PictureBox()
        Me.PicLink2 = New System.Windows.Forms.PictureBox()
        Me.PicLinkWin = New System.Windows.Forms.PictureBox()
        Me.LblFalse = New System.Windows.Forms.Label()
        Me.imageLoad = New System.Windows.Forms.Timer(Me.components)
        Me.PanelQuestions.SuspendLayout()
        Me.PanelLink.SuspendLayout()
        CType(Me.PicLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGanon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGanon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGandalf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLink2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLinkWin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIntro
        '
        Me.LblIntro.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblIntro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntro.ForeColor = System.Drawing.Color.Black
        Me.LblIntro.Location = New System.Drawing.Point(0, 2)
        Me.LblIntro.Name = "LblIntro"
        Me.LblIntro.Size = New System.Drawing.Size(429, 198)
        Me.LblIntro.TabIndex = 0
        Me.LblIntro.Text = resources.GetString("LblIntro.Text")
        Me.LblIntro.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LbLChiffre2
        '
        Me.LbLChiffre2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbLChiffre2.Font = New System.Drawing.Font("Kristen ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLChiffre2.Location = New System.Drawing.Point(74, 3)
        Me.LbLChiffre2.Name = "LbLChiffre2"
        Me.LbLChiffre2.Size = New System.Drawing.Size(64, 44)
        Me.LbLChiffre2.TabIndex = 1
        Me.LbLChiffre2.Text = "0"
        Me.LbLChiffre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbLChiffre3
        '
        Me.LbLChiffre3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbLChiffre3.Font = New System.Drawing.Font("Kristen ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLChiffre3.Location = New System.Drawing.Point(144, 3)
        Me.LbLChiffre3.Name = "LbLChiffre3"
        Me.LbLChiffre3.Size = New System.Drawing.Size(64, 44)
        Me.LbLChiffre3.TabIndex = 2
        Me.LbLChiffre3.Text = "0"
        Me.LbLChiffre3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbLChiffre4
        '
        Me.LbLChiffre4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbLChiffre4.Font = New System.Drawing.Font("Kristen ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLChiffre4.Location = New System.Drawing.Point(214, 3)
        Me.LbLChiffre4.Name = "LbLChiffre4"
        Me.LbLChiffre4.Size = New System.Drawing.Size(64, 44)
        Me.LbLChiffre4.TabIndex = 3
        Me.LbLChiffre4.Text = "0"
        Me.LbLChiffre4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbLChiffre5
        '
        Me.LbLChiffre5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbLChiffre5.Font = New System.Drawing.Font("Kristen ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLChiffre5.Location = New System.Drawing.Point(284, 3)
        Me.LbLChiffre5.Name = "LbLChiffre5"
        Me.LbLChiffre5.Size = New System.Drawing.Size(64, 44)
        Me.LbLChiffre5.TabIndex = 4
        Me.LbLChiffre5.Text = "0"
        Me.LbLChiffre5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbLChiffre1
        '
        Me.LbLChiffre1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbLChiffre1.Font = New System.Drawing.Font("Kristen ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLChiffre1.Location = New System.Drawing.Point(4, 3)
        Me.LbLChiffre1.Name = "LbLChiffre1"
        Me.LbLChiffre1.Size = New System.Drawing.Size(64, 44)
        Me.LbLChiffre1.TabIndex = 9
        Me.LbLChiffre1.Text = "0"
        Me.LbLChiffre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSoumettre
        '
        Me.BtnSoumettre.Location = New System.Drawing.Point(12, 248)
        Me.BtnSoumettre.Name = "BtnSoumettre"
        Me.BtnSoumettre.Size = New System.Drawing.Size(100, 27)
        Me.BtnSoumettre.TabIndex = 11
        Me.BtnSoumettre.Text = "Deviner!"
        Me.BtnSoumettre.UseVisualStyleBackColor = True
        '
        'TBchiffre1
        '
        Me.TBchiffre1.Location = New System.Drawing.Point(12, 210)
        Me.TBchiffre1.Name = "TBchiffre1"
        Me.TBchiffre1.Size = New System.Drawing.Size(36, 20)
        Me.TBchiffre1.TabIndex = 12
        '
        'TBChiffre2
        '
        Me.TBChiffre2.Location = New System.Drawing.Point(76, 210)
        Me.TBChiffre2.Name = "TBChiffre2"
        Me.TBChiffre2.Size = New System.Drawing.Size(36, 20)
        Me.TBChiffre2.TabIndex = 13
        '
        'PanelQuestions
        '
        Me.PanelQuestions.Controls.Add(Me.LbLChiffre1)
        Me.PanelQuestions.Controls.Add(Me.LbLChiffre5)
        Me.PanelQuestions.Controls.Add(Me.LbLChiffre4)
        Me.PanelQuestions.Controls.Add(Me.LbLChiffre3)
        Me.PanelQuestions.Controls.Add(Me.LbLChiffre2)
        Me.PanelQuestions.Location = New System.Drawing.Point(203, 206)
        Me.PanelQuestions.Name = "PanelQuestions"
        Me.PanelQuestions.Size = New System.Drawing.Size(356, 50)
        Me.PanelQuestions.TabIndex = 16
        '
        'Lblquestion2
        '
        Me.Lblquestion2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Lblquestion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblquestion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblquestion2.ForeColor = System.Drawing.Color.Black
        Me.Lblquestion2.Location = New System.Drawing.Point(6, 2)
        Me.Lblquestion2.Name = "Lblquestion2"
        Me.Lblquestion2.Size = New System.Drawing.Size(564, 205)
        Me.Lblquestion2.TabIndex = 17
        Me.Lblquestion2.Text = resources.GetString("Lblquestion2.Text")
        Me.Lblquestion2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lblquestion2.Visible = False
        '
        'BtnAttaque
        '
        Me.BtnAttaque.Location = New System.Drawing.Point(13, 98)
        Me.BtnAttaque.Name = "BtnAttaque"
        Me.BtnAttaque.Size = New System.Drawing.Size(131, 32)
        Me.BtnAttaque.TabIndex = 18
        Me.BtnAttaque.Text = "Avance pour attaquer!"
        Me.BtnAttaque.UseVisualStyleBackColor = True
        '
        'PanelLink
        '
        Me.PanelLink.BackColor = System.Drawing.Color.Transparent
        Me.PanelLink.Controls.Add(Me.BtnAttaque)
        Me.PanelLink.Controls.Add(Me.PicLink)
        Me.PanelLink.Location = New System.Drawing.Point(0, 282)
        Me.PanelLink.Name = "PanelLink"
        Me.PanelLink.Size = New System.Drawing.Size(159, 130)
        Me.PanelLink.TabIndex = 19
        Me.PanelLink.Visible = False
        '
        'PicLink
        '
        Me.PicLink.BackColor = System.Drawing.Color.Transparent
        Me.PicLink.Image = CType(resources.GetObject("PicLink.Image"), System.Drawing.Image)
        Me.PicLink.Location = New System.Drawing.Point(3, 3)
        Me.PicLink.Name = "PicLink"
        Me.PicLink.Size = New System.Drawing.Size(153, 127)
        Me.PicLink.TabIndex = 14
        Me.PicLink.TabStop = False
        '
        'BtnKill
        '
        Me.BtnKill.Location = New System.Drawing.Point(180, 359)
        Me.BtnKill.Name = "BtnKill"
        Me.BtnKill.Size = New System.Drawing.Size(144, 53)
        Me.BtnKill.TabIndex = 21
        Me.BtnKill.Text = "Finit-le!"
        Me.BtnKill.UseVisualStyleBackColor = True
        Me.BtnKill.Visible = False
        '
        'TimeLink
        '
        Me.TimeLink.Interval = 1
        '
        'Timelink2
        '
        Me.Timelink2.Interval = 1
        '
        'Timelink3
        '
        Me.Timelink3.Interval = 1
        '
        'TimeLink4
        '
        Me.TimeLink4.Interval = 18000
        '
        'BtnVictoire
        '
        Me.BtnVictoire.Location = New System.Drawing.Point(221, 9)
        Me.BtnVictoire.Name = "BtnVictoire"
        Me.BtnVictoire.Size = New System.Drawing.Size(131, 31)
        Me.BtnVictoire.TabIndex = 24
        Me.BtnVictoire.Text = "Victoire!!"
        Me.BtnVictoire.UseVisualStyleBackColor = True
        Me.BtnVictoire.Visible = False
        '
        'LblVictoire
        '
        Me.LblVictoire.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.LblVictoire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblVictoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVictoire.Location = New System.Drawing.Point(2, -5)
        Me.LblVictoire.Name = "LblVictoire"
        Me.LblVictoire.Size = New System.Drawing.Size(579, 250)
        Me.LblVictoire.TabIndex = 25
        Me.LblVictoire.Text = resources.GetString("LblVictoire.Text")
        Me.LblVictoire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblVictoire.Visible = False
        '
        'BtnAvancer
        '
        Me.BtnAvancer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAvancer.Location = New System.Drawing.Point(180, 319)
        Me.BtnAvancer.Name = "BtnAvancer"
        Me.BtnAvancer.Size = New System.Drawing.Size(193, 34)
        Me.BtnAvancer.TabIndex = 26
        Me.BtnAvancer.Text = "Aller dans le chemin"
        Me.BtnAvancer.UseVisualStyleBackColor = True
        Me.BtnAvancer.Visible = False
        '
        'CBMusic
        '
        Me.CBMusic.AutoSize = True
        Me.CBMusic.Location = New System.Drawing.Point(5, 423)
        Me.CBMusic.Name = "CBMusic"
        Me.CBMusic.Size = New System.Drawing.Size(68, 17)
        Me.CBMusic.TabIndex = 27
        Me.CBMusic.Text = "CBMusic"
        Me.CBMusic.UseVisualStyleBackColor = True
        Me.CBMusic.Visible = False
        '
        'TimeAttaque
        '
        Me.TimeAttaque.Interval = 1500
        '
        'LblAie
        '
        Me.LblAie.AutoSize = True
        Me.LblAie.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.LblAie.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblAie.Location = New System.Drawing.Point(475, 178)
        Me.LblAie.Name = "LblAie"
        Me.LblAie.Size = New System.Drawing.Size(80, 18)
        Me.LblAie.TabIndex = 28
        Me.LblAie.Text = "Je t'ai eu!"
        Me.LblAie.Visible = False
        '
        'PicGanon2
        '
        Me.PicGanon2.BackColor = System.Drawing.Color.Transparent
        Me.PicGanon2.Image = Global.TuEsLeChampion.My.Resources.Resources.Ganon2
        Me.PicGanon2.Location = New System.Drawing.Point(330, 301)
        Me.PicGanon2.Name = "PicGanon2"
        Me.PicGanon2.Size = New System.Drawing.Size(240, 120)
        Me.PicGanon2.TabIndex = 22
        Me.PicGanon2.TabStop = False
        Me.PicGanon2.Visible = False
        '
        'PicGanon
        '
        Me.PicGanon.BackColor = System.Drawing.Color.Transparent
        Me.PicGanon.Image = Global.TuEsLeChampion.My.Resources.Resources.Ganon1
        Me.PicGanon.Location = New System.Drawing.Point(401, 218)
        Me.PicGanon.Name = "PicGanon"
        Me.PicGanon.Size = New System.Drawing.Size(169, 194)
        Me.PicGanon.TabIndex = 15
        Me.PicGanon.TabStop = False
        Me.PicGanon.Visible = False
        '
        'PicGandalf
        '
        Me.PicGandalf.Image = CType(resources.GetObject("PicGandalf.Image"), System.Drawing.Image)
        Me.PicGandalf.Location = New System.Drawing.Point(340, 2)
        Me.PicGandalf.Name = "PicGandalf"
        Me.PicGandalf.Size = New System.Drawing.Size(230, 191)
        Me.PicGandalf.TabIndex = 5
        Me.PicGandalf.TabStop = False
        '
        'PicLink2
        '
        Me.PicLink2.BackColor = System.Drawing.Color.Transparent
        Me.PicLink2.Image = Global.TuEsLeChampion.My.Resources.Resources.oot_link12
        Me.PicLink2.Location = New System.Drawing.Point(0, 138)
        Me.PicLink2.Name = "PicLink2"
        Me.PicLink2.Size = New System.Drawing.Size(174, 274)
        Me.PicLink2.TabIndex = 20
        Me.PicLink2.TabStop = False
        Me.PicLink2.Visible = False
        '
        'PicLinkWin
        '
        Me.PicLinkWin.BackColor = System.Drawing.Color.Transparent
        Me.PicLinkWin.Image = Global.TuEsLeChampion.My.Resources.Resources.VictoryLink_
        Me.PicLinkWin.Location = New System.Drawing.Point(151, 133)
        Me.PicLinkWin.Name = "PicLinkWin"
        Me.PicLinkWin.Size = New System.Drawing.Size(173, 288)
        Me.PicLinkWin.TabIndex = 23
        Me.PicLinkWin.TabStop = False
        Me.PicLinkWin.Visible = False
        '
        'LblFalse
        '
        Me.LblFalse.AutoSize = True
        Me.LblFalse.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.LblFalse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblFalse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFalse.Location = New System.Drawing.Point(13, 179)
        Me.LblFalse.Name = "LblFalse"
        Me.LblFalse.Size = New System.Drawing.Size(164, 17)
        Me.LblFalse.TabIndex = 29
        Me.LblFalse.Text = "Non! Mauvaise réponse!"
        Me.LblFalse.Visible = False
        '
        'imageLoad
        '
        Me.imageLoad.Interval = 6000
        '
        'Magicien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TuEsLeChampion.My.Resources.Resources.DSCN0451
        Me.ClientSize = New System.Drawing.Size(572, 430)
        Me.Controls.Add(Me.LblFalse)
        Me.Controls.Add(Me.LblIntro)
        Me.Controls.Add(Me.PicGanon2)
        Me.Controls.Add(Me.PanelQuestions)
        Me.Controls.Add(Me.PicGanon)
        Me.Controls.Add(Me.LblAie)
        Me.Controls.Add(Me.CBMusic)
        Me.Controls.Add(Me.PanelLink)
        Me.Controls.Add(Me.BtnKill)
        Me.Controls.Add(Me.TBChiffre2)
        Me.Controls.Add(Me.TBchiffre1)
        Me.Controls.Add(Me.BtnSoumettre)
        Me.Controls.Add(Me.PicLink2)
        Me.Controls.Add(Me.BtnAvancer)
        Me.Controls.Add(Me.PicLinkWin)
        Me.Controls.Add(Me.Lblquestion2)
        Me.Controls.Add(Me.LblVictoire)
        Me.Controls.Add(Me.PicGandalf)
        Me.Controls.Add(Me.BtnVictoire)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Magicien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tu es le Champion - Avec la caravane"
        Me.TransparencyKey = System.Drawing.Color.DarkMagenta
        Me.PanelQuestions.ResumeLayout(False)
        Me.PanelLink.ResumeLayout(False)
        CType(Me.PicLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGanon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGanon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGandalf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLink2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLinkWin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblIntro As System.Windows.Forms.Label
    Friend WithEvents LbLChiffre2 As System.Windows.Forms.Label
    Friend WithEvents LbLChiffre3 As System.Windows.Forms.Label
    Friend WithEvents LbLChiffre4 As System.Windows.Forms.Label
    Friend WithEvents LbLChiffre5 As System.Windows.Forms.Label
    Friend WithEvents PicGandalf As System.Windows.Forms.PictureBox
    Friend WithEvents LbLChiffre1 As System.Windows.Forms.Label
    Friend WithEvents BtnSoumettre As System.Windows.Forms.Button
    Friend WithEvents TBchiffre1 As System.Windows.Forms.TextBox
    Friend WithEvents TBChiffre2 As System.Windows.Forms.TextBox
    Friend WithEvents PicLink As System.Windows.Forms.PictureBox
    Friend WithEvents PicGanon As System.Windows.Forms.PictureBox
    Friend WithEvents PanelQuestions As System.Windows.Forms.Panel
    Friend WithEvents Lblquestion2 As System.Windows.Forms.Label
    Friend WithEvents BtnAttaque As System.Windows.Forms.Button
    Friend WithEvents PanelLink As System.Windows.Forms.Panel
    Friend WithEvents PicLink2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnKill As System.Windows.Forms.Button
    Friend WithEvents PicGanon2 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerLink As System.Windows.Forms.Timer
    Friend WithEvents TimerLink2 As System.Windows.Forms.Timer
    Friend WithEvents TimerLink3 As System.Windows.Forms.Timer
    Friend WithEvents TimeLink As System.Windows.Forms.Timer
    Friend WithEvents Timelink2 As System.Windows.Forms.Timer
    Friend WithEvents Timelink3 As System.Windows.Forms.Timer
    Friend WithEvents PicLinkWin As System.Windows.Forms.PictureBox
    Friend WithEvents TimeLink4 As System.Windows.Forms.Timer
    Friend WithEvents BtnVictoire As System.Windows.Forms.Button
    Friend WithEvents LblVictoire As System.Windows.Forms.Label
    Friend WithEvents BtnAvancer As System.Windows.Forms.Button
    Friend WithEvents CBMusic As System.Windows.Forms.CheckBox
    Friend WithEvents TimeAttaque As System.Windows.Forms.Timer
    Friend WithEvents LblAie As System.Windows.Forms.Label
    Friend WithEvents LblFalse As System.Windows.Forms.Label
    Friend WithEvents imageLoad As System.Windows.Forms.Timer
End Class
