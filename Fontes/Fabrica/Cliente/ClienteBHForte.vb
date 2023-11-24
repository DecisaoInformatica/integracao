Public Class ClienteBHForte
    Implements I_Cliente

    Private ClAcesso As New AcessoDados.AcessoAdoNet
    Public Property Erro As String = ""
    Private Sistema_Implementado As String = "BHPECAS"
    Sub New(_Sistema_Implementado As String)
        Sistema_Implementado = _Sistema_Implementado
    End Sub
    Public Function Retorna_Id_Cliente(CPF As String) As Integer Implements I_Cliente.Retorna_Id_Cliente
        Throw New NotImplementedException()
    End Function

    Public Function Incluir(Lista As Cliente) As Integer Implements I_Cliente.Incluir
        Throw New NotImplementedException()
    End Function

    Public Function Lista(Optional Código As Integer = 0, Optional Nome As String = "", Optional Bairro As String = "", Optional Cidade As String = "", Optional CPF As String = "") As List(Of Cliente) Implements I_Cliente.Lista
        Throw New NotImplementedException()
    End Function

    Public Function Alterar(Cliente As Cliente) As Boolean Implements I_Cliente.Alterar
        Throw New NotImplementedException()
    End Function

    Public Function Excluir(Código As Integer) As Boolean Implements I_Cliente.Excluir
        Throw New NotImplementedException()
    End Function
End Class