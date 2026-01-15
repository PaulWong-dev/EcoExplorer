Imports System.Data.OleDb
Imports System.IO

Public Class formLogin
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ECOEXPLORER.accdb")
    Dim dr As OleDbDataReader

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim response As DialogResult

        response = MessageBox.Show("Are you sure you want to close me T_T", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then

            Application.Exit()

        End If


    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try

            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from login where username=@username AND password=@password", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", txtUser.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            Dim username As String = ""
            Dim password As String = ""
            dr = cmd.ExecuteReader
            If (dr.Read() = True) Then

                username = dr("username")
                password = dr("password")
                MessageBox.Show("LOGIN SUCCESSFULLY", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                formMenu.Show()

            Else
                MsgBox("WRONG PASSWORD", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "PASSWORD")

            End If

        Catch ex As Exception

        End Try

    End Sub

End Class