Public Class TRANSAC
    Private Sub TRANSAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        readdataclient()
    End Sub

    Sub readdataclient()
        DataGridView1.Rows.Clear()
        str = "Select * from TRANSACTION_TBL"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr("TENANT_ID"), dr("RFID"), dr("STALL_ID"), dr("PURCHASER"), dr("AMOUNTDUE"), dr("PAYMENT"), dr("CHANGE"), dr("STATUS"), dr("DATE"))


        End While
        dr.Close()
        cmd.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Sub searchMENU()
        Dim i As Integer

        DataGridView1.Rows.Clear()
        str = "Select * from TRANSACTION_TBL where PURCHASER like '%" & TextBox1.Text & "%'"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader

        While dr.Read
            DataGridView1.Rows.Add(dr("TENANT_ID"), dr("RFID"), dr("STALL_ID"), dr("PURCHASER"), dr("AMOUNTDUE"), dr("PAYMENT"), dr("CHANGE"), dr("STATUS"), dr("DATE"))

        End While

        If DataGridView1.Rows.Count = 0 Then

        End If


        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        searchMENU()
    End Sub
    Sub Deleteclient(ByVal CID As String)
        query = "Delete from TRANSACTION_TBL where TENANT_ID = @TENANT_ID"
        cmd = New SqlClient.SqlCommand(query, sqlconn)
        With cmd
            .Parameters.AddWithValue("@TENANT_ID", CID)







        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to delete it?", "Delete", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then

            Dim i As Integer = DataGridView1.CurrentRow.Index
            Deleteclient(DataGridView1.Item(0, i).Value)
            readdataclient()
            MsgBox("Successfully Deleted", MsgBoxStyle.Information, "Not Safe")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        REPORT.Show()
    End Sub
End Class