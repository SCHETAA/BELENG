Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Dim trynumber As Integer
    Private Sub LOGINBTN_Click(sender As Object, e As EventArgs)

    End Sub

    Sub LOGGED()
        If sqlconn.State <> ConnectionState.Open Then
            sqlconn.Open()
        End If
        Dim da As New SqlDataAdapter("select * from ACCOUNT_TBL ", sqlconn)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        Dim resultat As Integer
        For i = 0 To dt.Rows.Count - 1
            If USERNAME.Text = Convert.ToString(dt.Rows(i)("USERNAME")) And
                PASSWORD.Text = Convert.ToString(dt.Rows(i)("PASSWORD")) Then

                fname = Convert.ToString(dt.Rows(i)("FNAME"))
                lname = Convert.ToString(dt.Rows(i)("LNAME"))
                mname = Convert.ToString(dt.Rows(i)("MNAME"))
                userlevel = Convert.ToString(dt.Rows(i)("USERLEVEL"))
                '   uid = Convert.ToString(dt.Rows(i)("uid"))
                globalization.passwords = Convert.ToString(dt.Rows(i)("Password"))
                usernamee = Convert.ToString(dt.Rows(i)("Username"))
                uid = Convert.ToString(dt.Rows(i)("ID"))
                imageE = Convert.ToString(dt.Rows(i)("IMG"))

                ' tap.PictureBox3.Image = imageE

                Me.Hide()
                MsgBox(" You are now logged", MsgBoxStyle.Information)

                USERNAMEEE.Label3.Text = globalization.passwords
                PASSWORDS.Label2.Text = globalization.passwords
                tap.Label32.Text = uid
                tap.Label32.Text = uid
                tap.Label33.Text = userlevel


                PASSWORDS.Label4.Text = uid
                tap.Show()


                'Dashboard.Label4.Text = fname + " " + mname + " " + lname


                tap.Label31.Text = (fname + " " + mname + " " + lname)
                SETTINGS.TextBox1.Text = (fname + " " + mname + " " + lname)
                SETTINGS.TextBox2.Text = usernamee
                SETTINGS.TextBox3.Text = globalization.passwords
                '' Form2.Show()
                'Dashboard.Show()
                'Dashboard.Label5.Text = fname + " " + lname
                '  USERMANAGEMENT.Label13.Text = uid
                '/  USERMANAGEMENT.Label14.Text = userlevel
                '  Dashboard.Label3.Text = uid
                ' Dashboard.Label8.Text = userlevel



                resultat = 1

                Try
                    str = "Select * from ACCOUNT_TBL where PASSWORD = @PASSWORD"
                    cmd = New SqlClient.SqlCommand(str, sqlconn)
                    With cmd
                        .Parameters.AddWithValue("@USERNAME", USERNAME.Text)
                        .Parameters.AddWithValue("@PASSWORD", PASSWORD.Text)
                    End With

                    dr = cmd.ExecuteReader
                    If (dr.Read()) Then

                    End If
                    cmd.Dispose()
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        Next
        If resultat <> 1 Then

            MsgBox("Invalid Credentials", MsgBoxStyle.Critical)
            trynumber += 1


            If trynumber >= 3 Then
                MsgBox(" You are now Locked! Please Try again", MsgBoxStyle.Critical)
                '
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub PASSWORD_TextChanged(sender As Object, e As EventArgs) Handles PASSWORD.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PASSWORD.PasswordChar = ""
        Else
            PASSWORD.PasswordChar = "*"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LOGGED()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ACCREGISTER.Show()
    End Sub
End Class
