Imports MySql.Data.MySqlClient

Public Class login
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim f As New senha()
        Me.Hide()
        f.ShowDialog()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim usuario As String = txt_usuario.Text.Trim()
        Dim senha As String = txt_senha.Text.Trim()

        Dim connString As String = "Server=localhost;Port=3307;Database=stayhub;Uid=root;Pwd=usbw;"
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT Cargo FROM Usuarios WHERE (Email=@usuario OR CPF=@usuario) AND Senha=@senha"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@usuario", usuario)
                cmd.Parameters.AddWithValue("@senha", senha)

                Dim cargoObj As Object = cmd.ExecuteScalar()

                If cargoObj IsNot Nothing Then
                    Dim cargo As String = cargoObj.ToString()

                    Select Case cargo.ToLower()
                        Case "administrador"
                            Dim adminForm As New menu_admin()
                            adminForm.Show()
                        Case "recepcionista"
                            Dim recForm As New menu_rec()
                            recForm.Show()
                        Case "auxiliar de serviços gerais"
                            Dim sgForm As New menu_sg()
                            sgForm.Show()
                        Case Else
                            MessageBox.Show("Cargo não reconhecido.")
                            Return
                    End Select

                    Me.Hide()
                Else
                    MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class