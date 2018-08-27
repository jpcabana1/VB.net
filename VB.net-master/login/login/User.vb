Public Class User
    Private Strnome As String
    Public Property nome() As String
        Get
            Return Strnome
        End Get
        Set(ByVal value As String)
            Strnome = value
        End Set
    End Property

    Private Stremail As String
    Public Property email() As String
        Get
            Return Stremail
        End Get
        Set(ByVal value As String)
            Stremail = value
        End Set
    End Property
    Private Strsenha As String
    Public Property senha() As String
        Get
            Return Strsenha
        End Get
        Set(ByVal value As String)
            Strsenha = value
        End Set
    End Property
End Class
