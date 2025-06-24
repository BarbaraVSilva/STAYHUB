Imports MySql.Data.MySqlClient

Module Module1
    Public connectionString As String = "Server=localhost;Port=3307;Database=stayhub;Uid=root;Pwd=usbw;"
    Public db As MySqlConnection

    Sub ConectaBanco()
        Try
            db = New MySqlConnection(connectionString)
            db.Open()
            MsgBox("Conexão bem-sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As MySqlException
            MsgBox($"Erro ao conectar: {ex.Message}", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub LimparCadastro()
        Try
            With usuarios
                .user_cpf.Clear()
                .user_nome.Clear()
                .user_data.Clear()
                .user_rg.Clear()
                .user_email.Clear()
                .user_end.Clear()
                .user_comp.Clear()
                .user_cel.Clear()
                .user_senha.Clear()
                .cmb_cargo.SelectedIndex = -1 ' Limpa a seleção da ComboBox
                .user_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar campos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
