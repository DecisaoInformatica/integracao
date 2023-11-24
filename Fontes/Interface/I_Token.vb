Public Interface I_TokenConfig
    Function Get_Token(Plataforma As String) As List(Of Token)
    Function Seta_Acess_Token(Plataforma As String, Acess_Token As String) As Boolean
    Function Seta_Refresh_Token(Plataforma As String, Refresh_Token As String) As Boolean
    Function Seta_Data_Expiração_Refresh_Token(Plataforma As String, Data_Expiração As String) As Boolean
    Function Seta_Token(ByVal _Token As Token) As Boolean
End Interface
