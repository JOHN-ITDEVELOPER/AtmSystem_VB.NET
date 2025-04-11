<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TbxAccNum = New TextBox()
        TbxName = New TextBox()
        TbxFname = New TextBox()
        TbxPin = New TextBox()
        TbxOccupation = New TextBox()
        TbxPhone = New TextBox()
        Label10 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label11 = New Label()
        RtbxAddress = New RichTextBox()
        BtnSubmit = New Button()
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        LbLogout = New Label()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(974, 78)
        Panel2.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(930, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(41, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(324, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(320, 23)
        Label4.TabIndex = 5
        Label4.Text = "BANKING AND ATM MANAGMENT "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label1.Location = New Point(80, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 25)
        Label1.TabIndex = 10
        Label1.Text = "ACC NUM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label2.Location = New Point(80, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 25)
        Label2.TabIndex = 11
        Label2.Text = "NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label3.Location = New Point(80, 267)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 12
        Label3.Text = "FNAME"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label5.Location = New Point(80, 333)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 25)
        Label5.TabIndex = 13
        Label5.Text = "ADDRESS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label6.Location = New Point(540, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 25)
        Label6.TabIndex = 14
        Label6.Text = "PIN"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label7.Location = New Point(540, 213)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 25)
        Label7.TabIndex = 15
        Label7.Text = "EDUCATION"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label8.Location = New Point(540, 272)
        Label8.Name = "Label8"
        Label8.Size = New Size(153, 25)
        Label8.TabIndex = 16
        Label8.Text = "OCCUPATION"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label9.Location = New Point(540, 403)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 25)
        Label9.TabIndex = 17
        Label9.Text = "DOB"
        ' 
        ' TbxAccNum
        ' 
        TbxAccNum.Location = New Point(232, 146)
        TbxAccNum.Name = "TbxAccNum"
        TbxAccNum.Size = New Size(214, 23)
        TbxAccNum.TabIndex = 18
        ' 
        ' TbxName
        ' 
        TbxName.Location = New Point(232, 215)
        TbxName.Name = "TbxName"
        TbxName.Size = New Size(214, 23)
        TbxName.TabIndex = 18
        ' 
        ' TbxFname
        ' 
        TbxFname.Location = New Point(232, 267)
        TbxFname.Name = "TbxFname"
        TbxFname.Size = New Size(214, 23)
        TbxFname.TabIndex = 18
        ' 
        ' TbxPin
        ' 
        TbxPin.Location = New Point(707, 146)
        TbxPin.Name = "TbxPin"
        TbxPin.Size = New Size(214, 23)
        TbxPin.TabIndex = 18
        ' 
        ' TbxOccupation
        ' 
        TbxOccupation.Location = New Point(707, 272)
        TbxOccupation.Name = "TbxOccupation"
        TbxOccupation.Size = New Size(214, 23)
        TbxOccupation.TabIndex = 18
        ' 
        ' TbxPhone
        ' 
        TbxPhone.Location = New Point(707, 339)
        TbxPhone.Name = "TbxPhone"
        TbxPhone.Size = New Size(214, 23)
        TbxPhone.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label10.Location = New Point(540, 333)
        Label10.Name = "Label10"
        Label10.Size = New Size(83, 25)
        Label10.TabIndex = 20
        Label10.Text = "PHONE"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(708, 407)
        DateTimePicker1.MaxDate = New Date(2025, 2, 26, 0, 0, 0, 0)
        DateTimePicker1.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 21
        DateTimePicker1.Value = New Date(2025, 2, 26, 0, 0, 0, 0)
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(338, 81)
        Label11.Name = "Label11"
        Label11.Size = New Size(259, 25)
        Label11.TabIndex = 22
        Label11.Text = "REGISTER FOR ACCOUNT"
        ' 
        ' RtbxAddress
        ' 
        RtbxAddress.Location = New Point(232, 334)
        RtbxAddress.Name = "RtbxAddress"
        RtbxAddress.Size = New Size(214, 115)
        RtbxAddress.TabIndex = 23
        RtbxAddress.Text = ""
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        BtnSubmit.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSubmit.ForeColor = Color.White
        BtnSubmit.Location = New Point(426, 482)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(119, 42)
        BtnSubmit.TabIndex = 24
        BtnSubmit.Text = "SUBMIT"
        BtnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 571)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(974, 10)
        Panel1.TabIndex = 27
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"DIPLOMA ", "DEGREE", "MASTERS", "PHD", "NULL"})
        ComboBox1.Location = New Point(707, 213)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(214, 23)
        ComboBox1.TabIndex = 28
        ' 
        ' LbLogout
        ' 
        LbLogout.AutoSize = True
        LbLogout.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbLogout.ForeColor = Color.Red
        LbLogout.Location = New Point(453, 527)
        LbLogout.Name = "LbLogout"
        LbLogout.Size = New Size(68, 30)
        LbLogout.TabIndex = 29
        LbLogout.Text = "BACK"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(974, 581)
        Controls.Add(LbLogout)
        Controls.Add(ComboBox1)
        Controls.Add(Panel1)
        Controls.Add(BtnSubmit)
        Controls.Add(RtbxAddress)
        Controls.Add(Label11)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label10)
        Controls.Add(TbxPhone)
        Controls.Add(TbxOccupation)
        Controls.Add(TbxFname)
        Controls.Add(TbxPin)
        Controls.Add(TbxName)
        Controls.Add(TbxAccNum)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TbxAccNum As TextBox
    Friend WithEvents TbxName As TextBox
    Friend WithEvents TbxFname As TextBox
    Friend WithEvents TbxPin As TextBox
    Friend WithEvents TbxOccupation As TextBox
    Friend WithEvents TbxPhone As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents RtbxAddress As RichTextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LbLogout As Label
End Class
