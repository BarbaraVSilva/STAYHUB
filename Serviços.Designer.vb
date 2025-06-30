<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Serviços
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Serviços))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label2 = New Label()
        txtName = New TextBox()
        Label3 = New Label()
        txtPrice = New TextBox()
        Label1 = New Label()
        txtCategoria = New TextBox()
        Label4 = New Label()
        dtgServ = New DataGridView()
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        ToolStripLabel2 = New ToolStripLabel()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStripLabel1 = New ToolStripLabel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        btn_salvar = New Guna.UI2.WinForms.Guna2Button()
        CType(dtgServ, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nome:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(90, 61)
        txtName.Name = "txtName"
        txtName.Size = New Size(186, 23)
        txtName.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 2
        Label3.Text = "Preço:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(90, 91)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(186, 23)
        txtPrice.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 3
        Label1.Text = "Categoria:"
        ' 
        ' txtCategoria
        ' 
        txtCategoria.Location = New Point(90, 120)
        txtCategoria.Name = "txtCategoria"
        txtCategoria.Size = New Size(186, 23)
        txtCategoria.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkBlue
        Label4.Location = New Point(119, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 17)
        Label4.TabIndex = 4
        Label4.Text = "SERVIÇOS EXTRAS"
        ' 
        ' dtgServ
        ' 
        dtgServ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgServ.Location = New Point(13, 151)
        dtgServ.Name = "dtgServ"
        dtgServ.RowHeadersWidth = 51
        dtgServ.Size = New Size(532, 247)
        dtgServ.TabIndex = 5
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Anchor = AnchorStyles.Top
        ToolStrip1.AutoSize = False
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1, ToolStripLabel2, ToolStripTextBox1, ToolStripLabel1})
        ToolStrip1.Location = New Point(-1, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(546, 42)
        ToolStrip1.TabIndex = 6
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.Alignment = ToolStripItemAlignment.Right
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(24, 39)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(0, 39)
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Alignment = ToolStripItemAlignment.Right
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(100, 42)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(42, 39)
        ToolStripLabel1.Text = "Buscar"
        ToolStripLabel1.TextAlign = ContentAlignment.MiddleRight
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
        Guna2Button1.Location = New Point(9, 2)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button1.Size = New Size(103, 39)
        Guna2Button1.TabIndex = 30
        ' 
        ' btn_salvar
        ' 
        btn_salvar.BorderRadius = 10
        btn_salvar.CustomizableEdges = CustomizableEdges7
        btn_salvar.DisabledState.BorderColor = Color.DarkGray
        btn_salvar.DisabledState.CustomBorderColor = Color.DarkGray
        btn_salvar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_salvar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_salvar.FillColor = Color.DarkBlue
        btn_salvar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_salvar.ForeColor = Color.White
        btn_salvar.Location = New Point(426, 107)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btn_salvar.Size = New Size(114, 38)
        btn_salvar.TabIndex = 31
        btn_salvar.Text = "Salvar"
        btn_salvar.Tile = True
        ' 
        ' Serviços
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(552, 409)
        Controls.Add(btn_salvar)
        Controls.Add(Guna2Button1)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(txtCategoria)
        Controls.Add(ToolStrip1)
        Controls.Add(dtgServ)
        Controls.Add(txtPrice)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "Serviços"
        StartPosition = FormStartPosition.CenterScreen
        Text = "STAYHUB"
        CType(dtgServ, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtgServ As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents btn_salvar As Guna.UI2.WinForms.Guna2Button
End Class
