Imports MySql.Data.MySqlClient

Public Class menu_sg

    Private Sub CarregarFinanceiro()
        Dim sql As String = "SELECT SUM(valor) FROM financeiro_entrada WHERE MONTH(data)=MONTH(CURRENT_DATE())"
        Dim cmd As New MySqlCommand(sql, db)
        Dim total As Object = cmd.ExecuteScalar()

        lbl_financeiro.Text = "R$" & If(IsDBNull(total), "0,00", Convert.ToDecimal(total).ToString("N2"))
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

    Private Sub menu_sg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If db Is Nothing OrElse db.State <> ConnectionState.Open Then
            ConectaBanco(True)
        End If

        lbl_nome.Text = NomeUsuario
        CarregarFinanceiro()
        CarregarLimpeza()
        CarregarReservas()
        CarregarEstoque()
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        Estoque.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        reservas.Show()
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        reservas.Show()
    End Sub

    Private Sub Guna2CircleButton5_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton5.Click
        Estoque.Show()
    End Sub

    Private Sub Guna2CircleButton6_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton6.Click
        Dim resultado As DialogResult = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo)

        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Guna2CircleButton4_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton4.Click
        reservas.Show()
    End Sub
End Class