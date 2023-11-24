Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NUnit.Framework
Imports IntegracaoMarkPlace
Imports Assert = NUnit.Framework.Assert
Imports Microsoft.Win32

<TestFixture, TestClass> Public Class TesteAutorização
#Region "Funções uteis"
    Private Const Plataforma As String = "Shopee"
    Private Function Get_Configuração() As ConfiguracaoIntegracao
        Dim Dao_Config As New DAOConfiguracao
        Dim Lista_Configuração As List(Of ConfiguracaoIntegracao) = Dao_Config.Get_Configuracao(Plataforma)
        If Lista_Configuração.Count = 0 Then Throw New Exception("Não foi feita a configuração do sistema, configure antes de autenticar")
        Return Lista_Configuração(0)
    End Function
#End Region
    <Test, TestMethod, Order(1)> Public Sub Teste_Recuperar_String_Autorização()
        Dim _Controle_Atual As I_Controle_Acesso_Strategy = New Crontrole_Acesso_Shopee
        _Controle_Atual.Configuração = Get_Configuração()
        Dim _Controle_Acesso As New Controle_Acesso(_Controle_Atual)
        Dim Str_Acesso As String = _Controle_Acesso.Get_String_Acesso
        Assert.IsTrue(Str_Acesso.Contains(_Controle_Atual.Configuração.Endereço_Host.ToString), "Host Não Encontrado.")
        Assert.IsTrue(Str_Acesso.Contains(_Controle_Atual.Configuração.ID_Aplicação.ToString), "ID da Aplicação Não Encontrado.")
        Assert.IsTrue(Str_Acesso.Contains(_Controle_Atual.Configuração.Endereço_Redirecionamento_Página), "Endereço do redirecionamento Não Encontrado.")
    End Sub
End Class
