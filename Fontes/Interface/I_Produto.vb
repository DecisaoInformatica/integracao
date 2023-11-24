Public Interface I_Produto
    Enum Classificação
        CodMercadoria
        Nome
    End Enum
    Function Lista(Optional ByVal CodMercadoria As Long = 0, Optional ByVal Nome As String = "",
                         Optional ByVal Classificar As Classificação = Classificação.Nome,
                         Optional ByVal Descente As Boolean = False, Optional ByVal Ativo As Boolean = False, Optional CódigoBarra As String = ""
                        ) As List(Of Produto)
    Function Incluir(ByVal Lc As Produto) As Boolean
    Sub RecuperaInformaçãoNCM(NCM As String, ByRef Descricao As String, ByRef CEST As String)
    Function Excluir(ByVal Código As Long) As Boolean
    Function Alterar(ByVal Lc As Produto) As Boolean
End Interface
