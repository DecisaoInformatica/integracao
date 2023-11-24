Imports System.Threading
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmProdutoNfe
    Public Enum PosicaodoRegistro
        Primeiro
        Ultimo
        NaoAltera
        Anterior
        Seguinte
    End Enum

#Region "Declarações"
    Dim Lista As New List(Of Produto)
    Dim Dao As New DAOProduto
    Dim ListaPesquisa As New List(Of Produto)
    Private Posição As Integer = 0
    Private GlUsuário As String = Environment.MachineName
    Private Erro As String = ""
#End Region

#Region "Funçoes"
    Sub BuscaNCm()
        If ClassificacaoFiscal.Text.Length > 0 Then
            Dim Dao As New DAOProduto
            Dim Descricao As String = ""
            Dim LcCEST As String = ""
            Dao.RecuperaInformaçãoNCM(ClassificacaoFiscal.Text, Descricao, LcCEST)
            DescricaoNCM.Text = Descricao
            CEST.Text = LcCEST
            If Descricao = "NCM não encontrado no cadastro." Then
                DescricaoNCM.ForeColor = Color.Red
            Else
                DescricaoNCM.ForeColor = Color.Black
            End If
        Else

        End If
    End Sub
    Sub LimpaForm()
        LbCodigo.Text = ""
        CodigoBarra.Text = ""
        ClassificacaoFiscal.Text = ""
        Produto.Text = ""
        OptSim.Checked = True
        Unidade.Text = ""
        CustoAtual.Text = 0
        PrecoVenda.Text = 0
        Estoque.Text = 0
        EstoqueMinimo.Text = 0
        EstoqueMaximo.Text = 0
        Observacao.Text = ""
    End Sub

    Sub CarregaListas()
        Lista = Dao.Lista(0, "", I_Produto.Classificação.CodMercadoria, False, True)
        ListaPesquisa = Lista
    End Sub
    Sub Carrega(ByVal PosiçãoReg As PosicaodoRegistro)
        Try
            CarregaListas()

            If PosiçãoReg = PosicaodoRegistro.Primeiro Then Posição = 0
            If PosiçãoReg = PosicaodoRegistro.Ultimo Then Posição = Lista.Count - 1
            If PosiçãoReg = PosicaodoRegistro.Anterior Then
                If Posição > 0 Then
                    Posição -= 1
                Else
                    If Lista.Count > 0 Then
                        Posição += 1
                    Else
                        Posição = 0
                    End If
                End If
            End If
            If PosiçãoReg = PosicaodoRegistro.Seguinte Then
                If Posição < Lista.Count - 1 Then
                    Posição += 1
                Else
                    If Lista.Count > 0 Then
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
            Erro = ex.Message
            MsgBox("Ocorreu o seguinte erro buscando os dados:" & ex.Message, 64, "Aviso")
        End Try
    End Sub

    Sub CarregaDados()
        If Not ListaPesquisa Is Nothing Then
            Lista = ListaPesquisa
        End If
        If Lista.Count > 0 Then

            LbCodigo.Text = Lista(Posição).CodMercadoria

            If Lista(Posição).Ativo Then
                OptSim.Checked = True
            Else
                OptNao.Checked = True
            End If

            Produto.Text = Lista(Posição).Descricao
            CodigoBarra.Text = Lista(Posição).CodBarra
            ClassificacaoFiscal.Text = Lista(Posição).NCM

            BuscaNCm()
            CEST.Text = Lista(Posição).CEST
            Unidade.Text = Lista(Posição).Unidade
            CustoAtual.Text = Lista(Posição).PrecoCusto
            PrecoVenda.Text = Lista(Posição).PrecoVenda
            Estoque.Text = Lista(Posição).Estoque
            EstoqueMinimo.Text = Lista(Posição).Minimo
            EstoqueMaximo.Text = Lista(Posição).Maximo
            Observacao.Text = Lista(Posição).obs
        Else
            LimpaForm()
        End If
    End Sub

    Private Sub Pesquisa()
        Dim LcCod As Long = 0
        If Not IsNumeric(PCodigo.Text) Then
            LcCod = 0
        Else
            LcCod = PCodigo.Text
        End If

        ListaPesquisa = Dao.Lista(LcCod, PesqNome.Text, IntegracaoMarkPlace.I_Produto.Classificação.Nome, False)
        GridPesqClientes.AutoGenerateColumns = False
        GridPesqClientes.DataSource = ListaPesquisa
        GridPesqClientes.Refresh()
    End Sub
