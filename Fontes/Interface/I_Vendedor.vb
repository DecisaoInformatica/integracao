Public Interface I_Vendedor
    Function Retorna_Vendedor(ByVal Nome As String) As List(Of PVendedor)
    Function Incluir(ByVal Lista As PVendedor) As Boolean
End Interface
