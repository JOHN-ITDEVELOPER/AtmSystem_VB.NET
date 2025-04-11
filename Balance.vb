Imports Microsoft.Data.SqlClient

Public Class Balance
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VB.NET\ATM.vb\bin\ATMvbNewDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub GetBalance()
        Con.Open()
        Dim cmd As SqlCommand
        Dim query = "select Balance from AccountTbl where AccNum=" & Account & ""
        cmd = New SqlCommand(query, Con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        LblBalance.Text = Convert.ToInt32(dt.Rows(0)(0).ToString())
        Con.Close()
    End Sub
    Dim Account As Integer

    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Account = Convert.ToInt32(acc)
        lblAccNum.Text = acc
        GetBalance()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblAccNum.Click

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Application.Exit()
    End Sub
    Public Property acc As String
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Dim obj = New MainPage
        ' obj.Show()
        'Me.Show(MainPage)
        If Not MainPage.Visible Then
            MainPage.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub LblBalance_Click(sender As Object, e As EventArgs) Handles LblBalance.Click

    End Sub
End Class