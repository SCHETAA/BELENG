Imports System.IO
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Register
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label12.Click, Label11.Click, Label10.Click

    End Sub
    Sub add()
        Dim cntun, cntflb As String
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)


        str = "Select COUNT(TENANT_ID) as cntun from TENANT_TBL where RFID = '" & TextBox5.Text & "'"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            cntun = dr.GetValue(0)
        End While
        dr.Close()
        cmd.Dispose()

        If cntun = "1" Then
            MsgBox("Username Already Exist")
        End If

        str = "Select COUNT(TENANT_ID) as cntflb from TENANT_TBL where FNAME = '" & TextBox2.Text & "' and MNAME = '" & TextBox3.Text & "' and LNAME = '" & TextBox4.Text & "' and CONTACT = '" & TextBox6.Text & "' and ADDRESS = '" & TextBox7.Text & "' and EMAIL = '" & TextBox8.Text & "' and DATE_STAMP = '" & Label10.Text & "' and USER_STAMP = '" & ComboBox1.SelectedItem & "' and STALL = '" & TextBox10.Text & "'"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            cntflb = dr.GetValue(0)
        End While
        dr.Close()
        cmd.Dispose()

        If cntflb = "1" Then
            MsgBox("User Already Exist")
        End If

        If cntun = "0" And cntflb = "0" Then


            query = "insert into TENANT_TBL (TENANT_ID,RFID,FNAME,MNAME,LNAME,CONTACT,ADDRESS,EMAIL,TENANT_IMG,DATE_STAMP,USER_STAMP,STALL) values (@TENANT_ID,@RFID,@FNAME,@MNAME,@LNAME,@CONTACT,@ADDRESS,@EMAIL,@TENANT_IMG,@DATE_STAMP,@USER_STAMP,@STALL)"
            cmd = New SqlClient.SqlCommand(query, sqlconn)

            With cmd


                .Parameters.AddWithValue("@TENANT_ID", TextBox1.Text)
                .Parameters.AddWithValue("@RFID", TextBox5.Text)
                .Parameters.AddWithValue("@FNAME", TextBox2.Text)
                .Parameters.AddWithValue("@MNAME", TextBox3.Text)
                .Parameters.AddWithValue("@LNAME", TextBox4.Text)
                .Parameters.AddWithValue("@CONTACT", TextBox6.Text)
                .Parameters.AddWithValue("@ADDRESS", TextBox7.Text)
                .Parameters.AddWithValue("@EMAIL", TextBox8.Text)
                .Parameters.AddWithValue("@TENANT_IMG", ms.ToArray)
                .Parameters.AddWithValue("@DATE_STAMP", Label10.Text)
                .Parameters.AddWithValue("@USER_STAMP", ComboBox1.SelectedItem)
                .Parameters.AddWithValue("@STALL", TextBox10.Text)



            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        dr.Close()
        cmd.Dispose()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.LimeGreen
        TextBox5.Enabled = True
        Button1.Enabled = False
        TextBox5.Clear()
        TextBox5.Focus()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        AutoNumberID()
    End Sub
    Sub AutoNumberID()
        Dim autoORDERID As Integer
        str = "SELECT COUNT(*) as TENANT_ID FROM TENANT_TBL"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            autoORDERID = CInt(dr("TENANT_ID")) + 1
        End While
        dr.Close()


        Dim formattedID As String = autoORDERID

        TextBox1.Text = formattedID
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text.Length > 9 Then
            MsgBox("d")
            MessageBox.Show("SUCCESFULLY SCANNED", "RFID")
            TextBox5.Enabled = False
            Button1.Enabled = True
            Button1.BackColor = Color.Aqua



        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dddd, MMMM d, yyyy")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        STALLS.Show()
    End Sub

    Sub CLEAR()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        PictureBox1.Image = My.Resources.NOIMAGE
    End Sub



    Sub update()

        query = "Update STALL_TBL set STALL_STATUS = @STALL_STATUS ,PURCHASER = @PURCHASER  where STALL_ID = @STALL_ID "
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@STALL_ID", TextBox10.Text)
            .Parameters.AddWithValue("@STALL_STATUS", Label14.Text)
            .Parameters.AddWithValue("@PURCHASER", TextBox2.Text)




        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dialog As DialogResult

        If TextBox5.Text = "" Then


            MsgBox("You need to assign RFID first!")


        Else
            If PictureBox1.Image Is Nothing Then

                MsgBox("You need to add image first!")

            Else

                dialog = MessageBox.Show("Anything else you want to change?", "Hello world", MessageBoxButtons.YesNo)
                If dialog = DialogResult.No Then


                    add()
                    update()
                    CLEAR()


                    STALLINFO.Close()
                    STALLS.Show()
                    Me.Hide()

                    STALLS.PictureBox2.BackColor = Color.DodgerBlue
                    STALLS.PictureBox1.BackColor = Color.DodgerBlue
                    STALLS.PictureBox3.BackColor = Color.DodgerBlue



                    MessageBox.Show("SUCCESFULLY REGISTERED", "TENANTS")


                End If
            End If


        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class