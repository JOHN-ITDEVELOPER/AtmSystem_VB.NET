<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        cancel = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        BtnDeposit = New Button()
        BtnLoan = New Button()
        BtnChgpin = New Button()
        BtnWithdraw = New Button()
        BtnMiniState = New Button()
        BtnBalance = New Button()
        Label2 = New Label()
        LblAccNum = New Label()
        LbLogout = New Label()
        Panel3 = New Panel()
        RbtnTheme = New RadioButton()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(cancel, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(cancel)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(692, 78)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(692, 78)
        Panel2.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(648, 3)
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
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(120, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(451, 25)
        Label4.TabIndex = 5
        Label4.Text = "Please Select a Service below and Proceed"
        ' 
        ' cancel
        ' 
        cancel.Image = CType(resources.GetObject("cancel.Image"), Image)
        cancel.Location = New Point(585, 3)
        cancel.Name = "cancel"
        cancel.Size = New Size(33, 29)
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
        ' BtnDeposit
        ' 
        BtnDeposit.BackColor = Color.Lime
        BtnDeposit.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnDeposit.ForeColor = Color.White
        BtnDeposit.Location = New Point(152, 149)
        BtnDeposit.Name = "BtnDeposit"
        BtnDeposit.Size = New Size(108, 52)
        BtnDeposit.TabIndex = 2
        BtnDeposit.Text = "DEPOSIT"
        BtnDeposit.UseVisualStyleBackColor = False
        ' 
        ' BtnLoan
        ' 
        BtnLoan.BackColor = Color.Lime
        BtnLoan.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnLoan.ForeColor = Color.White
        BtnLoan.Location = New Point(152, 236)
        BtnLoan.Name = "BtnLoan"
        BtnLoan.Size = New Size(108, 52)
        BtnLoan.TabIndex = 3
        BtnLoan.Text = "LOAN"
        BtnLoan.UseVisualStyleBackColor = False
        ' 
        ' BtnChgpin
        ' 
        BtnChgpin.BackColor = Color.Lime
        BtnChgpin.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnChgpin.ForeColor = Color.White
        BtnChgpin.Location = New Point(152, 332)
        BtnChgpin.Name = "BtnChgpin"
        BtnChgpin.Size = New Size(108, 52)
        BtnChgpin.TabIndex = 4
        BtnChgpin.Text = "CHANGE PIN"
        BtnChgpin.UseVisualStyleBackColor = False
        ' 
        ' BtnWithdraw
        ' 
        BtnWithdraw.BackColor = Color.Lime
        BtnWithdraw.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnWithdraw.ForeColor = Color.White
        BtnWithdraw.Location = New Point(468, 149)
        BtnWithdraw.Name = "BtnWithdraw"
        BtnWithdraw.Size = New Size(108, 52)
        BtnWithdraw.TabIndex = 5
        BtnWithdraw.Text = "WITHDRAW"
        BtnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' BtnMiniState
        ' 
        BtnMiniState.BackColor = Color.Lime
        BtnMiniState.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnMiniState.ForeColor = Color.White
        BtnMiniState.Location = New Point(468, 245)
        BtnMiniState.Name = "BtnMiniState"
        BtnMiniState.Size = New Size(108, 52)
        BtnMiniState.TabIndex = 6
        BtnMiniState.Text = "MINI STATEMENT"
        BtnMiniState.UseVisualStyleBackColor = False
        ' 
        ' BtnBalance
        ' 
        BtnBalance.BackColor = Color.Lime
        BtnBalance.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnBalance.ForeColor = Color.White
        BtnBalance.Location = New Point(468, 332)
        BtnBalance.Name = "BtnBalance"
        BtnBalance.Size = New Size(108, 52)
        BtnBalance.TabIndex = 7
        BtnBalance.Text = "BALANCE"
        BtnBalance.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(188, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 25)
        Label2.TabIndex = 8
        Label2.Text = "Account Number:"
        ' 
        ' LblAccNum
        ' 
        LblAccNum.AutoSize = True
        LblAccNum.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        LblAccNum.Location = New Point(352, 95)
        LblAccNum.Name = "LblAccNum"
        LblAccNum.Size = New Size(56, 25)
        LblAccNum.TabIndex = 9
        LblAccNum.Text = "Num"
        ' 
        ' LbLogout
        ' 
        LbLogout.AutoSize = True
        LbLogout.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbLogout.ForeColor = Color.Red
        LbLogout.Location = New Point(319, 443)
        LbLogout.Name = "LbLogout"
        LbLogout.Size = New Size(97, 30)
        LbLogout.TabIndex = 10
        LbLogout.Text = "LOGOUT"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveBorder
        Panel3.Controls.Add(RbtnTheme)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 78)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(98, 418)
        Panel3.TabIndex = 11
        ' 
        ' RbtnTheme
        ' 
        RbtnTheme.AutoSize = True
        RbtnTheme.Location = New Point(10, 23)
        RbtnTheme.Name = "RbtnTheme"
        RbtnTheme.Size = New Size(85, 19)
        RbtnTheme.TabIndex = 13
        RbtnTheme.TabStop = True
        RbtnTheme.Text = "DarkTheme"
        RbtnTheme.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(98, 485)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(594, 11)
        Panel4.TabIndex = 12
        ' 
        ' MainPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(692, 496)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(LbLogout)
        Controls.Add(LblAccNum)
        Controls.Add(Label2)
        Controls.Add(BtnBalance)
        Controls.Add(BtnMiniState)
        Controls.Add(BtnWithdraw)
        Controls.Add(BtnChgpin)
        Controls.Add(BtnLoan)
        Controls.Add(BtnDeposit)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainPage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(cancel, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cancel As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnDeposit As Button
    Friend WithEvents BtnLoan As Button
    Friend WithEvents BtnChgpin As Button
    Friend WithEvents BtnWithdraw As Button
    Friend WithEvents BtnMiniState As Button
    Friend WithEvents BtnBalance As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LblAccNum As Label
    Friend WithEvents LbLogout As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RbtnTheme As RadioButton
End Class
