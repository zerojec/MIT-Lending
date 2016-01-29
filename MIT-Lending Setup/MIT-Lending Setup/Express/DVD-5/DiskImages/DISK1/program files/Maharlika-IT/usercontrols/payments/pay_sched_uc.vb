Public Class pay_sched_uc

    Public ps As New payment_schedule

    Private Sub pay_sched_uc_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblday.Text = ps.day
        lbldue.Text = Format(ps.due, "#,##0.00")


        lblexcess.Text = ps.GET_EXCESS

        lbldaily.Text = ps.daily

        lblschedule_date.Text = Format(ps.schedule_date, "MM/dd/yyyy")

        If ps.excess_from_previous > 0 Then
            lblpayment.Text = Format(ps.payment_amount, "#,##0.00") & "+" & ps.excess_from_previous
        Else
            lblpayment.Text = Format(ps.payment_amount, "#,##0.00")
        End If


        Dim excess As Decimal = CDec(ps.GET_TOTAL_CASH) - CDec(ps.daily)

        If excess > 0 Then
            lblexcess.Text= excess
        Else
            lblexcess.Text = 0
        End If



        If lblpayment.Text = "0.00" And lblexcess.Text = "0" Then
            If ps.schedule_date > Now Then
                Me.BackColor = Color.Silver
            Else
                Me.BackColor = Color.Red
            End If
        Else
            Me.BackColor = Color.GreenYellow
        End If

        If ps.schedule_date.ToShortDateString = Now.ToShortDateString Then
            Me.BackColor = Color.Orange
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.Width = Me.Parent.Width - 30
        Catch ex As Exception

        End Try

    End Sub
End Class
