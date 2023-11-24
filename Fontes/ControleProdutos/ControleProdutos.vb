Public Class ControleProdutos
    Private _ControleProduto As I_Produto_Strategy
    Public Sub New(ControleProduto As I_Produto_Strategy)
        _ControleProduto = ControleProduto
    End Sub
    Public Function Get_Lista_Produto() As List(Of ProdutosExibir)
        Return _ControleProduto.Busca_Produto()
    End Function
    Public Sub Seta_Preço_Loja(ByRef Lista_Dados_Produto As List(Of BaseAtualização))
         _ControleProduto.Alterar_Preço(Lista_Dados_Produto)
    End Sub
    Public Sub Seta_Quantidade_Loja(ByRef Lista_Dados_Produto As List(Of BaseAtualização))
        _ControleProduto.Alterar_Quantidade(Lista_Dados_Produto)
    End Sub
End Class
