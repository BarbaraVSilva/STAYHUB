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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        btn_entrar = New Guna.UI2.WinForms.Guna2Button()
        Label4 = New Label()
        Label3 = New Label()
        txt_email = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txt_confirmaSenha = New TextBox()
        Label5 = New Label()
        txt_novaSenha = New TextBox()
        Label6 = New Label()
        txt_cpf = New MaskedTextBox()
        btn_visualizar = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        btn_cancelar = New Guna.UI2.WinForms.Guna2Button()
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
        btn_entrar.Location = New Point(88, 266)
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
        ' txt_email
        ' 
        txt_email.Location = New Point(42, 161)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(182, 23)
        txt_email.TabIndex = 13
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 21
        Label2.Text = "CPF"
        ' 
        ' txt_confirmaSenha
        ' 
        txt_confirmaSenha.Location = New Point(261, 213)
        txt_confirmaSenha.Name = "txt_confirmaSenha"
        txt_confirmaSenha.PasswordChar = "*"c
        txt_confirmaSenha.Size = New Size(182, 23)
        txt_confirmaSenha.TabIndex = 26
        txt_confirmaSenha.UseSystemPasswordChar = True
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
        ' txt_novaSenha
        ' 
        txt_novaSenha.Location = New Point(261, 161)
        txt_novaSenha.Name = "txt_novaSenha"
        txt_novaSenha.PasswordChar = "*"c
        txt_novaSenha.Size = New Size(182, 23)
        txt_novaSenha.TabIndex = 24
        txt_novaSenha.UseSystemPasswordChar = True
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
        ' txt_cpf
        ' 
        txt_cpf.Location = New Point(44, 216)
        txt_cpf.Mask = "999,999,999-99"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(181, 23)
        txt_cpf.TabIndex = 27
        ' 
        ' btn_visualizar
        ' 
        btn_visualizar.CustomizableEdges = CustomizableEdges5
        btn_visualizar.DisabledState.BorderColor = Color.DarkGray
        btn_visualizar.DisabledState.CustomBorderColor = Color.DarkGray
        btn_visualizar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_visualizar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_visualizar.FillColor = Color.White
        btn_visualizar.Font = New Font("Segoe UI", 9F)
        btn_visualizar.ForeColor = Color.White
        btn_visualizar.Image = CType(resources.GetObject("btn_visualizar.Image"), Image)
        btn_visualizar.ImageSize = New Size(17, 17)
        btn_visualizar.Location = New Point(414, 163)
        btn_visualizar.Name = "btn_visualizar"
        btn_visualizar.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btn_visualizar.Size = New Size(27, 19)
        btn_visualizar.TabIndex = 28
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges7
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.White
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), Image)
        Guna2Button1.ImageSize = New Size(17, 17)
        Guna2Button1.Location = New Point(414, 215)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button1.Size = New Size(27, 19)
        Guna2Button1.TabIndex = 29
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.BorderRadius = 10
        btn_cancelar.CustomizableEdges = CustomizableEdges9
        btn_cancelar.DisabledState.BorderColor = Color.DarkGray
        btn_cancelar.DisabledState.CustomBorderColor = Color.DarkGray
        btn_cancelar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_cancelar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_cancelar.FillColor = Color.DarkBlue
        btn_cancelar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_cancelar.ForeColor = Color.White
        btn_cancelar.Location = New Point(259, 266)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btn_cancelar.Size = New Size(121, 38)
        btn_cancelar.TabIndex = 30
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.Tile = True
        ' 
        ' senha
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(485, 325)
        Controls.Add(btn_cancelar)
        Controls.Add(Guna2Button1)
        Controls.Add(btn_visualizar)
        Controls.Add(txt_cpf)
        Controls.Add(txt_confirmaSenha)
        Controls.Add(Label5)
        Controls.Add(txt_novaSenha)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Guna2PictureBox2)
        Controls.Add(btn_entrar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txt_email)
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
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_confirmaSenha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_novaSenha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents btn_visualizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cancelar As Guna.UI2.WinForms.Guna2Button
End Class
