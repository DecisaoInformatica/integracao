Imports IntegracaoMarkPlace.Shopee

Public Class DAOConfiguracao
    Public Property Erro As String = ""
    Public Function Get_Configuracao(Plataforma As String) As List(Of ConfiguracaoIntegracao)
        Return FabricaConfiguracao.CriaConfiguracao.Get_Configuracao(Plataforma)
    End Function

    Public Function Seta_Código_Acesso(Plataforma As String, Codigo_Gerado As String) As Boolean
        Return FabricaConfiguracao.CriaConfiguracao.Seta_Codigo_Acesso(Plataforma, Codigo_Gerado)
    End Function
    Public Function Seta_Código_Loja(Plataforma As String, Codigo_Loja As String) As Boolean
        Return FabricaConfiguracao.CriaConfiguracao.Seta_Codigo_Loja(Plataforma, Codigo_Loja)
    End Function
    Public Function Seta_Parâmetro(ByVal _Configuracao As ConfiguracaoIntegracao) As Boolean
        Erro = Valida_Configuração(_Configuracao)
        If Erro.Length = 0 Then
            Return FabricaConfiguracao.CriaConfiguracao.Seta_Parametro(_Configuracao)
        Else
            Return False
        End If


    End Function
    Private Function Valida_Configuração(_Configuracao As ConfiguracaoIntegracao) As String
        Dim Resposta As String = ""
        If _Configuracao.Endereço_Redirecionamento_Página.Length = 0 Then Resposta = "Endereço de redirecionamento Inválido."
        If _Configuracao.Endereço_Host.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Endereço do Host Inválido."
        End If

        If _Configuracao.ID_Aplicação = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "ID da Aplicação inválido."
        End If
        If _Configuracao.Loja_ID.ToString.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "ID da Loja inválido."
        End If
        If _Configuracao.Plataforma.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Plataforma não informada."
        End If
        If _Configuracao.Senha_Aplicação.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Senha da aplicação não informada."
        End If
        Return Resposta
    End Function
End Class
