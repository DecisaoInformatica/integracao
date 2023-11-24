Imports IntegracaoMarkPlace.Shopee

Public Class ProdutoIntegracaoScae
    Implements I_ProdutoIntegracao
    Private ClAcesso As New AcessoDados.AcessoAdoNet
    Public Property Erro As String = ""
    Private Sistema_Implementado As String = "SCAE"
    Sub New(_Sistema_Implementado As String)
        Sistema_Implementado = _Sistema_Implementado
    End Sub
    Private Function CriarLista(ByVal dr As DataSet) As List(Of PProdutoIntegracao)
        Dim Resposta As New List(Of PProdutoIntegracao)
        Dim _ProdutoIntegração As New PProdutoIntegracao

        Try
            For x = 0 To dr.Tables(0).Rows.Count - 1
                With dr.Tables(0).Rows(x)
                    _ProdutoIntegração = New PProdutoIntegracao
                    _ProdutoIntegração.ID = .Item("id")
                    _ProdutoIntegração.ProdutoID = .Item("ProdutoID").ToString
                    _ProdutoIntegração.Produto_LojaID = .Item("Produto_LojaID").ToString
                    _ProdutoIntegração.Preço_Loja = .Item("Preço_Loja").ToString
                    _ProdutoIntegração.Plataforma = .Item("Plataforma").ToString

                    _ProdutoIntegração.PrecoVenda = CDec(.Item("PrecoVenda"))
                    _ProdutoIntegração.Descricao = .Item("Descricao").ToString
                    _ProdutoIntegração.Estoque = CDec(.Item("Quantidade"))
                    Resposta.Add(_ProdutoIntegração)
                End With
            Next

        Catch ex As Exception
            _ProdutoIntegração = Nothing
        End Try
        Return Resposta
    End Function
    Public Function Get_ProdutoIntegração(Plataforma As String, ProdutoID As Integer, ProdutoID_Loja As String) As List(Of PProdutoIntegracao) Implements I_ProdutoIntegracao.Get_ProdutoIntegração
        Dim ProdutoIntegração As New List(Of PProdutoIntegracao)
        Try
            Dim StrWhere As String = ""
            Dim StrSql As String = "Select ProdutoIntegracao.*,tblmercadoria.Descricao,tblmercadoria.Quantidade,tblmercadoria.PrecoVenda"
            StrSql += " from ProdutoIntegracao "
            StrSql += " inner join tblmercadoria on tblmercadoria.CodMercadoria=ProdutoIntegracao.ProdutoID"
            If Plataforma.Length > 0 Then
                If StrWhere.Length > 0 Then StrWhere += " and " Else StrWhere = " Where "
                StrWhere += "ProdutoIntegracao.Plataforma='" & Plataforma & "'"
            End If
            If ProdutoID > 0 Then
                If StrWhere.Length > 0 Then StrWhere += " and " Else StrWhere = " Where "
                StrWhere += "ProdutoIntegracao.ProdutoID=" & ProdutoID
            End If
            If ProdutoID_Loja.Length > 0 Then
                If StrWhere.Length > 0 Then StrWhere += " and " Else StrWhere = " Where "
                StrWhere += "ProdutoIntegracao.Produto_LojaID='" & ProdutoID_Loja & "'"
            End If
            If StrWhere.Length > 0 Then StrSql += StrWhere
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Using Dr As DataSet = ClAcesso.ObtemDataset(StrSql)
                ProdutoIntegração = CriarLista(Dr)
                If Not ClAcesso.TransacaoEstaAtiva Then ClAcesso.FechaConexao()
            End Using
        Catch ex As Exception
            ProdutoIntegração = Nothing
        Finally
        End Try
        Return ProdutoIntegração
    End Function

    Public Function Incluir(ProdutoIntegração As PProdutoIntegracao) As Boolean Implements I_ProdutoIntegracao.Incluir
        Dim Resposta As Boolean = False
        Try
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado

            Dim StrSql As String = "Delete from ProdutoIntegracao where Produto_LojaID='" & ProdutoIntegração.Produto_LojaID & "'"
            StrSql += " and Plataforma='" & ProdutoIntegração.Plataforma & "'"
            Dim Afetado As Integer = ClAcesso.ExecutaSql(StrSql)
            If ProdutoIntegração.ProdutoID > 0 And ProdutoIntegração.Produto_LojaID.Length > 0 Then
                StrSql = "insert into ProdutoIntegracao (ProdutoID,Produto_LojaID,Plataforma,Preço_Loja) Values("
                StrSql += ProdutoIntegração.ProdutoID & ","
                StrSql += "'" & ProdutoIntegração.Produto_LojaID.Replace("'", "''") & "',"
                StrSql += "'" & ProdutoIntegração.Plataforma.Replace("'", "''") & "',"
                StrSql += ProdutoIntegração.Preço_Loja.ToString.Replace(",", ".") & ")"
                Afetado = ClAcesso.ExecutaSql(StrSql)
            End If
            Resposta = True
        Catch ex As Exception
            Resposta = False
        Finally
        End Try
        Return Resposta
    End Function

    Public Function Seta_Token(ProdutoIntegração As PProdutoIntegracao) As Boolean Implements I_ProdutoIntegracao.Seta_Token
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = "Update ProdutoIntegracao set "
            StrSql += "Plataforma='" & ProdutoIntegração.Plataforma.ToString & "',"
            StrSql += "ProdutoID=" & ProdutoIntegração.ProdutoID & ","
            StrSql += "Preço_Loja=" & ProdutoIntegração.Preço_Loja.ToString.Replace(",", ".") & ","
            StrSql += "Produto_LojaID='" & ProdutoIntegração.Produto_LojaID.ToString.Replace(",", ".") & "'"
            StrSql += " where id=" & ProdutoIntegração.ID

            Dim IDGerado As Integer = 0
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Dim afetados As Integer = ClAcesso.ExecutaSql(StrSql, IDGerado)
            If ProdutoIntegração.ID = 0 Then ProdutoIntegração.ID = IDGerado
            If afetados > 0 Then
                Resposta = True
            End If
        Catch ex As Exception
            Resposta = False
        Finally
        End Try
        Return Resposta
    End Function
End Class