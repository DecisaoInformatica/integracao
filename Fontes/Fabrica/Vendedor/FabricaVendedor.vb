
Public MustInherit Class FabricaVendedor
    Shared Function CriaVendedor() As I_Vendedor
        Dim Cl As New Geral.Utilitario
        Select Case Cl.SistemaImplementado.ToUpper()
            Case Is = "SCAE"
                Return New VendedorScae(Cl.SistemaImplementado.ToUpper())
            Case Is = "BHFORTE"
                Return New VendedorBHForte(Cl.SistemaImplementado.ToUpper())
        End Select

        Return Nothing
    End Function
End Class

