Public Class Estoque
    Friend Class Produto
        Public Property Nome As String
        Public Property Preco As Decimal
        Public Property Quantidade As Integer
        Public Property Descricao As String
        Public Property Categoria As String
    End Class

    Private produtos As New List(Of Produto)()
    Private editIndex As Integer = -1
    Private colunasCriadas As Boolean = False


    Private Sub Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarGrid()
    End Sub


    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim nome = user_nome.Text.Trim()
        Dim preco As Decimal
        Dim quantidade As Integer
        Dim descricao = TextBox1.Text.Trim()
        Dim categoria = TextBox3.Text.Trim()

        If Not Decimal.TryParse(TextBox2.Text, preco) Then
            MessageBox.Show("Preço inválido.")
            Return
        End If
        If Not Integer.TryParse(TextBox4.Text, quantidade) Then
            MessageBox.Show("Quantidade inválida.")
            Return
        End If
        If nome = "" Or descricao = "" Or categoria = "" Then
            MessageBox.Show("Preencha todos os campos.")
            Return
        End If

        If editIndex = -1 Then

            produtos.Add(New Produto With {
                .Nome = nome,
                .Preco = preco,
                .Quantidade = quantidade,
                .Descricao = descricao,
                .Categoria = categoria
            })
        Else

            If editIndex >= 0 AndAlso editIndex < produtos.Count Then
                produtos(editIndex).Nome = nome
                produtos(editIndex).Preco = preco
                produtos(editIndex).Quantidade = quantidade
                produtos(editIndex).Descricao = descricao
                produtos(editIndex).Categoria = categoria
            End If
            editIndex = -1
            btn_entrar.Text = "Cadastrar"
        End If

        LimparCampos()
        AtualizarGrid()
    End Sub


    Private Sub AtualizarGrid()
        If Not colunasCriadas Then
            Guna2DataGridView1.Columns.Clear()
            Guna2DataGridView1.Columns.Add("Nome", "Nome")
            Guna2DataGridView1.Columns.Add("Preco", "Preço")
            Guna2DataGridView1.Columns.Add("Quantidade", "Quantidade")
            Guna2DataGridView1.Columns.Add("Descricao", "Descrição")
            Guna2DataGridView1.Columns.Add("Categoria", "Categoria")

            Dim editarBtn As New DataGridViewButtonColumn With {
                .Name = "Editar",
                .HeaderText = "Editar",
                .Text = "Editar",
                .UseColumnTextForButtonValue = True
            }
            Guna2DataGridView1.Columns.Add(editarBtn)

            Dim excluirBtn As New DataGridViewButtonColumn With {
                .Name = "Excluir",
                .HeaderText = "Excluir",
                .Text = "Excluir",
                .UseColumnTextForButtonValue = True
            }
            Guna2DataGridView1.Columns.Add(excluirBtn)

            colunasCriadas = True
        End If


        Guna2DataGridView1.Rows.Clear()
        For Each p In produtos
            Guna2DataGridView1.Rows.Add(p.Nome, p.Preco.ToString("F2"), p.Quantidade.ToString(), p.Descricao, p.Categoria)
        Next
    End Sub


    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If e.RowIndex < 0 OrElse e.RowIndex >= produtos.Count Then Return

        If Guna2DataGridView1.Columns(e.ColumnIndex).Name = "Editar" Then

            editIndex = e.RowIndex
            Dim p = produtos(editIndex)
            user_nome.Text = p.Nome
            TextBox2.Text = p.Preco.ToString()
            TextBox4.Text = p.Quantidade.ToString()
            TextBox1.Text = p.Descricao
            TextBox3.Text = p.Categoria
            btn_entrar.Text = "Salvar"

        ElseIf Guna2DataGridView1.Columns(e.ColumnIndex).Name = "Excluir" Then

            If MessageBox.Show("Deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                produtos.RemoveAt(e.RowIndex)
                AtualizarGrid()
                LimparCampos()
            End If
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        LimparCampos()
    End Sub


    Private Sub LimparCampos()
        user_nome.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox1.Text = ""
        TextBox3.Text = ""
        editIndex = -1
        btn_entrar.Text = "Cadastrar"
        user_nome.Focus()
    End Sub
End Class
