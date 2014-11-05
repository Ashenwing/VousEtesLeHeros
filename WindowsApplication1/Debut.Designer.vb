<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debut
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
        Me.LblForet = New System.Windows.Forms.Label()
        Me.LblRoute = New System.Windows.Forms.Label()
        Me.TimeLblForet = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLblRoute = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LblForet
        '
        Me.LblForet.BackColor = System.Drawing.Color.Transparent
        Me.LblForet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblForet.ForeColor = System.Drawing.Color.Orange
        Me.LblForet.Location = New System.Drawing.Point(57, 285)
        Me.LblForet.Name = "LblForet"
        Me.LblForet.Size = New System.Drawing.Size(179, 54)
        Me.LblForet.TabIndex = 0
        Me.LblForet.Text = "Passer par la forêt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LblForet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LblRoute
        '
        Me.LblRoute.BackColor = System.Drawing.Color.Transparent
        Me.LblRoute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRoute.ForeColor = System.Drawing.Color.Orange
        Me.LblRoute.Location = New System.Drawing.Point(336, 285)
        Me.LblRoute.Name = "LblRoute"
        Me.LblRoute.Size = New System.Drawing.Size(179, 54)
        Me.LblRoute.TabIndex = 1
        Me.LblRoute.Text = "Prendre la route"
        Me.LblRoute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeLblForet
        '
        Me.TimeLblForet.Interval = 1000
        '
        'TimeLblRoute
        '
        Me.TimeLblRoute.Interval = 1000
        '
        'Debut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = My.Resources.Optimisation_Intro_
        Me.ClientSize = New System.Drawing.Size(573, 348)
        Me.Controls.Add(Me.LblRoute)
        Me.Controls.Add(Me.LblForet)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Debut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tu es le Champion - Le début de tout"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblForet As System.Windows.Forms.Label
    Friend WithEvents LblRoute As System.Windows.Forms.Label
    Friend WithEvents TimeLblForet As System.Windows.Forms.Timer
    Friend WithEvents TimeLblRoute As System.Windows.Forms.Timer

End Class
