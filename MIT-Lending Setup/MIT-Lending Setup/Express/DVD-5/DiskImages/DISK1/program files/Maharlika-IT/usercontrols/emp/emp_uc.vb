Public Class emp_uc

    
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim a As New new_emp_uc
        a.Dock = DockStyle.Fill
        pnlops.Height = a.Height
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub

    Private Sub emp_uc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        ApplyRestrictions()
    End Sub



    Sub LoadEmp()
        Dim dt As New DataTable
        Dim em As New emp
        dt = em.SELECT_ALL

        lv.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim li As New ListViewItem
                    li.Text = x
                    li.SubItems.Add(r.Item("lname") & ", " & r.Item("fname"))
                    li.SubItems.Add(r.Item("position"))
                    li.SubItems.Add(r.Item("contactno"))
                    li.SubItems.Add(r.Item("areaid"))
                    li.Tag = r.Item("id")
                    lv.Items.Add(li)
                    x += 1
                Next
            End If
        Else

        End If

    End Sub

    Sub LoadEmpByName(ByVal thisname As String)
        Dim dt As New DataTable
        Dim em As New emp
        dt = em.SELECT_BY_NAME(thisname)

        lv.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim li As New ListViewItem
                    li.Text = x
                    li.SubItems.Add(r.Item("lname") & ", " & r.Item("fname"))
                    li.SubItems.Add(r.Item("position"))
                    li.SubItems.Add(r.Item("contactno"))
                    li.SubItems.Add(r.Item("areaid"))
                    li.Tag = r.Item("id")
                    lv.Items.Add(li)
                    x += 1
                Next
            End If
        Else

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadEmp()
        Timer1.Enabled = False
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If lv.SelectedItems.Count > 0 Then
            Dim empid As Integer = lv.SelectedItems(0).Tag
            Dim a, b As New emp
            b.id = empid
            a = b.SELECT_BY_ID()

            Dim edit_uc As New edit_emp_uc
            edit_uc.Dock = DockStyle.Fill
            edit_uc.edit_emp = a

            pnlops.Controls.Clear()
            pnlops.Height = edit_uc.Height

            pnlops.Controls.Add(edit_uc)


        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If lv.SelectedItems.Count > 0 Then
            Dim empid As Integer = lv.SelectedItems(0).Tag
            Dim a, b As New emp
            b.id = empid
            a = b.SELECT_BY_ID()

            If MsgBox("Please confirm delete.", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then

                If a.delete Then
                    MsgBox("Success", MsgBoxStyle.Information, "Delete")
                Else
                    MsgBox("Failed: " & err_global.Message, MsgBoxStyle.Information, "Delete")
                End If
            End If

            LoadEmp()

        End If
    End Sub

    Private Sub txtSearchBox_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchBox.KeyUp

        Dim n As String = txtSearchBox.Text

        LoadEmpByName(n)

    End Sub


    Sub ApplyRestrictions()
        If CURRENT_RESTRICTION.CAN_ADD_EMP Then
            btnNew.Visible = True
        Else
            btnNew.Visible = False
        End If

        If CURRENT_RESTRICTION.CAN_SEARCH_EMP Then
            pnlSearch.Visible = True
        Else
            pnlSearch.Visible = False
        End If

        If CURRENT_RESTRICTION.CAN_EDIT_EMP Then
            EditToolStripMenuItem.Enabled = True
        Else
            EditToolStripMenuItem.Enabled = False
        End If

        If CURRENT_RESTRICTION.CAN_DELETE_EMP Then
            DeleteToolStripMenuItem.Enabled = True
        Else
            DeleteToolStripMenuItem.Enabled = False
        End If

        If CURRENT_RESTRICTION.CAN_VIEW_EMP Then
            lv.Visible = True
        Else
            lv.Visible = False
        End If
    End Sub

   
    Private Sub CashAdvanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashAdvanceToolStripMenuItem.Click
        If lv.SelectedItems.Count > 0 Then
            Dim empid As Integer = lv.SelectedItems(0).Tag
            Dim a, b As New emp
            b.id = empid
            a = b.SELECT_BY_ID()

            Dim ca As New emp_ca
            ca.Dock = DockStyle.Fill
            ca.ca_emp = a


            Dim cap As New emp_ca_monitor
            cap.Dock = DockStyle.Fill
            cap.ca_emp = a

            Dim cash_adv As New cash_advance
            cash_adv.empid = empid


            'ca_data(0)= cash_advance_amount
            'ca_data(1)= cash_advance_balance
            pnlops.Controls.Clear()
            pnlops.Height = ca.Height
            Try
                Dim ca_data() As Decimal = cash_adv.CHECK_BALANCE_BYEMPID

                Dim amount As Decimal = ca_data(0)
                Dim bal As Decimal = ca_data(1)
                Dim ca_id As Decimal = ca_data(2)

                If bal > 0 Then
                    cap.balance = bal
                    cap.amount = amount
                    cap.ca_id = ca_id

                    pnlops.Controls.Add(cap)
                Else
                    pnlops.Controls.Add(ca)
                End If
            Catch ex As Exception
                pnlops.Controls.Add(ca)
            End Try         

        End If
    End Sub



End Class

