Public Class Sauter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSoumettre.Click
        My.Computer.Audio.Stop()
        If RBSaute.Checked = True Then
            LblIntro.Text = "Malheureusement, vous n'arrivez pas à sauter assez loin et vous tombez. Par chance, vous réussissez à vous accrocher à une branche. Grimpez maintenant jusqu'en haut !"

            RBSaute.Visible = False
            RBPont.Visible = False
            BtnSoumettre.Visible = False
            Me.Text = "Grimpez !"
            PictureBox2.Visible = True
            BtnCommencer.Visible = True
        End If
        If RBPont.Checked = True Then
            Me.Visible = False
            Pont.ShowDialog()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCommencer.Click
        BtnCommencer.Visible = False
        BtnGrimpe1.Visible = True
        TimeSaute1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeSaute1.Tick
        BtnGrimpe1.Visible = False
        If BtnGrimpe2.Visible = False And BtnGrimpe1.Visible = False Then
            LblFail.Visible = True
            BtnFail.Visible = True
            TimeSaute1.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrimpe1.Click
        BtnGrimpe1.Visible = False
        BtnGrimpe2.Visible = True
        TimeSaute2.Enabled = True
        TimeSaute1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeSaute2.Tick
        BtnGrimpe2.Visible = False
        If BtnGrimpe3.Visible = False And BtnGrimpe2.Visible = False Then
            LblFail.Visible = True
            BtnFail.Visible = True
            TimeSaute2.Enabled = False
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrimpe2.Click
        BtnGrimpe2.Visible = False
        BtnGrimpe3.Visible = True
        TimeSaute3.Enabled = True
        TimeSaute2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeSaute3.Tick
        BtnGrimpe3.Visible = False
        If BtnGrimpe4.Visible = False And BtnGrimpe3.Visible = False Then
            LblFail.Visible = True
            BtnFail.Visible = True
            TimeSaute3.Enabled = False
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrimpe4.Click
        TimeSaute4.Enabled = False
        BtnGrimpe4.Visible = False
        LblVictoire.Visible = True
        BtnVictoire.Visible = True
        LblIntro.Visible = False
        PictureBox2.Visible = False
        BtnFail.Visible = False
        LblFail.Visible = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrimpe3.Click
        BtnGrimpe3.Visible = False
        BtnGrimpe4.Visible = True
        TimeSaute4.Enabled = True
        TimeSaute3.Enabled = False


    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeSaute4.Tick
        BtnGrimpe4.Visible = False
        If BtnGrimpe4.Visible = False And BtnGrimpe3.Visible = False Then
            LblFail.Visible = True
            BtnFail.Visible = True
            TimeSaute4.Enabled = False
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFail.Click
        LblFail.Visible = False
        BtnCommencer.Visible = True
        BtnFail.Visible = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVictoire.Click
        Me.Close()
        F4.ShowDialog()
    End Sub

    Private Sub form_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        My.Computer.Audio.Stop()
    End Sub
End Class
