Public Interface I_Configuracao
    Function Get_Configuracao(Plataforma As String) As List(Of ConfiguracaoIntegracao)
    Function Seta_Codigo_Acesso(Plataforma As String, Codigo_Gerado As String) As Boolean
    Function Seta_Codigo_Loja(Plataforma As String, Codigo_Loja As String) As Boolean
    Function Seta_Parametro(ByVal _Configuracao As ConfiguracaoIntegracao) As Boolean
End Interface
