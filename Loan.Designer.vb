<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loan))
        Panel1 = New Panel()
        cancel = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        BtnBalance = New Button()
        BtnMiniState = New Button()
        BtnWithdraw = New Button()
        BtnChgpin = New Button()
        BtnLoan = New Button()
        Btn50 = New Button()
        Panel2 = New Panel()
        Label2 = New Label()
        Label5 = New Label()
        LblAmount = New Label()
        LbLogout = New Label()
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
        Panel1.Margin = New Padding(6, 5, 6, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(681, 82)
        Panel1.TabIndex = 13
        ' 
        ' cancel
        ' 
        cancel.Image = CType(resources.GetObject("cancel.Image"), Image)
        cancel.Location = New Point(631, 5)
        cancel.Margin = New Padding(6, 5, 6, 5)
        cancel.Name = "cancel"
        cancel.Size = New Size(44, 33)
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
        Label3.Location = New Point(281, 48)
        Label3.Margin = New Padding(6, 0, 6, 0)
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
        Label1.Location = New Point(167, 15)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 23)
        Label1.TabIndex = 5
        Label1.Text = "BANKING AND ATM MANAGMENT "
        ' 
        ' BtnBalance
        ' 
        BtnBalance.BackColor = Color.Lime
        BtnBalance.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnBalance.ForeColor = Color.White
        BtnBalance.Location = New Point(431, 373)
        BtnBalance.Name = "BtnBalance"
        BtnBalance.Size = New Size(151, 52)
        BtnBalance.TabIndex = 19
        BtnBalance.Text = "Kes 10000"
        BtnBalance.UseVisualStyleBackColor = False
        ' 
        ' BtnMiniState
        ' 
        BtnMiniState.BackColor = Color.Lime
        BtnMiniState.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnMiniState.ForeColor = Color.White
        BtnMiniState.Location = New Point(431, 277)
        BtnMiniState.Name = "BtnMiniState"
        BtnMiniState.Size = New Size(151, 52)
        BtnMiniState.TabIndex = 18
        BtnMiniState.Text = "Kes 2000"
        BtnMiniState.UseVisualStyleBackColor = False
        ' 
        ' BtnWithdraw
        ' 
        BtnWithdraw.BackColor = Color.Lime
        BtnWithdraw.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnWithdraw.ForeColor = Color.White
        BtnWithdraw.Location = New Point(431, 189)
        BtnWithdraw.Name = "BtnWithdraw"
        BtnWithdraw.Size = New Size(151, 52)
        BtnWithdraw.TabIndex = 17
        BtnWithdraw.Text = "Kes 500"
        BtnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' BtnChgpin
        ' 
        BtnChgpin.BackColor = Color.Lime
        BtnChgpin.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnChgpin.ForeColor = Color.White
        BtnChgpin.Location = New Point(132, 373)
        BtnChgpin.Name = "BtnChgpin"
        BtnChgpin.Size = New Size(151, 52)
        BtnChgpin.TabIndex = 16
        BtnChgpin.Text = "Kes 5000"
        BtnChgpin.UseVisualStyleBackColor = False
        ' 
        ' BtnLoan
        ' 
        BtnLoan.BackColor = Color.Lime
        BtnLoan.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        BtnLoan.ForeColor = Color.White
        BtnLoan.Location = New Point(132, 277)
        BtnLoan.Name = "BtnLoan"
        BtnLoan.Size = New Size(151, 52)
        BtnLoan.TabIndex = 15
        BtnLoan.Text = "Kes 1000"
        BtnLoan.UseVisualStyleBackColor = False
        ' 
        ' Btn50
        ' 
        Btn50.BackColor = Color.Lime
        Btn50.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Btn50.ForeColor = Color.White
        Btn50.Location = New Point(132, 189)
        Btn50.Name = "Btn50"
        Btn50.Size = New Size(151, 52)
        Btn50.TabIndex = 14
        Btn50.Text = "Kes 50"
        Btn50.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 497)
        Panel2.Margin = New Padding(6, 5, 6, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(681, 14)
        Panel2.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(281, 96)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 25)
        Label2.TabIndex = 6
        Label2.Text = "GET LOAN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(202, 140)
        Label5.Margin = New Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 23)
        Label5.TabIndex = 22
        Label5.Text = "BALANCE Kes :"
        ' 
        ' LblAmount
        ' 
        LblAmount.AutoSize = True
        LblAmount.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        LblAmount.ForeColor = SystemColors.ControlText
        LblAmount.Location = New Point(375, 140)
        LblAmount.Margin = New Padding(6, 0, 6, 0)
        LblAmount.Name = "LblAmount"
        LblAmount.Size = New Size(92, 23)
        LblAmount.TabIndex = 23
        LblAmount.Text = "AMOUNT"
        ' 
        ' LbLogout
        ' 
        LbLogout.AutoSize = True
        LbLogout.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LbLogout.ForeColor = Color.Red
        LbLogout.Location = New Point(299, 462)
        LbLogout.Name = "LbLogout"
        LbLogout.Size = New Size(97, 30)
        LbLogout.TabIndex = 30
        LbLogout.Text = "LOGOUT"
        ' 
        ' Loan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(681, 511)
        Controls.Add(LbLogout)
        Controls.Add(Label5)
        Controls.Add(LblAmount)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(BtnBalance)
        Controls.Add(BtnMiniState)
        Controls.Add(BtnWithdraw)
        Controls.Add(BtnChgpin)
        Controls.Add(BtnLoan)
        Controls.Add(Btn50)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Loan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Loan"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(cancel, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cancel As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBalance As Button
    Friend WithEvents BtnMiniState As Button
    Friend WithEvents BtnWithdraw As Button
    Friend WithEvents BtnChgpin As Button
    Friend WithEvents BtnLoan As Button
    Friend WithEvents Btn50 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblAmount As Label
    Friend WithEvents LbLogout As Label
End Class
