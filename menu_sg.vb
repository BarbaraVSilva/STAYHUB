Imports MySql.Data.MySqlClient

Public Class menu_sg
    Private Sub Guna2CircleButton6_Click(sender As Object, e As EventArgs)
        Dim confirmar = MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If confirmar = MsgBoxResult.Yes Then
            Application.Restart() ' Ou use: Me.Close() e chamar a tela de login novamente
        End If
    End Sub


    Private Sub CarregarFinanceiro()
        Dim sql As String = "SELECT SUM(valor) FROM financeiro WHERE MONTH(data)=MONTH(CURRENT_DATE())"
        Dim cmd As New MySqlCommand(sql, db)
        Dim total As Object = cmd.ExecuteScalar()

        lbl_financeiro.Text = "R$" & If(IsDBNull(total), "0,00", Convert.ToDecimal(total).ToString("N2"))
    End Sub

    Private Sub CarregarLimpeza()
        Dim sql As String = "SELECT COUNT(*) FROM tarefas_limpeza WHERE status='Concluída'"
        Dim cmd As New MySqlCommand(sql, db)
        Dim qtd As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        lbl_limpeza.Text = qtd.ToString()
    End Sub

    Private Sub CarregarReservas()
        Dim sql As String = "SELECT COUNT(*) FROM reservas WHERE data_entrada >= CURDATE()"
        Dim cmd As New MySqlCommand(sql, db)
        Dim qtd As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        lbl_reservas.Text = qtd.ToString()
    End Sub

    Private Sub CarregarEstoque()
        Dim sql As String = "SELECT COUNT(*) FROM estoque WHERE quantidade <= quantidade_minima"
        Dim cmd As New MySqlCommand(sql, db)
        Dim qtd As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        lbl_estoque.Text = qtd.ToString()
    End Sub

    Private Sub btn_financeiro_Click(sender As Object, e As EventArgs)
        financeiro.Show()
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs)
        Estoque.Show()
    End Sub

    Private Sub btn_reservas_Click(sender As Object, e As EventArgs)
        reservas.Show()
    End Sub

    Private Sub btn_equipe_Click(sender As Object, e As EventArgs)
        usuarios.Show()
    End Sub

    Private Sub btn_hospedes_Click(sender As Object, e As EventArgs)
        hospedes.Show()
    End Sub

    Private Sub menu_sg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = nomeUsuarioLogado
        CarregarFinanceiro()
        CarregarLimpeza()
        CarregarReservas()
        CarregarEstoque()
    End Sub

End Class