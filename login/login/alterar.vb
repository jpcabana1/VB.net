﻿Public Class alterar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.DeleteFile(UserDelete.Text)
        If Cuser.Text = "" Or Csenha1.Text = "" Or Csenha2.Text = "" Or
            Cemail.Text = "" Then
            MsgBox("Todos os campos devem ser preenchidos", MsgBoxStyle.Critical, "Erro")
        Else
            If Csenha1.Text <> Csenha2.Text Then
                MsgBox("Senhas devem ser iguais", MsgBoxStyle.Critical, "Erro")
            ElseIf Cemail.Text.IndexOf("@") = -1 Or Cemail.Text.IndexOf(".com") = -1 Then
                MsgBox("Email inválido", MsgBoxStyle.Critical, "Erro")
            Else
                MsgBox("Dados alterados",
                        MsgBoxStyle.Information, "alteração realizada")
                Call CadastrarLogin()
            End If
        End If
    End Sub
    Private Sub CadastrarLogin()

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Cuser.Text, True)
        file.WriteLine(Cuser.Text)
        file.WriteLine(Csenha1.Text)
        file.WriteLine(Cemail.Text)
        file.Close()
    End Sub


End Class