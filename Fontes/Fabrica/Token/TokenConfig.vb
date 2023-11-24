Public Class TokenConfig
    Implements I_TokenConfig

    Private ClAcesso As New AcessoDados.AcessoAdoNet
    Public Property Erro As String = ""
    Private Sistema_Implementado As String = "SCAE"
    Sub New(_Sistema_Implementado As String)
        Sistema_Implementado = _Sistema_Implementado
    End Sub
    Private Function CriarLista(ByVal dr As DataSet) As List(Of Token)
        Dim Resposta As New List(Of Token)
        Dim _Token As New Token

        Try
            For x = 0 To dr.Tables(0).Rows.Count - 1
                With dr.Tables(0).Rows(x)
                    _Token.ID = .Item("id")
                    _Token.Acess_Token = .Item("Acess_Token").ToString
                    _Token.Refresh_Token = .Item("Refresh_Token").ToString
                    _Token.Expiracao_Refresh_Token = .Item("Expiracao_Refresh_Token").ToString
                    _Token.Plataforma = .Item("Plataforma").ToString

                    Resposta.Add(_Token)
                End With
            Next

        Catch ex As Exception
            _Token = Nothing
        End Try
        Return Resposta
    End Function
    Private Function Get_Token(Plataforma As String) As List(Of Token) Implements I_TokenConfig.Get_Token
        Dim _Token As New List(Of Token)
        Try
            Dim StrSql As String = "Select * from Token "
            If Plataforma.Length > 0 Then
                StrSql += " Where Plataforma='" & Plataforma & "'"
            End If
            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Using Dr As DataSet = ClAcesso.ObtemDataset(StrSql)
                _Token = CriarLista(Dr)
                If Not ClAcesso.TransacaoEstaAtiva Then ClAcesso.FechaConexao()
            End Using
        Catch ex As Exception
            _Token = Nothing
        Finally
        End Try
        Return _Token
    End Function

    Private Function Seta_Acess_Token(Plataforma As String, Acess_Token As String) As Boolean Implements I_TokenConfig.Seta_Acess_Token
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = "update Token set Acess_Token='" & Acess_Token.Replace("'", "''") & "' where Plataforma='" & Plataforma & "'"
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

    Private Function Seta_Refresh_Token(Plataforma As String, Refresh_Token As String) As Boolean Implements I_TokenConfig.Seta_Refresh_Token
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = "update Token set Refresh_Token='" & Refresh_Token.Replace("'", "''") & "' where Plataforma='" & Plataforma & "'"
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

    Private Function Seta_Data_Expiração_Refresh_Token(Plataforma As String, Data_Expiração As String) As Boolean Implements I_TokenConfig.Seta_Data_Expiração_Refresh_Token
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = "update Token set Expiracao_Refresh_Token='" & Format(CDate(Data_Expiração), "yyyy-MM-dd") & "' where Plataforma='" & Plataforma & "'"
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

    Private Function Config_Seta_Token(_Token As Token) As Boolean Implements I_TokenConfig.Seta_Token
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = ""
            If _Token.ID > 0 Then
                StrSql = "Update Token set "
                StrSql += "Plataforma='" & _Token.Plataforma.ToString & "',"
                StrSql += "Refresh_Token='" & _Token.Refresh_Token.ToString & "',"
                StrSql += "Acess_Token=" & _Token.Acess_Token & ","
                StrSql += "Expiracao_Refresh_Token='" & Format(CDate(_Token.Expiracao_Refresh_Token.ToString), "yyyy-MM-dd") & "'"
                StrSql += " where id=" & _Token.ID
            Else
                StrSql = "Insert into Token (Plataforma,Refresh_Token,Acess_Token,Expiracao_Refresh_Token) values("
                StrSql += "'" & _Token.Plataforma.ToString & "',"
                StrSql += "'" & _Token.Refresh_Token.ToString & "',"
                StrSql += "'" & _Token.Acess_Token.ToString & "',"
                StrSql += "'" & Format(CDate(_Token.Expiracao_Refresh_Token.ToString), "yyyy-MM-dd") & "')"

            End If
            Dim IDGerado As Integer = 0

            ClAcesso = AcessoDados.AcessoAdoNet.Inicia
            ClAcesso.NomeProjeto = Sistema_Implementado
            Dim afetados As Integer = ClAcesso.ExecutaSql(StrSql, IDGerado)
            If _Token.ID = 0 Then _Token.ID = IDGerado
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
