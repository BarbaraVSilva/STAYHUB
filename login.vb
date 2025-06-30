Imports MySql.Data.MySqlClient

Public Class login
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim f As New senha()
        f.ShowDialog()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim usuario As String = txt_usuario.Text.Trim()
        Dim senha As String = txt_senha.Text.Trim()

        If usuario = "" Or senha = "" Then
            MessageBox.Show("Preencha todos os campos.")
            Return
        End If

        Dim connString As String = "Server=localhost;Port=3307;Database=stayhub;Uid=root;Pwd=usbw;"
        Using conn As New MySqlConnection(connString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT nome, cargo FROM usuarios WHERE (email=@usuario OR cpf=@usuario) AND senha=@senha", conn)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@senha", senha)

            Dim leitor As MySqlDataReader = cmd.ExecuteReader()
            If leitor.Read() Then
                NomeUsuario = leitor("nome").ToString()
                CargoUsuario = leitor("cargo").ToString().ToLower()

                leitor.Close()

                Select Case CargoUsuario
                    Case "administrador"
                        Dim f As New menu_admin()
                        f.Show()
                    Case "recepcionista"
                        Dim f As New menu_rec()
                        f.Show()
                    Case "auxiliar de serviços gerais"
                        Dim f As New menu_sg() ' Substitua por menu_servicos se tiver um específico
                        f.Show()
                End Select
                Me.Hide()
            Else
                leitor.Close()
                MessageBox.Show("Usuário ou senha inválidos!")
            End If
        End Using
    End Sub

    Private senhaVisivel As Boolean = False
    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs) Handles btn_visualizar.Click
        If senhaVisivel Then
            txt_senha.UseSystemPasswordChar = True
            btn_visualizar.Text = "👁️"
        Else
            txt_senha.UseSystemPasswordChar = False
            btn_visualizar.Text = "🙈"
        End If
        senhaVisivel = Not senhaVisivel
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class