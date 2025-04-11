<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deposit))
        Panel1 = New Panel()
        cancel = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        TbxAmount = New TextBox()
        BtnDeposit = New Button()
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
        Panel1.Size = New Size(675, 82)
        Panel1.TabIndex = 2
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
        Label3.Location = New Point(253, 42)
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
        Label1.Location = New Point(154, 9)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 23)
        Label1.TabIndex = 5
        Label1.Text = "BANKING AND ATM MANAGMENT "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(253, 103)
        Label6.Margin = New Padding(6, 0, 6, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 25)
        Label6.TabIndex = 6
        Label6.Text = "DEPOSIT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(128, 178)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 25)
        Label2.TabIndex = 6
        Label2.Text = "AMOUNT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(309, 347)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 25)
        Label4.TabIndex = 7
        Label4.Text = "Return"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 377)
        Panel2.Margin = New Padding(6, 5, 6, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(675, 14)
        Panel2.TabIndex = 8
        ' 
        ' TbxAmount
        ' 
        TbxAmount.Location = New Point(271, 165)
        TbxAmount.Multiline = True
        TbxAmount.Name = "TbxAmount"
        TbxAmount.Size = New Size(234, 38)
        TbxAmount.TabIndex = 9
        ' 
        ' BtnDeposit
        ' 
        BtnDeposit.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        BtnDeposit.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDeposit.ForeColor = Color.White
        BtnDeposit.Location = New Point(271, 280)
        BtnDeposit.Name = "BtnDeposit"
        BtnDeposit.Size = New Size(149, 41)
        BtnDeposit.TabIndex = 10
        BtnDeposit.Text = "DEPOSIT"
        BtnDeposit.UseVisualStyleBackColor = False
        ' 
        ' Deposit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(675, 391)
        Controls.Add(BtnDeposit)
        Controls.Add(TbxAmount)
        Controls.Add(Panel2)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Deposit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DEPOSIT"
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TbxAmount As TextBox
    Friend WithEvents BtnDeposit As Button
End Class
