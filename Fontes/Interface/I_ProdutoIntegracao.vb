Public Interface I_ProdutoIntegracao
    Function Get_ProdutoIntegração(Plataforma As String, ProdutoID As Integer, ProdutoID_Loja As String) As List(Of PProdutoIntegracao)
    Function Incluir(ProdutoIntegração As PProdutoIntegracao) As Boolean
    Function Seta_Token(ProdutoIntegração As PProdutoIntegracao) As Boolean
End Interface
