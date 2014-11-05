Public Class Menu

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblJouer.Click
        My.Computer.Audio.Stop()
        F0.Close()
        F1.ShowDialog()

    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Skyrim, AudioPlayMode.Background)
        Dim splash As New Splash
        splash.ShowDialog()
    End Sub
    Private Sub form_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblJouer.MouseHover
        LblJouer.ForeColor = Color.Teal
        TimeLbl1.Enabled = True
    End Sub

    Private Sub TimeLbl1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLbl1.Tick
        LblJouer.ForeColor = Color.Black
    End Sub

    Private Sub Label2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTemple.MouseHover
        LblTemple.ForeColor = Color.Teal
        TimeLbl2.Enabled = True
    End Sub
    Private Sub TimeLbl2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLbl2.Tick
        LblTemple.ForeColor = Color.Black
    End Sub
    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblQuitter.MouseHover
        LblQuitter.ForeColor = Color.Teal
        TimeLbl3.Enabled = True
    End Sub
    Private Sub TimeLbl3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLbl3.Tick
        LblQuitter.ForeColor = Color.Black
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTemple.Click
        My.Computer.Audio.Stop()
        F01.ShowDialog()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblQuitter.Click
        End
    End Sub
End Class