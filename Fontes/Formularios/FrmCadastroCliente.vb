Imports System.Threading
Imports System.Windows.Forms

Public Class FrmCadastroCliente

    Public Enum PosicaodoRegistro
        Primeiro
        Ultimo
        NaoAltera
        Anterior
        Seguinte
    End Enum

#Region "Declarações"
    Dim ListaClientes As New List(Of Cliente)
    Dim DaoCliente As New DAOCliente
    Dim ListaPesquisaCliente As New List(Of Cliente)
    Dim DaoPesqCliente As New DAOCliente
    Dim ListaCidade As New List(Of Cidade)
    Dim DaoCidade As New AdoCidade
    Private Posição As Integer = 0
    Private erro As String = ""
#End Region

#Region "Funçoes"

    Sub LimpaForm()
        LbCodigo.Text = ""
        Nome.Text = ""
        Rua.Text = ""
        Numero.Text = ""
        Complemento.Text = ""
        Bairro.Text = ""
        CboCidade.Text = ""
        CboCidade.SelectedValue = ""
        Estado.Text = ""
        CEP.Text = ""
        cpf.Text = ""
        identidade.Text = ""
        telefone1.Text = ""
        Email.Text = ""
        OptSim.Checked = True
        Obs.Text = ""
        DataCadastro.Text = Format(Date.Now, "dd/MM/yyyy")
    End Sub

    Sub CarregaListas()
        ListaCidade = DaoCidade.Lista("", "", "", False)
        ListaClientes = DaoCliente.Lista()
    End Sub

    Sub CombosCidades()
        CboCidade.ValueMember = "COD"
        CboCidade.DisplayMember = "Nome"
        CboCidade.DataSource = ListaCidade
        CboCidade.SelectedValue = 0
        CboCidade.Text = ""
    End Sub

    Sub CarregaCombos()
        CombosCidades()
    End Sub

    Sub Carrega(ByVal PosiçãoReg As PosicaodoRegistro)
        Try
            CarregaListas()

            If PosiçãoReg = PosicaodoRegistro.Primeiro Then Posição = 0
            If PosiçãoReg = PosicaodoRegistro.Ultimo Then Posição = ListaClientes.Count - 1
            If PosiçãoReg = PosicaodoRegistro.Anterior Then
                If Posição > 0 Then
                    Posição -= 1
                Else
                    If ListaClientes.Count > 0 Then
                        Posição += 1
                    Else
                        Posição = 0
                    End If
                End If
            End If
            If PosiçãoReg = PosicaodoRegistro.Seguinte Then
                If Posição < ListaClientes.Count - 1 Then
                    Posição += 1
                Else
                    If ListaClientes.Count > 0 Then
                        If Posição > 0 Then
                            Posição -= 1
                        Else
                            Posição = 0
                        End If
                    Else
                        Posição = 0
                    End If
                End If
            End If
            CarregaDados()

        Catch ex As Exception
            erro = ex.Message
            MsgBox("Ocorreu o seguinte erro buscando os dados:" & ex.Message, 64, "Aviso")
        End Try
    End Sub

    Sub CarregaDados()
        If ListaClientes.Count > 0 Then
            LbCodigo.Text = ListaClientes(Posição).CodCliente
            cpf.Text = ListaClientes(Posição).CPF
            If ListaClientes(Posição).ATIVO Then
                OptSim.Checked = True
            Else
                OptNao.Checked = True
            End If
            Nome.Text = ListaClientes(Posição).NomeCliente
            Rua.Text = ListaClientes(Posição).Rua
            Numero.Text = ListaClientes(Posição).Numero
            Complemento.Text = ListaClientes(Posição).Complemento
            Bairro.Text = ListaClientes(Posição).Bairro
            CboCidade.Text = ListaClientes(Posição).Cidade
            CboCidade.SelectedValue = ListaClientes(Posição).CodCidade
            Estado.Text = ListaClientes(Posição).UF
            CEP.Text = ListaClientes(Posição).CEP
            identidade.Text = ListaClientes(Posição).RG
            telefone1.Text = ListaClientes(Posição).fone1
            DataCadastro.Text = ListaClientes(Posição).DataCadastro
            Email.Text = ListaClientes(Posição).Email
        Else
            LimpaForm()
        End If
    End Sub
