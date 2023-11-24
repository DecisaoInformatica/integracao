Public Interface I_Produto_Strategy
    Event Informação_Processo(Descrição As String)
    Property Configuração As ConfiguracaoIntegracao
    Property AcessToken As String
    Property Status_Pesquisar As String
    Property Erro As String
    Property Erro_MSG As String
    Function Get_refresh_Token() As Token
    Property DataInicio As String
    Property DataFim As String
    Function Busca_Produto() As List(Of ProdutosExibir)
    Sub Alterar_Preço(ByRef Lista_dados_Produto As List(Of BaseAtualização))
    Sub Alterar_Quantidade(ByRef Lista_dados_Produto As List(Of BaseAtualização))
End Interface
