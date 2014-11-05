<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.LblJouer = New System.Windows.Forms.Label()
        Me.LblTemple = New System.Windows.Forms.Label()
        Me.LblQuitter = New System.Windows.Forms.Label()
        Me.TimeLbl1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLbl2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLbl3 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LblJouer
        '
        Me.LblJouer.AutoSize = True
        Me.LblJouer.BackColor = System.Drawing.Color.Transparent
        Me.LblJouer.Font = New System.Drawing.Font("Chiller", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJouer.Location = New System.Drawing.Point(238, 135)
        Me.LblJouer.Name = "LblJouer"
        Me.LblJouer.Size = New System.Drawing.Size(70, 38)
        Me.LblJouer.TabIndex = 1
        Me.LblJouer.Text = "Jouer"
        '
        'LblTemple
        '
        Me.LblTemple.AutoSize = True
        Me.LblTemple.BackColor = System.Drawing.Color.Transparent
        Me.LblTemple.Font = New System.Drawing.Font("Chiller", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTemple.Location = New System.Drawing.Point(195, 227)
        Me.LblTemple.Name = "LblTemple"
        Me.LblTemple.Size = New System.Drawing.Size(247, 38)
        Me.LblTemple.TabIndex = 2
        Me.LblTemple.Text = "Temple de la Renommée"
        '
        'LblQuitter
        '
        Me.LblQuitter.AutoSize = True
        Me.LblQuitter.BackColor = System.Drawing.Color.Transparent
        Me.LblQuitter.Font = New System.Drawing.Font("Chiller", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuitter.Location = New System.Drawing.Point(266, 335)
        Me.LblQuitter.Name = "LblQuitter"
        Me.LblQuitter.Size = New System.Drawing.Size(85, 38)
        Me.LblQuitter.TabIndex = 3
        Me.LblQuitter.Text = "Quitter"
        '
        'TimeLbl1
        '
        Me.TimeLbl1.Interval = 1000
        '
        'TimeLbl2
        '
        Me.TimeLbl2.Interval = 1000
        '
        'TimeLbl3
        '
        Me.TimeLbl3.Interval = 1000
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TuEsLeChampion.My.Resources.Resources.Menu_TP_Prog
        Me.ClientSize = New System.Drawing.Size(568, 444)
        Me.Controls.Add(Me.LblQuitter)
        Me.Controls.Add(Me.LblTemple)
        Me.Controls.Add(Me.LblJouer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tu es le Champion - Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblJouer As System.Windows.Forms.Label
    Friend WithEvents LblTemple As System.Windows.Forms.Label
    Friend WithEvents LblQuitter As System.Windows.Forms.Label
    Friend WithEvents TimeLbl1 As System.Windows.Forms.Timer
    Friend WithEvents TimeLbl2 As System.Windows.Forms.Timer
    Friend WithEvents TimeLbl3 As System.Windows.Forms.Timer
End Class
