Public Class PVenda
    Public Property CodVenda As Integer
    Public Property Referencia As String
    Public Property Plataforma As String
    Public Property DataVenda As Date
    Public Property Hora As String
    Public Property CodVendedor As Integer
    Public Property NomeVendedor As String
    Public Property CodCliente As Integer
    Public Property NomeCliente As String
    Public Property TipoVenda As String
    Public Property TipoPag As String
    Public Property ValorVenda As Decimal
    Public Property CustoTotal As Decimal
End Class
Public Class PVenda_Item
    Public Property CodVenda As Integer
    Public Property CodVendaItem As Integer
    Public Property NumItem As Integer
    Public Property CodMercadoria As Integer
    Public Property Descricao As String
    Public Property Unidade As String
    Public Property Quantidade As Decimal
    Public Property ValorUnit As Decimal
    Public Property SubTotal As Decimal
    Public Property CustoUnit As Decimal
    Public Property CodFornecedor As Integer
End Class


