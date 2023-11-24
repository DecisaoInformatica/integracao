Public Class VendaBHForte
    Implements I_Venda
    Private ClAcesso As New AcessoDados.AcessoAdoNet
    Public Property Erro As String = ""
    Private Sistema_Implementado As String = "BHPECAS"
    Sub New(_Sistema_Implementado As String)
        Sistema_Implementado = _Sistema_Implementado
    End Sub

    Public Function Incluir_Cabecalho(Lista As PVenda) As Integer Implements I_Venda.Incluir_Cabecalho
        Throw New NotImplementedException()
    End Function

    Public Function Incluir_Item(Lista As PVenda_Item) As Boolean Implements I_Venda.Incluir_Item
        Throw New NotImplementedException()
    End Function

    Public Function Retorna_ID_Venda(Plataforma As String, Referencia As String) As String Implements I_Venda.Retorna_ID_Venda
        Throw New NotImplementedException()
    End Function
End Class