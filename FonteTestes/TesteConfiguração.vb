Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NUnit.Framework
Imports IntegracaoMarkPlace
Imports Assert = NUnit.Framework.Assert
Imports Microsoft.Win32

<TestFixture, TestClass>
Public Class TesteConfiguração
    Private _Configuração As ConfiguracaoIntegracao
    Private _DaoConfiguracao As DAOConfiguracao
#Region "Funções uteis"
    Sub Configuração_Correta()
        _Configuração = New ConfiguracaoIntegracao
        _Configuração.Endereço_Host = "https://partner.test-stable.shopeemobile.com"
        _Configuração.CodGerado = "62784f475a6c785744657a4347676b76"
        _Configuração.Endereço_Redirecionamento_Página = "https://open.shopee.com"
        _Configuração.ID = 0
        _Configuração.ID_Aplicação = "1057994"
        _Configuração.Loja_ID = "92819"
        _Configuração.Plataforma = "Shopee"
        _Configuração.Senha_Aplicação = "486a69474b785769516a4e46646c54675a624c4c61756772476c6d5555735253"
    End Sub
    Sub Configuração_Falta_Plataforma()
        _Configuração = New ConfiguracaoIntegracao
        _Configuração.Endereço_Host = "https://partner.test-stable.shopeemobile.com"
        _Configuração.CodGerado = "62784f475a6c785744657a4347676b76"
        _Configuração.Endereço_Redirecionamento_Página = "https://open.shopee.com"
        _Configuração.ID = 0
        _Configuração.ID_Aplicação = "1057994"
        _Configuração.Loja_ID = "92819"
        _Configuração.Plataforma = ""
        _Configuração.Senha_Aplicação = "486a69474b785769516a4e46646c54675a624c4c61756772476c6d5555735253"
    End Sub
    Sub Configuração_Falta_Senha_Aplicação()
        _Configuração = New ConfiguracaoIntegracao
        _Configuração.Endereço_Host = "https://partner.test-stable.shopeemobile.com"
        _Configuração.CodGerado = "62784f475a6c785744657a4347676b76"
        _Configuração.Endereço_Redirecionamento_Página = "https://open.shopee.com"
        _Configuração.ID = 0
        _Configuração.ID_Aplicação = "1057994"
        _Configuração.Loja_ID = "92819"
        _Configuração.Plataforma = "Shopee"
        _Configuração.Senha_Aplicação = ""
    End Sub
    Sub Configuração_Falta_ID_Loja()
        _Configuração = New ConfiguracaoIntegracao
        _Configuração.Endereço_Host = "https://partner.test-stable.shopeemobile.com"
        _Configuração.CodGerado = "62784f475a6c785744657a4347676b76"
        _Configuração.Endereço_Redirecionamento_Página = "https://open.shopee.com"
        _Configuração.ID = 0
        _Configuração.ID_Aplicação = "1057994"
        _Configuração.Loja_ID = ""
        _Configuração.Plataforma = "Shopee"
        _Configuração.Senha_Aplicação = "486a69474b785769516a4e46646c54675a624c4c61756772476c6d5555735253"
    End Sub
    Sub Configuração_Falta_IDAplicação()
        _Configuração = New ConfiguracaoIntegracao
        _Configuração.Endereço_Host = "https://partner.test-stable.shopeemobile.com"
        _Configuração.CodGerado = "62784f475a6c785744657a4347676b76"
        _Configuração.Endereço_Redirecionamento_Página = "https://open.shopee.com"
        _Configuração.ID = 0
        _Configuração.ID_Aplicação = 0
        _Configuração.Loja_ID = "92819"
        _Configuração.Plataforma = "Shopee"
        _Configuração.Senha_Aplicação = "486a69474b785769516a4e46646c54675a624c4c61756772476c6d5555735253"
    End Sub
    Sub Configuração_Falta_Redirecionamento()
        _Configuração = New ConfiguracaoIntegracao
        _Configuração.Endereço_Host = "https://partner.test-stable.shopeemobile.com"
        _Configuração.CodGerado = "62784f475a6c785744657a4347676b76"
        _Configuração.Endereço_Redirecionamento_Página = ""
        _Configuração.ID = 0
        _Configuração.ID_Aplicação = "1057994"
        _Configuração.Loja_ID = "92819"
        _Configuração.Plataforma = "Shopee"
        _Configuração.Senha_Aplicação = "486a69474b785769516a4e46646c54675a624c4c61756772476c6d5555735253"

    End Sub
    Sub Configuração_Falta_Host()
        _Configuração = New ConfiguracaoIntegracao
        _Configuração.Endereço_Host = ""
        _Configuração.CodGerado = "62784f475a6c785744657a4347676b76"
        _Configuração.Endereço_Redirecionamento_Página = "https://open.shopee.com"
        _Configuração.ID = 0
        _Configuração.ID_Aplicação = "1057994"
        _Configuração.Loja_ID = "92819"
        _Configuração.Plataforma = "Shopee"
        _Configuração.Senha_Aplicação = "486a69474b785769516a4e46646c54675a624c4c61756772476c6d5555735253"
    End Sub
