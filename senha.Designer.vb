<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class senha
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(senha))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        btn_entrar = New Guna.UI2.WinForms.Guna2Button()
        Label4 = New Label()
        Label3 = New Label()
        txt_usuario = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.BackColor = Color.Transparent
        Guna2PictureBox2.BackgroundImageLayout = ImageLayout.None
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), Image)
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(170, -9)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox2.Size = New Size(130, 130)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox2.TabIndex = 20
        Guna2PictureBox2.TabStop = False
        Guna2PictureBox2.UseTransparentBackground = True
        ' 
        ' btn_entrar
        ' 
        btn_entrar.BorderRadius = 10
        btn_entrar.CustomizableEdges = CustomizableEdges3
        btn_entrar.DisabledState.BorderColor = Color.DarkGray
        btn_entrar.DisabledState.CustomBorderColor = Color.DarkGray
        btn_entrar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_entrar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_entrar.FillColor = Color.DarkBlue
        btn_entrar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_entrar.ForeColor = Color.White
        btn_entrar.Location = New Point(171, 265)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btn_entrar.Size = New Size(121, 38)
        btn_entrar.TabIndex = 19
        btn_entrar.Text = "Redefinir"
        btn_entrar.Tile = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(42, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 15)
        Label4.TabIndex = 18
        Label4.Text = "Insira seus dados abaixo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(40, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 21)
        Label3.TabIndex = 17
        Label3.Text = "Redefinir senha"
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Location = New Point(42, 161)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(182, 23)
        txt_usuario.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 12
        Label1.Text = "E-mail"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(42, 213)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 23)
        TextBox1.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 21
        Label2.Text = "CPF"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(261, 213)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(182, 23)
        TextBox2.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(259, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 15)
        Label5.TabIndex = 25
        Label5.Text = "Confirmar senha"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(261, 161)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(182, 23)
        TextBox3.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(259, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 15)
        Label6.TabIndex = 23
        Label6.Text = "Nova senha"
        ' 
        ' senha
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(485, 325)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Guna2PictureBox2)
        Controls.Add(btn_entrar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txt_usuario)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "senha"
        Text = "STAYHUB"
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_entrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
End Class
