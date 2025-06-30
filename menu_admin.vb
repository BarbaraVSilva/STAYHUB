Imports MySql.Data.MySqlClient

Public Class menu_admin

    Private Sub Guna2CircleButton6_Click(sender As Object, e As EventArgs)
        Dim confirmar = MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If confirmar = MsgBoxResult.Yes Then
            Application.Restart ' Ou use: Me.Close() e chamar a tela de login novamente
        End If
    End Sub


    Private Sub CarregarFinanceiro()
        Try
            ' Total de entradas no mês atual
            Dim cmdEntrada As New MySqlCommand("SELECT SUM(valor) FROM financeiro_entrada WHERE MONTH(data) = MONTH(CURRENT_DATE()) AND YEAR(data) = YEAR(CURRENT_DATE())", db)
            Dim totalEntrada As Object = cmdEntrada.ExecuteScalar()

            ' Total de saídas no mês atual
            Dim cmdSaida As New MySqlCommand("SELECT SUM(valor) FROM financeiro_saida WHERE MONTH(data) = MONTH(CURRENT_DATE()) AND YEAR(data) = YEAR(CURRENT_DATE())", db)
            Dim totalSaida As Object = cmdSaida.ExecuteScalar()

            Dim entradaDecimal As Decimal = If(IsDBNull(totalEntrada) OrElse totalEntrada Is Nothing, 0, Convert.ToDecimal(totalEntrada))
            Dim saidaDecimal As Decimal = If(IsDBNull(totalSaida) OrElse totalSaida Is Nothing, 0, Convert.ToDecimal(totalSaida))

            Dim saldo As Decimal = entradaDecimal - saidaDecimal

            lbl_financeiro.Text = "R$ " & saldo.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar total financeiro: " & ex.Message)
        End Try
    End Sub

    Private Sub CarregarLimpeza()
        Dim sql As String = "SELECT COUNT(*) FROM quartos WHERE status_limpeza='Concluída'"
        Dim cmd As New MySqlCommand(sql, db)
        Dim qtd As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        lbl_limpeza.Text = qtd.ToString()
    End Sub

    Private Sub CarregarReservas()
        Dim sql As String = "SELECT COUNT(*) FROM quartos WHERE status_reserva='Ocupado' and created_at = CURDATE()"
        Dim cmd As New MySqlCommand(sql, db)
        Dim qtd As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        lbl_reservas.Text = qtd.ToString()
    End Sub

    Private Sub CarregarEstoque()
        Dim sql As String = "SELECT SUM(quantidade) FROM produtos"
        Dim cmd As New MySqlCommand(sql, db)
        Dim qtd As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        lbl_estoque.Text = qtd.ToString()
    End Sub

    Private Sub btn_financeiro_Click(sender As Object, e As EventArgs) Handles btn_financeiro.Click
        financeiro.Show()
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        Estoque.Show()
    End Sub

    Private Sub btn_reservas_Click(sender As Object, e As EventArgs) Handles btn_reservas.Click
        reservas.Show()
    End Sub

    Private Sub btn_equipe_Click(sender As Object, e As EventArgs) Handles btn_equipe.Click
        usuarios.Show()
    End Sub

    Private Sub btn_hospedes_Click(sender As Object, e As EventArgs) Handles btn_hospedes.Click
        hospedes.Show()
    End Sub


    Private Sub menu_admin_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        If db Is Nothing OrElse db.State <> ConnectionState.Open Then
            ConectaBanco(True)
        End If

        lbl_nome.Text = NomeUsuario
        CarregarFinanceiro()
        CarregarLimpeza()
        CarregarReservas()
        CarregarEstoque()
    End Sub

    Private Sub Guna2CircleButton6_Click_1(sender As Object, e As EventArgs) Handles Guna2CircleButton6.Click
        Dim resultado As DialogResult = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo)

        If resultado = DialogResult.Yes Then
            Me.Close() ' Fecha o formulário atual
        End If
    End Sub

    Private Sub Guna2CircleButton5_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton5.Click
        Estoque.Show()
    End Sub

    Private Sub Guna2CircleButton4_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton4.Click
        reservas.Show()
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        reservas.Show()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        financeiro.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        quartos.Show()
    End Sub

    Private Sub lbl_financeiro_Click(sender As Object, e As EventArgs) Handles lbl_financeiro.Click

    End Sub
End Class