Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NUnit.Framework
Imports IntegracaoMarkPlace
Imports Assert = NUnit.Framework.Assert
<TestFixture>
<TestClass()> Public Class Teste_Cliente
    Dim Lista_Clientes As New List(Of Cliente)

#Region "Funções Uteis"
    Sub Preenche_Lista_Cliente_Correta()
        Dim _Cliente As New Cliente

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-2)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Ronan Jorge Ramos"
        _Cliente.Rua = "Hugo Palhares"
        _Cliente.Numero = "335"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martinha"
        _Cliente.Cidade = "Ribeirão das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33.890-250"
        _Cliente.CPF = "878.039.336-53"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)98864-9407"
        _Cliente.Email = "ronan@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão 2"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-3)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Elizabete Ramos"
        _Cliente.Rua = "Pedro Leopoldo"
        _Cliente.Numero = "155"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martilde"
        _Cliente.Cidade = "Ribeirao das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33.860-590"
        _Cliente.CPF = "938.519.366-04"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)9408-1501"
        _Cliente.Email = "bete@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão bete 2"
        Lista_Clientes.Add(_Cliente)
    End Sub
    Sub Preenche_Lista_Cliente_Erro()
        Dim _Cliente As New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-3)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = ""
        _Cliente.Rua = "Hugo Palhares"
        _Cliente.Numero = "335"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martinha"
        _Cliente.Cidade = "Ribeirao das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33890250"
        _Cliente.CPF = "87803933653"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)988649407"
        _Cliente.Email = "ronan@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-2)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Ronan Jorge Ramos"
        _Cliente.Rua = ""
        _Cliente.Numero = "335"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martinha"
        _Cliente.Cidade = "Ribeirão das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33.890-250"
        _Cliente.CPF = "878.039.336-53"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)98864-9407"
        _Cliente.Email = "ronan@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão 2"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-3)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Elizabete Gomes Ramos"
        _Cliente.Rua = "Pedro Leopoldo"
        _Cliente.Numero = ""
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martilde"
        _Cliente.Cidade = "Ribeirao das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33860590"
        _Cliente.CPF = "93851936604"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)94081501"
        _Cliente.Email = "bete@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão bete"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-3)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Elizabete Ramos"
        _Cliente.Rua = "Pedro Leopoldo"
        _Cliente.Numero = "155"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = ""
        _Cliente.Cidade = "Ribeirao das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33.860-590"
        _Cliente.CPF = "938.519.366-4"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)9408-1501"
        _Cliente.Email = "bete@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão bete 2"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-3)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = ""
        _Cliente.Rua = "Hugo Palhares"
        _Cliente.Numero = "335"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martinha"
        _Cliente.Cidade = ""
        _Cliente.UF = "MG"
        _Cliente.CEP = "33890250"
        _Cliente.CPF = "87803933653"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)988649407"
        _Cliente.Email = "ronan@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-2)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Ronan Jorge Ramos"
        _Cliente.Rua = "Hugo Palhares"
        _Cliente.Numero = "335"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martinha"
        _Cliente.Cidade = "Ribeirão das Neves"
        _Cliente.UF = ""
        _Cliente.CEP = "33.890-250"
        _Cliente.CPF = "878.039.336-53"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)98864-9407"
        _Cliente.Email = "ronan@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão 2"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-3)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Elizabete Gomes Ramos"
        _Cliente.Rua = "Pedro Leopoldo"
        _Cliente.Numero = "155"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martilde"
        _Cliente.Cidade = "Ribeirao das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = ""
        _Cliente.CPF = "93851936604"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)94081501"
        _Cliente.Email = "bete@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão bete"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-3)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Elizabete Ramos"
        _Cliente.Rua = "Pedro Leopoldo"
        _Cliente.Numero = "155"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Sta matilde"
        _Cliente.Cidade = "Ribeirao das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33.860-590"
        _Cliente.CPF = ""
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)9408-1501"
        _Cliente.Email = "bete@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão bete 2"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-2)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Ronan Jorge Ramos"
        _Cliente.Rua = "Hugo Palhares"
        _Cliente.Numero = "335"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martinha"
        _Cliente.Cidade = "Ribeirão das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33.890-250"
        _Cliente.CPF = "878.039.336-53"
        _Cliente.RG = ""
        _Cliente.fone1 = "(31)98864-9407"
        _Cliente.Email = "ronan@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão 2"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-3)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Elizabete Gomes Ramos"
        _Cliente.Rua = "Pedro Leopoldo"
        _Cliente.Numero = "155"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martilde"
        _Cliente.Cidade = "Ribeirao das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33860590"
        _Cliente.CPF = "93851936604"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = ""
        _Cliente.Email = "bete@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão bete"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-3)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Elizabete Ramos"
        _Cliente.Rua = "Pedro Leopoldo"
        _Cliente.Numero = "155"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Matilde"
        _Cliente.Cidade = "Ribeirao das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33.860-590"
        _Cliente.CPF = "938.519.366-4"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)9408-1501"
        _Cliente.Email = ""
        _Cliente.OBS = "Para teste de inclusão bete 2"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-3)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Ronan Jorge Ramos"
        _Cliente.Rua = "Hugo Palhares"
        _Cliente.Numero = "335"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martinha"
        _Cliente.Cidade = "Ribeirão das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33890250"
        _Cliente.CPF = "00000000000"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)988649407"
        _Cliente.Email = "ronan@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão"
        Lista_Clientes.Add(_Cliente)

        _Cliente = New Cliente
        _Cliente.Admissao = Date.Now.AddYears(-2)
        _Cliente.CodCliente = 0
        _Cliente.ATIVO = True
        _Cliente.NomeCliente = "Ronan Jorge Ramos"
        _Cliente.Rua = "Hugo Palhares"
        _Cliente.Numero = "335"
        _Cliente.Complemento = "Casa"
        _Cliente.Bairro = "Santa Martinha"
        _Cliente.Cidade = "Ribeirão das Neves"
        _Cliente.UF = "MG"
        _Cliente.CEP = "33.890-250"
        _Cliente.CPF = "878.039.336-54"
        _Cliente.RG = "4363319"
        _Cliente.fone1 = "(31)98864-9407"
        _Cliente.Email = "ronan@bhinfo.com.br"
        _Cliente.OBS = "Para teste de inclusão 2"
        Lista_Clientes.Add(_Cliente)
    End Sub
