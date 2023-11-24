Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NUnit.Framework
Imports IntegracaoMarkPlace
Imports Assert = NUnit.Framework.Assert
<TestFixture, TestClass> Public Class TesteProdutos
    Dim Lista_Produtos As New List(Of Produto)

#Region "Funções Uteis"
    Sub Preenche_Lista_Cliente_Correta()
        Dim _Produto As New Produto

        _Produto = New Produto
        _Produto.Minimo = 10
        _Produto.Ativo = True
        _Produto.CEST = "1004600"
        _Produto.CodBarra = "1234567890120"
        _Produto.CodFornecedor = 0
        _Produto.CodMercadoria = 0
        _Produto.CodPesquisa = ""
        _Produto.Descricao = "Produto de teste 1"
        _Produto.Estoque = 50
        _Produto.Maximo = 100
        _Produto.NCM = "73079200"
        _Produto.PrecoCusto = 2.45
        _Produto.PrecoVenda = 8.34
        _Produto.Unidade = "UN"
        _Produto.obs = "inclusão de produtos 1"
        Lista_Produtos.Add(_Produto)

        _Produto = New Produto
        _Produto.Minimo = 20
        _Produto.Ativo = True
        _Produto.CEST = "1004600"
        _Produto.CodBarra = "1234567890123"
        _Produto.CodFornecedor = 0
        _Produto.CodMercadoria = 0
        _Produto.CodPesquisa = ""
        _Produto.Descricao = "Produto de teste 2"
        _Produto.Estoque = 70
        _Produto.Maximo = 900
        _Produto.NCM = "73079200"
        _Produto.PrecoCusto = 6.45
        _Produto.PrecoVenda = 11.34
        _Produto.Unidade = "UN"
        _Produto.obs = "inclusão de produtos 2"

        Lista_Produtos.Add(_Produto)
        _Produto = New Produto
        _Produto.Minimo = 20
        _Produto.Ativo = True
        _Produto.CEST = "1004600"
        _Produto.CodBarra = "1234567890124"
        _Produto.CodFornecedor = 0
        _Produto.CodMercadoria = 0
        _Produto.CodPesquisa = ""
        _Produto.Descricao = "Caixa d'agua 1"
        _Produto.Estoque = 70
        _Produto.Maximo = 900
        _Produto.NCM = "73079200"
        _Produto.PrecoCusto = 6.45
        _Produto.PrecoVenda = 11.34
        _Produto.Unidade = "UN"
        _Produto.obs = "inclusão de produtos 2"
        Lista_Produtos.Add(_Produto)
    End Sub
    Sub Preenche_Lista_Cliente_Erro()
        Dim _Produto As New Produto

        _Produto = New Produto
        _Produto.Minimo = 10
        _Produto.Ativo = True
        _Produto.CEST = "1004600"
        _Produto.CodBarra = "1234567890120"
        _Produto.CodFornecedor = 0
        _Produto.CodMercadoria = 0
        _Produto.CodPesquisa = ""
        _Produto.Descricao = ""
        _Produto.Estoque = 50
        _Produto.Maximo = 100
        _Produto.NCM = "73079200"
        _Produto.PrecoCusto = 2.45
        _Produto.PrecoVenda = 8.34
        _Produto.Unidade = "UN"
        _Produto.obs = "inclusão de produtos 1"
        Lista_Produtos.Add(_Produto)

        _Produto = New Produto
        _Produto.Minimo = 20
        _Produto.Ativo = True
        _Produto.CEST = "1004600"
        _Produto.CodBarra = "1234567890120"
        _Produto.CodFornecedor = 0
        _Produto.CodMercadoria = 0
        _Produto.CodPesquisa = ""
        _Produto.Descricao = "Produto de teste 2"
        _Produto.Estoque = 70
        _Produto.Maximo = 900
        _Produto.NCM = "73079200"
        _Produto.PrecoCusto = 6.45
        _Produto.PrecoVenda = 11.34
        _Produto.Unidade = "UN"
        _Produto.obs = "inclusão de produtos 2"

    End Sub
