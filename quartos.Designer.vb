<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quartos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quartos))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        btn_salvar = New Guna.UI2.WinForms.Guna2Button()
        txt_capacidade = New TextBox()
        Label7 = New Label()
        num_camas = New TextBox()
        Label4 = New Label()
        txt_preco = New TextBox()
        Label2 = New Label()
        txt_tipo = New TextBox()
        Label1 = New Label()
        txt_num = New TextBox()
        Label3 = New Label()
        TabPage2 = New TabPage()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        ToolStrip1 = New ToolStrip()
        ToolStripButton2 = New ToolStripButton()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripLabel2 = New ToolStripLabel()
        dgv_quartos = New DataGridView()
        Id = New DataGridViewTextBoxColumn()
        numero = New DataGridViewTextBoxColumn()
        tipo = New DataGridViewTextBoxColumn()
        preco = New DataGridViewTextBoxColumn()
        numero_camas = New DataGridViewTextBoxColumn()
        capacidade = New DataGridViewTextBoxColumn()
        status_reserva = New DataGridViewTextBoxColumn()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        ToolStrip1.SuspendLayout()
        CType(dgv_quartos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(1, -1)
        TabControl1.Margin = New Padding(4, 3, 4, 3)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(712, 407)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.WhiteSmoke
        TabPage1.Controls.Add(Guna2Button2)
        TabPage1.Controls.Add(btn_salvar)
        TabPage1.Controls.Add(txt_capacidade)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(num_camas)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(txt_preco)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(txt_tipo)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(txt_num)
        TabPage1.Controls.Add(Label3)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Margin = New Padding(4, 3, 4, 3)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4, 3, 4, 3)
        TabPage1.Size = New Size(704, 379)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Detalhes"
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
        Guna2Button2.Location = New Point(286, 3)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button2.Size = New Size(141, 88)
        Guna2Button2.TabIndex = 73
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
        btn_salvar.Location = New Point(483, 183)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btn_salvar.Size = New Size(176, 70)
        btn_salvar.TabIndex = 72
        btn_salvar.Text = "Salvar"
        ' 
        ' txt_capacidade
        ' 
        txt_capacidade.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_capacidade.Location = New Point(198, 293)
        txt_capacidade.Margin = New Padding(4, 3, 4, 3)
        txt_capacidade.Multiline = True
        txt_capacidade.Name = "txt_capacidade"
        txt_capacidade.Size = New Size(195, 28)
        txt_capacidade.TabIndex = 70
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(27, 297)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 17)
        Label7.TabIndex = 71
        Label7.Text = "Capacidade"
        ' 
        ' num_camas
        ' 
        num_camas.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_camas.Location = New Point(198, 251)
        num_camas.Margin = New Padding(4, 3, 4, 3)
        num_camas.Multiline = True
        num_camas.Name = "num_camas"
        num_camas.Size = New Size(195, 28)
        num_camas.TabIndex = 66
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(27, 255)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 17)
        Label4.TabIndex = 67
        Label4.Text = "Número de camas"
        ' 
        ' txt_preco
        ' 
        txt_preco.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_preco.Location = New Point(198, 203)
        txt_preco.Margin = New Padding(4, 3, 4, 3)
        txt_preco.Multiline = True
        txt_preco.Name = "txt_preco"
        txt_preco.Size = New Size(195, 28)
        txt_preco.TabIndex = 64
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(27, 206)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 17)
        Label2.TabIndex = 65
        Label2.Text = "Preço"
        ' 
        ' txt_tipo
        ' 
        txt_tipo.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_tipo.Location = New Point(198, 155)
        txt_tipo.Margin = New Padding(4, 3, 4, 3)
        txt_tipo.Multiline = True
        txt_tipo.Name = "txt_tipo"
        txt_tipo.Size = New Size(195, 28)
        txt_tipo.TabIndex = 62
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 159)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 17)
        Label1.TabIndex = 63
        Label1.Text = "Tipo"
        ' 
        ' txt_num
        ' 
        txt_num.BackColor = SystemColors.ControlLightLight
        txt_num.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_num.Location = New Point(198, 109)
        txt_num.Margin = New Padding(4, 3, 4, 3)
        txt_num.Multiline = True
        txt_num.Name = "txt_num"
        txt_num.Size = New Size(195, 28)
        txt_num.TabIndex = 60
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(27, 113)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 17)
        Label3.TabIndex = 61
        Label3.Text = "Número"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.WhiteSmoke
        TabPage2.Controls.Add(Guna2Button1)
        TabPage2.Controls.Add(ToolStrip1)
        TabPage2.Controls.Add(dgv_quartos)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Margin = New Padding(4, 3, 4, 3)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4, 3, 4, 3)
        TabPage2.Size = New Size(704, 379)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Lista de quartos"
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
        Guna2Button1.Location = New Point(8, 3)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button1.Size = New Size(121, 39)
        Guna2Button1.TabIndex = 63
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Anchor = AnchorStyles.None
        ToolStrip1.AutoSize = False
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton2, ToolStripTextBox1, ToolStripLabel1, ToolStripLabel2})
        ToolStrip1.Location = New Point(0, -3)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(706, 50)
        ToolStrip1.TabIndex = 62
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
        ' dgv_quartos
        ' 
        dgv_quartos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_quartos.Columns.AddRange(New DataGridViewColumn() {Id, numero, tipo, preco, numero_camas, capacidade, status_reserva})
        dgv_quartos.Location = New Point(7, 50)
        dgv_quartos.Name = "dgv_quartos"
        dgv_quartos.RowHeadersWidth = 51
        dgv_quartos.Size = New Size(679, 322)
        dgv_quartos.TabIndex = 61
        ' 
        ' Id
        ' 
        Id.HeaderText = "Id"
        Id.Name = "Id"
        ' 
        ' numero
        ' 
        numero.HeaderText = "Número"
        numero.Name = "numero"
        ' 
        ' tipo
        ' 
        tipo.HeaderText = "Tipo"
        tipo.Name = "tipo"
        ' 
        ' preco
        ' 
        preco.HeaderText = "Preço"
        preco.Name = "preco"
        ' 
        ' numero_camas
        ' 
        numero_camas.HeaderText = "Camas"
        numero_camas.Name = "numero_camas"
        ' 
        ' capacidade
        ' 
        capacidade.HeaderText = "Capacidade"
        capacidade.Name = "capacidade"
        ' 
        ' status_reserva
        ' 
        status_reserva.HeaderText = "Reserva"
        status_reserva.Name = "status_reserva"
        ' 
        ' quartos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(714, 407)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "quartos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "STAYHUB"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(dgv_quartos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txt_num As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents num_camas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_preco As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents dgv_quartos As DataGridView
    Friend WithEvents txt_capacidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_salvar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents preco As DataGridViewTextBoxColumn
    Friend WithEvents numero_camas As DataGridViewTextBoxColumn
    Friend WithEvents capacidade As DataGridViewTextBoxColumn
    Friend WithEvents status_reserva As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
