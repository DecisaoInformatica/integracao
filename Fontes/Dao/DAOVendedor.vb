Imports Microsoft.Web.WebView2

Public Class DAOVendedor
    Function Retorna_Vendedor(Nome As String) As List(Of PVendedor)
        Return FabricaVendedor.CriaVendedor.Retorna_Vendedor(Nome)
    End Function
    Function Incluir(Lista As PVendedor) As Boolean
        Return FabricaVendedor.CriaVendedor.Incluir(Lista)
    End Function
End Class