#End Region

    Private Sub CmdIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdIncluir.Click
        LimpaForm()
    End Sub

    Private Sub CmdProximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdProximo.Click
        If Posição = (Lista.Count - 1) Then
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
        If Posição = Lista.Count - 1 Then
            MsgBox("Este é o último Registro.", 64, "Aviso")
        Else
            Posição = Lista.Count - 1
        End If
        CarregaDados()
    End Sub

    Private Sub CmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalvar.Click
        Dim LcLista As New Produto
        Dim Resposta As Boolean

        If OptSim.Checked = False And OptNao.Checked = False Then
            OptSim.Checked = True
        End If

        If OptSim.Checked Then
            LcLista.Ativo = True
        Else
            LcLista.Ativo = False
        End If
        LcLista.CodMercadoria = IIf(Not IsNumeric(LbCodigo.Text), 0, LbCodigo.Text)
        LcLista.Descricao = Produto.Text.Trim

        LcLista.CodBarra = CodigoBarra.Text.Trim
        LcLista.NCM = ClassificacaoFiscal.Text.Trim
        LcLista.Unidade = Unidade.Text.Trim
        LcLista.PrecoCusto = CustoAtual.Text.Trim
        LcLista.PrecoVenda = PrecoVenda.Text
        LcLista.Estoque = Estoque.Text
        LcLista.Minimo = EstoqueMinimo.Text
        LcLista.Maximo = EstoqueMaximo.Text
        LcLista.obs = Observacao.Text
        LcLista.NCM = ClassificacaoFiscal.Text
        LcLista.CEST = CEST.Text
        If LcLista.CodMercadoria = 0 Then
            Resposta = Dao.Incluir(LcLista)
            Lista = Dao.Lista(0, Produto.Text, IntegracaoMarkPlace.I_Produto.Classificação.Nome, True)
            If Lista.Count > 0 Then
                LcLista = Lista(0)
            End If
            Carrega(PosicaodoRegistro.Ultimo)
        Else
            Resposta = Dao.Alterar(LcLista)
            Carrega(PosicaodoRegistro.NaoAltera)
        End If

        If Resposta Then
            LançaFicha()
            CarregaListas()
            MsgBox("Registro salvo com sucesso", 64, "Aviso")
        Else
            MsgBox("Erro ao salvar registro", MsgBoxStyle.Critical, "Aviso")
        End If

    End Sub
    Sub LançaFicha()
        Dim LcQuant As Decimal = 0
        Dim LcCompra As Decimal = 0
        Dim LcVenda As Decimal = 0

        If IsNumeric(Estoque.Text) Then LcQuant = CDec(Estoque.Text)
        If IsNumeric(CustoAtual.Text) Then LcCompra = CDec(CustoAtual.Text)
        If IsNumeric(PrecoVenda.Text) Then LcVenda = CDec(PrecoVenda.Text)

        Dim StrSql As String = "insert into tblFichaEstoque(CodMercadoria,Data,Tipo,Quantidade,Saldo,Cliente,PrecoCompra,PrecoCusto,PrecoVenda)values("

        StrSql += LbCodigo.Text & ",#" & Format(CDate(Date.Today), "MM/dd/yy") & "#,'Mov Manual Est'," & LcQuant.ToString.Replace(",", ".") & "," & Estoque.Text.ToString.Replace(",", ".")
        StrSql += ",'" & GlUsuário.Replace("'", "''") & "',"
        StrSql += LcCompra.ToString.Replace(",", ".") & ","
        StrSql += LcCompra.ToString.Replace(",", ".") & ","
        StrSql += LcVenda.ToString.Replace(",", ".") & ")"
        util.IniciaBase()
        Dim afetados As Int16 = util.ClAcesso.ExecutaSql(StrSql)
    End Sub
    Private Sub CmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExcluir.Click
        If IsNumeric(LbCodigo.Text) Then
            If MsgBox("Deseja excluir o produto?", vbYesNo, "Atenção") = vbYes Then
                Dao.Excluir(LbCodigo.Text)
                Carrega(PosicaodoRegistro.Seguinte)
            End If
        End If
    End Sub

    Private Sub CmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdListar.Click
        TabControl1.SelectTab(1)
        PesqNome.Focus()
    End Sub

    Private Sub GridPesqClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPesqClientes.CellDoubleClick
        If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell Then 'AndAlso TypeOf sender.CurrentCell Is DataGridViewTextBoxCell
            Dim LcValor As String = 0
            LcValor = GridPesqClientes.CurrentRow.Cells(0).Value
            For A = 0 To ListaPesquisa.Count - 1
                If ListaPesquisa(A).CodMercadoria = LcValor Then
                    Posição = A
                    CarregaDados()
                    TabControl1.SelectTab(0)
                    Produto.Focus()
                End If
            Next
        End If
    End Sub

    Private Sub FrmProdutoNfe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FrmProdutoNfe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CarregaListas()
        Carrega(PosicaodoRegistro.Primeiro)
    End Sub

    Private Sub PCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PCodigo.LostFocus
        Pesquisa()
    End Sub

    Private Sub PesqNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesqNome.TextChanged
        Pesquisa()
    End Sub
    Private Sub ClassificacaoFiscal_LostFocus(sender As Object, e As EventArgs) Handles ClassificacaoFiscal.LostFocus
        BuscaNCm()
    End Sub


    Private Sub ClassificacaoFiscal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ClassificacaoFiscal.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(e.KeyChar)
    End Sub
    Private Sub CodigoBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CodigoBarra.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(e.KeyChar)
    End Sub

    Private Sub CEST_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CEST.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(e.KeyChar)
    End Sub

    Private Sub CustoAtual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustoAtual.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(CustoAtual.Text, e.KeyChar)
    End Sub
    Private Sub PrecoVenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecoVenda.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(PrecoVenda.Text, e.KeyChar)
    End Sub

    Private Sub Estoque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Estoque.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(Estoque.Text, e.KeyChar)
    End Sub
    Private Sub EstoqueMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstoqueMinimo.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(EstoqueMinimo.Text, e.KeyChar)
    End Sub

    Private Sub EstoqueMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstoqueMaximo.KeyPress
        e.Handled = util.Bloqueia_Digitação_em_Campos_Numéricos(EstoqueMaximo.Text, e.KeyChar)
    End Sub

    Private Sub CodigoBarra_TextChanged(sender As Object, e As EventArgs) Handles CodigoBarra.TextChanged

    End Sub
End Class