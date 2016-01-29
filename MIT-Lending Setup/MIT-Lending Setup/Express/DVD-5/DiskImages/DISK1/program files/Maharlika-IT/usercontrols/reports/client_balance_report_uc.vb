Imports Microsoft.Reporting.WinForms
Public Class client_balance_report_uc


    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim dt As New DataTable
        Dim loan As New loan

        dt = loan.SELECT_ACTIVE

        '=============================================================
        'IF THE CLIENT HAS AN ACTIVE LOAN, TRY RETRIEVING ITS PAYMENTS

        Try
            If dt IsNot Nothing Then
                Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\reports\Report4.rdlc"
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Dim r As New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt)
                Me.ReportViewer1.LocalReport.DataSources.Add(r)

                'MANIPULATING PARAMETERS
                Dim asof_param As New ReportParameter("asof_param", Now)
                ReportViewer1.LocalReport.SetParameters(asof_param)

                'Dim rd As New ReportParameter("date_", Now)
                'Me.ReportViewer1.LocalReport.SetParameters(rd)

                Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                Me.ReportViewer1.ZoomMode = ZoomMode.Percent
                Me.ReportViewer1.ZoomPercent = 100



                Me.ReportViewer1.RefreshReport()
                pnlops.Controls.Clear()
                pnlops.Height = 0
            Else
                MsgBox("Nothing Found...")
            End If

        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try
       
    End Sub
End Class
