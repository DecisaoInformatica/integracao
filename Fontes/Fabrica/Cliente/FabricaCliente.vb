
Public MustInherit Class FabricaCliente
    Shared Function CriaCliente() As I_Cliente
        Dim Cl As New Geral.Utilitario
        Select Case Cl.SistemaImplementado.ToUpper()
            Case Is = "SCAE"
                Return New ClienteScae(Cl.SistemaImplementado.ToUpper())
            Case Is = "BHFORTE"
                Return New ClienteBHForte(Cl.SistemaImplementado.ToUpper())
        End Select

        Return Nothing
    End Function
End Class

