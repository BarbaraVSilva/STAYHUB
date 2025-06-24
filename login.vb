Imports MySql.Data.MySqlClient

Public Class login
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim f As New senha()
        f.ShowDialog()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim usuario As String = txt_usuario.Text
        Dim senha As String = txt_senha.Text

        ' Conexão com o banco
        Dim connString As String = "Server=localhost;Port=3307;Database=stayhub;Uid=root;Pwd=usbw;"
        Using conn As New MySqlConnection(connString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT Cargo FROM Usuarios WHERE (Email=@usuario OR CPF=@usuario) AND Senha=@senha", conn)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@senha", senha)

            Dim cargo As Object = cmd.ExecuteScalar()
            If cargo IsNot Nothing Then
                Select Case cargo.ToString().ToLower()
                    Case "administrador"
                        Dim f As New menu_admin()
                        f.Show()
                    Case "recepcionista"
                        Dim f As New menu_rec()
                        f.Show()
                    Case "auxiliar de serviço geral"
                        Dim f As New menu_sg()
                        f.Show()
                End Select
                Me.Hide()
            Else
                MessageBox.Show("Usuário ou senha inválidos!")
            End If
        End Using
    End Sub
End Class