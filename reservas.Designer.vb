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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservas))
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
        Panel1.SuspendLayout()
        CType(dtgList, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1072, 43)
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
        Panel1.Location = New Point(7, 81)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(188, 225)
        Panel1.TabIndex = 1
        ' 
        ' btnAvailSeach
        ' 
        btnAvailSeach.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAvailSeach.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnAvailSeach.Location = New Point(12, 164)
        btnAvailSeach.Margin = New Padding(4, 3, 4, 3)
        btnAvailSeach.Name = "btnAvailSeach"
        btnAvailSeach.Size = New Size(161, 42)
        btnAvailSeach.TabIndex = 4
        btnAvailSeach.Text = "Buscar"
        btnAvailSeach.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(12, 115)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 3
        Label4.Text = "Check-out"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(8, 59)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 2
        Label3.Text = "Check-in"
        ' 
        ' dtpCheckout
        ' 
        dtpCheckout.CalendarForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        dtpCheckout.Format = DateTimePickerFormat.Short
        dtpCheckout.Location = New Point(12, 136)
        dtpCheckout.Margin = New Padding(4, 3, 4, 3)
        dtpCheckout.Name = "dtpCheckout"
        dtpCheckout.Size = New Size(160, 23)
        dtpCheckout.TabIndex = 1
        ' 
        ' dtpCheckin
        ' 
        dtpCheckin.CalendarForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        dtpCheckin.Enabled = False
        dtpCheckin.Format = DateTimePickerFormat.Short
        dtpCheckin.Location = New Point(12, 80)
        dtpCheckin.Margin = New Padding(4, 3, 4, 3)
        dtpCheckin.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        dtpCheckin.Name = "dtpCheckin"
        dtpCheckin.Size = New Size(160, 23)
        dtpCheckin.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(0, 0)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 31)
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
        lstRoomType.Location = New Point(5, 40)
        lstRoomType.Margin = New Padding(4, 3, 4, 3)
        lstRoomType.Name = "lstRoomType"
        lstRoomType.Size = New Size(176, 160)
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
        dtgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtgList.EditMode = DataGridViewEditMode.EditProgrammatically
        dtgList.Location = New Point(201, 81)
        dtgList.Margin = New Padding(4, 3, 4, 3)
        dtgList.Name = "dtgList"
        dtgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgList.Size = New Size(863, 403)
        dtgList.TabIndex = 2
        ' 
        ' lblMessage
        ' 
        lblMessage.BackColor = Color.White
        lblMessage.Dock = DockStyle.Top
        lblMessage.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMessage.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblMessage.Location = New Point(0, 43)
        lblMessage.Margin = New Padding(4, 0, 4, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(1072, 35)
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
        Panel2.Location = New Point(7, 313)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(188, 214)
        Panel2.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label7.Dock = DockStyle.Top
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Image = CType(resources.GetObject("Label7.Image"), Image)
        Label7.Location = New Point(0, 0)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(186, 31)
        Label7.TabIndex = 0
        Label7.Text = "Tipos de quartos"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnClose.Location = New Point(916, 490)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(148, 37)
        btnClose.TabIndex = 6
        btnClose.Text = "Cancelar"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Book
        ' 
        Book.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Book.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Book.Location = New Point(761, 490)
        Book.Margin = New Padding(4, 3, 4, 3)
        Book.Name = "Book"
        Book.Size = New Size(148, 37)
        Book.TabIndex = 6
        Book.Text = "Reservar"
        Book.UseVisualStyleBackColor = True
        ' 
        ' reservas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1072, 541)
        Controls.Add(Book)
        Controls.Add(btnClose)
        Controls.Add(Panel2)
        Controls.Add(lblMessage)
        Controls.Add(dtgList)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
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
End Class
