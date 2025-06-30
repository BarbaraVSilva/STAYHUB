Imports MySql.Data.MySqlClient

Module Module1
    Public connectionString As String = "Server=localhost;Port=3307;Database=stayhub;Uid=root;Pwd=usbw;"
    Public db As MySqlConnection
    Public nomeUsuarioLogado As String
    Public NomeUsuario As String
    Public CargoUsuario As String


    Sub ConectaBanco(Optional exibirMensagem As Boolean = False)
        Try
            db = New MySqlConnection(connectionString)
            db.Open()

            If exibirMensagem Then
                MsgBox("Conexão bem-sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            End If
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
                .cmb_cargo.SelectedIndex = -1
                .user_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar campos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub ConfigurarDataGridView(grid As DataGridView)
        With grid
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
        End With
    End Sub
End Module


