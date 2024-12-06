Imports System.IO
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PASSWORDS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Retrieve the entered passwords
        Dim NEWPassword As String = TextBox1.Text
        Dim conPassword As String = Label2.Text

        ' Check if the passwords match
        If NEWPassword = conPassword Then

            MsgBox("PLEASE ENTER YOUR NEW PASSWORD!")
            TextBox2.Visible = True
            Label3.Visible = True
            Button2.Visible = True
            Button1.Visible = False
            TextBox1.Clear()
            Label1.Text = "ENTER YOUR NEW PASSWORD"


        Else
            ' Display error message
            MsgBox("WRONG PASSWORD PLEASE TRY AGAIN", vbCritical, "CREDENTIALS FAILED")
        End If
    End Sub

    Private Sub PASSWORDS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = tap.Label32.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
    Sub updateclient()
        query = "Update ACCOUNT_TBL set PASSWORD = @PASSWORD where ID = @ID "
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@ID", Label4.Text)
            .Parameters.AddWithValue("@PASSWORD", TextBox2.Text)

        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Retrieve the entered passwords
        Dim NEWPassword As String = TextBox2.Text
        Dim conPassword As String = TextBox1.Text

        ' Check if the passwords match
        If NEWPassword = conPassword Then

            MsgBox("PASSWORD SUCCESFULLY CHANGED!")
            updateclient()
            Application.Restart()



        Else
            ' Display error message
            MsgBox("WRONG PASSWORD PLEASE TRY AGAIN", vbCritical, "CREDENTIALS FAILED")
        End If
    End Sub
End Class