Imports System.Data.OleDb
Imports System.IO

Public Class formRegister
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ECOEXPLORER.accdb")
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim response As DialogResult

        response = MessageBox.Show("Are you sure you want to close me T_T", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

    Private Sub btnPfp_Click(sender As Object, e As EventArgs) Handles btnPfp.Click

        Dim pop As OpenFileDialog = New OpenFileDialog

        If pop.ShowDialog Then

            btnPfp.Image = Image.FromFile(pop.FileName)

        End If

    End Sub

    Sub save()

        Try

            If btnPfp.Image Is Nothing Then
                MessageBox.Show("Please select a Profile Picture!", "Missing Profile Picture", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Exit the method if no profile picture is selected
            End If

            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("INSERT INTO Login([Email], [Username], [Password], [pic]) VALUES (?, ?, ?, ?)", conn)
            Dim i As Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Username", txtName.Text)
            cmd.Parameters.AddWithValue("@Password", txtConPass.Text)

            'image convert to binary format

            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            btnPfp.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()

            cmd.Parameters.AddWithValue("@pic", picture)


            i = cmd.ExecuteNonQuery
            If i > 0 Then

                MsgBox("New User Register Successfully!", MsgBoxStyle.Information)

            Else
                MsgBox("New User Register Failed!", MsgBoxStyle.Information)

            End If

            txtEmail.Clear()
            txtName.Clear()
            txtPass.Clear()
            txtConPass.Clear()
            btnPfp.Image = Nothing

            Me.Hide()
            formMAIN.Show()


        Catch ex As Exception

            MsgBox(ex.Message)

        Finally
            ' Close the connection in the finally block
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try

    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

        Dim security As String = txtPass.Text
        Dim security2 As String = txtConPass.Text

        If security = security2 Then

            save()

        Else

            MessageBox.Show("'Confirm Password' is not as 'Password'", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub
End Class