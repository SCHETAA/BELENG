Imports System.IO
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Usermanagement
    Private Sub Usermanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        readdataclient()
        rowheight()
    End Sub

    Sub readdataclient()
        DataGridView1.Rows.Clear()
        str = "Select * from ACCOUNT_TBL"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr("ID"), dr("FNAME"), dr("MNAME"), dr("LNAME"), dr("CONTACT"), dr("ADDRESS"), dr("USERNAME"), dr("PASSWORD"), dr("DATE_STAMP"), dr("USERLEVEL"), dr("IMG"))


        End While
        dr.Close()
        cmd.Dispose()

    End Sub

    Sub rowheight()
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim r As DataGridViewRow = DataGridView1.Rows(i)
            r.Height = 100
        Next
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        tap.Show()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer = DataGridView1.CurrentRow.Index

        TextBox2.Text = DataGridView1.Item(0, i).Value
        TextBox3.Text = DataGridView1.Item(1, i).Value
        TextBox4.Text = DataGridView1.Item(2, i).Value
        TextBox5.Text = DataGridView1.Item(3, i).Value
        TextBox6.Text = DataGridView1.Item(4, i).Value
        TextBox7.Text = DataGridView1.Item(5, i).Value
        TextBox8.Text = DataGridView1.Item(6, i).Value
        TextBox9.Text = DataGridView1.Item(7, i).Value
        Label10.Text = DataGridView1.Item(8, i).Value
        ComboBox1.SelectedItem = DataGridView1.Item(9, i).Value
        viewimage()
    End Sub

    Sub add()
        Dim cntun, cntflb As String
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        str = "Select COUNT(ID) as cntun from ACCOUNT_TBL where FNAME = '" & TextBox3.Text & "'"
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

        str = "Select COUNT(ID) as cntflb from ACCOUNT_TBL where MNAME = '" & TextBox4.Text & "' and LNAME = '" & TextBox5.Text & "' and CONTACT = '" & TextBox6.Text & "' and ADDRESS = '" & TextBox7.Text & "' and USERNAME = '" & TextBox8.Text & "' and PASSWORD = '" & TextBox9.Text & "' and DATE_STAMP = '" & Label13.Text & "'  and USERLEVEL = '" & ComboBox1.SelectedItem & "'"
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


                .Parameters.AddWithValue("@ID", TextBox2.Text)
                .Parameters.AddWithValue("@FNAME", TextBox3.Text)
                .Parameters.AddWithValue("@MNAME", TextBox4.Text)
                .Parameters.AddWithValue("@LNAME", TextBox5.Text)
                .Parameters.AddWithValue("@CONTACT", TextBox6.Text)
                .Parameters.AddWithValue("@ADDRESS", TextBox7.Text)
                .Parameters.AddWithValue("@USERNAME", TextBox8.Text)
                .Parameters.AddWithValue("@PASSWORD", TextBox9.Text)
                .Parameters.AddWithValue("@DATE_STAMP", Label13.Text)
                .Parameters.AddWithValue("@USERLEVEL", ComboBox1.SelectedItem)
                .Parameters.AddWithValue("@IMG", ms.ToArray)



            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        dr.Close()
        cmd.Dispose()

    End Sub

    Sub CLEAR()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        PictureBox1.Image = My.Resources.NOIMAGE
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        add()
        readdataclient()
        rowheight()
        CLEAR()
        MsgBox(" Succesfuly Created")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label13.Text = Date.Now.ToString("dddd, MMMM d, yyyy")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CLEAR()
        MsgBox("CLEARED")
    End Sub


    Sub updateclient()
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        query = "Update ACCOUNT_TBL set FNAME = @FNAME ,MNAME = @MNAME ,LNAME = @LNAME,CONTACT = @CONTACT,ADDRESS = @ADDRESS, USERNAME = @USERNAME, PASSWORD = @PASSWORD, IMG = @IMG, DATE_STAMP = @DATE_STAMP, USERLEVEL = @USERLEVEL  where ID = @ID "
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@ID", TextBox2.Text)
            .Parameters.AddWithValue("@FNAME", TextBox3.Text)
            .Parameters.AddWithValue("@MNAME", TextBox4.Text)
            .Parameters.AddWithValue("@LNAME", TextBox5.Text)
            .Parameters.AddWithValue("@CONTACT", TextBox6.Text)
            .Parameters.AddWithValue("@ADDRESS", TextBox7.Text)
            .Parameters.AddWithValue("@USERNAME", TextBox8.Text)
            .Parameters.AddWithValue("@PASSWORD", TextBox9.Text)
            .Parameters.AddWithValue("@IMG", ms.ToArray)
            .Parameters.AddWithValue("@DATE_STAMP", Label13.Text)
            .Parameters.AddWithValue("@USERLEVEL", ComboBox1.SelectedItem)


        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub


    Sub Deleteclient(ByVal CID As String)
        query = "Delete from ACCOUNT_TBL where ID = @ID"
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@ID", CID)







        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Sub viewimage()
        Dim img() As Byte
        str = "Select * from ACCOUNT_TBL where ID = '" & TextBox2.Text & "'"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            img = dr("IMG")
            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)


        End While
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        updateclient()
        CLEAR()
        MsgBox(" Succesfuly UPDATE")
        readdataclient()
        rowheight()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Deleteclient(DataGridView1.Item(0, i).Value)
        readdataclient()
        rowheight()
        MsgBox("Successfully Deleted", MsgBoxStyle.Information, "Not Safe")
    End Sub
End Class