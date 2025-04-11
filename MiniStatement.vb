Imports Microsoft.Data.SqlClient

Public Class MiniStatement
    Public Property acc As String
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VB.NET\ATM.vb\bin\ATMvbNewDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayTr()
        con.Open()
        Dim cmd As SqlCommand
        Dim query = "select * from TransactionTbl where AccNum=" & acc & ""
        cmd = New SqlCommand(query, con)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet()
        adapter.Fill(ds)
        DgvTransaction.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub MiniStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTr()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MainPage.Close()
        Me.Hide()
    End Sub
End Class