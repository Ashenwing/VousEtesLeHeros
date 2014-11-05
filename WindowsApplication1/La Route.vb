Public Class La_Route
    Private Sub La_Route_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Theme_Song, AudioPlayMode.Background)
    End Sub
    Private Sub form_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        My.Computer.Audio.Stop()
    End Sub

    Private Sub BtnCommencer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCommencer.Click
        LblIntro.Visible = False
        BtnCommencer.Visible = False
        LblQuestion1.Visible = True
        PanelQuestion1.Visible = True
        My.Computer.Audio.Play(My.Resources.Jeopardy, AudioPlayMode.Background)
    End Sub

    Private Sub BtnSoumettre1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSoumettre1.Click
        Static count As Integer
        count = count + 1
        LblRetry.Visible = True
        If RB4Poissons.Checked = True Then
            count = 0
            LblRetry.Visible = False
        End If

        If count = 2 Then
            MessageBox.Show("Malheureusement vous n'etes pas qualifié pour que nous vous laissons passer. Retourne chez toi, petit homme.", "Game Over")
            Debut.Visible = True
            My.Computer.Audio.Stop()
            Close()
        End If

        If RB4Poissons.Checked = True Then
            PanelQuestion1.Enabled = False
            LblQuestion2.Visible = True
            PanelQuestion2.Visible = True
            LblQuestion1.Visible = False
        End If

    End Sub

    Private Sub BtnSoumettre2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSoumettre2.Click
        If CBEpee.Checked = False And CBHache.Checked = False And CBLance.Checked = False And CBArc.Checked = False Then
            LblQuestion2.Text = "Vous savez utiliser AUCUNE arme?" + vbCrLf + "Franchement, sire." + vbCrLf + " Sous les ordres de Napadenom," + vbCrLf + " nous ne pouvons vous laisser passer."
        End If

        If CBEpee.Checked = True Or CBHache.Checked = True Or CBLance.Checked = True Or CBArc.Checked = True Then
            LblQuestion2.Visible = False
            PanelQuestion1.Visible = False
            PanelQuestion2.Visible = False
            BtnContinuer.Visible = True
            LblReussite.Visible = True
            My.Computer.Audio.Play(My.Resources.FFVictory, AudioPlayMode.Background)

        End If
    End Sub

    Private Sub BtnContinuer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnContinuer.Click
        My.Computer.Audio.Stop()
        Me.Close()
        Magicien.Show()
    End Sub
End Class