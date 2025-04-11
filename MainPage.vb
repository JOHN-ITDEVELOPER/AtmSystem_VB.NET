Public Class MainPage

    Private AccNum As String

    Public Sub New()
    End Sub

    Public Sub New(acc As String)

        ' This call is required by the designer.
        InitializeComponent()
        AccNum = acc

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Property acc As String

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LblAccNum.Text = AccNum
        If LblAccNum IsNot Nothing Then
            LblAccNum.Text = AccNum
        Else
            'Handle the case where LblAccNum Is Not initialized
            MessageBox.Show("LblAccNum is not initialized.")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub LbLogout_Click(sender As Object, e As EventArgs) Handles LbLogout.Click

        Dim obj = New login()
        obj.Show()
        LblAccNum.Text = AccNum
        Me.Hide()

    End Sub

    Private Sub BtnDeposit_Click(sender As Object, e As EventArgs) Handles BtnDeposit.Click
        Dim obj = New Deposit()
        obj.acc = LblAccNum.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnBalance_Click(sender As Object, e As EventArgs) Handles BtnBalance.Click
        Dim obj = New Balance()
        obj.acc = LblAccNum.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnWithdraw_Click(sender As Object, e As EventArgs) Handles BtnWithdraw.Click
        Dim obj = New Withdraw()
        obj.acc = LblAccNum.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnChgpin_Click(sender As Object, e As EventArgs) Handles BtnChgpin.Click
        Dim obj = New ChangePin()
        obj.acc = LblAccNum.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLoan_Click(sender As Object, e As EventArgs) Handles BtnLoan.Click
        Dim obj = New Loan()
        obj.acc = LblAccNum.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMiniState_Click(sender As Object, e As EventArgs) Handles BtnMiniState.Click
        Dim obj = New MiniStatement()
        obj.acc = LblAccNum.Text
        obj.Show()
        Me.Hide()
    End Sub
End Class