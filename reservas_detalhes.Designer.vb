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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservas_detalhes))
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
        LBLUSERID = New Label()
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
        Label1.Location = New Point(18, 70)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 13)
        Label1.TabIndex = 0
        Label1.Text = "Primeiro nome:"
        ' 
        ' txtfname
        ' 
        txtfname.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtfname.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtfname.Location = New Point(109, 67)
        txtfname.Margin = New Padding(4, 3, 4, 3)
        txtfname.Name = "txtfname"
        txtfname.Size = New Size(356, 20)
        txtfname.TabIndex = 1
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
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAddress.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtAddress.Location = New Point(104, 130)
        txtAddress.Margin = New Padding(4, 3, 4, 3)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(814, 20)
        txtAddress.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(475, 70)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 13)
        Label3.TabIndex = 0
        Label3.Text = "Sobrenome:"
        ' 
        ' txtlname
        ' 
        txtlname.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtlname.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtlname.Location = New Point(561, 67)
        txtlname.Margin = New Padding(4, 3, 4, 3)
        txtlname.Name = "txtlname"
        txtlname.Size = New Size(356, 20)
        txtlname.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(478, 104)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 13)
        Label4.TabIndex = 0
        Label4.Text = "Telefone:"
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContact.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtContact.Location = New Point(561, 99)
        txtContact.Margin = New Padding(4, 3, 4, 3)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(356, 20)
        txtContact.TabIndex = 6
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Checked = True
        rdoMale.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdoMale.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        rdoMale.Location = New Point(110, 102)
        rdoMale.Margin = New Padding(4, 3, 4, 3)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(52, 17)
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
        rdoFemale.Location = New Point(180, 102)
        rdoFemale.Margin = New Padding(4, 3, 4, 3)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(65, 17)
        rdoFemale.TabIndex = 4
        rdoFemale.Text = "Female"
        rdoFemale.UseVisualStyleBackColor = True
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
        ' btnClose
        ' 
        btnClose.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnClose.Location = New Point(864, 507)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(88, 42)
        btnClose.TabIndex = 4
        btnClose.Text = "Cancelar"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNew.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnNew.Location = New Point(770, 507)
        btnNew.Margin = New Padding(4, 3, 4, 3)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(88, 42)
        btnNew.TabIndex = 4
        btnNew.Text = "Atualizar"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnSave.Location = New Point(676, 507)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(88, 42)
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
        dtgList.Location = New Point(0, 23)
        dtgList.Margin = New Padding(4, 3, 4, 3)
        dtgList.MultiSelect = False
        dtgList.Name = "dtgList"
        dtgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgList.Size = New Size(938, 94)
        dtgList.TabIndex = 0
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
        ' txtAddons
        ' 
        txtAddons.BackColor = Color.White
        txtAddons.Enabled = False
        txtAddons.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAddons.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtAddons.Location = New Point(115, 70)
        txtAddons.Margin = New Padding(4, 3, 4, 3)
        txtAddons.Name = "txtAddons"
        txtAddons.Size = New Size(225, 20)
        txtAddons.TabIndex = 9
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
        Panel1.Controls.Add(dtgAddons)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(btnRemove)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(12, 351)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(572, 197)
        Panel1.TabIndex = 3
        ' 
        ' dtgAddons
        ' 
        dtgAddons.AllowUserToAddRows = False
        dtgAddons.AllowUserToDeleteRows = False
        dtgAddons.AllowUserToResizeColumns = False
        dtgAddons.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        dtgAddons.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dtgAddons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgAddons.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dtgAddons.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dtgAddons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgAddons.Columns.AddRange(New DataGridViewColumn() {DTGCOLUMNID, Column1, Column3, Column2, Column4})
        dtgAddons.Location = New Point(12, 32)
        dtgAddons.Margin = New Padding(4, 3, 4, 3)
        dtgAddons.Name = "dtgAddons"
        dtgAddons.Size = New Size(447, 155)
        dtgAddons.TabIndex = 9
        ' 
        ' DTGCOLUMNID
        ' 
        DTGCOLUMNID.HeaderText = "ID"
        DTGCOLUMNID.Name = "DTGCOLUMNID"
        ' 
        ' Column1
        ' 
        Column1.FillWeight = 73.85786F
        Column1.HeaderText = "Add-ons"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column3
        ' 
        Column3.FillWeight = 73.85786F
        Column3.HeaderText = "Price"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column2
        ' 
        Column2.FillWeight = 152.2843F
        Column2.HeaderText = "Quantity"
        Column2.Name = "Column2"
        Column2.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Subtot"
        Column4.Name = "Column4"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
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
        btnRemove.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
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
        Label10.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label10.Dock = DockStyle.Top
        Label10.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Image = CType(resources.GetObject("Label10.Image"), Image)
        Label10.Location = New Point(0, 0)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(572, 23)
        Label10.TabIndex = 6
        Label10.Text = "Serviços extras"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dtgList)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(12, 231)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(938, 117)
        Panel2.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label11.Dock = DockStyle.Top
        Label11.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Image = CType(resources.GetObject("Label11.Image"), Image)
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
        Panel3.Controls.Add(txtAddons)
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
        Label12.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label12.Dock = DockStyle.Top
        Label12.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Image = CType(resources.GetObject("Label12.Image"), Image)
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
        Panel4.Location = New Point(12, 52)
        Panel4.Margin = New Padding(4, 3, 4, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(938, 172)
        Panel4.TabIndex = 1
        ' 
        ' btnFind
        ' 
        btnFind.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFind.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnFind.Location = New Point(301, 35)
        btnFind.Margin = New Padding(4, 3, 4, 3)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(57, 27)
        btnFind.TabIndex = 10
        btnFind.Text = "Buscar"
        btnFind.UseVisualStyleBackColor = True
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
        ' txtGuestid
        ' 
        txtGuestid.Enabled = False
        txtGuestid.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGuestid.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtGuestid.Location = New Point(104, 37)
        txtGuestid.Margin = New Padding(4, 3, 4, 3)
        txtGuestid.Name = "txtGuestid"
        txtGuestid.Size = New Size(190, 20)
        txtGuestid.TabIndex = 8
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label13.Dock = DockStyle.Top
        Label13.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Image = CType(resources.GetObject("Label13.Image"), Image)
        Label13.Location = New Point(0, 0)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(936, 23)
        Label13.TabIndex = 6
        Label13.Text = "Hospede"
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.White
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(0, 0)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(962, 42)
        lblTitle.TabIndex = 9
        lblTitle.Text = "Detalhes da reserva"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LBLUSERID
        ' 
        LBLUSERID.AutoSize = True
        LBLUSERID.Location = New Point(912, 10)
        LBLUSERID.Margin = New Padding(4, 0, 4, 0)
        LBLUSERID.Name = "LBLUSERID"
        LBLUSERID.Size = New Size(13, 15)
        LBLUSERID.TabIndex = 10
        LBLUSERID.Text = "1"
        LBLUSERID.Visible = False
        ' 
        ' reservas_detalhes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(962, 552)
        Controls.Add(lblTitle)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnSave)
        Controls.Add(btnNew)
        Controls.Add(btnClose)
        Controls.Add(LBLUSERID)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
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
        PerformLayout()

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
    Friend WithEvents LBLUSERID As System.Windows.Forms.Label
    Friend WithEvents DTGCOLUMNID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtGuestid As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
End Class
