<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedido
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedido))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Plataforma = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdBuscarPedidos = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.GridCabecalho = New System.Windows.Forms.DataGridView()
        Me.Selecionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PedidoGerado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtIDLoja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtEmissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtFormaPag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChaveAcesso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridItem = New System.Windows.Forms.DataGridView()
        Me.TxtItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCodigoLoja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtQtde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessarPedido = New System.Windows.Forms.Button()
        Me.CmdUploadArquivo = New System.Windows.Forms.Button()
        Me.ArquivoXML = New System.Windows.Forms.TextBox()
        Me.CmdSelecionaArquivo = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataInicio = New System.Windows.Forms.MaskedTextBox()
        Me.DataFim = New System.Windows.Forms.MaskedTextBox()
        CType(Me.GridCabecalho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Plataforna"
        '
        'Plataforma
        '
        Me.Plataforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plataforma.FormattingEnabled = True
        Me.Plataforma.Items.AddRange(New Object() {"Shopee"})
        Me.Plataforma.Location = New System.Drawing.Point(12, 38)
        Me.Plataforma.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Plataforma.Name = "Plataforma"
        Me.Plataforma.Size = New System.Drawing.Size(185, 26)
        Me.Plataforma.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(217, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Período"
        '
        'CmdBuscarPedidos
        '
        Me.CmdBuscarPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBuscarPedidos.Location = New System.Drawing.Point(1044, 12)
        Me.CmdBuscarPedidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmdBuscarPedidos.Name = "CmdBuscarPedidos"
        Me.CmdBuscarPedidos.Size = New System.Drawing.Size(216, 55)
        Me.CmdBuscarPedidos.TabIndex = 4
        Me.CmdBuscarPedidos.Text = "Buscar Pedidos na Loja"
        Me.CmdBuscarPedidos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(445, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Status do Pedido"
        '
        'Status
        '
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.FormattingEnabled = True
        Me.Status.Location = New System.Drawing.Point(449, 38)
        Me.Status.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(241, 26)
        Me.Status.TabIndex = 3
        '
        'GridCabecalho
        '
        Me.GridCabecalho.AllowUserToAddRows = False
        Me.GridCabecalho.AllowUserToDeleteRows = False
        Me.GridCabecalho.BackgroundColor = System.Drawing.Color.White
        Me.GridCabecalho.ColumnHeadersHeight = 29
        Me.GridCabecalho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selecionar, Me.PedidoGerado, Me.TxtIDLoja, Me.TxtEmissao, Me.TXTCliente, Me.TxtCPF, Me.TxtFormaPag, Me.TXTValor, Me.ChaveAcesso})
        Me.GridCabecalho.Location = New System.Drawing.Point(5, 81)
        Me.GridCabecalho.Margin = New System.Windows.Forms.Padding(4)
        Me.GridCabecalho.Name = "GridCabecalho"
        Me.GridCabecalho.RowHeadersWidth = 8
        Me.GridCabecalho.Size = New System.Drawing.Size(1496, 501)
        Me.GridCabecalho.TabIndex = 7
        '
        'Selecionar
        '
        Me.Selecionar.HeaderText = "S/N"
        Me.Selecionar.MinimumWidth = 6
        Me.Selecionar.Name = "Selecionar"
        Me.Selecionar.Width = 40
        '
        'PedidoGerado
        '
        Me.PedidoGerado.DataPropertyName = "CodVenda_Gerado"
        Me.PedidoGerado.HeaderText = "Ped.Gerado"
        Me.PedidoGerado.MinimumWidth = 6
        Me.PedidoGerado.Name = "PedidoGerado"
        Me.PedidoGerado.Width = 70
        '
        'TxtIDLoja
        '
        Me.TxtIDLoja.DataPropertyName = "ID_Loja"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TxtIDLoja.DefaultCellStyle = DataGridViewCellStyle1
        Me.TxtIDLoja.HeaderText = "IDLoja"
        Me.TxtIDLoja.MinimumWidth = 120
        Me.TxtIDLoja.Name = "TxtIDLoja"
        Me.TxtIDLoja.ReadOnly = True
        Me.TxtIDLoja.Width = 120
        '
        'TxtEmissao
        '
        Me.TxtEmissao.DataPropertyName = "Emissao"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TxtEmissao.DefaultCellStyle = DataGridViewCellStyle2
        Me.TxtEmissao.HeaderText = "Emissão"
        Me.TxtEmissao.MinimumWidth = 80
        Me.TxtEmissao.Name = "TxtEmissao"
        Me.TxtEmissao.ReadOnly = True
        Me.TxtEmissao.Width = 80
        '
        'TXTCliente
        '
        Me.TXTCliente.DataPropertyName = "Cliente_Nome"
        Me.TXTCliente.HeaderText = "Cliente"
        Me.TXTCliente.MinimumWidth = 250
        Me.TXTCliente.Name = "TXTCliente"
        Me.TXTCliente.ReadOnly = True
        Me.TXTCliente.Width = 250
        '
        'TxtCPF
        '
        Me.TxtCPF.DataPropertyName = "Cliente_CPF"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TxtCPF.DefaultCellStyle = DataGridViewCellStyle3
        Me.TxtCPF.HeaderText = "CPF"
        Me.TxtCPF.MinimumWidth = 100
        Me.TxtCPF.Name = "TxtCPF"
        Me.TxtCPF.ReadOnly = True
        Me.TxtCPF.Width = 125
        '
        'TxtFormaPag
        '
        Me.TxtFormaPag.DataPropertyName = "Forma_Pag"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TxtFormaPag.DefaultCellStyle = DataGridViewCellStyle4
        Me.TxtFormaPag.HeaderText = "FormaPag"
        Me.TxtFormaPag.MinimumWidth = 150
        Me.TxtFormaPag.Name = "TxtFormaPag"
        Me.TxtFormaPag.ReadOnly = True
        Me.TxtFormaPag.Width = 150
        '
        'TXTValor
        '
        Me.TXTValor.DataPropertyName = "Valor_Total"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.TXTValor.DefaultCellStyle = DataGridViewCellStyle5
        Me.TXTValor.HeaderText = "Valor"
        Me.TXTValor.MinimumWidth = 6
        Me.TXTValor.Name = "TXTValor"
        Me.TXTValor.ReadOnly = True
        Me.TXTValor.Width = 90
        '
        'ChaveAcesso
        '
        Me.ChaveAcesso.HeaderText = "Chave de Acesso"
        Me.ChaveAcesso.MinimumWidth = 6
        Me.ChaveAcesso.Name = "ChaveAcesso"
        Me.ChaveAcesso.ReadOnly = True
        Me.ChaveAcesso.Width = 230
        '
        'GridItem
        '
        Me.GridItem.AllowUserToAddRows = False
        Me.GridItem.AllowUserToDeleteRows = False
        Me.GridItem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridItem.ColumnHeadersHeight = 29
        Me.GridItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TxtItem, Me.TXTCodigo, Me.Descricao, Me.TxtCodigoLoja, Me.TxtNome, Me.TxtQtde, Me.TXTUnitario, Me.TxtTotal})
        Me.GridItem.Location = New System.Drawing.Point(5, 607)
        Me.GridItem.Margin = New System.Windows.Forms.Padding(4)
        Me.GridItem.Name = "GridItem"
        Me.GridItem.RowHeadersWidth = 8
        Me.GridItem.Size = New System.Drawing.Size(1496, 207)
        Me.GridItem.TabIndex = 8
        '
        'TxtItem
        '
        Me.TxtItem.DataPropertyName = "Item"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TxtItem.DefaultCellStyle = DataGridViewCellStyle6
        Me.TxtItem.HeaderText = "Item"
        Me.TxtItem.MinimumWidth = 6
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.ReadOnly = True
        Me.TxtItem.Width = 40
        '
        'TXTCodigo
        '
        Me.TXTCodigo.DataPropertyName = "CodProdutoAuto"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TXTCodigo.DefaultCellStyle = DataGridViewCellStyle7
        Me.TXTCodigo.HeaderText = "Codigo"
        Me.TXTCodigo.MinimumWidth = 6
        Me.TXTCodigo.Name = "TXTCodigo"
        Me.TXTCodigo.ReadOnly = True
        Me.TXTCodigo.Width = 70
        '
        'Descricao
        '
        Me.Descricao.DataPropertyName = "Descricao"
        Me.Descricao.HeaderText = "Descrição"
        Me.Descricao.MinimumWidth = 6
        Me.Descricao.Name = "Descricao"
        Me.Descricao.Width = 280
        '
        'TxtCodigoLoja
        '
        Me.TxtCodigoLoja.DataPropertyName = "CodProduto_Loja"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TxtCodigoLoja.DefaultCellStyle = DataGridViewCellStyle8
        Me.TxtCodigoLoja.HeaderText = "Codigo Loja"
        Me.TxtCodigoLoja.MinimumWidth = 120
        Me.TxtCodigoLoja.Name = "TxtCodigoLoja"
        Me.TxtCodigoLoja.ReadOnly = True
        Me.TxtCodigoLoja.Width = 120
        '
        'TxtNome
        '
        Me.TxtNome.DataPropertyName = "Nome"
        Me.TxtNome.HeaderText = "Decrição Loja"
        Me.TxtNome.MinimumWidth = 250
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.ReadOnly = True
        Me.TxtNome.Width = 300
        '
        'TxtQtde
        '
        Me.TxtQtde.DataPropertyName = "Quantidade"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = "0"
        Me.TxtQtde.DefaultCellStyle = DataGridViewCellStyle9
        Me.TxtQtde.HeaderText = "Qtde"
        Me.TxtQtde.MinimumWidth = 100
        Me.TxtQtde.Name = "TxtQtde"
        Me.TxtQtde.ReadOnly = True
        Me.TxtQtde.Width = 125
        '
        'TXTUnitario
        '
        Me.TXTUnitario.DataPropertyName = "ValorUnitario"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.TXTUnitario.DefaultCellStyle = DataGridViewCellStyle10
        Me.TXTUnitario.HeaderText = "Vl. Unitario"
        Me.TXTUnitario.MinimumWidth = 80
        Me.TXTUnitario.Name = "TXTUnitario"
        Me.TXTUnitario.ReadOnly = True
        Me.TXTUnitario.Width = 80
        '
        'TxtTotal
        '
        Me.TxtTotal.DataPropertyName = "ValorTotal"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.TxtTotal.DefaultCellStyle = DataGridViewCellStyle11
        Me.TxtTotal.HeaderText = "V.Total"
        Me.TxtTotal.MinimumWidth = 90
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Width = 90
        '
        'ProcessarPedido
        '
        Me.ProcessarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProcessarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessarPedido.Location = New System.Drawing.Point(1285, 12)
        Me.ProcessarPedido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProcessarPedido.Name = "ProcessarPedido"
        Me.ProcessarPedido.Size = New System.Drawing.Size(216, 55)
        Me.ProcessarPedido.TabIndex = 5
        Me.ProcessarPedido.Text = "Processar Pedidos Selecionados"
        Me.ProcessarPedido.UseVisualStyleBackColor = False
        '
        'CmdUploadArquivo
        '
        Me.CmdUploadArquivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdUploadArquivo.Location = New System.Drawing.Point(1285, 12)
        Me.CmdUploadArquivo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmdUploadArquivo.Name = "CmdUploadArquivo"
        Me.CmdUploadArquivo.Size = New System.Drawing.Size(216, 55)
        Me.CmdUploadArquivo.TabIndex = 6
        Me.CmdUploadArquivo.Text = "Upload Arquivo"
        Me.CmdUploadArquivo.UseVisualStyleBackColor = True
        Me.CmdUploadArquivo.Visible = False
        '
        'ArquivoXML
        '
        Me.ArquivoXML.Location = New System.Drawing.Point(244, -9)
        Me.ArquivoXML.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ArquivoXML.Name = "ArquivoXML"
        Me.ArquivoXML.Size = New System.Drawing.Size(36, 22)
        Me.ArquivoXML.TabIndex = 23
        Me.ArquivoXML.Visible = False
        '
        'CmdSelecionaArquivo
        '
        Me.CmdSelecionaArquivo.Location = New System.Drawing.Point(304, -7)
        Me.CmdSelecionaArquivo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmdSelecionaArquivo.Name = "CmdSelecionaArquivo"
        Me.CmdSelecionaArquivo.Size = New System.Drawing.Size(37, 23)
        Me.CmdSelecionaArquivo.TabIndex = 24
        Me.CmdSelecionaArquivo.Text = "..."
        Me.CmdSelecionaArquivo.UseVisualStyleBackColor = True
        Me.CmdSelecionaArquivo.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataInicio
        '
        Me.DataInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataInicio.Location = New System.Drawing.Point(221, 38)
        Me.DataInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.DataInicio.Mask = "99/99/99"
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DataInicio.Size = New System.Drawing.Size(95, 26)
        Me.DataInicio.TabIndex = 1
        '
        'DataFim
        '
        Me.DataFim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataFim.Location = New System.Drawing.Point(321, 38)
        Me.DataFim.Margin = New System.Windows.Forms.Padding(4)
        Me.DataFim.Mask = "99/99/99"
        Me.DataFim.Name = "DataFim"
        Me.DataFim.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DataFim.Size = New System.Drawing.Size(95, 26)
        Me.DataFim.TabIndex = 2
        '
        'FrmPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1505, 820)
        Me.Controls.Add(Me.DataFim)
        Me.Controls.Add(Me.DataInicio)
        Me.Controls.Add(Me.CmdSelecionaArquivo)
        Me.Controls.Add(Me.ArquivoXML)
        Me.Controls.Add(Me.ProcessarPedido)
        Me.Controls.Add(Me.GridItem)
        Me.Controls.Add(Me.GridCabecalho)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.CmdBuscarPedidos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Plataforma)
        Me.Controls.Add(Me.CmdUploadArquivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmPedido"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento dos Pedidos"
        CType(Me.GridCabecalho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Plataforma As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmdBuscarPedidos As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Status As ComboBox
    Friend WithEvents GridCabecalho As DataGridView
    Friend WithEvents GridItem As DataGridView
    Friend WithEvents ProcessarPedido As Button
    Friend WithEvents CmdUploadArquivo As Button
    Friend WithEvents ArquivoXML As TextBox
    Friend WithEvents CmdSelecionaArquivo As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataInicio As MaskedTextBox
    Friend WithEvents DataFim As MaskedTextBox
    Friend WithEvents TxtItem As DataGridViewTextBoxColumn
    Friend WithEvents TXTCodigo As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents TxtCodigoLoja As DataGridViewTextBoxColumn
    Friend WithEvents TxtNome As DataGridViewTextBoxColumn
    Friend WithEvents TxtQtde As DataGridViewTextBoxColumn
    Friend WithEvents TXTUnitario As DataGridViewTextBoxColumn
    Friend WithEvents TxtTotal As DataGridViewTextBoxColumn
    Friend WithEvents Selecionar As DataGridViewCheckBoxColumn
    Friend WithEvents PedidoGerado As DataGridViewTextBoxColumn
    Friend WithEvents TxtIDLoja As DataGridViewTextBoxColumn
    Friend WithEvents TxtEmissao As DataGridViewTextBoxColumn
    Friend WithEvents TXTCliente As DataGridViewTextBoxColumn
    Friend WithEvents TxtCPF As DataGridViewTextBoxColumn
    Friend WithEvents TxtFormaPag As DataGridViewTextBoxColumn
    Friend WithEvents TXTValor As DataGridViewTextBoxColumn
    Friend WithEvents ChaveAcesso As DataGridViewTextBoxColumn
End Class
