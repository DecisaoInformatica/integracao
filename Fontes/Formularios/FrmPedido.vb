Public Class FrmPedido
    Private Configuração As New ConfiguracaoIntegracao
    Private lista_Venda As New List(Of VendaCabecalho)
    Private WithEvents _Controle_Atual As I_Pedido_Strategy
    Sub Get_Configuração()
        Dim Dao_Config As New DAOConfiguracao
        Dim Lista_Configuração As List(Of ConfiguracaoIntegracao) = Dao_Config.Get_Configuracao(Plataforma.Text)
        If Lista_Configuração.Count = 0 Then Throw New Exception("Não foi feita a configuração do sistema, configure antes de autenticar")
        Configuração = Lista_Configuração(0)
    End Sub
    Private Sub CmdBuscarPedidos_Click(sender As Object, e As EventArgs) Handles CmdBuscarPedidos.Click
        Dim cap As String = Me.Text

        LimpaGrids()
        Dim _ADO_Token As New DAOTokenConfig()
        Dim _Token As List(Of Token) = _ADO_Token.Get_Token(Plataforma.Text)

        If _Token.Count > 0 Then
            _Controle_Atual = Seleciona_Controle_Pedido(Plataforma.Text)
            _Controle_Atual.Configuração = Configuração
            _Controle_Atual.AcessToken = Get_Token_Acesso(_Token(_Token.Count - 1))
            If _Controle_Atual.AcessToken IsNot Nothing Then
                Dim _Controle_Pedido As New Controle_Pedido(_Controle_Atual)
                lista_Venda = _Controle_Pedido.Get_Lista_Pedido("create_time", DataInicio.Text, DataFim.Text, Status.Text)
                If lista_Venda.Count > 0 Then
                    lista_Venda(0).CodVenda_Gerado = Busca_Pedido_Gerado(Plataforma.Text, lista_Venda(0).ID_Loja)
                    lista_Venda(0).Cliente_CPF = "074.957.106-32"
                    lista_Venda(0).Forma_Pag = "CARTAO CREDITO"
                    lista_Venda(0).Valor_Total = "355"
                End If

                If _Controle_Atual.Erro.Length > 0 Then
                    MsgBox("Ocorreu o seguinte erro Buscando os Pedidos:" & _Controle_Atual.Erro_MSG, 64, _Controle_Atual.Erro)
                End If
            End If
        Else
            MsgBox("Token não encontrado! Efetue o processo de Autorização e Geração do Token Novamente!")
        End If
        GeraGrid_Cabeçalho(lista_Venda)
        Me.Text = cap
    End Sub
    Sub LimpaGrids()
        GridCabecalho.DataSource = nothing
        GridCabecalho.Refresh()
        GridItem.DataSource = Nothing
        GridItem.Refresh()
    End Sub
    Sub GeraGrid_Cabeçalho(Lista_Cabeçalho As List(Of VendaCabecalho))
        GridCabecalho.AutoGenerateColumns = False
        GridCabecalho.DataSource = Lista_Cabeçalho
        GridCabecalho.Refresh()
    End Sub
    Sub GeraGrid_Itens(Lista_Itens As List(Of VendaDados))
        GridItem.AutoGenerateColumns = False
        GridItem.DataSource = Lista_Itens
        GridItem.Refresh()
    End Sub

    Function Get_Token_Acesso(_Token As Token) As String
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
    Function Seleciona_Controle_Pedido(Plataforma As String) As I_Pedido_Strategy
        Dim Resposta As I_Pedido_Strategy
        If Plataforma.ToUpper = "SHOPEE" Then Resposta = New Controle_Pedido_Shopee

        Return Resposta

    End Function
    Function Seleciona_Controle_Token_token(Plataforma As String) As I_Controle_Token_Strategy
        Dim Resposta As I_Controle_Token_Strategy
        If Plataforma.ToUpper = "SHOPEE" Then Resposta = New Controle_Token_Shopee
        Return Resposta

    End Function
    Sub Carrega_Status_Pedido()
        Dim Lista_Status As ArrayList = Seleciona_Status_Pedido()
        For Each _Status As String In Lista_Status
            Status.Items.Add(_Status)
        Next
    End Sub
    Function Seleciona_Status_Pedido() As ArrayList
        If Plataforma.Text.ToUpper = "SHOPEE" Then Return Shopee.Utilitário.Lista_Status_Pedido
    End Function
    Private Sub FrmPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_Configuração()
        Carrega_Status_Pedido()
    End Sub

    Private Sub GridCabecalho_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCabecalho.CellContentClick

    End Sub

    Private Sub GridCabecalho_Click(sender As Object, e As EventArgs) Handles GridCabecalho.Click

    End Sub

    Private Sub GridCabecalho_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCabecalho.CellClick
        Try
            Dim Linha As Int16 = GridCabecalho.CurrentCell.RowIndex
            If Linha < 0 Then Exit Sub
            Dim IDLoja As String = GridCabecalho.Rows(Linha).Cells(2).Value
            Dim listaFiltrada As List(Of VendaCabecalho) = lista_Venda.FindAll(Function(p As VendaCabecalho) p.ID_Loja = IDLoja)


            listaFiltrada(0).Itens = Busca_Produto_Vinculados(listaFiltrada(0).Itens)
            Dim Lc_Vinculados As Boolean = True
            For Each l In listaFiltrada(0).Itens
                If l.CodProdutoAuto = 0 Then
                    Lc_Vinculados = False
                    Exit For
                End If
            Next
            GeraGrid_Itens(listaFiltrada(0).Itens)
            If Not Lc_Vinculados Then
                GridCabecalho.Rows(Linha).Cells(0).Value = False
            End If
        Catch ex As Exception
        Finally

        End Try
    End Sub

    Private Sub _Controle_Atual_Informação_Processo(Descrição As String) Handles _Controle_Atual.Informação_Processo
        Application.DoEvents()
        Me.Text = Descrição
        Application.DoEvents()
    End Sub

    Private Sub GridCabecalho_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCabecalho.CellContentDoubleClick
        Dim Linha As Int16 = GridCabecalho.CurrentCell.RowIndex
        If Linha < 0 Then Exit Sub
    End Sub

    Private Sub ProcessarPedido_Click(sender As Object, e As EventArgs) Handles ProcessarPedido.Click
        Try
            Dim PedidoID As String = ""
            Dim Selecionado As Boolean = False
            Dim Lista_Vendedor As New List(Of PVendedor)
            Dim Lista_Cliente As New List(Of Cliente)
            Dim ClienteID As Integer = 0

            Dim DaoV As New DAOVendedor
            Lista_Vendedor = DaoV.Retorna_Vendedor(Plataforma.Text)
            If Lista_Vendedor.Count = 0 Then
                Dim List As New PVendedor
                List.Nome = Plataforma.Text
                If DaoV.incluir(List) Then
                    Lista_Vendedor = DaoV.Retorna_Vendedor(Plataforma.Text)
                End If
            End If

            For Each Linha As DataGridViewRow In GridCabecalho.Rows
                Selecionado = Linha.Cells(0).Value
                If Selecionado Then
                    PedidoID = Linha.Cells(2).Value.ToString
                    If Valida_Pedido(PedidoID) Then
                        Lista_Cliente = New List(Of Cliente)
                        Lista_Cliente = Get_Cliente(PedidoID)
                        If Lista_Cliente.Count = 0 Then
                            ClienteID = Grava_Dados_Cliente(PedidoID)
                            Lista_Cliente = Get_Cliente(PedidoID)
                        End If
                        If Lista_Cliente.Count > 0 And Lista_Vendedor.Count > 0 Then
                            If Not Grava_Venda(PedidoID, Plataforma.Text, Lista_Cliente, Lista_Vendedor) Then
                                MsgBox("Não foi possível processar o pedido: " & PedidoID & ". Tente novamente após a conclusão.", vbInformation, "Atenção")
                            End If
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
        Finally
        End Try
    End Sub
    Private Function Valida_Pedido(PedidoID As String) As Boolean
        Dim Resp As Boolean = True
        Try
            Dim listaFiltrada As List(Of VendaCabecalho) = lista_Venda.FindAll(Function(p As VendaCabecalho) p.ID_Loja = PedidoID)
            listaFiltrada(0).Itens = Busca_Produto_Vinculados(listaFiltrada(0).Itens)
            For Each l In listaFiltrada(0).Itens
                If l.CodProdutoAuto = 0 Then
                    Resp = False
                    Exit For
                End If
            Next
            If Not Resp Then
                MsgBox("Pedido com Produtos não Vinculados" & Chr(13) & Chr(13) & "Pedido: " & PedidoID)
            End If
        Catch ex As Exception
        Finally
        End Try
        Return Resp
    End Function
    Private Function Get_ClienteID(PedidoLojaID As String) As Integer
        Dim Resposta As Integer = 0
        Try
            Dim CPF As String = ""
            Dim Dao_Cliente As New DAOCliente()
            Dim listaFiltrada As List(Of VendaCabecalho) = lista_Venda.FindAll(Function(p As VendaCabecalho) p.ID_Loja = PedidoLojaID)
            If listaFiltrada.Count > 0 Then
                CPF = listaFiltrada(0).Cliente_CPF
                Resposta = Dao_Cliente.Retorna_Id_Cliente(CPF)
            End If
        Catch ex As Exception
        Finally
        End Try
        Return Resposta
    End Function
    Private Function Get_Cliente(PedidoLojaID As String) As List(Of Cliente)
        Dim Lista As List(Of Cliente)
        Try
            Dim CPF As String = ""
            Dim Dao_Cliente As New DAOCliente()
            Dim listaFiltrada As List(Of VendaCabecalho) = lista_Venda.FindAll(Function(p As VendaCabecalho) p.ID_Loja = PedidoLojaID)
            If listaFiltrada.Count > 0 Then
                CPF = listaFiltrada(0).Cliente_CPF
                Lista = Dao_Cliente.Lista(0, "", "", "", CPF)
            End If
        Catch ex As Exception
        Finally
        End Try
        Return Lista
    End Function
    Private Function Grava_Dados_Cliente(PedidoLojaID As String) As Integer
        Dim IdCliente As Integer = 0
        Try
            Dim Dao_Cliente As New DAOCliente
            Dim listaFiltrada As List(Of VendaCabecalho) = lista_Venda.FindAll(Function(p As VendaCabecalho) p.ID_Loja = PedidoLojaID)
            If listaFiltrada.Count > 0 Then
                '--> preenche com os ddos do cliente
                Dim List As New Cliente
                List.TipoCliente = "Físico"
                List.CPF = listaFiltrada(0).Cliente_CPF
                List.NomeCliente = listaFiltrada(0).Cliente_Nome
                List.CEP = listaFiltrada(0).Cliente_Endereço.zipcode & ""
                List.fone1 = listaFiltrada(0).Cliente_Endereço.phone & ""
                List.Bairro = listaFiltrada(0).Cliente_Endereço.district & ""
                List.Cidade = listaFiltrada(0).Cliente_Endereço.city & ""
                List.Rua = listaFiltrada(0).Cliente_Endereço.full_address & ""
                List.Numero = ""
                List.Complemento = ""
                List.UF = listaFiltrada(0).Cliente_Endereço.state & ""
                Dim DaoC As New DAOCliente
                IdCliente = List.CodCliente = DaoC.Incluir(List)
            End If
        Catch ex As Exception
        Finally
        End Try
        Return IdCliente
    End Function
    Private Function Grava_Venda(PedidoLojaID As String, LcPlataforma As String, Lista_Cliente As List(Of Cliente),
                                 Lista_Vendedor As List(Of PVendedor)) As Boolean
        Dim Resposta As Boolean = False
        Try
            Dim listaFiltrada As List(Of VendaCabecalho) = lista_Venda.FindAll(Function(p As VendaCabecalho) p.ID_Loja = PedidoLojaID)
            If listaFiltrada.Count > 0 Then
                Dim Lista_Venda As New PVenda
                Lista_Venda.Referencia = PedidoLojaID
                Lista_Venda.Plataforma = LcPlataforma
                Lista_Venda.DataVenda = CDate(listaFiltrada(0).Emissao)
                Lista_Venda.Hora = Format(TimeOfDay, "HH:mm:ss")
                Lista_Venda.CodVendedor = Lista_Vendedor(0).CodFuncionario
                Lista_Venda.NomeVendedor = Lista_Vendedor(0).Nome
                Lista_Venda.CodCliente = Lista_Cliente(0).CodCliente
                Lista_Venda.NomeCliente = Lista_Cliente(0).NomeCliente
                Lista_Venda.TipoPag = listaFiltrada(0).Forma_Pag.ToString
                Lista_Venda.TipoVenda = "A Vista"
                Lista_Venda.ValorVenda = listaFiltrada(0).Valor_Total
                Dim DaoV As New DAOVenda
                Lista_Venda.CodVenda = DaoV.Incluir_Cabecalho(Lista_Venda)
                If Lista_Venda.CodVenda > 0 Then
                    Dim ListaP As New List(Of Produto)
                    Dim DaoP As New DAOProduto
                    Dim Lista_Venda_Item As New PVenda_Item
                    Dim NumItem As Integer = 1
                    For Each L In listaFiltrada(0).Itens
                        Lista_Venda_Item = New PVenda_Item
                        ListaP = New List(Of Produto)
                        ListaP = DaoP.Lista(L.CodProdutoAuto)
                        Lista_Venda_Item.NumItem = NumItem
                        NumItem += 1
                        Lista_Venda_Item.CodVenda = Lista_Venda.CodVenda
                        Lista_Venda_Item.CodMercadoria = L.CodProdutoAuto
                        Lista_Venda_Item.Descricao = L.Descricao
                        Lista_Venda_Item.Unidade = ListaP(0).Unidade
                        Lista_Venda_Item.Quantidade = L.Quantidade
                        Lista_Venda_Item.ValorUnit = L.ValorUnitario
                        Lista_Venda_Item.SubTotal = L.ValorTotal
                        Lista_Venda_Item.CustoUnit = ListaP(0).PrecoCusto
                        Lista_Venda_Item.CodFornecedor = ListaP(0).CodFornecedor
                        Lista_Venda_Item.CodVendaItem = DaoV.Incluir_Item(Lista_Venda_Item)
                    Next
                    Resposta = True
                End If
            End If
        Catch ex As Exception
            Resposta = False
        Finally
        End Try

        Return Resposta
    End Function

    Private Sub CmdSelecionaArquivo_Click(sender As Object, e As EventArgs) Handles CmdSelecionaArquivo.Click
        OpenFileDialog1.ShowDialog()
        ArquivoXML.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub CmdUploadArquivo_Click(sender As Object, e As EventArgs) Handles CmdUploadArquivo.Click
        Dim cap As String = Me.Text
        Dim _ADO_Token As New DAOTokenConfig()
        Dim _Token As List(Of Token) = _ADO_Token.Get_Token(Plataforma.Text)

        If _Token.Count > 0 Then
            _Controle_Atual = Seleciona_Controle_Pedido(Plataforma.Text)
            _Controle_Atual.Configuração = Configuração
            _Controle_Atual.AcessToken = Get_Token_Acesso(_Token(_Token.Count - 1))
            If _Controle_Atual.AcessToken IsNot Nothing Then
                Dim _Controle_Pedido As New Controle_Pedido(_Controle_Atual)
                _Controle_Pedido.UploadArquivo(ArquivoXML.Text, "aaaa")
                If _Controle_Atual.Erro.Length > 0 Then
                    MsgBox("Ocorreu o seguinte erro Buscando os Pedidos:" & _Controle_Atual.Erro_MSG, 64, _Controle_Atual.Erro)
                End If
            End If
        Else
            MsgBox("Token não encontrado! Efetue o processo de Autorização e Geração do Token Novamente!")
        End If
        GeraGrid_Cabeçalho(lista_Venda)
        Me.Text = cap
    End Sub
    Private Function Busca_Produto_Vinculados(Lista As List(Of VendaDados)) As List(Of VendaDados)
        Try
            Dim DaoPI As New DAOProdutoIntegracao
            Dim Lista_Integracao As New List(Of PProdutoIntegracao)
            Dim List_Integracao As New List(Of PProdutoIntegracao)
            Lista_Integracao = DaoPI.Get_ProdutoIntegração(Plataforma.Text, 0, "")
            Dim DaoP As New DAOProduto
            Dim ListaProduto As New List(Of Produto)
            For Each L In Lista
                List_Integracao = New List(Of PProdutoIntegracao)
                List_Integracao = Lista_Integracao.FindAll(Function(P As PProdutoIntegracao) P.Produto_LojaID = L.CodProduto_Loja)
                If List_Integracao.Count > 0 Then
                    L.CodProdutoAuto = List_Integracao(0).ProdutoID
                    L.Descricao = List_Integracao(0).Descricao
                End If
            Next
        Catch ex As Exception
        Finally
        End Try
        Return Lista
    End Function
    Private Function Busca_Pedido_Gerado(LcPlataforma As String, Referencencia As String) As String
        Dim Resp As String = ""
        Try
            Dim DaoV As New DAOVenda
            Resp = DaoV.Retorna_ID_Venda(LcPlataforma, Referencencia)
        Catch ex As Exception
        Finally
        End Try
        Return Resp
    End Function
    Private Sub GridCabecalho_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridCabecalho.CellEndEdit

    End Sub
End Class