Public Class DAOTokenConfig
    Function Get_Token(Plataforma As String) As List(Of Token)
        Return FabricaTokenConfig.CriaTokenConfig.Get_Token(Plataforma)
    End Function
    Function Seta_Acess_Token(Plataforma As String, Acess_Token As String) As Boolean
        Return FabricaTokenConfig.CriaTokenConfig.Seta_Acess_Token(Plataforma, Acess_Token)
    End Function
    Function Seta_Refresh_Token(Plataforma As String, Refresh_Token As String) As Boolean
        Return FabricaTokenConfig.CriaTokenConfig.Seta_Refresh_Token(Plataforma, Refresh_Token)
    End Function
    Function Seta_Data_Expiração_Refresh_Token(Plataforma As String, Data_Expiração As String) As Boolean
        Return FabricaTokenConfig.CriaTokenConfig.Seta_Data_Expiração_Refresh_Token(Plataforma, Data_Expiração)
    End Function
    Function Seta_Token(ByVal _Token As Token) As Boolean
        Return FabricaTokenConfig.CriaTokenConfig.Seta_Token(_Token)
    End Function
End Class
