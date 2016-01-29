Imports MySql.Data.MySqlClient
Public Class loans_uc

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim a As New new_loan_uc
        a.Dock = DockStyle.Fill
        pnlops.Height = a.Height
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub

    Private Sub loans_uc_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True

    End Sub


    Sub LoadLoans()
        Dim dt As New DataTable
        Dim l As New loan
        dt = l.SELECT_ALL

        lv.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then

                Dim c As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim li As New ListViewItem
                    li.Text = c

                    Dim loan_amount As Decimal = r.Item("loan_amount")
                    Dim total_payment As Decimal = r.Item("payment_sum")
                    Dim balance As Decimal = r.Item("balance")
                    Dim percentage As Decimal

                    'li.SubItems.Add(r.Item("id"))
                    li.SubItems.Add(r.Item("fullname"))
                    li.SubItems.Add(r.Item("date_released"))
                    li.SubItems.Add(r.Item("start_of_payment"))
                    li.SubItems.Add(r.Item("end_of_payment"))
                    li.SubItems.Add(Format(loan_amount, "#,##0.00"))
                    li.SubItems.Add(r.Item("comaker"))

                    percentage = total_payment / loan_amount

                    li.SubItems.Add(Format(total_payment, "#,##0.00") & "@" & Format(percentage, "0.00%"))
                    li.SubItems.Add(Format(balance, "#,##0.00"))

                    li.Tag = r.Item("loanid")
                    lv.Items.Add(li)

                    c += 1
                Next
            End If
        End If

    End Sub

    Sub LoadActiveLoans()
        Dim dt As New DataTable
        Dim l As New loan
        dt = l.SELECT_ACTIVE

        lv.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then

                Dim c As Integer = 1
                For Each r As DataRow In dt.Rows

                    Dim loan_amount As Decimal = r.Item("loan_amount")
                    Dim total_payment As Decimal = r.Item("payment_sum")
                    Dim balance As Decimal = r.Item("balance")
                    Dim percentage As Decimal

                    Dim li As New ListViewItem

                    li.Text = c

                    


                    If balance = 0 Then
                        Dim active_loan As New loan
                        active_loan.id = r.Item("loanid")
                        active_loan.UNSET_TO_FULLY_PAID(Now)
                    Else
                        'li.SubItems.Add(r.Item("id"))
                        li.SubItems.Add(r.Item("fullname"))
                        li.SubItems.Add(r.Item("date_released"))
                        li.SubItems.Add(r.Item("start_of_payment"))
                        li.SubItems.Add(r.Item("end_of_payment"))
                        li.SubItems.Add(Format(loan_amount, "#,##0.00"))
                        li.SubItems.Add(r.Item("comaker"))

                        percentage = total_payment / loan_amount

                        li.SubItems.Add(Format(total_payment, "#,##0.00") & "@" & Format(percentage, "0.00%"))
                        li.SubItems.Add(Format(balance, "#,##0.00"))

                        li.Tag = r.Item("loanid")

                        lv.Items.Add(li)

                        c += 1
                    End If


                   
                Next

            End If
        End If

    End Sub

    Sub LoadLoansByName(ByVal thisname As String)
        Dim dt As New DataTable
        Dim l As New loan
        dt = l.SELECT_BY_NAME(thisname)

        lv.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then

                Dim c As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim li As New ListViewItem
                    li.Text = c

                    Dim loan_amount As Decimal = r.Item("loan_amount")
                    Dim total_payment As Decimal = r.Item("payment_sum")
                    Dim balance As Decimal = r.Item("balance")
                    Dim percentage As Decimal

                    'li.SubItems.Add(r.Item("id"))
                    li.SubItems.Add(r.Item("fullname"))
                    li.SubItems.Add(r.Item("date_released"))
                    li.SubItems.Add(r.Item("start_of_payment"))
                    li.SubItems.Add(r.Item("end_of_payment"))
                    li.SubItems.Add(Format(loan_amount, "#,##0.00"))
                    li.SubItems.Add(r.Item("comaker"))

                    percentage = total_payment / loan_amount

                    li.SubItems.Add(Format(total_payment, "#,##0.00") & "@" & Format(percentage, "0.00%"))
                    li.SubItems.Add(Format(balance, "#,##0.00"))

                    li.Tag = r.Item("loanid")
                    lv.Items.Add(li)

                    c += 1
                Next
            End If
        End If

    End Sub

    Sub LoadActiveLoansByName(ByVal thisname As String)
        Dim dt As New DataTable
        Dim l As New loan
        dt = l.SELECT_ACTIVE_BY_NAME(thisname)

        lv.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then

                Dim c As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim li As New ListViewItem

                    li.Text = c

                    Dim loan_amount As Decimal = r.Item("loan_amount")
                    Dim total_payment As Decimal = r.Item("payment_sum")
                    Dim balance As Decimal = r.Item("balance")
                    Dim percentage As Decimal

                    'li.SubItems.Add(r.Item("id"))
                    li.SubItems.Add(r.Item("fullname"))
                    li.SubItems.Add(r.Item("date_released"))
                    li.SubItems.Add(r.Item("start_of_payment"))
                    li.SubItems.Add(r.Item("end_of_payment"))
                    li.SubItems.Add(Format(loan_amount, "#,##0.00"))
                    li.SubItems.Add(r.Item("comaker"))

                    percentage = total_payment / loan_amount

                    li.SubItems.Add(Format(total_payment, "#,##0.00") & "@" & Format(percentage, "0.00%"))
                    li.SubItems.Add(Format(balance, "#,##0.00"))

                    li.Tag = r.Item("loanid")
                    lv.Items.Add(li)

                    c += 1
                Next
            End If
        End If

    End Sub



    Private Sub txtSearchBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBox.KeyPress
        Dim n As String = txtSearchBox.Text

        If chkActive.Checked Then
            LoadActiveLoansByName(n)
        Else
            LoadLoansByName(n)
        End If

    End Sub

    Private Sub chkActive_CheckedChanged(sender As Object, e As EventArgs) Handles chkActive.CheckedChanged

        Dim n As String = txtSearchBox.Text
        If n = "" Then
            If chkActive.Checked Then
                LoadActiveLoans()
            Else
                LoadLoans()
            End If
        Else
            If chkActive.Checked Then
                LoadActiveLoansByName(n)
            Else
                LoadLoansByName(n)
            End If
        End If

        
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If lv.SelectedItems.Count > 0 Then

            'Dim l, l1 As New loan
            'l1.id = lv.SelectedItems(0).Tag
            'l = l1.SELECT_BY_ID
            '    Dim edit_uc As New edit_loan_uc
            '    edit_uc.Dock = DockStyle.Fill
            '    edit_uc.edit_object = l
            '    'MsgBox(l.loan_amount)
            '    pnlops.Controls.Clear()
            '    pnlops.Height = edit_uc.Height
            '    pnlops.Controls.Add(edit_uc)         
        End If
    End Sub

    Private Sub CreatePaymentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If lv.SelectedItems.Count > 0 Then

            Dim l, l1 As New loan
            l1.id = lv.SelectedItems(0).Tag
            l = l1.SELECT_BY_ID

            Dim c, c1 As New client
            c1.id = l.clientid
            c = c1.SELECT_BY_ID

            Dim payment_uc As New new_payment_uc
            payment_uc.Dock = DockStyle.Fill
            payment_uc.c = New client
            payment_uc.c = c
            payment_uc.Label1.Text = "NEW PAYMENT ENTRY FOR  :  " & UCase(c.fname) & " " & UCase(c.mname) & " " & UCase(c.lname)

            'MsgBox(l.loan_amount)
            pnlops.Controls.Clear()
            pnlops.Height = payment_uc.Height

            pnlops.Controls.Add(payment_uc)

        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If lv.SelectedItems.Count > 0 Then

            Dim l, l1 As New loan
            l1.id = lv.SelectedItems(0).Tag
            l = l1.SELECT_BY_ID

            If MsgBox("WARNING : Are you sure you want to delete this permanentyly?" & vbCrLf & "All payments associated with this loan will also be deleted and this action is IRREVERSIBLE. Please Confirm.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm Delete") = MsgBoxResult.Yes Then
                If l.delete Then

                    Dim p As New payment
                    p.loanid = l.id

                    If p.DELETE_ALL_PAYMENT_BY_LOANID Then
                        MsgBox("This loan and all payments associated with it is now deleted.", MsgBoxStyle.Information, "Delete")
                        frmMain.btnLoans.PerformClick()
                    Else
                        MsgBox("Failed:" & err_global.Message, MsgBoxStyle.Information, "Delete Payment")
                    End If
                Else
                    MsgBox("Failed:" & err_global.Message, MsgBoxStyle.Information, "Delete Loan")
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Sub ApplyRestrictions()

        If CURRENT_RESTRICTION.CAN_EDIT_LOAN Then
            EditToolStripMenuItem.Enabled = True
        Else
            EditToolStripMenuItem.Enabled = False
        End If

        If CURRENT_RESTRICTION.CAN_DELETE_LOAN Then
            DeleteToolStripMenuItem.Enabled = True
        Else
            DeleteToolStripMenuItem.Enabled = False
        End If

        If CURRENT_RESTRICTION.CAN_ADD_LOAN Then
            btnNew.Visible = True
        Else
            btnNew.Visible = False
        End If

        If CURRENT_RESTRICTION.CAN_SEARCH_LOAN Then
            pnlSearch.Visible = True
        Else
            pnlSearch.Visible = False
        End If

        If CURRENT_RESTRICTION.CAN_VIEW_LOAN Then
            lv.Visible = True
        Else
            lv.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If chkActive.Checked Then
            LoadActiveLoans()
        Else
            LoadLoans()
        End If

        ApplyRestrictions()
        Timer1.Enabled = False

    End Sub
End Class
