Public Class FrmConfiguração
    Private DaoConfiDao_Config As New DAOConfiguracao
    Public Property PlataformaUsar As String
    Sub LimpaCampos()
        ID.Text = ""
        Plataforma.Text = ""
        Endereço_Redirecionamento_Página.Text = ""
        ID_Aplicação.Text = ""
        Senha_Aplicação.Text = ""
        Endereço_Host.Text = ""
        Loja_ID.Text = ""
        Codigo_Gerado.Text = ""
    End Sub
    Function Valida_Dados() As String
        Dim Erro As String = ""
        If Plataforma.Text.Length = 0 Then
            Erro = "Escolha a Plataforma de integração"
        End If
        If Endereço_Redirecionamento_Página.Text.Length = 0 Then
            If Erro.Length > 0 Then Erro += Chr(13)
            Erro += "Informe o endereço de redirecionamento das respostas da API"
        End If
        If ID_Aplicação.Text.Length = 0 Then
            If Erro.Length > 0 Then Erro += Chr(13)
            Erro += "Informe o ID da aplicação"
        End If
        If Senha_Aplicação.Text.Length = 0 Then
            If Erro.Length > 0 Then Erro += Chr(13)
            Erro += "Informe a senha da aplicação"
        End If
        If Endereço_Host.Text.Length = 0 Then
            If Erro.Length > 0 Then Erro += Chr(13)
            Erro += "Informe o endereço base da API"
        End If
        If Loja_ID.Text.Length = 0 Then
            If Erro.Length > 0 Then Erro += Chr(13)
            Erro += "Informe o ID da loja de integração"
        End If
        Return Erro
    End Function
    Private Sub Get_Dados()

        Dim _Configuração As List(Of ConfiguracaoIntegracao) = DaoConfiDao_Config.Get_Configuracao(PlataformaUsar)
        If _Configuração.Count > 0 Then
            ID.Text = _Configuração(0).ID
            Plataforma.Text = _Configuração(0).Plataforma
            Endereço_Redirecionamento_Página.Text = _Configuração(0).Endereço_Redirecionamento_Página
            ID_Aplicação.Text = _Configuração(0).ID_Aplicação
            Senha_Aplicação.Text = _Configuração(0).Senha_Aplicação
            Endereço_Host.Text = _Configuração(0).Endereço_Host
            Loja_ID.Text = _Configuração(0).Loja_ID
            Codigo_Gerado.Text = _Configuração(0).CodGerado
        Else
            LimpaCampos()
        End If

    End Sub
    Private Sub FrmConfiguração_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Get_Dados()
        Catch ex As Exception
            Dim unused = MsgBox(ex.Message, vbApplicationModal.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub CmdSalvar_Click(sender As Object, e As EventArgs) Handles CmdSalvar.Click
        Try
            Dim Erro_Validação As String = Valida_Dados()
            If Erro_Validação.Length > 0 Then
                MsgBox(Erro_Validação, vbOKOnly, "Aviso")
            Else
                If Not IsNumeric(ID.Text) Then ID.Text = 0
                Dim _Configuração As New ConfiguracaoIntegracao
                _Configuração.ID = ID.Text
                _Configuração.Plataforma = Plataforma.Text
                _Configuração.Endereço_Redirecionamento_Página = Endereço_Redirecionamento_Página.Text
                _Configuração.ID_Aplicação = ID_Aplicação.Text
                _Configuração.Senha_Aplicação = Senha_Aplicação.Text
                _Configuração.Endereço_Host = Endereço_Host.Text
                _Configuração.Loja_ID = Loja_ID.Text
                _Configuração.CodGerado = Codigo_Gerado.Text
                If DaoConfiDao_Config.Seta_Parâmetro(_Configuração) Then
                    MsgBox("Registro salvo com sucesso!", vbApplicationModal.OkOnly, "Confirmação")
                Else
                    MsgBox("Ocorreu um erro salvando o Registro, verifique e tente novamente", vbApplicationModal.OkOnly, "Confirmação")
                End If
            End If
        Catch ex As Exception
            Dim unused = MsgBox(ex.Message, vbApplicationModal.OkOnly, "Aviso")
        End Try
    End Sub
End Class