Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class STALLS
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.BackColor = Color.PapayaWhip
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label1.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Sub searchMENU()
        Dim i As Integer
        DataGridView1.Rows.Clear()
        str = "Select * from STALL_TBL where STALL_ID like '%" & TextBox1.Text & "%' "
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr("STALL_ID"), dr("STALL_SIZE"), dr("STALL_PRICE"), dr("STALL_STATUS"), dr("PURCHASER"))
        End While
    End Sub


    Sub STALLINFOS()
        Dim i As Integer = DataGridView1.CurrentRow.Index
        STALLINFO.Label1.Text = DataGridView1.Item(0, i).Value
        STALLINFO.Label2.Text = DataGridView1.Item(1, i).Value
        STALLINFO.Label3.Text = DataGridView1.Item(2, i).Value
        STALLINFO.Label7.Text = DataGridView1.Item(3, i).Value
        STALLINFO.Label9.Text = DataGridView1.Item(4, i).Value


    End Sub

    Private Sub STALLS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        connect()

        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.BackColor = Color.PapayaWhip
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label2.Text
        searchMENU()



        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox3.BackColor = Color.PapayaWhip
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label3.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        tap.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.PapayaWhip
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label6.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.PapayaWhip
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label5.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.PapayaWhip
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label4.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.PapayaWhip
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label7.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.PapayaWhip
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label8.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.PapayaWhip
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label9.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.PapayaWhip
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label10.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.PapayaWhip
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label11.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.PapayaWhip
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label12.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.PapayaWhip
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label13.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.PapayaWhip
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label14.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.PapayaWhip
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label15.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.PapayaWhip
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label16.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.PapayaWhip
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label17.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.PapayaWhip
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label18.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.PapayaWhip
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label19.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.PapayaWhip
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label20.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.PapayaWhip
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label31.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.PapayaWhip
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label22.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.PapayaWhip
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label25.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.PapayaWhip
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        TextBox1.Text = Label21.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.PapayaWhip
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label23.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.PapayaWhip
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label26.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.PapayaWhip
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label24.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.PapayaWhip
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label27.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.PapayaWhip
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label28.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.PapayaWhip
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label29.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.PapayaWhip
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label30.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.PapayaWhip
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label32.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.PapayaWhip
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label39.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.PapayaWhip
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label33.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.PapayaWhip
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label40.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.PapayaWhip
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label34.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.PapayaWhip
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label36.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.PapayaWhip
        PictureBox40.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        TextBox1.Text = Label35.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.PapayaWhip
        PictureBox40.BackColor = Color.DodgerBlue
        TextBox1.Text = Label37.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        PictureBox3.BackColor = Color.DodgerBlue
        PictureBox2.BackColor = Color.DodgerBlue
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox4.BackColor = Color.DodgerBlue
        PictureBox5.BackColor = Color.DodgerBlue
        PictureBox6.BackColor = Color.DodgerBlue
        PictureBox7.BackColor = Color.DodgerBlue
        PictureBox8.BackColor = Color.DodgerBlue
        PictureBox9.BackColor = Color.DodgerBlue
        PictureBox10.BackColor = Color.DodgerBlue
        PictureBox11.BackColor = Color.DodgerBlue
        PictureBox12.BackColor = Color.DodgerBlue
        PictureBox13.BackColor = Color.DodgerBlue
        PictureBox14.BackColor = Color.DodgerBlue
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox16.BackColor = Color.DodgerBlue
        PictureBox17.BackColor = Color.DodgerBlue
        PictureBox18.BackColor = Color.DodgerBlue
        PictureBox19.BackColor = Color.DodgerBlue
        PictureBox20.BackColor = Color.DodgerBlue
        PictureBox22.BackColor = Color.DodgerBlue
        PictureBox25.BackColor = Color.DodgerBlue
        PictureBox21.BackColor = Color.DodgerBlue
        PictureBox23.BackColor = Color.DodgerBlue
        PictureBox26.BackColor = Color.DodgerBlue
        PictureBox24.BackColor = Color.DodgerBlue
        PictureBox27.BackColor = Color.DodgerBlue
        PictureBox28.BackColor = Color.DodgerBlue
        PictureBox29.BackColor = Color.DodgerBlue
        PictureBox30.BackColor = Color.DodgerBlue
        PictureBox32.BackColor = Color.DodgerBlue
        PictureBox36.BackColor = Color.DodgerBlue
        PictureBox31.BackColor = Color.DodgerBlue
        PictureBox33.BackColor = Color.DodgerBlue
        PictureBox37.BackColor = Color.DodgerBlue
        PictureBox34.BackColor = Color.DodgerBlue
        PictureBox38.BackColor = Color.DodgerBlue
        PictureBox35.BackColor = Color.DodgerBlue
        PictureBox39.BackColor = Color.DodgerBlue
        PictureBox40.BackColor = Color.PapayaWhip
        TextBox1.Text = Label38.Text
        searchMENU()
        STALLINFOS()
        STALLINFO.Show()
    End Sub
End Class