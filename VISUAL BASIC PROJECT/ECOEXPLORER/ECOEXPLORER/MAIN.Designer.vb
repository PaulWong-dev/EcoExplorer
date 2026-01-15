<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMAIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMAIN))
        PictureBox1 = New PictureBox()
        btnClose = New PictureBox()
        btnSignup = New PictureBox()
        btnLogin = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnSignup, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnLogin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(23, 64)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(412, 426)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
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
        btnClose.TabIndex = 1
        btnClose.TabStop = False
        ' 
        ' btnSignup
        ' 
        btnSignup.BackColor = Color.Transparent
        btnSignup.BackgroundImage = CType(resources.GetObject("btnSignup.BackgroundImage"), Image)
        btnSignup.BackgroundImageLayout = ImageLayout.Stretch
        btnSignup.Cursor = Cursors.Hand
        btnSignup.Location = New Point(116, 676)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(225, 85)
        btnSignup.TabIndex = 3
        btnSignup.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), Image)
        btnLogin.BackgroundImageLayout = ImageLayout.Stretch
        btnLogin.Cursor = Cursors.Hand
        btnLogin.Location = New Point(116, 549)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(225, 91)
        btnLogin.TabIndex = 4
        btnLogin.TabStop = False
        ' 
        ' formMAIN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(460, 855)
        Controls.Add(btnLogin)
        Controls.Add(btnSignup)
        Controls.Add(btnClose)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formMAIN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        CType(btnSignup, ComponentModel.ISupportInitialize).EndInit()
        CType(btnLogin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnSignup As PictureBox
    Friend WithEvents btnLogin As PictureBox
End Class
