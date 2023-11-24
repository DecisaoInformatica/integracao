Public Interface I_Controle_Token_Strategy
    Property Configuração As ConfiguracaoIntegracao
    Property Erro As String
    Property Erro_MSG As String
    Function Get_refresh_Token() As Token
    Function Get_Acess_Token(Refresh_Token As String) As Token
End Interface
