Imports MySql.Data.MySqlClient

Public Class Estoque
    Dim conexao As MySqlConnection
    Dim idSelecionado As Integer = -1

    Private Sub Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        CarregarEstoque(db)
        ConfigurarDataGridView(Guna2DataGridView1)
    End Sub

    Private Sub CarregarEstoque(conexao As MySqlConnection)
        If conexao.State <> ConnectionState.Open Then
            MsgBox("Erro ao conectar com o banco!", MsgBoxStyle.Critical)
            Return
        End If

        Dim sql As String = "SELECT id, nome, preco, quantidade, descricao, categoria FROM produtos"
        Dim cmd As New MySqlCommand(sql, conexao)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        Guna2DataGridView1.Columns.Clear()
        Guna2DataGridView1.Rows.Clear()

        ' Colunas
        Guna2DataGridView1.Columns.Add("id", "ID")
        Guna2DataGridView1.Columns("id").Visible = False
        Guna2DataGridView1.Columns.Add("nome", "Nome")
        Guna2DataGridView1.Columns.Add("preco", "Preço")
        Guna2DataGridView1.Columns.Add("quantidade", "Quantidade")
        Guna2DataGridView1.Columns.Add("descricao", "Descrição")
        Guna2DataGridView1.Columns.Add("categoria", "Categoria")

        ' Botões
        Dim editarBtn As New DataGridViewButtonColumn With {.Name = "editar", .HeaderText = "Editar", .Text = "✏️", .UseColumnTextForButtonValue = True}
        Dim excluirBtn As New DataGridViewButtonColumn With {.Name = "excluir", .HeaderText = "Excluir", .Text = "❌", .UseColumnTextForButtonValue = True}
        Guna2DataGridView1.Columns.Add(editarBtn)
        Guna2DataGridView1.Columns.Add(excluirBtn)

        While reader.Read()
            Guna2DataGridView1.Rows.Add(
                reader("id"),
                reader("nome"),
                FormatNumber(reader("preco"), 2),
                reader("quantidade"),
                reader("descricao").ToString(),
                reader("categoria")
            )
        End While

        reader.Close()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Dim nome = user_nome.Text.Trim()
        Dim descricao = TextBox1.Text.Trim()
        Dim categoria = TextBox3.Text.Trim()
        Dim preco As Decimal
        Dim quantidade As Integer

        If Not Decimal.TryParse(TextBox2.Text, preco) Then
            MsgBox("Preço inválido.")
            Return
        End If

        If Not Integer.TryParse(TextBox4.Text, quantidade) Then
            MsgBox("Quantidade inválida.")
            Return
        End If

        If nome = "" Or categoria = "" Then
            MsgBox("Preencha os campos obrigatórios (nome e categoria).")
            Return
        End If

        Dim cmd As MySqlCommand

        If idSelecionado = -1 Then
            ' Inserir novo
            Dim sqlInsert = "INSERT INTO produtos(nome, preco, quantidade, descricao, categoria) VALUES (@nome, @preco, @quantidade, @descricao, @categoria)"
            cmd = New MySqlCommand(sqlInsert, db)
        Else
            ' Atualizar existente
            Dim sqlUpdate = "UPDATE produtos SET nome=@nome, preco=@preco, quantidade=@quantidade, descricao=@descricao, categoria=@categoria WHERE id=@id"
            cmd = New MySqlCommand(sqlUpdate, db)
            cmd.Parameters.AddWithValue("@id", idSelecionado)
        End If

        cmd.Parameters.AddWithValue("@nome", nome)
        cmd.Parameters.AddWithValue("@preco", preco)
        cmd.Parameters.AddWithValue("@quantidade", quantidade)
        cmd.Parameters.AddWithValue("@descricao", descricao)
        cmd.Parameters.AddWithValue("@categoria", categoria)

        cmd.ExecuteNonQuery()
        MsgBox("Produto salvo com sucesso!", MsgBoxStyle.Information)

        LimparCampos()
        CarregarEstoque(db)
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim id As Integer = CInt(Guna2DataGridView1.Rows(e.RowIndex).Cells("id").Value)

        If Guna2DataGridView1.Columns(e.ColumnIndex).Name = "editar" Then
            ' Carregar dados no formulário
            Dim sql As String = "SELECT * FROM produtos WHERE id = @id"
            Dim cmd As New MySqlCommand(sql, db)
            cmd.Parameters.AddWithValue("@id", id)
            Dim reader = cmd.ExecuteReader()

            If reader.Read() Then
                idSelecionado = reader("id")
                user_nome.Text = reader("nome").ToString()
                TextBox2.Text = reader("preco").ToString()
                TextBox4.Text = reader("quantidade").ToString()
                TextBox1.Text = reader("descricao").ToString()
                TextBox3.Text = reader("categoria").ToString()
                btn_salvar.Text = "Atualizar"
            End If
            reader.Close()

        ElseIf Guna2DataGridView1.Columns(e.ColumnIndex).Name = "excluir" Then
            If MsgBox("Deseja excluir este produto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Dim sqlDel As String = "DELETE FROM produtos WHERE id = @id"
                Dim cmd As New MySqlCommand(sqlDel, db)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                MsgBox("Produto excluído com sucesso!", MsgBoxStyle.Information)
                CarregarEstoque(db)
                LimparCampos()
            End If
        End If
    End Sub

    Private Sub LimparCampos()
        user_nome.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        btn_salvar.Text = "Cadastrar"
        idSelecionado = -1
        user_nome.Focus()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Select Case CargoUsuario
            Case "administrador"
                Dim f As New menu_admin()
                f.Show()
            Case "recepcionista"
                Dim f As New menu_rec()
                f.Show()
            Case "auxiliar de serviços gerais"
                Dim f As New menu_sg()
                f.Show()
            Case Else
                MessageBox.Show("Cargo do usuário não reconhecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        Me.Close()
    End Sub
End Class

