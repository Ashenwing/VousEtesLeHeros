Public Class Magicien
    Private Sub Magicien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Deku, AudioPlayMode.Background)
    End Sub
    Private Sub form_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        My.Computer.Audio.Stop()
    End Sub
    Private Sub BtnSoumettre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSoumettre.Click

        tabchiffre(0) = TBchiffre1.Text  'Le chiffre entree par l'utilisater est inserée
        tabchiffre(1) = TBChiffre2.Text  ' Dans les tableaux.

        Dim valid1 As Boolean = False
        Dim valid2 As Boolean = False

        Try
            If (CInt(tabchiffre(0)) > 30) Then
                MessageBox.Show("Votre chiffre est trop haut!", "Erreur!")
            Else
                valid1 = True
            End If
        Catch ex As Exception
            MessageBox.Show("Vous devez remplir le premier champ avec un chiffre!", "Erreur!")
        End Try

        Try
            If (CInt(tabchiffre(1)) > 30) Then
                MessageBox.Show("Votre chiffre est trop haut!", "Erreur!")
            Else
                valid2 = True
            End If
        Catch ex As Exception
            MessageBox.Show("Vous devez remplir le deuxième champ avec un chiffre!", "Erreur!")
        End Try

        If (valid1 = True And valid2 = True) Then

            Dim check As Boolean = False
            LbLChiffre1.Text = CStr(chiffre1()) ' Le programme génere 6 chiffres aléatoires
            LbLChiffre2.Text = CStr(chiffre2()) ' Grace aux 5 Fonctions.
            LbLChiffre3.Text = CStr(chiffre3())
            LbLChiffre4.Text = CStr(chiffre4())
            LbLChiffre5.Text = CStr(chiffre5())

            Select Case tabchiffre(0)
                Case Is = LbLChiffre1.Text, LbLChiffre2.Text, LbLChiffre3.Text, LbLChiffre4.Text, LbLChiffre5.Text
                    BtnSoumettre.Visible = False
                    LblFalse.Visible = False
                    Lblquestion2.Visible = True
                    LblIntro.Visible = False
                    TBchiffre1.Visible = False
                    TBChiffre2.Visible = False
                    BtnSoumettre.Visible = False
                    PanelQuestions.Visible = False
                    check = True
                    imageLoad.Start()
                Case Else
                    LblFalse.Visible = True

            End Select
            If (check = False) Then
                Select Case tabchiffre(1)
                    Case Is = LbLChiffre1.Text, LbLChiffre2.Text, LbLChiffre3.Text, LbLChiffre4.Text, LbLChiffre5.Text
                        BtnSoumettre.Enabled = False
                        Lblquestion2.Visible = True
                        LblFalse.Visible = False
                        LblIntro.Visible = False
                        TBchiffre1.Visible = False
                        TBChiffre2.Visible = False
                        BtnSoumettre.Visible = False
                        PanelQuestions.Visible = False
                        imageLoad.Start()
                    Case Else
                        LblFalse.Visible = True
                End Select
            End If
        End If

    End Sub
    Private Function chiffre1() As Integer
        n1 = hasard.Next(1, 30)
        Return n1
    End Function
    Private Function chiffre2() As Integer
        n2 = n1
        While n2 = n1
            n2 = hasard.Next(1, 30)
        End While
        Return n2
    End Function
    Private Function chiffre3() As Integer
        n3 = n2
        While n3 = n2 Or n3 = n1
            n3 = hasard.Next(1, 30)
        End While
        Return n3
    End Function
    Private Function chiffre4() As Integer
        n4 = n3
        While n4 = n3 Or n4 = n2 Or n4 = n1
            n4 = hasard.Next(1, 30)
        End While
        Return n4
    End Function
    Private Function chiffre5() As Integer
        n5 = n4
        While n5 = n4 Or n5 = n3 Or n5 = n2 Or n5 = n1
            n5 = hasard.Next(1, 30)
        End While
        Return n5
    End Function

    Private Sub BtnAttaque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAttaque.Click
        Static compteur As Integer = 0
        compteur += 1
        LblIntro.Visible = False
        Lblquestion2.Visible = False
        PicGandalf.Visible = False
        PanelQuestions.Visible = False
        BtnSoumettre.Visible = False
        TBchiffre1.Visible = False
        TBChiffre2.Visible = False

        PanelLink.Location = New Point(hasard.Next(1, 300), hasard.Next(1, 300))

        If compteur = 10 Then
            PicLink2.Visible = True
            BtnKill.Visible = True
            PicGanon2.Visible = True
            PicGanon.Visible = False
            PanelLink.Visible = False
            TimeAttaque.Enabled = False
            LblAie.Text = ""
        End If

        CBMusic.Checked = True
        BtnAttaque.Text = "Esquive ses attaques!"
        TimeAttaque.Enabled = False
        TimeAttaque.Enabled = True
        LblAie.Visible = False



    End Sub
    Private Sub BtnKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKill.Click
        TimeLink.Enabled = True
        BtnKill.Visible = False
    End Sub
    Private Sub TimeLink_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLink.Tick
        Static droit As Boolean = True
        If droit Then
            PicLink2.Left += 1
            If PicLink2.Left = 75 Then
                droit = False
                PicLink2.Image = My.Resources.LinkJump_
                TimeLink.Enabled = False
                Timelink2.Enabled = True
            End If
        End If
    End Sub
    Private Sub Timelink2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timelink2.Tick
        Static droit As Boolean = True
        If droit Then
            PicLink2.Left += 1
            PicLink2.Top -= 1
            If PicLink2.Top = 30 Then
                droit = False
                Timelink2.Enabled = False
                Timelink3.Enabled = True
                PicLink2.Image = My.Resources.LinkAttack_
                My.Computer.Audio.Play(My.Resources.LinkScream, AudioPlayMode.Background)
            End If
        End If
    End Sub
    Private Sub TimeLink3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timelink3.Tick
        Static droit As Boolean = True
        If droit Then
            PicLink2.Left += 1
            PicLink2.Top += 1
        End If
        If PicLink2.Top = 180 Then
            droit = False
            PicLink2.Visible = False
            PicLinkWin.Visible = True
            PicGanon2.Image = My.Resources.GanonDie_
            TimeLink4.Enabled = True
            BtnVictoire.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVictoire.Click
        My.Computer.Audio.Play(My.Resources.ZeldaWin, AudioPlayMode.Background)
        BtnVictoire.Enabled = False
        TimeLink4.Enabled = True

    End Sub

    Private Sub TimeLink4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLink4.Tick
        LblVictoire.Visible = True
        BtnAvancer.Visible = True
        PicLinkWin.Left = 700   'Pour une raison ignoree, le .Visible=false ne marche pas.
        PicGanon2.Visible = False
    End Sub

    Private Sub BtnAvancer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAvancer.Click
        Me.Close()
        Tresor.Show()
    End Sub
    Private Sub CBMusic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMusic.CheckedChanged
        If CBMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.Last_Battle, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub TimeAttaque_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeAttaque.Tick
        Static compte As Integer
        LblAie.Visible = True
        compte += 1
        If (compte = 2) Then
            LblAie.Text = "Je t'ai eu encore!"
            LblAie.Left = 425
        End If
        If PicLink2.Visible = True Then
            compte = 0
            TimeAttaque.Enabled = False
        End If
        If compte = 3 Then
            My.Computer.Audio.Play(My.Resources.TPGameOver, AudioPlayMode.Background)
            TimeAttaque.Enabled = False
            rep = (MessageBox.Show("L'ennemi vous a tué, vous n'avez pas réussit à éviter ses coups." + vbCrLf +
                            "Vous échouez dans la noirceur...", "GAME OVER", MessageBoxButtons.OK))
        End If
        If rep = Windows.Forms.DialogResult.OK Then
            Me.Close()
            Debut.Show()
            My.Computer.Audio.Stop()

        End If
    End Sub

    Private Sub imageLoad_Tick(sender As Object, e As EventArgs) Handles imageLoad.Tick
        Static counter As Integer = 0
        counter += 1

        If (counter = 1) Then
            PicGanon.Visible = True
        End If
        If (counter = 2) Then
            PanelLink.Visible = True
            imageLoad.Stop()
        End If

    End Sub

End Class