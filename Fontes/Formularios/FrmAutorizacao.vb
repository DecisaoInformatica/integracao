Imports Microsoft.Web.WebView2.Core

Public Class FrmAutorizacao
    Private Configuração As New ConfiguracaoIntegracao
    Public Property Plataforma As String = ""
    Private _PaginaAtual As String = ""
    Private Sub Get_Configuração()
        Dim Dao_Config As New DAOConfiguracao
        Dim Lista_Configuração As List(Of ConfiguracaoIntegracao) = Dao_Config.Get_Configuracao(Plataforma)
        If Lista_Configuração.Count = 0 Then Throw New Exception("Não foi feita a configuração do sistema, configure antes de autenticar")
        Configuração = Lista_Configuração(0)
    End Sub
    Private Sub FrmAutorizacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Plataforma.Length = 0 Then Throw New Exception("A Plataforma a ser usada não foi informada,Informa a plataforma para a autenticação")
            Get_Configuração()
            Me.Text = "Autorização para integrar a plataforma " & Plataforma

            Dim _Controle_Atual As I_Controle_Acesso_Strategy = Seleciona_Controle(Plataforma)
            _Controle_Atual.Configuração = Configuração

            Dim _Controle_Acesso As New Controle_Acesso(_Controle_Atual)

            Dim Str_Acesso As String = _Controle_Acesso.Get_String_Acesso
            If Str_Acesso.Length = 0 Then Throw New Exception("Falha recuperando o endereço de acesso da autorização")

            Acessa_Pagina_Autorização(Str_Acesso)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Informação insuficiente")
        End Try

    End Sub
    Private Sub Acessa_Pagina_Autorização(Url As String)
        WebView21.Source = New Uri(Url)
    End Sub
    Private Function Seleciona_Controle(Plataforma As String) As I_Controle_Acesso_Strategy
        Dim Resposta As I_Controle_Acesso_Strategy
        If Plataforma.ToUpper = "SHOPEE" Then Resposta = New Crontrole_Acesso_Shopee

        Return Resposta

    End Function
    Private Function Seleciona_Controle_Token(Plataforma As String) As I_Controle_Token_Strategy
        Dim Resposta As I_Controle_Token_Strategy
        If Plataforma.ToUpper = "SHOPEE" Then Resposta = New Controle_Token_Shopee

        Return Resposta

    End Function
    Private Sub WebView21_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted
        Dim Capt As String = Me.Text
        Try
            Dim Tamanho_End_Redirect As Integer = Configuração.Endereço_Redirecionamento_Página.Length
            If _PaginaAtual.Substring(0, Tamanho_End_Redirect) = Configuração.Endereço_Redirecionamento_Página Then
                'Stop
                Me.Text = "Recuperando dados retornados..."
                Application.DoEvents()
                Dim _Separa_Base() As String = _PaginaAtual.Split("?")
                Dim Codigo_Gerado As String = ""
                Dim Codigo_Loja As String = ""
                If _Separa_Base.Length = 2 Then
                    Dim Separa_Codigo_Loja_ID() As String = _Separa_Base(1).Split("&")
                    For i = 0 To Separa_Codigo_Loja_ID.Length - 1
                        If i = 0 Then
                            Codigo_Gerado = Separa_Codigo_Loja_ID(i).Replace("code=", "")
                        End If
                        If i = 1 Then
                            Codigo_Loja = Separa_Codigo_Loja_ID(i).Replace("shop_id=", "")
                        End If
                    Next
                    '==> Grava os dados
                    Me.Text = "Atualizando a configuração..."
                    Application.DoEvents()
                    If Not Grava_Dados_Configuração(Codigo_Gerado, Codigo_Loja) Then Throw New Exception("Erro gravando os dados de autorização de acesso.")
                    Get_Configuração()
                    Me.Text = "Gerando token de acesso..."
                    Application.DoEvents()
                    If Not Gerar_Token() Then Throw New Exception("Erro Gerando o Token de acesso")
                    MsgBox("Token gerado com sucesso!", 64, "Aviso")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Function Gerar_Token() As Boolean
        Dim Resposta As Boolean = False

        Dim _Controle_Atual As I_Controle_Token_Strategy = Seleciona_Controle_Token(Plataforma)
        _Controle_Atual.Configuração = Configuração
        Dim _Token As Token = _Controle_Atual.Get_refresh_Token()
        If _Controle_Atual.Erro.Length = 0 Then
            If _Token IsNot Nothing Then
                Grava_Token(_Token)
                Resposta = True
            End If
        Else
            MsgBox("Erro gerando o Token de acesso:" & _Controle_Atual.Erro & " - " & _Controle_Atual.Erro_MSG, 64, "Aviso")
        End If


        Return Resposta
    End Function
    Private Function Grava_Dados_Configuração(Codigo_Gerado As String, Codigo_Loja As String) As Boolean
        Dim Resposta As Boolean = False
        ' Try
        Dim Dao_Config As New DAOConfiguracao
        If Not Dao_Config.Seta_Código_Loja(Configuração.Plataforma, Codigo_Loja) Then Throw New Exception("Erro Salvando o codigo gerado para a loja")
        If Not Dao_Config.Seta_Código_Acesso(Configuração.Plataforma, Codigo_Gerado) Then Throw New Exception("Erro Salvando o codigo gerado para acesso")
        Resposta = True



        Return Resposta
    End Function
    Private Function Grava_Token(_Token As Token) As Boolean
        Dim Resposta As Boolean = False
        ' Try
        Dim Dao_Token As New DAOTokenConfig
        If Not Dao_Token.Seta_Token(_Token) Then Throw New Exception("Erro Gravando o token Gerado")
        Resposta = True

        Return Resposta
    End Function

    Private Sub WebView21_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs) Handles WebView21.NavigationStarting
        _PaginaAtual = e.Uri
    End Sub

    Private Sub WebView21_Click(sender As Object, e As EventArgs) Handles WebView21.Click

    End Sub
End Class