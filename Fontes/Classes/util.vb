
Public Class util
    Public Const GlNomeProjeto = "SCAE"
    Public Shared ClAcesso As AcessoDados.AcessoAdoNet
    Public Shared Sub IniciaBase()
        Try

            util.ClAcesso = ClAcesso.Inicia
            util.ClAcesso.NomeProjeto = GlNomeProjeto
            util.ClAcesso.LerConfiguracao()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Overloads Shared Function Bloqueia_Digitação_em_Campos_Numéricos(Caractere As Char) As Boolean
        Dim Resposta As Boolean = False
        If Not Char.IsDigit(Caractere) AndAlso Not Char.IsControl(Caractere) Then Resposta = True
        Return Resposta
    End Function
    Public Overloads Shared Function Bloqueia_Digitação_em_Campos_Numéricos(Valor As String, Caractere As Char) As Boolean
        Dim Resposta As Boolean = False
        If Not (Char.IsDigit(Caractere) OrElse Caractere = ","c) Then
            Resposta = True
        End If

        ' Se a vírgula já existir, não permita outra vírgula
        If Caractere = ","c Then
            If Valor.Contains(",") Then
                Resposta = True
            End If
        End If
        Return Resposta
    End Function
    Public Shared Function Valida_CPF(Valor As String) As Boolean
        Dim Resposta As Boolean = False
        Dim dig1 As Integer
        Dim dig2 As Integer
        Dim Mult1 As Integer
        Dim Mult2 As Integer
        Dim X As Integer
        Dim A As Integer
        Dim LcCpf As String
        Mult1 = 10
        Mult2 = 11
        For A = 1 To Len(Valor)
            If IsNumeric(Mid(Valor, A, 1)) Then
                LcCpf = LcCpf & Mid(Valor, A, 1)
            End If
        Next
        Valor = LcCpf
        For X = 1 To 9
            dig1 = dig1 + (Val(Mid$(Valor, X, 1)) * Mult1)
            Mult1 = Mult1 - 1
        Next

        For X = 1 To 10
            dig2 = dig2 + (Val(Mid$(Valor, X, 1)) * Mult2)
            Mult2 = Mult2 - 1
        Next

        dig1 = (dig1 * 10) Mod 11
        dig2 = (dig2 * 10) Mod 11
        If dig1 = 10 Then dig1 = 0
        If dig2 = 10 Then dig2 = 0
        Resposta = False
        If Val(Mid$(Valor, 10, 1)) = dig1 And Val(Mid$(Valor, 11, 1)) = dig2 Then Resposta = True
        Return Resposta
    End Function
    Public Shared Function FormataCNPJ(Cnpj As String) As String
        Cnpj = Cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace("\", "").Replace(" ", "")
        If Cnpj.Length > 0 Then
            Cnpj = Cnpj.Substring(0, 2) & "." & Cnpj.Substring(2, 3) & "." & Cnpj.Substring(5, 3) & "/" & Cnpj.Substring(8, 4) & "-" & Cnpj.Substring(12, 2)

        End If
        Return Cnpj
    End Function
    Public Shared Function FormataCPF(CPF As String) As String
        CPF = CPF.Replace(".", "").Replace("-", "").Replace("/", "").Replace("\", "").Replace(" ", "")
        If CPF.Length > 0 Then
            CPF = CPF.Substring(0, 3) & "." & CPF.Substring(3, 3) & "." & CPF.Substring(6, 3) & "-" & CPF.Substring(9, 2)
        End If
        Return CPF
    End Function
End Class
