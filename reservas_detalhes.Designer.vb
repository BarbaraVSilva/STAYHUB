<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservas_detalhes
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservas_detalhes))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        txtNome = New TextBox()
        Label2 = New Label()
        txtEndereco = New TextBox()
        Label4 = New Label()
        txtCelular = New TextBox()
        Label5 = New Label()
        btnCancelar = New Button()
        btnNew = New Button()
        btnCheckOut = New Button()
        dtgQuartos = New DataGridView()
        Label7 = New Label()
        txtSubtotal = New TextBox()
        txtServicosExtras = New TextBox()
        txtTotal = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Panel1 = New Panel()
        dgvServicosExtras = New DataGridView()
        btnAdd = New Button()
        btnRemove = New Button()
        Label10 = New Label()
        Panel2 = New Panel()
        Label11 = New Label()
        Panel3 = New Panel()
        Label12 = New Label()
        Panel4 = New Panel()
        txtGenero = New TextBox()
        txtCPF = New TextBox()
        Label3 = New Label()
        btnBuscarHospede = New Button()
        Label15 = New Label()
        txtHospedeID = New TextBox()
        Label13 = New Label()
        lblTitle = New Label()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        CType(dtgQuartos, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dgvServicosExtras, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(18, 70)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 13)
        Label1.TabIndex = 0
        Label1.Text = "Primeiro nome:"
        ' 
        ' txtNome
        ' 
        txtNome.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNome.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtNome.Location = New Point(109, 67)
        txtNome.Margin = New Padding(4, 3, 4, 3)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(250, 20)
        txtNome.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(29, 134)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 13)
        Label2.TabIndex = 0
        Label2.Text = "Endereço:"
        ' 
        ' txtEndereco
        ' 
        txtEndereco.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEndereco.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtEndereco.Location = New Point(109, 131)
        txtEndereco.Margin = New Padding(4, 3, 4, 3)
        txtEndereco.Name = "txtEndereco"
        txtEndereco.Size = New Size(642, 20)
        txtEndereco.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(443, 70)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 13)
        Label4.TabIndex = 0
        Label4.Text = "Celular:"
        ' 
        ' txtCelular
        ' 
        txtCelular.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCelular.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtCelular.Location = New Point(501, 67)
        txtCelular.Margin = New Padding(4, 3, 4, 3)
        txtCelular.Name = "txtCelular"
        txtCelular.Size = New Size(250, 20)
        txtCelular.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(56, 102)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 13)
        Label5.TabIndex = 0
        Label5.Text = "Genero:"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.Navy
        btnCancelar.Location = New Point(864, 507)
        btnCancelar.Margin = New Padding(4, 3, 4, 3)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(88, 42)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNew.ForeColor = Color.Navy
        btnNew.Location = New Point(770, 507)
        btnNew.Margin = New Padding(4, 3, 4, 3)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(88, 42)
        btnNew.TabIndex = 4
        btnNew.Text = "Atualizar"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnCheckOut
        ' 
        btnCheckOut.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckOut.ForeColor = Color.Navy
        btnCheckOut.Location = New Point(676, 507)
        btnCheckOut.Margin = New Padding(4, 3, 4, 3)
        btnCheckOut.Name = "btnCheckOut"
        btnCheckOut.Size = New Size(88, 42)
        btnCheckOut.TabIndex = 4
        btnCheckOut.Text = "Check-out"
        btnCheckOut.UseVisualStyleBackColor = True
        ' 
        ' dtgQuartos
        ' 
        dtgQuartos.AllowUserToAddRows = False
        dtgQuartos.AllowUserToDeleteRows = False
        dtgQuartos.AllowUserToResizeColumns = False
        dtgQuartos.AllowUserToResizeRows = False
        dtgQuartos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgQuartos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dtgQuartos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgQuartos.Dock = DockStyle.Fill
        dtgQuartos.EditMode = DataGridViewEditMode.EditProgrammatically
        dtgQuartos.Location = New Point(0, 23)
        dtgQuartos.Margin = New Padding(4, 3, 4, 3)
        dtgQuartos.MultiSelect = False
        dtgQuartos.Name = "dtgQuartos"
        dtgQuartos.RowHeadersWidth = 51
        dtgQuartos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgQuartos.Size = New Size(938, 94)
        dtgQuartos.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(12, 43)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(62, 13)
        Label7.TabIndex = 0
        Label7.Text = "Subtotal :"
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.BackColor = Color.White
        txtSubtotal.Enabled = False
        txtSubtotal.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSubtotal.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtSubtotal.Location = New Point(115, 39)
        txtSubtotal.Margin = New Padding(4, 3, 4, 3)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(225, 20)
        txtSubtotal.TabIndex = 8
        ' 
        ' txtServicosExtras
        ' 
        txtServicosExtras.BackColor = Color.White
        txtServicosExtras.Enabled = False
        txtServicosExtras.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtServicosExtras.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtServicosExtras.Location = New Point(115, 70)
        txtServicosExtras.Margin = New Padding(4, 3, 4, 3)
        txtServicosExtras.Name = "txtServicosExtras"
        txtServicosExtras.Size = New Size(225, 20)
        txtServicosExtras.TabIndex = 9
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.White
        txtTotal.Enabled = False
        txtTotal.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotal.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtTotal.Location = New Point(115, 102)
        txtTotal.Margin = New Padding(4, 3, 4, 3)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(225, 20)
        txtTotal.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label8.Location = New Point(6, 74)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 13)
        Label8.TabIndex = 0
        Label8.Text = "Serviços extras:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label9.Location = New Point(29, 105)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 13)
        Label9.TabIndex = 0
        Label9.Text = "Total :"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(dgvServicosExtras)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(btnRemove)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(12, 351)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(572, 197)
        Panel1.TabIndex = 3
        ' 
        ' dgvServicosExtras
        ' 
        dgvServicosExtras.AllowUserToAddRows = False
        dgvServicosExtras.AllowUserToDeleteRows = False
        dgvServicosExtras.AllowUserToResizeColumns = False
        dgvServicosExtras.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        dgvServicosExtras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvServicosExtras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvServicosExtras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvServicosExtras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvServicosExtras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvServicosExtras.Location = New Point(12, 32)
        dgvServicosExtras.Margin = New Padding(4, 3, 4, 3)
        dgvServicosExtras.Name = "dgvServicosExtras"
        dgvServicosExtras.RowHeadersWidth = 51
        dgvServicosExtras.Size = New Size(447, 155)
        dgvServicosExtras.TabIndex = 9
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.Navy
        btnAdd.Location = New Point(468, 35)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(99, 36)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Adicionar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemove.ForeColor = Color.Navy
        btnRemove.Location = New Point(468, 73)
        btnRemove.Margin = New Padding(4, 3, 4, 3)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(99, 36)
        btnRemove.TabIndex = 8
        btnRemove.Text = "Remover"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.Navy
        Label10.Dock = DockStyle.Top
        Label10.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(0, 0)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(572, 23)
        Label10.TabIndex = 6
        Label10.Text = "Serviços extras"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dtgQuartos)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(12, 231)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(938, 117)
        Panel2.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.Navy
        Label11.Dock = DockStyle.Top
        Label11.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(0, 0)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(938, 23)
        Label11.TabIndex = 6
        Label11.Text = "Detalhes do quarto"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txtTotal)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(txtServicosExtras)
        Panel3.Controls.Add(txtSubtotal)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(589, 350)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(362, 150)
        Panel3.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.Navy
        Label12.Dock = DockStyle.Top
        Label12.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(0, 0)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(360, 23)
        Label12.TabIndex = 6
        Label12.Text = "Resumo"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(txtGenero)
        Panel4.Controls.Add(txtCPF)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(btnBuscarHospede)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(txtHospedeID)
        Panel4.Controls.Add(txtEndereco)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(txtNome)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(txtCelular)
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(12, 52)
        Panel4.Margin = New Padding(4, 3, 4, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(938, 172)
        Panel4.TabIndex = 1
        ' 
        ' txtGenero
        ' 
        txtGenero.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGenero.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtGenero.Location = New Point(109, 99)
        txtGenero.Margin = New Padding(4, 3, 4, 3)
        txtGenero.Name = "txtGenero"
        txtGenero.Size = New Size(250, 20)
        txtGenero.TabIndex = 13
        ' 
        ' txtCPF
        ' 
        txtCPF.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCPF.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtCPF.Location = New Point(501, 38)
        txtCPF.Margin = New Padding(4, 3, 4, 3)
        txtCPF.Name = "txtCPF"
        txtCPF.Size = New Size(250, 20)
        txtCPF.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(459, 41)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 13)
        Label3.TabIndex = 11
        Label3.Text = "CPF:"
        ' 
        ' btnBuscarHospede
        ' 
        btnBuscarHospede.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscarHospede.ForeColor = Color.Navy
        btnBuscarHospede.Location = New Point(810, 125)
        btnBuscarHospede.Margin = New Padding(4, 3, 4, 3)
        btnBuscarHospede.Name = "btnBuscarHospede"
        btnBuscarHospede.Size = New Size(107, 26)
        btnBuscarHospede.TabIndex = 10
        btnBuscarHospede.Text = "Buscar"
        btnBuscarHospede.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label15.Location = New Point(26, 38)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(78, 13)
        Label15.TabIndex = 9
        Label15.Text = "Hospede ID:"
        ' 
        ' txtHospedeID
        ' 
        txtHospedeID.Enabled = False
        txtHospedeID.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtHospedeID.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtHospedeID.Location = New Point(109, 38)
        txtHospedeID.Margin = New Padding(4, 3, 4, 3)
        txtHospedeID.Name = "txtHospedeID"
        txtHospedeID.Size = New Size(250, 20)
        txtHospedeID.TabIndex = 8
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.DarkBlue
        Label13.Dock = DockStyle.Top
        Label13.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(0, 0)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(936, 23)
        Label13.TabIndex = 6
        Label13.Text = "Hospede"
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.BackColor = Color.WhiteSmoke
        lblTitle.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.DarkBlue
        lblTitle.Location = New Point(169, 3)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(611, 42)
        lblTitle.TabIndex = 9
        lblTitle.Text = "Detalhes da reserva"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
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
        Guna2Button3.Size = New Size(149, 39)
        Guna2Button3.TabIndex = 30
        ' 
        ' reservas_detalhes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(962, 552)
        Controls.Add(Guna2Button3)
        Controls.Add(lblTitle)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnCheckOut)
        Controls.Add(btnNew)
        Controls.Add(btnCancelar)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "reservas_detalhes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "STAYHUB"
        CType(dtgQuartos, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(dgvServicosExtras, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnCheckOut As System.Windows.Forms.Button
    Friend WithEvents dtgQuartos As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtServicosExtras As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents dgvServicosExtras As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtHospedeID As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarHospede As System.Windows.Forms.Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGenero As TextBox
End Class
