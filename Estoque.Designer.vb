<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estoque
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estoque))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        ToolStrip1 = New ToolStrip()
        ToolStripButton2 = New ToolStripButton()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripLabel2 = New ToolStripLabel()
        btn_salvar = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        user_nome = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Guna2DataGridView1 = New DataGridView()
        ToolStrip1.SuspendLayout()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Guna2Button3.Location = New Point(12, 4)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button3.Size = New Size(103, 39)
        Guna2Button3.TabIndex = 28
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Anchor = AnchorStyles.Top
        ToolStrip1.AutoSize = False
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton2, ToolStripTextBox1, ToolStripLabel1, ToolStripLabel2})
        ToolStrip1.Location = New Point(0, -1)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(659, 44)
        ToolStrip1.TabIndex = 27
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.Alignment = ToolStripItemAlignment.Right
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 41)
        ToolStripButton2.Text = "ToolStripButton2"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Alignment = ToolStripItemAlignment.Right
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(100, 44)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(42, 41)
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
        ToolStripLabel2.Size = New Size(0, 41)
        ToolStripLabel2.Text = "                                       "
        ' 
        ' btn_salvar
        ' 
        btn_salvar.BorderRadius = 10
        btn_salvar.CustomizableEdges = CustomizableEdges3
        btn_salvar.DisabledState.BorderColor = Color.DarkGray
        btn_salvar.DisabledState.CustomBorderColor = Color.DarkGray
        btn_salvar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_salvar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_salvar.FillColor = Color.DarkBlue
        btn_salvar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_salvar.ForeColor = Color.White
        btn_salvar.Location = New Point(456, 112)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btn_salvar.Size = New Size(190, 38)
        btn_salvar.TabIndex = 29
        btn_salvar.Text = "Salvar"
        btn_salvar.Tile = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 15)
        Label1.TabIndex = 31
        Label1.Text = "Nome"
        ' 
        ' user_nome
        ' 
        user_nome.Location = New Point(12, 75)
        user_nome.Name = "user_nome"
        user_nome.Size = New Size(195, 23)
        user_nome.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkBlue
        Label3.Location = New Point(119, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 17)
        Label3.TabIndex = 33
        Label3.Text = "ESTOQUE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 34
        Label2.Text = "Descrição"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 127)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(195, 23)
        TextBox1.TabIndex = 35
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(231, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 15)
        Label4.TabIndex = 36
        Label4.Text = "Preço"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(231, 75)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(195, 23)
        TextBox2.TabIndex = 37
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(231, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 38
        Label5.Text = "Categoria"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(231, 127)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(195, 23)
        TextBox3.TabIndex = 39
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(456, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 15)
        Label6.TabIndex = 40
        Label6.Text = "Quantidade "
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(456, 75)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(195, 23)
        TextBox4.TabIndex = 41
        ' 
        ' Guna2DataGridView1
        ' 
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Guna2DataGridView1.Location = New Point(9, 164)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.Size = New Size(640, 295)
        Guna2DataGridView1.TabIndex = 42
        ' 
        ' Estoque
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(659, 465)
        Controls.Add(Guna2DataGridView1)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(user_nome)
        Controls.Add(btn_salvar)
        Controls.Add(Guna2Button3)
        Controls.Add(ToolStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Estoque"
        Text = "STAYHUB"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents btn_salvar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents user_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Guna2DataGridView1 As DataGridView
End Class
