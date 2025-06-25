Imports MySql.Data.MySqlClient

Public Class senha
    Private Sub btn_redefinir_Click(sender As Object, e As EventArgs) Handles btn_redefinir.Click
        Dim email As String = txt_email.Text.Trim()
        Dim cpf As String = txt_cpf.Text.Trim()
        Dim novaSenha As String = txt_novasenha.Text
        Dim confirmarSenha As String = txt_conf.Text

        If email = "" Or cpf = "" Or novaSenha = "" Or confirmarSenha = "" Then
            MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If novaSenha <> confirmarSenha Then
            MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Conexão com o banco
        Dim connString As String = "Server=localhost;Port=3307;Database=stayhub;Uid=root;Pwd=usbw;"
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Verifica se o usuário existe
                Dim verificaCmd As New MySqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Email=@Email AND CPF=@CPF", conn)
                verificaCmd.Parameters.AddWithValue("@Email", email)
                verificaCmd.Parameters.AddWithValue("@CPF", cpf)

                Dim existe As Integer = Convert.ToInt32(verificaCmd.ExecuteScalar())
                If existe = 0 Then
                    MessageBox.Show("E-mail ou CPF incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Atualiza a senha
                Dim updateCmd As New MySqlCommand("UPDATE Usuarios SET Senha=@NovaSenha WHERE Email=@Email AND CPF=@CPF", conn)
                updateCmd.Parameters.AddWithValue("@NovaSenha", novaSenha)
                updateCmd.Parameters.AddWithValue("@Email", email)
                updateCmd.Parameters.AddWithValue("@CPF", cpf)

                updateCmd.ExecuteNonQuery()
                MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                login.Show()

            Catch ex As Exception
                MessageBox.Show("Erro ao redefinir senha: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class