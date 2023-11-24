Public Interface I_Venda
    Function Incluir_Cabecalho(Lista As PVenda) As Integer
    Function Incluir_Item(Lista As PVenda_Item) As Boolean
    Function Retorna_ID_Venda(Plataforma As String, Referencia As String) As String
End Interface
