Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Extensions

Public Class Loan
    Private Sub BtnChgpin_Click(sender As Object, e As EventArgs) Handles BtnChgpin.Click

    End Sub
    Public Property acc As String
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VB.NET\ATM.vb\bin\ATMvbNewDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim OldBalance = 0
    Private Sub GetBalance()
        Con.Open()
        Dim cmd As SqlCommand
        Dim query = "select Balance from AccountTbl where AccNum=" & acc & ""
        cmd = New SqlCommand(query, Con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        LblAmount.Text = OldBalance
        Con.Close()
    End Sub
    Dim MyAcc = 0
    Private Sub Loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBalance()
        MyAcc = Convert.ToInt32(acc)
    End Sub
    Dim Amount As Integer
    Private Sub UpdateBal(Amt As Integer)
        Dim Account = Convert.ToInt32(acc)
        Dim NewBal = OldBalance - Amt
        Try

            Con.Open()
            Dim query = "Update AccountTbl set Balance =" & NewBal & " where AccNum =" & acc & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Balance updated")
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnDeposit_Click(sender As Object, e As EventArgs) Handles Btn50.Click
        If OldBalance < 50 Then
            MsgBox("insufficient balance")
        Else
            Dim Account = Convert.ToInt32(acc)
            Dim TrType = "Withdraw"
            Amount = 50
            Try
                Dim bal As Integer = 0
                Dim query As String = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)"

                Dim cmd As New SqlCommand(query, Con)


                cmd.Parameters.AddWithValue("@AccNum", Integer.Parse(MyAcc))
                cmd.Parameters.AddWithValue("@Type", TrType)
                cmd.Parameters.AddWithValue("@Amount", Btn50.Text) ' Should be another field, or fix it
                cmd.Parameters.AddWithValue("@TDate", System.DateTime.Today.Date)

                Con.Open()
                cmd.ExecuteNonQuery()
                Con.Close()

                MsgBox("Withdraw Successfull!")
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                    UpdateBal(Amount)
                End If
            End Try
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Application.Exit()
    End Sub

    Private Sub LbLogout_Click(sender As Object, e As EventArgs) Handles LbLogout.Click
        MainPage.Show()
        Me.Hide()
    End Sub
End Class