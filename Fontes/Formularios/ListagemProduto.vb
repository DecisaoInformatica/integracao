Public Class ListagemProduto
    Private ListaProduto As New List(Of Produto)
    Private ListaNova As New List(Of Produto)
    Private Linha As Integer = 0
    Public Event SetaProduto_Codigo(Cod As Integer)
    Private Sub ListagemProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{tab}")
                SendKeys.Send("{HOME}+{END}")
            End If
            If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.F12 Then
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListagemProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DaoP As New DAOProduto()
            ListaProduto = DaoP.Lista(0)
            Filtrar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmdFiltrar_Click(sender As Object, e As EventArgs)
        Try
            Filtrar()
        Catch ex As Exception

        End Try
    End Sub
    Sub Filtrar()
        Try
            ListaNova = New List(Of Produto)
            ListaNova = ListaProduto
            If Nome.Text.Length > 0 Then
                ListaNova = ListaNova.FindAll(Function(P As Produto) UCase(P.Descricao) Like UCase(Nome.Text) & "*")
            End If
            ListaNova = ListaNova.FindAll(Function(P As Produto) UCase(P.CodPesquisa) Like UCase(CodProduto.Text) & "*")

            ListaNova.Sort(Function(p1 As Produto, p2 As Produto) p1.Descricao.CompareTo(p2.Descricao))
            Grid.AutoGenerateColumns = False
            Grid.DataSource = ListaNova
            Grid.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        Try
            If Grid.Rows.Count = 0 Then Exit Sub
            Dim LcCod As String = ""
            Linha = e.RowIndex
            LcCod = Grid.Rows(Linha).Cells(0).Value
            RaiseEvent SetaProduto_Codigo(LcCod)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Grid_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellEnter
        Try
            If Grid.Rows.Count = 0 Then Exit Sub
            Linha = e.RowIndex
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Grid_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid.KeyDown
        Try
            If Grid.Rows.Count = 0 Then Exit Sub
            If e.KeyCode = Keys.Enter Then
                Dim LcCod As String = ""
                LcCod = Grid.Rows(Linha).Cells(0).Value
                RaiseEvent SetaProduto_Codigo(LcCod)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Nome_KeyDown(sender As Object, e As KeyEventArgs) Handles Nome.KeyDown
        Try
            If e.KeyCode = 40 Then
                Grid.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Nome_TextChanged(sender As Object, e As EventArgs) Handles Nome.TextChanged
        Try
            Filtrar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CodProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles CodProduto.KeyDown
        Try
            If e.KeyCode = 40 Then
                Grid.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CodProduto_TextChanged(sender As Object, e As EventArgs) Handles CodProduto.TextChanged
        Try
            Filtrar()
        Catch ex As Exception

        End Try
    End Sub
End Class
