Public Class emp_ca_monitor

    Public ca_emp As emp
    Public balance As Decimal
    Public amount As Decimal
    Public ca_id As Decimal
    Private Sub emp_ca_monitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblca.Text &= " : " & ca_emp.lname.ToUpper & ", " & ca_emp.fname.ToUpper & " [P" & amount.ToString("#,##0.00") & "]"
        txtbalance.Text = balance.ToString("#,##0.00")

        LoadPaymentsForCashAdvance()

    End Sub

    Public Sub LoadPaymentsForCashAdvance()
        Dim cap, tmp As New cash_advance_payment
        tmp.cashadvance_id = CInt(ca_id)

        Dim dt As New DataTable
        dt = tmp.SELECT_BY_CA_ID

        If dt IsNot Nothing Then

            Dim totalpayment As Decimal = 0

            For x As Integer = 0 To dt.Rows.Count - 1

                Dim r As DataRow = dt.Rows(x)

                Dim li As New ListViewItem
                li.Text = x + 1
                li.Tag = r("id").ToString()
                li.SubItems.Add(CDate(r("date_").ToString()).ToShortDateString())
                li.SubItems.Add(CDec(r("amount").ToString()).ToString("#,##0.00"))

                totalpayment += CDec(r("amount").ToString())

                lv.Items.Add(li)

            Next

            Dim liline As New ListViewItem
            liline.Text = "====="
            liline.Tag = "LINE"

            liline.SubItems.Add("===========")
            liline.SubItems.Add("===========")
            lv.Items.Add(liline)

            Dim litotal As New ListViewItem
            litotal.Text = ""
            litotal.Tag = "TOTAL"
            litotal.SubItems.Add("TOTAL : ")
            litotal.SubItems.Add(totalpayment.ToString("#,##0.00"))
            lv.Items.Add(litotal)

        Else
            MsgBox("Nothing found...")
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ca_payment As New cash_advance_payment
        ca_payment.cashadvance_id = CInt(ca_id)
        ca_payment.amount = CDec(txtamount.Text)
        ca_payment.empid = ca_emp.id

        If ca_payment.save() Then
            MsgBox("Success", MsgBoxStyle.Information, "Saving Cash Advance Payment")
            Me.Parent.Height = 0
            Me.Dispose()
        Else
            MsgBox("Failed:" & err_global.Message, MsgBoxStyle.Information, "Saving Cash Advance Payment")
            Me.Parent.Height = 0
            Me.Dispose()
        End If

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click


        If lv.SelectedItems.Count > 0 Then
            Dim sel As ListViewItem
            sel = lv.SelectedItems(0)

            ' MsgBox(sel.Tag)
            If sel.Tag = "LINE" Or sel.Tag = "TOTAL" Then Exit Sub

            Dim cap, cap2 As New cash_advance_payment
            cap2.id = sel.Tag
            cap = cap2.SELECT_BYID

            If cap IsNot Nothing Then

                'prompt before deleting
                If MessageBox.Show("Please confirm delete cash advance-payment amounting: P" & cap.amount & " dated: " & cap.date_ & " from employee id: " & cap.empid & "?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    If cap.delete() Then
                        MessageBox.Show("Successful", "Deleting of Cash Advance Payment")
                    Else
                        MessageBox.Show("Failed :" & err_global.Message, "Deleting of Cash Advance Payment")
                    End If
                    Me.Parent.Height = 0
                    Me.Dispose()
                End If
            Else
                MessageBox.Show("Error :" & err_global.Message)
            End If

        End If
       
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Parent.Height = 0
        Me.Dispose()
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
End Class
