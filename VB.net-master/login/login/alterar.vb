Public Class alterar
    Private Strarq As String
    Public Property arquivo() As String
        Get
            Return Strarq
        End Get
        Set(ByVal value As String)
            Strarq = value
        End Set
    End Property

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
                MsgBox("Dados alterados",
                        MsgBoxStyle.Information, "alteração realizada")
                Call AlterarLogin()
            End If
        End If
    End Sub
    Private Sub AlterarLogin()
        System.IO.File.WriteAllText("C:\\Users\\Administrator.SYSTI\\Downloads\\VB.net-master\\VB.net-master\\login\\login\\bin\\Debug\\Arquivos\\" & arquivo, "")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\Administrator.SYSTI\\Downloads\\VB.net-master\\VB.net-master\\login\\login\\bin\\Debug\\Arquivos\\" & arquivo, True)
        file.WriteLine(Cuser.Text)
        file.WriteLine(Csenha1.Text)
        file.WriteLine(Cemail.Text)
        file.Close()
        My.Computer.FileSystem.RenameFile("C:\\Users\\Administrator.SYSTI\\Downloads\\VB.net-master\\VB.net-master\\login\\login\\bin\\Debug\\Arquivos\\" & arquivo, Cuser.Text)
    End Sub


End Class