#End Region

    <Test, TestMethod, Order(1)> Public Sub Teste_Inclusão_erro()
        _DaoConfiguracao = New DAOConfiguracao
        Dim Resposta As Boolean = False
        Configuração_Falta_Host()
        Resposta = _DaoConfiguracao.Seta_Parâmetro(_Configuração)
        Assert.IsFalse(Resposta, "Falha ao validar a configuração Deveria falhar informação do Host")

        Configuração_Falta_IDAplicação()
        Resposta = _DaoConfiguracao.Seta_Parâmetro(_Configuração)
        Assert.IsFalse(Resposta, "Falha ao validar a configuração Deveria falhar informação ID da Aplicação")

        Configuração_Falta_ID_Loja()
        Resposta = _DaoConfiguracao.Seta_Parâmetro(_Configuração)
        Assert.IsFalse(Resposta, "Falha ao validar a configuração Deveria falhar informação ID da Loja")

        Configuração_Falta_Plataforma()
        Resposta = _DaoConfiguracao.Seta_Parâmetro(_Configuração)
        Assert.IsFalse(Resposta, "Falha ao validar a configuração Deveria falhar informação da Plataforma")

        Configuração_Falta_Redirecionamento()
        Resposta = _DaoConfiguracao.Seta_Parâmetro(_Configuração)
        Assert.IsFalse(Resposta, "Falha ao validar a configuração Deveria falhar informação  da página de redirecionamento")

        Configuração_Falta_Senha_Aplicação()
        Resposta = _DaoConfiguracao.Seta_Parâmetro(_Configuração)
        Assert.IsFalse(Resposta, "Falha ao validar a configuração Deveria falhar informação da senha da aplicação")
    End Sub
    <Test, TestMethod, Order(2)>
    Public Sub Teste_Inclusão_Correto()

        Configuração_Correta()
        _DaoConfiguracao = New DAOConfiguracao
        Dim Resposta As Boolean = _DaoConfiguracao.Seta_Parâmetro(_Configuração)
        Assert.IsTrue(Resposta, "Falha ao validar a configuração Deveria passar todas as configurações")

    End Sub
    <Test, TestMethod, Order(3)> Public Sub Teste_Busca_Configuração()
        _DaoConfiguracao = New DAOConfiguracao
        Dim lista As List(Of ConfiguracaoIntegracao) = _DaoConfiguracao.Get_Configuracao("Shopee")
        Dim Registros As Integer = lista.Count
        Assert.AreEqual(1, Registros, 0, "A quantidade de registros retornada pela pesquisa é diferente da esperada ")

    End Sub
    <Test, Order(5), TestMethod> Public Sub Teste_Altera()
        Configuração_Correta()
        _DaoConfiguracao = New DAOConfiguracao
        Dim lista As List(Of ConfiguracaoIntegracao) = _DaoConfiguracao.Get_Configuracao("Shopee")
        Assert.AreEqual(1, lista.Count, 0, "A quantidade de registros retornada pela pesquisa é diferente da esperada ")

        lista(0).Endereço_Redirecionamento_Página = "http://www.convestlv.com"
        Dim Resposta As Boolean = _DaoConfiguracao.Seta_Parâmetro(lista(0))
        Assert.IsTrue(Resposta, "Falha ao validar a configuração Deveria passar todas as configurações")

        lista = _DaoConfiguracao.Get_Configuracao("Shopee")
        Dim GravouCorretamente As Boolean = lista(0).Endereço_Redirecionamento_Página = "http://www.convestlv.com"
        Assert.IsTrue(GravouCorretamente, "A quantidade de registros retornada pela pesquisa é diferente da esperada ")
    End Sub

End Class
