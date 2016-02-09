Imports MySql.Data.MySqlClient
Public Class client_profile_uc

    Public c As New client
    



    Private Sub client_profile_uc_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtaddress.Text = c.address
        txtcontactno.Text = c.contactno
        txtfname.Text = c.fname
        txtid.Text = c.id & "-" & c.areaid
        txtlname.Text = c.lname
        txtmname.Text = c.mname
        txtloan_cycle.Text = c.GET_LOAN_CYCLE(c.id)
        LoadCycles(c.id)
        LoadWhoIBecameACoMaker(c.id)

    End Sub

    Sub LoadCycles(ByVal id As Integer)

        Dim dt As New DataTable
        Dim l As New loan
        dt = l.SELECT_BY_CLIENTID(id)

        lstLoanCycles.Items.Clear()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows

                    Dim p As New payment
                    Dim total_payment As Decimal = p.SELECT_SUM_BY_LOANID(r.Item("id"))
                    Dim loan_amount As Decimal = r.Item("loan_amount")
                    Dim balance As Decimal = loan_amount - total_payment

                    Dim li As New ListViewItem
                    li.Text = x
                    li.Tag = r.Item("id")
                    li.SubItems.Add(Format(loan_amount, "#,##0.00"))
                    li.SubItems.Add(Format(total_payment, "#,##0.00"))
                    li.SubItems.Add(Format(balance, "#,##0.00"))


                    lstLoanCycles.Items.Add(li)
                    'lstLoanCycles.Items.Add(x & "- Php " & Format(r.Item("loan_amount"), "#,##0.00") & "----> Total Payment:  Php " & Format(total_payment, "#,##0.00"))
                    x += 1
                Next
            End If
        Else

        End If
    End Sub

    Sub LoadWhoIBecameACoMaker(ByVal id As Integer)

        Dim dt As New DataTable
        Dim l As New loan
        l.comakerid = id
        dt = l.SELECT_BY_COMAKERID

        lvclient_has_been_comaker_to.Items.Clear()


        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows

                    Dim p As New payment
                    Dim total_payment As Decimal = p.SELECT_SUM_BY_LOANID(r.Item("loanid"))
                    Dim loan_amount As Decimal = r.Item("loan_amount")
                    Dim balance As Decimal = loan_amount - total_payment

                    Dim li As New ListViewItem
                    'li.Text = x
                    li.Tag = r.Item("loanid")
                    li.Text = r.Item("fullname")
                    li.SubItems.Add(Format(r.Item("loan_amount"), "#,##0.00"))
                    li.SubItems.Add(Format(balance, "#,##0.00"))


                    lvclient_has_been_comaker_to.Items.Add(li)
                    'lstLoanCycles.Items.Add(x & "- Php " & Format(r.Item("loan_amount"), "#,##0.00") & "----> Total Payment:  Php " & Format(total_payment, "#,##0.00"))
                    x += 1
                Next
            End If
        Else

        End If
    End Sub

    Private Sub lstLoanCycles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstLoanCycles.MouseDoubleClick
        If lstLoanCycles.SelectedItems.Count > 0 Then

            ResetVariables()

            Dim sel As Integer = lstLoanCycles.SelectedItems(0).Tag      
            Dim l, loan As New loan
            loan.id = sel
            l = loan.SELECT_BY_ID

            DetermineCutOffs(l)

        End If
    End Sub



    'DETERMINE CUTOFFS

    Sub DetermineCutOffs(ByVal l As loan)

        Dim WEEKLY_DUE As Decimal = 0 'aka WEEKLY_DUE
        Dim WEEKNO As Integer = 1
        Dim OVERALL_DUE As Decimal = 0
        Dim LAPSE_CTR As Integer = 0
        Dim TOTAL_LAPSE As Integer = 0
        Dim CTR As Integer = 0
        Dim OVERDUE_CTR As Integer = 0
        Dim ABSENT_DAYS As Integer = 0 'NO PAYMENT ON SCHEDULE
        Dim PAYMENT_CTR As Integer = 0
        Dim RATING As String = ""
        Dim STATS As String = ""


        lv.Items.Clear()

        Dim release_date As Date = l.date_released
        Dim start_of_payment As Date = release_date.AddDays(1)
        Dim end_of_payment As Date = start_of_payment.AddDays(100)
        Dim daily As Decimal = CDec(l.loan_amount) / 100


        'VARIABLE FOR TOTAL PAYMENT FOR THE WEEK
        Dim WEEK_TOTAL As Decimal = 0
        'pnl_payment.Controls.Clear()

        '=========================================
        'dc variable is short for "DAYS COUNT" just for counting 100 days
        Dim t As Integer = 0        

        Dim lOOP_END_CTR As Integer = 0




        For dc As Integer = 0 To 99


            Dim has_start_date As Boolean = False 'determines whether the generated cutoff contains the start_date of payment of the client
            Dim has_end_date As Boolean = False ' determines whethere the generated cutoff contains the end_date of the payment of the client
            Dim overdue As Decimal = 0

            Dim cutoff_start_date As Date
            Dim cutoff_end_date As Date

            Dim no As Integer = dc + 1
            'dc is the counter for looping to 100 days
            'thsdate is the DAY generated (dc)DAYS after start_of_payment DATE
            Dim thisdate As Date = DateAdd(DateInterval.Day, dc, start_of_payment)
            Dim payment_for_this_day As Decimal = 0
            Dim collectibles As Decimal = 0

            Dim p As New payment
            p.loanid = l.id

            'GET PAYMENT FOR THIS DATE
            payment_for_this_day = p.SELECT_BY_DATE_BY_LOANID(p.loanid, thisdate)

            WEEK_TOTAL += payment_for_this_day


            'INCREMENT ABSENT_DAYS

            If payment_for_this_day = 0 Then
                'IF FULLY PAID
                If Not l.date_fully_paid.CompareTo(CDate("1/1/0001")) = 0 Then
                    'IF FULLY_PAID_DATE IS LESS THAN END_OF_PAYMENT DATE
                    If l.date_fully_paid.CompareTo(l.end_of_payment) <= 0 Then
                        If thisdate.CompareTo(l.start_of_payment) >= 0 AndAlso thisdate.CompareTo(l.date_fully_paid) <= 0 Then ABSENT_DAYS += 1
                    Else
                        ABSENT_DAYS += 1
                    End If
                Else               
                    If thisdate.CompareTo(l.start_of_payment) >= 0 AndAlso thisdate.CompareTo(Date.Now) <= 0 Then ABSENT_DAYS += 1
                End If
            End If
            

            'INCREMENT WEEKLY DUE BY ADDING THE 
            'DAILY PAYMENT FOR EACH DAY IN THE CUTOFF PERIOD
            WEEKLY_DUE += daily

            Dim li As New ListViewItem
            li.Text = no
            li.SubItems.Add(thisdate)
            li.SubItems.Add(payment_for_this_day)

            '==========================
            'color code payment
            'red for no payment
            'greenyellow with payment
            '===========================
            If payment_for_this_day = 0 Then
                li.BackColor = Color.Red
            Else
                li.BackColor = Color.GreenYellow
            End If


            If thisdate = start_of_payment Then
                has_start_date = True
            End If


            If thisdate = end_of_payment Then
                has_end_date = True
            End If


            If CutOff(thisdate) Or dc = 99 Then




                Dim cutoffli As New ListViewItem
                lv.Items.Add(li)
                cutoffli.Text = "CUTOFF"
                cutoffli.SubItems.Add("DUE :" & WEEKLY_DUE)
                cutoffli.SubItems.Add("WEEK TOTAL:" & WEEK_TOTAL)
                lv.Items.Add(cutoffli)


                'DETERMINE START_DATE AND END_DATE OF THE CUTOFF
                If thisdate.Day = 7 Then
                    If WEEKNO = 1 Then
                        cutoff_start_date = start_of_payment
                    Else
                        cutoff_start_date = DateAdd(DateInterval.Day, -6, thisdate)
                    End If
                ElseIf thisdate.Day = 15 Or thisdate.Day = 23 Then
                    If WEEKNO = 1 Then
                        cutoff_start_date = start_of_payment
                    Else
                        cutoff_start_date = DateAdd(DateInterval.Day, -7, thisdate)
                    End If
                Else
                    If WEEKNO = 1 Then
                        cutoff_start_date = start_of_payment
                    Else
                        cutoff_start_date = New Date(thisdate.Year, thisdate.Month, 24)
                    End If
                End If

                'cutoff_end_date
                cutoff_end_date = thisdate


                'NOW CALCULATE OVERALL DUE TO DATE
                OVERALL_DUE = CalculateDue(start_of_payment, cutoff_end_date, daily)

                collectibles = WEEKLY_DUE - WEEK_TOTAL











                If has_start_date Then
                    WEEKLY_DUE = OVERALL_DUE
                    overdue = 0
                Else
                    Dim payment_from_previous_week As Decimal = 0
                    Dim collectibles_from_previous_week As Decimal = 0
                    Dim due_from_last_week As Decimal = 0


                    payment_from_previous_week = p.SELECT_BETWDATE_BY_LOANID(start_of_payment, DateAdd(DateInterval.Day, -1, cutoff_start_date))

                    due_from_last_week = GET_DUE_FROM_LAST_WEEK(start_of_payment, DateAdd(DateInterval.Day, -1, cutoff_start_date), daily, end_of_payment)
                    'TESTING DATA

                    'weekly_due = overall_due - payment_from_previous_week
                    overdue = due_from_last_week - payment_from_previous_week
                    'collectibles = (weekly_due - weekly_total) + overdue
                    'weekly_due = 
                End If



                collectibles = collectibles + overdue

                Dim lio As New ListViewItem



                If dc < 99 Then
                    lio.Text = "OVERDUE:"
                    If overdue < 1 Then
                        lio.SubItems.Add(0)
                    Else
                        lio.SubItems.Add(overdue)
                    End If
                    lv.Items.Add(lio)
                    Dim lic As New ListViewItem
                    lic.Text = "COLLECTIBLES:"
                    lic.SubItems.Add(collectibles)
                    lv.Items.Add(lic)
                Else

                    Dim bal As Decimal = l.GET_BALANCE()
                    lio.Text = "OVERDUE:"
                    If overdue < 1 Then
                        lio.SubItems.Add(0)
                    Else
                        lio.SubItems.Add(bal)
                    End If
                    lv.Items.Add(lio)
                    Dim lic As New ListViewItem
                    lic.Text = "COLLECTIBLES:"
                    lic.SubItems.Add(bal)
                    lv.Items.Add(lic)
                End If


                'COUNTER OF OVERDUE
                If collectibles > 0 And thisdate.CompareTo(l.date_fully_paid) = -1 Then
                    OVERDUE_CTR += 1
                End If

                'if cutoff reset weekly due to zero         
                WEEKLY_DUE = 0
                WEEKNO += 1
                WEEK_TOTAL = 0
            Else
                lv.Items.Add(li)
            End If



        Next


        Dim lbl As New Label
        lbl.Font = New Font("Verdana", 10, FontStyle.Bold)
        lbl.TextAlign = ContentAlignment.MiddleRight
        lbl.Dock = DockStyle.Fill
        lbl.ForeColor = Color.White

       

        ''new 
        'If TOTAL_LAPSE < 10 Then
        '    rating = "EXCELLENT"            
        'ElseIf TOTAL_LAPSE >= 11 And TOTAL_LAPSE <= 20 Then
        '    rating = "GOOD"
        'ElseIf TOTAL_LAPSE > 21 Then
        '    rating = "SATISFACTORY"
        'End If


        If OVERDUE_CTR > 0 Then
            RATING = "OVERDUE"
        Else
            If ABSENT_DAYS < 10 Then
                RATING = "EXCELLENT"
            ElseIf ABSENT_DAYS >= 11 And ABSENT_DAYS <= 20 Then
                RATING = "GOOD"
            ElseIf ABSENT_DAYS > 21 Then
                RATING = "SATISFACTORY"
            End If
        End If


        lbl.Text = "ABSENTS:  " & ABSENT_DAYS & vbTab
        lbl.Text &= vbTab & "  |  OVERDUE: " & OVERDUE_CTR


        lbl.Text &= vbTab & "  |  RATING: " & RATING

        If Not l.date_fully_paid.CompareTo(CDate("1/1/0001")) = 0 Then
            lbl.Text &= vbTab & "  |  DATE FULLY PAID : " & l.date_fully_paid.ToShortDateString()
        End If

        'CHECK LAPSE
        If Not l.date_fully_paid.CompareTo(CDate("1/1/0001")) = 0 Then

            If l.date_fully_paid.CompareTo(l.end_of_payment) > 0 Then
                Dim ts As TimeSpan = l.date_fully_paid.Subtract(l.end_of_payment)
                LAPSE_CTR = ts.TotalDays
            End If
        Else
            If Date.Now.CompareTo(l.end_of_payment) > 0 Then
                Dim ts As TimeSpan = Date.Now.Subtract(l.end_of_payment)
                LAPSE_CTR = ts.TotalDays
            End If
        End If

        lbl.Text &= vbTab & "  | LAPSE : " & LAPSE_CTR.ToString()


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
        'WEEKLY_DUE = 0 'aka DUE    
        'LAPSE = 0
        'TOTAL_LAPSE = 0
    End Sub

    
   
    Private Sub lstLoanCycles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLoanCycles.SelectedIndexChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Parent.Height = 0
        Me.Dispose()
    End Sub

    Private Sub AssessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssessToolStripMenuItem.Click
        If lstLoanCycles.SelectedItems.Count > 0 Then

            ResetVariables()

            Dim sel As Integer = lstLoanCycles.SelectedItems(0).Tag
            Dim l, loan As New loan
            loan.id = sel
            l = loan.SELECT_BY_ID

            DetermineCutOffs(l)

        End If
    End Sub

    Private Sub ReviewPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReviewPaymentsToolStripMenuItem.Click
        If lstLoanCycles.SelectedItems.Count > 0 Then

            ResetVariables()

            Dim sel As Integer = lstLoanCycles.SelectedItems(0).Tag
            Dim l, loan As New loan
            loan.id = sel
            l = loan.SELECT_BY_ID

            LoadPaymentHistory(l)

        End If
    End Sub


    Sub LoadPaymentHistory(ByVal l As loan)

        lv.Items.Clear()

        Dim p As New payment
        p.loanid = l.id

        Dim dt As New DataTable
        dt = p.SELECT_BY_LOANID()

        Dim total_payment_accounted As Decimal = 0
        Dim ctr As Integer = 1
        For Each row As DataRow In dt.Rows
            Dim li As New ListViewItem
            li.Text = ctr

            Dim amt As Decimal = CDec(row.Item("amount").ToString())
            Dim date_ As Date = CDate(row.Item("date_").ToString())

            If date_ > l.end_of_payment Then
                li.BackColor = Color.Red
            End If

            If amt > 0 Then
                li.SubItems.Add(date_.ToShortDateString())
                li.SubItems.Add(amt.ToString("#,##0.00"))
                lv.Items.Add(li)
                total_payment_accounted += amt
                ctr += 1
            End If


        Next


        Dim liline As New ListViewItem
        liline.Text = "==="
        liline.SubItems.Add("==========")
        liline.SubItems.Add("=============")
        lv.Items.Add(liline)

        Dim litotal As New ListViewItem
        litotal.Text = ""
        litotal.SubItems.Add("")      
        litotal.SubItems.Add(total_payment_accounted.ToString("#,##0.00"))
        lv.Items.Add(litotal)




        pnlstats.Controls.Clear()

        Dim lbl As New Label
        lbl.Font = New Font("Verdana", 10, FontStyle.Bold)
        lbl.TextAlign = ContentAlignment.MiddleRight
        lbl.Dock = DockStyle.Fill
        lbl.ForeColor = Color.White

        'what to write here???
        'as message for the user

        'pnlstats.Controls.Add(lbl)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class
