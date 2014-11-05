Public Class Pont
    Public Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSoumettre.Click
        If LBObjets.SelectedIndex = 1 Then
            LblVictoire.Visible = True
            LblIntro.Visible = False
            LblRefus.Visible = False
            BtnVictoire.Visible = True
            LBObjets.Visible = False
            BtnSoumettre.Visible = False
            PictureBox1.Visible = False

        Else
            LblRefus.Visible = True
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblRefus.Visible= False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVictoire.Click
        Me.Close()
        F4.ShowDialog()
    End Sub
End Class