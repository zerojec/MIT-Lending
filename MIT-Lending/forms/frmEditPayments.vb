Public Class frmEditPayments

    Public p As New payment

    Private Sub frmEditPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Edit Payment : Trace No# " & p.id

        LoadCollectors()

        Dim c, cli As New client
        cli.id = p.clientid
        c = cli.SELECT_BY_ID()

        txtname.Text = c.lname & ", " & c.fname
        txtamount.Text = Format(p.amount, "#,##0.00")
        txtornumber.Text = p.ornumber


        Dim emp, emplo As New emp
        emplo.id = p.collectorid
        emp = emplo.SELECT_BY_ID

        cbocollector.Text = emp.id & "-" & emp.lname & ", " & emp.fname

        dtpaymentdate.Value = p.date_


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
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

    Private Sub cbocollector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbocollector.KeyPress
        e.Handled = True
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
                If txtornumber.Text.Contains(".") Then
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

    Private Sub txtamount_Leave(sender As Object, e As EventArgs) Handles txtamount.Leave
        txtamount.Text = Format(CDec(txtamount.Text), "#,##0.00")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        p.amount = CDec(txtamount.Text)
        p.ornumber = txtornumber.Text
        p.collectorid = Split(cbocollector.Text, "-")(0)
        p.date_ = dtpaymentdate.Value

        If p.update Then
            MsgBox("Success", MsgBoxStyle.Information, "Update")
            frmMain.btnPayments.PerformClick()
            Me.Dispose()
        Else
            MsgBox("Failed :" & err_global.Message, MsgBoxStyle.Information, "Update")
        End If


    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        e.Handled = True
    End Sub
End Class