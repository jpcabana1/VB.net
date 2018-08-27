Imports System.IO
Public Class Listar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lista As List(Of User) = New List(Of User)

        Dim directory = "C:\\Users\\Administrator.SYSTI\\Downloads\\VB.net-master\\VB.net-master\\login\\login\\bin\\Debug\\Arquivos"


        For Each file As String In My.Computer.FileSystem.GetFiles(directory)
            'Fazer leitura'
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(file)
            Dim stringReader As String
            stringReader = fileReader.ReadLine()

            'Alocar objeto e preencher atributos'
            Dim obj As User = New User
            obj.nome = stringReader
            stringReader = fileReader.ReadLine()
            obj.email = stringReader
            stringReader = fileReader.ReadLine()
            obj.senha = stringReader

            'Adicionar objeto na lista'
            lista.Add(obj)
        Next
        For Each obj As User In lista
            Me.DataGridView1.Rows.Add(obj.nome, obj.senha, obj.email)
        Next

    End Sub


End Class