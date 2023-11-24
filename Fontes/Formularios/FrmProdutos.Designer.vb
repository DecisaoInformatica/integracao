<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProdutos
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NSU = New System.Windows.Forms.TextBox()
        Me.Barra = New System.Windows.Forms.TextBox()
        Me.Descricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Plataforma = New System.Windows.Forms.ComboBox()
        Me.CmdAtualizarPreco = New System.Windows.Forms.Button()
        Me.CmdAtualizaEstoque = New System.Windows.Forms.Button()
        Me.Selecionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CodigoAuto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTNSU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTBarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTPerLoja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTFreteFrete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPreco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTPrecoLoja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTQTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXTQTD_Loja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NSU
        '
        Me.NSU.Location = New System.Drawing.Point(222, 27)
        Me.NSU.Margin = New System.Windows.Forms.Padding(2)
        Me.NSU.Name = "NSU"
        Me.NSU.Size = New System.Drawing.Size(102, 20)
        Me.NSU.TabIndex = 0
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(340, 27)
        Me.Barra.Margin = New System.Windows.Forms.Padding(2)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(154, 20)
        Me.Barra.TabIndex = 1
        '
        'Descricao
        '
        Me.Descricao.Location = New System.Drawing.Point(503, 27)
        Me.Descricao.Margin = New System.Windows.Forms.Padding(2)
        Me.Descricao.Name = "Descricao"
        Me.Descricao.Size = New System.Drawing.Size(312, 20)
        Me.Descricao.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(218, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NSU"
        '
        'CmdBuscar
        '
        Me.CmdBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBuscar.Location = New System.Drawing.Point(967, 11)
        Me.CmdBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.CmdBuscar.Name = "CmdBuscar"
        Me.CmdBuscar.Size = New System.Drawing.Size(90, 36)
        Me.CmdBuscar.TabIndex = 6
        Me.CmdBuscar.Text = "&Buscar "
        Me.CmdBuscar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selecionar, Me.CodigoAuto, Me.DescricaoG, Me.TXTNSU, Me.TXTBarra, Me.TXTNome, Me.TXTPerLoja, Me.TXTFreteFrete, Me.txtPreco, Me.TXTPrecoLoja, Me.TXTQTD, Me.TXTQTD_Loja})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 59)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 8
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1318, 580)
        Me.DataGridView1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(336, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Codigo Barra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(499, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Descrição"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Plataforna"
        '
        'Plataforma
        '
        Me.Plataforma.FormattingEnabled = True
        Me.Plataforma.Items.AddRange(New Object() {"Shopee"})
        Me.Plataforma.Location = New System.Drawing.Point(13, 27)
        Me.Plataforma.Margin = New System.Windows.Forms.Padding(2)
        Me.Plataforma.Name = "Plataforma"
        Me.Plataforma.Size = New System.Drawing.Size(163, 21)
        Me.Plataforma.TabIndex = 10
        '
        'CmdAtualizarPreco
        '
        Me.CmdAtualizarPreco.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdAtualizarPreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAtualizarPreco.Location = New System.Drawing.Point(1061, 11)
        Me.CmdAtualizarPreco.Margin = New System.Windows.Forms.Padding(2)
        Me.CmdAtualizarPreco.Name = "CmdAtualizarPreco"
        Me.CmdAtualizarPreco.Size = New System.Drawing.Size(131, 36)
        Me.CmdAtualizarPreco.TabIndex = 13
        Me.CmdAtualizarPreco.Text = "Atualizar &Preço"
        Me.CmdAtualizarPreco.UseVisualStyleBackColor = False
        '
        'CmdAtualizaEstoque
        '
        Me.CmdAtualizaEstoque.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdAtualizaEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAtualizaEstoque.Location = New System.Drawing.Point(1196, 11)
        Me.CmdAtualizaEstoque.Margin = New System.Windows.Forms.Padding(2)
        Me.CmdAtualizaEstoque.Name = "CmdAtualizaEstoque"
        Me.CmdAtualizaEstoque.Size = New System.Drawing.Size(135, 36)
        Me.CmdAtualizaEstoque.TabIndex = 14
        Me.CmdAtualizaEstoque.Text = "Atualizar &Estoque"
        Me.CmdAtualizaEstoque.UseVisualStyleBackColor = False
        '
        'Selecionar
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = False
        Me.Selecionar.DefaultCellStyle = DataGridViewCellStyle1
        Me.Selecionar.HeaderText = "S/N"
        Me.Selecionar.MinimumWidth = 6
        Me.Selecionar.Name = "Selecionar"
        Me.Selecionar.Width = 35
        '
        'CodigoAuto
        '
        Me.CodigoAuto.DataPropertyName = "CodigoAuto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoAuto.DefaultCellStyle = DataGridViewCellStyle2
        Me.CodigoAuto.HeaderText = "Código"
        Me.CodigoAuto.MinimumWidth = 6
        Me.CodigoAuto.Name = "CodigoAuto"
        Me.CodigoAuto.Width = 70
        '
        'DescricaoG
        '
        Me.DescricaoG.DataPropertyName = "Descricao"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescricaoG.DefaultCellStyle = DataGridViewCellStyle3
        Me.DescricaoG.HeaderText = "Descrição"
        Me.DescricaoG.MinimumWidth = 6
        Me.DescricaoG.Name = "DescricaoG"
        Me.DescricaoG.ReadOnly = True
        Me.DescricaoG.Width = 270
        '
        'TXTNSU
        '
        Me.TXTNSU.DataPropertyName = "ItemID_Loja"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTNSU.DefaultCellStyle = DataGridViewCellStyle4
        Me.TXTNSU.HeaderText = "SKU"
        Me.TXTNSU.MinimumWidth = 6
        Me.TXTNSU.Name = "TXTNSU"
        Me.TXTNSU.ReadOnly = True
        Me.TXTNSU.Width = 125
        '
        'TXTBarra
        '
        Me.TXTBarra.DataPropertyName = "Barra"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBarra.DefaultCellStyle = DataGridViewCellStyle5
        Me.TXTBarra.HeaderText = "Barra"
        Me.TXTBarra.MinimumWidth = 6
        Me.TXTBarra.Name = "TXTBarra"
        Me.TXTBarra.ReadOnly = True
        Me.TXTBarra.Width = 125
        '
        'TXTNome
        '
        Me.TXTNome.DataPropertyName = "Nome"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTNome.DefaultCellStyle = DataGridViewCellStyle6
        Me.TXTNome.HeaderText = "Nome"
        Me.TXTNome.MinimumWidth = 6
        Me.TXTNome.Name = "TXTNome"
        Me.TXTNome.ReadOnly = True
        Me.TXTNome.Width = 200
        '
        'TXTPerLoja
        '
        Me.TXTPerLoja.DataPropertyName = "PerLoja"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.TXTPerLoja.DefaultCellStyle = DataGridViewCellStyle7
        Me.TXTPerLoja.HeaderText = "% Loja"
        Me.TXTPerLoja.MinimumWidth = 6
        Me.TXTPerLoja.Name = "TXTPerLoja"
        Me.TXTPerLoja.Width = 70
        '
        'TXTFreteFrete
        '
        Me.TXTFreteFrete.DataPropertyName = "Frete"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.TXTFreteFrete.DefaultCellStyle = DataGridViewCellStyle8
        Me.TXTFreteFrete.HeaderText = "V.Frete"
        Me.TXTFreteFrete.MinimumWidth = 6
        Me.TXTFreteFrete.Name = "TXTFreteFrete"
        Me.TXTFreteFrete.Width = 70
        '
        'txtPreco
        '
        Me.txtPreco.DataPropertyName = "Preco"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.txtPreco.DefaultCellStyle = DataGridViewCellStyle9
        Me.txtPreco.HeaderText = "Preço"
        Me.txtPreco.MinimumWidth = 6
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.ReadOnly = True
        Me.txtPreco.Width = 80
        '
        'TXTPrecoLoja
        '
        Me.TXTPrecoLoja.DataPropertyName = "PrecoLoja"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.TXTPrecoLoja.DefaultCellStyle = DataGridViewCellStyle10
        Me.TXTPrecoLoja.HeaderText = "Preço Loja"
        Me.TXTPrecoLoja.MinimumWidth = 6
        Me.TXTPrecoLoja.Name = "TXTPrecoLoja"
        Me.TXTPrecoLoja.Width = 90
        '
        'TXTQTD
        '
        Me.TXTQTD.DataPropertyName = "QTD"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle11.Format = "N0"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.TXTQTD.DefaultCellStyle = DataGridViewCellStyle11
        Me.TXTQTD.HeaderText = "QTD"
        Me.TXTQTD.MinimumWidth = 6
        Me.TXTQTD.Name = "TXTQTD"
        Me.TXTQTD.ReadOnly = True
        Me.TXTQTD.Width = 70
        '
        'TXTQTD_Loja
        '
        Me.TXTQTD_Loja.DataPropertyName = "QTD_Loja"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle12.Format = "N0"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.TXTQTD_Loja.DefaultCellStyle = DataGridViewCellStyle12
        Me.TXTQTD_Loja.HeaderText = "QTD_Loja"
        Me.TXTQTD_Loja.MinimumWidth = 6
        Me.TXTQTD_Loja.Name = "TXTQTD_Loja"
        Me.TXTQTD_Loja.Width = 80
        '
        'FrmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1344, 645)
        Me.Controls.Add(Me.CmdAtualizaEstoque)
        Me.Controls.Add(Me.CmdAtualizarPreco)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Plataforma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmdBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Descricao)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.NSU)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmProdutos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NSU As TextBox
    Friend WithEvents Barra As TextBox
    Friend WithEvents Descricao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmdBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Plataforma As ComboBox
    Friend WithEvents CmdAtualizarPreco As Button
    Friend WithEvents CmdAtualizaEstoque As Button
    Friend WithEvents Selecionar As DataGridViewCheckBoxColumn
    Friend WithEvents CodigoAuto As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoG As DataGridViewTextBoxColumn
    Friend WithEvents TXTNSU As DataGridViewTextBoxColumn
    Friend WithEvents TXTBarra As DataGridViewTextBoxColumn
    Friend WithEvents TXTNome As DataGridViewTextBoxColumn
    Friend WithEvents TXTPerLoja As DataGridViewTextBoxColumn
    Friend WithEvents TXTFreteFrete As DataGridViewTextBoxColumn
    Friend WithEvents txtPreco As DataGridViewTextBoxColumn
    Friend WithEvents TXTPrecoLoja As DataGridViewTextBoxColumn
    Friend WithEvents TXTQTD As DataGridViewTextBoxColumn
    Friend WithEvents TXTQTD_Loja As DataGridViewTextBoxColumn
End Class
