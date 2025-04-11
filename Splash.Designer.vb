<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splash))
        Label1 = New Label()
        MyProgress = New ProgressBar()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        LblSplash = New Label()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(124, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 19)
        Label1.TabIndex = 0
        Label1.Text = "BANKING AND ATM MANAGMENT "
        ' 
        ' MyProgress
        ' 
        MyProgress.Dock = DockStyle.Bottom
        MyProgress.ForeColor = Color.White
        MyProgress.Location = New Point(0, 237)
        MyProgress.Name = "MyProgress"
        MyProgress.Size = New Size(486, 10)
        MyProgress.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 97)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(20, 202)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 3
        Label2.Text = "Loading.."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(218, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 19)
        Label3.TabIndex = 4
        Label3.Text = "SYSTEM"
        ' 
        ' LblSplash
        ' 
        LblSplash.AutoSize = True
        LblSplash.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSplash.ForeColor = Color.White
        LblSplash.Location = New Point(98, 202)
        LblSplash.Name = "LblSplash"
        LblSplash.Size = New Size(25, 22)
        LblSplash.TabIndex = 5
        LblSplash.Text = "%"
        ' 
        ' Timer1
        ' 
        ' 
        ' splash
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(486, 247)
        Controls.Add(LblSplash)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(MyProgress)
        Controls.Add(Label1)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 4, 5, 4)
        Name = "splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "splash"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MyProgress As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblSplash As Label
    Friend WithEvents Timer1 As Timer
End Class
