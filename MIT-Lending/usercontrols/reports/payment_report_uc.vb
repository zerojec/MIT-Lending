Imports Microsoft.Reporting.WinForms
Public Class payment_report_uc

    Dim dt As New DataTable
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim p As New payment
        dt = p.SELECT_BY_DATE(DateTimePicker1.Value)

        Try
            If dt IsNot Nothing Then
                Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\reports\Report1.rdlc"
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Dim r As New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt)
                Me.ReportViewer1.LocalReport.DataSources.Add(r)

                'MANIPULATING PARAMETERS
                'Dim fd As New ReportParameter("from_date", from_date)
                'Dim td As New ReportParameter("to_date", to_date)
                'ReportViewer1.LocalReport.SetParameters(fd)
                'ReportViewer1.LocalReport.SetParameters(td)

                Dim rd As New ReportParameter("date_", DateTimePicker1.Value)
                Me.ReportViewer1.LocalReport.SetParameters(rd)

                Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                Me.ReportViewer1.ZoomMode = ZoomMode.Percent
                Me.ReportViewer1.ZoomPercent = 100
                Me.ReportViewer1.RefreshReport()
                pnlops.Controls.Clear()
                pnlops.Height = 0
            End If

        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try

    End Sub
End Class
