<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuarios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuarios))
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        user_nome = New TextBox()
        cmb_cargo = New ComboBox()
        Label2 = New Label()
        user_email = New TextBox()
        Label3 = New Label()
        user_end = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        user_comp = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        user_data = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        user_senha = New TextBox()
        Label11 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        user_cel = New MaskedTextBox()
        user_rg = New MaskedTextBox()
        user_cpf = New MaskedTextBox()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        TabPage2 = New TabPage()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        dgv_dados = New DataGridView()
        Nome = New DataGridViewTextBoxColumn()
        CPF = New DataGridViewTextBoxColumn()
        Cargo = New DataGridViewTextBoxColumn()
        ToolStrip1 = New ToolStrip()
        ToolStripButton2 = New ToolStripButton()
        txt_buscar = New ToolStripTextBox()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripLabel2 = New ToolStripLabel()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(dgv_dados, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nome do funcionário"
        ' 
        ' user_nome
        ' 
        user_nome.Location = New Point(37, 116)
        user_nome.Name = "user_nome"
        user_nome.Size = New Size(195, 23)
        user_nome.TabIndex = 1
        ' 
        ' cmb_cargo
        ' 
        cmb_cargo.AutoCompleteCustomSource.AddRange(New String() {"Administrador", "Recepcionista", "Auxiliar"})
        cmb_cargo.FormattingEnabled = True
        cmb_cargo.Location = New Point(289, 116)
        cmb_cargo.Name = "cmb_cargo"
        cmb_cargo.Size = New Size(195, 23)
        cmb_cargo.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(289, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 3
        Label2.Text = "Cargo"
        ' 
        ' user_email
        ' 
        user_email.Location = New Point(37, 175)
        user_email.Name = "user_email"
        user_email.Size = New Size(195, 23)
        user_email.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 4
        Label3.Text = "E-mail"
        ' 
        ' user_end
        ' 
        user_end.Location = New Point(37, 284)
        user_end.Name = "user_end"
        user_end.Size = New Size(195, 23)
        user_end.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(37, 266)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 8
        Label4.Text = "Endereço"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 6
        Label5.Text = "CPF"
        ' 
        ' user_comp
        ' 
        user_comp.Location = New Point(289, 284)
        user_comp.Name = "user_comp"
        user_comp.Size = New Size(195, 23)
        user_comp.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(289, 266)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 15)
        Label6.TabIndex = 12
        Label6.Text = "Complemento"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(289, 208)
        Label7.Name = "Label7"
        Label7.Size = New Size(22, 15)
        Label7.TabIndex = 10
        Label7.Text = "RG"
        ' 
        ' user_data
        ' 
        user_data.Location = New Point(289, 175)
        user_data.Name = "user_data"
        user_data.Size = New Size(195, 23)
        user_data.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(289, 157)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 15)
        Label8.TabIndex = 14
        Label8.Text = "Data de Nascimento"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(37, 322)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 15)
        Label9.TabIndex = 18
        Label9.Text = "Celular"
        ' 
        ' user_senha
        ' 
        user_senha.Location = New Point(289, 340)
        user_senha.Name = "user_senha"
        user_senha.PasswordChar = "*"c
        user_senha.Size = New Size(195, 23)
        user_senha.TabIndex = 21
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(289, 322)
        Label11.Name = "Label11"
        Label11.Size = New Size(39, 15)
        Label11.TabIndex = 20
        Label11.Text = "Senha"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(546, 468)
        TabControl1.TabIndex = 23
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(user_cel)
        TabPage1.Controls.Add(user_rg)
        TabPage1.Controls.Add(user_cpf)
        TabPage1.Controls.Add(Guna2Button2)
        TabPage1.Controls.Add(Guna2Button1)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(user_nome)
        TabPage1.Controls.Add(user_senha)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(user_data)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(user_email)
        TabPage1.Controls.Add(user_comp)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(cmb_cargo)
        TabPage1.Controls.Add(user_end)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(538, 440)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Cadastrar usuário"
        ' 
        ' user_cel
        ' 
        user_cel.Location = New Point(37, 340)
        user_cel.Mask = "(99)99999-9999"
        user_cel.Name = "user_cel"
        user_cel.Size = New Size(195, 23)
        user_cel.TabIndex = 27
        ' 
        ' user_rg
        ' 
        user_rg.Location = New Point(289, 233)
        user_rg.Mask = "99,999,999-99"
        user_rg.Name = "user_rg"
        user_rg.Size = New Size(195, 23)
        user_rg.TabIndex = 26
        ' 
        ' user_cpf
        ' 
        user_cpf.Location = New Point(37, 233)
        user_cpf.Mask = "999,999,999-99"
        user_cpf.Name = "user_cpf"
        user_cpf.Size = New Size(195, 23)
        user_cpf.TabIndex = 25
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges7
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Transparent
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), Image)
        Guna2Button2.ImageSize = New Size(150, 150)
        Guna2Button2.Location = New Point(192, 6)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button2.Size = New Size(141, 88)
        Guna2Button2.TabIndex = 24
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 10
        Guna2Button1.CustomizableEdges = CustomizableEdges9
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.DarkBlue
        Guna2Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(162, 381)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Button1.Size = New Size(199, 39)
        Guna2Button1.TabIndex = 22
        Guna2Button1.Text = "Cadastrar"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Guna2Button3)
        TabPage2.Controls.Add(dgv_dados)
        TabPage2.Controls.Add(ToolStrip1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(538, 440)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Lista de usuários"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BackColor = Color.WhiteSmoke
        Guna2Button3.CustomizableEdges = CustomizableEdges11
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.WhiteSmoke
        Guna2Button3.Font = New Font("Segoe UI", 9F)
        Guna2Button3.ForeColor = Color.Transparent
        Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), Image)
        Guna2Button3.ImageSize = New Size(80, 80)
        Guna2Button3.Location = New Point(12, 4)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Button3.Size = New Size(71, 39)
        Guna2Button3.TabIndex = 25
        ' 
        ' dgv_dados
        ' 
        dgv_dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_dados.Columns.AddRange(New DataGridViewColumn() {Nome, CPF, Cargo})
        dgv_dados.Location = New Point(3, 46)
        dgv_dados.Name = "dgv_dados"
        dgv_dados.Size = New Size(532, 388)
        dgv_dados.TabIndex = 0
        ' 
        ' Nome
        ' 
        Nome.HeaderText = "Nome"
        Nome.Name = "Nome"
        ' 
        ' CPF
        ' 
        CPF.HeaderText = "CPF"
        CPF.Name = "CPF"
        ' 
        ' Cargo
        ' 
        Cargo.HeaderText = "Cargo"
        Cargo.Name = "Cargo"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ToolStrip1.AutoSize = False
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton2, txt_buscar, ToolStripLabel1, ToolStripLabel2})
        ToolStrip1.Location = New Point(3, 3)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(532, 40)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.Alignment = ToolStripItemAlignment.Right
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 37)
        ToolStripButton2.Text = "ToolStripButton2"
        ' 
        ' txt_buscar
        ' 
        txt_buscar.Alignment = ToolStripItemAlignment.Right
        txt_buscar.Name = "txt_buscar"
        txt_buscar.Size = New Size(100, 40)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(42, 37)
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
        ToolStripLabel2.Size = New Size(0, 37)
        ToolStripLabel2.Text = "                                       "
        ' 
        ' usuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(546, 470)
        Controls.Add(TabControl1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "usuarios"
        Text = "STAYHUB"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        CType(dgv_dados, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents user_nome As TextBox
    Friend WithEvents cmb_cargo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents user_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents user_end As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents user_comp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents user_data As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents user_tel As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents user_senha As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents txt_buscar As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents user_cel As MaskedTextBox
    Friend WithEvents user_rg As MaskedTextBox
    Friend WithEvents user_cpf As MaskedTextBox
End Class
