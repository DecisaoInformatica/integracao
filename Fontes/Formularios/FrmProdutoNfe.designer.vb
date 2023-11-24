<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProdutoNfe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProdutoNfe))
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.PCodigo = New System.Windows.Forms.TextBox()
        Me.PesqNome = New System.Windows.Forms.TextBox()
        Me.GridPesqClientes = New System.Windows.Forms.DataGridView()
        Me.CodCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DescricaoNCM = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CEST = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Observacao = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.EstoqueMaximo = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.EstoqueMinimo = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Estoque = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PrecoVenda = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CustoAtual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Unidade = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClassificacaoFiscal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CodigoBarra = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.OptNao = New System.Windows.Forms.RadioButton()
        Me.OptSim = New System.Windows.Forms.RadioButton()
        Me.CmdExcluir = New System.Windows.Forms.Button()
        Me.CmdUltimo = New System.Windows.Forms.Button()
        Me.CmdProximo = New System.Windows.Forms.Button()
        Me.CmdAnterior = New System.Windows.Forms.Button()
        Me.CmdPrimeiro = New System.Windows.Forms.Button()
        Me.CmdListar = New System.Windows.Forms.Button()
        Me.CmdSalvar = New System.Windows.Forms.Button()
        Me.CmdIncluir = New System.Windows.Forms.Button()
        Me.Produto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbCodigo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridPesqClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Label41)
        Me.TabPage3.Controls.Add(Me.PCodigo)
        Me.TabPage3.Controls.Add(Me.PesqNome)
        Me.TabPage3.Controls.Add(Me.GridPesqClientes)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(859, 465)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Lista"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(8, 5)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(51, 16)
        Me.Label41.TabIndex = 38
        Me.Label41.Text = "Código"
        '
        'PCodigo
        '
        Me.PCodigo.Location = New System.Drawing.Point(12, 23)
        Me.PCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.PCodigo.MaxLength = 50
        Me.PCodigo.Name = "PCodigo"
        Me.PCodigo.Size = New System.Drawing.Size(65, 22)
        Me.PCodigo.TabIndex = 0
        '
        'PesqNome
        '
        Me.PesqNome.Location = New System.Drawing.Point(87, 23)
        Me.PesqNome.Margin = New System.Windows.Forms.Padding(4)
        Me.PesqNome.MaxLength = 50
        Me.PesqNome.Name = "PesqNome"
        Me.PesqNome.Size = New System.Drawing.Size(760, 22)
        Me.PesqNome.TabIndex = 1
        '
        'GridPesqClientes
        '
        Me.GridPesqClientes.AllowUserToAddRows = False
        Me.GridPesqClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPesqClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodCliente, Me.NomeCliente})
        Me.GridPesqClientes.Location = New System.Drawing.Point(8, 55)
        Me.GridPesqClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.GridPesqClientes.Name = "GridPesqClientes"
        Me.GridPesqClientes.RowHeadersWidth = 12
        Me.GridPesqClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridPesqClientes.Size = New System.Drawing.Size(840, 562)
        Me.GridPesqClientes.TabIndex = 6
        Me.GridPesqClientes.TabStop = False
        '
        'CodCliente
        '
        Me.CodCliente.DataPropertyName = "CodMercadoria"
        Me.CodCliente.HeaderText = "Código"
        Me.CodCliente.MaxInputLength = 10
        Me.CodCliente.MinimumWidth = 6
        Me.CodCliente.Name = "CodCliente"
        Me.CodCliente.ReadOnly = True
        Me.CodCliente.Width = 45
        '
        'NomeCliente
        '
        Me.NomeCliente.DataPropertyName = "Descricao"
        Me.NomeCliente.HeaderText = "Nome"
        Me.NomeCliente.MaxInputLength = 300
        Me.NomeCliente.MinimumWidth = 6
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.ReadOnly = True
        Me.NomeCliente.Width = 300
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(83, 5)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(44, 16)
        Me.Label36.TabIndex = 28
        Me.Label36.Text = "Nome"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.DescricaoNCM)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.CEST)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Observacao)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.EstoqueMaximo)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.EstoqueMinimo)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Estoque)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.PrecoVenda)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.CustoAtual)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Unidade)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ClassificacaoFiscal)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.CodigoBarra)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Controls.Add(Me.CmdExcluir)
        Me.TabPage1.Controls.Add(Me.CmdUltimo)
        Me.TabPage1.Controls.Add(Me.CmdProximo)
        Me.TabPage1.Controls.Add(Me.CmdAnterior)
        Me.TabPage1.Controls.Add(Me.CmdPrimeiro)
        Me.TabPage1.Controls.Add(Me.CmdListar)
        Me.TabPage1.Controls.Add(Me.CmdSalvar)
        Me.TabPage1.Controls.Add(Me.CmdIncluir)
        Me.TabPage1.Controls.Add(Me.Produto)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.LbCodigo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(859, 465)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados"
        '
        'DescricaoNCM
        '
        Me.DescricaoNCM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescricaoNCM.Location = New System.Drawing.Point(251, 145)
        Me.DescricaoNCM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DescricaoNCM.Name = "DescricaoNCM"
        Me.DescricaoNCM.Size = New System.Drawing.Size(558, 24)
        Me.DescricaoNCM.TabIndex = 89
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(13, 186)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 16)
        Me.Label26.TabIndex = 88
        Me.Label26.Text = "CEST"
        '
        'CEST
        '
        Me.CEST.Location = New System.Drawing.Point(103, 177)
        Me.CEST.Margin = New System.Windows.Forms.Padding(4)
        Me.CEST.MaxLength = 8
        Me.CEST.Name = "CEST"
        Me.CEST.Size = New System.Drawing.Size(109, 22)
        Me.CEST.TabIndex = 3
        Me.CEST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(13, 354)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 16)
        Me.Label31.TabIndex = 86
        Me.Label31.Text = "Obs"
        '
        'Observacao
        '
        Me.Observacao.Location = New System.Drawing.Point(103, 351)
        Me.Observacao.Margin = New System.Windows.Forms.Padding(4)
        Me.Observacao.MaxLength = 500
        Me.Observacao.Multiline = True
        Me.Observacao.Name = "Observacao"
        Me.Observacao.Size = New System.Drawing.Size(705, 105)
        Me.Observacao.TabIndex = 10
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(529, 308)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(107, 16)
        Me.Label27.TabIndex = 80
        Me.Label27.Text = "Estoque Maximo"
        '
        'EstoqueMaximo
        '
        Me.EstoqueMaximo.Location = New System.Drawing.Point(663, 308)
        Me.EstoqueMaximo.Margin = New System.Windows.Forms.Padding(4)
        Me.EstoqueMaximo.MaxLength = 50
        Me.EstoqueMaximo.Name = "EstoqueMaximo"
        Me.EstoqueMaximo.Size = New System.Drawing.Size(145, 22)
        Me.EstoqueMaximo.TabIndex = 9
        Me.EstoqueMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(249, 308)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(103, 16)
        Me.Label28.TabIndex = 78
        Me.Label28.Text = "Estoque Minimo"
        '
        'EstoqueMinimo
        '
        Me.EstoqueMinimo.Location = New System.Drawing.Point(367, 304)
        Me.EstoqueMinimo.Margin = New System.Windows.Forms.Padding(4)
        Me.EstoqueMinimo.MaxLength = 50
        Me.EstoqueMinimo.Name = "EstoqueMinimo"
        Me.EstoqueMinimo.Size = New System.Drawing.Size(133, 22)
        Me.EstoqueMinimo.TabIndex = 8
        Me.EstoqueMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(13, 308)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 16)
        Me.Label29.TabIndex = 76
        Me.Label29.Text = "Estoque"
        '
        'Estoque
        '
        Me.Estoque.Location = New System.Drawing.Point(103, 304)
        Me.Estoque.Margin = New System.Windows.Forms.Padding(4)
        Me.Estoque.MaxLength = 50
        Me.Estoque.Name = "Estoque"
        Me.Estoque.Size = New System.Drawing.Size(109, 22)
        Me.Estoque.TabIndex = 7
        Me.Estoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(247, 266)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 16)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "Pr.Venda"
        '
        'PrecoVenda
        '
        Me.PrecoVenda.Location = New System.Drawing.Point(367, 262)
        Me.PrecoVenda.Margin = New System.Windows.Forms.Padding(4)
        Me.PrecoVenda.MaxLength = 50
        Me.PrecoVenda.Name = "PrecoVenda"
        Me.PrecoVenda.Size = New System.Drawing.Size(133, 22)
        Me.PrecoVenda.TabIndex = 6
        Me.PrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 262)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 16)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Custo Atual"
        '
        'CustoAtual
        '
        Me.CustoAtual.Location = New System.Drawing.Point(103, 258)
        Me.CustoAtual.Margin = New System.Windows.Forms.Padding(4)
        Me.CustoAtual.MaxLength = 50
        Me.CustoAtual.Name = "CustoAtual"
        Me.CustoAtual.Size = New System.Drawing.Size(109, 22)
        Me.CustoAtual.TabIndex = 5
        Me.CustoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 212)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Unidade"
        '
        'Unidade
        '
        Me.Unidade.Location = New System.Drawing.Point(103, 206)
        Me.Unidade.Margin = New System.Windows.Forms.Padding(4)
        Me.Unidade.MaxLength = 3
        Me.Unidade.Name = "Unidade"
        Me.Unidade.Size = New System.Drawing.Size(109, 22)
        Me.Unidade.TabIndex = 4
        Me.Unidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "NCM"
        '
        'ClassificacaoFiscal
        '
        Me.ClassificacaoFiscal.Location = New System.Drawing.Point(103, 145)
        Me.ClassificacaoFiscal.Margin = New System.Windows.Forms.Padding(4)
        Me.ClassificacaoFiscal.MaxLength = 8
        Me.ClassificacaoFiscal.Name = "ClassificacaoFiscal"
        Me.ClassificacaoFiscal.Size = New System.Drawing.Size(109, 22)
        Me.ClassificacaoFiscal.TabIndex = 2
        Me.ClassificacaoFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "EAN-13"
        '
        'CodigoBarra
        '
        Me.CodigoBarra.Location = New System.Drawing.Point(412, 80)
        Me.CodigoBarra.Margin = New System.Windows.Forms.Padding(4)
        Me.CodigoBarra.MaxLength = 50
        Me.CodigoBarra.Name = "CodigoBarra"
        Me.CodigoBarra.Size = New System.Drawing.Size(212, 22)
        Me.CodigoBarra.TabIndex = 0
        Me.CodigoBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.OptNao)
        Me.GroupBox9.Controls.Add(Me.OptSim)
        Me.GroupBox9.Location = New System.Drawing.Point(677, 59)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(165, 47)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Ativo"
        '
        'OptNao
        '
        Me.OptNao.AutoSize = True
        Me.OptNao.Location = New System.Drawing.Point(85, 18)
        Me.OptNao.Margin = New System.Windows.Forms.Padding(4)
        Me.OptNao.Name = "OptNao"
        Me.OptNao.Size = New System.Drawing.Size(54, 20)
        Me.OptNao.TabIndex = 1
        Me.OptNao.Text = "Não"
        Me.OptNao.UseVisualStyleBackColor = True
        '
        'OptSim
        '
        Me.OptSim.AutoSize = True
        Me.OptSim.Checked = True
        Me.OptSim.Location = New System.Drawing.Point(21, 17)
        Me.OptSim.Margin = New System.Windows.Forms.Padding(4)
        Me.OptSim.Name = "OptSim"
        Me.OptSim.Size = New System.Drawing.Size(51, 20)
        Me.OptSim.TabIndex = 0
        Me.OptSim.TabStop = True
        Me.OptSim.Text = "Sim"
        Me.OptSim.UseVisualStyleBackColor = True
        '
        'CmdExcluir
        '
        Me.CmdExcluir.Location = New System.Drawing.Point(708, 20)
        Me.CmdExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdExcluir.Name = "CmdExcluir"
        Me.CmdExcluir.Size = New System.Drawing.Size(100, 31)
        Me.CmdExcluir.TabIndex = 36
        Me.CmdExcluir.TabStop = False
        Me.CmdExcluir.Text = "Excluir"
        Me.CmdExcluir.UseVisualStyleBackColor = True
        '
        'CmdUltimo
        '
        Me.CmdUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CmdUltimo.Location = New System.Drawing.Point(159, 20)
        Me.CmdUltimo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdUltimo.Name = "CmdUltimo"
        Me.CmdUltimo.Size = New System.Drawing.Size(43, 31)
        Me.CmdUltimo.TabIndex = 32
        Me.CmdUltimo.TabStop = False
        Me.CmdUltimo.Text = ">>"
        Me.CmdUltimo.UseVisualStyleBackColor = True
        '
        'CmdProximo
        '
        Me.CmdProximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CmdProximo.Location = New System.Drawing.Point(117, 20)
        Me.CmdProximo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdProximo.Name = "CmdProximo"
        Me.CmdProximo.Size = New System.Drawing.Size(43, 31)
        Me.CmdProximo.TabIndex = 33
        Me.CmdProximo.TabStop = False
        Me.CmdProximo.Text = ">"
        Me.CmdProximo.UseVisualStyleBackColor = True
        '
        'CmdAnterior
        '
        Me.CmdAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CmdAnterior.Location = New System.Drawing.Point(76, 20)
        Me.CmdAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdAnterior.Name = "CmdAnterior"
        Me.CmdAnterior.Size = New System.Drawing.Size(43, 31)
        Me.CmdAnterior.TabIndex = 31
        Me.CmdAnterior.TabStop = False
        Me.CmdAnterior.Text = "<"
        Me.CmdAnterior.UseVisualStyleBackColor = True
        '
        'CmdPrimeiro
        '
        Me.CmdPrimeiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrimeiro.Location = New System.Drawing.Point(35, 20)
        Me.CmdPrimeiro.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdPrimeiro.Name = "CmdPrimeiro"
        Me.CmdPrimeiro.Size = New System.Drawing.Size(43, 31)
        Me.CmdPrimeiro.TabIndex = 30
        Me.CmdPrimeiro.TabStop = False
        Me.CmdPrimeiro.Text = "<<"
        Me.CmdPrimeiro.UseVisualStyleBackColor = True
        '
        'CmdListar
        '
        Me.CmdListar.Location = New System.Drawing.Point(609, 20)
        Me.CmdListar.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdListar.Name = "CmdListar"
        Me.CmdListar.Size = New System.Drawing.Size(100, 31)
        Me.CmdListar.TabIndex = 37
        Me.CmdListar.TabStop = False
        Me.CmdListar.Text = "Listar"
        Me.CmdListar.UseVisualStyleBackColor = True
        '
        'CmdSalvar
        '
        Me.CmdSalvar.Location = New System.Drawing.Point(511, 20)
        Me.CmdSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSalvar.Name = "CmdSalvar"
        Me.CmdSalvar.Size = New System.Drawing.Size(100, 31)
        Me.CmdSalvar.TabIndex = 35
        Me.CmdSalvar.TabStop = False
        Me.CmdSalvar.Text = "Salvar"
        Me.CmdSalvar.UseVisualStyleBackColor = True
        '
        'CmdIncluir
        '
        Me.CmdIncluir.Location = New System.Drawing.Point(412, 20)
        Me.CmdIncluir.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdIncluir.Name = "CmdIncluir"
        Me.CmdIncluir.Size = New System.Drawing.Size(100, 31)
        Me.CmdIncluir.TabIndex = 34
        Me.CmdIncluir.TabStop = False
        Me.CmdIncluir.Text = "Novo"
        Me.CmdIncluir.UseVisualStyleBackColor = True
        '
        'Produto
        '
        Me.Produto.Location = New System.Drawing.Point(103, 114)
        Me.Produto.Margin = New System.Windows.Forms.Padding(4)
        Me.Produto.MaxLength = 250
        Me.Produto.Name = "Produto"
        Me.Produto.Size = New System.Drawing.Size(705, 22)
        Me.Produto.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Produto"
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.Location = New System.Drawing.Point(103, 70)
        Me.LbCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(0, 29)
        Me.LbCodigo.TabIndex = 4
        Me.LbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(767, 110)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 16)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Fracionado"
        Me.Label13.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(575, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Marca/Fab."
        Me.Label4.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(575, 43)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 16)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Cor"
        Me.Label16.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(575, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Detalhe"
        Me.Label10.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(11, 14)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(867, 494)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'FrmProdutoNfe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 513)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProdutoNfe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Produtos"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.GridPesqClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents PCodigo As System.Windows.Forms.TextBox
    Friend WithEvents PesqNome As System.Windows.Forms.TextBox
    Friend WithEvents GridPesqClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents OptNao As System.Windows.Forms.RadioButton
    Friend WithEvents OptSim As System.Windows.Forms.RadioButton
    Friend WithEvents CmdExcluir As System.Windows.Forms.Button
    Friend WithEvents CmdUltimo As System.Windows.Forms.Button
    Friend WithEvents CmdProximo As System.Windows.Forms.Button
    Friend WithEvents CmdAnterior As System.Windows.Forms.Button
    Friend WithEvents CmdPrimeiro As System.Windows.Forms.Button
    Friend WithEvents CmdListar As System.Windows.Forms.Button
    Friend WithEvents CmdSalvar As System.Windows.Forms.Button
    Friend WithEvents CmdIncluir As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Produto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbCodigo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ClassificacaoFiscal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Observacao As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents EstoqueMaximo As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents EstoqueMinimo As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Estoque As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PrecoVenda As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CustoAtual As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Unidade As System.Windows.Forms.TextBox
    Friend WithEvents CodCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescricaoNCM As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents CEST As TextBox
End Class
