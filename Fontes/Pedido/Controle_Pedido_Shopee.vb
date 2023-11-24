Imports IntegracaoMarkPlace.Shopee
Imports Microsoft.Web.WebView2
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports RestSharp
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices.ComTypes
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports System.Text
Imports unirest

Public Class Controle_Pedido_Shopee
    Implements I_Pedido_Strategy

    Private _Quantidade_Registro_Por_Pagina As Integer = 50
    Private Caminho_APP As String = "/api/v2/order/get_order_list"
    Private Caminho_Detalhes As String = "/api/v2/order/get_order_detail"
    Private Caminho_Upload As String = "/api/v2/order/upload_invoice_doc"
    Private Caminho_Cancelamento As String = "/api/v2/order/cancel_order"
    Public Event Informação_Processo(Descrição As String) Implements I_Pedido_Strategy.Informação_Processo
    Public Property Configuração As ConfiguracaoIntegracao Implements I_Pedido_Strategy.Configuração

    Public Property AcessToken As String Implements I_Pedido_Strategy.AcessToken

    Public Property Erro As String = "" Implements I_Pedido_Strategy.Erro
    Public Property Erro_MSG As String = "" Implements I_Pedido_Strategy.Erro_MSG

    Public Function Get_Lista_Pedido(TipoPeríodo As String, DataInicio As String, DataFinal As String,
                                     Status_Pedido As String) As List(Of VendaCabecalho) Implements I_Pedido_Strategy.Get_Lista_Pedido

        Dim Resposta As New List(Of VendaCabecalho)

        Dim URL As String = Configuração.Endereço_Host & Caminho_APP
        RaiseEvent Informação_Processo("Gerando TimeSpam")
        Dim TimeSpam As Long = Shopee.Utilitário.Gera_Time_Spam
        RaiseEvent Informação_Processo("Gerando Sinal")
        Dim _Sinal = Shopee.Utilitário.Gerar_Signature(Configuração.ID_Aplicação, Configuração.Senha_Aplicação, Caminho_APP, AcessToken, Configuração.Loja_ID)

        ' Dim Data As String = Geral.Utilitario.Converter_TimeSpan_Date_Time("1694217600")


        If TipoPeríodo.Length = 0 Then TipoPeríodo = "create_time"

        Dim _Chamada As String = URL & "?access_token=" & AcessToken
        _Chamada += "&time_range_field=" & TipoPeríodo
        _Chamada += "&page_size=" & _Quantidade_Registro_Por_Pagina.ToString
        _Chamada += "&partner_id=" & Configuração.ID_Aplicação.ToString
        _Chamada += "&shop_id=" & Configuração.Loja_ID.ToString
        _Chamada += "&sign=" & _Sinal.ToString
        _Chamada += "&timestamp=" & TimeSpam.ToString
        Dim _Inicio As Long = Geral.Utilitario.Gerar_Time_Span_Data(CDate(DataInicio))  'CInt(DateTime.UtcNow.Subtract(New DateTime(DataInicio)).TotalMilliseconds)
        Dim _Fim As Long = Geral.Utilitario.Gerar_Time_Span_Data(CDate(DataFinal))  ' CInt(DateTime.UtcNow.Subtract(New DateTime(DataFinal)).TotalMilliseconds)
        _Chamada += "&time_from=" & _Inicio.ToString
        _Chamada += "&time_to=" & _Fim.ToString
        _Chamada += "&order_status=" & Shopee.Utilitário.Get_Status_Pedido(Status_Pedido)

        RaiseEvent Informação_Processo("Buscando Lista pedidos...")

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
                    If _Erro.Length = 0 Then
                        RaiseEvent Informação_Processo("Processando a lista Base de pedidos...")
                        Dim _Response As String = ret("response").ToString()
                        Dim retorno_itens As JObject = JObject.Parse(_Response)
                        Dim Pedidos As String = retorno_itens("order_list").ToString()
                        If IsNumeric(retorno_itens("next_cursor").ToString()) Then TemPróximaPagina = CBool(retorno_itens("next_cursor").ToString())
                        Dim ListaPedido As List(Of Shopee.ResumoPedido) = JsonConvert.DeserializeObject(Of List(Of Shopee.ResumoPedido))(Pedidos)
                        RaiseEvent Informação_Processo("Recuperando os detalhes do Pedido")
                        Resposta = Get_Detalhes_Pedido(ListaPedido)
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
    Private Function Get_Detalhes_Pedido(Lista_Pedido As List(Of Shopee.ResumoPedido)) As List(Of VendaCabecalho)
        Dim resposta As New List(Of VendaCabecalho)
        Dim Pedido_ID As String = ""
        RaiseEvent Informação_Processo("Filtrando os pedidos recebidos...")
        For Each ID As Shopee.ResumoPedido In Lista_Pedido
            If Pedido_ID.Length > 0 Then Pedido_ID += ","
            Pedido_ID += ID.order_sn.ToString
        Next
        If Pedido_ID.Length > 0 Then resposta = Get_Detalhes_Pedido_na_Shopee(Pedido_ID)
        Return resposta
    End Function
    Private Function Get_Detalhes_Pedido_na_Shopee(Pedido_ID As String) As List(Of VendaCabecalho)

        Dim Resposta As New List(Of VendaCabecalho)

        Dim URL As String = Configuração.Endereço_Host & Caminho_Detalhes
        Dim TimeSpam As Long = Shopee.Utilitário.Gera_Time_Spam
        Dim _Sinal = Shopee.Utilitário.Gerar_Signature(Configuração.ID_Aplicação, Configuração.Senha_Aplicação, Caminho_Detalhes, AcessToken, Configuração.Loja_ID)

        ' Dim Data As String = Geral.Utilitario.Converter_TimeSpan_Date_Time("1694217600")
        RaiseEvent Informação_Processo("Buscado detalhes do(s) Pedido(s):" & Pedido_ID)

        Dim _Chamada As String = URL & "?access_token=" & AcessToken
        _Chamada += "&partner_id=" & Configuração.ID_Aplicação.ToString
        _Chamada += "&shop_id=" & Configuração.Loja_ID.ToString
        _Chamada += "&sign=" & _Sinal.ToString
        _Chamada += "&timestamp=" & TimeSpam.ToString
        _Chamada += "&order_sn_list=" & Pedido_ID
        _Chamada += "&response_optional_fields=buyer_user_id,buyer_username,estimated_shipping_fee,recipient_address,actual_shipping_fee,item_list,dropshipper,dropshipper_phone,buyer_cpf_id"
        Dim request As HttpWebRequest = CType(WebRequest.Create(_Chamada), HttpWebRequest)
        request.Method = "GET"
        request.ContentType = "application/json"

        Try
            Dim TemPróximaPagina As Boolean = False
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim responseText As String = reader.ReadToEnd()
                    Console.WriteLine(responseText)
                    RaiseEvent Informação_Processo("Processando os detalhes Recebidos...")
                    Dim ret As JObject = JObject.Parse(responseText)

                    Dim Msg_Erro As String = ret("message").ToString()
                    Dim _Erro As String = ret("error").ToString()
                    If _Erro.Length = 0 Then
                        Dim _Response As String = ret("response").ToString()
                        Dim retorno_itens As JObject = JObject.Parse(_Response)
                        Dim Pedidos As String = retorno_itens("order_list").ToString()
                        'If IsNumeric(retorno_itens("next_cursor").ToString()) Then TemPróximaPagina = CBool(retorno_itens("next_cursor").ToString())
                        Dim ListaPedido As List(Of OrderList) = JsonConvert.DeserializeObject(Of List(Of OrderList))(Pedidos)
                        Resposta = Converter_Pedido(ListaPedido)
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
    Private Function Converter_Pedido(Lista_Pedido As List(Of OrderList)) As List(Of VendaCabecalho)
        Dim Resposta As New List(Of VendaCabecalho)
        For Each Pedido As OrderList In Lista_Pedido
            RaiseEvent Informação_Processo("Processando o Pedido:" & Pedido.order_sn)
            Dim Dados_Cabeçalho As New VendaCabecalho
            If Pedido.buyer_cpf_id Is Nothing Then Pedido.buyer_cpf_id = ""
            If Pedido.dropshipper Is Nothing Then Pedido.dropshipper = ""
            Dados_Cabeçalho.Cliente_ID = Get_Cliente_ID(Pedido.buyer_cpf_id)
            Dados_Cabeçalho.Cliente_Nome = Pedido.buyer_username
            Dados_Cabeçalho.Cliente_CPF = Pedido.buyer_cpf_id
            Dados_Cabeçalho.Emissao = Geral.Utilitario.Converter_TimeSpan_Date_Time(Pedido.create_time)
            Dados_Cabeçalho.Forma_Pag = Pedido.dropshipper.ToString
            Dados_Cabeçalho.ID_Loja = Pedido.order_sn
            Dados_Cabeçalho.Itens = Converter_Item_Pedido(Pedido.item_list, Dados_Cabeçalho.ID_Loja)
            Dados_Cabeçalho.Cliente_Endereço = Pedido.recipient_address
            'Dados_Cabeçalho.Valor_Total = Pedido.
            Resposta.Add(Dados_Cabeçalho)
        Next

        Return Resposta
    End Function
    Function Converter_Item_Pedido(Lista_Item As List(Of ItemList), VendaID_Loja As String) As List(Of VendaDados)
        Dim Resposta As New List(Of VendaDados)
        Dim i As Integer = 1
        For Each Item As ItemList In Lista_Item
            RaiseEvent Informação_Processo("Processando o item do Pedido:" & Item.item_name)
            Dim Item_Venda As New VendaDados
            Item_Venda.CodProdutoAuto = 0
            Item_Venda.CodProduto_Loja = Item.item_id
            Item_Venda.Item = i
            Item_Venda.Nome = Item.item_name
            Item_Venda.Quantidade = Item.model_quantity_purchased
            Item_Venda.SKU = Item.item_sku
            Item_Venda.ValorUnitario = Item.model_original_price
            Item_Venda.ValorTotal = Item_Venda.Quantidade * Item_Venda.ValorUnitario
            Item_Venda.VendaDadosID = 0
            Item_Venda.VendaID = 0
            Item_Venda.VendaID_Loja = VendaID_Loja
            Resposta.Add(Item_Venda)
        Next
        Return Resposta
    End Function
    Function Get_Cliente_ID(CPF As String) As Integer
        Dim Resposta As Integer = 0
        If CPF.Length > 9 Then
            Dim Dao_Cliente As New DAOCliente
            Resposta = Dao_Cliente.Retorna_Id_Cliente(CPF)
        End If
        Return Resposta
    End Function
    Public Function Atualizar_Pedido(Id_Pedido_Loja As String) As Object Implements I_Pedido_Strategy.Atualizar_Pedido
        Throw New NotImplementedException()
    End Function
    Function UploadArquivo(Nome_Arquivo As String, NumeroPedido_Shopee As String) As Boolean Implements I_Pedido_Strategy.UploadArquivo
        Dim URL As String = Configuração.Endereço_Host & Caminho_Upload
        Dim TimeSpam As Long = Shopee.Utilitário.Gera_Time_Spam
        Dim _Sinal = Shopee.Utilitário.Gerar_Signature(Configuração.ID_Aplicação, Configuração.Senha_Aplicação, Caminho_Upload, AcessToken, Configuração.Loja_ID)

        ' Dim Data As String = Geral.Utilitario.Converter_TimeSpan_Date_Time("1694217600")
        RaiseEvent Informação_Processo("Subindo com o arquivo " & Nome_Arquivo)
        Dim _Chamada As String = URL & "?access_token=" & AcessToken
        _Chamada += "&partner_id=" & Configuração.ID_Aplicação.ToString
        _Chamada += "&shop_id=" & Configuração.Loja_ID.ToString
        _Chamada += "&sign=" & _Sinal.ToString
        _Chamada += "&timestamp=" & TimeSpam.ToString

        'Dim files As Byte() = File.ReadAllBytes(Nome_Arquivo) ' Replace with actual file path

        Dim options As New RestClientOptions("https://partner.test-stable.shopeemobile.com") With {
            .MaxTimeout = -1
        }
        Dim client As New RestClient(options)
        Dim request As New RestRequest(_Chamada, Method.Post)
        request.AlwaysMultipartFormData = True
        request.AddParameter("order_sn", NumeroPedido_Shopee)
        request.AddParameter("file_type", "4")
        request.AddFile("file", Nome_Arquivo)
        Dim response As RestResponse = client.ExecuteAsync(request).GetAwaiter().GetResult()
        Console.WriteLine(response.Content)
    End Function

    Public Function Cancelar_Pedido(Pedido_Loja As String, Lista_Itens_Cancelar As List(Of BaseAtualização)) As Boolean Implements I_Pedido_Strategy.Cancelar_Pedido
        Dim Resposta As Boolean = False
        Dim URL As String = Configuração.Endereço_Host & Caminho_Cancelamento
        RaiseEvent Informação_Processo("Gerando TimeSpam")
        Dim TimeSpam As Long = Shopee.Utilitário.Gera_Time_Spam
        RaiseEvent Informação_Processo("Gerando Sinal")
        Dim _Sinal = Shopee.Utilitário.Gerar_Signature(Configuração.ID_Aplicação, Configuração.Senha_Aplicação, Caminho_Cancelamento, AcessToken, Configuração.Loja_ID)

        Dim _Chamada As String = URL & "?access_token=" & AcessToken
        _Chamada += "&partner_id=" & Configuração.ID_Aplicação.ToString
        _Chamada += "&shop_id=" & Configuração.Loja_ID.ToString
        _Chamada += "&sign=" & _Sinal.ToString
        _Chamada += "&timestamp=" & TimeSpam.ToString
        _Chamada += "&order_sn=" & Pedido_Loja
        _Chamada += "&cancel_reason=OUT_OF_STOCK"

        RaiseEvent Informação_Processo("Buscando Lista pedidos...")
        Try
            Dim body As String = "{""order_sn"": " & Pedido_Loja & ", ""cancel_reason"":""OUT_OF_STOCK""," & Gera_Cancelamento_Itens(Lista_Itens_Cancelar) & "}"
            Dim request As HttpWebRequest = WebRequest.Create(_Chamada)
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
                Dim ret As JObject = JObject.Parse(result)
                If ret IsNot Nothing Then
                    Dim Msg_Erro As String = ret("message").ToString()
                    Dim _Erro As String = ret("error").ToString()
                    If _Erro.Length > 0 Then
                        Resposta = True
                        Erro = _Erro
                        Erro_MSG = Msg_Erro
                    End If
                End If

            End If

        Catch ex As WebException
            Console.WriteLine(ex.Message)
        End Try
        Return Resposta
    End Function
    Private Function Gera_Cancelamento_Itens(Lista_Itens_Cancelar As List(Of BaseAtualização)) As String
        Dim Corpo As String = ""
        For Each Dados_Produto In Lista_Itens_Cancelar
            RaiseEvent Informação_Processo("Montado lista dos iten(s) a cancelar. Produto:" & Dados_Produto.IDProduto)
            If Corpo.Length > 0 Then Corpo += ","
            Corpo += """item_list"":[{"
            Corpo += """item_id"": """ & Dados_Produto.IDProduto & ","
            Corpo += """model_id"":" & Dados_Produto.Departamento & "}]"
        Next
        Return Corpo
    End Function
End Class
