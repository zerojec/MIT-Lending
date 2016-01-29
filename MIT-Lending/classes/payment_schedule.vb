
'CLASS SP is short for 
Public Class payment_schedule
    Public Property day As Integer
    Public Property schedule_date As Date
    Public Property excess_from_previous As Decimal 'excess from previous payment
    Public Property payment_amount As Decimal 'total payment for the scheduled date
    Public Property daily As Decimal ' the daily payment amount as computed through loan application
    Public Property due As Decimal 'the due for the scheduled date  
    Public Property loanid As Integer 'the loan id for reference to payment schedule
    Private Property total_cash_amount As Decimal ' add natin ang excess from previous at ang payment para makuha ang total cash

    Public Function IS_LAPSE() As Boolean
        IS_LAPSE = False

        'KPAG ANG TOTAL CASH AY MAHIGIT SA ZERO (TOTAL_CASH= PAYMENT + EXCESS)
        'CYEMRPRE NOT LAPASE
        If GET_TOTAL_CASH() > 0 Or excess_from_previous > 0 Then
            IS_LAPSE = False
        Else
            IS_LAPSE = True
        End If
    End Function

    Public Function GET_EXCESS() As Decimal

        'DAAHIL KAPAT MAS MALAKI ANG PAYMENT AMOUNT SA DAILY 
        'MAY EXCESS, IPAPASA ITONG VALUE SA SUNOD NA ARAW.
        If payment_amount > daily Then
            GET_EXCESS = payment_amount - daily
        Else
            GET_EXCESS = 0
        End If
    End Function

    Public Function GET_PAYMENT() As Decimal
        Dim p As New payment
        Dim a As Decimal = 0
        a = p.SELECT_BY_DATE_BY_LOANID(loanid, schedule_date)
        payment_amount = a
        Return a
    End Function

    Public Function GET_TOTAL_CASH() As Decimal

        Dim p As Decimal = GET_PAYMENT()
        Dim e As Decimal = excess_from_previous
        total_cash_amount = p + e
        GET_TOTAL_CASH = total_cash_amount

    End Function
End Class
