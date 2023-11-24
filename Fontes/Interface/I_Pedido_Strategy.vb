Public Interface I_Pedido_Strategy
    Event Informação_Processo(Descrição As String)
    Property Configuração As ConfiguracaoIntegracao
    Property AcessToken As String
    Property Erro As String
    Property Erro_MSG As String
    Function Get_Lista_Pedido(TipoPeríodo As String, DataInicio As String, DataFinal As String, Status_Pedido As String) As List(Of VendaCabecalho)
    Function Atualizar_Pedido(Id_Pedido_Loja As String)
    Function UploadArquivo(Nome_Arquivo As String, NumeroPedido_Shopee As String) As Boolean
    Function Cancelar_Pedido(Pedido_Loja As String, Lista_Itens_Cancelar As List(Of BaseAtualização)) As Boolean
End Interface
