Public Class splash
    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        MyProgress.Increment(1)
        Dim per As String
        per = Convert.ToString(MyProgress.Value)
        LblSplash.Text = per + "%"
        If MyProgress.Value = 100 Then
            Me.Hide()
            Dim obj = New login
            obj.Show()
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub MyProgress_Click(sender As Object, e As EventArgs) Handles MyProgress.Click

    End Sub
End Class