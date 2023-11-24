Public Interface I_Cliente
    Function Retorna_Id_Cliente(ByVal CPF As String) As Integer
    Function Incluir(ByVal Lista As Cliente) As Integer
    Function Lista(Optional ByVal Código As Integer = 0,
                              Optional ByVal Nome As String = "",
                              Optional ByVal Bairro As String = "", Optional ByVal Cidade As String = "",
                              Optional CPF As String = "") As List(Of Cliente)
    Function Alterar(ByVal Cliente As Cliente) As Boolean
    Function Excluir(ByVal Código As Integer) As Boolean
End Interface
