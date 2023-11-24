Imports System.IO
Imports System.Net
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports IntegracaoMarkPlace.Shopee
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ControleProdutoShopee
    Implements I_Produto_Strategy

    Private _Quantidade_Registro_Por_Pagina As Integer = 50
    Private Caminho_APP As String = "/api/v2/product/get_item_list"
    Private Caminho_Info As String = "/api/v2/product/get_item_base_info"

    Private Caminho_Atualizar_Preço As String = "/api/v2/product/update_price"
    Private Caminho_Atualizar_Estoque As String = "/api/v2/product/update_stock"
    Public Event Informação_Processo(Descrição As String) Implements I_Produto_Strategy.Informação_Processo
    Public Property Configuração As ConfiguracaoIntegracao Implements I_Produto_Strategy.Configuração
    Public Property AcessToken As String Implements I_Produto_Strategy.AcessToken
    Public Property Status_Pesquisar As String Implements I_Produto_Strategy.Status_Pesquisar

    Public Property DataInicio As String Implements I_Produto_Strategy.DataInicio
    Public Property DataFim As String Implements I_Produto_Strategy.DataFim

    Public Property Erro As String = "" Implements I_Produto_Strategy.Erro

    Public Property Erro_MSG As String = "" Implements I_Produto_Strategy.Erro_MSG

    Public Function Busca_Produto() As List(Of ProdutosExibir) Implements I_Produto_Strategy.Busca_Produto
        Dim Resposta As New List(Of ProdutosExibir)
        RaiseEvent Informação_Processo("Configurando Processo de Busca")

        Dim URL As String = Configuração.Endereço_Host & Caminho_APP
        Dim TimeSpam As Long = Shopee.Utilitário.Gera_Time_Spam
        RaiseEvent Informação_Processo("Recuperando o Sinal")
        Dim _Sinal = Shopee.Utilitário.Gerar_Signature(Configuração.ID_Aplicação, Configuração.Senha_Aplicação, Caminho_APP, AcessToken, Configuração.Loja_ID)
        If Status_Pesquisar.Length = 0 Then Status_Pesquisar = "NORMAL"

        Dim _Chamada As String = URL & "?access_token=" & AcessToken
        _Chamada += "&item_status=" & Status_Pesquisar
        _Chamada += "&offset=0"
        _Chamada += "&page_size=" & _Quantidade_Registro_Por_Pagina.ToString
        _Chamada += "&partner_id=" & Configuração.ID_Aplicação.ToString
        _Chamada += "&shop_id=" & Configuração.Loja_ID.ToString
        _Chamada += "&sign=" & _Sinal.ToString
        _Chamada += "&timestamp=" & TimeSpam.ToString

        If IsDate(DataInicio) And IsDate(DataFim) Then
            Dim _Inicio As Integer = CLng(DateTime.UtcNow.Subtract(New DateTime(DataInicio)).TotalMilliseconds)
            Dim _Fim As Integer = CLng(DateTime.UtcNow.Subtract(New DateTime(DataFim)).TotalMilliseconds)
            _Chamada += "&update_time_from=" = _Inicio
            _Chamada += "&update_time_to=" = _Fim
        End If

        Dim request As HttpWebRequest = CType(WebRequest.Create(_Chamada), HttpWebRequest)
        request.Method = "GET"
        request.ContentType = "application/json"

        Try
            Dim TemPróximaPagina As Boolean = False
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                RaiseEvent Informação_Processo("Comunicando com a Shopee")
                Using reader As New StreamReader(response.GetResponseStream())
                    RaiseEvent Informação_Processo("Processando a Resposta")
                    Dim responseText As String = reader.ReadToEnd()
                    Console.WriteLine(responseText)

                    Dim ret As JObject = JObject.Parse(responseText)
                    Dim _Response As String = ret("response").ToString()
                    Dim Msg_Erro As String = ret("message").ToString()
                    Dim _Erro As String = ret("error").ToString()
                    If _Erro.Length = 0 Then
                        Dim retorno_itens As JObject = JObject.Parse(_Response)
                        Dim Itens As String = retorno_itens("item").ToString()
                        TemPróximaPagina = CBool(retorno_itens("has_next_page").ToString())
                        Dim ListaItens As List(Of Resumo_Item_Produtos) = JsonConvert.DeserializeObject(Of List(Of Resumo_Item_Produtos))(Itens)
                        Resposta = Get_Detalhes_Item(ListaItens)
                    Else
                        Erro = _Erro
                        Erro_MSG = Msg_Erro
                    End If

                End Using
            End Using
        Catch ex As WebException
            Console.WriteLine(ex.Message)
        End Try
        Return Resposta
    End Function
    Private Function Get_Detalhes_Item(ListaItens As List(Of Resumo_Item_Produtos)) As List(Of ProdutosExibir)
        Dim _Item As String = ""
        Dim Lista_Produto_Shopee As New List(Of Shopee.Produto)
        Dim Lista_Exibir As New List(Of ProdutosExibir)
        RaiseEvent Informação_Processo("Separando os Itens recebidos")
        For Each Item As Resumo_Item_Produtos In ListaItens
            If _Item.Length > 0 Then _Item += ","
            _Item += Item.item_id.ToString
        Next
        If _Item.Length > 0 Then
            Lista_Produto_Shopee = Busca_na_Loja(_Item)
            Lista_Exibir = Converter_Lista_Shopee_em_Lista_Resumo(Lista_Produto_Shopee)
        End If

        Return Lista_Exibir
    End Function
    Private Function Converter_Lista_Shopee_em_Lista_Resumo(Lista_Shopee As List(Of Shopee.Produto)) As List(Of ProdutosExibir)
        Dim Lista_Exibir As New List(Of ProdutosExibir)
        For Each Produto As Shopee.Produto In Lista_Shopee
            RaiseEvent Informação_Processo("Processando o Item:" & Produto.item_id & " - " & Produto.item_name)
            Dim Resumo As New ProdutosExibir
            Resumo.Frete = 0
            Resumo.Codigo = ""
            Resumo.QTD = 0
            Resumo.QTD_Loja = Get_Quantidade_Loja(Produto.stock_info_v2)
            Resumo.CodigoAuto = 0
            Resumo.Barra = ""
            Resumo.Nome = Produto.item_name
            Resumo.SKU = Produto.item_sku
            Resumo.PerLoja = 0
            Resumo.Seleciona = False
            Resumo.PrecoLoja = Get_Preço_Loja(Produto.price_info)
            Resumo.Preco = 0
            Resumo.ItemID_Loja = Produto.item_id
            Lista_Exibir.Add(Resumo)
        Next

        Return Lista_Exibir
    End Function
    Private Function Get_Preço_Loja(Lista_Preço As List(Of PriceInfo)) As Decimal
        Dim Resposta As Decimal = 0
        If Lista_Preço IsNot Nothing Then
            If Lista_Preço.Count > 0 Then
                Resposta = Lista_Preço(0).current_price
            End If
        End If
        Return Resposta
    End Function
    Private Function Get_Quantidade_Loja(Dados_Quantidade As StockInfoV2) As Integer
        Dim Resposta As Integer = 0
        Dim Lista_Estoque As New List(Of SellerStock)

        If Dados_Quantidade IsNot Nothing Then
            Lista_Estoque = Dados_Quantidade.seller_stock
            If Lista_Estoque IsNot Nothing Then
                If Lista_Estoque.Count > 0 Then
                    Resposta = Lista_Estoque(0).stock
                End If
            End If
        End If
        Return Resposta
    End Function
    Private Function Busca_na_Loja(ItemIDs As String) As List(Of Shopee.Produto)
        Dim ListaProdutos As New List(Of Shopee.Produto)
        Dim URL As String = Configuração.Endereço_Host & Caminho_Info
        Dim TimeSpam As Long = Shopee.Utilitário.Gera_Time_Spam
        Dim _Sinal = Shopee.Utilitário.Gerar_Signature(Configuração.ID_Aplicação, Configuração.Senha_Aplicação, Caminho_Info, AcessToken, Configuração.Loja_ID)

        Dim _Chamada As String = URL & "?access_token=" & AcessToken
        _Chamada += "&partner_id=" & Configuração.ID_Aplicação.ToString
        _Chamada += "&shop_id=" & Configuração.Loja_ID.ToString
        _Chamada += "&sign=" & _Sinal.ToString
        _Chamada += "&timestamp=" & TimeSpam.ToString
        _Chamada += "&item_id_list=" & ItemIDs

        Dim request As HttpWebRequest = CType(WebRequest.Create(_Chamada), HttpWebRequest)
        request.Method = "GET"
        request.ContentType = "application/json"

        Try
            Dim TemPróximaPagina As Boolean = False
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim responseText As String = reader.ReadToEnd()
                    Console.WriteLine(responseText)

                    Dim ret As JObject = JObject.Parse(responseText)
                    Dim Msg_Erro As String = ret("message").ToString()
                    Dim _Erro As String = ret("error").ToString()

                    Dim _Response As String = ""
                    If ret("response") IsNot Nothing Then _Response = ret("response").ToString()

                    If _Erro.Length = 0 Then
                        Dim retorno_itens As JObject = JObject.Parse(_Response)
                        Dim Itens As String = retorno_itens("item_list").ToString()
                        ListaProdutos = JsonConvert.DeserializeObject(Of List(Of Shopee.Produto))(Itens)

                    Else
                        Erro = _Erro
                        Erro_MSG = Msg_Erro
                    End If

                End Using
            End Using
        Catch ex As WebException
            Console.WriteLine(ex.Message)
        End Try
        Return ListaProdutos
    End Function



    Public Sub Alterar_Preço(ByRef Lista_dados_Produto As List(Of BaseAtualização)) Implements I_Produto_Strategy.Alterar_Preço

        Try
            RaiseEvent Informação_Processo("Configurando Processo de Atualização")
            Dim URL As String = Configuração.Endereço_Host & Caminho_Atualizar_Preço
            Dim TimeSpam As Long = Shopee.Utilitário.Gera_Time_Spam
            Dim Corpo As String = ""
            RaiseEvent Informação_Processo("Gerando o Sinal")
            Dim _Sinal = Shopee.Utilitário.Gerar_Signature(Configuração.ID_Aplicação, Configuração.Senha_Aplicação, Caminho_Atualizar_Preço, AcessToken, Configuração.Loja_ID)
            Dim _Chamada As String = URL & "?access_token=" & AcessToken
            _Chamada += "&partner_id=" & Configuração.ID_Aplicação.ToString
            _Chamada += "&shop_id=" & Configuração.Loja_ID.ToString
            _Chamada += "&sign=" & _Sinal.ToString
            _Chamada += "&timestamp=" & TimeSpam.ToString

            For Each Dados_Produto In Lista_dados_Produto
                RaiseEvent Informação_Processo("Montado string de envio produto:" & Dados_Produto.IDProduto)
                If Corpo.Length > 0 Then Corpo += ","
                Corpo += """item_id"":" & Dados_Produto.IDProduto & ", ""price_list"":[{"
                If Dados_Produto.Departamento.Length > 0 Then
                    Corpo += """model_id"": """ & Dados_Produto.Departamento & ","
                End If
                Corpo += """original_price"":" & Dados_Produto.Preço.ToString.Replace(".", "").Replace(",", ".") & "}]"
            Next
            If Corpo.Length > 0 Then Corpo = "{" & Corpo & "}"
            RaiseEvent Informação_Processo("Comunicando com a Shopee")
            Dim request As HttpWebRequest = CType(WebRequest.Create(_Chamada), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"
            Dim dataBytes As Byte() = Encoding.UTF8.GetBytes(Corpo)
            request.ContentLength = dataBytes.Length
            Using requestStream As Stream = request.GetRequestStream()
                requestStream.Write(dataBytes, 0, dataBytes.Length)
            End Using

            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Dim responseStream As Stream = response.GetResponseStream()
            RaiseEvent Informação_Processo("Processando a Resposta")
            Dim reader As New StreamReader(responseStream)
            Dim result As String = reader.ReadToEnd()

            reader.Close()
            responseStream.Close()
            response.Close()

            If Not String.IsNullOrEmpty(result) Then
                Dim ret As JObject = JObject.Parse(result)
                If ret IsNot Nothing Then
                    Dim Msg_Erro As String = ret("message").ToString()
                    Dim _Erro As String = ret("error").ToString()
                    If _Erro.Length = 0 Then

                    Else
                        Erro = _Erro
                        Erro_MSG = Msg_Erro
                    End If
                End If

            End If

        Catch ex As Exception

        End Try


    End Sub

    Public Sub Alterar_Quantidade(ByRef Lista_dados_Produto As List(Of BaseAtualização)) Implements I_Produto_Strategy.Alterar_Quantidade
        Try
            RaiseEvent Informação_Processo("Configurando Processo de Atualização")
            Dim URL As String = Configuração.Endereço_Host & Caminho_Atualizar_Estoque
            Dim TimeSpam As Long = Shopee.Utilitário.Gera_Time_Spam
            Dim Corpo As String = ""
            RaiseEvent Informação_Processo("Gerando o Sinal")
            Dim _Sinal = Shopee.Utilitário.Gerar_Signature(Configuração.ID_Aplicação, Configuração.Senha_Aplicação, Caminho_Atualizar_Estoque, AcessToken, Configuração.Loja_ID)
            Dim _Chamada As String = URL & "?access_token=" & AcessToken
            _Chamada += "&partner_id=" & Configuração.ID_Aplicação.ToString
            _Chamada += "&shop_id=" & Configuração.Loja_ID.ToString
            _Chamada += "&sign=" & _Sinal.ToString
            _Chamada += "&timestamp=" & TimeSpam.ToString

            For Each Dados_Produto In Lista_dados_Produto
                RaiseEvent Informação_Processo("Montado string de envio produto:" & Dados_Produto.IDProduto)
                If Corpo.Length > 0 Then Corpo += ","
                Corpo += """item_id"":" & Dados_Produto.IDProduto & ", ""stock_list"":[{"
                If Dados_Produto.Departamento.Length > 0 Then
                    Corpo += """model_id"": """ & Dados_Produto.Departamento & ","
                End If
                Corpo += """seller_stock"":[{"
                ' Corpo += """location_id"": ""PHZ "","
                Corpo += """stock"":" & Dados_Produto.Quantidade.ToString.Replace(".", "").Replace(",", ".") & "}]}]"
            Next
            If Corpo.Length > 0 Then Corpo = "{" & Corpo & "}"
            RaiseEvent Informação_Processo("Comunicando com a Shopee")
            Dim request As HttpWebRequest = CType(WebRequest.Create(_Chamada), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"
            Dim dataBytes As Byte() = Encoding.UTF8.GetBytes(Corpo)
            request.ContentLength = dataBytes.Length
            Using requestStream As Stream = request.GetRequestStream()
                requestStream.Write(dataBytes, 0, dataBytes.Length)
            End Using

            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Dim responseStream As Stream = response.GetResponseStream()
            RaiseEvent Informação_Processo("Processando a Resposta")
            Dim reader As New StreamReader(responseStream)
            Dim result As String = reader.ReadToEnd()

            reader.Close()
            responseStream.Close()
            response.Close()

            If Not String.IsNullOrEmpty(result) Then
                Dim ret As JObject = JObject.Parse(result)
                If ret IsNot Nothing Then
                    Dim Msg_Erro As String = ret("message").ToString()
                    Dim _Erro As String = ret("error").ToString()
                    If _Erro.Length = 0 Then

                    Else
                        Erro = _Erro
                        Erro_MSG = Msg_Erro
                    End If
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Function Get_refresh_Token() As Token Implements I_Produto_Strategy.Get_refresh_Token
        Throw New NotImplementedException()
    End Function
End Class
