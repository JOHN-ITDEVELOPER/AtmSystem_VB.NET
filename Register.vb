Imports Microsoft.Data.SqlClient
Public Class Register
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VB.NET\ATM.vb\bin\ATMvbNewDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Reset()
        TbxAccNum.Text = ""
        TbxName.Text = ""
        TbxFname.Text = ""
        TbxPhone.Text = ""
        RtbxAddress.Text = ""
        ComboBox1.SelectedIndex = 0
        TbxOccupation.Text = ""
        TbxPin.Text = ""
    End Sub
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If TbxAccNum.Text = "" Or TbxName.Text = "" Or TbxFname.Text = "" Or TbxPhone.Text = "" Or RtbxAddress.Text = "" Or ComboBox1.SelectedIndex = -1 Or TbxOccupation.Text = "" Or TbxPin.Text = "" Then
            MsgBox("Missing Information")
        Else

            Try
                Dim bal As Integer = 0
                Dim query As String = "INSERT INTO AccountTbl (AccNum, Name, FaName, Dob, Phone, Address, Education, Occupation, Pin, Balance) VALUES (@AccNum, @Name, @Fname, @Dob, @Phone, @Address, @Education, @Occupation, @Pin, @Balance)"

                Dim cmd As New SqlCommand(query, Con)

                ' Assign values using parameters
                cmd.Parameters.AddWithValue("@AccNum", Integer.Parse(TbxAccNum.Text))
                cmd.Parameters.AddWithValue("@Name", TbxName.Text)
                cmd.Parameters.AddWithValue("@Fname", TbxName.Text) ' Should be another field, or fix it
                cmd.Parameters.AddWithValue("@Dob", DateTimePicker1.Value.Date)
                cmd.Parameters.AddWithValue("@Phone", TbxPhone.Text)
                cmd.Parameters.AddWithValue("@Address", RtbxAddress.Text)
                cmd.Parameters.AddWithValue("@Education", ComboBox1.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Occupation", TbxOccupation.Text)
                cmd.Parameters.AddWithValue("@Pin", TbxPin.Text)
                cmd.Parameters.AddWithValue("@Balance", bal)

                ' Open connection and execute command
                Con.Open()
                cmd.ExecuteNonQuery()
                Con.Close()
                Reset()
                MsgBox("Account Added Successfully!")

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub LbLogout_Click(sender As Object, e As EventArgs) Handles LbLogout.Click
        Dim obj = New login()
        Me.Hide()
        obj.Show()
    End Sub
End Class
