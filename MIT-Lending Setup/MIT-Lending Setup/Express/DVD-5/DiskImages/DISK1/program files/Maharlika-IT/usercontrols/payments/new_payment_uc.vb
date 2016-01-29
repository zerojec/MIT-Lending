Imports MySql.Data.MySqlClient

Public Class new_payment_uc

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

    Public c As client

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

    Sub LoadCollectors()
        Dim dt As New DataTable
        Dim c As New emp
        dt = c.SELECT_ALL

        cbocollector.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim s As String = ""
                    s = r.Item("id") & "-" & (r.Item("lname") & ", " & r.Item("fname"))
                    cbocollector.Items.Add(s)
                Next
            End If
        Else

        End If
    End Sub

    Private Sub new_payment_uc_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim s As String = ""
        If c Is Nothing Then
            LoadClients()
        Else

            s = c.lname & ", " & c.fname & " " & c.mname & "-" & c.id
            cboclient.Items.Add(s)
            cboclient.Text = s
            cboclient.Enabled = False
            'ProcessClientData()
        End If
        LoadCollectors()

    End Sub

    Private Sub cboclient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboclient.SelectedIndexChanged

        ProcessClientData()

    End Sub

    Sub ProcessClientData()

        ResetVariables()

        '===============================================
        'GET CLIENT USING ID (From COMBOBOX)
        Dim id As String = Split(cboclient.SelectedItem.ToString, "-")(1)
        Dim name As String = Split(cboclient.SelectedItem.ToString, "-")(0)

        Dim c, b As New client
        b.id = id
        c = b.SELECT_BY_ID()

        '===============================================
        'AFTER GETTING THE CLIENT, GET HIS/HER ACTIVE LOAN CYCLE ID
        Dim alc As Integer = c.GET_ACTIVE_LOAN_CYCLE

        '===============================================
        'AFTER DETERMINING LOAN ID, INSTANTIATE A LOAN (USING LOAN ID)
        Dim a, loan As New loan
        loan.id = alc
        a = loan.SELECT_BY_ID

        '===============================================
        'SHOW TO UI
        txtaddress.Text = c.address
        txtcontactno.Text = c.contactno
        txtname.Text = name

        If a IsNot Nothing Then
            txtactive_loan.Text = a.id & "-" & a.loan_amount & "@" & Format(a.loan_amount / 100, "#,##0.00")

            Dim p, payment As New payment
            payment.loanid = alc
            p = payment

            Dim total_payment As Decimal = p.SELECT_SUM_BY_LOANID(alc)
            Dim balance As Decimal = a.loan_amount - total_payment

            txttotal_payment.Text = Format(total_payment, "#,##0.00")
            txtbalance.Text = Format(balance, "#,##0.00")

            txtstartofpayment.Text = a.start_of_payment.ToShortDateString
            txtendofpayment.Text = a.end_of_payment.ToShortDateString

            Dim lapse As Integer = Now.Subtract(a.end_of_payment).TotalDays

            If lapse <= 0 Then
                txtdayslapse.Text = 0
            Else
                txtdayslapse.Text = lapse
            End If

            DetermineCutOffs(a)
        Else
            txtactive_loan.Text = "No active loan"
            txttotal_payment.Text = Format(0, "#,##0.00")
            txtbalance.Text = Format(0, "#,##0.00")
            txtstartofpayment.Text = ""
            txtendofpayment.Text = ""
            pnl_payment.Controls.Clear()
            NO_ACTIVE_LOAN()
        End If
    End Sub

    Sub NO_ACTIVE_LOAN()
        Dim lbl As New Label
        lbl.Font = New Font("Verdana", 14, FontStyle.Bold)
        lbl.ForeColor = Color.Red
        'lbl.Top = (pnl_payment.Height / 2) - 10
        lbl.Dock = DockStyle.Fill


        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Text = "NO ACTIVE LOAN DETECED"
        lbl.AutoSize = False

        pnl_payment.Controls.Add(lbl)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cboclient.Text = "" Or cbocollector.Text = "" Or txtamount.Text = "" Then Exit Sub
        If txtornumber.Text = "" Then Exit Sub


        Dim p As New payment
        p.amount = CDec(txtamount.Text)
        p.collectorid = Split(cbocollector.Text, "-")(0)
        p.clientid = Split(cboclient.Text, "-")(1)
        p.date_ = dtpayment_date.Value


        p.loanid = Split(txtactive_loan.Text, "-")(0)
        p.ornumber = txtornumber.Text




        If Not p.DUPLICATE_OR_NUMBER Then
            If p.save Then
                MsgBox("Success", MsgBoxStyle.Information, "Payment")

                'KAPAG ANG BAYAD AY EQUAL OR MALAKI PA SA BALANACE 
                'THEN FULLPAID NA DAPAT ANG UTANG
                If CDec(txtbalance.Text) <= CDec(txtamount.Text) Then
                    Dim l As New loan
                    l.id = p.loanid
                    If l.SET_TO_FULLY_PAID(dtpayment_date.Value) Then
                        MsgBox("Success", MsgBoxStyle.Information, "Setting to Fully Paid")
                    Else
                        MsgBox("Error: " & err_global.Message, MsgBoxStyle.Exclamation, "Setting to Fully Paid")
                    End If

                End If

                frmMain.btnPayments.PerformClick()
            Else
                MsgBox("Failed:" & err_global.Message, MsgBoxStyle.Information, "Payment")
            End If
        Else
            MsgBox("Failed: Duplicate OR Number detected", MsgBoxStyle.Exclamation, "Error")
        End If




    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        Dim n As Integer = AscW(e.KeyChar)
        If ThisKeyCodeIsHere(n) Then
            If n = 46 Then
                If txtamount.Text.Contains(".") Then
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

    Private Sub txtornumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtornumber.KeyPress
        Dim n As Integer = AscW(e.KeyChar)
        If ThisKeyCodeIsHere(n) Then
            If n = 46 Then
                If txtamount.Text.Contains(".") Then
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Parent.Height = 0
        Me.Dispose()
    End Sub

    Private Sub txtamount_Leave(sender As Object, e As EventArgs) Handles txtamount.Leave
        If txtamount.Text = "" Then Exit Sub
        txtamount.Text = Format(CDec(txtamount.Text), "#,##0.00")
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

            'WE ONLY CHECK FOR LAPSE or ABSENT IF THE SCHEDULED_PAYMENT_DATE 
            'IS GREATER THAN THAT OF TODAY'S DATE
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

            If CutOff(start_of_payment.AddDays(dc)) Or dc = 99 Then

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





        Dim lbl As New Label
        lbl.Font = New Font("Verdana", 10, FontStyle.Bold)
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Dock = DockStyle.Fill
        lbl.ForeColor = Color.White

        lbl.Text = "TOTAL ABSENT/S :  " & TOTAL_LAPSE & vbTab
        lbl.Text &= vbTab & "---AVERAGE ABSENT PER WEEK :  " & Format(TOTAL_LAPSE / WEEKNO, "0.00")

        Dim stats As String = ""
        Dim rating As String = ""

        If TOTAL_LAPSE < 10 Then
            rating = "EXCELLENT"
        ElseIf TOTAL_LAPSE >= 11 And TOTAL_LAPSE <= 20 Then
            rating = "GOOD"
        ElseIf TOTAL_LAPSE > 21 Then
            rating = "SATISFACTORY"
        End If

        If TOTAL_LAPSE > 0 Then
            stats = "LAPSE"
        Else
            stats = "NO LAPSE"
        End If

        lbl.Text &= vbTab & "---STATUS :  " & stats
        lbl.Text &= vbTab & "---RATING :  " & rating


        pnlstats.Controls.Add(lbl)



    End Sub


    Function CutOff(ByVal sop As Date) As Boolean
        If sop.Day = 7 Or sop.Day = 15 Or sop.Day = 23 Or IsLastDay(sop) Then
            CutOff = True
        Else
            CutOff = False
        End If
    End Function
    Function GetPayment(ByVal date_ As Date, ByVal loanid As Integer) As Decimal

        Dim p As New payment
        p.loanid = loanid
        Dim todayspayment As Decimal = p.SELECT_BY_DATE_BY_LOANID(loanid, date_)
        Return todayspayment

    End Function

    Sub ResetVariables()
        WEEKLY_DUE = 0 'aka DUE
        COLLECTIBLE = 0
        PAYMENT = 0
        TOTAL_PAYMENT_FOR_THE_WEEK = 0
        WEEKNO = 1
        EXCESS = 0
        LAPSE = 0
        TOTAL_LAPSE = 0
        WEEK_EXCESS = 0
        TOTAL_COLLECTIBLES = 0
        INCREMENTAL_DUE = 0

        pnl_payment.Controls.Clear()
    End Sub




    Private Sub cboclient_Click(sender As Object, e As EventArgs) Handles cboclient.Click
        cboclient.Text = ""
    End Sub
End Class