#End Region
    <Test>
    <TestMethod> <Order(1)> Public Sub Teste_Inclusão_Correto()
        Preenche_Lista_Cliente_Correta()
        Dim _DaoCliente As New DAOCliente
        For Each Cliente As Cliente In Lista_Clientes
            Dim Resposta As Integer = _DaoCliente.Incluir(Cliente)
            Assert.AreNotEqual(0, Resposta, 0, "Ocorreu uma falha ao incluir o Cliente " & Cliente.NomeCliente & " - " & _DaoCliente.Erro)
        Next

    End Sub
    <Test>
    <TestMethod> <Order(0)> Public Sub Teste_Inclusão_erro()
        Preenche_Lista_Cliente_Erro()
        Dim _DaoCliente As New DAOCliente
        For Each Cliente As Cliente In Lista_Clientes
            Dim Resposta As Integer = _DaoCliente.Incluir(Cliente)
            Assert.AreEqual(0, Resposta, 0, "Falha ao validar o cliente " & Cliente.NomeCliente)
        Next
    End Sub
    <Test>
    <TestMethod> <Order(4)> Public Sub Teste_Exclusão()
        Preenche_Lista_Cliente_Correta()
        Dim _DaoCliente As New DAOCliente
        For Each Cliente As Cliente In Lista_Clientes
            Dim lista As List(Of Cliente) = _DaoCliente.Lista(0, "", "", "", Cliente.CPF)
            Dim Registros As Integer = lista.Count
            Assert.AreEqual(1, Registros, 0, "A quantidade de registros retornada pela pesquisa do CPF " & Cliente.CPF & " é diferente da esperada ")
            If Registros = 1 Then
                Dim Resposta As Boolean = _DaoCliente.Excluir(lista(0).CodCliente)
                Assert.IsTrue(Resposta, "O registro do CPF " & Cliente.CPF & " não foi excluido")
            End If
        Next
    End Sub
    <Test>
    <TestMethod> <Order(2)> Public Sub Teste_Pesquisa_CPF()
        Preenche_Lista_Cliente_Correta()
        Dim _DaoCliente As New DAOCliente
        For Each Cliente As Cliente In Lista_Clientes
            Dim lista As List(Of Cliente) = _DaoCliente.Lista(0, "", "", "", Cliente.CPF)
            Dim Registros As Integer = lista.Count
            Assert.AreEqual(1, Registros, 0, "A quantidade de registros retornada pela pesquisa do CPF " & Cliente.CPF & " é diferente da esperada ")
            If Registros = 1 Then
                Assert.IsTrue((lista(0).NomeCliente.ToUpper = Cliente.NomeCliente.ToUpper), "O nome esperado pela pesquisa do CPF " & Cliente.CPF & " é " & Cliente.NomeCliente & " e retornou " & lista(0).NomeCliente)
            End If
        Next
    End Sub
    <Test>
    <TestMethod> <Order(3)> Public Sub Teste_Pesquisa_Nome()
        Preenche_Lista_Cliente_Correta()
        Dim _DaoCliente As New DAOCliente
        For Each Cliente As Cliente In Lista_Clientes
            Dim lista As List(Of Cliente) = _DaoCliente.Lista(0, Cliente.NomeCliente)
            Dim Registros As Integer = lista.Count
            Assert.AreEqual(1, Registros, 0, "A quantidade de registros retornada pela pesquisa do Nome " & Cliente.NomeCliente & " é diferente da esperada ")
            If Registros >= 1 Then
                Assert.IsTrue((lista(0).CPF = Cliente.CPF), "O CPF esperado pela pesquisa do nome " & Cliente.NomeCliente & " é " & Cliente.CPF & " e retornou " & lista(0).CPF)
            End If
        Next
    End Sub
End Class