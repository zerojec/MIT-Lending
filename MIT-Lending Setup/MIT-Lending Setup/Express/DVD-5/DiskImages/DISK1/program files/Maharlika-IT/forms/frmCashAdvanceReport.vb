Imports Microsoft.Reporting.WinForms
Public Class frmCashAdvanceReport


    Public dtcashadvance As New DataTable
    Public dtcashadvance_payment As New DataTable

    Private Sub frmCashAdvanceReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dtcashadvance.TableName = "tblcashadvance"
        dtcashadvance_payment.TableName = "tblcashadvance_payment"

        Dim ds As New DataSet

        ds.Tables.Add(dtcashadvance)
        ds.Tables.Add(dtcashadvance_payment)



        Try
            If dtcashadvance IsNot Nothing And dtcashadvance_payment IsNot Nothing Then
                Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\reports\rptCashAdvanceReport.rdlc"
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Dim rd1 As New ReportDataSource("DataSet1", dtcashadvance)
                Dim rd2 As New ReportDataSource("DataSet2", dtcashadvance_payment)
                Me.ReportViewer1.LocalReport.DataSources.Add(rd1)
                Me.ReportViewer1.LocalReport.DataSources.Add(rd2)

                Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                Me.ReportViewer1.ZoomMode = ZoomMode.Percent
                Me.ReportViewer1.ZoomPercent = 100
                Me.ReportViewer1.RefreshReport()

            End If

        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        End Try


    End Sub
End Class