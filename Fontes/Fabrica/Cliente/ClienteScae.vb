Imports System.Security
Imports IntegracaoMarkPlace.Shopee

Public Class ClienteScae
    Implements I_Cliente

    Public Property Erro As String = ""
    Private Sistema_Implementado As String = "SCAE"
    Sub New(_Sistema_Implementado As String)
        Sistema_Implementado = _Sistema_Implementado
    End Sub

    Public Function Retorna_Id_Cliente(CPF As String) As Integer Implements I_Cliente.Retorna_Id_Cliente
        Dim Resposta As Integer = 0
        Try

            Dim StrSql As String = "Select CodCliente from tblCliente "
            StrSql += " Where ativo=true and replace(replace(replace(CPF,'.',''),'-',''),' ','') ='" & CPF.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "") & "'"

            util.IniciaBase()

            Using Dr As DataSet = util.ClAcesso.ObtemDataset(StrSql)
                If Dr.Tables(0).Rows.Count > 0 Then
                    Resposta = Dr.Tables(0).Rows(0).Item("CodCliente").ToString
                End If
            End Using

        Catch ex As Exception
        Finally
        End Try
        Return Resposta
    End Function
    Private Function CriaLista(ByVal Dr As DataSet) As List(Of Cliente)
        Dim ListaClientes As New List(Of Cliente)
        Try
            For x = 0 To Dr.Tables(0).Rows.Count - 1
                With Dr.Tables(0).Rows(x)
                    Dim clientes As New Cliente
                    If IsDate(.Item("DataCadastro").ToString) Then clientes.DataCadastro = Format(CDate(.Item("DataCadastro").ToString), "dd/MM/yyyy") Else clientes.DataCadastro = ""
                    clientes.CodCliente = CLng(.Item("CodCliente").ToString)
                    clientes.NomeCliente = .Item("NomeCliente").ToString
                    clientes.CPF = .Item("CPF").ToString
                    clientes.Bairro = .Item("Bairro").ToString
                    clientes.CEP = .Item("CEP").ToString
                    clientes.UF = .Item("UF").ToString
                    clientes.Numero = .Item("Numero").ToString
                    clientes.Complemento = .Item("Complemento").ToString
                    clientes.Rua = .Item("Rua").ToString
                    clientes.CPF = .Item("cpf").ToString
                    clientes.Cidade = .Item("Cidade").ToString
                    clientes.fone1 = IIf(Not IsDBNull(.Item("Fone1")), .Item("Fone1").ToString, Nothing)
                    clientes.Email = IIf(Not IsDBNull(.Item("email")), .Item("email").ToString, Nothing)
                    clientes.RG = IIf(Not IsDBNull(.Item("Rg")), .Item("Rg"), Nothing)
                    clientes.ATIVO = .Item("Ativo")
                    clientes.CodCidade = .Item("CodCidade").ToString
                    clientes.OBS = .Item("Obs").ToString
                    ListaClientes.Add(clientes)
                End With
            Next

        Catch ex As Exception
            Erro = ex.Message
        End Try
        Return ListaClientes
    End Function

    Public Function Incluir(Lista As Cliente) As Integer Implements I_Cliente.Incluir
        Try
            If Lista.CodCidade Is Nothing Then Lista.CodCidade = 0
            If Lista.OBS Is Nothing Then Lista.OBS=""
            Dim StrSql As String = "Insert into tblCliente (DataCadastro,NomeCliente,Ativo,"
            StrSql += "CPF,CEP,Rua,Numero,Complemento,Bairro,Cidade,UF,email,Fone1,obs,codCidade,rg"
            StrSql += ")values("
            StrSql += "'" & Format(Date.Today, "yyyy-MM-dd") & "',"
            StrSql += "'" & Lista.NomeCliente & "',true,"
            StrSql += "'" & util.FormataCPF(Lista.CPF.Replace("'", "''")) & "',"
            StrSql += "'" & Lista.CEP.Replace("'", "''") & "',"
            StrSql += "'" & Mid(Lista.Rua.Replace("'", "''"), 1, 60) & "',"
            StrSql += "'" & Lista.Numero.Replace("'", "''") & "',"
            StrSql += "'" & Lista.Complemento.Replace("'", "''") & "',"
            StrSql += "'" & Lista.Bairro.Replace("'", "''") & "',"
            StrSql += "'" & Lista.Cidade.Replace("'", "''") & "',"
            StrSql += "'" & Mid(Lista.UF.Replace("'", "''"), 1, 2) & "',"
            StrSql += "'" & Lista.Email.Replace("'", "''") & "',"
            StrSql += "'" & Lista.fone1.Replace("'", "''") & "',"
            StrSql += "'" & Lista.OBS.Replace("'", "''") & "',"
            StrSql += "'" & Lista.CodCidade.Replace("'", "''") & "',"
            StrSql += "'" & Lista.RG.Replace("'", "''") & "')"
            util.IniciaBase()
            Dim Afetados As Integer = util.ClAcesso.ExecutaSql(StrSql, True, Lista.CodCliente)
        Catch ex As Exception
        Finally
        End Try
        Return Lista.CodCliente
    End Function
    Public Function Lista(Optional ByVal Codigo As Integer = 0,
                              Optional ByVal Nome As String = "",
                              Optional ByVal Bairro As String = "", Optional ByVal Cidade As String = "",
                              Optional CPF As String = "") As List(Of Cliente) Implements I_Cliente.Lista
        Dim LcLista As New List(Of Cliente)
        Try
            '==> Cria as consulta
            Dim StrWhere As String = " Where ativo<>0"
            Dim StrSql As String = "Select CodCliente,DataCadastro,NomeCliente,Ativo,CPF,CEP,Rua,Numero,Complemento,Bairro,Cidade,UF,email,Fone1,obs,codCidade,rg FROM tblCliente"
            If Codigo > 0 Then
                If StrWhere.Length = 0 Then StrWhere = " Where " Else StrWhere += " and "
                StrWhere += "CodCliente=" & Codigo
            End If
            If Nome.Length > 0 Then
                If StrWhere.Length = 0 Then StrWhere = " Where " Else StrWhere += " and "
                StrWhere += "NomeCliente like '%" & Nome & "%'"
            End If

            If Bairro.Length > 0 Then
                If StrWhere.Length = 0 Then StrWhere = " Where " Else StrWhere += " and "
                StrWhere += "Bairro like '%" & Bairro & "%'"
            End If
            If Cidade.Length > 0 Then
                If StrWhere.Length = 0 Then StrWhere = " Where " Else StrWhere += " and "
                StrWhere += "Cidade like '%" & Cidade & "%'"
            End If
            If CPF.Length > 0 Then
                If StrWhere.Length = 0 Then StrWhere = " Where " Else StrWhere += " and "
                StrWhere += "replace(replace(replace(cpf,'.',''),'/',''),'-','')='" & CPF.Replace(".", "").Replace("/", "").Replace("-", "") & "'"
            End If

            StrSql += StrWhere & " order by NomeCliente"
            '==> Inicia a Base
            util.IniciaBase()
            Dim Dr As DataSet = util.ClAcesso.ObtemDataset(StrSql)
            LcLista = CriaLista(Dr)
            Dr.Dispose()

        Catch ex As Exception
            Erro = ex.Message

        End Try

        Return LcLista
    End Function
    Public Function Alterar(ByVal Cliente As Cliente) As Boolean Implements I_Cliente.Alterar
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = "Update tblCliente set "
            StrSql += "NomeCliente='" & Cliente.NomeCliente.Replace("'", "''") & "',"
            StrSql += "CPF='" & util.FormataCPF(Cliente.CPF) & "',"
            StrSql += "rua='" & Cliente.Rua.Replace("'", "''") & "',"
            StrSql += "Numero='" & Cliente.Numero.Replace("'", "''") & "',"
            StrSql += "Complemento='" & Cliente.Complemento.Replace("'", "''") & "',"
            StrSql += "Bairro='" & Cliente.Bairro.Replace("'", "''") & "',"
            StrSql += "Cidade='" & Cliente.Cidade.Replace("'", "''") & "',"
            StrSql += "uf='" & Cliente.UF.Replace("'", "''") & "',"
            StrSql += "CEP='" & Cliente.CEP.Replace("'", "''") & "',"
            StrSql += "Email='" & Cliente.Email.Replace("'", "''") & "',"
            StrSql += "rg='" & Cliente.RG.Replace("'", "''") & "',"
            StrSql += "fone1='" & Cliente.fone1.Replace("'", "''") & "',"
            StrSql += "CodCidade='" & Cliente.CodCidade.Replace("'", "''") & "',"
            StrSql += "OBS='" & Cliente.OBS.Replace("'", "''") & "'"
            StrSql += " where CodCliente=" & Cliente.CodCliente
            util.IniciaBase()
            Dim afetados As Integer = util.ClAcesso.ExecutaSql(StrSql)
            If afetados > 0 Then
                Resposta = True
            End If
        Catch ex As Exception
            Erro = ex.ToString
        End Try
        Return Resposta
    End Function
    Public Function Excluir(ByVal Código As Integer) As Boolean Implements I_Cliente.Excluir
        Dim Resposta As Boolean = False
        Try
            Dim StrSql As String = "Delete from tblCliente where CodCliente=" & Código
            util.IniciaBase()
            Dim Afetados As Integer = util.ClAcesso.ExecutaSql(StrSql)
            If Afetados > 0 Then
                Resposta = True
            End If
        Catch ex As Exception
            Erro = ex.Message
            Resposta = False
        End Try
        Return Resposta
    End Function
End Class