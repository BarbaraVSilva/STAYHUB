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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservas_detalhes))
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        txtfname = New TextBox()
        Label2 = New Label()
        txtAddress = New TextBox()
        Label3 = New Label()
        txtlname = New TextBox()
        Label4 = New Label()
        txtContact = New TextBox()
        rdoMale = New RadioButton()
        rdoFemale = New RadioButton()
        Label5 = New Label()
        btnClose = New Button()
        btnNew = New Button()
        btnSave = New Button()
        dtgList = New DataGridView()
        Label7 = New Label()
        txtSubtotal = New TextBox()
        txtAddons = New TextBox()
        txtTotal = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Panel1 = New Panel()
        dtgAddons = New DataGridView()
        DTGCOLUMNID = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        btnAdd = New Button()
        btnRemove = New Button()
        Label10 = New Label()
        Panel2 = New Panel()
        Label11 = New Label()
        Panel3 = New Panel()
        Label12 = New Label()
        Panel4 = New Panel()
        btnFind = New Button()
        Label15 = New Label()
        txtGuestid = New TextBox()
        Label13 = New Label()
        lblTitle = New Label()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        CType(dtgList, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dtgAddons, ComponentModel.ISupportInitialize).BeginInit()
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
        Label1.Location = New Point(21, 93)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 17)
        Label1.TabIndex = 0
        Label1.Text = "Primeiro nome:"
        ' 
        ' txtfname
        ' 
        txtfname.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtfname.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtfname.Location = New Point(125, 89)
        txtfname.Margin = New Padding(5, 4, 5, 4)
        txtfname.Name = "txtfname"
        txtfname.Size = New Size(406, 23)
        txtfname.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(33, 179)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 17)
        Label2.TabIndex = 0
        Label2.Text = "Endereço:"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAddress.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtAddress.Location = New Point(119, 173)
        txtAddress.Margin = New Padding(5, 4, 5, 4)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(930, 23)
        txtAddress.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(543, 93)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 17)
        Label3.TabIndex = 0
        Label3.Text = "Sobrenome:"
        ' 
        ' txtlname
        ' 
        txtlname.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtlname.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtlname.Location = New Point(641, 89)
        txtlname.Margin = New Padding(5, 4, 5, 4)
        txtlname.Name = "txtlname"
        txtlname.Size = New Size(406, 23)
        txtlname.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(546, 139)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 17)
        Label4.TabIndex = 0
        Label4.Text = "Telefone:"
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContact.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtContact.Location = New Point(641, 132)
        txtContact.Margin = New Padding(5, 4, 5, 4)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(406, 23)
        txtContact.TabIndex = 6
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Checked = True
        rdoMale.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdoMale.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        rdoMale.Location = New Point(126, 136)
        rdoMale.Margin = New Padding(5, 4, 5, 4)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(63, 21)
        rdoMale.TabIndex = 3
        rdoMale.TabStop = True
        rdoMale.Text = "Male"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' rdoFemale
        ' 
        rdoFemale.AutoSize = True
        rdoFemale.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdoFemale.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        rdoFemale.Location = New Point(206, 136)
        rdoFemale.Margin = New Padding(5, 4, 5, 4)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(81, 21)
        rdoFemale.TabIndex = 4
        rdoFemale.Text = "Female"
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(64, 136)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 17)
        Label5.TabIndex = 0
        Label5.Text = "Genero:"
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Navy
        btnClose.Location = New Point(987, 676)
        btnClose.Margin = New Padding(5, 4, 5, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(101, 56)
        btnClose.TabIndex = 4
        btnClose.Text = "Cancelar"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNew.ForeColor = Color.Navy
        btnNew.Location = New Point(880, 676)
        btnNew.Margin = New Padding(5, 4, 5, 4)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(101, 56)
        btnNew.TabIndex = 4
        btnNew.Text = "Atualizar"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.Navy
        btnSave.Location = New Point(773, 676)
        btnSave.Margin = New Padding(5, 4, 5, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(101, 56)
        btnSave.TabIndex = 4
        btnSave.Text = "Check-out"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' dtgList
        ' 
        dtgList.AllowUserToAddRows = False
        dtgList.AllowUserToDeleteRows = False
        dtgList.AllowUserToResizeColumns = False
        dtgList.AllowUserToResizeRows = False
        dtgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dtgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgList.Dock = DockStyle.Fill
        dtgList.EditMode = DataGridViewEditMode.EditProgrammatically
        dtgList.Location = New Point(0, 31)
        dtgList.Margin = New Padding(5, 4, 5, 4)
        dtgList.MultiSelect = False
        dtgList.Name = "dtgList"
        dtgList.RowHeadersWidth = 51
        dtgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgList.Size = New Size(1072, 125)
        dtgList.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(14, 57)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 17)
        Label7.TabIndex = 0
        Label7.Text = "Subtotal :"
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.BackColor = Color.White
        txtSubtotal.Enabled = False
        txtSubtotal.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSubtotal.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtSubtotal.Location = New Point(131, 52)
        txtSubtotal.Margin = New Padding(5, 4, 5, 4)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(257, 23)
        txtSubtotal.TabIndex = 8
        ' 
        ' txtAddons
        ' 
        txtAddons.BackColor = Color.White
        txtAddons.Enabled = False
        txtAddons.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAddons.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtAddons.Location = New Point(131, 93)
        txtAddons.Margin = New Padding(5, 4, 5, 4)
        txtAddons.Name = "txtAddons"
        txtAddons.Size = New Size(257, 23)
        txtAddons.TabIndex = 9
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.White
        txtTotal.Enabled = False
        txtTotal.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotal.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtTotal.Location = New Point(131, 136)
        txtTotal.Margin = New Padding(5, 4, 5, 4)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(257, 23)
        txtTotal.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label8.Location = New Point(7, 99)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 17)
        Label8.TabIndex = 0
        Label8.Text = "Serviços extras:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label9.Location = New Point(33, 140)
        Label9.Margin = New Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 17)
        Label9.TabIndex = 0
        Label9.Text = "Total :"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(dtgAddons)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(btnRemove)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(14, 468)
        Panel1.Margin = New Padding(5, 4, 5, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(654, 263)
        Panel1.TabIndex = 3
        ' 
        ' dtgAddons
        ' 
        dtgAddons.AllowUserToAddRows = False
        dtgAddons.AllowUserToDeleteRows = False
        dtgAddons.AllowUserToResizeColumns = False
        dtgAddons.AllowUserToResizeRows = False
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        dtgAddons.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        dtgAddons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgAddons.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dtgAddons.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dtgAddons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgAddons.Columns.AddRange(New DataGridViewColumn() {DTGCOLUMNID, Column1, Column3, Column2, Column4})
        dtgAddons.Location = New Point(14, 43)
        dtgAddons.Margin = New Padding(5, 4, 5, 4)
        dtgAddons.Name = "dtgAddons"
        dtgAddons.RowHeadersWidth = 51
        dtgAddons.Size = New Size(511, 207)
        dtgAddons.TabIndex = 9
        ' 
        ' DTGCOLUMNID
        ' 
        DTGCOLUMNID.HeaderText = "ID"
        DTGCOLUMNID.MinimumWidth = 6
        DTGCOLUMNID.Name = "DTGCOLUMNID"
        ' 
        ' Column1
        ' 
        Column1.FillWeight = 73.85786F
        Column1.HeaderText = "Add-ons"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column3
        ' 
        Column3.FillWeight = 73.85786F
        Column3.HeaderText = "Price"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column2
        ' 
        Column2.FillWeight = 152.2843F
        Column2.HeaderText = "Quantity"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Subtot"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.Navy
        btnAdd.Location = New Point(535, 47)
        btnAdd.Margin = New Padding(5, 4, 5, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(113, 48)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Adicionar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemove.ForeColor = Color.Navy
        btnRemove.Location = New Point(535, 97)
        btnRemove.Margin = New Padding(5, 4, 5, 4)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(113, 48)
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
        Label10.Margin = New Padding(5, 0, 5, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(654, 31)
        Label10.TabIndex = 6
        Label10.Text = "Serviços extras"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dtgList)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(14, 308)
        Panel2.Margin = New Padding(5, 4, 5, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1072, 156)
        Panel2.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.Navy
        Label11.Dock = DockStyle.Top
        Label11.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(0, 0)
        Label11.Margin = New Padding(5, 0, 5, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(1072, 31)
        Label11.TabIndex = 6
        Label11.Text = "Detalhes do quarto"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txtTotal)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(txtAddons)
        Panel3.Controls.Add(txtSubtotal)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(673, 467)
        Panel3.Margin = New Padding(5, 4, 5, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(413, 199)
        Panel3.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.Navy
        Label12.Dock = DockStyle.Top
        Label12.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(0, 0)
        Label12.Margin = New Padding(5, 0, 5, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(411, 31)
        Label12.TabIndex = 6
        Label12.Text = "Resumo"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(btnFind)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(txtGuestid)
        Panel4.Controls.Add(txtAddress)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(txtlname)
        Panel4.Controls.Add(rdoFemale)
        Panel4.Controls.Add(txtfname)
        Panel4.Controls.Add(rdoMale)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(txtContact)
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(14, 69)
        Panel4.Margin = New Padding(5, 4, 5, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1072, 229)
        Panel4.TabIndex = 1
        ' 
        ' btnFind
        ' 
        btnFind.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFind.ForeColor = Color.Navy
        btnFind.Location = New Point(344, 47)
        btnFind.Margin = New Padding(5, 4, 5, 4)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(65, 36)
        btnFind.TabIndex = 10
        btnFind.Text = "Buscar"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label15.Location = New Point(30, 51)
        Label15.Margin = New Padding(5, 0, 5, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(97, 17)
        Label15.TabIndex = 9
        Label15.Text = "Hospede ID:"
        ' 
        ' txtGuestid
        ' 
        txtGuestid.Enabled = False
        txtGuestid.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGuestid.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtGuestid.Location = New Point(119, 49)
        txtGuestid.Margin = New Padding(5, 4, 5, 4)
        txtGuestid.Name = "txtGuestid"
        txtGuestid.Size = New Size(217, 23)
        txtGuestid.TabIndex = 8
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.DarkBlue
        Label13.Dock = DockStyle.Top
        Label13.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(0, 0)
        Label13.Margin = New Padding(5, 0, 5, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(1070, 31)
        Label13.TabIndex = 6
        Label13.Text = "Hospede"
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.BackColor = Color.WhiteSmoke
        lblTitle.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.DarkBlue
        lblTitle.Location = New Point(193, 4)
        lblTitle.Margin = New Padding(5, 0, 5, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(698, 56)
        lblTitle.TabIndex = 9
        lblTitle.Text = "Detalhes da reserva"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BackColor = Color.WhiteSmoke
        Guna2Button3.CustomizableEdges = CustomizableEdges3
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.WhiteSmoke
        Guna2Button3.Font = New Font("Segoe UI", 9F)
        Guna2Button3.ForeColor = Color.Transparent
        Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), Image)
        Guna2Button3.ImageSize = New Size(80, 80)
        Guna2Button3.Location = New Point(15, 4)
        Guna2Button3.Margin = New Padding(3, 4, 3, 4)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button3.Size = New Size(170, 52)
        Guna2Button3.TabIndex = 30
        ' 
        ' reservas_detalhes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1099, 736)
        Controls.Add(Guna2Button3)
        Controls.Add(lblTitle)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnSave)
        Controls.Add(btnNew)
        Controls.Add(btnClose)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        Name = "reservas_detalhes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "STAYHUB"
        CType(dtgList, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(dtgAddons, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dtgList As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtAddons As System.Windows.Forms.TextBox
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
    Friend WithEvents dtgAddons As System.Windows.Forms.DataGridView
    Friend WithEvents DTGCOLUMNID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtGuestid As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class
