<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class senha
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(senha))
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        btn_redefinir = New Guna.UI2.WinForms.Guna2Button()
        Label4 = New Label()
        Label3 = New Label()
        txt_email = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txt_conf = New TextBox()
        Label5 = New Label()
        txt_novasenha = New TextBox()
        Label6 = New Label()
        txt_cpf = New MaskedTextBox()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.BackColor = Color.Transparent
        Guna2PictureBox2.BackgroundImageLayout = ImageLayout.None
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges5
        Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), Image)
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(170, -9)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2PictureBox2.Size = New Size(130, 130)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox2.TabIndex = 20
        Guna2PictureBox2.TabStop = False
        Guna2PictureBox2.UseTransparentBackground = True
        ' 
        ' btn_redefinir
        ' 
        btn_redefinir.BorderRadius = 10
        btn_redefinir.CustomizableEdges = CustomizableEdges7
        btn_redefinir.DisabledState.BorderColor = Color.DarkGray
        btn_redefinir.DisabledState.CustomBorderColor = Color.DarkGray
        btn_redefinir.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_redefinir.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_redefinir.FillColor = Color.DarkBlue
        btn_redefinir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_redefinir.ForeColor = Color.White
        btn_redefinir.Location = New Point(171, 265)
        btn_redefinir.Name = "btn_redefinir"
        btn_redefinir.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btn_redefinir.Size = New Size(121, 38)
        btn_redefinir.TabIndex = 19
        btn_redefinir.Text = "Redefinir"
        btn_redefinir.Tile = True
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
        ' txt_conf
        ' 
        txt_conf.Location = New Point(261, 213)
        txt_conf.Name = "txt_conf"
        txt_conf.PasswordChar = "*"c
        txt_conf.Size = New Size(182, 23)
        txt_conf.TabIndex = 26
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
        ' txt_novasenha
        ' 
        txt_novasenha.Location = New Point(261, 161)
        txt_novasenha.Name = "txt_novasenha"
        txt_novasenha.PasswordChar = "*"c
        txt_novasenha.Size = New Size(182, 23)
        txt_novasenha.TabIndex = 24
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
        txt_cpf.Location = New Point(42, 213)
        txt_cpf.Mask = "999,999,999-99"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(182, 23)
        txt_cpf.TabIndex = 27
        ' 
        ' senha
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(485, 325)
        Controls.Add(txt_cpf)
        Controls.Add(txt_conf)
        Controls.Add(Label5)
        Controls.Add(txt_novasenha)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Guna2PictureBox2)
        Controls.Add(btn_redefinir)
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
    Friend WithEvents btn_redefinir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_conf As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_novasenha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
End Class