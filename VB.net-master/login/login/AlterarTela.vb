Imports System.Data.DataTable
Imports System.IO

Public Class alterarTela
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer
        Dim str As String
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(index)


        str = selectedRow.Cells(index).Value.ToString
        Dim alt As alterar = New alterar
        alt.arquivo = str

        alt.Show()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim directory = "C:\\Users\\Administrator.SYSTI\\Downloads\\VB.net-master\\VB.net-master\\login\\login\\bin\\Debug\\Arquivos"

        For Each file As String In My.Computer.FileSystem.GetFiles(directory)
            Dim str As String
            str = Path.GetFileName(file)
            Me.DataGridView1.Rows.Add(str)
        Next
    End Sub
End Class