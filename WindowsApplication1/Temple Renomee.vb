Imports System.IO

Public Class Temple
    Private Sub Temple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Ficheread As New StreamReader("Renomée.txt")
        TBTemple.Text = Ficheread.ReadToEnd
        Ficheread.Close()
        My.Computer.Audio.Play(My.Resources.Pokemon, AudioPlayMode.Background)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitter.Click
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub
    Private Sub form_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        My.Computer.Audio.Stop()
    End Sub
End Class