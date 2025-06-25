<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class financeiro
    Inherits System.Windows.Forms.Form

    ' Limpeza de recursos
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(financeiro))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        ENTRADAS = New TabControl()
        TabEntrada = New TabPage()
        btnLimparEntrada = New Button()
        dgvEntrada = New DataGridView()
        lblDataEntrada = New Label()
        dtpDataEntrada = New DateTimePicker()
        lblHospede = New Label()
        txtHospede = New TextBox()
        lblQuarto = New Label()
        txtQuarto = New TextBox()
        lblValorEntrada = New Label()
        txtValorEntrada = New TextBox()
        lblFormaPagamento = New Label()
        cmbFormaPagamento = New ComboBox()
        btnSalvarEntrada = New Button()
        lblPesquisaEntrada = New Label()
        dtpPesquisaEntrada = New DateTimePicker()
        btnPesquisarEntrada = New Button()
        TabSaida = New TabPage()
        btnLimparSaida = New Button()
        dgvSaida = New DataGridView()
        lblDataSaida = New Label()
        dtpDataSaida = New DateTimePicker()
        lblDescricaoSaida = New Label()
        txtDescricaoSaida = New TextBox()
        lblValorSaida = New Label()
        txtValorSaida = New TextBox()
        btnSalvarSaida = New Button()
        lblPesquisaSaida = New Label()
        dtpPesquisaSaida = New DateTimePicker()
        btnPesquisarSaida = New Button()
        ToolStrip1 = New ToolStrip()
        ToolStripLabel2 = New ToolStripLabel()
        ToolStripTextBox1 = New ToolStripTextBox()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        ENTRADAS.SuspendLayout()
        TabEntrada.SuspendLayout()
        CType(dgvEntrada, ComponentModel.ISupportInitialize).BeginInit()
        TabSaida.SuspendLayout()
        CType(dgvSaida, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ENTRADAS
        ' 
        ENTRADAS.Controls.Add(TabEntrada)
        ENTRADAS.Controls.Add(TabSaida)
        ENTRADAS.Location = New Point(15, 88)
        ENTRADAS.Name = "ENTRADAS"
        ENTRADAS.SelectedIndex = 0
        ENTRADAS.Size = New Size(601, 500)
        ENTRADAS.TabIndex = 0
        ' 
        ' TabEntrada
        ' 
        TabEntrada.AccessibleDescription = ""
        TabEntrada.BackColor = Color.WhiteSmoke
        TabEntrada.Controls.Add(btnLimparEntrada)
        TabEntrada.Controls.Add(dgvEntrada)
        TabEntrada.Controls.Add(lblDataEntrada)
        TabEntrada.Controls.Add(dtpDataEntrada)
        TabEntrada.Controls.Add(lblHospede)
        TabEntrada.Controls.Add(txtHospede)
        TabEntrada.Controls.Add(lblQuarto)
        TabEntrada.Controls.Add(txtQuarto)
        TabEntrada.Controls.Add(lblValorEntrada)
        TabEntrada.Controls.Add(txtValorEntrada)
        TabEntrada.Controls.Add(lblFormaPagamento)
        TabEntrada.Controls.Add(cmbFormaPagamento)
        TabEntrada.Controls.Add(btnSalvarEntrada)
        TabEntrada.Controls.Add(lblPesquisaEntrada)
        TabEntrada.Controls.Add(dtpPesquisaEntrada)
        TabEntrada.Controls.Add(btnPesquisarEntrada)
        TabEntrada.ForeColor = Color.Black
        TabEntrada.Location = New Point(4, 29)
        TabEntrada.Name = "TabEntrada"
        TabEntrada.Size = New Size(593, 467)
        TabEntrada.TabIndex = 0
        TabEntrada.Text = "ENTRADAS"
        ' 
        ' btnLimparEntrada
        ' 
        btnLimparEntrada.BackColor = Color.White
        btnLimparEntrada.Location = New Point(472, 148)
        btnLimparEntrada.Name = "btnLimparEntrada"
        btnLimparEntrada.Size = New Size(108, 30)
        btnLimparEntrada.TabIndex = 15
        btnLimparEntrada.Text = "Limpar"
        btnLimparEntrada.UseVisualStyleBackColor = False
        ' 
        ' dgvEntrada
        ' 
        dgvEntrada.ColumnHeadersHeight = 29
        dgvEntrada.Location = New Point(10, 240)
        dgvEntrada.Name = "dgvEntrada"
        dgvEntrada.RowHeadersWidth = 51
        dgvEntrada.Size = New Size(570, 200)
        dgvEntrada.TabIndex = 0
        ' 
        ' lblDataEntrada
        ' 
        lblDataEntrada.Location = New Point(3, 11)
        lblDataEntrada.Name = "lblDataEntrada"
        lblDataEntrada.Size = New Size(100, 23)
        lblDataEntrada.TabIndex = 1
        lblDataEntrada.Text = "Data:"
        ' 
        ' dtpDataEntrada
        ' 
        dtpDataEntrada.Location = New Point(130, 7)
        dtpDataEntrada.Name = "dtpDataEntrada"
        dtpDataEntrada.Size = New Size(200, 27)
        dtpDataEntrada.TabIndex = 2
        ' 
        ' lblHospede
        ' 
        lblHospede.Location = New Point(3, 44)
        lblHospede.Name = "lblHospede"
        lblHospede.Size = New Size(100, 23)
        lblHospede.TabIndex = 3
        lblHospede.Text = "Hóspede:"
        ' 
        ' txtHospede
        ' 
        txtHospede.Location = New Point(130, 40)
        txtHospede.Name = "txtHospede"
        txtHospede.Size = New Size(200, 27)
        txtHospede.TabIndex = 4
        ' 
        ' lblQuarto
        ' 
        lblQuarto.Location = New Point(3, 77)
        lblQuarto.Name = "lblQuarto"
        lblQuarto.Size = New Size(100, 23)
        lblQuarto.TabIndex = 5
        lblQuarto.Text = "Quarto:"
        ' 
        ' txtQuarto
        ' 
        txtQuarto.Location = New Point(130, 73)
        txtQuarto.Name = "txtQuarto"
        txtQuarto.Size = New Size(200, 27)
        txtQuarto.TabIndex = 6
        ' 
        ' lblValorEntrada
        ' 
        lblValorEntrada.Location = New Point(3, 110)
        lblValorEntrada.Name = "lblValorEntrada"
        lblValorEntrada.Size = New Size(100, 23)
        lblValorEntrada.TabIndex = 7
        lblValorEntrada.Text = "Valor:"
        ' 
        ' txtValorEntrada
        ' 
        txtValorEntrada.Location = New Point(130, 106)
        txtValorEntrada.Name = "txtValorEntrada"
        txtValorEntrada.Size = New Size(200, 27)
        txtValorEntrada.TabIndex = 8
        ' 
        ' lblFormaPagamento
        ' 
        lblFormaPagamento.Location = New Point(3, 153)
        lblFormaPagamento.Name = "lblFormaPagamento"
        lblFormaPagamento.Size = New Size(155, 23)
        lblFormaPagamento.TabIndex = 9
        lblFormaPagamento.Text = "Forma de Pagamento:"
        ' 
        ' cmbFormaPagamento
        ' 
        cmbFormaPagamento.Location = New Point(183, 148)
        cmbFormaPagamento.Name = "cmbFormaPagamento"
        cmbFormaPagamento.Size = New Size(147, 28)
        cmbFormaPagamento.TabIndex = 10
        ' 
        ' btnSalvarEntrada
        ' 
        btnSalvarEntrada.BackColor = Color.White
        btnSalvarEntrada.Location = New Point(353, 148)
        btnSalvarEntrada.Name = "btnSalvarEntrada"
        btnSalvarEntrada.Size = New Size(108, 30)
        btnSalvarEntrada.TabIndex = 11
        btnSalvarEntrada.Text = "Salvar Entrada"
        btnSalvarEntrada.UseVisualStyleBackColor = False
        ' 
        ' lblPesquisaEntrada
        ' 
        lblPesquisaEntrada.Location = New Point(10, 200)
        lblPesquisaEntrada.Name = "lblPesquisaEntrada"
        lblPesquisaEntrada.Size = New Size(100, 23)
        lblPesquisaEntrada.TabIndex = 12
        lblPesquisaEntrada.Text = "Pesquisar por data:"
        ' 
        ' dtpPesquisaEntrada
        ' 
        dtpPesquisaEntrada.Location = New Point(130, 200)
        dtpPesquisaEntrada.Name = "dtpPesquisaEntrada"
        dtpPesquisaEntrada.Size = New Size(200, 27)
        dtpPesquisaEntrada.TabIndex = 13
        ' 
        ' btnPesquisarEntrada
        ' 
        btnPesquisarEntrada.BackColor = Color.White
        btnPesquisarEntrada.Location = New Point(366, 200)
        btnPesquisarEntrada.Name = "btnPesquisarEntrada"
        btnPesquisarEntrada.Size = New Size(108, 30)
        btnPesquisarEntrada.TabIndex = 14
        btnPesquisarEntrada.Text = "Pesquisar"
        btnPesquisarEntrada.UseVisualStyleBackColor = False
        ' 
        ' TabSaida
        ' 
        TabSaida.Controls.Add(btnLimparSaida)
        TabSaida.Controls.Add(dgvSaida)
        TabSaida.Controls.Add(lblDataSaida)
        TabSaida.Controls.Add(dtpDataSaida)
        TabSaida.Controls.Add(lblDescricaoSaida)
        TabSaida.Controls.Add(txtDescricaoSaida)
        TabSaida.Controls.Add(lblValorSaida)
        TabSaida.Controls.Add(txtValorSaida)
        TabSaida.Controls.Add(btnSalvarSaida)
        TabSaida.Controls.Add(lblPesquisaSaida)
        TabSaida.Controls.Add(dtpPesquisaSaida)
        TabSaida.Controls.Add(btnPesquisarSaida)
        TabSaida.Location = New Point(4, 29)
        TabSaida.Name = "TabSaida"
        TabSaida.Size = New Size(593, 467)
        TabSaida.TabIndex = 1
        TabSaida.Text = "SAÍDAS"
        ' 
        ' btnLimparSaida
        ' 
        btnLimparSaida.BackColor = Color.White
        btnLimparSaida.Location = New Point(471, 116)
        btnLimparSaida.Name = "btnLimparSaida"
        btnLimparSaida.Size = New Size(108, 30)
        btnLimparSaida.TabIndex = 12
        btnLimparSaida.Text = "Limpar"
        btnLimparSaida.UseVisualStyleBackColor = False
        ' 
        ' dgvSaida
        ' 
        dgvSaida.ColumnHeadersHeight = 29
        dgvSaida.Location = New Point(10, 220)
        dgvSaida.Name = "dgvSaida"
        dgvSaida.RowHeadersWidth = 51
        dgvSaida.Size = New Size(555, 232)
        dgvSaida.TabIndex = 0
        ' 
        ' lblDataSaida
        ' 
        lblDataSaida.Location = New Point(3, 10)
        lblDataSaida.Name = "lblDataSaida"
        lblDataSaida.Size = New Size(100, 23)
        lblDataSaida.TabIndex = 1
        lblDataSaida.Text = "Data:"
        ' 
        ' dtpDataSaida
        ' 
        dtpDataSaida.Location = New Point(116, 10)
        dtpDataSaida.Name = "dtpDataSaida"
        dtpDataSaida.Size = New Size(200, 27)
        dtpDataSaida.TabIndex = 2
        ' 
        ' lblDescricaoSaida
        ' 
        lblDescricaoSaida.Location = New Point(3, 64)
        lblDescricaoSaida.Name = "lblDescricaoSaida"
        lblDescricaoSaida.Size = New Size(100, 23)
        lblDescricaoSaida.TabIndex = 3
        lblDescricaoSaida.Text = "Descrição:"
        ' 
        ' txtDescricaoSaida
        ' 
        txtDescricaoSaida.Location = New Point(116, 60)
        txtDescricaoSaida.Name = "txtDescricaoSaida"
        txtDescricaoSaida.Size = New Size(200, 27)
        txtDescricaoSaida.TabIndex = 4
        ' 
        ' lblValorSaida
        ' 
        lblValorSaida.Location = New Point(3, 116)
        lblValorSaida.Name = "lblValorSaida"
        lblValorSaida.Size = New Size(100, 23)
        lblValorSaida.TabIndex = 5
        lblValorSaida.Text = "Valor:"
        ' 
        ' txtValorSaida
        ' 
        txtValorSaida.Location = New Point(116, 116)
        txtValorSaida.Name = "txtValorSaida"
        txtValorSaida.Size = New Size(200, 27)
        txtValorSaida.TabIndex = 6
        ' 
        ' btnSalvarSaida
        ' 
        btnSalvarSaida.Location = New Point(356, 116)
        btnSalvarSaida.Name = "btnSalvarSaida"
        btnSalvarSaida.Size = New Size(109, 27)
        btnSalvarSaida.TabIndex = 7
        btnSalvarSaida.Text = "Salvar"
        ' 
        ' lblPesquisaSaida
        ' 
        lblPesquisaSaida.Location = New Point(3, 167)
        lblPesquisaSaida.Name = "lblPesquisaSaida"
        lblPesquisaSaida.Size = New Size(100, 23)
        lblPesquisaSaida.TabIndex = 8
        lblPesquisaSaida.Text = "Pesquisar por data:"
        ' 
        ' dtpPesquisaSaida
        ' 
        dtpPesquisaSaida.Location = New Point(116, 167)
        dtpPesquisaSaida.Name = "dtpPesquisaSaida"
        dtpPesquisaSaida.Size = New Size(200, 27)
        dtpPesquisaSaida.TabIndex = 9
        ' 
        ' btnPesquisarSaida
        ' 
        btnPesquisarSaida.Location = New Point(356, 168)
        btnPesquisarSaida.Name = "btnPesquisarSaida"
        btnPesquisarSaida.Size = New Size(109, 28)
        btnPesquisarSaida.TabIndex = 10
        btnPesquisarSaida.Text = "Pesquisar"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.AutoSize = False
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel2, ToolStripTextBox1})
        ToolStrip1.Location = New Point(149, 26)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(463, 59)
        ToolStrip1.TabIndex = 28
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.ActiveLinkColor = Color.Transparent
        ToolStripLabel2.BackgroundImage = CType(resources.GetObject("ToolStripLabel2.BackgroundImage"), Image)
        ToolStripLabel2.BackgroundImageLayout = ImageLayout.None
        ToolStripLabel2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(0, 56)
        ToolStripLabel2.Text = "                                       "
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.BackColor = Color.WhiteSmoke
        ToolStripTextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripTextBox1.ForeColor = Color.DarkBlue
        ToolStripTextBox1.MergeAction = MergeAction.MatchOnly
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(100, 59)
        ToolStripTextBox1.Text = "FINANCEIRO"
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BackColor = Color.WhiteSmoke
        Guna2Button3.CustomizableEdges = CustomizableEdges1
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.WhiteSmoke
        Guna2Button3.Font = New Font("Segoe UI", 9F)
        Guna2Button3.ForeColor = Color.Transparent
        Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), Image)
        Guna2Button3.ImageSize = New Size(80, 80)
        Guna2Button3.Location = New Point(17, 26)
        Guna2Button3.Margin = New Padding(3, 4, 3, 4)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button3.Size = New Size(118, 52)
        Guna2Button3.TabIndex = 29
        ' 
        ' financeiro
        ' 
        ClientSize = New Size(634, 605)
        Controls.Add(Guna2Button3)
        Controls.Add(ToolStrip1)
        Controls.Add(ENTRADAS)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "financeiro"
        Text = "STAYHUB"
        ENTRADAS.ResumeLayout(False)
        TabEntrada.ResumeLayout(False)
        TabEntrada.PerformLayout()
        CType(dgvEntrada, ComponentModel.ISupportInitialize).EndInit()
        TabSaida.ResumeLayout(False)
        TabSaida.PerformLayout()
        CType(dgvSaida, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    ' Declaração dos componentes
    Private WithEvents ENTRADAS As TabControl
    Private WithEvents TabEntrada As TabPage
    Private WithEvents TabSaida As TabPage
    Private WithEvents dgvEntrada As DataGridView
    Private WithEvents lblDataEntrada As Label
    Private WithEvents dtpDataEntrada As DateTimePicker
    Private WithEvents lblHospede As Label
    Private WithEvents txtHospede As TextBox
    Private WithEvents lblQuarto As Label
    Private WithEvents txtQuarto As TextBox
    Private WithEvents lblValorEntrada As Label
    Private WithEvents txtValorEntrada As TextBox
    Private WithEvents lblFormaPagamento As Label
    Private WithEvents cmbFormaPagamento As ComboBox
    Private WithEvents btnSalvarEntrada As Button
    Private WithEvents lblPesquisaEntrada As Label
    Private WithEvents dtpPesquisaEntrada As DateTimePicker
    Private WithEvents btnPesquisarEntrada As Button

    Private WithEvents dgvSaida As DataGridView
    Private WithEvents lblDataSaida As Label
    Private WithEvents dtpDataSaida As DateTimePicker
    Private WithEvents lblDescricaoSaida As Label
    Private WithEvents txtDescricaoSaida As TextBox
    Private WithEvents lblValorSaida As Label
    Private WithEvents txtValorSaida As TextBox
    Private WithEvents btnSalvarSaida As Button
    Private WithEvents lblPesquisaSaida As Label
    Private WithEvents dtpPesquisaSaida As DateTimePicker
    Private WithEvents btnPesquisarSaida As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnLimparEntrada As Button
    Private WithEvents btnLimparSaida As Button
End Class
