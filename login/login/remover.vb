Public Class remover
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Computer.FileSystem.DeleteFile(TextBox1.Text)
            MsgBox("Usuário removido", MsgBoxStyle.Information, "Removido")
        Catch ex As Exception
            MsgBox("Erro ao remover usuário", MsgBoxStyle.Critical, "Erro")
        End Try

    End Sub
End Class