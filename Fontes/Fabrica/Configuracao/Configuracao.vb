Public Class Configuracao
    Implements I_Configuracao
    Private ClAcesso As New AcessoDados.AcessoAdoNet
    Public Property Erro As String = ""
    Private Sistema_Implementado As String = "SCAE"
    Sub New(_Sistema_Implementado As String)
        Sistema_Implementado = _Sistema_Implementado
    End Sub
    Private Function CriarLista(ByVal dr As DataSet) As List(Of ConfiguracaoIntegracao)
        Dim Resposta As New List(Of ConfiguracaoIntegracao)
        Dim _Configuracao As New ConfiguracaoIntegracao

        Try
            For x = 0 To dr.Tables(0).Rows.Count - 1
                With dr.Tables(0).Rows(x)
                    _Configuracao.ID = .Item("id")
                    _Configuracao.Endereço_Host = .Item("Endereço_Host").ToString
                    _Configuracao.Endereço_Redirecionamento_Página = .Item("Endereço_Redirecionamento_Página").ToString
                    _Configuracao.ID_Aplicação = .Item("ID_Aplicação").ToString
                    _Configuracao.Loja_ID = .Item("Loja_ID").ToString
                    _Configuracao.Senha_Aplicação = .Item("Senha_Aplicação").ToString
                    _Configuracao.Plataforma = .Item("Plataforma").ToString
                    _Configuracao.CodGerado = .Item("CodGerado").ToString
                    Resposta.Add(_Configuracao)
                End With
            Next

        Catch ex As Exception
            _Configuracao = Nothing
        End Try
        Return Resposta
    End Function
    Public Function Get_Configuracao(Plataforma As String) As List(Of ConfiguracaoIntegracao) Implements I_Configuracao.Get_Configuracao
        Dim _Configuracao As New List(Of ConfiguracaoIntegracao)
        Try
            Dim StrSql As String = "Select * from ConfiguracaoIntegracao "
            If Plataforma.Length > 0 Then
                StrSql += " Where Plataforma='" & Plataforma & "'"
            End If

            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Using Dr As DataSet = ClAcesso.ObtemDataset(StrSql)
                _Configuracao = CriarLista(Dr)
                If Not ClAcesso.TransacaoEstaAtiva Then ClAcesso.FechaConexao()
            End Using
        Catch ex As Exception
            _Configuracao = Nothing
        Finally
        End Try
        Return _Configuracao
    End Function

    Public Function Seta_Codigo_Acesso(Plataforma As String, Codigo_Gerado As String) As Boolean Implements I_Configuracao.Seta_Codigo_Acesso
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = "update ConfiguracaoIntegracao set CodGerado='" & Codigo_Gerado.Replace("'", "''") & "' where Plataforma='" & Plataforma & "'"
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Dim Afetado As Integer = ClAcesso.ExecutaSql(StrSql)
            Resposta = True
        Catch ex As Exception
            Resposta = False
        Finally
        End Try
        Return Resposta
    End Function

    Public Function Seta_Codigo_Loja(Plataforma As String, Codigo_Loja As String) As Boolean Implements I_Configuracao.Seta_Codigo_Loja
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = "update ConfiguracaoIntegracao set Loja_ID='" & Codigo_Loja.Replace("'", "''") & "' where Plataforma='" & Plataforma & "'"
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Dim Afetado As Integer = ClAcesso.ExecutaSql(StrSql)
            Resposta = True
        Catch ex As Exception
            Resposta = False
        Finally
        End Try
        Return Resposta
    End Function

    Public Function Seta_Parametro(_Configuracao As ConfiguracaoIntegracao) As Boolean Implements I_Configuracao.Seta_Parametro
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = ""
            If _Configuracao.CodGerado Is Nothing Then _Configuracao.CodGerado = ""
            If _Configuracao.ID > 0 Then
                StrSql = "Update  ConfiguracaoIntegracao set "
                StrSql += "Plataforma='" & _Configuracao.Plataforma.ToString & "',"
                StrSql += "Endereço_Redirecionamento_Página='" & _Configuracao.Endereço_Redirecionamento_Página.ToString & "',"
                StrSql += "ID_Aplicação=" & _Configuracao.ID_Aplicação & ","
                StrSql += "Senha_Aplicação='" & _Configuracao.Senha_Aplicação.ToString & "',"
                StrSql += "Endereço_Host='" & _Configuracao.Endereço_Host.ToString & "',"
                StrSql += "CodGerado='" & _Configuracao.CodGerado.ToString & "',"
                StrSql += "Loja_ID='" & _Configuracao.Loja_ID.ToString & "'"

                StrSql += " where id=" & _Configuracao.ID
            Else
                StrSql = "Insert into ConfiguracaoIntegracao (Plataforma,Endereço_Redirecionamento_Página,ID_Aplicação,Senha_Aplicação,Endereço_Host,Loja_ID,CodGerado) values("
                StrSql += "'" & _Configuracao.Plataforma.ToString & "',"
                StrSql += "'" & _Configuracao.Endereço_Redirecionamento_Página.ToString & "',"
                StrSql += "'" & _Configuracao.ID_Aplicação.ToString & "',"
                StrSql += "'" & _Configuracao.Senha_Aplicação.ToString & "',"
                StrSql += "'" & _Configuracao.Endereço_Host.ToString & "',"
                StrSql += "'" & _Configuracao.Loja_ID.ToString & "',"
                StrSql += "'" & _Configuracao.CodGerado.ToString & "')"
            End If
            Dim IDGerado As Integer = 0
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Dim afetados As Integer = ClAcesso.ExecutaSql(StrSql, IDGerado)
            If _Configuracao.ID = 0 Then _Configuracao.ID = IDGerado
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
