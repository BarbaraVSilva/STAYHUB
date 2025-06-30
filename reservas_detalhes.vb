Imports MySql.Data.MySqlClient

Public Class reservas_detalhes
    Private idQuarto As Integer
    Private checkin As Date
    Private checkout As Date

    Public Sub New(idQuarto As Integer, checkin As Date, checkout As Date)
        InitializeComponent()
        Me.idQuarto = idQuarto
        Me.checkin = checkin
        Me.checkout = checkout
    End Sub

    Private Sub DetalhesReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCheckIn.Text = checkin.ToShortDateString()
        txtCheckOut.Text = checkout.ToShortDateString()
        CarregarDetalhesQuarto()
        CarregarServicosExtras()
    End Sub

    Private Sub CarregarDetalhesQuarto()
        ConectaBanco()
        Dim conn = db
        Dim cmd As New MySqlCommand("SELECT * FROM quartos WHERE id=@id", conn)
        cmd.Parameters.AddWithValue("@id", idQuarto)
        Dim reader = cmd.ExecuteReader()
        If reader.Read() Then
            txt_numero.Text = reader("numero") & " - " & reader("tipo")
            txt_preco.Text = FormatCurrency(reader("preco"))
        End If
        reader.Close()
    End Sub

    Private Sub CarregarServicosExtras()
        ConectaBanco()
        Dim conn = db
        Dim cmd As New MySqlCommand("SELECT id, nome, preco FROM servicos ORDER BY nome", conn)
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            dgvServicosExtras.Rows.Add(reader("id"), reader("nome"), reader("preco"), 0, 0)
        End While
        reader.Close()
    End Sub

    Private Sub btnBuscarHospede_Click(sender As Object, e As EventArgs) Handles btnBuscarHospede.Click
        ConectaBanco()
        Dim conn = db
        Dim cmd As New MySqlCommand("SELECT * FROM hospedes WHERE cpf = @cpf", conn)
        cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim())
        Dim reader = cmd.ExecuteReader()
        If reader.Read() Then
            txtHospedeID.Text = reader("id")
            txtNome.Text = reader("nome")
            txtGenero.Text = reader("genero")
            txtCelular.Text = reader("celular")
            txtEndereco.Text = reader("endereco")
        Else
            MessageBox.Show("Hóspede não encontrado.")
        End If
        reader.Close()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        ' Calcular totais
        Dim precoBase As Decimal = Convert.ToDecimal(txt_preco.Text.Replace("R$", ""))
        Dim totalServicos As Decimal = 0

        For Each row As DataGridViewRow In dgvServicosExtras.Rows
            If row.Cells("Quantity").Value IsNot Nothing AndAlso IsNumeric(row.Cells("Quantity").Value) Then
                Dim qtd = Convert.ToInt32(row.Cells("Quantity").Value)
                Dim preco = Convert.ToDecimal(row.Cells("Price").Value)
                Dim subtotal = qtd * preco
                row.Cells("Subtotal").Value = subtotal
                totalServicos += subtotal
            End If
        Next

        Dim dias As Integer = (checkout - checkin).Days
        Dim subtotal = dias * precoBase
        Dim total = subtotal + totalServicos

        txtSubtotal.Text = FormatCurrency(subtotal)
        txtServicosExtras.Text = FormatCurrency(totalServicos)
        txtTotal.Text = FormatCurrency(total)

        ' Registrar reserva
        ConectaBanco()
        Dim conn = db
        Dim cmd As New MySqlCommand("INSERT INTO reservas (id_hospede, id_quarto, checkin, checkout, total) VALUES (@id_hospede, @id_quarto, @checkin, @checkout, @total)", conn)
        cmd.Parameters.AddWithValue("@id_hospede", txtHospedeID.Text)
        cmd.Parameters.AddWithValue("@id_quarto", idQuarto)
        cmd.Parameters.AddWithValue("@checkin", checkin)
        cmd.Parameters.AddWithValue("@checkout", checkout)
        cmd.Parameters.AddWithValue("@total", total)
        cmd.ExecuteNonQuery()

        Dim cmdQuarto As New MySqlCommand("UPDATE quartos SET status_reserva = 'Reservado' WHERE id = @id", conn)
        cmdQuarto.Parameters.AddWithValue("@id", idQuarto)
        cmdQuarto.ExecuteNonQuery()

        MessageBox.Show("Reserva registrada com sucesso!")
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Select Case CargoUsuario
            Case "administrador"
                Dim f As New menu_admin()
                f.Show()
            Case "recepcionista"
                Dim f As New menu_rec()
                f.Show()
            Case "auxiliar de serviços gerais"
                Dim f As New menu_sg()
                f.Show()
        End Select
        Me.Close()
    End Sub

End Class