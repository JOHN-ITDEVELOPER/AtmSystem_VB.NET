<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Panel1 = New Panel()
        cancel = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TbxAccNum = New TextBox()
        TbxPin = New TextBox()
        LblSignup = New Label()
        BtnLogin = New Button()
        Panel1.SuspendLayout()
        CType(cancel, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(cancel)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(556, 78)
        Panel1.TabIndex = 0
        ' 
        ' cancel
        ' 
        cancel.Image = CType(resources.GetObject("cancel.Image"), Image)
        cancel.Location = New Point(516, 3)
        cancel.Name = "cancel"
        cancel.Size = New Size(37, 29)
        cancel.SizeMode = PictureBoxSizeMode.StretchImage
        cancel.TabIndex = 7
        cancel.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(234, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 23)
        Label3.TabIndex = 6
        Label3.Text = "SYSTEM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(140, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 23)
        Label1.TabIndex = 5
        Label1.Text = "BANKING AND ATM MANAGMENT "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(201, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 25)
        Label2.TabIndex = 1
        Label2.Text = "LOGIN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(15, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(186, 23)
        Label4.TabIndex = 2
        Label4.Text = "ACCOUNT NUMBER"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(15, 219)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 23)
        Label5.TabIndex = 3
        Label5.Text = "LOGIN PIN"
        ' 
        ' TbxAccNum
        ' 
        TbxAccNum.Location = New Point(215, 146)
        TbxAccNum.Name = "TbxAccNum"
        TbxAccNum.Size = New Size(245, 27)
        TbxAccNum.TabIndex = 4
        ' 
        ' TbxPin
        ' 
        TbxPin.Location = New Point(215, 213)
        TbxPin.Name = "TbxPin"
        TbxPin.Size = New Size(245, 27)
        TbxPin.TabIndex = 5
        ' 
        ' LblSignup
        ' 
        LblSignup.AutoSize = True
        LblSignup.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSignup.Location = New Point(243, 316)
        LblSignup.Name = "LblSignup"
        LblSignup.Size = New Size(89, 25)
        LblSignup.TabIndex = 1
        LblSignup.Text = "SIGNUP"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        BtnLogin.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(215, 256)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(149, 41)
        BtnLogin.TabIndex = 6
        BtnLogin.Text = "LOGIN"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(556, 364)
        Controls.Add(BtnLogin)
        Controls.Add(TbxPin)
        Controls.Add(TbxAccNum)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(LblSignup)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(cancel, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbxAccNum As TextBox
    Friend WithEvents TbxPin As TextBox
    Friend WithEvents LblSignup As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents cancel As PictureBox
End Class
