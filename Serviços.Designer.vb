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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label2 = New Label()
        txtName = New TextBox()
        Label3 = New Label()
        txtPrice = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        dtgList = New DataGridView()
        ToolStrip1 = New ToolStrip()
        ToolStripButton2 = New ToolStripButton()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripLabel2 = New ToolStripLabel()
        Guna2Button3 = New Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(dtgList, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nome:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(99, 71)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(212, 27)
        txtName.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 2
        Label3.Text = "Preço:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(99, 111)
        txtPrice.Margin = New Padding(3, 4, 3, 4)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(212, 27)
        txtPrice.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 20)
        Label1.TabIndex = 3
        Label1.Text = "Categoria:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(99, 149)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(212, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkBlue
        Label4.Location = New Point(136, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 20)
        Label4.TabIndex = 4
        Label4.Text = "SERVIÇOS EXTRAS"
        ' 
        ' dtgList
        ' 
        dtgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgList.Location = New Point(15, 253)
        dtgList.Margin = New Padding(3, 4, 3, 4)
        dtgList.Name = "dtgList"
        dtgList.RowHeadersWidth = 51
        dtgList.Size = New Size(608, 277)
        dtgList.TabIndex = 5
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Anchor = AnchorStyles.Top
        ToolStrip1.AutoSize = False
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton2, ToolStripTextBox1, ToolStripLabel1, ToolStripLabel2})
        ToolStrip1.Location = New Point(403, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(229, 55)
        ToolStrip1.TabIndex = 6
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.Alignment = ToolStripItemAlignment.Right
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(29, 52)
        ToolStripButton2.Text = "Buscar"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Alignment = ToolStripItemAlignment.Right
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(114, 55)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Alignment = ToolStripItemAlignment.Right
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(52, 52)
        ToolStripLabel1.Text = "Buscar"
        ToolStripLabel1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(0, 52)
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.Location = New Point(360, 142)
        Guna2Button3.Margin = New Padding(3, 4, 3, 4)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.Size = New Size(114, 41)
        Guna2Button3.TabIndex = 4
        Guna2Button3.Text = "Salvar"
        Guna2Button3.UseVisualStyleBackColor = True
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.WhiteSmoke
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.WhiteSmoke
        Guna2Button1.Font = New Font("Segoe UI", 9.0F)
        Guna2Button1.ForeColor = Color.Transparent
        Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), Image)
        Guna2Button1.ImageSize = New Size(80, 80)
        Guna2Button1.Location = New Point(12, 3)
        Guna2Button1.Margin = New Padding(3, 4, 3, 4)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(118, 52)
        Guna2Button1.TabIndex = 30
        ' 
        ' Serviços
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(631, 545)
        Controls.Add(Guna2Button1)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Guna2Button3)
        Controls.Add(ToolStrip1)
        Controls.Add(dtgList)
        Controls.Add(txtPrice)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        Name = "Serviços"
        StartPosition = FormStartPosition.CenterScreen
        Text = "STAYHUB"
        CType(dtgList, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtgList As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Guna2Button3 As System.Windows.Forms.Button ' Use Button se não tiver Guna2
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
