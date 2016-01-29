Public Class edit_loan_uc

    Dim WEEKLY_DUE As Decimal = 0 'aka WEEKLY_DUE
    Dim COLLECTIBLE As Decimal = 0
    Dim TOTAL_COLLECTIBLES As Decimal = 0
    Dim INCREMENTAL_DUE As Decimal = 0
    Dim NUM_OF_DAY_CTR As Integer = 0

    Dim PAYMENT As Decimal = 0
    Dim TOTAL_PAYMENT_FOR_THE_WEEK As Decimal = 0
    Dim DAILY As Decimal = 0

    Dim WEEKNO As Integer = 1
    Dim EXCESS As Decimal = 0
    Dim WEEK_EXCESS As Decimal = 0

    Dim LAPSE As Integer = 0
    Dim TOTAL_LAPSE As Integer = 0

    Dim CTR As Integer = 0

    Public edit_object As New loan

    Private Sub edit_loan_uc_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim c, b As New client
        b.id = edit_object.clientid

        c = b.SELECT_BY_ID()
        cboclient.Items.Add(c.lname & ", " & c.fname & " " & c.mname & "-" & c.id)
        cboclient.Text = cboclient.Items(0).ToString

        LoadData()
        LoadComakers()

    End Sub


    Sub LoadData()
        pnl_payment.Controls.Clear()
        txtloan.Text = ""
        txtaddress.Text = ""
        txtLoanCycle.Text = ""
        txtname.Text = ""
        txtcontactno.Text = ""

        If cboclient.Text = "" Then Exit Sub

        Dim id As String = Split(cboclient.SelectedItem.ToString, "-")(1)
        Dim name As String = Split(cboclient.SelectedItem.ToString, "-")(0)

        Dim c, a, b, d As New client
        b.id = id
        c = b.SELECT_BY_ID()

        Dim loan_cycle As Integer = b.GET_LOAN_CYCLE(id)

        txtLoanCycle.Text = loan_cycle
        txtaddress.Text = c.address
        txtcontactno.Text = c.contactno
        txtname.Text = c.lname & ", " & c.fname & " " & c.mname

        ' MsgBox(edit_object.loan_amount)

        dtrelease_date.Value = edit_object.date_released
        txtstart_of_payment.Text = edit_object.start_of_payment.ToShortDateString
        txtend_of_payment.Text = edit_object.end_of_payment.ToShortDateString
        txtdaily_payment.Text = Format(edit_object.daily_payment_amount, "#,##0.00")
        txtloan.Text = Format(edit_object.loan_amount, "#,##0.00")

        d.id = edit_object.comakerid
        b = d.SELECT_BY_ID

        If b IsNot Nothing Then
            cbocomaker.Text = b.lname & ", " & b.fname & " " & b.mname & "-" & b.id
        Else
            cbocomaker.Text = ""
        End If



    End Sub


    Sub LoadComakers()
        Dim dt As New DataTable
        Dim c As New client
        dt = c.SELECT_ALL


        cbocomaker.Items.Clear()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim s As String = ""
                    s = (r.Item("lname") & ", " & r.Item("fname") & " " & r.Item("mname") & "-" & r.Item("id"))
                    If Not s = cboclient.Text Then
                        cbocomaker.Items.Add(s)
                        cbocomaker.AutoCompleteCustomSource.Add(s)
                    End If
                Next
            End If
        Else

        End If


    End Sub

    Private Sub txtloan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtloan.KeyPress
        Dim n As Integer = AscW(e.KeyChar)
        If ThisKeyCodeIsHere(n) Then
            If n = 46 Then
                If txtloan.Text.Contains(".") Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Sub ComputeDates()
        Dim d As Date = dtrelease_date.Value
        txtstart_of_payment.Text = d.AddDays(1).ToShortDateString
        txtend_of_payment.Text = d.AddDays(100).ToShortDateString
    End Sub

    Private Sub dtrelease_date_ValueChanged(sender As Object, e As EventArgs) Handles dtrelease_date.ValueChanged
        ComputeDates()
    End Sub

    Sub WITH_ACTIVE_LOAN()
        Dim lbl As New Label
        lbl.Font = New Font("Verdana", 14, FontStyle.Bold)
        lbl.ForeColor = Color.Red
        'lbl.Top = (pnl_payment.Height / 2) - 10
        lbl.Dock = DockStyle.Fill


        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Text = "UNABLE TO PROCESS: ACTIVE_LOAN_DETECTED"
        lbl.AutoSize = False

        pnl_payment.Controls.Add(lbl)
        btnSave.Enabled = False
    End Sub
    Sub DetermineCutOffs(ByVal l As loan)

        Dim release_date As Date = l.date_released
        Dim start_of_payment As Date = release_date.AddDays(1)
        Dim end_of_payment As Date = start_of_payment.AddDays(100)
        DAILY = CDec(l.loan_amount) / 100

        Dim day_num As Integer = start_of_payment.Day
        Dim month_num As Integer = start_of_payment.Month
        Dim excess_from_previous As Decimal = 0
        Dim collectible_from_previous_week As Decimal = 0



        pnl_payment.Controls.Clear()

        '=========================================
        'dc variable is short for "DAYS COUNT" just for counting 100 days
        Dim t As Integer = 0
        Dim ps(100) As payment_schedule

        For dc As Integer = 0 To 99

            WEEKLY_DUE += DAILY

            Dim ps_uc As New pay_sched_uc

            ps(dc) = New payment_schedule

            ps(dc).loanid = l.id

            ps(dc).daily = DAILY
            ps(dc).day = dc + 1
            ps(dc).schedule_date = start_of_payment.AddDays(dc)

            ps(dc).GET_PAYMENT()
            ps(dc).due = WEEKLY_DUE


            'IF LOOP COUNTER =0 OFCOURSE THERE IS NO PREVIOUS PAYMENT
            If dc = 0 Then
                ps(dc).excess_from_previous = 0
            Else
                ps(dc).excess_from_previous = excess_from_previous
            End If

            TOTAL_PAYMENT_FOR_THE_WEEK += ps(dc).payment_amount

            If Not ps(dc).schedule_date > Now Then
                If ps(dc).IS_LAPSE Then
                    LAPSE += 1
                End If
            End If

            ps_uc.ps = ps(dc)
            ps_uc.Height = 30
            ps_uc.Top = t
            ps_uc.Width = pnl_payment.Width - 30
            'ps_uc.Dock = DockStyle.Bottom

            pnl_payment.VerticalScroll.Value = 0
            pnl_payment.Controls.Add(ps_uc)

            NUM_OF_DAY_CTR += 1

            If CutOff(start_of_payment.AddDays(dc)) Then

                Dim c As New cutoff_uc
                c.Width = pnl_payment.Width - 30
                c.Top = t + ps_uc.Height
                c.lblweekno.Text = WEEKNO

                c.lbldue.Text = Format(collectible_from_previous_week + (NUM_OF_DAY_CTR * DAILY), "#,##0.00")
                c.lblpayment.Text = Format(TOTAL_PAYMENT_FOR_THE_WEEK, "#,##0.00")


                c.lblcollectibles.Text = Format(CDec(c.lbldue.Text) - CDec(c.lblpayment.Text), "#,##0.00")
                c.lblabsent.Text = LAPSE

                collectible_from_previous_week = CDec(c.lblcollectibles.Text)

                excess_from_previous = CDec(c.lblcollectibles.Text)

                pnl_payment.Controls.Add(c)

                t += c.Height - 2

                WEEKNO += 1
                TOTAL_PAYMENT_FOR_THE_WEEK = 0
                TOTAL_LAPSE += LAPSE
                LAPSE = 0
                NUM_OF_DAY_CTR = 0

            End If

            t += ps_uc.Height - 2
            excess_from_previous = ps(dc).GET_TOTAL_CASH - DAILY

            If excess_from_previous < 0 Then
                excess_from_previous = 0
            End If
        Next

    End Sub

    Function CutOff(ByVal sop As Date) As Boolean
        If sop.Day = 7 Or sop.Day = 15 Or sop.Day = 23 Or IsLastDay(sop) Then
            CutOff = True
        Else
            CutOff = False
        End If
    End Function


    Private Sub txtloan_Leave(sender As Object, e As EventArgs) Handles txtloan.Leave
        If txtloan.Text = "" Or cboclient.Text = "" Then Exit Sub

        Dim c As New client
        c.id = Split(cboclient.Text, "-")(1)



        Dim daily As Decimal = 0
        Dim loan_amount As Decimal = CDec(txtloan.Text)
        daily = loan_amount / 100
        txtdaily_payment.Text = Format(daily, "#,##0.00")
        txtloan.Text = Format(loan_amount, "#,##0.00")

        Dim b As New loan
        b.loan_amount = loan_amount
        b.date_released = dtrelease_date.Value
        DetermineCutOffs(b)
     
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Parent.Height = 0
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboclient.Text = "" Or txtloan.Text = "" Or cbocomaker.Text = "" Then Exit Sub

        'IF THERE IS NO COMAKER
        If cbocomaker.Text <> "" Then
            edit_object.comakerid = Split(cbocomaker.SelectedItem.ToString, "-")(1)
        Else
            edit_object.comakerid = 0
        End If

        'edit_object.loan_amount = CDec(txtloan.Text)
        'edit_object.date_released = dtrelease_date.Value
        'edit_object.start_of_payment = CDate(txtstart_of_payment.Text)
        'edit_object.end_of_payment = CDate(txtend_of_payment.Text)

        ''CHECK IF THE CLIENT HAS AN ACTIVE LOAN

        'If edit_object.update Then
        '    MsgBox("Success", MsgBoxStyle.Information, "Updating Loan")
        'Else
        '    MsgBox("Failed:" & err_global.Message, MsgBoxStyle.Information, "Updating Loan")
        'End If
        frmMain.btnLoans.PerformClick()
    End Sub

    Private Sub cbocomaker_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocomaker.SelectedIndexChanged
        If cboclient.Text = "" Then Exit Sub

        If cboclient.Text = cbocomaker.Text Then
            cboclient.Text = ""
            cbocomaker.Text = ""
        Else

            Dim new_comaker As New client
            new_comaker.id = CInt(Split(cbocomaker.Text, "-")(1))

            If Not new_comaker.CHECK_IF_A_COMAKER Then
                cboclient.Enabled = False
                cbocomaker.Enabled = False
            Else
                MsgBox("Denied : person you selected is an active comaker.", MsgBoxStyle.Information, "Comaker")
                cbocomaker.Text = ""
            End If

        End If
    End Sub
End Class
