Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class STALLINFO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'STALLS.PictureBox1.BackColor = Color.DodgerBlue

        If Label7.Text = "available" Then

            Register.TextBox10.Text = Label1.Text
            Register.Show()
            Me.Hide()
        Else
            If Label7.Text = "not available" Then
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you really Want to Replace the Tenant's Owner?", "Warning", MessageBoxButtons.YesNo)
                If dialog = DialogResult.No Then
                    Me.Hide()
                    Me.Show()

                Else

                    Register.TextBox10.Text = Label1.Text
                    Register.Show()
                    Me.Hide()


                End If
            End If
        End If

    End Sub

    Private Sub STALLINFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        connect()


        If Label7.Text = "available" Then
            Button2.Enabled = False
        End If

        If Label7.Text = "not available" Then
            Button1.Text = "Replace Tenant owner"
            Label7.ForeColor = Color.Red
        Else
            Button1.Text = "Register tenant owner"
            Label7.ForeColor = Color.LimeGreen
        End If


        If Label9.Text = "UNREGISTERED" Then

            Label9.ForeColor = Color.Red
        End If
    End Sub

    Sub updatestalls()

        query = "Update STALL_TBL set STALL_STATUS = @STALL_STATUS ,PURCHASER = @PURCHASER  where STALL_ID = @STALL_ID "
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@STALL_ID", Label1.Text)
            .Parameters.AddWithValue("@STALL_STATUS", Label11.Text)
            .Parameters.AddWithValue("@PURCHASER", Label12.Text)




        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Sub updatetenant()

        query = "Update TENANT_TBL set USER_STAMP = @USER_STAMP where STALL = @STALL"
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@STALL", Label1.Text)
            .Parameters.AddWithValue("@USER_STAMP", Label13.Text)




        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("are you sure you Want to Remove Tenant's Owner?", "Warning", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then

            updatestalls()
            updatetenant()
            Me.Hide()




            Me.Close()
            STALLS.PictureBox2.BackColor = Color.DodgerBlue
            STALLS.PictureBox1.BackColor = Color.DodgerBlue
            STALLS.PictureBox3.BackColor = Color.DodgerBlue

            STALLS.Show()






        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class