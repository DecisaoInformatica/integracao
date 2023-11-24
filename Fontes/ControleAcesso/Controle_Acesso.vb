Public Class Controle_Acesso
    Private _Controle As I_Controle_Acesso_Strategy
    Public Sub New(Controle As I_Controle_Acesso_Strategy)
        _Controle = Controle
    End Sub
    Public Function Get_String_Acesso() As String
        Return _Controle.Gerar_String_Aprovação()

    End Function
End Class
