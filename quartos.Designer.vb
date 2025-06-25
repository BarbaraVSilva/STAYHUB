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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        bttnCancel = New Button()
        bttnSave = New Button()
        txtNoOfbeds = New TextBox()
        Label4 = New Label()
        txtRoomRate = New TextBox()
        Label2 = New Label()
        txtRoomType = New TextBox()
        Label1 = New Label()
        txtID = New TextBox()
        Label3 = New Label()
        Label9 = New Label()
        TabPage2 = New TabPage()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        Label6 = New Label()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        ToolStrip1 = New ToolStrip()
        ToolStripButton2 = New ToolStripButton()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripLabel2 = New ToolStripLabel()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(1, 48)
        TabControl1.Margin = New Padding(4, 3, 4, 3)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(605, 357)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.WhiteSmoke
        TabPage1.Controls.Add(bttnCancel)
        TabPage1.Controls.Add(bttnSave)
        TabPage1.Controls.Add(txtNoOfbeds)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(txtRoomRate)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(txtRoomType)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label9)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Margin = New Padding(4, 3, 4, 3)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4, 3, 4, 3)
        TabPage1.Size = New Size(597, 329)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Novo quarto"
        ' 
        ' bttnCancel
        ' 
        bttnCancel.Location = New Point(412, 275)
        bttnCancel.Margin = New Padding(4, 3, 4, 3)
        bttnCancel.Name = "bttnCancel"
        bttnCancel.Size = New Size(117, 36)
        bttnCancel.TabIndex = 69
        bttnCancel.Text = "Cancelar"
        bttnCancel.UseVisualStyleBackColor = True
        ' 
        ' bttnSave
        ' 
        bttnSave.Location = New Point(288, 275)
        bttnSave.Margin = New Padding(4, 3, 4, 3)
        bttnSave.Name = "bttnSave"
        bttnSave.Size = New Size(117, 36)
        bttnSave.TabIndex = 68
        bttnSave.Text = "Cadastrar"
        bttnSave.UseVisualStyleBackColor = True
        ' 
        ' txtNoOfbeds
        ' 
        txtNoOfbeds.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNoOfbeds.Location = New Point(198, 211)
        txtNoOfbeds.Margin = New Padding(4, 3, 4, 3)
        txtNoOfbeds.Multiline = True
        txtNoOfbeds.Name = "txtNoOfbeds"
        txtNoOfbeds.Size = New Size(86, 28)
        txtNoOfbeds.TabIndex = 66
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(27, 215)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 16)
        Label4.TabIndex = 67
        Label4.Text = "Número de camas"
        ' 
        ' txtRoomRate
        ' 
        txtRoomRate.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRoomRate.Location = New Point(198, 163)
        txtRoomRate.Margin = New Padding(4, 3, 4, 3)
        txtRoomRate.Multiline = True
        txtRoomRate.Name = "txtRoomRate"
        txtRoomRate.Size = New Size(86, 28)
        txtRoomRate.TabIndex = 64
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(27, 166)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 16)
        Label2.TabIndex = 65
        Label2.Text = "Preço"
        ' 
        ' txtRoomType
        ' 
        txtRoomType.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRoomType.Location = New Point(198, 115)
        txtRoomType.Margin = New Padding(4, 3, 4, 3)
        txtRoomType.Multiline = True
        txtRoomType.Name = "txtRoomType"
        txtRoomType.Size = New Size(198, 28)
        txtRoomType.TabIndex = 62
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 119)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 16)
        Label1.TabIndex = 63
        Label1.Text = "Tipo"
        ' 
        ' txtID
        ' 
        txtID.BackColor = SystemColors.ControlLightLight
        txtID.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(198, 69)
        txtID.Margin = New Padding(4, 3, 4, 3)
        txtID.Multiline = True
        txtID.Name = "txtID"
        txtID.Size = New Size(86, 28)
        txtID.TabIndex = 60
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(27, 73)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 16)
        Label3.TabIndex = 61
        Label3.Text = "Número"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(22, 25)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 24)
        Label9.TabIndex = 59
        Label9.Text = "Novo quarto"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.WhiteSmoke
        TabPage2.Controls.Add(DataGridView1)
        TabPage2.Controls.Add(Label5)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Margin = New Padding(4, 3, 4, 3)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4, 3, 4, 3)
        TabPage2.Size = New Size(597, 329)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Lista de quartos"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(19, 74)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(513, 236)
        DataGridView1.TabIndex = 61
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(22, 25)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 24)
        Label5.TabIndex = 60
        Label5.Text = "Quartos"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.WhiteSmoke
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkBlue
        Label6.Location = New Point(122, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 17)
        Label6.TabIndex = 36
        Label6.Text = "QUARTOS"
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
        Guna2Button3.Location = New Point(13, 3)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button3.Size = New Size(103, 39)
        Guna2Button3.TabIndex = 35
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Anchor = AnchorStyles.Top
        ToolStrip1.AutoSize = False
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton2, ToolStripTextBox1, ToolStripLabel1, ToolStripLabel2})
        ToolStrip1.Location = New Point(1, 1)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(605, 44)
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
        ' quartos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(606, 404)
        Controls.Add(Label6)
        Controls.Add(Guna2Button3)
        Controls.Add(ToolStrip1)
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
        TabPage2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRoomType As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfbeds As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRoomRate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
