<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLoading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLoading))
        PictureBox1 = New PictureBox()
        lblLoading = New Label()
        Timer1 = New Timer(components)
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(191, 79)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(276, 261)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblLoading
        ' 
        lblLoading.AutoSize = True
        lblLoading.BackColor = Color.Transparent
        lblLoading.Font = New Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLoading.Location = New Point(40, 358)
        lblLoading.Name = "lblLoading"
        lblLoading.Size = New Size(597, 59)
        lblLoading.TabIndex = 1
        lblLoading.Text = "LOADING IN PROGRESS . . ."
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 1.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(627, 475)
        Label1.Name = "Label1"
        Label1.Size = New Size(7, 3)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' formLoading
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(649, 450)
        Controls.Add(Label1)
        Controls.Add(lblLoading)
        Controls.Add(PictureBox1)
        Cursor = Cursors.WaitCursor
        FormBorderStyle = FormBorderStyle.None
        Name = "formLoading"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblLoading As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label

End Class
