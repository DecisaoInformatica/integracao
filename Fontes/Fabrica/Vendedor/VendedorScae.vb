Imports IntegracaoMarkPlace.Shopee
Imports Microsoft.Web.WebView2

Public Class VendedorScae
    Implements I_Vendedor
    Private ClAcesso As New AcessoDados.AcessoAdoNet
    Public Property Erro As String = ""
    Private Sistema_Implementado As String = "SCAE"
    Sub New(_Sistema_Implementado As String)
        Sistema_Implementado = _Sistema_Implementado
    End Sub
    Public Function Retorna_Vendedor(Nome As String) As List(Of PVendedor) Implements I_Vendedor.Retorna_Vendedor
        Dim Lista As New List(Of PVendedor)
        Try
            Dim StrSql As String = "Select CodFuncionario,NomeFunc"
            StrSql += " FROM tblfuncionario "
            StrSql += " Where ativo=true And NomeFunc='" & Nome & "'"
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Using Dr As DataSet = ClAcesso.ObtemDataset(StrSql)
                Dim List As PVendedor
                For a = 0 To Dr.Tables(0).Rows.Count - 1
                    List = New PVendedor
                    List.CodFuncionario = CInt(Dr.Tables(0).Rows(a).Item("CodFuncionario"))
                    List.Nome = Dr.Tables(0).Rows(a).Item("NomeFunc").ToString
                    Lista.Add(List)
                Next
                If Not ClAcesso.TransacaoEstaAtiva Then ClAcesso.FechaConexao()
            End Using

        Catch ex As Exception
        Finally
        End Try
        Return Lista
    End Function

    Public Function Incluir(Lista As PVendedor) As Boolean Implements I_Vendedor.Incluir
        Dim Resp As Boolean = False
        Try
            Dim StrSql As String = "Insert into tblFuncionario (NomeFunc,Orcamento,Ativo"
            StrSql += ")values("
            StrSql += "'" & Lista.Nome & "',true,true)"
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Dim Afetados As Integer = ClAcesso.ExecutaSql(StrSql)
            If Afetados <> 0 Then Resp = True
        Catch ex As Exception
        Finally
        End Try
        Return Resp
    End Function
End Class