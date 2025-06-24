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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quartos))
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
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(24, 21)
        TabControl1.Margin = New Padding(4, 3, 4, 3)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(561, 362)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
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
        TabPage1.Size = New Size(553, 334)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Novo quarto"
        TabPage1.UseVisualStyleBackColor = True
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
        TabPage2.Controls.Add(DataGridView1)
        TabPage2.Controls.Add(Label5)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Margin = New Padding(4, 3, 4, 3)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4, 3, 4, 3)
        TabPage2.Size = New Size(553, 334)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Lista de quartos"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(19, 74)
        DataGridView1.Name = "DataGridView1"
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
        ' quartos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 397)
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
        ResumeLayout(False)

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
End Class
