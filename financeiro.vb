Imports MySql.Data.MySqlClient
Imports System.Data

Public Class financeiro
    Private editIndexEntrada As Integer = -1
    Private editIndexSaida As Integer = -1

    Private Sub financeiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CriarTabelasSeNecessario()
        CarregarDadosEntrada()
        CarregarDadosSaida()
    End Sub

    ' CRIAÇÃO DAS TABELAS
    Private Sub CriarTabelasSeNecessario()
        Try
            ConectaBanco()
            Dim cmd As New MySqlCommand()
            cmd.Connection = db

            ' Cria tabela de entradas
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS financeiro_entrada (" &
                              "id INT AUTO_INCREMENT PRIMARY KEY," &
                              "data DATE," &
                              "hospede VARCHAR(100)," &
                              "quarto VARCHAR(10)," &
                              "valor DECIMAL(10,2)," &
                              "forma_pagamento VARCHAR(50))"
            cmd.ExecuteNonQuery()

            ' Cria tabela de saídas
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS financeiro_saida (" &
                              "id INT AUTO_INCREMENT PRIMARY KEY," &
                              "data DATE," &
                              "descricao VARCHAR(200)," &
                              "valor DECIMAL(10,2))"
            cmd.ExecuteNonQuery()

            db.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao criar tabelas: " & ex.Message)
        End Try
    End Sub

    ' SALVAR ENTRADA
    Private Sub btnSalvarEntrada_Click(sender As Object, e As EventArgs) Handles btnSalvarEntrada.Click
        If ValidarCamposEntrada() Then
            Try
                ConectaBanco()
                Dim cmd As New MySqlCommand()
                cmd.Connection = db

                If editIndexEntrada = -1 Then
                    cmd.CommandText = "INSERT INTO financeiro_entrada (data, hospede, quarto, valor, forma_pagamento) VALUES (@data, @hospede, @quarto, @valor, @forma)"
                Else
                    cmd.CommandText = "UPDATE financeiro_entrada SET data=@data, hospede=@hospede, quarto=@quarto, valor=@valor, forma_pagamento=@forma WHERE id=@id"
                    cmd.Parameters.AddWithValue("@id", editIndexEntrada)
                End If

                cmd.Parameters.AddWithValue("@data", dtpDataEntrada.Value.Date)
                cmd.Parameters.AddWithValue("@hospede", txtHospede.Text.Trim())
                cmd.Parameters.AddWithValue("@quarto", txtQuarto.Text.Trim())
                cmd.Parameters.AddWithValue("@valor", Decimal.Parse(txtValorEntrada.Text))
                cmd.Parameters.AddWithValue("@forma", cmbFormaPagamento.Text)

                cmd.ExecuteNonQuery()
                db.Close()

                LimparCamposEntrada()
                CarregarDadosEntrada()
                MessageBox.Show("Entrada salva com sucesso!")
            Catch ex As Exception
                MessageBox.Show("Erro ao salvar entrada: " & ex.Message)
            End Try
        End If
    End Sub

    Private Function ValidarCamposEntrada() As Boolean
        If txtHospede.Text.Trim() = "" OrElse txtQuarto.Text.Trim() = "" OrElse txtValorEntrada.Text.Trim() = "" OrElse cmbFormaPagamento.SelectedIndex = -1 Then
            MessageBox.Show("Preencha todos os campos da entrada.")
            Return False
        End If
        Return True
    End Function

    ' SALVAR SAÍDA
    Private Sub btnSalvarSaida_Click(sender As Object, e As EventArgs) Handles btnSalvarSaida.Click
        If ValidarCamposSaida() Then
            Try
                ConectaBanco()
                Dim cmd As New MySqlCommand()
                cmd.Connection = db

                If editIndexSaida = -1 Then
                    cmd.CommandText = "INSERT INTO financeiro_saida (data, descricao, valor) VALUES (@data, @descricao, @valor)"
                Else
                    cmd.CommandText = "UPDATE financeiro_saida SET data=@data, descricao=@descricao, valor=@valor WHERE id=@id"
                    cmd.Parameters.AddWithValue("@id", editIndexSaida)
                End If

                cmd.Parameters.AddWithValue("@data", dtpDataSaida.Value.Date)
                cmd.Parameters.AddWithValue("@descricao", txtDescricaoSaida.Text.Trim())
                cmd.Parameters.AddWithValue("@valor", Decimal.Parse(txtValorSaida.Text))

                cmd.ExecuteNonQuery()
                db.Close()

                LimparCamposSaida()
                CarregarDadosSaida()
                MessageBox.Show("Saída salva com sucesso!")
            Catch ex As Exception
                MessageBox.Show("Erro ao salvar saída: " & ex.Message)
            End Try
        End If
    End Sub

    Private Function ValidarCamposSaida() As Boolean
        If txtDescricaoSaida.Text.Trim() = "" OrElse txtValorSaida.Text.Trim() = "" Then
            MessageBox.Show("Preencha todos os campos da saída.")
            Return False
        End If
        Return True
    End Function

    ' CARREGAR DADOS
    Private Sub CarregarDadosEntrada()
        Try
            ConectaBanco()
            Dim cmd As New MySqlCommand("SELECT * FROM financeiro_entrada ORDER BY data DESC", db)
            Dim dt As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
            dgvEntrada.DataSource = dt
            db.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados de entrada: " & ex.Message)
        End Try
    End Sub

    Private Sub CarregarDadosSaida()
        Try
            ConectaBanco()
            Dim cmd As New MySqlCommand("SELECT * FROM financeiro_saida ORDER BY data DESC", db)
            Dim dt As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
            dgvSaida.DataSource = dt
            db.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados de saída: " & ex.Message)
        End Try
    End Sub

    ' LIMPAR CAMPOS
    Private Sub LimparCamposEntrada()
        txtHospede.Clear()
        txtQuarto.Clear()
        txtValorEntrada.Clear()
        cmbFormaPagamento.SelectedIndex = -1
        dtpDataEntrada.Value = Today
        editIndexEntrada = -1
        btnSalvarEntrada.Text = "Salvar"
    End Sub

    Private Sub LimparCamposSaida()
        txtDescricaoSaida.Clear()
        txtValorSaida.Clear()
        dtpDataSaida.Value = Today
        editIndexSaida = -1
        btnSalvarSaida.Text = "Salvar"
    End Sub

    ' PESQUISAS
    Private Sub btnPesquisarEntrada_Click(sender As Object, e As EventArgs) Handles btnPesquisarEntrada.Click
        Try
            ConectaBanco()
            Dim cmd As New MySqlCommand("SELECT * FROM financeiro_entrada WHERE data = @data", db)
            cmd.Parameters.AddWithValue("@data", dtpPesquisaEntrada.Value.Date)
            Dim dt As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
            dgvEntrada.DataSource = dt
            db.Close()
        Catch ex As Exception
            MessageBox.Show("Erro na pesquisa de entrada: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPesquisarSaida_Click(sender As Object, e As EventArgs) Handles btnPesquisarSaida.Click
        Try
            ConectaBanco()
            Dim cmd As New MySqlCommand("SELECT * FROM financeiro_saida WHERE data = @data", db)
            cmd.Parameters.AddWithValue("@data", dtpPesquisaSaida.Value.Date)
            Dim dt As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
            dgvSaida.DataSource = dt
            db.Close()
        Catch ex As Exception
            MessageBox.Show("Erro na pesquisa de saída: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLimparEntrada_Click(sender As Object, e As EventArgs) Handles btnLimparEntrada.Click
        LimparCamposEntrada()
    End Sub

    Private Sub btnLimparSaida_Click(sender As Object, e As EventArgs) Handles btnLimparSaida.Click
        LimparCamposSaida()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class
