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
        Label1 = New Label()
        txt_nome = New TextBox()
        txt_email = New TextBox()
        Label3 = New Label()
        data_nasc = New TextBox()
        Label4 = New Label()
        txt_cpf = New TextBox()
        Label5 = New Label()
        txt_rg = New TextBox()
        Label6 = New Label()
        txt_tel = New TextBox()
        Label7 = New Label()
        txt_cel = New TextBox()
        Label8 = New Label()
        txt_comp = New TextBox()
        Label9 = New Label()
        txt_end = New TextBox()
        Label10 = New Label()
        cad_hosp = New TabControl()
        Novo_hospede = New TabPage()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Label2 = New Label()
        List = New ListBox()
        TabPage2 = New TabPage()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        ToolStrip1 = New ToolStrip()
        ToolStripButton2 = New ToolStripButton()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripLabel2 = New ToolStripLabel()
        DataGridView1 = New DataGridView()
        cad_hosp.SuspendLayout()
        Novo_hospede.SuspendLayout()
        TabPage2.SuspendLayout()
        ToolStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nome Completo"
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(29, 113)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(413, 23)
        txt_nome.TabIndex = 1
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(31, 279)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(411, 23)
        txt_email.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 260)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 4
        Label3.Text = "E-mail"
        ' 
        ' data_nasc
        ' 
        data_nasc.Location = New Point(464, 113)
        data_nasc.Name = "data_nasc"
        data_nasc.Size = New Size(168, 23)
        data_nasc.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(464, 94)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 15)
        Label4.TabIndex = 6
        Label4.Text = "Data de nascimento"
        ' 
        ' txt_cpf
        ' 
        txt_cpf.Location = New Point(30, 162)
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(209, 23)
        txt_cpf.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(28, 144)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 8
        Label5.Text = "CPF"
        ' 
        ' txt_rg
        ' 
        txt_rg.Location = New Point(262, 162)
        txt_rg.Name = "txt_rg"
        txt_rg.Size = New Size(179, 23)
        txt_rg.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(262, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(22, 15)
        Label6.TabIndex = 10
        Label6.Text = "RG"
        ' 
        ' txt_tel
        ' 
        txt_tel.Location = New Point(32, 336)
        txt_tel.Name = "txt_tel"
        txt_tel.Size = New Size(209, 23)
        txt_tel.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 318)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 15)
        Label7.TabIndex = 12
        Label7.Text = "Telefone"
        ' 
        ' txt_cel
        ' 
        txt_cel.Location = New Point(262, 336)
        txt_cel.Name = "txt_cel"
        txt_cel.Size = New Size(179, 23)
        txt_cel.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(262, 318)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 15)
        Label8.TabIndex = 14
        Label8.Text = "Celular"
        ' 
        ' txt_comp
        ' 
        txt_comp.Location = New Point(464, 220)
        txt_comp.Name = "txt_comp"
        txt_comp.Size = New Size(168, 23)
        txt_comp.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(464, 202)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 15)
        Label9.TabIndex = 18
        Label9.Text = "Complemento"
        ' 
        ' txt_end
        ' 
        txt_end.Location = New Point(31, 220)
        txt_end.Name = "txt_end"
        txt_end.Size = New Size(410, 23)
        txt_end.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(31, 202)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 15)
        Label10.TabIndex = 16
        Label10.Text = "Endereço"
        ' 
        ' cad_hosp
        ' 
        cad_hosp.Controls.Add(Novo_hospede)
        cad_hosp.Controls.Add(TabPage2)
        cad_hosp.Location = New Point(0, 52)
        cad_hosp.Name = "cad_hosp"
        cad_hosp.SelectedIndex = 0
        cad_hosp.Size = New Size(690, 409)
        cad_hosp.TabIndex = 21
        ' 
        ' Novo_hospede
        ' 
        Novo_hospede.BackColor = Color.WhiteSmoke
        Novo_hospede.Controls.Add(Guna2Button2)
        Novo_hospede.Controls.Add(Guna2Button1)
        Novo_hospede.Controls.Add(Label2)
        Novo_hospede.Controls.Add(List)
        Novo_hospede.Controls.Add(txt_comp)
        Novo_hospede.Controls.Add(Label1)
        Novo_hospede.Controls.Add(txt_nome)
        Novo_hospede.Controls.Add(Label9)
        Novo_hospede.Controls.Add(Label3)
        Novo_hospede.Controls.Add(txt_end)
        Novo_hospede.Controls.Add(txt_email)
        Novo_hospede.Controls.Add(Label10)
        Novo_hospede.Controls.Add(Label4)
        Novo_hospede.Controls.Add(txt_cel)
        Novo_hospede.Controls.Add(data_nasc)
        Novo_hospede.Controls.Add(Label8)
        Novo_hospede.Controls.Add(Label5)
        Novo_hospede.Controls.Add(txt_tel)
        Novo_hospede.Controls.Add(txt_cpf)
        Novo_hospede.Controls.Add(Label7)
        Novo_hospede.Controls.Add(Label6)
        Novo_hospede.Controls.Add(txt_rg)
        Novo_hospede.Location = New Point(4, 24)
        Novo_hospede.Name = "Novo_hospede"
        Novo_hospede.Padding = New Padding(3)
        Novo_hospede.Size = New Size(682, 381)
        Novo_hospede.TabIndex = 0
        Novo_hospede.Text = "Novo Hóspede"
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
        Guna2Button2.Location = New Point(262, 15)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button2.Size = New Size(161, 78)
        Guna2Button2.TabIndex = 24
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 10
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.DarkBlue
        Guna2Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(464, 318)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(168, 39)
        Guna2Button1.TabIndex = 26
        Guna2Button1.Text = "Cadastrar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(464, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 22
        Label2.Text = "Gênero"
        ' 
        ' List
        ' 
        List.FormattingEnabled = True
        List.ItemHeight = 15
        List.Location = New Point(464, 165)
        List.Name = "List"
        List.Size = New Size(168, 19)
        List.TabIndex = 21
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Guna2Button3)
        TabPage2.Controls.Add(ToolStrip1)
        TabPage2.Controls.Add(DataGridView1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(682, 381)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Lista de Hóspedes"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BackColor = Color.WhiteSmoke
        Guna2Button3.CustomizableEdges = CustomizableEdges5
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.WhiteSmoke
        Guna2Button3.Font = New Font("Segoe UI", 9F)
        Guna2Button3.ForeColor = Color.Transparent
        Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), Image)
        Guna2Button3.ImageSize = New Size(80, 80)
        Guna2Button3.Location = New Point(9, 1)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button3.Size = New Size(152, 39)
        Guna2Button3.TabIndex = 27
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Anchor = AnchorStyles.Top
        ToolStrip1.AutoSize = False
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton2, ToolStripTextBox1, ToolStripLabel1, ToolStripLabel2})
        ToolStrip1.Location = New Point(4, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(675, 40)
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
        ToolStripButton2.Size = New Size(23, 37)
        ToolStripButton2.Text = "ToolStripButton2"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Alignment = ToolStripItemAlignment.Right
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(100, 40)
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
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(4, 46)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(675, 332)
        DataGridView1.TabIndex = 2
        ' 
        ' hospedes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(690, 459)
        Controls.Add(cad_hosp)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "hospedes"
        Text = "STAYHUB"
        cad_hosp.ResumeLayout(False)
        Novo_hospede.ResumeLayout(False)
        Novo_hospede.PerformLayout()
        TabPage2.ResumeLayout(False)
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents data_nasc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_rg As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_comp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_end As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cad_hosp As TabControl
    Friend WithEvents Novo_hospede As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents List As ListBox
    Friend WithEvents DataGridView1 As DataGridView

    Private Sub Novo_hospede_Click(sender As Object, e As EventArgs) Handles Novo_hospede.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub New()
    End Sub

    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
