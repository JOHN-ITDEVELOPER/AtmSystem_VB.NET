﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Balance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Balance))
        Panel1 = New Panel()
        cancel = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblAccNum = New Label()
        LblBalance = New Label()
        Panel2 = New Panel()
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
        Panel1.Size = New Size(700, 82)
        Panel1.TabIndex = 1
        ' 
        ' cancel
        ' 
        cancel.Image = CType(resources.GetObject("cancel.Image"), Image)
        cancel.Location = New Point(647, 5)
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
        Label3.Location = New Point(322, 49)
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
        Label1.Location = New Point(192, 15)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 23)
        Label1.TabIndex = 5
        Label1.Text = "BANKING AND ATM MANAGMENT "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(291, 331)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 25)
        Label2.TabIndex = 2
        Label2.Text = "Return"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(96, 134)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 25)
        Label4.TabIndex = 3
        Label4.Text = "Account Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(96, 211)
        Label5.Margin = New Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 25)
        Label5.TabIndex = 4
        Label5.Text = "My Balance"
        ' 
        ' lblAccNum
        ' 
        lblAccNum.AutoSize = True
        lblAccNum.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        lblAccNum.ForeColor = SystemColors.ControlText
        lblAccNum.Location = New Point(337, 134)
        lblAccNum.Margin = New Padding(6, 0, 6, 0)
        lblAccNum.Name = "lblAccNum"
        lblAccNum.Size = New Size(103, 25)
        lblAccNum.TabIndex = 5
        lblAccNum.Text = "AccNum"
        ' 
        ' LblBalance
        ' 
        LblBalance.AutoSize = True
        LblBalance.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        LblBalance.ForeColor = SystemColors.ControlText
        LblBalance.Location = New Point(344, 211)
        LblBalance.Margin = New Padding(6, 0, 6, 0)
        LblBalance.Name = "LblBalance"
        LblBalance.Size = New Size(96, 25)
        LblBalance.TabIndex = 6
        LblBalance.Text = "Balance"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 377)
        Panel2.Margin = New Padding(6, 5, 6, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(700, 14)
        Panel2.TabIndex = 7
        ' 
        ' Balance
        ' 
        AutoScaleDimensions = New SizeF(13F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 391)
        Controls.Add(Panel2)
        Controls.Add(LblBalance)
        Controls.Add(lblAccNum)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 15.75F, FontStyle.Bold)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(6, 5, 6, 5)
        Name = "Balance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Balance"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAccNum As Label
    Friend WithEvents LblBalance As Label
    Friend WithEvents Panel2 As Panel
End Class
