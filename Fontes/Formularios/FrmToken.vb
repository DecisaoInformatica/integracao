Public Class FrmToken
    Private Configuração As New ConfiguracaoIntegracao
    Sub Get_Configuração()
        Dim Dao_Config As New DAOConfiguracao
        Dim Lista_Configuração As List(Of ConfiguracaoIntegracao) = Dao_Config.Get_Configuracao(Plataforma.Text)
        If Lista_Configuração.Count = 0 Then Throw New Exception("Não foi feita a configuração do sistema, configure antes de autenticar")
        Configuração = Lista_Configuração(0)
    End Sub
    Sub Buscar_Token()

        Dim Dao_Token As New DAOTokenConfig
        Dim Lista_Token As List(Of Token) = Dao_Token.Get_Token(Plataforma.Text)
        If Lista_Token.Count > 0 Then
            ID.Text = Lista_Token(0).ID
            Expiracao.Text = Lista_Token(0).Expiracao_Refresh_Token
            Acess_Token.Text = Lista_Token(0).Acess_Token
            Refresh_Token.Text = Lista_Token(0).Refresh_Token
        End If
    End Sub
    Private Sub FrmToken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Plataforma.Text.Length > 0 Then Buscar_Token()
        Get_Configuração()
    End Sub

    Private Sub Plataforma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Plataforma.SelectedIndexChanged
        If Plataforma.Text.Length > 0 Then Buscar_Token()
    End Sub

    Private Sub CmdGerarToken_Click(sender As Object, e As EventArgs) Handles CmdGerarToken.Click
        Gerar_Token()
    End Sub
    Private Function Gerar_Token() As Boolean
        Dim Resposta As Boolean = False


        Dim _Controle_Atual As I_Controle_Token_Strategy = Seleciona_Controle_Token(Plataforma.Text)
        _Controle_Atual.Configuração = Configuração

        Dim _Token As Token = _Controle_Atual.Get_refresh_Token()
        If _Token IsNot Nothing Then
            Resposta = True
            Grava_Token(_Token)
            Buscar_Token()
        End If

        Return Resposta
    End Function
    Function Seleciona_Controle_Token(Plataforma As String) As I_Controle_Token_Strategy
        Dim Resposta As I_Controle_Token_Strategy
        If Plataforma.ToUpper = "SHOPEE" Then Resposta = New Controle_Token_Shopee

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
End Class