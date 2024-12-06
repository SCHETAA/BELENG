Imports System.Data.SqlClient

Public Class REPORT
    Private Sub REPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As New SqlConnection("Data Source=DESKTOP-35EDI7C\SCHETA;Initial Catalog=billing;Integrated Security=True;Encrypt=False")
            Dim dt As New DataTable

            con.Open()
            Using cmd As New SqlCommand("Select * from TRANSACTION_TBL", con)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd

                da.Fill(dt)
            End Using
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "C:\Users\SCHETA\Desktop\FINAL-BILLING-main\BILLING\BILLREPORT.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
            End With

        End Using
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub


End Class