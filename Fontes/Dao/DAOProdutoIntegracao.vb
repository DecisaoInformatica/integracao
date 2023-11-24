Imports IntegracaoMarkPlace.Shopee

Public Class DAOProdutoIntegracao
    Function Get_ProdutoIntegração(Plataforma As String, ProdutoID As Integer, ProdutoID_Loja As String) As List(Of PProdutoIntegracao)
        Return FabricaProdutoIntegracao.CriaProdutoIntegracao.Get_ProdutoIntegração(Plataforma, ProdutoID, ProdutoID_Loja)
    End Function
    Function Incluir(ProdutoIntegração As PProdutoIntegracao) As Boolean
        Return FabricaProdutoIntegracao.CriaProdutoIntegracao.Incluir(ProdutoIntegração)
    End Function

    Function Seta_Token(ProdutoIntegração As PProdutoIntegracao) As Boolean
        Return FabricaProdutoIntegracao.CriaProdutoIntegracao.Seta_Token(ProdutoIntegração)
    End Function
End Class
