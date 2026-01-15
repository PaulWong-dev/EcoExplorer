Public Class formLoading

    Dim countdownvalue As Integer

    Private Sub ecoLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        countdownvalue = 25

        Label1.Text = countdownvalue.ToString()

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        countdownvalue -= 1

        Label1.Text = countdownvalue.ToString()

        If countdownvalue <= 0 Then

            Timer1.Stop()

            Me.Hide()
            formMAIN.Show()

        End If

    End Sub

End Class
