<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservas_lista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservas_lista))
        dtgList = New DataGridView()
        btnUpdate = New Button()
        btnClose = New Button()
        btnCheckedout = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtSearch = New TextBox()
        btnnew = New Button()
        CType(dtgList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtgList
        ' 
        dtgList.AllowUserToAddRows = False
        dtgList.AllowUserToDeleteRows = False
        dtgList.AllowUserToResizeColumns = False
        dtgList.AllowUserToResizeRows = False
        dtgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dtgList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dtgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgList.EditMode = DataGridViewEditMode.EditProgrammatically
        dtgList.Location = New Point(7, 115)
        dtgList.Margin = New Padding(4, 3, 4, 3)
        dtgList.Name = "dtgList"
        dtgList.RowHeadersVisible = False
        dtgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgList.Size = New Size(1000, 370)
        dtgList.TabIndex = 0
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnUpdate.Location = New Point(602, 493)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(88, 37)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "View"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnClose.Location = New Point(919, 493)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(88, 37)
        btnClose.TabIndex = 1
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnCheckedout
        ' 
        btnCheckedout.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckedout.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnCheckedout.Location = New Point(696, 493)
        btnCheckedout.Margin = New Padding(4, 3, 4, 3)
        btnCheckedout.Name = "btnCheckedout"
        btnCheckedout.Size = New Size(88, 37)
        btnCheckedout.TabIndex = 1
        btnCheckedout.Text = "Check-out"
        btnCheckedout.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1015, 38)
        Label1.TabIndex = 2
        Label1.Text = "List of Booked Rooms"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(600, 88)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 3
        Label2.Text = "Search For :"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(692, 84)
        txtSearch.Margin = New Padding(4, 3, 4, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(314, 21)
        txtSearch.TabIndex = 4
        ' 
        ' btnnew
        ' 
        btnnew.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnnew.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        btnnew.Location = New Point(791, 493)
        btnnew.Margin = New Padding(4, 3, 4, 3)
        btnnew.Name = "btnnew"
        btnnew.Size = New Size(121, 37)
        btnnew.TabIndex = 5
        btnnew.Text = "Book a Room"
        btnnew.UseVisualStyleBackColor = True
        ' 
        ' reservas_lista
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1015, 543)
        Controls.Add(btnnew)
        Controls.Add(txtSearch)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCheckedout)
        Controls.Add(btnClose)
        Controls.Add(btnUpdate)
        Controls.Add(dtgList)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "reservas_lista"
        StartPosition = FormStartPosition.CenterScreen
        Text = "STAYHUB"
        CType(dtgList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents dtgList As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCheckedout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnnew As System.Windows.Forms.Button
End Class
