Imports Microsoft.Reporting.WinForms
Public Class client_report_uc

    Sub LoadClients()
        Dim dt As New DataTable
        Dim c As New client
        dt = c.SELECT_ALL

        cboclient.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim s As String = ""
                    s = (r.Item("lname") & ", " & r.Item("fname")) & "-" & r.Item("id")
                    cboclient.Items.Add(s)
                    cboclient.AutoCompleteCustomSource.Add(s)
                Next
            End If
        Else

        End If


    End Sub

    Private Sub client_report_uc_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadClients()
    End Sub

    Private Sub cboclient_Click(sender As Object, e As EventArgs) Handles cboclient.Click
        cboclient.Text = ""
    End Sub

    Public Sub LoadLoansByClientID(ByVal cid As Integer)
        Dim l As New loan
        l.clientid = cid

        Dim dt As New DataTable
        dt = l.SELECT_BY_CLIENTID(l.clientid)
        cblLoans.Items.Clear()

        If dt IsNot Nothing Then

            If dt.Rows.Count > 0 Then
                For Each r As DataRow In dt.Rows
                    Dim daily As Decimal = r.Item("loan_amount") / 100
                    Dim active As Boolean = r.Item("active")
                    If active Then
                        cblLoans.Items.Add(r.Item("id").ToString & "-" & r.Item("loan_amount").ToString & "@" & daily & "-Active")
                    Else
                        cblLoans.Items.Add(r.Item("id").ToString & "-" & r.Item("loan_amount").ToString & "@" & daily)
                    End If

                Next
            Else
                cblLoans.Items.Add("No Loans Retrieved...")
            End If
           
        Else
            cblLoans.Items.Add("No Loans Retrieved...")
        End If


        'cblLoans.Text = cblLoans.Items(0).ToString

    End Sub


    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        If cboclient.Text = "" Or cblLoans.Text = "" Then Exit Sub

        Dim dt As New DataTable
        Dim c, c1 As New client

        c.id = CInt(Split(cboclient.Text, "-")(1))
        c1 = c.SELECT_BY_ID


        '===============================================
        'AFTER GETTING THE CLIENT, GET HIS/HER ACTIVE LOAN CYCLE ID
        'Dim alc As Integer = c.GET_ACTIVE_LOAN_CYCLE

        Dim lc As Integer = Split(cblLoans.Text, "-")(0)
        '=============================================================
        'AFTER DETERMINING LOAN ID, INSTANTIATE A LOAN (USING LOAN ID)
        Dim a, loan As New loan
        loan.id = lc
        a = loan.SELECT_BY_ID


        '=============================================================
        'IF THE CLIENT HAS AN ACTIVE LOAN, TRY RETRIEVING ITS PAYMENTS
        If a IsNot Nothing Then

            Dim p, payment As New payment
            payment.loanid = lc
            p = payment

            Dim total_payment As Decimal = p.SELECT_SUM_BY_LOANID(lc)
            Dim loan_amount As Decimal = a.loan_amount
            Dim balance As Decimal = loan_amount - total_payment

            dt = p.SELECT_BY_LOANID

            Try
                If dt IsNot Nothing Then
                    Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\reports\client.rdlc"
                    Me.ReportViewer1.LocalReport.DataSources.Clear()

                    Dim r As New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt)

                    Me.ReportViewer1.LocalReport.DataSources.Add(r)

                    'MANIPULATING PARAMETERS
                    Dim idparam As New ReportParameter("id_param", c1.id)
                    Dim nameparam As New ReportParameter("name_param", c1.lname & ", " & c1.fname & " " & c1.mname)
                    Dim addressparam As New ReportParameter("address_param", c1.address)
                    Dim contactparam As New ReportParameter("contact_param", c1.contactno)

                    Dim active_loan_param As New ReportParameter("active_loan_param", a.id & "-" & a.loan_amount & "@" & a.loan_amount / 100)
                    Dim release_date_param As New ReportParameter("release_date_param", a.date_released)
                    Dim payment_start_param As New ReportParameter("payment_start_param", a.start_of_payment)
                    Dim payment_end_param As New ReportParameter("payment_end_param", a.end_of_payment)
                    Dim balance_param As New ReportParameter("balance_param", balance)
                    Dim asof_param As New ReportParameter("asof_param", Now)


                    ReportViewer1.LocalReport.SetParameters(idparam)
                    ReportViewer1.LocalReport.SetParameters(nameparam)
                    ReportViewer1.LocalReport.SetParameters(addressparam)
                    ReportViewer1.LocalReport.SetParameters(contactparam)
                    ReportViewer1.LocalReport.SetParameters(active_loan_param)
                    ReportViewer1.LocalReport.SetParameters(release_date_param)
                    ReportViewer1.LocalReport.SetParameters(payment_start_param)
                    ReportViewer1.LocalReport.SetParameters(payment_end_param)
                    ReportViewer1.LocalReport.SetParameters(balance_param)
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
        Else
            MsgBox("Client has no active loan", MsgBoxStyle.Information, "")
        End If

       
    End Sub

    Sub MySubreportEventHandler()

    End Sub

    Private Sub cboclient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboclient.SelectedIndexChanged

        If cboclient.Text <> "" Then
            Dim cid As Integer = Split(cboclient.Text, "-")(1)
            LoadLoansByClientID(cid)

        End If

        If cblLoans.Items.Count > 0 Then
            cblLoans.Text = cblLoans.Items(0).ToString
        End If

    End Sub
End Class