#End Region

    <Test, TestMethod, Order(1)> Public Sub Teste_Inclusão_erro()
        Preenche_Lista_Cliente_Erro()
        Dim _DaoProduto As New DAOProduto
        For Each _Produto As Produto In Lista_Produtos
            Dim Resposta As Integer = _DaoProduto.Incluir(_Produto)
            Assert.AreEqual(0, Resposta, 0, "Falha ao validar o Produto " & _Produto.Descricao)
        Next
    End Sub
    <Test, TestMethod, Order(2)>
    Public Sub Teste_Inclusão_Correto()
        Preenche_Lista_Cliente_Correta()
        Dim _DaoProduto As New DAOProduto
        For Each _Produto As Produto In Lista_Produtos
            Dim Resposta As Boolean = _DaoProduto.Incluir(_Produto)
            Assert.IsTrue(Resposta, "Ocorreu uma falha ao incluir o Produto " & _Produto.Descricao & " - " & _DaoProduto.Erro)
        Next

    End Sub
    <Test, TestMethod, Order(3)> Public Sub Teste_Pesquisa_CodBarra()
        Preenche_Lista_Cliente_Correta()
        Dim _DaoProduto As New DAOProduto
        For Each _Produto As Produto In Lista_Produtos
            Dim lista As List(Of Produto) = _DaoProduto.Lista(0, "", I_Produto.Classificação.CodMercadoria, False, False, _Produto.CodBarra)
            Dim Registros As Integer = lista.Count
            Assert.AreEqual(1, Registros, 0, "A quantidade de registros retornada pela pesquisa do EAN-13 " & _Produto.CodBarra & " é diferente da esperada ")
            If Registros = 1 Then
                Assert.IsTrue((lista(0).Descricao.ToUpper = _Produto.Descricao.ToUpper), "O nome esperado pela pesquisa do EAN-13 " & _Produto.CodBarra & " é " & _Produto.Descricao & " e retornou " & lista(0).Descricao)
            End If
        Next
    End Sub
    <Test, TestMethod, Order(4)> Public Sub Teste_Pesquisa_Nome()
        Preenche_Lista_Cliente_Correta()
        Dim _DaoProduto As New DAOProduto
        For Each _Produto As Produto In Lista_Produtos
            Dim lista As List(Of Produto) = _DaoProduto.Lista(0, _Produto.Descricao, I_Produto.Classificação.Nome)
            Dim Registros As Integer = lista.Count
            Assert.AreEqual(1, Registros, 0, "A quantidade de registros retornada pela pesquisa do Nome " & _Produto.Descricao & " é diferente da esperada ")
            If Registros >= 1 Then
                Assert.IsTrue((lista(0).CodBarra = _Produto.CodBarra), "O Código esperado pela pesquisa do nome " & _Produto.Descricao & " é " & _Produto.CodBarra & " e retornou " & lista(0).CodBarra)
            End If
        Next
    End Sub
    <Test, Order(5), TestMethod> Public Sub Teste_Exclusão()
        Preenche_Lista_Cliente_Correta()
        Dim DAOProduto As New DAOProduto
        For Each Produto As Produto In Lista_Produtos
            Dim lista As List(Of Produto) = DAOProduto.Lista(0, "", I_Produto.Classificação.CodMercadoria, False, False, Produto.CodBarra)
            Dim Registros As Integer = lista.Count
            Assert.AreEqual(1, Registros, 0, "A quantidade de registros retornada pela pesquisa do EAN-13 " & Produto.CodBarra & " é diferente da esperada ")
            If Registros = 1 Then
                Dim Resposta As Boolean = DAOProduto.Excluir(lista(0).CodMercadoria)
                Assert.IsTrue(Resposta, "O registro do EAN-13 " & Produto.CodBarra & " não foi excluido")
            End If
        Next
    End Sub

End Class
