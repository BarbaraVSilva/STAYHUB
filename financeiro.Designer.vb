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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(financeiro))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        ENTRADAS = New TabControl()
        TabEntrada = New TabPage()
        cmbFormaPagamento = New ComboBox()
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
        Label3 = New Label()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        ToolStrip1 = New ToolStrip()
        ToolStripButton2 = New ToolStripButton()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripLabel2 = New ToolStripLabel()
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
        ENTRADAS.Location = New Point(1, 49)
        ENTRADAS.Name = "ENTRADAS"
        ENTRADAS.SelectedIndex = 0
        ENTRADAS.Size = New Size(633, 555)
        ENTRADAS.TabIndex = 0
        ' 
        ' TabEntrada
        ' 
        TabEntrada.AccessibleDescription = ""
        TabEntrada.BackColor = Color.WhiteSmoke
        TabEntrada.Controls.Add(cmbFormaPagamento)
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
        TabEntrada.Controls.Add(btnSalvarEntrada)
        TabEntrada.Controls.Add(lblPesquisaEntrada)
        TabEntrada.Controls.Add(dtpPesquisaEntrada)
        TabEntrada.Controls.Add(btnPesquisarEntrada)
        TabEntrada.ForeColor = Color.Black
        TabEntrada.Location = New Point(4, 24)
        TabEntrada.Name = "TabEntrada"
        TabEntrada.Size = New Size(625, 527)
        TabEntrada.TabIndex = 0
        TabEntrada.Text = "ENTRADAS"
        ' 
        ' cmbFormaPagamento
        ' 
        cmbFormaPagamento.Items.AddRange(New Object() {"PIX", "Dinheiro", "Cartão de Crédito", "Cartão de Débito"})
        cmbFormaPagamento.Location = New Point(130, 148)
        cmbFormaPagamento.Name = "cmbFormaPagamento"
        cmbFormaPagamento.Size = New Size(200, 23)
        cmbFormaPagamento.TabIndex = 10
        ' 
        ' btnLimparEntrada
        ' 
        btnLimparEntrada.BackColor = Color.Gainsboro
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
        dgvEntrada.Size = New Size(607, 280)
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
        dtpDataEntrada.Size = New Size(200, 23)
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
        txtHospede.Size = New Size(200, 23)
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
        txtQuarto.Size = New Size(200, 23)
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
        txtValorEntrada.Size = New Size(200, 23)
        txtValorEntrada.TabIndex = 8
        ' 
        ' lblFormaPagamento
        ' 
        lblFormaPagamento.BackColor = Color.WhiteSmoke
        lblFormaPagamento.Location = New Point(3, 150)
        lblFormaPagamento.Name = "lblFormaPagamento"
        lblFormaPagamento.Size = New Size(126, 23)
        lblFormaPagamento.TabIndex = 9
        lblFormaPagamento.Text = "Forma de Pagamento:"
        ' 
        ' btnSalvarEntrada
        ' 
        btnSalvarEntrada.BackColor = Color.Gainsboro
        btnSalvarEntrada.Location = New Point(353, 148)
        btnSalvarEntrada.Name = "btnSalvarEntrada"
        btnSalvarEntrada.Size = New Size(108, 30)
        btnSalvarEntrada.TabIndex = 11
        btnSalvarEntrada.Text = "Salvar Entrada"
        btnSalvarEntrada.UseVisualStyleBackColor = False
        ' 
        ' lblPesquisaEntrada
        ' 
        lblPesquisaEntrada.Location = New Point(8, 200)
        lblPesquisaEntrada.Name = "lblPesquisaEntrada"
        lblPesquisaEntrada.Size = New Size(100, 23)
        lblPesquisaEntrada.TabIndex = 12
        lblPesquisaEntrada.Text = "Pesquisar por data:"
        ' 
        ' dtpPesquisaEntrada
        ' 
        dtpPesquisaEntrada.Location = New Point(130, 200)
        dtpPesquisaEntrada.Name = "dtpPesquisaEntrada"
        dtpPesquisaEntrada.Size = New Size(200, 23)
        dtpPesquisaEntrada.TabIndex = 13
        ' 
        ' btnPesquisarEntrada
        ' 
        btnPesquisarEntrada.BackColor = Color.Gainsboro
        btnPesquisarEntrada.Location = New Point(353, 198)
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
        TabSaida.Location = New Point(4, 24)
        TabSaida.Name = "TabSaida"
        TabSaida.Size = New Size(625, 527)
        TabSaida.TabIndex = 1
        TabSaida.Text = "SAÍDAS"
        ' 
        ' btnLimparSaida
        ' 
        btnLimparSaida.BackColor = Color.Gainsboro
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
        dtpDataSaida.Size = New Size(200, 23)
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
        txtDescricaoSaida.Size = New Size(200, 23)
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
        txtValorSaida.Size = New Size(200, 23)
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
        dtpPesquisaSaida.Size = New Size(200, 23)
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkBlue
        Label3.Location = New Point(130, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 17)
        Label3.TabIndex = 36
        Label3.Text = "FINANCEIRO"
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
        Guna2Button3.Location = New Point(10, 3)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button3.Size = New Size(117, 39)
        Guna2Button3.TabIndex = 35
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Anchor = AnchorStyles.Left
        ToolStrip1.AutoSize = False
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton2, ToolStripTextBox1, ToolStripLabel1, ToolStripLabel2})
        ToolStrip1.Location = New Point(1, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(633, 46)
        ToolStrip1.TabIndex = 34
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.Alignment = ToolStripItemAlignment.Right
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 43)
        ToolStripButton2.Text = "ToolStripButton2"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Alignment = ToolStripItemAlignment.Right
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(100, 46)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(42, 43)
        ToolStripLabel1.Text = "Buscar"
        ToolStripLabel1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.ActiveLinkColor = Color.Transparent
        ToolStripLabel2.BackgroundImage = CType(resources.GetObject("ToolStripLabel2.BackgroundImage"), Image)
        ToolStripLabel2.BackgroundImageLayout = ImageLayout.None
        ToolStripLabel2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(0, 43)
        ToolStripLabel2.Text = "                                       "
        ' 
        ' financeiro
        ' 
        ClientSize = New Size(634, 605)
        Controls.Add(Label3)
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
        PerformLayout()
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
    Private WithEvents btnLimparEntrada As Button
    Private WithEvents btnLimparSaida As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
