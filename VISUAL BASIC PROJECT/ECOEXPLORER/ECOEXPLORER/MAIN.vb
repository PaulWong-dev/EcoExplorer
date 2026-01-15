Public Class formMAIN
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim response As DialogResult

        response = MessageBox.Show("Are you sure you want to close me T_T", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then

            Application.Exit()

        End If


    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Me.Hide()
        formLogin.Show()

    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

        Me.Hide()
        formRegister.Show()

    End Sub
End Class