<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservas
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservas))
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Panel1 = New Panel()
        btnAvailSeach = New Button()
        Label4 = New Label()
        Label3 = New Label()
        dtpCheckout = New DateTimePicker()
        dtpCheckin = New DateTimePicker()
        Label2 = New Label()
        lstRoomType = New ListBox()
        dtgList = New DataGridView()
        lblMessage = New Label()
        Panel2 = New Panel()
        Label7 = New Label()
        btnClose = New Button()
        Book = New Button()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Panel1.SuspendLayout()
        CType(dtgList, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(219, 13)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 57)
        Label1.TabIndex = 0
        Label1.Text = "Reservar um quarto"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnAvailSeach)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(dtpCheckout)
        Panel1.Controls.Add(dtpCheckin)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(8, 108)
        Panel1.Margin = New Padding(5, 4, 5, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(215, 299)
        Panel1.TabIndex = 1
        ' 
        ' btnAvailSeach
        ' 
        btnAvailSeach.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAvailSeach.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnAvailSeach.Location = New Point(14, 219)
        btnAvailSeach.Margin = New Padding(5, 4, 5, 4)
        btnAvailSeach.Name = "btnAvailSeach"
        btnAvailSeach.Size = New Size(184, 56)
        btnAvailSeach.TabIndex = 4
        btnAvailSeach.Text = "Buscar"
        btnAvailSeach.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(14, 153)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 18)
        Label4.TabIndex = 3
        Label4.Text = "Check-out"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(9, 79)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 18)
        Label3.TabIndex = 2
        Label3.Text = "Check-in"
        ' 
        ' dtpCheckout
        ' 
        dtpCheckout.CalendarForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        dtpCheckout.Format = DateTimePickerFormat.Short
        dtpCheckout.Location = New Point(14, 181)
        dtpCheckout.Margin = New Padding(5, 4, 5, 4)
        dtpCheckout.Name = "dtpCheckout"
        dtpCheckout.Size = New Size(182, 27)
        dtpCheckout.TabIndex = 1
        ' 
        ' dtpCheckin
        ' 
        dtpCheckin.CalendarForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        dtpCheckin.Enabled = False
        dtpCheckin.Format = DateTimePickerFormat.Short
        dtpCheckin.Location = New Point(14, 107)
        dtpCheckin.Margin = New Padding(5, 4, 5, 4)
        dtpCheckin.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        dtpCheckin.Name = "dtpCheckin"
        dtpCheckin.Size = New Size(182, 27)
        dtpCheckin.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Navy
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(0, 0)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 41)
        Label2.TabIndex = 0
        Label2.Text = "Pesquisar"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lstRoomType
        ' 
        lstRoomType.BorderStyle = BorderStyle.None
        lstRoomType.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstRoomType.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lstRoomType.FormattingEnabled = True
        lstRoomType.Location = New Point(6, 53)
        lstRoomType.Margin = New Padding(5, 4, 5, 4)
        lstRoomType.Name = "lstRoomType"
        lstRoomType.Size = New Size(201, 200)
        lstRoomType.TabIndex = 0
        ' 
        ' dtgList
        ' 
        dtgList.AllowUserToAddRows = False
        dtgList.AllowUserToDeleteRows = False
        dtgList.AllowUserToResizeColumns = False
        dtgList.AllowUserToResizeRows = False
        dtgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dtgList.ColumnHeadersHeight = 29
        dtgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtgList.EditMode = DataGridViewEditMode.EditProgrammatically
        dtgList.Location = New Point(230, 108)
        dtgList.Margin = New Padding(5, 4, 5, 4)
        dtgList.Name = "dtgList"
        dtgList.RowHeadersWidth = 51
        dtgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgList.Size = New Size(986, 537)
        dtgList.TabIndex = 2
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.None
        lblMessage.BackColor = Color.WhiteSmoke
        lblMessage.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMessage.ForeColor = Color.Navy
        lblMessage.Location = New Point(948, 57)
        lblMessage.Margin = New Padding(5, 0, 5, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(263, 47)
        lblMessage.TabIndex = 3
        lblMessage.Text = "Quartos disponiveis hoje"
        lblMessage.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(lstRoomType)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(8, 417)
        Panel2.Margin = New Padding(5, 4, 5, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(215, 285)
        Panel2.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Navy
        Label7.Dock = DockStyle.Top
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(0, 0)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(213, 41)
        Label7.TabIndex = 0
        Label7.Text = "Tipos de quartos"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Navy
        btnClose.Location = New Point(1047, 653)
        btnClose.Margin = New Padding(5, 4, 5, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(169, 49)
        btnClose.TabIndex = 6
        btnClose.Text = "Cancelar"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Book
        ' 
        Book.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Book.ForeColor = Color.Navy
        Book.Location = New Point(870, 653)
        Book.Margin = New Padding(5, 4, 5, 4)
        Book.Name = "Book"
        Book.Size = New Size(169, 49)
        Book.TabIndex = 6
        Book.Text = "Reservar"
        Book.UseVisualStyleBackColor = True
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
        Guna2Button3.Location = New Point(15, 13)
        Guna2Button3.Margin = New Padding(3, 4, 3, 4)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button3.Size = New Size(170, 52)
        Guna2Button3.TabIndex = 31
        ' 
        ' reservas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1225, 721)
        Controls.Add(Guna2Button3)
        Controls.Add(Book)
        Controls.Add(btnClose)
        Controls.Add(Panel2)
        Controls.Add(lblMessage)
        Controls.Add(dtgList)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        Name = "reservas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "STAYHUB"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dtgList, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpCheckin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAvailSeach As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtgList As System.Windows.Forms.DataGridView
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lstRoomType As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Book As System.Windows.Forms.Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class
