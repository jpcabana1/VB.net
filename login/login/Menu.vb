Public Class Menu
    Private Sub cadastro_Click(sender As Object, e As EventArgs) Handles cadastro.Click
        Dim cad As Cadastrar = New Cadastrar
        cad.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim alt As alterar = New alterar
        alt.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim remover As remover = New remover
        remover.Show()
    End Sub
End Class