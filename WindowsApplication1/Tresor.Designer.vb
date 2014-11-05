<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tresor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tresor))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PbFlash = New System.Windows.Forms.PictureBox()
        Me.PBCle = New System.Windows.Forms.PictureBox()
        Me.TbTemple = New System.Windows.Forms.TextBox()
        Me.BtnOuvre = New System.Windows.Forms.Button()
        Me.PBCoffre = New System.Windows.Forms.PictureBox()
        Me.LblTemple = New System.Windows.Forms.Label()
        Me.LbLVide = New System.Windows.Forms.Label()
        Me.BtnSoumettre = New System.Windows.Forms.Button()
        Me.LblIntro = New System.Windows.Forms.Label()
        Me.TabCle = New System.Windows.Forms.TabPage()
        Me.PBPetiteCle = New System.Windows.Forms.PictureBox()
        Me.LblVictoire = New System.Windows.Forms.Label()
        Me.TimerKey = New System.Windows.Forms.Timer(Me.components)
        Me.Timeflash = New System.Windows.Forms.Timer(Me.components)
        Me.TimeSoumettre = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        CType(Me.PbFlash,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PBCle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PBCoffre,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabCle.SuspendLayout
        CType(Me.PBPetiteCle,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabCle)
        Me.TabControl1.Location = New System.Drawing.Point(1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(570, 417)
        Me.TabControl1.TabIndex = 2
        Me.TabControl1.Tag = "Hmm"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.BackgroundImage = Global.TuEsLeChampion.My.Resources.Resources.iTunes_lnk
        Me.TabPage1.Controls.Add(Me.PbFlash)
        Me.TabPage1.Controls.Add(Me.PBCle)
        Me.TabPage1.Controls.Add(Me.TbTemple)
        Me.TabPage1.Controls.Add(Me.BtnOuvre)
        Me.TabPage1.Controls.Add(Me.PBCoffre)
        Me.TabPage1.Controls.Add(Me.LblTemple)
        Me.TabPage1.Controls.Add(Me.LbLVide)
        Me.TabPage1.Controls.Add(Me.BtnSoumettre)
        Me.TabPage1.Controls.Add(Me.LblIntro)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(562, 391)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "."
        '
        'PbFlash
        '
        Me.PbFlash.Image = Global.TuEsLeChampion.My.Resources.Resources._3_bright_light_flash_lgn
        Me.PbFlash.Location = New System.Drawing.Point(-4, 0)
        Me.PbFlash.Name = "PbFlash"
        Me.PbFlash.Size = New System.Drawing.Size(570, 391)
        Me.PbFlash.TabIndex = 4
        Me.PbFlash.TabStop = false
        Me.PbFlash.Visible = false
        '
        'PBCle
        '
        Me.PBCle.BackColor = System.Drawing.Color.Transparent
        Me.PBCle.Image = Global.TuEsLeChampion.My.Resources.Resources.BigKey
        Me.PBCle.Location = New System.Drawing.Point(252, 53)
        Me.PBCle.Name = "PBCle"
        Me.PBCle.Size = New System.Drawing.Size(314, 163)
        Me.PBCle.TabIndex = 2
        Me.PBCle.TabStop = false
        Me.PBCle.Visible = false
        '
        'TbTemple
        '
        Me.TbTemple.Location = New System.Drawing.Point(187, 308)
        Me.TbTemple.Name = "TbTemple"
        Me.TbTemple.Size = New System.Drawing.Size(174, 20)
        Me.TbTemple.TabIndex = 7
        Me.TbTemple.Visible = false
        '
        'BtnOuvre
        '
        Me.BtnOuvre.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnOuvre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOuvre.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnOuvre.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnOuvre.Location = New System.Drawing.Point(199, 327)
        Me.BtnOuvre.Name = "BtnOuvre"
        Me.BtnOuvre.Size = New System.Drawing.Size(143, 42)
        Me.BtnOuvre.TabIndex = 3
        Me.BtnOuvre.Text = "Ouvre-le!!"
        Me.BtnOuvre.UseVisualStyleBackColor = false
        Me.BtnOuvre.Visible = false
        '
        'PBCoffre
        '
        Me.PBCoffre.BackColor = System.Drawing.Color.Transparent
        Me.PBCoffre.Image = Global.TuEsLeChampion.My.Resources.Resources.Treasure
        Me.PBCoffre.Location = New System.Drawing.Point(6, 6)
        Me.PBCoffre.Name = "PBCoffre"
        Me.PBCoffre.Size = New System.Drawing.Size(240, 210)
        Me.PBCoffre.TabIndex = 0
        Me.PBCoffre.TabStop = false
        '
        'LblTemple
        '
        Me.LblTemple.BackColor = System.Drawing.Color.Transparent
        Me.LblTemple.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblTemple.ForeColor = System.Drawing.Color.White
        Me.LblTemple.Location = New System.Drawing.Point(76, 257)
        Me.LblTemple.Name = "LblTemple"
        Me.LblTemple.Size = New System.Drawing.Size(449, 48)
        Me.LblTemple.TabIndex = 6
        Me.LblTemple.Text = "Bravo, hero, vous avez accomplit votre quête, quoique peu glorieuse."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Entrez votr"& _ 
    "e nom ici pour que nous puissions nous rappeller de vous jusqu'a la fin des temp"& _ 
    "s."
        Me.LblTemple.Visible = false
        '
        'LbLVide
        '
        Me.LbLVide.BackColor = System.Drawing.Color.Transparent
        Me.LbLVide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LbLVide.ForeColor = System.Drawing.Color.White
        Me.LbLVide.Location = New System.Drawing.Point(252, 6)
        Me.LbLVide.Name = "LbLVide"
        Me.LbLVide.Size = New System.Drawing.Size(310, 242)
        Me.LbLVide.TabIndex = 5
        Me.LbLVide.Text = resources.GetString("LbLVide.Text")
        Me.LbLVide.Visible = false
        '
        'BtnSoumettre
        '
        Me.BtnSoumettre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnSoumettre.Location = New System.Drawing.Point(199, 334)
        Me.BtnSoumettre.Name = "BtnSoumettre"
        Me.BtnSoumettre.Size = New System.Drawing.Size(152, 31)
        Me.BtnSoumettre.TabIndex = 8
        Me.BtnSoumettre.Text = "Soumettre votre nom"
        Me.BtnSoumettre.UseVisualStyleBackColor = true
        Me.BtnSoumettre.Visible = false
        '
        'LblIntro
        '
        Me.LblIntro.BackColor = System.Drawing.Color.Transparent
        Me.LblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblIntro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblIntro.Location = New System.Drawing.Point(138, 231)
        Me.LblIntro.Name = "LblIntro"
        Me.LblIntro.Size = New System.Drawing.Size(283, 121)
        Me.LblIntro.TabIndex = 1
        Me.LblIntro.Text = "VOUS Y ÊTES!! LE TRÉSOR SECRET DE YAPASDOR!!!"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"..."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Mais c'est barré, et vous"& _ 
    " n'avez pas la clé!! Elle doit être quelque part.... Où peut-il bien être?"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabCle
        '
        Me.TabCle.BackColor = System.Drawing.SystemColors.Control
        Me.TabCle.BackgroundImage = Global.TuEsLeChampion.My.Resources.Resources._223237_lgeXakTsarothTreasureRoomDLM
        Me.TabCle.Controls.Add(Me.PBPetiteCle)
        Me.TabCle.Controls.Add(Me.LblVictoire)
        Me.TabCle.Location = New System.Drawing.Point(4, 22)
        Me.TabCle.Name = "TabCle"
        Me.TabCle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCle.Size = New System.Drawing.Size(562, 391)
        Me.TabCle.TabIndex = 1
        Me.TabCle.Text = "."
        '
        'PBPetiteCle
        '
        Me.PBPetiteCle.BackColor = System.Drawing.Color.Transparent
        Me.PBPetiteCle.Image = Global.TuEsLeChampion.My.Resources.Resources.Key
        Me.PBPetiteCle.Location = New System.Drawing.Point(372, 165)
        Me.PBPetiteCle.Name = "PBPetiteCle"
        Me.PBPetiteCle.Size = New System.Drawing.Size(38, 21)
        Me.PBPetiteCle.TabIndex = 0
        Me.PBPetiteCle.TabStop = false
        '
        'LblVictoire
        '
        Me.LblVictoire.BackColor = System.Drawing.Color.Transparent
        Me.LblVictoire.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblVictoire.Location = New System.Drawing.Point(112, 120)
        Me.LblVictoire.Name = "LblVictoire"
        Me.LblVictoire.Size = New System.Drawing.Size(357, 178)
        Me.LblVictoire.TabIndex = 1
        Me.LblVictoire.Text = "Vous l'avez trouvée!! Revenez vite au trésor pour l'ouvrir!!"
        Me.LblVictoire.Visible = false
        '
        'TimerKey
        '
        Me.TimerKey.Interval = 1
        '
        'Timeflash
        '
        Me.Timeflash.Interval = 4000
        '
        'TimeSoumettre
        '
        Me.TimeSoumettre.Interval = 7000
        '
        'Tresor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 407)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = false
        Me.Name = "Tresor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tu es le Champion - Trésor"
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        CType(Me.PbFlash,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PBCle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PBCoffre,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabCle.ResumeLayout(false)
        CType(Me.PBPetiteCle,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PBCoffre As System.Windows.Forms.PictureBox
    Friend WithEvents LblIntro As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabCle As System.Windows.Forms.TabPage
    Friend WithEvents PBPetiteCle As System.Windows.Forms.PictureBox
    Friend WithEvents PBCle As System.Windows.Forms.PictureBox
    Friend WithEvents LblVictoire As System.Windows.Forms.Label
    Friend WithEvents BtnOuvre As System.Windows.Forms.Button
    Friend WithEvents TimerKey As System.Windows.Forms.Timer
    Friend WithEvents Timeflash As System.Windows.Forms.Timer
    Friend WithEvents BtnSoumettre As System.Windows.Forms.Button
    Friend WithEvents TbTemple As System.Windows.Forms.TextBox
    Friend WithEvents LblTemple As System.Windows.Forms.Label
    Friend WithEvents LbLVide As System.Windows.Forms.Label
    Friend WithEvents TimeSoumettre As System.Windows.Forms.Timer
    Friend WithEvents PbFlash As System.Windows.Forms.PictureBox
End Class
