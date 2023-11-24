
Public MustInherit Class FabricaProdutoIntegracao
    Shared Function CriaProdutoIntegracao() As I_ProdutoIntegracao
        Dim Cl As New Geral.Utilitario
        Select Case Cl.SistemaImplementado.ToUpper()
            Case Is = "SCAE"
                Return New ProdutoIntegracaoScae(Cl.SistemaImplementado.ToUpper())
            Case Is = "BHFORTE"
                'Return New ProdutoIntegracaoBHPecas(Cl.SistemaImplementado.ToUpper())
            Case = "CONVEST"
                'Return New ProdutoIntegracaoLidis(Cl.SistemaImplementado.ToUpper())
        End Select

        Return Nothing
    End Function
End Class

