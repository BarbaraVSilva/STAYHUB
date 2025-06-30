Imports MySql.Data.MySqlClient
Public Class reservas

    Dim conexao As MySqlConnection

        Private Sub reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ConectaBanco()
            dtp_checkin.Value = Date.Now
            dtp_checkout.Value = Date.Now.AddDays(1)
            CarregarTiposQuartos()
            CarregarQuartosDisponiveis()
        End Sub

        Private Sub CarregarTiposQuartos()
            Try
                Dim sql As String = "SELECT DISTINCT tipo FROM quartos"
                Dim comando As New MySqlCommand(sql, db)
                Dim leitor As MySqlDataReader = comando.ExecuteReader()
            flp_quartos.Items.Clear()

            While leitor.Read()
                flp_quartos.Items.Add(leitor("tipo").ToString())
            End While

                leitor.Close()
            Catch ex As Exception
                MsgBox("Erro ao carregar tipos de quarto: " & ex.Message)
            End Try
        End Sub

        Private Sub CarregarQuartosDisponiveis()
            If db.State <> ConnectionState.Open Then Exit Sub

            Dim dataCheckIn As String = dtp_checkin.Value.ToString("yyyy-MM-dd")
            Dim dataCheckOut As String = dtp_checkout.Value.ToString("yyyy-MM-dd")

            Dim sql As String = "
            SELECT * FROM quartos q
            WHERE q.status_reserva = 'Livre'
            AND NOT EXISTS (
                SELECT 1 FROM reservas r
                WHERE r.quarto_id = q.id
                AND (@checkin < r.checkout AND @checkout > r.checkin)
            )"

            Dim comando As New MySqlCommand(sql, db)
            comando.Parameters.AddWithValue("@checkin", dataCheckIn)
            comando.Parameters.AddWithValue("@checkout", dataCheckOut)

            Dim leitor As MySqlDataReader = comando.ExecuteReader()

            flp_quartos.Controls.Clear()

            While leitor.Read()
                Dim btn As New Button()
                btn.Text = $"Quarto {leitor("numero")} - {leitor("tipo")}"
                btn.Tag = leitor("id")
                btn.Width = 180
                btn.Height = 60
                btn.BackColor = Color.LightGreen
                AddHandler btn.Click, AddressOf SelecionarQuarto
                flp_quartos.Controls.Add(btn)
            End While

            leitor.Close()
        End Sub

        Private quartoSelecionadoId As Integer = 0

        Private Sub SelecionarQuarto(sender As Object, e As EventArgs)
            Dim botao As Button = CType(sender, Button)
            quartoSelecionadoId = CInt(botao.Tag)
            MsgBox("Quarto selecionado: " & botao.Text, MsgBoxStyle.Information)
        End Sub

        Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
            CarregarQuartosDisponiveis()
        End Sub

        Private Sub btn_reservar_Click(sender As Object, e As EventArgs) Handles btn_reservar.Click
            If quartoSelecionadoId = 0 Then
                MsgBox("Selecione um quarto antes de continuar!", MsgBoxStyle.Exclamation)
                Return
            End If

            Dim sql As String = "INSERT INTO reservas (quarto_id, checkin, checkout, status) VALUES (@quarto_id, @checkin, @checkout, 'Confirmada')"
            Dim comando As New MySqlCommand(sql, db)
            comando.Parameters.AddWithValue("@quarto_id", quartoSelecionadoId)
            comando.Parameters.AddWithValue("@checkin", dtp_checkin.Value.ToString("yyyy-MM-dd"))
            comando.Parameters.AddWithValue("@checkout", dtp_checkout.Value.ToString("yyyy-MM-dd"))

            comando.ExecuteNonQuery()

            MsgBox("Reserva registrada com sucesso!", MsgBoxStyle.Information)
            CarregarQuartosDisponiveis()
        End Sub

        Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
            Me.Close()
        End Sub
End Class