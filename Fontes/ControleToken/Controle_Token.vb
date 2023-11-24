Public Class Controle_Token
    Private _Controle As I_Controle_Token_Strategy
    Public Sub New(Controle As I_Controle_Token_Strategy)
        _Controle = Controle
    End Sub
    Public Function Get_Refresh_Token() As Token
        Return _Controle.Get_refresh_Token()
    End Function
    Public Function Get_Acess_Token(Refresh_Token As String) As Token
        Return _Controle.Get_Acess_Token(Refresh_Token)
    End Function
End Class
