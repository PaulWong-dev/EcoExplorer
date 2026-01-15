<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formRegister))
        btnClose = New PictureBox()
        PictureBox1 = New PictureBox()
        btnPfp = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        txtEmail = New RichTextBox()
        lblEmail = New Label()
        Label1 = New Label()
        txtName = New RichTextBox()
        lblPassword = New Label()
        txtPass = New RichTextBox()
        lblCfPass = New Label()
        txtConPass = New RichTextBox()
        btnSignup = New PictureBox()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnPfp, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnSignup, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), Image)
        btnClose.BackgroundImageLayout = ImageLayout.Stretch
        btnClose.Cursor = Cursors.Hand
        btnClose.Location = New Point(432, -2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(30, 30)
        btnClose.TabIndex = 3
        btnClose.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(290, 63)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' btnPfp
        ' 
        btnPfp.BackColor = Color.Transparent
        btnPfp.BackgroundImage = CType(resources.GetObject("btnPfp.BackgroundImage"), Image)
        btnPfp.BackgroundImageLayout = ImageLayout.Stretch
        btnPfp.Cursor = Cursors.Hand
        btnPfp.Location = New Point(177, 81)
        btnPfp.Name = "btnPfp"
        btnPfp.Size = New Size(100, 100)
        btnPfp.SizeMode = PictureBoxSizeMode.StretchImage
        btnPfp.TabIndex = 5
        btnPfp.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.Linen
        txtEmail.Location = New Point(93, 230)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(266, 41)
        txtEmail.TabIndex = 6
        txtEmail.Text = ""
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.Transparent
        lblEmail.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(93, 206)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(65, 21)
        lblEmail.TabIndex = 11
        lblEmail.Text = "Email:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(93, 275)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 21)
        Label1.TabIndex = 13
        Label1.Text = "Username:"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.Linen
        txtName.Location = New Point(93, 299)
        txtName.Name = "txtName"
        txtName.Size = New Size(266, 41)
        txtName.TabIndex = 12
        txtName.Text = ""
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(93, 345)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(110, 21)
        lblPassword.TabIndex = 15
        lblPassword.Text = "Password:"
        ' 
        ' txtPass
        ' 
        txtPass.BackColor = Color.Linen
        txtPass.Location = New Point(93, 369)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(266, 41)
        txtPass.TabIndex = 14
        txtPass.Text = ""
        ' 
        ' lblCfPass
        ' 
        lblCfPass.AutoSize = True
        lblCfPass.BackColor = Color.Transparent
        lblCfPass.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCfPass.Location = New Point(93, 416)
        lblCfPass.Name = "lblCfPass"
        lblCfPass.Size = New Size(188, 21)
        lblCfPass.TabIndex = 17
        lblCfPass.Text = "Confirm Password:"
        ' 
        ' txtConPass
        ' 
        txtConPass.BackColor = Color.Linen
        txtConPass.Location = New Point(93, 440)
        txtConPass.Name = "txtConPass"
        txtConPass.Size = New Size(266, 41)
        txtConPass.TabIndex = 16
        txtConPass.Text = ""
        ' 
        ' btnSignup
        ' 
        btnSignup.BackColor = Color.Transparent
        btnSignup.BackgroundImage = CType(resources.GetObject("btnSignup.BackgroundImage"), Image)
        btnSignup.BackgroundImageLayout = ImageLayout.Stretch
        btnSignup.Cursor = Cursors.Hand
        btnSignup.Location = New Point(128, 615)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(174, 64)
        btnSignup.TabIndex = 21
        btnSignup.TabStop = False
        ' 
        ' formRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(460, 855)
        Controls.Add(btnSignup)
        Controls.Add(lblCfPass)
        Controls.Add(txtConPass)
        Controls.Add(lblPassword)
        Controls.Add(txtPass)
        Controls.Add(Label1)
        Controls.Add(txtName)
        Controls.Add(lblEmail)
        Controls.Add(txtEmail)
        Controls.Add(btnPfp)
        Controls.Add(PictureBox1)
        Controls.Add(btnClose)
        FormBorderStyle = FormBorderStyle.None
        Name = "formRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnPfp, ComponentModel.ISupportInitialize).EndInit()
        CType(btnSignup, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPfp As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtEmail As RichTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As RichTextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPass As RichTextBox
    Friend WithEvents lblCfPass As Label
    Friend WithEvents txtConPass As RichTextBox
    Friend WithEvents btnSignup As PictureBox
End Class
