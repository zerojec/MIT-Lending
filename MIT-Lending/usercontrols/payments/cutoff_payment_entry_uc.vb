Imports MySql.Data.MySqlClient
Imports excel = Microsoft.Office.Interop.Excel
Imports System.Globalization

Public Class cutoff_payment_entry_uc

    Public cutoff As String = ""
    Public area As String = ""
    Public month_ As String = ""

    Public start_of_cutoff As Date

    Private Sub cutoff_payment_entry_uc_Load(sender As Object, e As EventArgs) Handles Me.Load
        If cutoff <> "" And area <> "" Then
            GeneratePaymentEntry(cutoff, area)
        Else
            MsgBox("Please supply Cutoff and Area")
        End If
    End Sub
    Sub GeneratePaymentEntry(ByVal cutoff As String, ByVal area As String)
        'payment_dt = Nothing
        'payment_dt = New DataTable
        Dim monthNumber = DateTime.ParseExact(month_, "MMMM", CultureInfo.CurrentCulture).Month
        Dim p As New payment
        Dim from_day As Integer = Split(cutoff, "-")(0)
        Dim to_day As Integer = Split(cutoff, "-")(1)
        Dim from_date As Date = CDate(monthNumber & "-" & from_day & "-" & Year(Now))
        Dim to_date As Date = CDate(monthNumber & "-" & to_day & "-" & Year(Now))

        start_of_cutoff = from_date

        If area = "All Areas" Then
            payment_dt = p.GENERATE_ENTRY_ALL_AREA(from_date, to_date)
        Else
            payment_dt = p.GENERATE_ENTRY(from_date, to_date, area)
        End If
        Dim nofdays As Integer = DateDiff(DateInterval.Day, from_date, to_date)

        Dim idx As Integer = 5
        For x As Integer = 0 To nofdays
            Dim colString As DataColumn = New DataColumn(Format(from_date.AddDays(x), "MM/dd/yy"))
            colString.DataType = System.Type.GetType("System.Decimal")
            payment_dt.Columns.Add(colString)
            colString.SetOrdinal(idx)
            idx += 1
        Next

        Dim totalcol As DataColumn = New DataColumn("Week_Total")
        totalcol.DataType = System.Type.GetType("System.Decimal")

        Dim duecol As DataColumn = New DataColumn("Due")
        duecol.DataType = System.Type.GetType("System.Decimal")

        Dim overdue As DataColumn = New DataColumn("Overdue")
        overdue.DataType = System.Type.GetType("System.Decimal")

        Dim collcol As DataColumn = New DataColumn("Collectibles")
        collcol.DataType = System.Type.GetType("System.Decimal")

        Dim dailycol As DataColumn = New DataColumn("Daily")
        dailycol.DataType = System.Type.GetType("System.Decimal")

        Dim no As DataColumn = New DataColumn("No")
        no.DataType = System.Type.GetType("System.Int32")

        payment_dt.Columns.Add(totalcol)
        payment_dt.Columns.Add(duecol)
        payment_dt.Columns.Add(overdue)
        payment_dt.Columns.Add(collcol)
        payment_dt.Columns.Add(dailycol)
        payment_dt.Columns.Add(no)

        totalcol.SetOrdinal(idx)
        duecol.SetOrdinal(idx + 1)
        overdue.SetOrdinal(idx + 2)
        collcol.SetOrdinal(idx + 3)
        dailycol.SetOrdinal(idx + 4)
        no.SetOrdinal(2)

        dtg.DataSource = payment_dt
        dtg.Refresh()

        '=================================================
        'VITAL COMPUTATIONS FOR FINANCES : COMPUTEFINANCIALS
        '=================================================
        ComputeFinancials(from_date, to_date)

        'dtg.DataSource = Nothing
        dtg.DataSource = payment_dt

        'another row to show subtotals
        Dim d As DataRow = payment_dt.NewRow
        payment_dt.Rows.Add(d)
        ComputeSUbTotal()
        dtg.Refresh()
        btnprint.Enabled = True

    End Sub

    Sub ComputeFinancials(ByVal from_date As Date, ByVal to_date As Date)

        Dim cols As Integer = payment_dt.Columns.Count
        Dim cnt As Integer = 1
        'frmTestData.Add(cols)

        For r As Integer = 0 To payment_dt.Rows.Count - 1

            Dim has_start_date As Boolean = False 'determines whether the generated cutoff contains the start_date of payment of the client
            Dim has_end_date As Boolean = False ' determines whethere the generated cutoff contains the end_date of the payment of the client

            Dim cid, lid As Integer ' the client_id and loan_id
            Dim amount As Decimal = 0 ' will hold the payment made by client as recorded in the database
            Dim weekly_total As Decimal = 0 'client's total_payment for the week
            Dim weekly_due As Decimal = 0 'client's daily * no_of_days (in a single cutoff)
            Dim overdue As Decimal = 0
            Dim overall_due As Decimal = 0 'client's overall due=== begining from start_date to the latest_cutoff

            Dim daily As Decimal = CDec(payment_dt.Rows(r).Item("Amount Loan")) / 100
            Dim total_payments As Decimal = CDec(payment_dt.Rows(r).Item("Total Payment"))
            Dim start_date As Date = CDate(payment_dt.Rows(r).Item("Start Date"))
            Dim end_date As Date = CDate(payment_dt.Rows(r).Item("End Date"))
            Dim bal As Decimal = CDec(payment_dt.Rows(r).Item("balance"))

            overall_due = CalculateDue(start_date, to_date, daily)
            Dim collectibles As Decimal = 0
            Dim due_from_last_week As Decimal = 0

            cid = payment_dt.Rows(r).Item("clientid")
            lid = payment_dt.Rows(r).Item("loanid")
            'frmTestData.Add(cid & "-" & lid)

            For x As Integer = 0 To cols - 1
                'd &= payment_dt.Columns(x).ToString
                Try

                    Dim d As Date = CDate(payment_dt.Columns(x).ToString)
                    Dim p As New payment

                    'SET PROPERTY FOR DATA RETRIEVAL
                    p.clientid = cid
                    p.date_ = d

                    'IF header_date is equal to start_date
                    'SET has_start_date to true

                    If d = start_date Then
                        has_start_date = True
                    End If

                    'IF header_date is equal to end_date
                    'SET has_end_date to true
                    If d = end_date Then
                        has_end_date = True
                        ' frmTestData.Add(has_end_date.ToString)
                    End If

                    'GET THE AMOUNT PAID by the client for this date
                    amount = p.SELECT_BY_DATE_BY_CLIENTID

                    'SET the datatable's amount field to the amount that is retrieved from the database
                    payment_dt.Rows(r).Item(x) = amount

                    'increment the weekly_payment collection
                    weekly_total += amount

                    'START INCREMENTING DUE ONLY IF HEADER DATE IS
                    'GREATER THAN OR EQUAL TO THE LOAN'S START DATE
                    'AND LESS THAN OR EQUAL TO THE LOAN'S END_DATE

                    If d >= start_date And d <= end_date Then
                        weekly_due += daily
                    End If

                Catch ex As Exception
                    frmTestData.Add(ex.Message)
                End Try

                collectibles = weekly_due - weekly_total

                'if it is his first week then compute only based on the his overall due
                If has_start_date Then
                    weekly_due = overall_due
                    overdue = 0
                Else
                    Dim payment_from_previous_week As Decimal = 0
                    Dim collectibles_from_previous_week As Decimal = 0

                    Dim p As New payment
                    p.loanid = lid

                    payment_from_previous_week = p.SELECT_BETWDATE_BY_LOANID(start_date, DateAdd(DateInterval.Day, -1, from_date))

                    due_from_last_week = GET_DUE_FROM_LAST_WEEK(start_date, DateAdd(DateInterval.Day, -1, from_date), daily, end_date)
                    'TESTING DATA

                    'weekly_due = overall_due - payment_from_previous_week
                    overdue = due_from_last_week - payment_from_previous_week
                    'collectibles = (weekly_due - weekly_total) + overdue
                    'weekly_due = 
                End If
            Next

            If weekly_due >= bal Then
                payment_dt.Rows(r).Item("due") = bal
                payment_dt.Rows(r).Item("Collectibles") = bal
                ' frmTestData.Add(weekly_due)
            Else
                payment_dt.Rows(r).Item("due") = weekly_due

                'OVERDUE IS THE UNPAID AMOUNT FROM PREVIOUS WEEK
                'EXAMPLE: CLIENT'S DUE LAS WEEK IS: 700
                'CLIENT'S PAYMENT LAST WEEK IS: 600
                'THEN OVERDUE IS COMPUTED AS: 700-600=100
                'OVERDUE IS ONLY COMPUTED IF CLIENT FAILED TO PAY LAST WEEKS' TOTAL DUE
                If to_date > end_date Then
                    payment_dt.Rows(r).Item("overdue") = overdue
                    payment_dt.Rows(r).Item("Collectibles") = overdue
                Else
                    payment_dt.Rows(r).Item("overdue") = overdue
                    payment_dt.Rows(r).Item("Collectibles") = collectibles + overdue
                End If
               
            End If

            'payment_dt.Rows(r).Item("due") = weekly_due
            'payment_dt.Rows(r).Item("Collectibles") = collectibles
            payment_dt.Rows(r).Item("Week_Total") = weekly_total
            payment_dt.Rows(r).Item("daily") = daily
            payment_dt.Rows(r).Item("no") = cnt


            cnt += 1
            'frmTestData.Add(d)
        Next


        '====================================================
        'HIDE COLUMNS
        '====================================================
        dtg.Columns("clientid").Visible = False
        dtg.Columns("loanid").Visible = False

        '====================================================
        'RESIZE COLUMNS
        '====================================================
        dtg.Columns("name").Width = 180

        If CURRENT_RESTRICTION.CAN_SHOW_AMOUNT Then
            dtg.Columns("Amount Loan").Width = 150
        Else
            dtg.Columns("Amount Loan").Visible = False
        End If

        dtg.Columns("LC").Width = 40
        dtg.Columns("No").Width = 40
        '====================================================
        'RESIZE COLUMNS
        '====================================================
        Dim colstart As Integer = 4
       
        For y As Integer = colstart To dtg.Columns.Count - 1
            'Dim datecol As Date = CDate(dtg.Columns(y).HeaderText)
            If dtg.Columns(y).HeaderText <> "Start Date" And dtg.Columns(y).HeaderText <> "End Date" And dtg.Columns(y).HeaderText <> "LC" And dtg.Columns(y).HeaderText <> "Amount Loan" Then
                dtg.Columns(y).DefaultCellStyle.Format = "N2"
                dtg.Columns(y).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dtg.Columns(y).Width = 70
            End If
        Next

        dtg.Columns("Amount Loan").DefaultCellStyle.Format = "N2"
        dtg.Columns("Amount Loan").Width = 100
        dtg.Columns("Amount Loan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dtg.Columns("LC").Width = 30
        dtg.Columns("LC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dtg.Columns("Total Payment").Width = 100
        dtg.Columns("Total Payment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dtg.Columns("Balance").Width = 100
        dtg.Columns("Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dtg.Columns("Due").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dtg.Columns("Week_Total").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dtg.Columns("Collectibles").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        SetEditableColumns()

        dtg.Visible = True
        'frmTestData.Show()
        'frmBGW.Hide()
    End Sub

   

    Sub SetEditableColumns()

        For Each col As DataGridViewColumn In dtg.Columns
            col.ReadOnly = True

            If CURRENT_RESTRICTION.CAN_EDIT_PAYMENT Then
                Try
                    Dim d As Date = CDate(col.Name)
                    col.DefaultCellStyle.BackColor = Color.Gray
                    col.ReadOnly = False
                Catch ex As Exception
                    col.ReadOnly = True
                End Try
            Else
                col.ReadOnly = True
                'Try
                '    Dim d As Date = CDate(col.Name)
                '    If d = Now Then
                '        col.DefaultCellStyle.BackColor = Color.White
                '        col.ReadOnly = True
                '    Else
                '        col.DefaultCellStyle.BackColor = Color.Gray
                '        col.ReadOnly = False
                '    End If
                'Catch ex As Exception
                '    col.ReadOnly = True
                'End Try
            End If       
         
        Next

       
        If dtg.Rows.Count > 0 Then
            dtg.Rows(dtg.Rows.Count - 1).ReadOnly = True
        End If
    End Sub

    Private Sub dtg_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellEndEdit



        Dim iCol = dtg.CurrentCell.ColumnIndex
        Dim iRow = dtg.CurrentCell.RowIndex

        Try
            Dim d As Date = CDate(dtg.Columns(iCol).HeaderText)

            Dim clientid As Integer = CInt(dtg.Rows(iRow).Cells("clientid").Value)
            Dim loanid As Integer = CInt(dtg.Rows(iRow).Cells("loanid").Value)
            Dim start_date As Date = CDate(dtg.Rows(iRow).Cells("Start Date").Value)
            Dim end_date As Date = CDate(dtg.Rows(iRow).Cells("End Date").Value)
            Dim daily As Decimal = CDec(dtg.Rows(iRow).Cells("Daily").Value)
            Dim week_total As Decimal = CDec(dtg.Rows(iRow).Cells("Week_Total").Value)
            Dim total As Decimal = CDec(dtg.Rows(iRow).Cells("Total Payment").Value)

            ' MsgBox(clientid & "-" & loanid & "-" & d.ToShortDateString)
            Dim amount As Decimal

            Try
                amount = CDec(dtg.Rows(iRow).Cells(iCol).Value)
                'MsgBox(amount)
                Dim p As New payment
                p.clientid = clientid
                p.loanid = loanid
                p.amount = amount
                p.date_ = d



                If d >= start_date Then
                    If p.create Then
                        '=====================================
                        'THIS WILL UPDATE THE ROW FINANCIALS
                        'FEB 9, 2016---- UPDATEROW MODIFIED    
                        start_of_cutoff = DateAdd(DateInterval.Day, -1, start_of_cutoff)
                        UpdateRow(iRow, p.amount, p.loanid, p.date_, start_date, start_of_cutoff, daily, end_date)
                    Else
                        MsgBox("Error :" & err_global.Message)
                    End If
                Else
                    MsgBox("Warning : Payment should begin on Start Date : " & start_date.ToLongDateString)

                    If p.delete_bydate_byclientid Then
                        dtg.Rows(iRow).Cells(iCol).Value = 0.0
                        'MsgBox("Deleted By Client ID.")
                    Else
                        dtg.Rows(iRow).Cells(iCol).Value = 0.0
                        'MsgBox("Cant Delete By Client ID.")
                    End If

                End If
            Catch ex As Exception
                dtg.Rows(iRow).Cells(iCol).Value = 0.0
                MsgBox("Catch Error 1: " & ex.ToString())
            End Try
        Catch ex As Exception
            dtg.Rows(iRow).Cells(iCol).Value = 0.0
            MsgBox("Catch Error 2: " & ex.ToString())
        End Try

        btnprint.Text = "Refresh"
    End Sub

    Private Sub dtg_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtg.CellFormatting
        If My.Settings.APPLY_PAYMENT_FORMATTING = True Then
            Try
                If dtg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.0 Then
                    e.CellStyle.BackColor = Color.Red
                    e.CellStyle.ForeColor = Color.White
                Else
                    e.CellStyle.BackColor = Color.GreenYellow
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    '=====================================================================
    '=========== P A R A M E T E R     D E F I N I T I O N ===============
    '=====================================================================
    'idx= INDEX OF ROW TO BE UPDATED
    'amount= AMOUNT ENTERED ON THE CELL
    'lid= LOAN ID 
    'payment_date= DATE OF PAYMENT (HEADER OF CELL FROM THE DATAGRIDVIEW)
    'start_date= THE START_DATE FROM WHICH THE LOAN IS SET TO PAY
    'from_date=
    'THE START_DATE OF THE CURRENT CUTOFF
    'daily= THE DAILY PAYMENT FOR THE LOAN
    'end_date= THE 100 DAYS END_DATE OF THE LOAN

    Public Sub UpdateRow(ByVal idx As Integer, ByVal amount As Decimal, ByVal lid As Integer, ByVal payment_date As Date, ByVal start_date As Date, ByVal from_date As Date, ByVal daily As Decimal, ByVal end_date As Date)

        Dim row As New DataGridViewRow

        payment_dt.Rows(idx).Item("Week_Total") += amount
        payment_dt.Rows(idx).Item("Total Payment") += amount
        payment_dt.Rows(idx).Item("Collectibles") -= amount
        payment_dt.Rows(idx).Item("Balance") -= amount

        'CHECKIN BALANCE
        Dim l As New loan
        l.id = lid
        'GET THE BALANCE
        Dim bal As Decimal = l.GET_BALANCE
        Dim p As New payment
        p.loanid = lid

        If bal <= 0 Then
            If l.SET_TO_FULLY_PAID(payment_date) Then
                MsgBox("This Loan is already paid in full.", MsgBoxStyle.Information, "Fully Paid")
            Else
                MsgBox("Error: " & err_global.Message, MsgBoxStyle.Exclamation, "Fully Paid")
            End If
        End If

        ComputeSUbTotal()
    End Sub


    Public Sub ZERO_IN_NEGATIVE_OVERDUE()

        For Each item As DataRow In payment_dt.Rows
            Try
                Dim overdue As Decimal = CDec(item("overdue"))
                If overdue < 0 Then
                    item("overdue") = 0.0
                End If
            Catch ex As Exception
                item("overdue") = 0.0
            End Try

        Next
        dtg.DataSource = payment_dt
        dtg.Refresh()

    End Sub

    Public Sub ComputeSUbTotal()

        If CURRENT_RESTRICTION.CAN_SHOW_SUBTOTAL Then

       

        Dim monthNumber = DateTime.ParseExact(month_, "MMMM", CultureInfo.CurrentCulture).Month

        Dim from_day As Integer = Split(cutoff, "-")(0)
        Dim to_day As Integer = Split(cutoff, "-")(1)
        Dim from_date As Date = CDate(monthNumber & "-" & from_day & "-" & Year(Now))
        Dim to_date As Date = CDate(monthNumber & "-" & to_day & "-" & Year(Now))
        Dim nofdays As Integer = DateDiff(DateInterval.Day, from_date, to_date)

        Dim lc_total As Decimal = 0
        Dim week_total_subtotal As Decimal = 0
        Dim collectibles_total As Decimal = 0
        Dim due_total As Decimal = 0
        Dim total_payments_total As Decimal = 0
        Dim balance_total As Decimal = 0
        Dim amount_loan_total As Decimal = 0
        Dim daily_total As Decimal = 0
        Dim payment_subtotal(nofdays) As Decimal


        Dim noofday As Integer = 0
        Dim date_field As Integer = 0

        'LOOP THROUGH ROWS
        For x As Integer = 0 To payment_dt.Rows.Count - 2
            date_field = 0
            Dim r As DataRow
            r = payment_dt.Rows(x)

            amount_loan_total += r.Item("Amount Loan")
            lc_total += r.Item("LC")
            week_total_subtotal += r.Item("week_total")
            collectibles_total += r.Item("collectibles")
            due_total += r.Item("due")
            total_payments_total += r.Item("Total Payment")
            balance_total += r.Item("balance")
            daily_total += r.Item("daily")


            For col As Integer = 0 To payment_dt.Columns.Count - 1
                Try
                    Dim d As Date = CDate(payment_dt.Columns(col).ColumnName)
                    Dim date_str As String = CStr(Format(d, "MM/dd/yy"))
                    ' frmTestData.Add(date_str & "-" & date_field)

                    payment_subtotal(date_field) += r.Item(date_str)
                    date_field += 1

                Catch ex As Exception

                End Try
            Next


        Next

        payment_dt.Rows(payment_dt.Rows.Count - 1).Item("Name") = ""
        payment_dt.Rows(payment_dt.Rows.Count - 1).Item("Amount Loan") = amount_loan_total
        payment_dt.Rows(payment_dt.Rows.Count - 1).Item("LC") = lc_total
        payment_dt.Rows(payment_dt.Rows.Count - 1).Item("week_total") = week_total_subtotal
        payment_dt.Rows(payment_dt.Rows.Count - 1).Item("collectibles") = collectibles_total
        payment_dt.Rows(payment_dt.Rows.Count - 1).Item("due") = due_total
        payment_dt.Rows(payment_dt.Rows.Count - 1).Item("Total Payment") = total_payments_total
        payment_dt.Rows(payment_dt.Rows.Count - 1).Item("balance") = balance_total
        payment_dt.Rows(payment_dt.Rows.Count - 1).Item("daily") = daily_total

        For y As Integer = 0 To nofdays
            Dim colString As String = CStr(Format(from_date.AddDays(y), "MM/dd/yy"))
            payment_dt.Rows(payment_dt.Rows.Count - 1).Item(CStr(Format(from_date.AddDays(y), "MM/dd/yy"))) = payment_subtotal(y)
        Next

        Else
            Exit Sub
        End If
        ' frmTestData.Show()


        ZERO_IN_NEGATIVE_OVERDUE()
    End Sub
    Private Sub dtg_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dtg.DataError
        'MsgBox("Error :" & e.Exception.Message)
        dtg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.0

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click

        If btnprint.Text = "Refresh" Then
            If cutoff <> "" And area <> "" Then
                GeneratePaymentEntry(cutoff, area)
                btnprint.Text = "Print"
            Else
                MsgBox("Please supply Cutoff and Area")
            End If
        Else



            Dim appXL As excel.Application
            Dim wbXl As excel.Workbook
            Dim shXL As excel.Worksheet

            'Dim raXL As excel.Range
            ' Start Excel and get Application object.
            appXL = CreateObject("Excel.Application")
            'appXL.Visible = True
            ' Add a new workbook.
            wbXl = appXL.Workbooks.Add()

            shXL = wbXl.ActiveSheet
            'Add table headers going cell by cell.

            shXL.PageSetup.Orientation = excel.XlPageOrientation.xlLandscape
            shXL.PageSetup.PaperSize = excel.XlPaperSize.xlPaperLegal
            shXL.PageSetup.BottomMargin = 0.3
            shXL.PageSetup.TopMargin = 0.3
            shXL.PageSetup.LeftMargin = 0.3
            shXL.PageSetup.RightMargin = 0.3


            Dim formatRange As excel.Range = shXL.UsedRange
            Dim dcol As Integer = 0


            For col As Integer = 0 To payment_dt.Columns.Count - 1



                If payment_dt.Columns(col).ColumnName.ToString = "Amount Loan" Then
                    If Not CURRENT_RESTRICTION.CAN_SHOW_AMOUNT Then
                        Continue For
                    End If
                End If


                shXL.Cells(1, dcol + 1).Value = payment_dt.Columns(col).ColumnName.ToString
                Dim cell As excel.Range = formatRange.Cells(1, dcol + 1)
                cell.Font.Bold = True
                cell.Font.Size = 8
                cell.WrapText = True
                cell.Interior.Color = Color.LightBlue
                '            cell.Interiorterior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
                cell.HorizontalAlignment = 3
                Dim border As excel.Borders = cell.Borders
                border.LineStyle = excel.XlLineStyle.xlContinuous
                border.Weight = 2.0
                dcol += 1
            Next

            '================================================
            'FETCH DAta FROM DATATABLE

            Dim myRow As DataRow
            Dim colindex As Integer = 0
            Dim rowIndex As Integer = 1


            Dim l As Integer = payment_dt.Rows.Count - 1
            Dim last As Integer = 0

            For Each myRow In payment_dt.Rows

                If Not CURRENT_RESTRICTION.CAN_SHOW_SUBTOTAL Then
                    If last = l Then Exit For
                End If


                rowIndex += 1
                colindex = 0
                Dim myColumn2 As DataColumn

                Dim dcol2 As Integer = 1
                For Each myColumn2 In payment_dt.Columns
                    colindex += 1

                    If Not CURRENT_RESTRICTION.CAN_SHOW_AMOUNT Then
                        If myColumn2.ColumnName = "Amount Loan" Then Continue For
                    End If

                    shXL.Cells(rowIndex, dcol2) = myRow(myColumn2.ColumnName)
                    Dim cell As excel.Range = formatRange.Cells(rowIndex, dcol2)
                    Dim border As excel.Borders = cell.Borders
                    cell.Font.Size = 8

                    If myColumn2.ColumnName = "Start Date" Or myColumn2.ColumnName = "End Date" Then
                        cell.NumberFormat = "MM/dd/yyyy"
                    ElseIf myColumn2.ColumnName = "No" Or myColumn2.ColumnName = "LC" Then
                        cell.NumberFormat = "###0"
                    Else
                        cell.NumberFormat = "#,##0.00"
                    End If

                    border.LineStyle = excel.XlLineStyle.xlContinuous
                    border.Weight = 2.0

                    dcol2 += 1
                Next (myColumn2)

                last += 1



            Next myRow

            With shXL
                .Columns("A:Z").EntireColumn.AutoFit()
                .Columns("A:B").EntireColumn.Hidden = True
                '.Protect(My.Settings.APP_PASSWORD)
            End With


            appXL.Visible = True

            appXL.DisplayAlerts = False
            ' wbXl.SaveAs(Application.StartupPath & "\" & Month(Now).ToString & "-" & cutoff & "-" & Hour(Now) & "-" & Minute(Now) & ".xls", excel.XlFileFormat.xlWorkbookNormal)


            ' Make sure Excel is visible and give the user control
            ' of Excel's lifetime.
            appXL.Visible = True
            appXL.UserControl = True

            'Release object references.
            'raXL = Nothing
            'shXL = Nothing
            'wbXl = Nothing
            'appXL.Quit()
            'appXL = Nothing

            Exit Sub

Err_Handler:
            MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)
        End If

    End Sub
    Sub ApplyRestictions()

    End Sub

  

End Class
