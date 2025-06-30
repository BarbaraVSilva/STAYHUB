<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class hospedes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hospedes))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        NomeCompleto = New TextBox()
        txtEmail = New TextBox()
        Label3 = New Label()
        data_nasc = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        txtComplemento = New TextBox()
        Label9 = New Label()
        txtEndereco = New TextBox()
        Label10 = New Label()
        cad_hosp = New TabControl()
        novo_hospede = New TabPage()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Label7 = New Label()
        txtCelular = New MaskedTextBox()
        txtRG = New MaskedTextBox()
        txtCPF = New MaskedTextBox()
        btnCadastrar = New Guna.UI2.WinForms.Guna2Button()
        Label2 = New Label()
        cmbGenero = New ListBox()
        TabPage2 = New TabPage()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        ToolStrip1 = New ToolStrip()
        ToolStripButton2 = New ToolStripButton()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripLabel2 = New ToolStripLabel()
        dgvHospedes = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        nome = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        cpf = New DataGridViewTextBoxColumn()
        rg = New DataGridViewTextBoxColumn()
        endereco = New DataGridViewTextBoxColumn()
        complemento = New DataGridViewTextBoxColumn()
        celular = New DataGridViewTextBoxColumn()
        data_nascimento = New DataGridViewTextBoxColumn()
        genero = New DataGridViewTextBoxColumn()
        cad_hosp.SuspendLayout()
        novo_hospede.SuspendLayout()
        TabPage2.SuspendLayout()
        ToolStrip1.SuspendLayout()
        CType(dgvHospedes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(92, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nome Completo"
        ' 
        ' NomeCompleto
        ' 
        NomeCompleto.Location = New Point(93, 138)
        NomeCompleto.Name = "NomeCompleto"
        NomeCompleto.Size = New Size(413, 23)
        NomeCompleto.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(95, 304)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(411, 23)
        txtEmail.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(95, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 4
        Label3.Text = "E-mail"
        ' 
        ' data_nasc
        ' 
        data_nasc.Location = New Point(528, 138)
        data_nasc.Name = "data_nasc"
        data_nasc.Size = New Size(168, 23)
        data_nasc.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(528, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 15)
        Label4.TabIndex = 6
        Label4.Text = "Data de nascimento"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(92, 169)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 8
        Label5.Text = "CPF"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(326, 169)
        Label6.Name = "Label6"
        Label6.Size = New Size(22, 15)
        Label6.TabIndex = 10
        Label6.Text = "RG"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(528, 286)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 15)
        Label8.TabIndex = 14
        Label8.Text = "Celular"
        ' 
        ' txtComplemento
        ' 
        txtComplemento.Location = New Point(528, 245)
        txtComplemento.Name = "txtComplemento"
        txtComplemento.Size = New Size(168, 23)
        txtComplemento.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(528, 227)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 15)
        Label9.TabIndex = 18
        Label9.Text = "Complemento"
        ' 
        ' txtEndereco
        ' 
        txtEndereco.Location = New Point(95, 245)
        txtEndereco.Name = "txtEndereco"
        txtEndereco.Size = New Size(410, 23)
        txtEndereco.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(95, 227)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 15)
        Label10.TabIndex = 16
        Label10.Text = "Endereço"
        ' 
        ' cad_hosp
        ' 
        cad_hosp.Controls.Add(novo_hospede)
        cad_hosp.Controls.Add(TabPage2)
        cad_hosp.Location = New Point(0, 0)
        cad_hosp.Name = "cad_hosp"
        cad_hosp.SelectedIndex = 0
        cad_hosp.Size = New Size(760, 458)
        cad_hosp.TabIndex = 21
        ' 
        ' novo_hospede
        ' 
        novo_hospede.BackColor = Color.WhiteSmoke
        novo_hospede.Controls.Add(Guna2Button2)
        novo_hospede.Controls.Add(Label7)
        novo_hospede.Controls.Add(txtCelular)
        novo_hospede.Controls.Add(txtRG)
        novo_hospede.Controls.Add(txtCPF)
        novo_hospede.Controls.Add(btnCadastrar)
        novo_hospede.Controls.Add(Label2)
        novo_hospede.Controls.Add(cmbGenero)
        novo_hospede.Controls.Add(txtComplemento)
        novo_hospede.Controls.Add(Label1)
        novo_hospede.Controls.Add(NomeCompleto)
        novo_hospede.Controls.Add(Label9)
        novo_hospede.Controls.Add(Label3)
        novo_hospede.Controls.Add(txtEndereco)
        novo_hospede.Controls.Add(txtEmail)
        novo_hospede.Controls.Add(Label10)
        novo_hospede.Controls.Add(Label4)
        novo_hospede.Controls.Add(data_nasc)
        novo_hospede.Controls.Add(Label8)
        novo_hospede.Controls.Add(Label5)
        novo_hospede.Controls.Add(Label6)
        novo_hospede.Location = New Point(4, 24)
        novo_hospede.Name = "novo_hospede"
        novo_hospede.Padding = New Padding(3)
        novo_hospede.Size = New Size(752, 430)
        novo_hospede.TabIndex = 0
        novo_hospede.Text = "Novo Hóspede"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges1
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Transparent
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), Image)
        Guna2Button2.ImageSize = New Size(150, 150)
        Guna2Button2.Location = New Point(306, 6)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button2.Size = New Size(141, 88)
        Guna2Button2.TabIndex = 35
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkBlue
        Label7.Location = New Point(76, -65)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 17)
        Label7.TabIndex = 34
        Label7.Text = "ESTOQUE"
        ' 
        ' txtCelular
        ' 
        txtCelular.Location = New Point(528, 304)
        txtCelular.Mask = "(99)99999-9999"
        txtCelular.Name = "txtCelular"
        txtCelular.Size = New Size(168, 23)
        txtCelular.TabIndex = 29
        ' 
        ' txtRG
        ' 
        txtRG.Location = New Point(319, 188)
        txtRG.Mask = "99,999,999-9"
        txtRG.Name = "txtRG"
        txtRG.Size = New Size(186, 23)
        txtRG.TabIndex = 28
        ' 
        ' txtCPF
        ' 
        txtCPF.Location = New Point(93, 188)
        txtCPF.Mask = "999,999,999,-99"
        txtCPF.Name = "txtCPF"
        txtCPF.Size = New Size(203, 23)
        txtCPF.TabIndex = 27
        ' 
        ' btnCadastrar
        ' 
        btnCadastrar.BorderRadius = 10
        btnCadastrar.CustomizableEdges = CustomizableEdges3
        btnCadastrar.DisabledState.BorderColor = Color.DarkGray
        btnCadastrar.DisabledState.CustomBorderColor = Color.DarkGray
        btnCadastrar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCadastrar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCadastrar.FillColor = Color.DarkBlue
        btnCadastrar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCadastrar.ForeColor = Color.White
        btnCadastrar.Location = New Point(292, 360)
        btnCadastrar.Name = "btnCadastrar"
        btnCadastrar.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCadastrar.Size = New Size(168, 39)
        btnCadastrar.TabIndex = 26
        btnCadastrar.Text = "Cadastrar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(528, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 22
        Label2.Text = "Gênero"
        ' 
        ' cmbGenero
        ' 
        cmbGenero.FormattingEnabled = True
        cmbGenero.ItemHeight = 15
        cmbGenero.Items.AddRange(New Object() {"Feminino", "Masculino", "Prefiro não informar"})
        cmbGenero.Location = New Point(528, 190)
        cmbGenero.Name = "cmbGenero"
        cmbGenero.Size = New Size(168, 19)
        cmbGenero.TabIndex = 21
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.WhiteSmoke
        TabPage2.Controls.Add(Guna2Button1)
        TabPage2.Controls.Add(Guna2Button3)
        TabPage2.Controls.Add(ToolStrip1)
        TabPage2.Controls.Add(dgvHospedes)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(752, 430)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Lista de Hóspedes"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.WhiteSmoke
        Guna2Button1.CustomizableEdges = CustomizableEdges5
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.WhiteSmoke
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.Transparent
        Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), Image)
        Guna2Button1.ImageSize = New Size(80, 80)
        Guna2Button1.Location = New Point(8, 7)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button1.Size = New Size(103, 39)
        Guna2Button1.TabIndex = 29
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BackColor = Color.WhiteSmoke
        Guna2Button3.CustomizableEdges = CustomizableEdges7
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.WhiteSmoke
        Guna2Button3.Font = New Font("Segoe UI", 9F)
        Guna2Button3.ForeColor = Color.Transparent
        Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), Image)
        Guna2Button3.ImageSize = New Size(80, 80)
        Guna2Button3.Location = New Point(24, -68)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button3.Size = New Size(152, 39)
        Guna2Button3.TabIndex = 27
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Anchor = AnchorStyles.None
        ToolStrip1.AutoSize = False
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton2, ToolStripTextBox1, ToolStripLabel1, ToolStripLabel2})
        ToolStrip1.Location = New Point(0, 3)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(752, 50)
        ToolStrip1.TabIndex = 26
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.Alignment = ToolStripItemAlignment.Right
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 47)
        ToolStripButton2.Text = "ToolStripButton2"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Alignment = ToolStripItemAlignment.Right
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(100, 50)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(42, 47)
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
        ToolStripLabel2.Size = New Size(0, 47)
        ToolStripLabel2.Text = "                                       "
        ' 
        ' dgvHospedes
        ' 
        dgvHospedes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHospedes.Columns.AddRange(New DataGridViewColumn() {id, nome, email, cpf, rg, endereco, complemento, celular, data_nascimento, genero})
        dgvHospedes.Location = New Point(3, 56)
        dgvHospedes.Name = "dgvHospedes"
        dgvHospedes.Size = New Size(742, 371)
        dgvHospedes.TabIndex = 2
        ' 
        ' id
        ' 
        id.HeaderText = "Id"
        id.Name = "id"
        ' 
        ' nome
        ' 
        nome.HeaderText = "Nome"
        nome.Name = "nome"
        ' 
        ' email
        ' 
        email.HeaderText = "Email"
        email.Name = "email"
        ' 
        ' cpf
        ' 
        cpf.HeaderText = "CPF"
        cpf.Name = "cpf"
        ' 
        ' rg
        ' 
        rg.HeaderText = "RG"
        rg.Name = "rg"
        ' 
        ' endereco
        ' 
        endereco.HeaderText = "Endereço"
        endereco.Name = "endereco"
        ' 
        ' complemento
        ' 
        complemento.HeaderText = "Complemento"
        complemento.Name = "complemento"
        ' 
        ' celular
        ' 
        celular.HeaderText = "Celular"
        celular.Name = "celular"
        ' 
        ' data_nascimento
        ' 
        data_nascimento.HeaderText = "Data de Nascimento"
        data_nascimento.Name = "data_nascimento"
        ' 
        ' genero
        ' 
        genero.HeaderText = "Genero"
        genero.Name = "genero"
        ' 
        ' hospedes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(759, 458)
        Controls.Add(cad_hosp)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "hospedes"
        Text = "STAYHUB"
        cad_hosp.ResumeLayout(False)
        novo_hospede.ResumeLayout(False)
        novo_hospede.PerformLayout()
        TabPage2.ResumeLayout(False)
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(dgvHospedes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NomeCompleto As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents data_nasc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cad_hosp As TabControl
    Friend WithEvents novo_hospede As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbGenero As ListBox
    Friend WithEvents dgvHospedes As DataGridView

    Private Sub Novo_hospede_Click(sender As Object, e As EventArgs) Handles novo_hospede.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents btnCadastrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents txtRG As MaskedTextBox
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents rg As DataGridViewTextBoxColumn
    Friend WithEvents endereco As DataGridViewTextBoxColumn
    Friend WithEvents complemento As DataGridViewTextBoxColumn
    Friend WithEvents celular As DataGridViewTextBoxColumn
    Friend WithEvents data_nascimento As DataGridViewTextBoxColumn
    Friend WithEvents genero As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
