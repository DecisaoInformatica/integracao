
Public MustInherit Class FabricaVenda
    Shared Function CriaVenda() As I_Venda
        Dim Cl As New Geral.Utilitario
        Select Case Cl.SistemaImplementado.ToUpper()
            Case Is = "SCAE"
                Return New VendaScae(Cl.SistemaImplementado.ToUpper())
            Case Is = "BHFORTE"
                Return New VendaBHForte(Cl.SistemaImplementado.ToUpper())
        End Select

        Return Nothing
    End Function
End Class

