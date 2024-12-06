Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Drawing.Printing

Public Class PAYMENT
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As Integer
        Dim sum As Integer
        If AMOUNTTB.Text = "" Then
            MsgBox("PLEASE INPUT AMOUNT!!", vbCritical, "PAYMENT FAILED")
        Else
            p = Val(AMOUNTTB.Text)

            If (p < Label5.Text) Then
                MsgBox("PAYMENT UNABLE TO PROCESS", vbCritical, "PAYMENT FAILED")

            Else

                sum = AMOUNTTB.Text - Label5.Text
                Label7.Text = sum
                MsgBox("PAYMENT RECEIVED!")
                TextBox1.Text = "COMPLETE"

                addTRansac()





            End If
        End If
    End Sub




    Sub addTRansac()
        Dim cntun, cntflb As String


        str = "Select COUNT(TENANT_ID) as cntun from TRANSACTION_TBL where RFID = '" & tap.Label12.Text & "'" 'RFID txtbox label 12
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            cntun = dr.GetValue(0)
        End While
        dr.Close()
        cmd.Dispose()



        str = "Select COUNT(TENANT_ID) as cntflb from TRANSACTION_TBL where STALL_ID = '" & tap.Label26.Text & "' and PURCHASER = '" & TextBox2.Text & "' and AMOUNTDUE = '" & Label5.Text & "' and PAYMENT = '" & AMOUNTTB.Text & "' and CHANGE = '" & Label7.Text & "' and STATUS = '" & TextBox1.Text & "' and DATE = '" & Label18.Text & "'"
        cmd = New SqlClient.SqlCommand(str, sqlconn)
        dr = cmd.ExecuteReader
        While dr.Read
            cntflb = dr.GetValue(0)
        End While
        dr.Close()
        cmd.Dispose()




        query = "insert into TRANSACTION_TBL (TENANT_ID,RFID,STALL_ID,PURCHASER,AMOUNTDUE,PAYMENT,CHANGE,STATUS,DATE) values (@TENANT_ID,@RFID,@STALL_ID,@PURCHASER,@AMOUNTDUE,@PAYMENT,@CHANGE,@STATUS,@DATE)"
        cmd = New SqlClient.SqlCommand(query, sqlconn)

        With cmd


            .Parameters.AddWithValue("@TENANT_ID", tap.Label11.Text)
            .Parameters.AddWithValue("@RFID", tap.Label12.Text)
            .Parameters.AddWithValue("@PURCHASER", TextBox2.Text)
            .Parameters.AddWithValue("@STALL_ID", tap.Label26.Text)
            .Parameters.AddWithValue("@AMOUNTDUE", Label5.Text)
            .Parameters.AddWithValue("@PAYMENT", AMOUNTTB.Text)
            .Parameters.AddWithValue("@CHANGE", Label7.Text)
            .Parameters.AddWithValue("@STATUS", TextBox1.Text)
            .Parameters.AddWithValue("@DATE", Label18.Text)






        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        dr.Close()
        cmd.Dispose()

    End Sub

    Private Sub PAYMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Specify the length of the random number
        Dim length As Integer = 5 ' Change this to your desired length

        ' Generate a random number with the specified length
        Dim randomNumber As String = GenerateRandomNumber(length)

        ' Display the random number in the TextBox
        TextBox3.Text = randomNumber
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click, Label12.Click, Label13.Click, Label17.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label18.Text = Date.Now.ToString("dddd, MMMM d, yyyy")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CHANGELONG()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub
    Sub CHANGELONG()
        longpaper = 0
        longpaper = 1 & 15
        longpaper = longpaper + 500
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "---------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("New Parang Daily Billing System", f10b, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Payment Receipt", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString(TextBox3.Text, f10b, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Invoice #", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 60)
        e.Graphics.DrawString("Assisted by Staff", f8, Brushes.Black, 70, 60)

        e.Graphics.DrawString("Incharge", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString(tap.Label31.Text, f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Date  :  " & Date.Now(), f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 107)

        Dim height As Integer

        height = +15

        e.Graphics.DrawString("PURCHASER   : " + TextBox2.Text, f8, Brushes.Black, 20, 125)
        e.Graphics.DrawString("PAYMENT       : ₱" + AMOUNTTB.Text, f8, Brushes.Black, 20, 140)
        e.Graphics.DrawString("CHANGE         : ₱" + Label7.Text, f8, Brushes.Black, 20, 155)
        e.Graphics.DrawString("TOTAL             : ₱" + Label5.Text, f8, Brushes.Black, 20, 170)
        e.Graphics.DrawString("STALL ID         : " + Label20.Text, f8, Brushes.Black, 20, 185)
        e.Graphics.DrawString("TENANT ID     : " + Label19.Text, f8, Brushes.Black, 20, 200)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 215)
        e.Graphics.DrawString(" Thank you for your service", f10b, Brushes.Black, centermargin, 230, center)
        e.Graphics.DrawString(" Please Come Again!", f10b, Brushes.Black, centermargin, 245, center)
        e.Graphics.DrawString("0935-675-8953", f10, Brushes.Black, centermargin, 260, center)
        e.Graphics.DrawString("www.Parangdailybilling.com", f10, Brushes.Black, centermargin, 275, center)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function GenerateRandomNumber(length As Integer) As String
        ' Create a new instance of the Random class
        Dim rnd As New Random()
        Dim result As String = ""

        ' Generate the random number digit by digit
        For i As Integer = 1 To length
            Dim digit As Integer = rnd.Next(0, 10) ' Generate a random digit (0-9)
            result &= digit.ToString()
        Next

        Return result
    End Function

End Class