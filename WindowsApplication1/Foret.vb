Public Class Foret
    Private Sub Foret_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnFrappe.Enabled = True
        LblFrappe.Text = "0"
        countdown = 10
        LblFrappe.Visible = False
        frappe = 0
    End Sub
    Private Sub form_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        My.Computer.Audio.Stop()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFrappe.Click
        LblIntro.Visible = False
        LblCount.Visible = True
        LblFrappe.Visible = True
        TimeFrappe.Enabled = True

        frappe = frappe + 1
        LblFrappe.Text = CStr(frappe)

        If LblFrappe.Text = "50" Then

            BtnVictoire.Visible = True
            TimeFrappe.Enabled = False
            LblIntro.Visible = False
            LblVictoire.Visible = True
            PbLoup.Visible = False
            PBLoupmort.Visible = True
            LblCount.Visible = False
            LblFrappe.Visible = False
            BtnFrappe.Visible = False
        End If

        CbMusique.Checked = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeFrappe.Tick
        If Not countdown = -1 Then
            LblCount.Text = CStr(countdown)
            countdown = countdown - 1
        Else
            TimeFrappe.Enabled = False
        End If
        If LblCount.Text = "0" Then
            TimeFrappe.Enabled = False
            BtnFrappe.Enabled = False
            My.Computer.Audio.Play(My.Resources.GameOver, AudioPlayMode.Background)
            MessageBox.Show(" Malheureusement, vous avez echoué. Votre aventure s'arrête ici. Meilleure chance la prochaine fois...")
            Me.Close()
            Debut.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVictoire.Click
        Me.Close()
        Sauter.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbMusique.CheckedChanged
        If CbMusique.Checked = True Then
            My.Computer.Audio.Play(My.Resources.FEStrike, AudioPlayMode.Background)
        End If
    End Sub
End Class