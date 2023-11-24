
Public MustInherit Class FabricaConfiguracao
    Shared Function CriaConfiguracao() As I_Configuracao
        Dim Cl As New Geral.Utilitario
        Return New Configuracao(Cl.SistemaImplementado.ToUpper())
    End Function
End Class

