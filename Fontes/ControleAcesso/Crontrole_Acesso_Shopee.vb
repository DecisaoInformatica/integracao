Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Crontrole_Acesso_Shopee
    Implements I_Controle_Acesso_Strategy


    Private Caminho_APP As String = "/api/v2/shop/auth_partner" ' "/api/v2/auth/token/get"

    Public Property Configuração As ConfiguracaoIntegracao Implements I_Controle_Acesso_Strategy.Configuração

    Public Function Gerar_String_Aprovação() As String Implements I_Controle_Acesso_Strategy.Gerar_String_Aprovação

        Dim Resposta As String = ""
        Resposta = AuthShop()
        Return Resposta
    End Function
    Private Function AuthShop() As String

        Dim redirectUrl As String = "https://open.shopee.com"

        Dim _TimeSpan As Integer = Shopee.Utilitário.Gera_Time_Spam()
        Dim baseString As String = String.Format("{0}{1}{2}", Configuração.ID_Aplicação, Caminho_APP, _TimeSpan)
        Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(Configuração.Senha_Aplicação)
        Dim sign As String = Get_Sign(_TimeSpan)
        Dim url As String = String.Format("{0}{1}?partner_id={2}&timestamp={3}&sign={4}&redirect={5}", Configuração.Endereço_Host, Caminho_APP, Configuração.ID_Aplicação, _TimeSpan, sign, Configuração.Endereço_Redirecionamento_Página)
        Return url
    End Function

    Private Function Get_Sign(timeSpan As Integer) As String
        Dim baseString As String = String.Format("{0}{1}{2}", Configuração.ID_Aplicação, Caminho_APP, timeSpan)
        Dim hmac As New HMACSHA256(Encoding.UTF8.GetBytes(Configuração.Senha_Aplicação))
        Dim sign As String = BitConverter.ToString(hmac.ComputeHash(Encoding.UTF8.GetBytes(baseString))).Replace("-", "").ToLower()
        Return sign
    End Function
End Class
