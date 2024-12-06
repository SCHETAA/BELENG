Imports System.IO
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TENANT
    Private Sub TENANT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        readdataclient()
        rowheight()
    End Sub

    Sub rowheight()
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim r As DataGridViewRow = DataGridView1.Rows(i)
            r.Height = 70
        Next
    End Sub

    Sub readdataclient()
        DataGridView1.Rows.Clear()
        str = "Select * from TENANT_TBL"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr("TENANT_ID"), dr("RFID"), dr("FNAME"), dr("MNAME"), dr("LNAME"), dr("CONTACT"), dr("ADDRESS"), dr("EMAIL"), dr("DATE_STAMP"), dr("USER_STAMP"), dr("STALL"), dr("TENANT_IMG"))


        End While
        dr.Close()
        cmd.Dispose()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer = DataGridView1.CurrentRow.Index
        Label3.Text = DataGridView1.Item(0, i).Value
        MODIFY.TextBox1.Text = DataGridView1.Item(0, i).Value
        MODIFY.TextBox2.Text = DataGridView1.Item(1, i).Value
        MODIFY.TextBox3.Text = DataGridView1.Item(2, i).Value
        MODIFY.TextBox4.Text = DataGridView1.Item(3, i).Value
        MODIFY.TextBox5.Text = DataGridView1.Item(4, i).Value
        MODIFY.TextBox6.Text = DataGridView1.Item(5, i).Value
        MODIFY.TextBox7.Text = DataGridView1.Item(6, i).Value
        MODIFY.TextBox8.Text = DataGridView1.Item(7, i).Value
        MODIFY.ComboBox1.SelectedItem = DataGridView1.Item(9, i).Value
        MODIFY.TextBox9.Text = DataGridView1.Item(10, i).Value
        viewimage()
    End Sub
    Sub viewimage()
        Dim img() As Byte
        str = "Select * from TENANT_TBL where TENANT_ID = '" & Label3.Text & "'"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            img = dr("TENANT_IMG")
            Dim ms As New MemoryStream(img)
            MODIFY.PictureBox1.Image = Image.FromStream(ms)


        End While
        dr.Close()
        cmd.Dispose()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MODIFY.Show()
    End Sub
    Sub Deleteclient(ByVal CID As String)
        query = "Delete from TENANT_TBL where TENANT_ID = @TENANT_ID"
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@TENANT_ID", CID)







        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to delete it?", "Delete", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then

            Dim i As Integer = DataGridView1.CurrentRow.Index
            Deleteclient(DataGridView1.Item(0, i).Value)
            readdataclient()
            rowheight()
            MsgBox("Successfully Deleted", MsgBoxStyle.Information, "Not Safe")

        End If
    End Sub
    Sub searchMENU()
        Dim i As Integer

        DataGridView1.Rows.Clear()
        str = "Select * from TENANT_TBL where FNAME like '%" & TextBox1.Text & "%' or MNAME like '%" & TextBox1.Text & "%' or LNAME like '%" & TextBox1.Text & "%'"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader

        While dr.Read
            DataGridView1.Rows.Add(dr("TENANT_ID"), dr("RFID"), dr("FNAME"), dr("MNAME"), dr("LNAME"), dr("CONTACT"), dr("ADDRESS"), dr("EMAIL"), dr("DATE_STAMP"), dr("USER_STAMP"), dr("STALL"), dr("TENANT_IMG"))

        End While

        If DataGridView1.Rows.Count = 0 Then

        End If


        dr.Close()
        cmd.Dispose()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        searchMENU()
        rowheight()
    End Sub
End Class