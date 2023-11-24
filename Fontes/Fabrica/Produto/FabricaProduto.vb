
Public MustInherit Class FabricaProduto
    Shared Function CriaProduto() As I_Produto
        Dim Cl As New Geral.Utilitario
        Select Case Cl.SistemaImplementado.ToUpper()
            Case Is = "SCAE"
                Return New ProdutoScae(Cl.SistemaImplementado.ToUpper())
            Case Is = "BHFORTE"
                'Return New ProdutoBHForte(Cl.SistemaImplementado.ToUpper())
            Case = "CONVEST"
                'Return New ProdutoLidis(Cl.SistemaImplementado.ToUpper())
        End Select

        Return Nothing
    End Function
End Class

