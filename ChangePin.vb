Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Extensions

Public Class ChangePin
    Public Property acc As String
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VB.NET\ATM.vb\bin\ATMvbNewDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim MyAcc As Integer
    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles BtnChange.Click
        If TbxPin1.Text = "" Or TbxPin2.Text = "" Then
            MsgBox("Missing Information")
        ElseIf TbxPin1.Text = TbxPin2.Text Then
            Try
                ' Ensure connection object (Con) is properly initialized
                If Con Is Nothing Then
                    MsgBox("Database connection is not initialized.")
                    Exit Sub
                End If

                ' Corrected SQL UPDATE statement
                Dim query As String = "UPDATE AccountTbl SET PIN = @PIN WHERE AccNum = @AccNum"

                ' Create SQL Command
                Dim cmd As New SqlCommand(query, Con)

                ' Ensure MyAcc (Account Number) is available and correctly parsed
                If String.IsNullOrEmpty(MyAcc) Then
                    MsgBox("Account number is missing!")
                    Exit Sub
                End If

                ' Assign values using parameters
                cmd.Parameters.AddWithValue("@PIN", TbxPin1.Text)
                cmd.Parameters.AddWithValue("@AccNum", Integer.Parse(MyAcc))

                ' Open connection, execute, and close connection
                Con.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                Con.Close()

                ' Check if an update occurred
                If rowsAffected > 0 Then
                    MsgBox("PIN Change Successful!")
                    Dim log = New login()
                    log.Show()
                    Me.Hide()
                Else
                    MsgBox("No account found to update. Check AccNum.")
                End If

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                ' Ensure connection is closed
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                End If
            End Try
        Else
            MsgBox("Pin does not match")
        End If


    End Sub

    Private Sub ChangePin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(acc)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim obj = New MainPage()
        obj.acc = acc
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Application.Exit()
    End Sub
End Class