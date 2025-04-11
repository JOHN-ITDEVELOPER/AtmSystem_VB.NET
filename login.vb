Imports System.Security.Cryptography
Imports Microsoft.Data.SqlClient
Public Class login
    Public Property AccNum As String
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VB.NET\ATM.vb\bin\ATMvbNewDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click

        Application.Exit()

    End Sub

    Private Sub LblSignup_Click(sender As Object, e As EventArgs) Handles LblSignup.Click
        Dim obj = New Register()
        Me.Hide()
        obj.Show()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TbxAccNum.Text = "" Or TbxPin.Text = "" Then
            MsgBox("Enter Account Number and PIN number")
        Else
            'Con.Open()
            Dim query = "select * from AccountTbl where AccNum ='" & TbxAccNum.Text & "' and PIN ='" & TbxPin.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong AccNUM or PIN")
            Else
                Dim obj As New MainPage(TbxAccNum.Text)
                obj.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub
End Class