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
        btn_buscar = New Button()
        Label4 = New Label()
        Label3 = New Label()
        dtp_checkout = New DateTimePicker()
        dtp_checkin = New DateTimePicker()
        Label2 = New Label()
        flp_quartos = New ListBox()
        dgvResultados = New DataGridView()
        lblMessage = New Label()
        Panel2 = New Panel()
        Label7 = New Label()
        btn_cancelar = New Button()
        btn_reservar = New Button()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Panel1.SuspendLayout()
        CType(dgvResultados, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(192, 10)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 43)
        Label1.TabIndex = 0
        Label1.Text = "Reservar um quarto"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btn_buscar)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(dtp_checkout)
        Panel1.Controls.Add(dtp_checkin)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(7, 81)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(188, 225)
        Panel1.TabIndex = 1
        ' 
        ' btn_buscar
        ' 
        btn_buscar.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_buscar.ForeColor = Color.DarkBlue
        btn_buscar.Location = New Point(12, 164)
        btn_buscar.Margin = New Padding(4, 3, 4, 3)
        btn_buscar.Name = "btn_buscar"
        btn_buscar.Size = New Size(161, 42)
        btn_buscar.TabIndex = 4
        btn_buscar.Text = "Buscar"
        btn_buscar.UseVisualStyleBackColor = True
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
        ' dtp_checkout
        ' 
        dtp_checkout.CalendarForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        dtp_checkout.Format = DateTimePickerFormat.Short
        dtp_checkout.Location = New Point(12, 136)
        dtp_checkout.Margin = New Padding(4, 3, 4, 3)
        dtp_checkout.Name = "dtp_checkout"
        dtp_checkout.Size = New Size(160, 23)
        dtp_checkout.TabIndex = 1
        ' 
        ' dtp_checkin
        ' 
        dtp_checkin.CalendarForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        dtp_checkin.Enabled = False
        dtp_checkin.Format = DateTimePickerFormat.Short
        dtp_checkin.Location = New Point(12, 80)
        dtp_checkin.Margin = New Padding(4, 3, 4, 3)
        dtp_checkin.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        dtp_checkin.Name = "dtp_checkin"
        dtp_checkin.Size = New Size(160, 23)
        dtp_checkin.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Navy
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(0, 0)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 31)
        Label2.TabIndex = 0
        Label2.Text = "Pesquisar"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' flp_quartos
        ' 
        flp_quartos.BorderStyle = BorderStyle.None
        flp_quartos.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        flp_quartos.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        flp_quartos.FormattingEnabled = True
        flp_quartos.Location = New Point(5, 40)
        flp_quartos.Margin = New Padding(4, 3, 4, 3)
        flp_quartos.Name = "flp_quartos"
        flp_quartos.Size = New Size(176, 144)
        flp_quartos.TabIndex = 0
        ' 
        ' dgvResultados
        ' 
        dgvResultados.AllowUserToAddRows = False
        dgvResultados.AllowUserToDeleteRows = False
        dgvResultados.AllowUserToResizeColumns = False
        dgvResultados.AllowUserToResizeRows = False
        dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvResultados.ColumnHeadersHeight = 29
        dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvResultados.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvResultados.Location = New Point(201, 81)
        dgvResultados.Margin = New Padding(4, 3, 4, 3)
        dgvResultados.Name = "dgvResultados"
        dgvResultados.RowHeadersWidth = 51
        dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResultados.Size = New Size(863, 403)
        dgvResultados.TabIndex = 2
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.None
        lblMessage.BackColor = Color.WhiteSmoke
        lblMessage.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMessage.ForeColor = Color.Navy
        lblMessage.Location = New Point(830, 43)
        lblMessage.Margin = New Padding(4, 0, 4, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(230, 35)
        lblMessage.TabIndex = 3
        lblMessage.Text = "Quartos disponiveis hoje"
        lblMessage.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(flp_quartos)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(7, 313)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(188, 214)
        Panel2.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Navy
        Label7.Dock = DockStyle.Top
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(0, 0)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(186, 31)
        Label7.TabIndex = 0
        Label7.Text = "Tipos de quartos"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_cancelar.ForeColor = Color.Navy
        btn_cancelar.Location = New Point(916, 490)
        btn_cancelar.Margin = New Padding(4, 3, 4, 3)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(148, 37)
        btn_cancelar.TabIndex = 6
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_reservar
        ' 
        btn_reservar.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_reservar.ForeColor = Color.Navy
        btn_reservar.Location = New Point(761, 490)
        btn_reservar.Margin = New Padding(4, 3, 4, 3)
        btn_reservar.Name = "btn_reservar"
        btn_reservar.Size = New Size(148, 37)
        btn_reservar.TabIndex = 6
        btn_reservar.Text = "Reservar"
        btn_reservar.UseVisualStyleBackColor = True
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
        Guna2Button3.Location = New Point(31, 14)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button3.Size = New Size(102, 39)
        Guna2Button3.TabIndex = 31
        ' 
        ' reservas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1072, 541)
        Controls.Add(Guna2Button3)
        Controls.Add(btn_reservar)
        Controls.Add(btn_cancelar)
        Controls.Add(Panel2)
        Controls.Add(lblMessage)
        Controls.Add(dgvResultados)
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
        CType(dgvResultados, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_checkin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_checkout As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvResultados As System.Windows.Forms.DataGridView
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents flp_quartos As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_reservar As System.Windows.Forms.Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class
