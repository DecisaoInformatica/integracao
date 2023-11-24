Public Class FrmPrincipal
    Private Sub CmdConfiguracao_Click(sender As Object, e As EventArgs) 
        Dim _FrmConfiguração As New FrmConfiguração
        _FrmConfiguração.PlataformaUsar = Plataforma.Text
        _FrmConfiguração.ShowDialog()

    End Sub

    Private Sub CmdAutenticação_Click(sender As Object, e As EventArgs) 
        Dim _FrmAutorização As New FrmAutorizacao
        _FrmAutorização.Plataforma = Plataforma.Text
        _FrmAutorização.ShowDialog()
    End Sub

    Private Sub CmdGerarToken_Click(sender As Object, e As EventArgs) 
        Dim _FrmToken As New FrmToken
        _FrmToken.Plataforma.Text = Plataforma.Text
        _FrmToken.ShowDialog()
    End Sub

    Private Sub CMDProdutos_Click(sender As Object, e As EventArgs) 
        Dim _Frm As New FrmProdutos
        _Frm.Plataforma.Text = Plataforma.Text
        _Frm.Show()
    End Sub

    Private Sub CmdPedido_Click(sender As Object, e As EventArgs) 
        Dim _Frm As New FrmPedido
        _Frm.Plataforma.Text = Plataforma.Text
        _Frm.Show()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CmdCadastroProduto_Click(sender As Object, e As EventArgs) 
        Dim _Frm As New FrmProdutoNfe
        _Frm.Show()
    End Sub

    Private Sub CmdCadastroCliente_Click(sender As Object, e As EventArgs) 
        Dim _Frm As New FrmCadastroCliente
        _Frm.Show()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim _Frm As New FrmCadastroCliente
        _Frm.Show()
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem.Click
        Dim _Frm As New FrmProdutoNfe
        _Frm.Show()
    End Sub

    Private Sub GerenciamentoDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciamentoDeProdutosToolStripMenuItem.Click
        Dim _Frm As New FrmProdutos
        _Frm.Plataforma.Text = Plataforma.Text
        _Frm.Show()
    End Sub

    Private Sub GerenciamentoDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciamentoDePedidosToolStripMenuItem.Click
        Dim _Frm As New FrmPedido
        _Frm.Plataforma.Text = Plataforma.Text
        _Frm.Show()
    End Sub

    Private Sub AutorizaçãoDeUsoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizaçãoDeUsoToolStripMenuItem.Click
        Dim _FrmAutorização As New FrmAutorizacao
        _FrmAutorização.Plataforma = Plataforma.Text
        _FrmAutorização.ShowDialog()
    End Sub

    Private Sub ConfiguraçãoDaLojaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraçãoDaLojaToolStripMenuItem.Click
        Dim _FrmConfiguração As New FrmConfiguração
        _FrmConfiguração.PlataformaUsar = Plataforma.Text
        _FrmConfiguração.ShowDialog()
    End Sub

    Private Sub TokenGeradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TokenGeradoToolStripMenuItem.Click
        Dim _FrmToken As New FrmToken
        _FrmToken.Plataforma.Text = Plataforma.Text
        _FrmToken.ShowDialog()
    End Sub
End Class