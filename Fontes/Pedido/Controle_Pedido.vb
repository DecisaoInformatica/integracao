Public Class Controle_Pedido
    Private _Controle As I_Pedido_Strategy
    Public Sub New(Controle As I_Pedido_Strategy)
        _Controle = Controle
    End Sub
    Function Get_Lista_Pedido(TipoPeríodo As String, DataInicio As String, DataFinal As String, Status_Pedido As String)
        Return _Controle.Get_Lista_Pedido(TipoPeríodo, DataInicio, DataFinal, Status_Pedido)
    End Function
    Function Atualizar_Pedido(Id_Pedido_Loja As String)
        Return _Controle.Atualizar_Pedido(Id_Pedido_Loja)
    End Function
    Function UploadArquivo(Nome_Arquivo As String, NumeroPedido_Shopee As String) As Boolean
        Return _Controle.UploadArquivo(Nome_Arquivo, NumeroPedido_Shopee)
    End Function
End Class
