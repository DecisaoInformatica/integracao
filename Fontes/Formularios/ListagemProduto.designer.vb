<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListagemProduto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListagemProduto))
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodProduto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodMercadoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodPesq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoVenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodMercadoria, Me.CodPesq, Me.Descricao, Me.Unidade, Me.Quantidade, Me.PrecoVenda})
        Me.Grid.Location = New System.Drawing.Point(3, 49)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersWidth = 8
        Me.Grid.Size = New System.Drawing.Size(648, 464)
        Me.Grid.TabIndex = 1
        '
        'Nome
        '
        Me.Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nome.Location = New System.Drawing.Point(122, 23)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(514, 20)
        Me.Nome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Descrição"
        '
        'CodProduto
        '
        Me.CodProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodProduto.Location = New System.Drawing.Point(3, 23)
        Me.CodProduto.Name = "CodProduto"
        Me.CodProduto.Size = New System.Drawing.Size(113, 20)
        Me.CodProduto.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Código"
        '
        'CodMercadoria
        '
        Me.CodMercadoria.DataPropertyName = "CodMercadoria"
        Me.CodMercadoria.HeaderText = "Código"
        Me.CodMercadoria.Name = "CodMercadoria"
        Me.CodMercadoria.ReadOnly = True
        Me.CodMercadoria.Width = 50
        '
        'CodPesq
        '
        Me.CodPesq.DataPropertyName = "CodPesquisa"
        Me.CodPesq.HeaderText = "Cod.Pesquisa"
        Me.CodPesq.Name = "CodPesq"
        Me.CodPesq.ReadOnly = True
        Me.CodPesq.Visible = False
        '
        'Descricao
        '
        Me.Descricao.DataPropertyName = "Descricao"
        Me.Descricao.HeaderText = "Descricao"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.ReadOnly = True
        Me.Descricao.Width = 400
        '
        'Unidade
        '
        Me.Unidade.DataPropertyName = "Unidade"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Unidade.DefaultCellStyle = DataGridViewCellStyle1
        Me.Unidade.HeaderText = "UN"
        Me.Unidade.Name = "Unidade"
        Me.Unidade.ReadOnly = True
        Me.Unidade.Width = 30
        '
        'Quantidade
        '
        Me.Quantidade.DataPropertyName = "Estoque"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.NullValue = "0"
        Me.Quantidade.DefaultCellStyle = DataGridViewCellStyle2
        Me.Quantidade.HeaderText = "Estoque"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        Me.Quantidade.Width = 60
        '
        'PrecoVenda
        '
        Me.PrecoVenda.DataPropertyName = "PrecoVenda"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.PrecoVenda.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecoVenda.HeaderText = "Pr.Venda"
        Me.PrecoVenda.Name = "PrecoVenda"
        Me.PrecoVenda.ReadOnly = True
        Me.PrecoVenda.Width = 75
        '
        'ListagemProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(657, 519)
        Me.Controls.Add(Me.CodProduto)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "ListagemProduto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listagem de Produtos"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Nome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CodProduto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodMercadoria As DataGridViewTextBoxColumn
    Friend WithEvents CodPesq As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents Unidade As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents PrecoVenda As DataGridViewTextBoxColumn
End Class
