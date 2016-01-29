Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class payments_uc

    Private Sub payments_uc_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LoadPayments()
        'lblSelect.Text = "Select Cutoff : " & MonthName(Now.Month)
       
    End Sub


    Sub LoadCutOffs(ByVal month_ As String)

        cbocutoff.Items.Clear()

        Dim monthNumber = DateTime.ParseExact(month_, "MMMM", CultureInfo.CurrentCulture).Month
        For x As Integer = 0 To cuttoff_date.Count - 1
            cbocutoff.Items.Add(cuttoff_date(x))
        Next
        Dim str As String = "24-" & CStr(GetLastDayOfMonth(monthNumber, Year(Now)).Day)
        cbocutoff.Items.Add(str)
        cbocutoff.Enabled = True


    End Sub


    Sub LoadPayments()
        Dim dt As New DataTable
        Dim p As New payment

        dt = p.SELECT_ALL

        lv.Items.Clear()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim c As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim li As New ListViewItem
                    li.Tag = r.Item("id") & "-" & r.Item("loanid")
                    li.Text = r.Item("id")
                    li.SubItems.Add(r.Item("fullname"))
                    li.SubItems.Add(Format(r.Item("amount"), "#,##0.00"))
                    'li.SubItems.Add(r.Item("ornumber"))
                    li.SubItems.Add(r.Item("date_"))
                    'li.SubItems.Add(r.Item("collector"))
                    lv.Items.Add(li)
                Next
            End If
        End If
    End Sub



    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        If cboarea.Text = "" Or cbocutoff.Text = "" Or cbomonths.Text = "" Then Exit Sub

        btnNew.Visible = False
        Dim a As New cutoff_payment_entry_uc
        a.cutoff = cbocutoff.Text
        a.area = cboarea.Text
        a.month_ = cbomonths.Text

        a.Height = Me.Height - 55
        a.Width = Me.Width
        a.Dock = DockStyle.Fill
        pnlops.Height = a.Height
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
        btnNew.Visible = True
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If lv.SelectedItems.Count > 0 Then


            Dim id As Integer = CInt(Split(lv.SelectedItems(0).Tag.ToString(), "-")(0))

            Dim lid As Integer = CInt(Split(lv.SelectedItems(0).Tag.ToString(), "-")(1))

            Dim p, p2 As New payment
            p2.id = id
            p = p2.SELECT_BY_ID



            p.amount = CDec(lv.SelectedItems(0).SubItems(2).Text)

            If MsgBox("Delete payment of " & vbCrLf & "Name : " & lv.SelectedItems(0).SubItems(1).Text & vbCrLf & "Worth : " & lv.SelectedItems(0).SubItems(2).Text & vbCrLf & "Dated : " & lv.SelectedItems(0).SubItems(3).Text & vbCrLf & vbCrLf & "Are you sure?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
                If p.delete Then
                    Dim l As New loan
                    l.id = lid
                    l.UNSET_TO_FULLY_PAID(Now)

                    MsgBox("Success", MsgBoxStyle.Information, "Delete")
                Else
                    MsgBox("Failed:" & err_global.Message, MsgBoxStyle.Information, "Delete")
                End If
            End If
            frmMain.btnPayments.PerformClick()
        End If
    End Sub

    Sub LoadPaymentsByName(ByVal thisname As String)
        Dim dt As New DataTable
        Dim p As New payment
        dt = p.SELECT_BY_NAME(thisname)

        lv.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim li As New ListViewItem
                    'li.Text = x
                    li.Tag = r.Item("id") & "-" & r.Item("loanid")
                    li.Text = r.Item("id")
                    li.SubItems.Add(r.Item("fullname"))
                    li.SubItems.Add(Format(r.Item("amount"), "#,##0.00"))
                    '  li.SubItems.Add(r.Item("ornumber"))
                    li.SubItems.Add(r.Item("date_"))
                    'li.SubItems.Add(r.Item("collector"))
                    lv.Items.Add(li)
                    x += 1
                Next
            End If
        Else

        End If

    End Sub


    Sub LoadAreas()
        Dim dt As New DataTable
        Dim a As New area
        dt = a.SELECT_ALL
        cboarea.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                For Each r As DataRow In dt.Rows
                    Dim ar As String = r.Item("areaid")
                    cboarea.Items.Add(ar)
                Next
            End If
        End If

        Dim all As String = "All Areas"
        cboarea.Items.Add(all)
    End Sub

    Private Sub cbomonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomonths.SelectedIndexChanged
        cbocutoff.Text = ""
        If cbomonths.Text <> "" Then
            LoadCutOffs(cbomonths.Text)
        End If

        cbocutoff.Text = cbocutoff.Items(0).ToString
    End Sub

    Private Sub cbocutoff_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbocutoff.KeyPress
        e.Handled = True
    End Sub
    Private Sub cboarea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboarea.KeyPress
        e.Handled = True
    End Sub

  
    Private Sub txtSearchBox_Click(sender As Object, e As EventArgs) Handles txtSearchBox.Click
        pnlops.Controls.Clear()
        pnlops.Height = 0
    End Sub

   
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged

    End Sub

    Private Sub txtSearchBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBox.KeyPress

        Dim n As String = txtSearchBox.Text
        LoadPaymentsByName(n)
       
    End Sub

    Sub ApplyRestrictions()
        If Not CURRENT_RESTRICTION.CAN_SEARCH_PAYMENT Then
            pnlsearch.Visible = False
        Else
            pnlsearch.Visible = True
        End If

        If Not CURRENT_RESTRICTION.CAN_DELETE_PAYMENT Then
            DeleteToolStripMenuItem.Enabled = False
        Else
            DeleteToolStripMenuItem.Enabled = True
        End If

        If Not CURRENT_RESTRICTION.CAN_GENERATE_PAYMENT_ENTRY Then
            pnlview.Visible = False
            btnNew.Visible = False
        Else
            pnlview.Visible = True
            btnNew.Visible = True
        End If

        If CURRENT_RESTRICTION.CAN_VIEW_PAYMENT Then
            lv.Visible = True
        Else
            lv.Visible = False
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        LoadAreas()
        cboarea.Text = cboarea.Items(0).ToString
        cbomonths.Text = cbomonths.Items(5).ToString

        LoadPayments()

        ApplyRestrictions()

        Timer1.Enabled = False
    End Sub
End Class
