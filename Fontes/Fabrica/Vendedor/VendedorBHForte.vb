Public Class VendedorBHForte
    Implements I_Vendedor
    Private ClAcesso As New AcessoDados.AcessoAdoNet
    Public Property Erro As String = ""
    Private Sistema_Implementado As String = "BHPECAS"
    Sub New(_Sistema_Implementado As String)
        Sistema_Implementado = _Sistema_Implementado
    End Sub
    Public Function Retorna_Vendedor(Nome As String) As List(Of PVendedor) Implements I_Vendedor.Retorna_Vendedor
        Throw New NotImplementedException()
    End Function

    Public Function Incluir(Lista As PVendedor) As Boolean Implements I_Vendedor.Incluir
        Throw New NotImplementedException()
    End Function
End Class