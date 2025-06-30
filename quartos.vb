Imports MySql.Data.MySqlClient

Public Class quartos
    Dim conexao As MySqlConnection
    Private Sub quartos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        CarregarQuarto(db)
        ConfigurarDataGridView(dgv_quartos)
    End Sub

    Private Sub CarregarQuarto(conexao As MySqlConnection)
        If conexao Is Nothing OrElse conexao.State <> ConnectionState.Open Then
            MsgBox("A conexão com o banco de dados não está aberta.", MsgBoxStyle.Critical)
            Return
        End If

        Dim sql As String = "SELECT id, numero, tipo, preco, numero_camas, capacidade, status_reserva FROM quartos"
        Dim comando As New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()

        dgv_quartos.Rows.Clear()
        If dgv_quartos.Columns.Count < 9 Then
            Dim editarColuna As New DataGridViewButtonColumn()
            editarColuna.Name = "editar"
            editarColuna.HeaderText = "Editar"
            editarColuna.Text = "✏️"
            editarColuna.UseColumnTextForButtonValue = True
            dgv_quartos.Columns.Add(editarColuna)

            Dim excluirColuna As New DataGridViewButtonColumn()
            excluirColuna.Name = "excluir"
            excluirColuna.HeaderText = "Excluir"
            excluirColuna.Text = "❌"
            excluirColuna.UseColumnTextForButtonValue = True
            dgv_quartos.Columns.Add(excluirColuna)
        End If


        Dim cont As Integer = 0

        While leitor.Read()
            cont += 1
            dgv_quartos.Rows.Add(cont, leitor("numero"), leitor("tipo"), leitor("preco"), leitor("numero_camas"), leitor("capacidade"), leitor("status_reserva"))
        End While

        leitor.Close()
    End Sub
    Private Sub LimparCampos()
        txt_num.Clear()
        txt_tipo.Clear()
        txt_preco.Clear()
        num_camas.Clear()
        txt_capacidade.Clear()
        txt_num.Focus()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Dim sqlBusca As String = "SELECT * FROM quartos WHERE numero = @numero"
        Dim comando As New MySqlCommand(sqlBusca, db)
        comando.Parameters.AddWithValue("@numero", txt_num.Text)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()

        If leitor.HasRows Then
            leitor.Close()
            Dim sqlAtualiza As String = "UPDATE quartos SET tipo=@tipo, preco=@preco, numero_camas=@camas, capacidade=@capacidade WHERE numero=@numero"
            comando = New MySqlCommand(sqlAtualiza, db)
        Else
            leitor.Close()
            Dim sqlInsere As String = "INSERT INTO quartos (numero, tipo, preco, numero_camas, capacidade, status_limpeza, status_reserva) VALUES (@numero, @tipo, @preco, @camas, @capacidade, @limpeza, @reserva)"
            comando = New MySqlCommand(sqlInsere, db)
        End If

        comando.Parameters.AddWithValue("@numero", txt_num.Text)
        comando.Parameters.AddWithValue("@tipo", txt_tipo.Text)
        comando.Parameters.AddWithValue("@preco", txt_preco.Text)
        comando.Parameters.AddWithValue("@camas", num_camas.Text)
        comando.Parameters.AddWithValue("@capacidade", txt_capacidade.Text)
        comando.Parameters.AddWithValue("@limpeza", "Concluída")
        comando.Parameters.AddWithValue("@reserva", "Livre")

        comando.ExecuteNonQuery()
        MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information)
        LimparCampos()
        CarregarQuarto(db)
    End Sub

    Private Sub dgv_quartos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_quartos.CellContentClick
        If e.RowIndex >= 0 Then
            Dim quartoSelecionado As String = dgv_quartos.Rows(e.RowIndex).Cells("numero").Value.ToString()

            ' EDITAR
            If dgv_quartos.Columns(e.ColumnIndex).Name = "editar" Then
                Dim sql As String = "SELECT * FROM quartos WHERE numero = @numero"
                Dim comando As New MySqlCommand(sql, db)
                comando.Parameters.AddWithValue("@numero", quartoSelecionado)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()

                If leitor.Read() Then
                    txt_num.Text = leitor("numero").ToString()
                    txt_tipo.Text = leitor("tipo").ToString()
                    txt_preco.Text = leitor("preco").ToString()
                    num_camas.Text = leitor("numero_camas").ToString()
                    txt_capacidade.Text = leitor("capacidade").ToString()
                End If
                leitor.Close()
                TabControl1.SelectedTab = TabPage1

            ElseIf dgv_quartos.Columns(e.ColumnIndex).Name = "excluir" Then
                Dim confirmar = MsgBox("Deseja excluir este quarto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
                If confirmar = MsgBoxResult.Yes Then
                    Dim sqlDel As String = "DELETE FROM quartos WHERE numero = @numero"
                    Dim comando As New MySqlCommand(sqlDel, db)
                    comando.Parameters.AddWithValue("@numero", quartoSelecionado)
                    comando.ExecuteNonQuery()
                    MsgBox("Quarto excluído com sucesso!", MsgBoxStyle.Information)
                    CarregarQuarto(db)
                End If
            End If
        End If
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
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