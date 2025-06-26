Imports MySql.Data.MySqlClient

Public Class senha

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_email.Text = "" Or txt_cpf.Text = "" Or txt_confirmaSenha.Text = "" Or txt_confirmaSenha.Text = "" Then
            MsgBox("Preencha todos os campos.", MsgBoxStyle.Exclamation)
            Return
        End If

        If txt_confirmaSenha.Text <> txt_confirmaSenha.Text Then
            MsgBox("As senhas não coincidem.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim sqlVerifica As String = "SELECT * FROM usuarios WHERE email=@e AND cpf=@c"
        Dim cmd As New MySqlCommand(sqlVerifica, db)
        cmd.Parameters.AddWithValue("@e", txt_email.Text.Trim())
        cmd.Parameters.AddWithValue("@c", txt_cpf.Text.Trim())

        Dim leitor As MySqlDataReader = cmd.ExecuteReader()
        If leitor.HasRows Then
            leitor.Close()
            Dim sqlAtualizaSenha As String = "UPDATE usuarios SET senha=@s WHERE email=@e AND cpf=@c"
            cmd = New MySqlCommand(sqlAtualizaSenha, db)
            cmd.Parameters.AddWithValue("@s", txt_confirmaSenha.Text)
            cmd.Parameters.AddWithValue("@e", txt_email.Text.Trim())
            cmd.Parameters.AddWithValue("@c", txt_cpf.Text.Trim())
            cmd.ExecuteNonQuery()

            MsgBox("Senha atualizada com sucesso!", MsgBoxStyle.Information)
        Else
            leitor.Close()
            MsgBox("Usuário não encontrado. Verifique os dados.", MsgBoxStyle.Critical)
        End If
    End Sub
    Private senhaVisivel As Boolean = False

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If senhaVisivel Then
            txt_novaSenha.UseSystemPasswordChar = True
            btn_visualizar.Text = "👁️"
        Else
            txt_novaSenha.UseSystemPasswordChar = False
            btn_visualizar.Text = "🙈"
        End If
        senhaVisivel = Not senhaVisivel
    End Sub

    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs) Handles btn_visualizar.Click
        If senhaVisivel Then
            txt_confirmaSenha.UseSystemPasswordChar = True
            btn_visualizar.Text = "👁️"
        Else
            txt_confirmaSenha.UseSystemPasswordChar = False
            btn_visualizar.Text = "🙈"
        End If
        senhaVisivel = Not senhaVisivel
    End Sub
End Class