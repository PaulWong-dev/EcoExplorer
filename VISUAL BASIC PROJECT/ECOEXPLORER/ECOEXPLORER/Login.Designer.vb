<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLogin))
        btnClose = New PictureBox()
        PictureBox1 = New PictureBox()
        txtUser = New RichTextBox()
        txtPassword = New RichTextBox()
        lblName = New Label()
        lblPassword = New Label()
        btnLogin = New PictureBox()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnLogin, ComponentModel.ISupportInitialize).BeginInit()
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
        btnClose.TabIndex = 2
        btnClose.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(-18, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(272, 96)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = Color.Linen
        txtUser.Font = New Font("Microsoft YaHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUser.Location = New Point(75, 276)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(319, 49)
        txtUser.TabIndex = 4
        txtUser.Text = ""
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Linen
        txtPassword.Font = New Font("Microsoft YaHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(75, 392)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(319, 49)
        txtPassword.TabIndex = 5
        txtPassword.Text = ""
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(75, 238)
        lblName.Name = "lblName"
        lblName.Size = New Size(169, 35)
        lblName.TabIndex = 6
        lblName.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(75, 354)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(179, 35)
        lblPassword.TabIndex = 7
        lblPassword.Text = "Password:"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), Image)
        btnLogin.BackgroundImageLayout = ImageLayout.Stretch
        btnLogin.Cursor = Cursors.Hand
        btnLogin.Location = New Point(112, 621)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(225, 91)
        btnLogin.TabIndex = 8
        btnLogin.TabStop = False
        ' 
        ' formLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(460, 855)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(lblName)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        Controls.Add(PictureBox1)
        Controls.Add(btnClose)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "formLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnLogin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUser As RichTextBox
    Friend WithEvents txtPassword As RichTextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As PictureBox
End Class
