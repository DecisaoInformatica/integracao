<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastroCliente))
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.PCodigo = New System.Windows.Forms.TextBox()
        Me.PesqCidade = New System.Windows.Forms.TextBox()
        Me.PesqBairro = New System.Windows.Forms.TextBox()
        Me.PesqRua = New System.Windows.Forms.TextBox()
        Me.PesqFantasia = New System.Windows.Forms.TextBox()
        Me.PesqNome = New System.Windows.Forms.TextBox()
        Me.GridPesqClientes = New System.Windows.Forms.DataGridView()
        Me.CodCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rua_Pesq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bairro_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataCadastro = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Obs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.telefone1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cpf = New System.Windows.Forms.MaskedTextBox()
        Me.identidade = New System.Windows.Forms.TextBox()
        Me.Nome = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Estado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboCidade = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Bairro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Complemento = New System.Windows.Forms.TextBox()
        Me.Numero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Rua = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbCodigo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridPesqClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Label41)
        Me.TabPage3.Controls.Add(Me.PCodigo)
        Me.TabPage3.Controls.Add(Me.PesqCidade)
        Me.TabPage3.Controls.Add(Me.PesqBairro)
        Me.TabPage3.Controls.Add(Me.PesqRua)
        Me.TabPage3.Controls.Add(Me.PesqFantasia)
        Me.TabPage3.Controls.Add(Me.PesqNome)
        Me.TabPage3.Controls.Add(Me.GridPesqClientes)
        Me.TabPage3.Controls.Add(Me.Label40)
        Me.TabPage3.Controls.Add(Me.Label39)
        Me.TabPage3.Controls.Add(Me.Label38)
        Me.TabPage3.Controls.Add(Me.Label37)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(781, 472)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pesquisar"
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
        'PesqCidade
        '
        Me.PesqCidade.Location = New System.Drawing.Point(573, 73)
        Me.PesqCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.PesqCidade.MaxLength = 50
        Me.PesqCidade.Name = "PesqCidade"
        Me.PesqCidade.Size = New System.Drawing.Size(196, 22)
        Me.PesqCidade.TabIndex = 5
        '
        'PesqBairro
        '
        Me.PesqBairro.Location = New System.Drawing.Point(392, 73)
        Me.PesqBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.PesqBairro.MaxLength = 50
        Me.PesqBairro.Name = "PesqBairro"
        Me.PesqBairro.Size = New System.Drawing.Size(172, 22)
        Me.PesqBairro.TabIndex = 4
        '
        'PesqRua
        '
        Me.PesqRua.Location = New System.Drawing.Point(12, 73)
        Me.PesqRua.Margin = New System.Windows.Forms.Padding(4)
        Me.PesqRua.MaxLength = 50
        Me.PesqRua.Name = "PesqRua"
        Me.PesqRua.Size = New System.Drawing.Size(371, 22)
        Me.PesqRua.TabIndex = 3
        '
        'PesqFantasia
        '
        Me.PesqFantasia.Location = New System.Drawing.Point(433, 25)
        Me.PesqFantasia.Margin = New System.Windows.Forms.Padding(4)
        Me.PesqFantasia.MaxLength = 50
        Me.PesqFantasia.Name = "PesqFantasia"
        Me.PesqFantasia.Size = New System.Drawing.Size(336, 22)
        Me.PesqFantasia.TabIndex = 2
        '
        'PesqNome
        '
        Me.PesqNome.Location = New System.Drawing.Point(87, 23)
        Me.PesqNome.Margin = New System.Windows.Forms.Padding(4)
        Me.PesqNome.MaxLength = 50
        Me.PesqNome.Name = "PesqNome"
        Me.PesqNome.Size = New System.Drawing.Size(337, 22)
        Me.PesqNome.TabIndex = 1
        '
        'GridPesqClientes
        '
        Me.GridPesqClientes.AllowUserToAddRows = False
        Me.GridPesqClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPesqClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodCliente, Me.NomeCliente, Me.CPF_, Me.Rua_Pesq, Me.Bairro_, Me.Cidade})
        Me.GridPesqClientes.Location = New System.Drawing.Point(8, 105)
        Me.GridPesqClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.GridPesqClientes.Name = "GridPesqClientes"
        Me.GridPesqClientes.RowHeadersWidth = 12
        Me.GridPesqClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridPesqClientes.Size = New System.Drawing.Size(763, 357)
        Me.GridPesqClientes.TabIndex = 6
        Me.GridPesqClientes.TabStop = False
        '
        'CodCliente
        '
        Me.CodCliente.DataPropertyName = "CodCliente"
        Me.CodCliente.HeaderText = "Código"
        Me.CodCliente.MaxInputLength = 10
        Me.CodCliente.MinimumWidth = 6
        Me.CodCliente.Name = "CodCliente"
        Me.CodCliente.ReadOnly = True
        Me.CodCliente.Width = 45
        '
        'NomeCliente
        '
        Me.NomeCliente.DataPropertyName = "NomeCliente"
        Me.NomeCliente.HeaderText = "Nome"
        Me.NomeCliente.MaxInputLength = 300
        Me.NomeCliente.MinimumWidth = 6
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.ReadOnly = True
        Me.NomeCliente.Width = 300
        '
        'CPF_
        '
        Me.CPF_.DataPropertyName = "CPF"
        Me.CPF_.HeaderText = "CPF"
        Me.CPF_.MaxInputLength = 20
        Me.CPF_.MinimumWidth = 6
        Me.CPF_.Name = "CPF_"
        Me.CPF_.ReadOnly = True
        Me.CPF_.Width = 125
        '
        'Rua_Pesq
        '
        Me.Rua_Pesq.DataPropertyName = "Rua"
        Me.Rua_Pesq.HeaderText = "Endereço"
        Me.Rua_Pesq.MaxInputLength = 250
        Me.Rua_Pesq.MinimumWidth = 6
        Me.Rua_Pesq.Name = "Rua_Pesq"
        Me.Rua_Pesq.ReadOnly = True
        Me.Rua_Pesq.Width = 250
        '
        'Bairro_
        '
        Me.Bairro_.DataPropertyName = "Bairro"
        Me.Bairro_.HeaderText = "Bairro"
        Me.Bairro_.MaxInputLength = 250
        Me.Bairro_.MinimumWidth = 6
        Me.Bairro_.Name = "Bairro_"
        Me.Bairro_.ReadOnly = True
        Me.Bairro_.Width = 120
        '
        'Cidade
        '
        Me.Cidade.DataPropertyName = "Cidade"
        Me.Cidade.HeaderText = "Cidade"
        Me.Cidade.MaxInputLength = 250
        Me.Cidade.MinimumWidth = 6
        Me.Cidade.Name = "Cidade"
        Me.Cidade.ReadOnly = True
        Me.Cidade.Width = 120
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(569, 53)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(51, 16)
        Me.Label40.TabIndex = 36
        Me.Label40.Text = "Cidade"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(388, 53)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(43, 16)
        Me.Label39.TabIndex = 34
        Me.Label39.Text = "Bairro"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(8, 53)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(66, 16)
        Me.Label38.TabIndex = 32
        Me.Label38.Text = "Endereço"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(429, 5)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(59, 16)
        Me.Label37.TabIndex = 30
        Me.Label37.Text = "Fantasia"
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
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.DataCadastro)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Obs)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Email)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Controls.Add(Me.CmdExcluir)
        Me.TabPage1.Controls.Add(Me.CmdUltimo)
        Me.TabPage1.Controls.Add(Me.CmdProximo)
        Me.TabPage1.Controls.Add(Me.CmdAnterior)
        Me.TabPage1.Controls.Add(Me.CmdPrimeiro)
        Me.TabPage1.Controls.Add(Me.CmdListar)
        Me.TabPage1.Controls.Add(Me.CmdSalvar)
        Me.TabPage1.Controls.Add(Me.CmdIncluir)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.telefone1)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.cpf)
        Me.TabPage1.Controls.Add(Me.identidade)
        Me.TabPage1.Controls.Add(Me.Nome)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.LbCodigo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(781, 472)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados do Cliente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(497, 76)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cadastrado em"
        '
        'DataCadastro
        '
        Me.DataCadastro.Location = New System.Drawing.Point(671, 75)
        Me.DataCadastro.Margin = New System.Windows.Forms.Padding(4)
        Me.DataCadastro.Mask = "99/99/9999"
        Me.DataCadastro.Name = "DataCadastro"
        Me.DataCadastro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DataCadastro.Size = New System.Drawing.Size(87, 22)
        Me.DataCadastro.TabIndex = 1
        Me.DataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 344)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 16)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Obs"
        '
        'Obs
        '
        Me.Obs.Location = New System.Drawing.Point(89, 344)
        Me.Obs.Margin = New System.Windows.Forms.Padding(4)
        Me.Obs.MaxLength = 250
        Me.Obs.Multiline = True
        Me.Obs.Name = "Obs"
        Me.Obs.Size = New System.Drawing.Size(669, 120)
        Me.Obs.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(236, 288)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "E-mail"
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(298, 288)
        Me.Email.Margin = New System.Windows.Forms.Padding(4)
        Me.Email.MaxLength = 250
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(460, 22)
        Me.Email.TabIndex = 7
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.OptNao)
        Me.GroupBox9.Controls.Add(Me.OptSim)
        Me.GroupBox9.Location = New System.Drawing.Point(236, 59)
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
        Me.CmdExcluir.Location = New System.Drawing.Point(535, 20)
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
        Me.CmdListar.Location = New System.Drawing.Point(436, 20)
        Me.CmdListar.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdListar.Name = "CmdListar"
        Me.CmdListar.Size = New System.Drawing.Size(100, 31)
        Me.CmdListar.TabIndex = 37
        Me.CmdListar.TabStop = False
        Me.CmdListar.Text = "Pesquisar"
        Me.CmdListar.UseVisualStyleBackColor = True
        '
        'CmdSalvar
        '
        Me.CmdSalvar.Location = New System.Drawing.Point(337, 20)
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
        Me.CmdIncluir.Location = New System.Drawing.Point(239, 20)
        Me.CmdIncluir.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdIncluir.Name = "CmdIncluir"
        Me.CmdIncluir.Size = New System.Drawing.Size(100, 31)
        Me.CmdIncluir.TabIndex = 34
        Me.CmdIncluir.TabStop = False
        Me.CmdIncluir.Text = "Novo"
        Me.CmdIncluir.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 291)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Fone 1"
        '
        'telefone1
        '
        Me.telefone1.Location = New System.Drawing.Point(89, 288)
        Me.telefone1.Margin = New System.Windows.Forms.Padding(4)
        Me.telefone1.Name = "telefone1"
        Me.telefone1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.telefone1.Size = New System.Drawing.Size(149, 22)
        Me.telefone1.TabIndex = 6
        Me.telefone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(233, 257)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 16)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "RG"
        '
        'cpf
        '
        Me.cpf.Location = New System.Drawing.Point(89, 252)
        Me.cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.cpf.Mask = "###,###,###-##"
        Me.cpf.Name = "cpf"
        Me.cpf.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.cpf.Size = New System.Drawing.Size(149, 22)
        Me.cpf.TabIndex = 4
        Me.cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'identidade
        '
        Me.identidade.Location = New System.Drawing.Point(298, 252)
        Me.identidade.Margin = New System.Windows.Forms.Padding(4)
        Me.identidade.MaxLength = 50
        Me.identidade.Name = "identidade"
        Me.identidade.Size = New System.Drawing.Size(139, 22)
        Me.identidade.TabIndex = 5
        Me.identidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nome
        '
        Me.Nome.Location = New System.Drawing.Point(97, 117)
        Me.Nome.Margin = New System.Windows.Forms.Padding(4)
        Me.Nome.MaxLength = 250
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(661, 22)
        Me.Nome.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 257)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "CPF"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CEP)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Estado)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CboCidade)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Bairro)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Complemento)
        Me.GroupBox2.Controls.Add(Me.Numero)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Rua)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 147)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(759, 97)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço"
        '
        'CEP
        '
        Me.CEP.Location = New System.Drawing.Point(663, 59)
        Me.CEP.Margin = New System.Windows.Forms.Padding(4)
        Me.CEP.Mask = "##,###-###"
        Me.CEP.Name = "CEP"
        Me.CEP.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.CEP.Size = New System.Drawing.Size(87, 22)
        Me.CEP.TabIndex = 6
        Me.CEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(617, 65)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "CEP"
        '
        'Estado
        '
        Me.Estado.Location = New System.Drawing.Point(519, 55)
        Me.Estado.Margin = New System.Windows.Forms.Padding(4)
        Me.Estado.MaxLength = 2
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(76, 22)
        Me.Estado.TabIndex = 5
        Me.Estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(489, 59)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "UF"
        '
        'CboCidade
        '
        Me.CboCidade.FormattingEnabled = True
        Me.CboCidade.Location = New System.Drawing.Point(297, 55)
        Me.CboCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.CboCidade.Name = "CboCidade"
        Me.CboCidade.Size = New System.Drawing.Size(175, 24)
        Me.CboCidade.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 59)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cidade"
        '
        'Bairro
        '
        Me.Bairro.Location = New System.Drawing.Point(89, 55)
        Me.Bairro.Margin = New System.Windows.Forms.Padding(4)
        Me.Bairro.MaxLength = 50
        Me.Bairro.Name = "Bairro"
        Me.Bairro.Size = New System.Drawing.Size(145, 22)
        Me.Bairro.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 59)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Bairro"
        '
        'Complemento
        '
        Me.Complemento.Location = New System.Drawing.Point(663, 23)
        Me.Complemento.Margin = New System.Windows.Forms.Padding(4)
        Me.Complemento.MaxLength = 25
        Me.Complemento.Name = "Complemento"
        Me.Complemento.Size = New System.Drawing.Size(87, 22)
        Me.Complemento.TabIndex = 2
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(519, 23)
        Me.Numero.Margin = New System.Windows.Forms.Padding(4)
        Me.Numero.MaxLength = 10
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(76, 22)
        Me.Numero.TabIndex = 1
        Me.Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(603, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Compl."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nº"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Rua/Av"
        '
        'Rua
        '
        Me.Rua.Location = New System.Drawing.Point(89, 23)
        Me.Rua.Margin = New System.Windows.Forms.Padding(4)
        Me.Rua.MaxLength = 250
        Me.Rua.Name = "Rua"
        Me.Rua.Size = New System.Drawing.Size(391, 22)
        Me.Rua.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nome"
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.Location = New System.Drawing.Point(84, 70)
        Me.LbCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(0, 29)
        Me.LbCodigo.TabIndex = 4
        Me.LbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(1, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(789, 501)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'FrmCadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(798, 519)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCadastroCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Clientes"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.GridPesqClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents PCodigo As System.Windows.Forms.TextBox
    Friend WithEvents PesqCidade As System.Windows.Forms.TextBox
    Friend WithEvents PesqBairro As System.Windows.Forms.TextBox
    Friend WithEvents PesqRua As System.Windows.Forms.TextBox
    Friend WithEvents PesqFantasia As System.Windows.Forms.TextBox
    Friend WithEvents PesqNome As System.Windows.Forms.TextBox
    Friend WithEvents GridPesqClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
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
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents telefone1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Nome As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Estado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboCidade As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Bairro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Complemento As System.Windows.Forms.TextBox
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Rua As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbCodigo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label10 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DataCadastro As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Obs As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents identidade As TextBox
    Friend WithEvents CodCliente As DataGridViewTextBoxColumn
    Friend WithEvents NomeCliente As DataGridViewTextBoxColumn
    Friend WithEvents CPF_ As DataGridViewTextBoxColumn
    Friend WithEvents Rua_Pesq As DataGridViewTextBoxColumn
    Friend WithEvents Bairro_ As DataGridViewTextBoxColumn
    Friend WithEvents Cidade As DataGridViewTextBoxColumn
End Class
