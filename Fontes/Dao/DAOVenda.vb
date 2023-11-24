Imports Microsoft.Web.WebView2

Public Class DAOVenda
    Function Incluir_Cabecalho(Lista As PVenda) As Integer
        Return FabricaVenda.CriaVenda.Incluir_Cabecalho(Lista)
    End Function
    Function Incluir_Item(Lista As PVenda_Item) As Boolean
        Return FabricaVenda.CriaVenda.Incluir_Item(Lista)
    End Function
    Function Retorna_ID_Venda(Plataforma As String, Referencia As String) As String
        Return FabricaVenda.CriaVenda.Retorna_ID_Venda(Plataforma, Referencia)
    End Function
End Class