<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Plataforma = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciamentoDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciamentoDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorizaçãoDeUsoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçãoDaLojaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TokenGeradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Plataforna"
        Me.Label3.Visible = False
        '
        'Plataforma
        '
        Me.Plataforma.FormattingEnabled = True
        Me.Plataforma.Items.AddRange(New Object() {"Shopee"})
        Me.Plataforma.Location = New System.Drawing.Point(28, 53)
        Me.Plataforma.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Plataforma.Name = "Plataforma"
        Me.Plataforma.Size = New System.Drawing.Size(299, 24)
        Me.Plataforma.TabIndex = 5
        Me.Plataforma.Text = "Shopee"
        Me.Plataforma.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.MovimentaçãoToolStripMenuItem, Me.AcessoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1371, 28)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.ProdutoToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ProdutoToolStripMenuItem
        '
        Me.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem"
        Me.ProdutoToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.ProdutoToolStripMenuItem.Text = "Produto"
        '
        'MovimentaçãoToolStripMenuItem
        '
        Me.MovimentaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciamentoDeProdutosToolStripMenuItem, Me.GerenciamentoDePedidosToolStripMenuItem})
        Me.MovimentaçãoToolStripMenuItem.Name = "MovimentaçãoToolStripMenuItem"
        Me.MovimentaçãoToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.MovimentaçãoToolStripMenuItem.Text = "Movimentação"
        '
        'GerenciamentoDeProdutosToolStripMenuItem
        '
        Me.GerenciamentoDeProdutosToolStripMenuItem.Name = "GerenciamentoDeProdutosToolStripMenuItem"
        Me.GerenciamentoDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.GerenciamentoDeProdutosToolStripMenuItem.Text = "Gerenciamento de Produtos"
        '
        'GerenciamentoDePedidosToolStripMenuItem
        '
        Me.GerenciamentoDePedidosToolStripMenuItem.Name = "GerenciamentoDePedidosToolStripMenuItem"
        Me.GerenciamentoDePedidosToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.GerenciamentoDePedidosToolStripMenuItem.Text = "Gerenciamento de Pedidos"
        '
        'AcessoToolStripMenuItem
        '
        Me.AcessoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutorizaçãoDeUsoToolStripMenuItem, Me.ConfiguraçãoDaLojaToolStripMenuItem, Me.TokenGeradoToolStripMenuItem})
        Me.AcessoToolStripMenuItem.Name = "AcessoToolStripMenuItem"
        Me.AcessoToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.AcessoToolStripMenuItem.Text = "Acesso"
        '
        'AutorizaçãoDeUsoToolStripMenuItem
        '
        Me.AutorizaçãoDeUsoToolStripMenuItem.Name = "AutorizaçãoDeUsoToolStripMenuItem"
        Me.AutorizaçãoDeUsoToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.AutorizaçãoDeUsoToolStripMenuItem.Text = "Autorização de Uso"
        '
        'ConfiguraçãoDaLojaToolStripMenuItem
        '
        Me.ConfiguraçãoDaLojaToolStripMenuItem.Name = "ConfiguraçãoDaLojaToolStripMenuItem"
        Me.ConfiguraçãoDaLojaToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ConfiguraçãoDaLojaToolStripMenuItem.Text = "Configuração da Loja"
        '
        'TokenGeradoToolStripMenuItem
        '
        Me.TokenGeradoToolStripMenuItem.Name = "TokenGeradoToolStripMenuItem"
        Me.TokenGeradoToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.TokenGeradoToolStripMenuItem.Text = "Ver Token Gerado"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1371, 668)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Plataforma)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Plataforma As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimentaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciamentoDeProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciamentoDePedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcessoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorizaçãoDeUsoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraçãoDaLojaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TokenGeradoToolStripMenuItem As ToolStripMenuItem
End Class
