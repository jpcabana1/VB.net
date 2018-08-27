Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cuser.Text = "" Or Csenha1.Text = "" Or Csenha2.Text = "" Or
            Cemail.Text = "" Then
            MsgBox("Todos os campos devem ser preenchidos", MsgBoxStyle.Critical, "Erro")
        Else
            If Csenha1.Text <> Csenha2.Text Then
                MsgBox("Senhas devem ser iguais", MsgBoxStyle.Critical, "Erro")
            ElseIf Cemail.Text.IndexOf("@") = -1 Or Cemail.Text.IndexOf(".com") = -1 Then
                MsgBox("Email inválido", MsgBoxStyle.Critical, "Erro")
            Else
                If System.IO.File.Exists(Cuser.Text) Then
                    MsgBox("Conta já existe", MsgBoxStyle.Critical, "Erro")
                Else
                    MsgBox("Seu cadastro foi feito com sucesso",
                        MsgBoxStyle.Information, "Cadastro realizado")
                    Call CadastrarLogin()
                End If
            End If
        End If
    End Sub

    Private Sub CadastrarLogin()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\Administrator.SYSTI\\Downloads\\VB.net-master\\VB.net-master\\login\\login\\bin\\Debug\\Arquivos\\" & Cuser.Text, True)
        file.WriteLine(Cuser.Text)
        file.WriteLine(Csenha1.Text)
        file.WriteLine(Cemail.Text)
        file.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If user.Text = "" Or senha.Text = "" Then
            MsgBox("preencha todos os campos antes", MsgBoxStyle.Critical, "Erro")
        Else
            Try
                Dim line As String
                Using arq As StreamReader = New StreamReader("C:\\Users\\Administrator.SYSTI\\Downloads\\VB.net-master\\VB.net-master\\login\\login\\bin\\Debug\\Arquivos\\" & user.Text)
                    line = arq.ReadLine
                    If line = user.Text Then
                        line = arq.ReadLine
                        If line = senha.Text Then
                            MsgBox("Logado", MsgBoxStyle.Information, "Login realizado")
                            Logar()
                        Else
                            MsgBox("Senha errada", MsgBoxStyle.Critical, "Erro")
                        End If
                    Else
                        MsgBox("Usuário errado", MsgBoxStyle.Critical, "Erro")
                    End If
                End Using

            Catch ex As Exception
                MsgBox("Falha ao realizar login", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub Logar()
        Dim login As Menu
        login = New Menu
        login.Show()
    End Sub
End Class
