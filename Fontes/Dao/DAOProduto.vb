
Imports IntegracaoMarkPlace.Shopee

Public Class DAOProduto
    Public Property Erro As String = ""
    Function Lista(Optional ByVal CodMercadoria As Long = 0, Optional ByVal Nome As String = "",
                         Optional ByVal Classificar As IntegracaoMarkPlace.I_Produto.Classificação = IntegracaoMarkPlace.I_Produto.Classificação.Nome,
                         Optional ByVal Descente As Boolean = False, Optional ByVal Ativo As Boolean = False, Optional CódigoBarra As String = ""
                        ) As List(Of Produto)
        Return FabricaProduto.CriaProduto.Lista(CodMercadoria, Nome, Classificar, Descente, Ativo, CódigoBarra)
    End Function
    Function Incluir(ByVal _Produto As Produto) As Boolean
        Erro = Valida_Produto(_Produto)
        If Erro.Length = 0 Then
            Return FabricaProduto.CriaProduto.Incluir(_Produto)
        Else
            Return False
        End If

    End Function
    Public Sub RecuperaInformaçãoNCM(NCM As String, ByRef Descricao As String, ByRef CEST As String)
        FabricaProduto.CriaProduto.RecuperaInformaçãoNCM(NCM, Descricao, CEST)
    End Sub
    Function Excluir(ByVal Código As Long) As Boolean
        Return FabricaProduto.CriaProduto.Excluir(Código)
    End Function
    Function Alterar(ByVal _Produto As Produto) As Boolean
        Erro = Valida_Produto(_Produto)
        If Erro.Length = 0 Then
            Return FabricaProduto.CriaProduto.Alterar(_Produto)
        Else
            Return False
        End If

    End Function
    Private Function Valida_Produto(_Produto As Produto) As String
        Dim Resposta As String = ""
        If _Produto.Descricao.Length = 0 Then Resposta = "Nome do produto Inválido."
        If _Produto.NCM.Length < 8 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "NCM Inválido."
        End If

        If _Produto.Unidade.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Unidade inválida."
        End If
        If IsDBNull(_Produto.PrecoCusto) Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Preço de custo não informado."
        End If
        If IsDBNull(_Produto.PrecoVenda) Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Preço de venda não informado."
        End If
        If IsDBNull(_Produto.Minimo) Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Minimo de estoque inválido."
        End If
        If IsDBNull(_Produto.Maximo) Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Máximo de estoque inválido."
        End If
        If _Produto.CodBarra.Length > 0 Then
            If _Produto.CodBarra.Length <> 13 AndAlso _Produto.CodBarra.Length <> 14 Then
                If Resposta.Length > 0 Then Resposta += Chr(10)
                Resposta += "EAN-13 informado é inválido."
            Else
                If CodBarra_Já_Cadastrado(_Produto.CodBarra, _Produto.CodMercadoria) Then
                    If Resposta.Length > 0 Then Resposta += Chr(10)
                    Resposta += "EAN-13 já cadastrado."
                End If
            End If
        End If

        Return Resposta
    End Function
    Private Function CodBarra_Já_Cadastrado(CodBarra As String, CodProduto As Integer) As Boolean
        Dim Resposta As Boolean = False
        Dim Lista_Produto As List(Of Produto) = Me.Lista(0, "", I_Produto.Classificação.CodMercadoria, False, False, CodBarra)
        If Lista_Produto.Count > 0 Then
            If CodProduto = 0 Then
                Resposta = True
            Else
                If Lista_Produto(0).CodMercadoria <> CodProduto Then
                    Resposta = True
                End If

            End If
        End If
        Return Resposta
    End Function
End Class
