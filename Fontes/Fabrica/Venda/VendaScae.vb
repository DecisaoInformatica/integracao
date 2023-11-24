Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports IntegracaoMarkPlace.Shopee
Imports Microsoft.Web.WebView2

Public Class VendaScae
    Implements I_Venda

    Private ClAcesso As New AcessoDados.AcessoAdoNet
    Public Property Erro As String = ""
    Private Sistema_Implementado As String = "SCAE"
    Sub New(_Sistema_Implementado As String)
        Sistema_Implementado = _Sistema_Implementado
    End Sub
    Public Function Incluir_Cabecalho(Lista As PVenda) As Integer Implements I_Venda.Incluir_Cabecalho
        Try
            Lista.CodVenda = Recupera_NumeroVenda()
            Dim StrSql As String = "Insert Into tblVendas (Codvenda,CodUsuario,Nomenclatura,DataVenda,Hora,"
            StrSql += "TipoVenda,TipoPag,ValorParcela,NumParcelas,Entrada,"
            StrSql += "CodVendedor,CodCliente,NomeCliente,Cliente,"
            StrSql += "TotalVendas,TotalProduto,DespFrete,Desconto,PerDesconto,Frete,PrecoCusto"
            StrSql += ")Values("
            StrSql += Lista.CodVenda & ","
            StrSql += "'" & Lista.Referencia.Replace("'", "''") & "',"
            StrSql += "'" & Lista.Plataforma.Replace("'", "''") & "',"
            StrSql += "'" & Format(CDate(Lista.DataVenda), "yyyy-MM-dd") & "',"
            StrSql += "'" & Lista.Hora & "',"
            StrSql += "'" & Lista.TipoVenda.Replace("'", "''") & "',"
            StrSql += "'" & Lista.TipoPag.Replace("'", "''") & "',"
            StrSql += Lista.ValorVenda.ToString.Replace(",", ".") & ","
            StrSql += 0 & ","
            StrSql += 0 & ","
            StrSql += Lista.CodVendedor & ","
            StrSql += Lista.CodCliente & ","
            StrSql += "'" & Lista.NomeCliente.Replace("'", "''") & "',"
            StrSql += "'" & Lista.NomeCliente.Replace("'", "''") & "',"
            StrSql += Lista.ValorVenda.ToString.Replace(",", ".") & ","
            StrSql += Lista.ValorVenda.ToString.Replace(",", ".") & ","
            StrSql += 0 & ","
            StrSql += 0 & ","
            StrSql += 0 & ","
            StrSql += 0 & ","
            StrSql += Lista.CustoTotal.ToString.Replace(",", ".") & ")"
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Dim Afetados As Integer = ClAcesso.ExecutaSql(StrSql)
            If Afetados = 0 Then
                Lista.CodVenda = 0
            End If
        Catch ex As Exception
        Finally
        End Try
        Return Lista.CodVenda
    End Function
    Private Function Recupera_NumeroVenda() As Integer
        Dim Resp As Integer = 0
        Try
            Dim StrSql As String = "Select * FROM numerovenda"
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Using Dr As DataSet = ClAcesso.ObtemDataset(StrSql)
                If Dr.Tables(0).Rows.Count > 0 Then
                    Resp = CInt(Dr.Tables(0).Rows(0).Item("Numero"))
                    Resp += 1
                End If
                If Not ClAcesso.TransacaoEstaAtiva Then ClAcesso.FechaConexao()
            End Using

            StrSql = "update NumeroVenda set Numero=[Numero] + 1"
            Dim Afetados As Integer = ClAcesso.ExecutaSql(StrSql)
        Catch ex As Exception
        Finally
        End Try
        Return Resp
    End Function
    Public Function Incluir_Item(Lista As PVenda_Item) As Boolean Implements I_Venda.Incluir_Item
        Dim Resp As Boolean = False
        Try
            Dim Strsql As String = "Insert Into tblVendasProduto (CodVenda,CodMercadoria,Descricao,Unidade,"
            Strsql += "Quantidade,Devolvida,QuantEntrega,NumItem,VUnitario,SubTotal,Desconto,VTotal,CustoMedUnit,"
            Strsql += "CustoUltCompraUnit,CodFornec"
            Strsql += ")Values("
            Strsql += Lista.CodVenda & ","
            Strsql += Lista.CodMercadoria & ","
            Strsql += "'" & Mid(Lista.Descricao.Replace("'", "''"), 1, 60) & "',"
            Strsql += "'" & Lista.Unidade & "',"
            Strsql += Replace(Lista.Quantidade, ",", ".") & ","
            Strsql += "0,"
            Strsql += Replace(Lista.Quantidade, ",", ".") & ","
            Strsql += Lista.NumItem & ","
            Strsql += Replace(Lista.ValorUnit, ",", ".") & ","
            Strsql += Replace(Lista.SubTotal, ",", ".") & ","
            Strsql += "0,"
            Strsql += Replace(Lista.SubTotal, ",", ".") & ","
            Strsql += Replace(Lista.CustoUnit, ",", ".") & ","
            Strsql += Replace(Lista.CustoUnit, ",", ".") & ","
            Strsql += Lista.CodFornecedor & ")"
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Dim Afetados As Integer = ClAcesso.ExecutaSql(Strsql)
            If Afetados <> 0 Then Resp = True
        Catch ex As Exception
        Finally
        End Try
        Return Resp
    End Function

    Public Function Retorna_ID_Venda(Plataforma As String, Referencia As String) As String Implements I_Venda.Retorna_ID_Venda
        Dim Resp As String = ""
        Try
            Dim StrSql As String = "Select CodVenda FROM tblvendas "
            StrSql += " Where CodUsuario='" & Referencia & "' and Nomenclatura='" & Plataforma & "'"
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Using Dr As DataSet = ClAcesso.ObtemDataset(StrSql)
                If Dr.Tables(0).Rows.Count > 0 Then
                    Resp = CInt(Dr.Tables(0).Rows(0).Item("CodVenda"))
                End If
                If Not ClAcesso.TransacaoEstaAtiva Then ClAcesso.FechaConexao()
            End Using
        Catch ex As Exception
        Finally
        End Try
        Return Resp
    End Function
End Class