Public Class Debut

    Private Sub Debut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblForet.BackColor = Color.Transparent
        LblRoute.BackColor = Color.Transparent
    End Sub
    
    Private Sub LblForet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblForet.Click
        My.Computer.Audio.Stop()
        Me.Close()
        Foret.Show()
    End Sub

    Private Sub LblRoute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblRoute.Click
        My.Computer.Audio.Stop()
        Me.Close()
        La_Route.Show()
    End Sub
    Private Sub LblForet_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblForet.MouseHover
        LblForet.ForeColor = Color.Teal
        TimeLblForet.Enabled = True
    End Sub
    Private Sub TimeLblForet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLblForet.Tick
        LblForet.ForeColor = Color.Orange
    End Sub
    Private Sub LblRoute_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblRoute.MouseHover
        LblRoute.ForeColor = Color.Teal
        TimeLblRoute.Enabled = True
    End Sub
    Private Sub TimeLblRoute_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLblRoute.Tick
        LblRoute.ForeColor = Color.Orange
    End Sub
End Class
