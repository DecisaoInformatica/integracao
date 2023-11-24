Imports IntegracaoMarkPlace.Shopee
Imports Newtonsoft.Json.Linq

Public Class FrmProdutos
    Private WithEvents _Controle_Atual As I_Produto_Strategy
    Private Configuração As New ConfiguracaoIntegracao
    Private LcCodProdutoGridPesquisa As String = ""
    Private lista_Exibir As New List(Of ProdutosExibir)
    Private WithEvents FrmListaProduto As ListagemProduto
    Private Sub Get_Configuração()
        Dim Dao_Config As New DAOConfiguracao
        Dim Lista_Configuração As List(Of ConfiguracaoIntegracao) = Dao_Config.Get_Configuracao(Plataforma.Text)
        If Lista_Configuração.Count = 0 Then Throw New Exception("Não foi feita a configuração do sistema, configure antes de autenticar")
        Configuração = Lista_Configuração(0)
    End Sub
    Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles CmdBuscar.Click
        Dim LcCap = Me.Text
        Dim _ADO_Token As New DAOTokenConfig()
        Dim _Token As List(Of Token) = _ADO_Token.Get_Token(Plataforma.Text)
        If _Token.Count > 0 Then
            _Controle_Atual = Seleciona_Controle_Produto(Plataforma.Text)
            _Controle_Atual.Configuração = Configuração
            _Controle_Atual.AcessToken = Get_Token_Acesso(_Token(_Token.Count - 1))
            _Controle_Atual.Status_Pesquisar = "NORMAL"
            If _Controle_Atual.AcessToken IsNot Nothing Then
                Dim _Controle_Produtos As New ControleProdutos(_Controle_Atual)
                lista_Exibir = _Controle_Produtos.Get_Lista_Produto()
                If lista_Exibir.Count > 0 Then
                    Busca_Produtos_Vinculados()
                End If
            End If
        Else
            MsgBox("Token não encontrado! Efetue o processo de Autorização e Geração do Token Novamente!")
        End If
        Gera_Grid(lista_Exibir)
        Me.Text = LcCap
    End Sub
    Private Function Get_Token_Acesso(_Token As Token) As String
        Dim Resposta As String = ""
        Dim Controle_Token As I_Controle_Token_Strategy = Seleciona_Controle_Token_token(Plataforma.Text)
        Controle_Token.Configuração = Configuração
        Dim NovoToken As Token = Controle_Token.Get_Acess_Token(_Token.Refresh_Token)
        If Controle_Token.Erro.Length > 0 Then
            MsgBox("Ocorreu o Seguinte Erro Recuperando o Token de acesso:" & Chr(13) & Controle_Token.Erro_MSG, 64, Controle_Token.Erro)
        Else
            '==> Grava o novo Acesso Token
            Dim Ado_Token As New DAOTokenConfig
            Ado_Token.Seta_Acess_Token(Plataforma.Text, NovoToken.Acess_Token)
            Resposta = NovoToken.Acess_Token
        End If

        Return Resposta
    End Function
    Private Sub Gera_Grid(Lista As List(Of ProdutosExibir))
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = Lista
        DataGridView1.Refresh()
    End Sub
    Private Function Seleciona_Controle_Produto(Plataforma As String) As I_Produto_Strategy
        Dim Resposta As I_Produto_Strategy
        If Plataforma.ToUpper = "SHOPEE" Then Resposta = New ControleProdutoShopee

        Return Resposta

    End Function
    Private Function Seleciona_Controle_Token_token(Plataforma As String) As I_Controle_Token_Strategy
        Dim Resposta As I_Controle_Token_Strategy
        If Plataforma.ToUpper = "SHOPEE" Then Resposta = New Controle_Token_Shopee
        Return Resposta

    End Function

    Private Sub FrmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_Configuração()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CmdAtualizarPreco_Click(sender As Object, e As EventArgs) Handles CmdAtualizarPreco.Click
        Dim LcCap = Me.Text
        Dim _ADO_Token As New DAOTokenConfig()
        Dim _Token As List(Of Token) = _ADO_Token.Get_Token(Plataforma.Text)

        If _Token.Count > 0 Then
            Dim Lista_dados As New List(Of BaseAtualização)

            _Controle_Atual = Seleciona_Controle_Produto(Plataforma.Text)
            _Controle_Atual.Configuração = Configuração
            _Controle_Atual.AcessToken = Get_Token_Acesso(_Token(_Token.Count - 1))
            _Controle_Atual.Status_Pesquisar = "NORMAL"
            If _Controle_Atual.AcessToken IsNot Nothing Then
                Dim _Controle_Produtos As New ControleProdutos(_Controle_Atual)
                For Each linha As DataGridViewRow In DataGridView1.Rows
                    Dim Selecionado As Boolean = linha.Cells(0).Value
                    If Selecionado Then
                        Dim Preço As Decimal = 0
                        Dim Quantidade As Integer = 0
                        If IsNumeric(linha.Cells(9).Value.ToString()) Then Preço = CDec(linha.Cells(9).Value.ToString())
                        If IsNumeric(linha.Cells(10).Value.ToString()) Then Quantidade = CInt(linha.Cells(10).Value.ToString())
                        Dim dados_Atualização As New BaseAtualização
                        dados_Atualização.IDProduto = linha.Cells(3).Value.ToString
                        dados_Atualização.Preço = Preço
                        dados_Atualização.Departamento = ""
                        dados_Atualização.Quantidade = Quantidade
                        Lista_dados.Add(dados_Atualização)
                    End If
                Next
                _Controle_Produtos.Seta_Preço_Loja(Lista_dados)
                Dim _Erro As String = _Controle_Atual.Erro_MSG
                If _Erro.Length > 0 Then MsgBox(_Erro, vbOK, _Controle_Atual.Erro) Else MsgBox("Atualizações feitas com sucesso!", 64, "Confirmação")
            End If
        Else
            MsgBox("Token não encontrado! Efetue o processo de Autorização e Geração do Token Novamente!")
        End If
        Me.Text = LcCap


    End Sub
    Private Sub _Controle_Atual_Informação_Processo(Descrição As String) Handles _Controle_Atual.Informação_Processo
        Me.Text = Descrição
        Application.DoEvents()
    End Sub

    Private Sub CmdAtualizaEstoque_Click(sender As Object, e As EventArgs) Handles CmdAtualizaEstoque.Click
        Dim LcCap = Me.Text
        Dim _ADO_Token As New DAOTokenConfig()
        Dim _Token As List(Of Token) = _ADO_Token.Get_Token(Plataforma.Text)

        If _Token.Count > 0 Then
            Dim Lista_dados As New List(Of BaseAtualização)

            _Controle_Atual = Seleciona_Controle_Produto(Plataforma.Text)
            _Controle_Atual.Configuração = Configuração
            _Controle_Atual.AcessToken = Get_Token_Acesso(_Token(_Token.Count - 1))
            If _Controle_Atual.AcessToken IsNot Nothing Then
                Dim _Controle_Produtos As New ControleProdutos(_Controle_Atual)
                For Each linha As DataGridViewRow In DataGridView1.Rows
                    Dim Selecionado As Boolean = linha.Cells(0).Value
                    If Selecionado Then
                        Dim Preço As Decimal = 0
                        Dim Quantidade As Integer = 0
                        If IsNumeric(linha.Cells(9).Value.ToString()) Then Preço = CDec(linha.Cells(9).Value.ToString())
                        If IsNumeric(linha.Cells(10).Value.ToString()) Then Quantidade = CInt(linha.Cells(10).Value.ToString())
                        Dim dados_Atualização As New BaseAtualização
                        dados_Atualização.IDProduto = linha.Cells(3).Value.ToString
                        dados_Atualização.Preço = Preço
                        dados_Atualização.Departamento = ""
                        dados_Atualização.Quantidade = Quantidade
                        Lista_dados.Add(dados_Atualização)
                    End If
                Next
                _Controle_Produtos.Seta_Quantidade_Loja(Lista_dados)
                Dim _Erro As String = _Controle_Atual.Erro_MSG
                If _Erro.Length > 0 Then MsgBox(_Erro, vbOKOnly, _Controle_Atual.Erro) Else MsgBox("Atualizações feitas com sucesso!", vbOKOnly, "Confirmação")
            End If
        Else
            MsgBox("Token não encontrado! Efetue o processo de Autorização e Geração do Token Novamente!")
        End If
        Me.Text = LcCap
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            If DataGridView1.Rows.Count = 0 Then Exit Sub
            Dim Linha As Integer = e.RowIndex
            If e.ColumnIndex = 1 Then
                LcCodProdutoGridPesquisa = ""
                FrmListaProduto = New ListagemProduto
                FrmListaProduto.ShowDialog(Me)
                If LcCodProdutoGridPesquisa.Length = 0 Then LcCodProdutoGridPesquisa = 0
                If CInt(LcCodProdutoGridPesquisa) > 0 Then
                    DataGridView1.Rows(Linha).Cells(1).Value = LcCodProdutoGridPesquisa
                    If Not IsNumeric(DataGridView1.Rows(Linha).Cells(1).Value) Then
                        lista_Exibir(Linha).CodigoAuto = 0
                        lista_Exibir(Linha).Descricao = ""
                    Else
                        Dim ListaProduto As New List(Of Produto)
                        Dim LcCod As Long = 0
                        LcCod = DataGridView1.Rows(Linha).Cells(1).Value


                        Dim DaoProduto As New DAOProduto()
                        ListaProduto = DaoProduto.Lista(LcCod)
                        If ListaProduto.Count > 0 Then
                            lista_Exibir(Linha).CodigoAuto = LcCod
                            lista_Exibir(Linha).Descricao = ListaProduto(0).Descricao
                            lista_Exibir(Linha).Preco = ListaProduto(0).PrecoVenda
                            lista_Exibir(Linha).QTD = ListaProduto(0).Estoque
                            DataGridView1.Rows(Linha).Cells(2).Value = ListaProduto(0).Descricao
                            DataGridView1.Rows(Linha).Cells(1).Value = LcCodProdutoGridPesquisa
                        Else
                            lista_Exibir(Linha).CodigoAuto = 0
                            lista_Exibir(Linha).Descricao = ""
                            lista_Exibir(Linha).Preco = 0
                            lista_Exibir(Linha).QTD = 0
                        End If
                    End If
                    Salva_Vinculacao_Produto(lista_Exibir(Linha))
                    DataGridView1.Refresh()
                End If
            End If
        Catch ex As Exception
        Finally

        End Try
    End Sub
    Private Sub PesquisaProdutoGrid(LcCod As Integer) Handles FrmListaProduto.SetaProduto_Codigo
        Try
            LcCodProdutoGridPesquisa = LcCod
        Catch ex As Exception
        Finally
        End Try

    End Sub
    Private Sub Salva_Vinculacao_Produto(List As ProdutosExibir)
        Try
            Dim DaoPI As New DAOProdutoIntegracao()
            Dim Lista_Integracao As New PProdutoIntegracao()
            Lista_Integracao.Preço_Loja = List.PrecoLoja
            Lista_Integracao.Plataforma = Plataforma.Text
            Lista_Integracao.ProdutoID = List.CodigoAuto
            Lista_Integracao.Produto_LojaID = List.ItemID_Loja
            DaoPI.Incluir(Lista_Integracao)
        Catch ex As Exception
        Finally
        End Try
    End Sub
    Private Sub Busca_Produtos_Vinculados()
        Try
            Dim DaoPI As New DAOProdutoIntegracao
            Dim Lista_Integracao As New List(Of PProdutoIntegracao)
            Dim List_Integracao As New List(Of PProdutoIntegracao)
            Lista_Integracao = DaoPI.Get_ProdutoIntegração(Plataforma.Text, 0, "")
            Dim DaoP As New DAOProduto
            Dim ListaProduto As New List(Of Produto)
            For Each L In lista_Exibir
                List_Integracao = New List(Of PProdutoIntegracao)
                List_Integracao = Lista_Integracao.FindAll(Function(P As PProdutoIntegracao) P.Produto_LojaID = L.ItemID_Loja)
                If List_Integracao.Count > 0 Then
                    L.CodigoAuto = List_Integracao(0).ProdutoID
                    L.Descricao = List_Integracao(0).Descricao
                    L.QTD = List_Integracao(0).Estoque
                    L.Preco = List_Integracao(0).PrecoVenda
                Else
                    If L.Barra.Length > 0 Then
                        ListaProduto = New List(Of Produto)
                        ListaProduto = DaoP.Lista(0, "", I_Produto.Classificação.Nome, False, False, L.Barra)
                        If ListaProduto.Count > 0 Then
                            L.CodigoAuto = ListaProduto(0).CodMercadoria
                            L.Descricao = ListaProduto(0).Descricao
                            L.QTD = ListaProduto(0).Estoque
                            L.Preco = ListaProduto(0).PrecoVenda
                            Salva_Vinculacao_Produto(L)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
        Finally
        End Try
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            If DataGridView1.Rows.Count = 0 Then Exit Sub
            Dim Linha As Integer = e.RowIndex
            If e.ColumnIndex = 1 Then
                Dim LcCod As Long = 0
                If IsNumeric(DataGridView1.Rows(Linha).Cells(1).Value) Then
                    LcCod = DataGridView1.Rows(Linha).Cells(1).Value
                End If
                If LcCod <= 0 Then
                    lista_Exibir(Linha).CodigoAuto = 0
                    lista_Exibir(Linha).Descricao = ""
                    lista_Exibir(Linha).Preco = 0
                    lista_Exibir(Linha).QTD = 0
                Else
                    Dim ListaProduto As New List(Of Produto)
                    Dim DaoProduto As New DAOProduto()
                    ListaProduto = DaoProduto.Lista(LcCod)
                    If ListaProduto.Count > 0 Then
                        lista_Exibir(Linha).CodigoAuto = LcCod
                        lista_Exibir(Linha).Descricao = ListaProduto(0).Descricao
                        lista_Exibir(Linha).Preco = ListaProduto(0).PrecoVenda
                        lista_Exibir(Linha).QTD = ListaProduto(0).Estoque
                        DataGridView1.Rows(Linha).Cells(2).Value = ListaProduto(0).Descricao
                    Else
                        lista_Exibir(Linha).CodigoAuto = 0
                        lista_Exibir(Linha).Descricao = ""
                        lista_Exibir(Linha).Preco = 0
                        lista_Exibir(Linha).QTD = 0
                    End If
                End If
                Salva_Vinculacao_Produto(lista_Exibir(Linha))
                DataGridView1.Refresh()
            End If
        Catch ex As Exception
        Finally
        End Try
    End Sub

    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit

    End Sub
End Class