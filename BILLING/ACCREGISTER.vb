Imports System.IO
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ACCREGISTER
    Private Sub ACCREGISTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        AutoNumberID()

    End Sub
    Sub AutoNumberID()
        Dim autoORDERID As Integer
        str = "SELECT COUNT(*) as ID FROM ACCOUNT_TBL"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            autoORDERID = CInt(dr("ID")) + 1
        End While
        dr.Close()


        Dim formattedID As String = autoORDERID

        TextBox8.Text = formattedID
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Sub add()
        Dim cntun, cntflb As String
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        str = "Select COUNT(ID) as cntun from ACCOUNT_TBL where FNAME = '" & TextBox1.Text & "'"
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
        str = "Select COUNT(ID) as cntflb from ACCOUNT_TBL where MNAME = '" & TextBox2.Text & "' and LNAME = '" & TextBox3.Text & "' and CONTACT = '" & TextBox6.Text & "' and ADDRESS = '" & TextBox7.Text & "' and USERNAME = '" & TextBox4.Text & "' and PASSWORD = '" & TextBox5.Text & "' and DATE_STAMP = '" & DateAndTime.Now & "'  and USERLEVEL = '" & Label8.Text & "'"
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
            query = "insert into ACCOUNT_TBL (ID,FNAME,MNAME,LNAME,CONTACT,ADDRESS,USERNAME,PASSWORD,DATE_STAMP,USERLEVEL,IMG) values(@ID,@FNAME,@MNAME,@LNAME,@CONTACT,@ADDRESS,@USERNAME,@PASSWORD,@DATE_STAMP,@USERLEVEL,@IMG)"
            cmd = New SqlClient.SqlCommand(query, sqlconn)

            With cmd


                .Parameters.AddWithValue("@ID", TextBox8.Text)
                .Parameters.AddWithValue("@FNAME", TextBox1.Text)
                .Parameters.AddWithValue("@MNAME", TextBox2.Text)
                .Parameters.AddWithValue("@LNAME", TextBox3.Text)
                .Parameters.AddWithValue("@CONTACT", TextBox6.Text)
                .Parameters.AddWithValue("@ADDRESS", TextBox7.Text)
                .Parameters.AddWithValue("@USERNAME", TextBox4.Text)
                .Parameters.AddWithValue("@PASSWORD", TextBox5.Text)
                .Parameters.AddWithValue("@DATE_STAMP", DateAndTime.Now)
                .Parameters.AddWithValue("@USERLEVEL", Label8.Text)
                .Parameters.AddWithValue("@IMG", ms.ToArray)



            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        add()
        MsgBox("SUCCESFULLY CREATED")
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class