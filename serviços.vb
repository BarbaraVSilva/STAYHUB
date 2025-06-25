Imports MySql.Data.MySqlClient
﻿
Public Class Serviços
    Dim conexao As MySqlConnection
    Dim servicoId As Integer = 0
    Dim modoEdicao As Boolean = False

    Private Sub Serviços_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        CarregarServicos(db)
        ConfigurarDataGridView()
    End Sub

    Private Sub ConfigurarDataGridView()
        ' Configurar colunas do DataGridView
        dtgList.Columns.Clear()
        dtgList.Columns.Add("id", "ID")
        dtgList.Columns.Add("nome", "Nome do Serviço")
        dtgList.Columns.Add("categoria", "Categoria")
        dtgList.Columns.Add("preco", "Preço")
        dtgList.Columns.Add("descricao", "Descrição")

        ' Adicionar colunas de ação
        Dim editarColuna As New DataGridViewButtonColumn()
        editarColuna.Name = "editar"
        editarColuna.HeaderText = "Editar"
        editarColuna.Text = "✏️"
        editarColuna.UseColumnTextForButtonValue = True
        dtgList.Columns.Add(editarColuna)

        Dim excluirColuna As New DataGridViewButtonColumn()
        excluirColuna.Name = "excluir"
        excluirColuna.HeaderText = "Excluir"
        excluirColuna.Text = "❌"
        excluirColuna.UseColumnTextForButtonValue = True
        dtgList.Columns.Add(excluirColuna)

        ' Configurar propriedades do DataGridView
        dtgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgList.AllowUserToAddRows = False
        dtgList.ReadOnly = True
        dtgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub CarregarServicos(conexao As MySqlConnection)
        If conexao Is Nothing OrElse conexao.State <> ConnectionState.Open Then
            MsgBox("A conexão com o banco de dados não está aberta.", MsgBoxStyle.Critical)
            Return
        End If

        Try
            ' Criar tabela de serviços se não existir
            CriarTabelaServicos(conexao)

            Dim sql As String = "SELECT id, nome, categoria, preco, descricao FROM servicos ORDER BY nome"
            Dim comando As New MySqlCommand(sql, conexao)
            Dim leitor As MySqlDataReader = comando.ExecuteReader()

            dtgList.Rows.Clear()

            While leitor.Read()
                dtgList.Rows.Add(
                    leitor("id"),
                    leitor("nome"),
                    leitor("categoria"),
                    "R$ " & Format(Convert.ToDecimal(leitor("preco")), "0.00"),
                    leitor("descricao")
                )
            End While

            leitor.Close()

        Catch ex As Exception
            MsgBox("Erro ao carregar serviços: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CriarTabelaServicos(conexao As MySqlConnection)
        Try
            Dim sql As String = "
                CREATE TABLE IF NOT EXISTS servicos (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    nome VARCHAR(100) NOT NULL,
                    categoria VARCHAR(50),
                    preco DECIMAL(10,2) NOT NULL,
                    descricao TEXT,
                    data_criacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                    data_atualizacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
                )"
            Dim comando As New MySqlCommand(sql, conexao)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao criar tabela de serviços: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LimparCampos()
        txtName.Clear()
        txtPrice.Clear()
        TextBox1.Clear() ' Campo categoria
        servicoId = 0
        modoEdicao = False
        txtName.Focus()
    End Sub

    Private Sub SalvarServico()
        Try
            ' Validações
            If String.IsNullOrWhiteSpace(txtName.Text) Then
                MsgBox("Por favor, informe o nome do serviço.", MsgBoxStyle.Information)
                txtName.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtPrice.Text) Then
                MsgBox("Por favor, informe o preço do serviço.", MsgBoxStyle.Information)
                txtPrice.Focus()
                Return
            End If

            Dim preco As Decimal
            Dim textoPreco As String = txtPrice.Text.Replace(",", ".")
            If Not Decimal.TryParse(textoPreco, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, preco) Then
                MsgBox("Por favor, informe um preço válido.", MsgBoxStyle.Critical)
                txtPrice.Focus()
                Return
            End If

            If modoEdicao Then
                ' Atualizar serviço existente
                Dim sql As String = "UPDATE servicos SET nome=@nome, categoria=@categoria, preco=@preco, descricao=@descricao WHERE id=@id"
                Dim comando As New MySqlCommand(sql, db)
                comando.Parameters.AddWithValue("@nome", txtName.Text.Trim())
                comando.Parameters.AddWithValue("@categoria", TextBox1.Text.Trim())
                comando.Parameters.AddWithValue("@preco", preco)
                comando.Parameters.AddWithValue("@descricao", If(String.IsNullOrWhiteSpace(TextBox1.Text), "", TextBox1.Text.Trim()))
                comando.Parameters.AddWithValue("@id", servicoId)
                comando.ExecuteNonQuery()
                MsgBox("Serviço atualizado com sucesso!", MsgBoxStyle.Information)
            Else
                ' Inserir novo serviço
                Dim sql As String = "INSERT INTO servicos (nome, categoria, preco, descricao) VALUES (@nome, @categoria, @preco, @descricao)"
                Dim comando As New MySqlCommand(sql, db)
                comando.Parameters.AddWithValue("@nome", txtName.Text.Trim())
                comando.Parameters.AddWithValue("@categoria", TextBox1.Text.Trim())
                comando.Parameters.AddWithValue("@preco", preco)
                comando.Parameters.AddWithValue("@descricao", If(String.IsNullOrWhiteSpace(TextBox1.Text), "", TextBox1.Text.Trim()))
                comando.ExecuteNonQuery()
                MsgBox("Serviço cadastrado com sucesso!", MsgBoxStyle.Information)
            End If

            CarregarServicos(db)
            LimparCampos()

        Catch ex As Exception
            MsgBox("Erro ao salvar serviço: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dtgList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgList.CellContentClick
        If e.RowIndex >= 0 Then
            Dim idSelecionado As Integer = Convert.ToInt32(dtgList.Rows(e.RowIndex).Cells(0).Value)

            ' EDITAR
            If dtgList.Columns(e.ColumnIndex).Name = "editar" Then
                CarregarServicoParaEdicao(idSelecionado)

                ' EXCLUIR
            ElseIf dtgList.Columns(e.ColumnIndex).Name = "excluir" Then
                Dim confirmar = MsgBox("Deseja excluir este serviço?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
                If confirmar = MsgBoxResult.Yes Then
                    ExcluirServico(idSelecionado)
                End If
            End If
        End If
    End Sub

    Private Sub CarregarServicoParaEdicao(id As Integer)
        Try
            Dim sql As String = "SELECT * FROM servicos WHERE id = @id"
            Dim comando As New MySqlCommand(sql, db)
            comando.Parameters.AddWithValue("@id", id)
            Dim leitor As MySqlDataReader = comando.ExecuteReader()

            If leitor.Read() Then
                servicoId = Convert.ToInt32(leitor("id"))
                txtName.Text = leitor("nome").ToString()
                TextBox1.Text = leitor("categoria").ToString()
                txtPrice.Text = leitor("preco").ToString()
                modoEdicao = True
            End If
            leitor.Close()

        Catch ex As Exception
            MsgBox("Erro ao carregar serviço para edição: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ExcluirServico(id As Integer)
        Try
            Dim sql As String = "DELETE FROM servicos WHERE id = @id"
            Dim comando As New MySqlCommand(sql, db)
            comando.Parameters.AddWithValue("@id", id)
            comando.ExecuteNonQuery()
            MsgBox("Serviço excluído com sucesso!", MsgBoxStyle.Information)
            CarregarServicos(db)
        Catch ex As Exception
            MsgBox("Erro ao excluir serviço: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        BuscarServicos()
    End Sub

    Private Sub ToolStripTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ToolStripTextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BuscarServicos()
            e.Handled = True
        End If
    End Sub

    Private Sub BuscarServicos()
        Try
            Dim termoBusca As String = ToolStripTextBox1.Text.Trim()

            If String.IsNullOrWhiteSpace(termoBusca) Then
                CarregarServicos(db)
                Return
            End If

            Dim sql As String = "
                SELECT id, nome, categoria, preco, descricao 
                FROM servicos 
                WHERE nome LIKE @busca OR categoria LIKE @busca OR descricao LIKE @busca 
                ORDER BY nome"

            Dim comando As New MySqlCommand(sql, db)
            comando.Parameters.AddWithValue("@busca", "%" & termoBusca & "%")
            Dim leitor As MySqlDataReader = comando.ExecuteReader()

            dtgList.Rows.Clear()

            While leitor.Read()
                dtgList.Rows.Add(
                    leitor("id"),
                    leitor("nome"),
                    leitor("categoria"),
                    "R$ " & Format(Convert.ToDecimal(leitor("preco")), "0.00"),
                    leitor("descricao")
                )
            End While

            leitor.Close()

            If dtgList.Rows.Count = 0 Then
                MsgBox("Nenhum serviço encontrado com o termo: " & termoBusca, MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Erro ao buscar serviços: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Evento para permitir apenas números e vírgula no campo de preço
    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    ' Evento para limpar campos quando clicar em novo
    Private Sub LimparCampos_Click(sender As Object, e As EventArgs)
        LimparCampos()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        SalvarServico()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim cargo As Object = cmd.ExecuteScalar()
        If cargo IsNot Nothing Then
            Select Case cargo.ToString().ToLower()
                    Case "administrador"
                        Dim f As New menu_admin()
                        f.Show()
                    Case "recepcionista"
                        Dim f As New menu_rec()
                        f.Show()
                    Case "auxiliar de serviço geral"
                        Dim f As New menu_sg()
                        f.Show()
             End Select    
             Me.Hide()
        End If
    End Sub
End Class