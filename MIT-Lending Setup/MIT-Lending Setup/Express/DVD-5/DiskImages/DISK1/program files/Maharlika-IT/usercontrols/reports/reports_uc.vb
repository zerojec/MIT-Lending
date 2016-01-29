Public Class reports_uc

    Private Sub btnPaymentSummary_Click(sender As Object, e As EventArgs) Handles btnPaymentSummary.Click
        Dim a As New payment_report_uc
        a.Dock = DockStyle.Fill
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub

    Private Sub btnPerClient_Click(sender As Object, e As EventArgs) Handles btnPerClient.Click
        Dim a As New client_report_uc
        a.Dock = DockStyle.Fill
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub

    Private Sub btnCollectors_Click(sender As Object, e As EventArgs)
        Dim a As New collector_report_uc
        a.Dock = DockStyle.Fill
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub

    Private Sub btnBalanceList_Click(sender As Object, e As EventArgs) Handles btnBalanceList.Click
        Dim a As New client_balance_report_uc
        a.Dock = DockStyle.Fill
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub

    Private Sub reports_uc_Load(sender As Object, e As EventArgs) Handles Me.Load
        ApplyRestrictions()
    End Sub

    Sub ApplyRestrictions()
        If CURRENT_RESTRICTION.CAN_ACCESS_PAYMENT_REPORT Then
            btnPaymentSummary.Visible = True
        Else
            btnPaymentSummary.Visible = False
        End If

        If CURRENT_RESTRICTION.CAN_ACCESS_CLIENT_REPORT Then
            btnPerClient.Visible = True
        Else
            btnPerClient.Visible = False
        End If

        If CURRENT_RESTRICTION.CAN_ACCESS_BALANCE_REPORT Then
            btnBalanceList.Visible = True
        Else
            btnBalanceList.Visible = False
        End If
    End Sub
End Class
