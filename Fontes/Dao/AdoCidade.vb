Imports System.Threading

Public Class AdoCidade
    Private Dr As DataSet
    Public Property Erro As String
    Public Function Lista(Optional ByVal Codigo As String = "",
                          Optional ByVal Nome As String = "",
                          Optional ByVal Estado As String = "",
                          Optional ByVal MostraBranco As Boolean = False) As List(Of Cidade)
        Dim LcLista As New List(Of Cidade)
        Try
            '==> Cria as consulta
            Dim StrWhere As String = ""
            Dim StrSql As String = "Select * from Cidade"
            '==> Efetua a verificacao dos parametros
            If Codigo.Length > 0 Then
                StrWhere = " COD='" & Codigo & "'"
            End If
            If Nome.Length > 0 Then
                If StrWhere.Length > 0 Then StrWhere += " and"
                StrWhere += " NOME like '" & Nome & "%'"
            End If
            If Estado.Length > 0 Then
                If StrWhere.Length > 0 Then StrWhere += " and"
                StrWhere += " ESTADO like '" & Estado & "%'"
            End If
            '==> Concatena o where
            If StrWhere.Length > 0 Then
                StrSql += " where" & StrWhere
            End If
            Dim StrClassificacao As String = " order by NOME"
            StrSql += StrClassificacao

            '==> Inicia a Base
            util.IniciaBase()
            Dr = util.ClAcesso.ObtemDataset(StrSql)
            LcLista = CriaLista(Dr)

        Catch ex As Exception
            Erro = ex.Message
        End Try

        Return LcLista
    End Function
    Private Function CriaLista(ByVal Dr As DataSet, Optional ByVal CalcularCodigo As Boolean = False) As List(Of Cidade)
        Dim LcLista As New List(Of Cidade)
        Try

            If CalcularCodigo Then
                For A = 0 To Dr.Tables(0).Rows.Count - 1
                    Dim _Cidade As New Cidade
                    _Cidade.COD = Dr.Tables(0).Rows(A).Item("COD")
                    LcLista.Add(_Cidade)
                Next
            Else
                For A = 0 To Dr.Tables(0).Rows.Count - 1
                    Dim _Cidade As New Cidade
                    _Cidade.COD = Dr.Tables(0).Rows(A).Item("COD")
                    _Cidade.Nome = Dr.Tables(0).Rows(A).Item("NOME")
                    If Not IsDBNull(Dr.Tables(0).Rows(A).Item("ESTADO")) Then
                        _Cidade.Estado = Dr.Tables(0).Rows(A).Item("ESTADO")
                    Else
                        _Cidade.Estado = Nothing
                    End If

                    If Not IsDBNull(Dr.Tables(0).Rows(A).Item("CodigoIBGEMunicipio")) Then
                        _Cidade.CodigoIBGEMunicipio = Dr.Tables(0).Rows(A).Item("CodigoIBGEMunicipio")
                    Else
                        _Cidade.CodigoIBGEMunicipio = Nothing
                    End If

                    If Not IsDBNull(Dr.Tables(0).Rows(A).Item("CodigoIBGEEstado")) Then
                        _Cidade.CodigoIBGEEstado = Dr.Tables(0).Rows(A).Item("CodigoIBGEEstado")
                    Else
                        _Cidade.CodigoIBGEEstado = Nothing
                    End If
                    LcLista.Add(_Cidade)
                Next
            End If
        Catch ex As Exception
            Erro = ex.Message
        End Try
        Return LcLista
    End Function

    Public Function CalculaCodigo() As String
        Dim LcCod As String = ""
        Dim List As New List(Of Cidade)
        Try
            Dim Lc As Long
            Dim StrSql As String = "Select * from Cidade order by COD desc"
            '==> Inicia a Base
            util.IniciaBase()
            Dr = util.ClAcesso.ObtemDataset(StrSql)
            List = CriaLista(Dr, True)
            Lc = CInt(List(0).COD)
            Lc += 1
            LcCod = Right("0000" & Lc, 4)
        Catch ex As Exception
            Erro = ex.Message
        End Try
        Return LcCod
    End Function

    Public Function Incluir(ByVal LcALID005 As Cidade) As Boolean
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = "Insert into Cidade(COD,Nome,Estado,CodigoIBGEMunicipio,CodigoIBGEEstado)values("
            StrSql += "'" & LcALID005.COD & "',"
            StrSql += "'" & LcALID005.Nome & "',"
            StrSql += "'" & LcALID005.Estado & "',"
            StrSql += "'" & LcALID005.CodigoIBGEMunicipio & "',"
            StrSql += "'" & LcALID005.CodigoIBGEEstado & "')"

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

    Public Function Alterar(ByVal _Cidade As Cidade) As Boolean
        Dim Resposta As Boolean = False
        If _Cidade.COD = 0 Then GoTo saida
        Try
            Dim StrSql As String = "Update Cidade set "
            StrSql += "COD=" & _Cidade.COD & ","
            StrSql += "Nome='" & _Cidade.Nome & "',"
            StrSql += "Estado='" & _Cidade.Estado & "',"
            StrSql += "CodigoIBGEMunicipio='" & _Cidade.CodigoIBGEMunicipio & "',"
            StrSql += "CodigoIBGEEstado='" & _Cidade.CodigoIBGEEstado & "'"
            StrSql += " Where COD=" & _Cidade.COD

            util.IniciaBase()
            Dim Afetado As Integer = util.ClAcesso.ExecutaSql(StrSql)
            If Afetado > 0 Then
                Resposta = True
            End If
        Catch ex As Exception
            Erro = ex.Message
        End Try
saida:
        Return Resposta
    End Function
    Public Function Excluir(ByVal Codigo As String) As Boolean
        Dim Resposta As Boolean = False
        If Codigo = 0 Then GoTo saida
        Try
            Dim StrSql As String = "Delete from Cidade"
            StrSql += " Where COD='" & Codigo & "'"

            util.IniciaBase()
            Dim Afetado As Integer = util.ClAcesso.ExecutaSql(StrSql)
            If Afetado > 0 Then
                Resposta = True
            End If
        Catch ex As Exception
            Erro = ex.Message
        End Try
saida:
        Return Resposta
    End Function
End Class