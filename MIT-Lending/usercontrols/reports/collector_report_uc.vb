Imports Microsoft.Reporting.WinForms
Public Class collector_report_uc

    Private Sub collector_report_uc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCollectors()
    End Sub

    Sub LoadCollectors()
        Dim dt As New DataTable
        Dim c As New emp
        dt = c.SELECT_ALL

        cboEmployee.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim s As String = ""
                    s = (r.Item("lname") & ", " & r.Item("fname")) & "-" & r.Item("id")
                    cboEmployee.Items.Add(s)
                    'cboemp.AutoCompleteCustomSource.Add(s)
                Next
            End If
        Else
            cboEmployee.Items.Add("Nothing Found...")
        End If
    End Sub



    Private Sub cboEmployee_Click(sender As Object, e As EventArgs) Handles cboEmployee.Click
        cboEmployee.Text = ""
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        If cboEmployee.Text = "" Then Exit Sub

        Dim dt As New DataTable
        Dim p As New payment

        Dim thisdate As Date = DateTimePicker1.Value
        Dim empid As Integer = CInt(Split(cboEmployee.Text, "-")(1))
        Dim empname As String = Split(cboEmployee.Text, "-")(0)

        dt = p.SELECT_BY_DATE_BY_COLLECTOR(thisdate, empid)

        Try

            If dt IsNot Nothing Then
                Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\reports\Report2.rdlc"
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Dim r As New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt)
                Me.ReportViewer1.LocalReport.DataSources.Add(r)

                'MANIPULATING PARAMETERS
                'Dim fd As New ReportParameter("from_date", from_date)
                'Dim td As New ReportParameter("to_date", to_date)
                'ReportViewer1.LocalReport.SetParameters(fd)
                'ReportViewer1.LocalReport.SetParameters(td)

                Dim rd As New ReportParameter("date_", thisdate)
                Dim re As New ReportParameter("emp_", empname)
                Me.ReportViewer1.LocalReport.SetParameters(rd)
                Me.ReportViewer1.LocalReport.SetParameters(re)

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
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Exclamation, "Failed")
        End Try




    End Sub
End Class