#End Region

    Private Sub CmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdIncluir.Click
        LimpaForm()
    End Sub

    Private Sub CmdProximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdProximo.Click
        If Posição = (ListaClientes.Count - 1) Then
            MsgBox("Este é o último Registro.", 64, "Aviso")
        Else
            Posição += 1
        End If
        CarregaDados()
    End Sub

    Private Sub CmdAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAnterior.Click
        If Posição = PosicaodoRegistro.Primeiro Then
            MsgBox("Este é o primeiro Registro.", 64, "Aviso")
        Else
            Posição -= 1
        End If
        CarregaDados()
    End Sub

    Private Sub CmdPrimeiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrimeiro.Click
        If Posição = PosicaodoRegistro.Primeiro Then
            MsgBox("Este é o Primeiro Registro.", 64, "Aviso")
        Else
            Posição = PosicaodoRegistro.Primeiro
        End If
        CarregaDados()
    End Sub

    Private Sub CmdUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdUltimo.Click
        If Posição = ListaClientes.Count - 1 Then
            MsgBox("Este é o último Registro.", 64, "Aviso")
        Else
            Posição = ListaClientes.Count - 1
        End If
        CarregaDados()
    End Sub

    Private Sub CmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalvar.Click
        Dim Cliente As New Cliente
        Dim Resposta As Boolean
        If OptSim.Checked Then
            Cliente.ATIVO = True
        Else
            Cliente.ATIVO = False
        End If
        Cliente.CodCliente = IIf(Not IsNumeric(LbCodigo.Text), 0, LbCodigo.Text)
        Cliente.NomeCliente = Nome.Text.Trim
        Cliente.Rua = Rua.Text.Trim
        Cliente.Numero = Numero.Text.Trim
        Cliente.Complemento = Complemento.Text.Trim
        Cliente.Bairro = Bairro.Text.Trim
        Cliente.Cidade = CboCidade.Text.Trim
        Cliente.UF = Estado.Text.Trim
        Cliente.CEP = CEP.Text.Trim
        Cliente.CPF = cpf.Text.Trim
        Cliente.RG = identidade.Text.Trim
        Cliente.fone1 = telefone1.Text.Trim
        Cliente.Email = Email.Text
        Cliente.OBS = Obs.Text
        Cliente.CodCidade = CboCidade.SelectedValue
        If Cliente.CodCliente = 0 Then
            Resposta = DaoCliente.Incluir(Cliente)
            ListaClientes = DaoCliente.Lista(Cliente.CodCliente, "")
            If ListaClientes.Count > 0 Then
                Cliente = ListaClientes(0)
                Carrega(PosicaodoRegistro.NaoAltera)
            End If


        Else
            Resposta = DaoCliente.Alterar(Cliente)
            Carrega(PosicaodoRegistro.NaoAltera)
        End If
        If DaoCliente.Erro.Length > 0 Then
            MsgBox(DaoCliente.Erro, MsgBoxStyle.Critical, "Aviso")
        Else
            MsgBox("Registro salvo com sucesso", 64, "Aviso")
        End If


    End Sub

    Private Sub CmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExcluir.Click
        If IsNumeric(LbCodigo.Text) Then
            If MsgBox("Deseja excluir o cliente?", vbYesNo, "Atenção") = vbYes Then
                DaoCliente.Excluir(LbCodigo.Text)
                Carrega(PosicaodoRegistro.Seguinte)
            End If
        End If
    End Sub

    Private Sub CmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdListar.Click
        TabControl1.SelectTab(1)
        PesqNome.Focus()
    End Sub

    Private Sub PesqNome_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PesqNome.TextChanged
        GerarPesquisa()
    End Sub

    Private Sub PesqRua_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PesqRua.TextChanged
        GerarPesquisa()
    End Sub

    Private Sub PesqBairro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PesqBairro.TextChanged
        GerarPesquisa()
    End Sub

    Private Sub PesqFantasia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PesqFantasia.TextChanged
        GerarPesquisa()
    End Sub

    Private Sub PesqCidade_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PesqCidade.TextChanged
        GerarPesquisa()
    End Sub
    Sub GerarPesquisa()
        ListaPesquisaCliente = DaoCliente.Lista(0, PesqNome.Text, PesqBairro.Text)
        GridPesqClientes.AutoGenerateColumns = False
        GridPesqClientes.DataSource = ListaPesquisaCliente
    End Sub
    Private Sub GridPesqClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPesqClientes.CellDoubleClick
        If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then
            Dim LcValor As String = 0
            LcValor = GridPesqClientes.CurrentRow.Cells(0).Value
            For A = 0 To ListaClientes.Count - 1
                If ListaClientes(A).CodCliente = LcValor Then
                    Posição = A
                    CarregaDados()
                    TabControl1.SelectTab(0)
                    Nome.Focus()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub PCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PCodigo.LostFocus
        GerarPesquisa()
    End Sub

    Private Sub FrmCadastroCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FrmCadastroCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CarregaListas()
        CarregaCombos()
        Carrega(PosicaodoRegistro.Primeiro)
        If Not IsNumeric(LbCodigo.Text) Then DataCadastro.Text = Format(Date.Now, "dd/MM/yyyy")
    End Sub

    Private Sub DataCadastro_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles DataCadastro.MaskInputRejected

    End Sub

    Private Sub DataCadastro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataCadastro.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(e.KeyChar)
    End Sub

    Private Sub CEP_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles CEP.MaskInputRejected

    End Sub

    Private Sub CEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CEP.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(e.KeyChar)
    End Sub

    Private Sub cpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles cpf.MaskInputRejected

    End Sub

    Private Sub cpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cpf.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(e.KeyChar)
    End Sub

    Private Sub telefone1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles telefone1.MaskInputRejected

    End Sub

    Private Sub telefone1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telefone1.KeyPress
        'e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(e.KeyChar)
    End Sub
End Class