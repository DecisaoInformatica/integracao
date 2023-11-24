Imports IntegracaoMarkPlace.Shopee
Imports System.Security

Public Class ProdutoScae
    Implements I_Produto

    Public Property Erro As String = ""
    Private Sistema_Implementado As String = "SCAE"

    Sub New(_Sistema_Implementado As String)
        Sistema_Implementado = _Sistema_Implementado
    End Sub
    Private Function CriarLista(ByVal dr As DataSet) As List(Of Produto)
        Dim LcLista As New List(Of Produto)
        Dim produto As New Produto
        Try
            If Not dr Is Nothing Then
                For x = 0 To dr.Tables(0).Rows.Count - 1
                    With dr.Tables(0).Rows(x)
                        produto = New Produto
                        produto.CodMercadoria = .Item("CodMercadoria")
                        produto.Descricao = .Item("Descricao").ToString
                        produto.Unidade = .Item("Unidade").ToString
                        produto.Estoque = .Item("Quantidade")
                        produto.PrecoCusto = .Item("precoCusto")
                        produto.PrecoVenda = .Item("PrecoVenda")
                        'produto.CodFornecedor = .Item("UltimoFornec")
                        produto.CodBarra = .Item("Barra").ToString
                        produto.Ativo = .Item("ativo")
                        produto.NCM = .Item("ClassificacaoFiscal").ToString
                        produto.CEST = .Item("Cest").ToString
                        produto.Minimo = .Item("minimo").ToString
                        produto.Maximo = .Item("Maximo").ToString
                        produto.obs = .Item("obs").ToString
                        LcLista.Add(produto)
                    End With
                Next

            End If
        Catch ex As Exception

        End Try
        Return LcLista
    End Function
    Public Function Incluir(ByVal _Produto As Produto) As Boolean Implements I_Produto.Incluir
        Dim Resposta As Boolean = False
        Dim StrSql As String = ""
        Try
            StrSql = "Insert into tblMercadoria(Descricao,Quantidade,PrecoCusto,PrecoVenda,"
            StrSql += "Unidade,Ativo,minimo,maximo,barra,obs,"
            StrSql += "ClassificacaoFiscal,CEST"
            StrSql += ")values("
            StrSql += "'" & _Produto.Descricao.Replace("'", "''") & "',"
            StrSql += _Produto.Estoque.ToString.Replace(",", ".") & ","
            StrSql += _Produto.PrecoCusto.ToString.Replace(",", ".") & ","
            StrSql += _Produto.PrecoVenda.ToString.Replace(",", ".") & ","
            StrSql += "'" & _Produto.Unidade.Replace("'", "''") & "',"
            StrSql += _Produto.Ativo & ","
            StrSql += _Produto.Minimo.ToString.Replace(",", ".") & ","
            StrSql += _Produto.Maximo.ToString.Replace(",", ".") & ","
            StrSql += "'" & _Produto.CodBarra.Replace("'", "''") & "',"
            StrSql += "'" & _Produto.obs.Replace("'", "''") & "',"
            StrSql += "'" & _Produto.NCM.Replace("'", "''") & "',"
            StrSql += "'" & _Produto.CEST.Replace("'", "''") & "')"


            util.IniciaBase()
            Dim Afetado As Integer = util.ClAcesso.ExecutaSql(StrSql)
            If Afetado > 0 Then
                Resposta = True
            End If
        Catch ex As Exception
            Erro = ex.Message
        End Try
        Return Resposta
    End Function
    Public Sub RecuperaInformaçãoNCM(NCM As String, ByRef Descricao As String, ByRef CEST As String) Implements I_Produto.RecuperaInformaçãoNCM
        Dim Dr As New DataSet
        Try

            Dim StrSql As String = "Select * from NCM where Ncm='" & NCM.Replace(".", "").Replace(" ", "").Replace(",", "") & "'"
            util.IniciaBase()
            Dr = util.ClAcesso.ObtemDataset(StrSql)
            If Dr.Tables(0).Rows.Count > 0 Then
                Descricao = Dr.Tables(0).Rows(0).Item("Descricao").ToString
                CEST = Dr.Tables(0).Rows(0).Item("CEST").ToString
            Else
                Descricao = "NCM não encontrado no cadastro."
            End If
            Dr.Dispose()

        Catch ex As Exception
        Finally
            Try
                Dr.Dispose()
            Catch ex As Exception

            End Try
        End Try
    End Sub
    Public Function Lista(Optional ByVal CodMercadoria As Long = 0, Optional ByVal Nome As String = "",
                         Optional ByVal Classificar As IntegracaoMarkPlace.I_Produto.Classificação = IntegracaoMarkPlace.I_Produto.Classificação.Nome,
                         Optional ByVal Descente As Boolean = False, Optional ByVal Ativo As Boolean = False, Optional CódigoBarra As String = ""
                        ) As List(Of Produto) Implements I_Produto.Lista
        Dim LcLista As New List(Of Produto)
        Try
            '==> Cria as consulta
            Dim StrWhere As String = ""
            Dim StrClassificação As String = ""
            Dim StrSql As String = "Select CodMercadoria,Descricao,Unidade,Quantidade,PrecoCusto,PrecoVenda,Barra,ativo,ClassificacaoFiscal,Cest,minimo,Maximo,obs  from TblMercadoria "
            If CodMercadoria > 0 Then
                StrWhere = " CodMercadoria=" & CodMercadoria
            End If
            If Nome.Length > 0 Then
                If StrWhere.Length > 0 Then StrWhere += " And "
                StrWhere += " Descricao like'" & Nome.Replace("'", "''") & "%'"
            End If
            If CódigoBarra.Length > 0 Then
                If StrWhere.Length > 0 Then StrWhere += " And "
                StrWhere += " barra ='" & CódigoBarra.Replace("'", "''") & "'"
            End If
            If Ativo Then
                If StrWhere.Length > 0 Then StrWhere += " And "
                StrWhere += " Ativo=" & Ativo
            End If
            '==> Recupera a Classificacao
            Select Case Classificar
                Case Is = IntegracaoMarkPlace.I_Produto.Classificação.CodMercadoria
                    StrClassificação = " order by CodMercadoria "
                Case Is = IntegracaoMarkPlace.I_Produto.Classificação.Nome
                    StrClassificação = " order by Descricao "
            End Select
            If Descente Then
                StrClassificação += "desc"
            End If
            '==> Concatena o where
            If StrWhere.Length > 0 Then
                StrSql += " where " & StrWhere
            End If
            StrSql += StrClassificação

            '==> Inicia a Base
            util.IniciaBase()
            Dim Dr As DataSet = util.ClAcesso.ObtemDataset(StrSql)

            LcLista = CriarLista(Dr)
            Dr.Dispose()

        Catch ex As Exception
            Erro = ex.Message
        End Try

        Return LcLista
    End Function
    Public Function Alterar(ByVal _Produto As Produto) As Boolean Implements I_Produto.Alterar
        Dim Resposta As Boolean = False
        If _Produto.CodMercadoria = 0 Then GoTo saída
        Try
            Dim StrSql As String = "Update tblmercadoria set "
            StrSql += "Descricao='" & _Produto.Descricao.Replace("'", "''") & "',"
            StrSql += "Quantidade=" & _Produto.Estoque.ToString.Replace(",", ".") & ","
            StrSql += "PrecoCusto=" & _Produto.PrecoCusto.ToString.Replace(",", ".") & ","
            StrSql += "PrecoVenda=" & _Produto.PrecoVenda.ToString.Replace(",", ".") & ","
            StrSql += "Unidade='" & _Produto.Unidade.Replace("'", "''") & "',"
            StrSql += "Ativo=" & _Produto.Ativo & ","
            StrSql += "minimo=" & _Produto.Minimo.ToString.Replace(",", ".") & ","
            StrSql += "maximo=" & _Produto.Maximo.ToString.Replace(",", ".") & ","
            StrSql += "barra='" & _Produto.CodBarra.Replace("'", "''") & "',"
            StrSql += "obs='" & _Produto.obs.Replace("'", "''") & "',"
            StrSql += "ClassificacaoFiscal='" & _Produto.NCM & "',"
            StrSql += "CEST='" & _Produto.CEST.Replace("'", "''") & "'"
            StrSql += " Where CodMercadoria=" & _Produto.CodMercadoria

            util.IniciaBase()
            Dim Afetado As Integer = util.ClAcesso.ExecutaSql(StrSql)
            If Afetado > 0 Then
                Resposta = True
            End If
        Catch ex As Exception
            Erro = ex.Message
        End Try
saída:
        Return Resposta
    End Function
    Public Function Excluir(ByVal Código As Long) As Boolean Implements I_Produto.Excluir
        Dim Resposta As Boolean = False
        If Código = 0 Then GoTo saída
        Try
            Dim StrSql As String = "Delete from tblmercadoria Where CodMercadoria=" & Código

            util.IniciaBase()
            Dim Afetado As Integer = util.ClAcesso.ExecutaSql(StrSql)
            If Afetado > 0 Then
                Resposta = True
            End If
        Catch ex As Exception
            Erro = ex.Message
        End Try
saída:
        Return Resposta
    End Function
End Class