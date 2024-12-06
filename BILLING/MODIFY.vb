Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MODIFY
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.LimeGreen
        TextBox2.Enabled = True
        Button1.Enabled = False
        TextBox2.Clear()
        TextBox2.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Length > 9 Then

            TextBox2.Enabled = False
            Button1.Enabled = True
            Button1.BackColor = Color.Aqua



        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Sub updateclient()
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        query = "Update TENANT_TBL set RFID = @RFID ,FNAME = @FNAME ,MNAME = @MNAME,LNAME = @LNAME,CONTACT = @CONTACT, ADDRESS = @ADDRESS, EMAIL = @EMAIL, TENANT_IMG = @TENANT_IMG, USER_STAMP = @USER_STAMP, STALL = @STALL where TENANT_ID = @TENANT_ID "
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@TENANT_ID", TextBox1.Text)
            .Parameters.AddWithValue("@RFID", TextBox2.Text)
            .Parameters.AddWithValue("@FNAME", TextBox3.Text)
            .Parameters.AddWithValue("@MNAME", TextBox4.Text)
            .Parameters.AddWithValue("@LNAME", TextBox5.Text)
            .Parameters.AddWithValue("@CONTACT", TextBox6.Text)
            .Parameters.AddWithValue("@ADDRESS", TextBox7.Text)
            .Parameters.AddWithValue("@EMAIL", TextBox8.Text)
            .Parameters.AddWithValue("@TENANT_IMG", ms.ToArray)
            .Parameters.AddWithValue("@USER_STAMP", ComboBox1.SelectedItem)
            .Parameters.AddWithValue("@STALL", TextBox9.Text)


        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updateclient()
        TENANT.Close()
        Me.Hide()
        tap.Show()
        MsgBox(" Succesfuly UPDATE")

    End Sub

    Private Sub MODIFY_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class