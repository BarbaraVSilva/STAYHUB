Imports MySql.Data.MySqlClient

Public Class usuarios
    Dim conexao As MySqlConnection

    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarCargos()
        ConectaBanco()
        CarregarUsuario(db)
    End Sub

    Private Sub CarregarUsuario(conexao As MySqlConnection)
        If conexao Is Nothing OrElse conexao.State <> ConnectionState.Open Then
            MsgBox("A conexão com o banco de dados não está aberta.", MsgBoxStyle.Critical)
            Return
        End If

        Dim sql As String = "SELECT id, nome, cpf, data_nascimento FROM usuarios"
        Dim comando As New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()

        dgv_dados.Rows.Clear()
        If dgv_dados.Columns.Count < 5 Then
            Dim editarColuna As New DataGridViewButtonColumn()
            editarColuna.Name = "editar"
            editarColuna.HeaderText = "Editar"
            editarColuna.Text = "✏️"
            editarColuna.UseColumnTextForButtonValue = True
            dgv_dados.Columns.Add(editarColuna)

            Dim excluirColuna As New DataGridViewButtonColumn()
            excluirColuna.Name = "excluir"
            excluirColuna.HeaderText = "Excluir"
            excluirColuna.Text = "❌"
            excluirColuna.UseColumnTextForButtonValue = True
            dgv_dados.Columns.Add(excluirColuna)
        End If


        Dim cont As Integer = 0

        While leitor.Read()
            cont += 1
            dgv_dados.Rows.Add(cont, leitor("nome"), leitor("cpf"))
        End While

        leitor.Close()
    End Sub

    Private Sub LimparCampos()
        Module1.LimparCadastro() ' Chama o método do módulo para limpar os campos
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            If user_cpf.Text = "" Or user_nome.Text = "" Or user_email.Text = "" Or user_senha.Text = "" Then
                MsgBox("Preencha os campos obrigatórios: Nome, CPF, E-mail e Senha.", MsgBoxStyle.Exclamation)
                Return
            End If

            Dim sqlBusca As String = "SELECT * FROM usuarios WHERE cpf = @cpf"
            Dim comando As New MySqlCommand(sqlBusca, db)
            comando.Parameters.AddWithValue("@cpf", user_cpf.Text)
            Dim leitor As MySqlDataReader = comando.ExecuteReader()

            If leitor.HasRows Then
                leitor.Close()
                Dim sqlAtualiza As String = "UPDATE usuarios SET nome=@nome, data_nascimento=@data, email=@email, rg=@rg, endereco=@endereco, complemento=@complemento, celular=@celular, cargo=@cargo, senha=@senha WHERE cpf=@cpf"
                comando = New MySqlCommand(sqlAtualiza, db)
            Else
                leitor.Close()
                Dim sqlInsere As String = "INSERT INTO usuarios (cpf, nome, data_nascimento, email, rg, endereco, complemento, celular, cargo, senha) VALUES (@cpf, @nome, @data, @email, @rg, @endereco, @complemento, @celular, @cargo, @senha)"
                comando = New MySqlCommand(sqlInsere, db)
            End If

            ' Parâmetros comuns
            comando.Parameters.AddWithValue("@cpf", user_cpf.Text)
            comando.Parameters.AddWithValue("@nome", user_nome.Text)
            comando.Parameters.AddWithValue("@data", user_data.Text)
            comando.Parameters.AddWithValue("@email", user_email.Text)
            comando.Parameters.AddWithValue("@rg", user_rg.Text)
            comando.Parameters.AddWithValue("@endereco", user_end.Text)
            comando.Parameters.AddWithValue("@complemento", user_comp.Text)
            comando.Parameters.AddWithValue("@celular", user_cel.Text)
            comando.Parameters.AddWithValue("@cargo", cmb_cargo.Text)
            comando.Parameters.AddWithValue("@senha", user_senha.Text)

            comando.ExecuteNonQuery()
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information)

            CarregarUsuario(db)
            LimparCampos()

        Catch ex As Exception
            MsgBox("Erro ao gravar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CarregarCargos()
        With Me.cmb_cargo.Items
            .Clear()
            .Add("Administrador")
            .Add("Recepcionista")
            .Add("Auxiliar de Serviços Gerais")
        End With
        Me.cmb_cargo.SelectedIndex = 0
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        If e.RowIndex >= 0 Then
            Dim cpfSelecionado As String = dgv_dados.Rows(e.RowIndex).Cells(2).Value.ToString()

            ' EDITAR
            If dgv_dados.Columns(e.ColumnIndex).Name = "editar" Then
                Dim sql As String = "SELECT * FROM usuarios WHERE cpf = @cpf"
                Dim comando As New MySqlCommand(sql, db)
                comando.Parameters.AddWithValue("@cpf", cpfSelecionado)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()

                If leitor.Read() Then
                    user_nome.Text = leitor("nome").ToString()
                    user_cpf.Text = leitor("cpf").ToString()
                    user_data.Text = leitor("data_nascimento").ToString()
                    cmb_cargo.Text = leitor("cargo").ToString()
                End If
                leitor.Close()
                TabControl1.SelectedTab = TabPage1

                ' EXCLUIR
            ElseIf dgv_dados.Columns(e.ColumnIndex).Name = "excluir" Then
                Dim confirmar = MsgBox("Deseja excluir este usuário?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
                If confirmar = MsgBoxResult.Yes Then
                    Dim sqlDel As String = "DELETE FROM usuarios WHERE cpf = @cpf"
                    Dim comando As New MySqlCommand(sqlDel, db)
                    comando.Parameters.AddWithValue("@cpf", cpfSelecionado)
                    comando.ExecuteNonQuery()
                    MsgBox("Usuário excluído com sucesso!", MsgBoxStyle.Information)
                    CarregarUsuario(db) ' Atualiza a tabela
                End If
            End If
        End If
    End Sub

    Private senhaVisivel As Boolean = False
    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs) Handles btn_visualizar.Click
        If senhaVisivel Then
            user_senha.UseSystemPasswordChar = True
            btn_visualizar.Text = "👁️"
        Else
            user_senha.UseSystemPasswordChar = False
            btn_visualizar.Text = "🙈"
        End If
        senhaVisivel = Not senhaVisivel
    End Sub
End Class