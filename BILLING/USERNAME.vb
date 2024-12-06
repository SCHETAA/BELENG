Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class USERNAMEEE
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub USERNAME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = tap.Label32.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Retrieve the entered passwords
        Dim NEWPassword As String = TextBox1.Text
        Dim conPassword As String = Label3.Text

        ' Check if the passwords match
        If NEWPassword = conPassword Then

            MsgBox("PLEASE ENTER YOUR NEW USERNAME!")

            Label1.Text = "INPUT NEW USERNAME"
            Button2.Visible = True
            Button1.Visible = False
            TextBox1.Clear()



        Else
            ' Display error message
            MsgBox("WRONG PASSWORD PLEASE TRY AGAIN", vbCritical, "CREDENTIALS FAILED")
        End If
    End Sub
    Sub updateclient()
        query = "Update ACCOUNT_TBL set USERNAME = @USERNAME where ID = @ID "
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@ID", Label2.Text)
            .Parameters.AddWithValue("@USERNAME", TextBox1.Text)

        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then


            MsgBox("PLEASE INPUT USERNAME! TRY AGAIN", vbCritical, "CREDENTIALS FAILED")

        Else
            ' Display error message

            MsgBox("USERNAME SUCCESFULLY CHANGED!")
            updateclient()
            Application.Restart()

        End If
    End Sub
End Class