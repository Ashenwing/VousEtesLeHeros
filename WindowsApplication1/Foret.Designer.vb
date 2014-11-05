<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Foret
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Foret))
        Me.LblIntro = New System.Windows.Forms.Label()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.BtnFrappe = New System.Windows.Forms.Button()
        Me.LblFrappe = New System.Windows.Forms.Label()
        Me.TimeFrappe = New System.Windows.Forms.Timer(Me.components)
        Me.LblVictoire = New System.Windows.Forms.Label()
        Me.BtnVictoire = New System.Windows.Forms.Button()
        Me.PBLoupmort = New System.Windows.Forms.PictureBox()
        Me.PbLoup = New System.Windows.Forms.PictureBox()
        Me.CbMusique = New System.Windows.Forms.CheckBox()
        CType(Me.PBLoupmort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLoup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIntro
        '
        Me.LblIntro.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntro.Location = New System.Drawing.Point(87, 4)
        Me.LblIntro.Name = "LblIntro"
        Me.LblIntro.Size = New System.Drawing.Size(301, 197)
        Me.LblIntro.TabIndex = 0
        Me.LblIntro.Text = resources.GetString("LblIntro.Text")
        Me.LblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCount
        '
        Me.LblCount.AutoSize = True
        Me.LblCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCount.Location = New System.Drawing.Point(40, 130)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(80, 57)
        Me.LblCount.TabIndex = 1
        Me.LblCount.Text = "10"
        Me.LblCount.Visible = False
        '
        'BtnFrappe
        '
        Me.BtnFrappe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFrappe.Location = New System.Drawing.Point(197, 218)
        Me.BtnFrappe.Name = "BtnFrappe"
        Me.BtnFrappe.Size = New System.Drawing.Size(142, 29)
        Me.BtnFrappe.TabIndex = 2
        Me.BtnFrappe.Text = "Frappe-le!"
        Me.BtnFrappe.UseVisualStyleBackColor = True
        '
        'LblFrappe
        '
        Me.LblFrappe.AutoSize = True
        Me.LblFrappe.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblFrappe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFrappe.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFrappe.Location = New System.Drawing.Point(211, 130)
        Me.LblFrappe.Name = "LblFrappe"
        Me.LblFrappe.Size = New System.Drawing.Size(38, 41)
        Me.LblFrappe.TabIndex = 3
        Me.LblFrappe.Text = "0"
        Me.LblFrappe.Visible = False
        '
        'TimeFrappe
        '
        Me.TimeFrappe.Interval = 1000
        '
        'LblVictoire
        '
        Me.LblVictoire.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblVictoire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVictoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVictoire.Location = New System.Drawing.Point(40, 4)
        Me.LblVictoire.Name = "LblVictoire"
        Me.LblVictoire.Size = New System.Drawing.Size(448, 81)
        Me.LblVictoire.TabIndex = 4
        Me.LblVictoire.Text = resources.GetString("LblVictoire.Text")
        Me.LblVictoire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblVictoire.Visible = False
        '
        'BtnVictoire
        '
        Me.BtnVictoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVictoire.Location = New System.Drawing.Point(199, 264)
        Me.BtnVictoire.Name = "BtnVictoire"
        Me.BtnVictoire.Size = New System.Drawing.Size(140, 26)
        Me.BtnVictoire.TabIndex = 7
        Me.BtnVictoire.Text = "Franchir la forêt"
        Me.BtnVictoire.UseVisualStyleBackColor = True
        Me.BtnVictoire.Visible = False
        '
        'PBLoupmort
        '
        Me.PBLoupmort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBLoupmort.Image = My.Resources.images__1_
        Me.PBLoupmort.Location = New System.Drawing.Point(394, 101)
        Me.PBLoupmort.Name = "PBLoupmort"
        Me.PBLoupmort.Size = New System.Drawing.Size(193, 170)
        Me.PBLoupmort.TabIndex = 6
        Me.PBLoupmort.TabStop = False
        Me.PBLoupmort.Visible = False
        '
        'PbLoup
        '
        Me.PbLoup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbLoup.Image = Global.TuEsLeChampion.My.Resources.Resources.images
        Me.PbLoup.Location = New System.Drawing.Point(394, 117)
        Me.PbLoup.Name = "PbLoup"
        Me.PbLoup.Size = New System.Drawing.Size(193, 200)
        Me.PbLoup.TabIndex = 5
        Me.PbLoup.TabStop = False
        '
        'CbMusique
        '
        Me.CbMusique.AutoSize = True
        Me.CbMusique.Location = New System.Drawing.Point(-1, 271)
        Me.CbMusique.Name = "CbMusique"
        Me.CbMusique.Size = New System.Drawing.Size(81, 17)
        Me.CbMusique.TabIndex = 8
        Me.CbMusique.Text = "CheckBox1"
        Me.CbMusique.UseVisualStyleBackColor = True
        Me.CbMusique.Visible = False
        '
        'Foret
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(587, 314)
        Me.Controls.Add(Me.LblIntro)
        Me.Controls.Add(Me.CbMusique)
        Me.Controls.Add(Me.BtnVictoire)
        Me.Controls.Add(Me.PBLoupmort)
        Me.Controls.Add(Me.PbLoup)
        Me.Controls.Add(Me.LblFrappe)
        Me.Controls.Add(Me.BtnFrappe)
        Me.Controls.Add(Me.LblCount)
        Me.Controls.Add(Me.LblVictoire)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Foret"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tu es le Champion - Dans la forêt"
        CType(Me.PBLoupmort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLoup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblIntro As System.Windows.Forms.Label
    Friend WithEvents LblCount As System.Windows.Forms.Label
    Friend WithEvents BtnFrappe As System.Windows.Forms.Button
    Friend WithEvents LblFrappe As System.Windows.Forms.Label
    Friend WithEvents TimeFrappe As System.Windows.Forms.Timer
    Friend WithEvents LblVictoire As System.Windows.Forms.Label
    Friend WithEvents PbLoup As System.Windows.Forms.PictureBox
    Friend WithEvents PBLoupmort As System.Windows.Forms.PictureBox
    Friend WithEvents BtnVictoire As System.Windows.Forms.Button
    Friend WithEvents CbMusique As System.Windows.Forms.CheckBox
End Class
