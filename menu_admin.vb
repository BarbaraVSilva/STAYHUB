Public Class menu_admin
    Private Sub btn_equipe_Click(sender As Object, e As EventArgs) Handles btn_equipe.Click
        usuarios.Show()
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        Estoque.Show()
    End Sub

    Private Sub btn_financeiro_Click(sender As Object, e As EventArgs) Handles btn_financeiro.Click
        financeiro.Show()
    End Sub

    Private Sub btn_hospede_Click(sender As Object, e As EventArgs) Handles btn_hospede.Click
        hospedes.Show()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Show()
    End Sub
End Class