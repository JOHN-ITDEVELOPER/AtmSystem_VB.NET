Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32.System

Public Class Deposit


    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim obj = New MainPage()
        obj.acc = acc
        obj.Show()
        Me.Hide()
    End Sub
    Public Property acc As String
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VB.NET\ATM.vb\bin\ATMvbNewDb.mdf;Integrated Security=True;Connect Timeout=30")
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
        Con.Close()
    End Sub
    Private Sub UpdateBal()
        Dim Account = Convert.ToInt32(acc)
        Dim NewBal = OldBalance + Convert.ToInt32(TbxAmount.Text)
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
    Private Sub BtnDeposit_Click(sender As Object, e As EventArgs) Handles BtnDeposit.Click
        If TbxAmount.Text = "" Or Convert.ToInt32(TbxAmount.Text) < 1 Then
            MsgBox("Missing Information")
        Else
            Dim Account = Convert.ToInt32(acc)
            Dim TrType = "Deposit"
            Try
                Dim bal As Integer = 0
                Dim query As String = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)"

                Dim cmd As New SqlCommand(query, Con)

                ' Assign values using parameters
                cmd.Parameters.AddWithValue("@AccNum", Integer.Parse(MyAcc))
                cmd.Parameters.AddWithValue("@Type", TrType)
                cmd.Parameters.AddWithValue("@Amount", TbxAmount.Text) ' Should be another field, or fix it
                cmd.Parameters.AddWithValue("@TDate", System.DateTime.Today.Date)

                Con.Open()
                cmd.ExecuteNonQuery()
                Con.Close()

                MsgBox("Deposit Successfull!")
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                    UpdateBal()
                End If
            End Try
        End If
        Dim log = New login()
        acc = log.AccNum
    End Sub
    Dim MyAcc As Integer
    Private Sub Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(acc)
        GetBalance()
    End Sub
End Class