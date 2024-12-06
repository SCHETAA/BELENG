Imports System.IO
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class tap
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 9 Then

            searchMENU()







            If DataGridView1.Rows.Count = 0 Then

                Panel2.Show()

                Panel1.Hide()
                '  Timer2.Enabled = True
                TextBox1.Clear()



            Else
                MsgBox("TENANT RFID ACCESS", MsgBoxStyle.Exclamation, "FUNCTION")
                TextBox1.Clear()
                Panel2.Hide()
                Panel1.Show()
                Dim i As Integer = DataGridView1.CurrentRow.Index
                Label11.Text = DataGridView1.Item(0, i).Value
                Label12.Text = DataGridView1.Item(1, i).Value
                Label21.Text = DataGridView1.Item(2, i).Value
                Label18.Text = DataGridView1.Item(3, i).Value
                Label19.Text = DataGridView1.Item(4, i).Value
                Label13.Text = DataGridView1.Item(5, i).Value
                Label14.Text = DataGridView1.Item(6, i).Value
                Label15.Text = DataGridView1.Item(7, i).Value

                ' Label16.Text = DataGridView1.Item(8, i).Value
                Label23.Text = DataGridView1.Item(9, i).Value
                Label25.Text = DataGridView1.Item(10, i).Value
                Label26.Text = DataGridView1.Item(11, i).Value
                viewimage()
            End If
        End If
    End Sub
    Sub viewimage()
        Dim img() As Byte
        str = "Select * from TENANT_TBL where TENANT_ID = '" & Label11.Text & "'"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            img = dr("TENANT_IMG")
            Dim ms As New MemoryStream(img)
            PictureBox2.Image = Image.FromStream(ms)


        End While
        dr.Close()
        cmd.Dispose()
    End Sub
    Sub searchMENU()
        Dim i As Integer
        DataGridView1.Rows.Clear()
        str = "Select * from TENANT_TBL where RFID like '%" & TextBox1.Text & "%' "
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr("TENANT_ID"), dr("RFID"), dr("FNAME"), dr("MNAME"), dr("LNAME"), dr("CONTACT"), dr("ADDRESS"), dr("EMAIL"), dr("TENANT_IMG"), dr("DATE_STAMP"), dr("USER_STAMP"), dr("STALL"))
        End While
    End Sub
    Private Sub tap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        Dim img() As Byte
        str = "Select * from ACCOUNT_TBL where ID = '" & Label32.Text & "'"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            img = dr("IMG")
            Dim ms As New MemoryStream(img)
            PictureBox3.Image = Image.FromStream(ms)
            SETTINGS.PictureBox1.Image = Image.FromStream(ms)


        End While
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label19.Click, Label18.Click, Label21.Click, Label23.Click, Label25.Click, Label26.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Hide()
        TextBox1.Clear()
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label25.Text = "remove" Then
            Panel4.Show()
        Else
            PAYMENT.Label19.Text = Label11.Text
            PAYMENT.Label20.Text = Label26.Text
            PAYMENT.Show()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really Want to Log out?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            Me.Hide()
            Me.Show()
        Else

            Application.Restart()


        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Label33.Text = "OWNER" Then
            Usermanagement.Show()
            Me.Hide()

        Else
            MsgBox("ONLY OWNER CAN ACCESS TO THIS FORM", MsgBoxStyle.Critical)
        End If



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label33.Text = "ADMINISTRATOR" Or Label33.Text = "OWNER" Then
            STALLS.Show()
            Me.Hide()
        Else

            MsgBox("ONLY OWNER AND ADMIN CAN ACCESS TO THIS FORM", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TENANT.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TRANSAC.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SETTINGS.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        REPORT.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel4.Hide()
    End Sub
End Class