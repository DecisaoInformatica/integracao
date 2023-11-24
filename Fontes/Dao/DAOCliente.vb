Imports Microsoft.Web.WebView2

Public Class DAOCliente
    Public Property Erro As String = ""
    Function Retorna_Id_Cliente(CPF As String) As Integer
        Return FabricaCliente.CriaCliente.Retorna_Id_Cliente(CPF)
    End Function
    Function Lista(Optional ByVal Código As Integer = 0,
                              Optional ByVal Nome As String = "",
                              Optional ByVal Bairro As String = "", Optional ByVal Cidade As String = "",
                              Optional CPF As String = "") As List(Of Cliente)
        Return FabricaCliente.CriaCliente.Lista(Código, Nome, Bairro, Cidade, CPF)
    End Function
    Function Incluir(_Cliente As Cliente) As Integer
        Erro = Valida_Cliente(_Cliente)
        If erro.Length = 0 Then
            Return FabricaCliente.CriaCliente.Incluir(_Cliente)
        Else
            Return 0
        End If
    End Function
    Function Alterar(ByVal _Cliente As Cliente) As Boolean
        Erro = Valida_Cliente(_Cliente)
        If erro.Length = 0 Then
            Return FabricaCliente.CriaCliente.Alterar(_Cliente)
        Else
            Return False
        End If

    End Function
    Function Excluir(ByVal Código As Integer) As Boolean
        Return FabricaCliente.CriaCliente.Excluir(Código)
    End Function
    Private Function Valida_Cliente(_Cliente As Cliente) As String
        Dim Resposta As String = ""
        If _Cliente.NomeCliente.Length = 0 Then Resposta = "Nome do Cliente Inválido."
        If _Cliente.Rua.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Rua/Av inválida."
        End If

        If _Cliente.Numero.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Número inválido."
        End If
        If _Cliente.Bairro.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Bairro Inválido."
        End If
        If _Cliente.Cidade.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Cidade Inválida."
        End If
        If _Cliente.UF.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Estado Inválido."
        End If
        If _Cliente.CEP.Replace(".", "").Replace("-", "").Replace("_", "").Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "CEP Inválido."
        End If
        If _Cliente.CPF.Replace(".", "").Replace("-", "").Replace("_", "").Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "CPF Inválido."
        Else
            If Not util.Valida_CPF(_Cliente.CPF) Then
                If Resposta.Length > 0 Then Resposta += Chr(10)
                Resposta += "CPF Inválido."
            Else
                If CPF_Já_Cadastrado(_Cliente.CPF, _Cliente.CodCliente) Then
                    If Resposta.Length > 0 Then Resposta += Chr(10)
                    Resposta += "CPF já cadastrado."
                End If
            End If
        End If
        If _Cliente.RG.Length = 0 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "RG Inválido."
        End If
        If _Cliente.fone1.Replace(".", "").Replace("-", "").Replace("_", "").Length < 8 Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "Telefone Inválido."
        End If
        If _Cliente.Email.Length = 0 OrElse (Not _Cliente.Email.Contains("@")) Then
            If Resposta.Length > 0 Then Resposta += Chr(10)
            Resposta += "E-mail Inválido."
        End If
        Return Resposta
    End Function
    Private Function CPF_Já_Cadastrado(CPF As String, codCliente As Integer) As Boolean
        Dim Resposta As Boolean = False
        Dim Lista_Cliente As List(Of Cliente) = Me.Lista(0, "", "", "", CPF)
        If Lista_Cliente.Count > 0 Then
            If codCliente = 0 Then
                Resposta = True
            Else
                If Lista_Cliente(0).CodCliente <> codCliente Then
                    Resposta = True
                End If

            End If
        End If

        Return Resposta
    End Function
End Class