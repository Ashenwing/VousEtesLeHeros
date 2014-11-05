<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class La_Route
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(La_Route))
        Me.RB4Poissons = New System.Windows.Forms.RadioButton()
        Me.RBSortir = New System.Windows.Forms.RadioButton()
        Me.RBFilsManger = New System.Windows.Forms.RadioButton()
        Me.RBTruquer = New System.Windows.Forms.RadioButton()
        Me.PanelQuestion1 = New System.Windows.Forms.Panel()
        Me.BtnSoumettre1 = New System.Windows.Forms.Button()
        Me.LblRetry = New System.Windows.Forms.Label()
        Me.BtnCommencer = New System.Windows.Forms.Button()
        Me.CBEpee = New System.Windows.Forms.CheckBox()
        Me.CBHache = New System.Windows.Forms.CheckBox()
        Me.CBLance = New System.Windows.Forms.CheckBox()
        Me.CBArc = New System.Windows.Forms.CheckBox()
        Me.PanelQuestion2 = New System.Windows.Forms.Panel()
        Me.BtnSoumettre2 = New System.Windows.Forms.Button()
        Me.BtnContinuer = New System.Windows.Forms.Button()
        Me.LblReussite = New System.Windows.Forms.Label()
        Me.LblIntro = New System.Windows.Forms.Label()
        Me.LblQuestion1 = New System.Windows.Forms.Label()
        Me.LblQuestion2 = New System.Windows.Forms.Label()
        Me.PanelQuestion1.SuspendLayout()
        Me.PanelQuestion2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RB4Poissons
        '
        Me.RB4Poissons.AutoSize = True
        Me.RB4Poissons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB4Poissons.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RB4Poissons.Location = New System.Drawing.Point(5, 47)
        Me.RB4Poissons.Name = "RB4Poissons"
        Me.RB4Poissons.Size = New System.Drawing.Size(261, 19)
        Me.RB4Poissons.TabIndex = 8
        Me.RB4Poissons.TabStop = True
        Me.RB4Poissons.Text = "Il n`y avait que quatre personnes présentes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RB4Poissons.UseVisualStyleBackColor = True
        '
        'RBSortir
        '
        Me.RBSortir.AutoSize = True
        Me.RBSortir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBSortir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RBSortir.Location = New System.Drawing.Point(5, 24)
        Me.RBSortir.Name = "RBSortir"
        Me.RBSortir.Size = New System.Drawing.Size(177, 19)
        Me.RBSortir.TabIndex = 9
        Me.RBSortir.TabStop = True
        Me.RBSortir.Text = "Un des cinq est sorti du sac."
        Me.RBSortir.UseVisualStyleBackColor = True
        '
        'RBFilsManger
        '
        Me.RBFilsManger.AutoSize = True
        Me.RBFilsManger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBFilsManger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RBFilsManger.Location = New System.Drawing.Point(5, 1)
        Me.RBFilsManger.Name = "RBFilsManger"
        Me.RBFilsManger.Size = New System.Drawing.Size(213, 19)
        Me.RBFilsManger.TabIndex = 10
        Me.RBFilsManger.TabStop = True
        Me.RBFilsManger.Text = "Le fils a mangé le dernier poisson."
        Me.RBFilsManger.UseVisualStyleBackColor = True
        '
        'RBTruquer
        '
        Me.RBTruquer.AutoSize = True
        Me.RBTruquer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTruquer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RBTruquer.Location = New System.Drawing.Point(5, 70)
        Me.RBTruquer.Name = "RBTruquer"
        Me.RBTruquer.Size = New System.Drawing.Size(255, 19)
        Me.RBTruquer.TabIndex = 11
        Me.RBTruquer.TabStop = True
        Me.RBTruquer.Text = "Vous éssayez de me truquer. Il y en a cinq."
        Me.RBTruquer.UseVisualStyleBackColor = True
        '
        'PanelQuestion1
        '
        Me.PanelQuestion1.BackColor = System.Drawing.Color.ForestGreen
        Me.PanelQuestion1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelQuestion1.Controls.Add(Me.BtnSoumettre1)
        Me.PanelQuestion1.Controls.Add(Me.RBTruquer)
        Me.PanelQuestion1.Controls.Add(Me.RB4Poissons)
        Me.PanelQuestion1.Controls.Add(Me.RBFilsManger)
        Me.PanelQuestion1.Controls.Add(Me.RBSortir)
        Me.PanelQuestion1.Location = New System.Drawing.Point(273, 208)
        Me.PanelQuestion1.Name = "PanelQuestion1"
        Me.PanelQuestion1.Size = New System.Drawing.Size(313, 121)
        Me.PanelQuestion1.TabIndex = 12
        Me.PanelQuestion1.Visible = False
        '
        'BtnSoumettre1
        '
        Me.BtnSoumettre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSoumettre1.Location = New System.Drawing.Point(114, 92)
        Me.BtnSoumettre1.Name = "BtnSoumettre1"
        Me.BtnSoumettre1.Size = New System.Drawing.Size(85, 23)
        Me.BtnSoumettre1.TabIndex = 12
        Me.BtnSoumettre1.Text = "Soumettre"
        Me.BtnSoumettre1.UseVisualStyleBackColor = True
        '
        'LblRetry
        '
        Me.LblRetry.AutoSize = True
        Me.LblRetry.BackColor = System.Drawing.Color.ForestGreen
        Me.LblRetry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRetry.ForeColor = System.Drawing.Color.Maroon
        Me.LblRetry.Location = New System.Drawing.Point(231, 194)
        Me.LblRetry.Name = "LblRetry"
        Me.LblRetry.Size = New System.Drawing.Size(340, 15)
        Me.LblRetry.TabIndex = 22
        Me.LblRetry.Text = "Non, vous avez tort. Vous avez une dernière chance."
        Me.LblRetry.Visible = False
        '
        'BtnCommencer
        '
        Me.BtnCommencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCommencer.Location = New System.Drawing.Point(36, 212)
        Me.BtnCommencer.Name = "BtnCommencer"
        Me.BtnCommencer.Size = New System.Drawing.Size(161, 45)
        Me.BtnCommencer.TabIndex = 18
        Me.BtnCommencer.Text = "Quelles sont ces questions?"
        Me.BtnCommencer.UseVisualStyleBackColor = True
        '
        'CBEpee
        '
        Me.CBEpee.AutoSize = True
        Me.CBEpee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEpee.Location = New System.Drawing.Point(5, 7)
        Me.CBEpee.Name = "CBEpee"
        Me.CBEpee.Size = New System.Drawing.Size(55, 19)
        Me.CBEpee.TabIndex = 13
        Me.CBEpee.Text = "Épée"
        Me.CBEpee.UseVisualStyleBackColor = True
        '
        'CBHache
        '
        Me.CBHache.AutoSize = True
        Me.CBHache.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBHache.Location = New System.Drawing.Point(5, 30)
        Me.CBHache.Name = "CBHache"
        Me.CBHache.Size = New System.Drawing.Size(62, 19)
        Me.CBHache.TabIndex = 14
        Me.CBHache.Text = "Hache"
        Me.CBHache.UseVisualStyleBackColor = True
        '
        'CBLance
        '
        Me.CBLance.AutoSize = True
        Me.CBLance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLance.Location = New System.Drawing.Point(105, 7)
        Me.CBLance.Name = "CBLance"
        Me.CBLance.Size = New System.Drawing.Size(60, 19)
        Me.CBLance.TabIndex = 15
        Me.CBLance.Text = "Lance"
        Me.CBLance.UseVisualStyleBackColor = True
        '
        'CBArc
        '
        Me.CBArc.AutoSize = True
        Me.CBArc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBArc.Location = New System.Drawing.Point(105, 30)
        Me.CBArc.Name = "CBArc"
        Me.CBArc.Size = New System.Drawing.Size(43, 19)
        Me.CBArc.TabIndex = 16
        Me.CBArc.Text = "Arc"
        Me.CBArc.UseVisualStyleBackColor = True
        '
        'PanelQuestion2
        '
        Me.PanelQuestion2.BackColor = System.Drawing.Color.ForestGreen
        Me.PanelQuestion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelQuestion2.Controls.Add(Me.BtnSoumettre2)
        Me.PanelQuestion2.Controls.Add(Me.CBArc)
        Me.PanelQuestion2.Controls.Add(Me.CBLance)
        Me.PanelQuestion2.Controls.Add(Me.CBHache)
        Me.PanelQuestion2.Controls.Add(Me.CBEpee)
        Me.PanelQuestion2.Location = New System.Drawing.Point(273, 331)
        Me.PanelQuestion2.Name = "PanelQuestion2"
        Me.PanelQuestion2.Size = New System.Drawing.Size(313, 60)
        Me.PanelQuestion2.TabIndex = 17
        Me.PanelQuestion2.Visible = False
        '
        'BtnSoumettre2
        '
        Me.BtnSoumettre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSoumettre2.Location = New System.Drawing.Point(202, 16)
        Me.BtnSoumettre2.Name = "BtnSoumettre2"
        Me.BtnSoumettre2.Size = New System.Drawing.Size(83, 23)
        Me.BtnSoumettre2.TabIndex = 17
        Me.BtnSoumettre2.Text = "Soumettre"
        Me.BtnSoumettre2.UseVisualStyleBackColor = True
        '
        'BtnContinuer
        '
        Me.BtnContinuer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContinuer.Location = New System.Drawing.Point(193, 397)
        Me.BtnContinuer.Name = "BtnContinuer"
        Me.BtnContinuer.Size = New System.Drawing.Size(195, 23)
        Me.BtnContinuer.TabIndex = 21
        Me.BtnContinuer.Text = "Continuer votre route"
        Me.BtnContinuer.UseVisualStyleBackColor = True
        Me.BtnContinuer.Visible = False
        '
        'LblReussite
        '
        Me.LblReussite.BackColor = System.Drawing.Color.ForestGreen
        Me.LblReussite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReussite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblReussite.Location = New System.Drawing.Point(72, 4)
        Me.LblReussite.Name = "LblReussite"
        Me.LblReussite.Size = New System.Drawing.Size(433, 174)
        Me.LblReussite.TabIndex = 23
        Me.LblReussite.Text = resources.GetString("LblReussite.Text")
        Me.LblReussite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblReussite.Visible = False
        '
        'LblIntro
        '
        Me.LblIntro.BackColor = System.Drawing.Color.ForestGreen
        Me.LblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntro.ForeColor = System.Drawing.Color.Black
        Me.LblIntro.Location = New System.Drawing.Point(33, -3)
        Me.LblIntro.Name = "LblIntro"
        Me.LblIntro.Size = New System.Drawing.Size(508, 208)
        Me.LblIntro.TabIndex = 27
        Me.LblIntro.Text = resources.GetString("LblIntro.Text")
        '
        'LblQuestion1
        '
        Me.LblQuestion1.BackColor = System.Drawing.Color.ForestGreen
        Me.LblQuestion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestion1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblQuestion1.Location = New System.Drawing.Point(33, 188)
        Me.LblQuestion1.Name = "LblQuestion1"
        Me.LblQuestion1.Size = New System.Drawing.Size(208, 187)
        Me.LblQuestion1.TabIndex = 28
        Me.LblQuestion1.Text = resources.GetString("LblQuestion1.Text")
        Me.LblQuestion1.Visible = False
        '
        'LblQuestion2
        '
        Me.LblQuestion2.AutoSize = True
        Me.LblQuestion2.BackColor = System.Drawing.Color.ForestGreen
        Me.LblQuestion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestion2.ForeColor = System.Drawing.Color.Black
        Me.LblQuestion2.Location = New System.Drawing.Point(11, 336)
        Me.LblQuestion2.Name = "LblQuestion2"
        Me.LblQuestion2.Size = New System.Drawing.Size(256, 52)
        Me.LblQuestion2.TabIndex = 29
        Me.LblQuestion2.Text = "Excellent, très bien! Je vois que tu es sage." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maintenant, nous devons savoir.." & _
    "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Avec quelle sortes d'armes est-tu habile?"
        Me.LblQuestion2.Visible = False
        '
        'La_Route
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.TuEsLeChampion.My.Resources.Resources.newpath
        Me.ClientSize = New System.Drawing.Size(572, 427)
        Me.Controls.Add(Me.LblQuestion2)
        Me.Controls.Add(Me.LblRetry)
        Me.Controls.Add(Me.LblIntro)
        Me.Controls.Add(Me.BtnCommencer)
        Me.Controls.Add(Me.BtnContinuer)
        Me.Controls.Add(Me.PanelQuestion2)
        Me.Controls.Add(Me.PanelQuestion1)
        Me.Controls.Add(Me.LblQuestion1)
        Me.Controls.Add(Me.LblReussite)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "La_Route"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tu es le Champion - La route"
        Me.PanelQuestion1.ResumeLayout(False)
        Me.PanelQuestion1.PerformLayout()
        Me.PanelQuestion2.ResumeLayout(False)
        Me.PanelQuestion2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RB4Poissons As System.Windows.Forms.RadioButton
    Friend WithEvents RBSortir As System.Windows.Forms.RadioButton
    Friend WithEvents RBFilsManger As System.Windows.Forms.RadioButton
    Friend WithEvents RBTruquer As System.Windows.Forms.RadioButton
    Friend WithEvents PanelQuestion1 As System.Windows.Forms.Panel
    Friend WithEvents CBEpee As System.Windows.Forms.CheckBox
    Friend WithEvents CBHache As System.Windows.Forms.CheckBox
    Friend WithEvents CBLance As System.Windows.Forms.CheckBox
    Friend WithEvents CBArc As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSoumettre1 As System.Windows.Forms.Button
    Friend WithEvents PanelQuestion2 As System.Windows.Forms.Panel
    Friend WithEvents BtnSoumettre2 As System.Windows.Forms.Button
    Friend WithEvents BtnCommencer As System.Windows.Forms.Button
    Friend WithEvents BtnContinuer As System.Windows.Forms.Button
    Friend WithEvents LblRetry As System.Windows.Forms.Label
    Friend WithEvents LblReussite As System.Windows.Forms.Label
    Friend WithEvents LblIntro As System.Windows.Forms.Label
    Friend WithEvents LblQuestion1 As System.Windows.Forms.Label
    Friend WithEvents LblQuestion2 As System.Windows.Forms.Label
End Class
