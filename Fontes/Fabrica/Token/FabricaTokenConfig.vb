
Public MustInherit Class FabricaTokenConfig
    Shared Function CriaTokenConfig() As I_TokenConfig
        Dim Cl As New Geral.Utilitario
        Return New TokenConfig(Cl.SistemaImplementado.ToUpper())
    End Function
End Class

