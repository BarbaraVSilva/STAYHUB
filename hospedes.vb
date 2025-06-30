Imports MySql.Data.MySqlClient

Public Class hospedes
    Private Sub hospedes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        CarregarHospedes(db)
        ConfigurarDataGridView(dgvHospedes)
    End Sub

    Private Sub CarregarHospedes(conexao As MySqlConnection)
        If conexao Is Nothing OrElse conexao.State <> ConnectionState.Open Then
            MsgBox("A conexão com o banco de dados não está aberta.", MsgBoxStyle.Critical)
            Return
        End If

        Dim sql As String = "SELECT nome, cpf, rg, endereco, complemento, email, celular, data_nascimento, genero FROM hospedes"
        Dim comando As New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()

        dgvHospedes.Rows.Clear()
        If dgvHospedes.Columns.Count < 11 Then
            dgvHospedes.Columns.Clear()
            dgvHospedes.Columns.Add("colIndex", "#")
            dgvHospedes.Columns.Add("nome", "Nome")
            dgvHospedes.Columns.Add("email", "Email")
            dgvHospedes.Columns.Add("cpf", "CPF")
            dgvHospedes.Columns.Add("rg", "RG")
            dgvHospedes.Columns.Add("endereco", "Endereço")
            dgvHospedes.Columns.Add("complemento", "Complemento")
            dgvHospedes.Columns.Add("celular", "Celular")
            dgvHospedes.Columns.Add("genero", "Gênero")

            Dim editarColuna As New DataGridViewButtonColumn()
            editarColuna.Name = "editar"
            editarColuna.HeaderText = "Editar"
            editarColuna.Text = "✏️"
            editarColuna.UseColumnTextForButtonValue = True
            dgvHospedes.Columns.Add(editarColuna)

            Dim excluirColuna As New DataGridViewButtonColumn()
            excluirColuna.Name = "excluir"
            excluirColuna.HeaderText = "Excluir"
            excluirColuna.Text = "❌"
            excluirColuna.UseColumnTextForButtonValue = True
            dgvHospedes.Columns.Add(excluirColuna)
        End If

        Dim cont As Integer = 0
        While leitor.Read()
            cont += 1
            dgvHospedes.Rows.Add(cont, leitor("nome"), leitor("email"), leitor("cpf"), leitor("rg"), leitor("endereco"), leitor("complemento"), leitor("celular"), leitor("genero"))
        End While

        leitor.Close()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        If ValidarCampos() Then
            CadastrarHospede()
            LimparCampos()
            CarregarHospedes(db)
        End If
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(NomeCompleto.Text) Then
            MessageBox.Show("O campo 'Nome Completo' é obrigatório.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtCPF.Text) Then
            MessageBox.Show("O campo 'CPF' é obrigatório.")
            Return False
        End If
        Return True
    End Function

    Private Sub CadastrarHospede()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim command As New MySqlCommand("INSERT INTO hospedes (nome, cpf, rg, endereco, complemento, email, celular, data_nascimento, genero) VALUES (@NomeCompleto, @CPF, @RG, @Endereco, @Complemento, @Email, @Celular, @DataNascimento, @Genero)", connection)

            command.Parameters.AddWithValue("@NomeCompleto", NomeCompleto.Text)
            command.Parameters.AddWithValue("@CPF", txtCPF.Text)
            command.Parameters.AddWithValue("@RG", txtRG.Text)
            command.Parameters.AddWithValue("@Endereco", txtEndereco.Text)
            command.Parameters.AddWithValue("@Complemento", txtComplemento.Text)
            command.Parameters.AddWithValue("@Email", txtEmail.Text)
            command.Parameters.AddWithValue("@Celular", txtCelular.Text)
            command.Parameters.AddWithValue("@DataNascimento", data_nasc.Text)
            command.Parameters.AddWithValue("@Genero", cmbGenero.SelectedItem)

            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub LimparCampos()
        NomeCompleto.Clear()
        txtCPF.Clear()
        txtRG.Clear()
        txtEndereco.Clear()
        txtEmail.Clear()
        txtComplemento.Clear()
        txtCelular.Clear()
        data_nasc.Clear()
        cmbGenero.SelectedIndex = -1
    End Sub

    Private Sub dgvHospedes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHospedes.CellContentClick
        If e.RowIndex >= 0 Then
            Dim cpfSelecionado As String = dgvHospedes.Rows(e.RowIndex).Cells("cpf").Value.ToString()

            ' EDITAR
            If dgvHospedes.Columns(e.ColumnIndex).Name = "editar" Then
                Dim sql As String = "SELECT * FROM hospedes WHERE cpf = @cpf"
                Dim comando As New MySqlCommand(sql, db)
                comando.Parameters.AddWithValue("@cpf", cpfSelecionado)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()

                If leitor.Read() Then
                    NomeCompleto.Text = leitor("nome").ToString()
                    txtCPF.Text = leitor("cpf").ToString()
                    txtRG.Text = leitor("rg").ToString()
                    txtEndereco.Text = leitor("endereco").ToString()
                    txtComplemento.Text = leitor("complemento").ToString()
                    txtEmail.Text = leitor("email").ToString()
                    txtCelular.Text = leitor("celular").ToString()
                    cmbGenero.SelectedItem = leitor("genero").ToString()
                End If
                leitor.Close()
                cad_hosp.SelectedTab = novo_hospede

                ' EXCLUIR
            ElseIf dgvHospedes.Columns(e.ColumnIndex).Name = "excluir" Then
                Dim confirmar = MsgBox("Deseja excluir este hóspede?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
                If confirmar = MsgBoxResult.Yes Then
                    Dim sqlDel As String = "DELETE FROM hospedes WHERE cpf = @cpf"
                    Dim comando As New MySqlCommand(sqlDel, db)
                    comando.Parameters.AddWithValue("@cpf", cpfSelecionado)
                    comando.ExecuteNonQuery()
                    MsgBox("Hóspede excluído com sucesso!", MsgBoxStyle.Information)
                    CarregarHospedes(db)
                End If
            End If
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Select Case CargoUsuario
            Case "administrador"
                Dim f As New menu_admin()
                f.Show()
            Case "recepcionista"
                Dim f As New menu_rec()
                f.Show()
            Case "auxiliar de serviços gerais"
                Dim f As New menu_sg() ' Substitua por menu_servicos se quiser outro menu
                f.Show()
            Case Else
                MessageBox.Show("Cargo do usuário não reconhecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
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
