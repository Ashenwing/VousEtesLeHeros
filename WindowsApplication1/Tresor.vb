Imports System.IO
Public Class Tresor
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBPetiteCle.Click
        PBCle.Visible = True
        LblVictoire.Visible = True
        BtnOuvre.Visible = True
        LblIntro.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOuvre.Click
        PBPetiteCle.Visible = False
        LblVictoire.Visible = False
        TimerKey.Enabled = True
        My.Computer.Audio.Play(My.Resources.ChestOpen, AudioPlayMode.Background)
    End Sub

    Private Sub TimerKey_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerKey.Tick
        Static droit As Boolean = True
        If droit Then
            PBCle.Left -= 2
            If PBCle.Left = 150 Then
                droit = False
                PbFlash.Visible = True
                Timeflash.Enabled = True
                PBCoffre.Image = My.Resources.CoffreOuvert
                PBCle.Visible = False
                BtnOuvre.Visible = False
                LblIntro.Visible = False
                LbLVide.Visible = True
            End If
        End If
    End Sub

    Private Sub Timeflash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timeflash.Tick
        PbFlash.Visible = False
        TimeSoumettre.Enabled = True
        Timeflash.Enabled = False
    End Sub

    Private Sub TimeSoumettre_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeSoumettre.Tick
        BtnSoumettre.Visible = True
        TbTemple.Visible = True
        LblTemple.Visible = True
    End Sub

    Private Sub BtnSoumettre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSoumettre.Click
        Dim fichier As New StreamWriter("Renomée.txt", True)
        fichier.WriteLine(TbTemple.Text)
        fichier.Close()
        BtnSoumettre.Enabled = False
        MessageBox.Show("Votre aventure est terminée! Félicitations, brave guerrier. Thank-you for playing!", "Game Over")
        Me.Close()
        Temple.Show()

    End Sub
    Private Sub Tresor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.BANANA, AudioPlayMode.Background)
    End Sub
    Private Sub form_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        My.Computer.Audio.Stop()
    End Sub
End Class