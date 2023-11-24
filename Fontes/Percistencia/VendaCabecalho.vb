Imports IntegracaoMarkPlace.Shopee

Public Class VendaCabecalho
    Public Property IDVenda As Integer
    Public Property CodVenda_Gerado As String
    Public Property ID_Loja As String
    Public Property Emissao As String
    Public Property Cliente_Nome As String
    Public Property Cliente_CPF As String
    Public Property Cliente_ID As Integer
    Public Property Valor_Total As Decimal
    Public Property Forma_Pag As String
    Public Property Itens As List(Of VendaDados)
    Public Property Cliente_Endereço As RecipientAddress
End Class
