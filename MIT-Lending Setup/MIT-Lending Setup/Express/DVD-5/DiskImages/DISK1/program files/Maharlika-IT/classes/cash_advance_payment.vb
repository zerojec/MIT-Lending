Imports MySql.Data.MySqlClient

Public Class cash_advance_payment
    Public Property id As Integer
    Public Property cashadvance_id As Integer
    Public Property empid As Integer
    Public Property amount As Decimal
    Public Property date_ As Date

    Public Function save() As Boolean
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "CA_PAYMENT_INSERT")

        cmd.Parameters.AddWithValue("_amount", amount)
        'cmd.Parameters.AddWithValue("_date_", date_)
        cmd.Parameters.AddWithValue("_empid", empid)
        cmd.Parameters.AddWithValue("_cashadvance_id", cashadvance_id)

        If ExecuteCommand(cmd) Then
            Dim evnt As String = "NEW CASH ADVANCE-PAYMENT" & empid & "-" & amount & "-" & cashadvance_id
            Dim l As New logger()

            l.action = "CA_PAYMENT_INSERT"
            l.data = evnt
            l.datetime = Now
            l.program_part = "CASH ADVANCE PAYMENT"
            l.WriteLog()

            save = True
        Else
            save = False
        End If
    End Function

    Public Function update() As Boolean
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "CA_PAYMENT_UPDATE")

        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_amount", amount)
        cmd.Parameters.AddWithValue("_date", date_)
        cmd.Parameters.AddWithValue("_empid", empid)
        cmd.Parameters.AddWithValue("_cashadvance_id", cashadvance_id)

        If ExecuteCommand(cmd) Then
            Dim evnt As String = "UPDATE CA_PAYMENT-" & empid & "-" & amount
            Dim l As New logger()

            l.action = "CA_PAYMENT_UPDATE"
            l.data = evnt
            l.datetime = Now
            l.program_part = "CASH ADVANCE PAYMENT"
            l.WriteLog()

            update = True
        Else
            update = False
        End If
    End Function

    Public Function delete() As Boolean

        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "CA_PAYMENT_DELETE")

        cmd.Parameters.AddWithValue("_id", id)

        If ExecuteCommand(cmd) Then
            Dim evnt As String = "DELETE CA_PAYMENT-" & empid & "-" & amount & "-" & date_
            Dim l As New logger()

            l.action = "CA_PAYMENT_DELETE"
            l.data = evnt
            l.datetime = Now
            l.program_part = "CASH ADVANCE PAYMENT"
            l.WriteLog()

            delete = True
        Else
            delete = False
        End If
    End Function

    Public Function SELECT_ALL() As DataTable
        Dim sql As String = "CA_PAYMENT_SELECT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_ALL = dt
    End Function

    Public Function SELECT_BY_CA_ID() As DataTable
        Dim sql As String = "CA_PAYMENT_SELECT_BY_CAID"
        Dim cmd As New MySqlCommand
        cmd.Parameters.AddWithValue("_cashadvance_id", cashadvance_id)
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_CA_ID = dt
    End Function

    Public Function SELECT_BY_EMPID() As DataTable
        Dim sql As String = "CA_PAYMENT_SELECT_BYEMPID"
        Dim cmd As New MySqlCommand
        cmd.Parameters.AddWithValue("_empid", empid)
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_EMPID = dt
    End Function

    Public Function GET_TOTAL_PAYMENT() As Decimal

        Dim sql As String = "CA_PAYMENT_TOTAL_BYEMPID"
        Dim cmd As New MySqlCommand
        cmd.Parameters.AddWithValue("_empid", empid)
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)


        If dt IsNot Nothing Then
            Return CDec(dt.Rows(0).Item(0).ToString())
        Else
            Return 0
        End If

    End Function
    Public Function SELECT_BYID() As cash_advance_payment

        Dim sql As String = "CA_PAYMENT_SELECT_BYID"
        Dim cmd As New MySqlCommand
        cmd.Parameters.AddWithValue("_id", id)
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)


        If dt IsNot Nothing Then

            Dim cap As New cash_advance_payment
            Dim r As DataRow = dt.Rows(0)
            cap.id = id
            cap.amount = CDec(r("amount").ToString())
            cap.cashadvance_id = r("cashadvance_id").ToString()
            cap.date_ = CDate(r("date_").ToString())
            cap.empid = r("empid").ToString()

            Return cap

        Else
            Return Nothing
        End If

    End Function
End Class
