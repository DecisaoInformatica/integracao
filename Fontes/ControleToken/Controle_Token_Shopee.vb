Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Numerics
Imports System.Security.Cryptography
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Controle_Token_Shopee
    Implements I_Controle_Token_Strategy
    Public Property Configuração As ConfiguracaoIntegracao Implements I_Controle_Token_Strategy.Configuração
    Private Caminho_RefreshToken As String = "/api/v2/auth/token/get"
    Private Caminho_Acess_Token As String = "/api/v2/auth/access_token/get"
    Public Property Erro As String = "" Implements I_Controle_Token_Strategy.Erro
    Public Property Erro_MSG As String = "" Implements I_Controle_Token_Strategy.Erro_MSG
    'https://partner.test-stable.shopeemobile.com/
    Public Function Get_refresh_Token() As Token Implements I_Controle_Token_Strategy.Get_refresh_Token
        Dim _Token As New Token
        Try
            ' _Token = GetTokenShopLevel()
            Dim Resposta As Dictionary(Of String, String) = GetToken(Configuração.CodGerado, Configuração.ID_Aplicação, Configuração.Senha_Aplicação, Configuração.Loja_ID)
            _Token.Plataforma = "Shopee"
            _Token.ID = 0
            _Token.Acess_Token = Resposta("access_token")
            _Token.Refresh_Token = Resposta("refresh_token")
            _Token.Expiracao_Refresh_Token = Format(Date.Now.AddDays(30))
        Catch ex As Exception
            ' MsgBox(ex.Message)
            _Token = New Token
        End Try

        Return _Token
    End Function

    Public Function Get_Acess_Token(Refresh_Token As String) As Token Implements I_Controle_Token_Strategy.Get_Acess_Token
        Dim _Token As New Token
        Try
            Dim Resposta As Dictionary(Of String, String) = GetAccessToken(Configuração.ID_Aplicação, Configuração.Senha_Aplicação, Configuração.Loja_ID, Refresh_Token)
            _Token.Plataforma = "Shopee"
            _Token.ID = 0
            _Token.Acess_Token = Resposta("access_token")
            _Token.Refresh_Token = Resposta("refresh_token")
            _Token.Expiracao_Refresh_Token = Format(Date.Now.AddDays(30))

        Catch ex As Exception
            _Token = New Token
        End Try

        Return _Token
    End Function
    Function GetAccessToken(ByVal partnerId As Integer, ByVal partnerKey As String, ByVal shopId As Integer, ByVal refreshToken As String) As Dictionary(Of String, String)
        Dim host As String = Configuração.Endereço_Host
        Dim timest As Long = Shopee.Utilitário.Gera_Time_Spam()
        Dim body As String = "{""partner_id"": " & partnerId & ", ""shop_id"": " & shopId & ", ""refresh_token"": """ & refreshToken & """}"
        Dim baseString As String = partnerId & Caminho_Acess_Token & timest

        Dim hmac As New HMACSHA256(Encoding.UTF8.GetBytes(partnerKey))
        Dim signBytes As Byte() = hmac.ComputeHash(Encoding.UTF8.GetBytes(baseString))
        Dim sign As String = BitConverter.ToString(signBytes).Replace("-", "").ToLower()
        Dim url As String = host & Caminho_Acess_Token & "?partner_id=" & partnerId & "&timestamp=" & timest & "&sign=" & sign

        Dim request As HttpWebRequest = WebRequest.Create(url)
        request.Method = "POST"
        request.ContentType = "application/json"
        Dim dataBytes As Byte() = Encoding.UTF8.GetBytes(body)
        request.ContentLength = dataBytes.Length
        Using requestStream As Stream = request.GetRequestStream()
            requestStream.Write(dataBytes, 0, dataBytes.Length)
        End Using

        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(responseStream)
        Dim result As String = reader.ReadToEnd()
        reader.Close()
        responseStream.Close()
        response.Close()

        Dim accessToken As String = ""
        Dim newRefreshToken As String = ""

        If Not String.IsNullOrEmpty(result) Then
            'Dim jsonObject As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(result)
            Dim ret As JObject = JObject.Parse(result)
            If ret IsNot Nothing Then
                Dim Msg_Erro As String = ret("message").ToString()
                Dim _Erro As String = ret("error").ToString()
                If _Erro.Length = 0 Then
                    accessToken = ret("access_token").ToString()
                    newRefreshToken = ret("refresh_token").ToString()
                    Dim Expira_em As String = ret("expire_in").ToString()
                    Dim Data_Expiração As String = Geral.Utilitario.Converter_TimeSpan_Date_Time(Expira_em)
                Else
                    Erro = _Erro
                    Erro_MSG = Msg_Erro
                End If
            End If

        End If
        Dim resposta As New Dictionary(Of String, String) From {
            {"access_token", accessToken},
            {"refresh_token", newRefreshToken}
        }

        Return resposta
    End Function
    Function GetToken(code As String, partnerId As Long, partnerKey As String, shopId As Long) As Dictionary(Of String, String)
        Dim host As String = Configuração.Endereço_Host '  "https://partner.test-stable.shopeemobile.com"
        Dim timest As Long = Shopee.Utilitário.Gera_Time_Spam()
        Dim body As New Dictionary(Of String, Object) From {
            {"code", code},
            {"shop_id", shopId},
            {"partner_id", partnerId}
        }
        Dim baseString As String = $"{partnerId}{Caminho_RefreshToken}{timest}"
        Dim sign As String = CalculateHMACSHA256(baseString, partnerKey)
        Dim url As String = $"{host}{Caminho_RefreshToken}?partner_id={partnerId}&timestamp={timest}&sign={sign}"

        Dim client As New WebClient()
        client.Headers.Add("Content-Type", "application/json")

        Dim jsonBody As String = JsonConvert.SerializeObject(body)
        Dim responseBytes As Byte() = client.UploadData(url, "POST", Encoding.UTF8.GetBytes(jsonBody))
        Dim responseJson As String = Encoding.UTF8.GetString(responseBytes)

        Console.WriteLine($"Raw Result: {responseJson}")

        Dim ret As JObject = JObject.Parse(responseJson)

        Dim Msg_Erro As String = ret("message").ToString()
        Dim _Erro As String = ret("error").ToString()
        Dim accessToken As String = ""
        Dim newRefreshToken As String = ""

        If _Erro.Length = 0 Then
            accessToken = ret("access_token").ToString()
            newRefreshToken = ret("refresh_token").ToString()
            Dim Expira_em As String = ret("expire_in").ToString()
            Dim Data_Expiração As String = Geral.Utilitario.Converter_TimeSpan_Date_Time(Expira_em)
        Else
            Erro = _Erro
            Erro_MSG = Msg_Erro
        End If

        Dim result As New Dictionary(Of String, String) From {
            {"access_token", accessToken},
            {"refresh_token", newRefreshToken}
        }

        Return result
    End Function
    Function CalculateHMACSHA256(input As String, key As String) As String
        Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(key)
        Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
        Using hmacsha256 As New HMACSHA256(keyBytes)
            Dim hashBytes As Byte() = hmacsha256.ComputeHash(inputBytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function

End Class
