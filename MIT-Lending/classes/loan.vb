Imports MySql.Data.MySqlClient
Public Class loan

    Public Property id As Integer
    Public Property clientid As Integer
    Public Property comakerid As Integer
    Public Property date_released As Date
    Public Property start_of_payment As Date
    Public Property end_of_payment As Date
    Public Property loan_amount As Decimal
    Public Property daily_payment_amount As Decimal

    Public Function save() As Boolean
        save = False
        Dim sql As String = "LOAN_INSERT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_clientid", clientid)
        cmd.Parameters.AddWithValue("_comakerid", comakerid)
        cmd.Parameters.AddWithValue("_date_released", date_released)
        cmd.Parameters.AddWithValue("_start_of_payment", start_of_payment)
        cmd.Parameters.AddWithValue("_end_of_payment", end_of_payment)
        cmd.Parameters.AddWithValue("_loan_amount", loan_amount)
        cmd.Parameters.AddWithValue("_daily_payment_amount", daily_payment_amount)

        If ExecuteCommand(cmd) Then
            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "LOAN"
            l.data = clientid & " " & loan_amount

            l.WriteLog()
            save = True
        Else
            save = False
        End If
    End Function

    Public Function update() As Boolean
        update = False
        Dim sql As String = "LOAN_UPDATE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_clientid", clientid)
        cmd.Parameters.AddWithValue("_comakerid", comakerid)
        cmd.Parameters.AddWithValue("_date_released", date_released)
        cmd.Parameters.AddWithValue("_start_of_payment", start_of_payment)
        cmd.Parameters.AddWithValue("_end_of_payment", end_of_payment)
        cmd.Parameters.AddWithValue("_loan_amount", loan_amount)
        cmd.Parameters.AddWithValue("_daily_payment_amount", daily_payment_amount)

        If ExecuteCommand(cmd) Then
            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "LOAN"
            l.data = clientid & " " & loan_amount

            l.WriteLog()
            update = True
        Else
            update = False
        End If
    End Function

    Public Function delete() As Boolean
        delete = False
        Dim sql As String = "LOAN_DELETE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)
        If ExecuteCommand(cmd) Then
            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "LOAN"
            l.data = clientid & " " & loan_amount

            l.WriteLog()
            delete = True
        Else
            delete = False
        End If
    End Function

    Public Function SET_TO_FULLY_PAID(ByVal _this_date As Date) As Boolean
        SET_TO_FULLY_PAID = False
        Dim sql As String = "LOAN_SET_TO_FULLY_PAID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)

        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_this_date", _this_date)

        If ExecuteCommand(cmd) Then
            'Dim l As New logger()
            'l.action = sql
            'l.datetime = DateTime.Now
            'l.program_part = "LOAN"
            'l.data = id & " " & _this_date

            'l.WriteLog()
            SET_TO_FULLY_PAID = True
        Else
            SET_TO_FULLY_PAID = False
        End If
    End Function


    Public Function UNSET_TO_FULLY_PAID(ByVal _this_date As Date) As Boolean
        UNSET_TO_FULLY_PAID = False
        Dim sql As String = "LOAN_UNSET_TO_FULLY_PAID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)

        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_this_date", _this_date)

        If ExecuteCommand(cmd) Then
            'Dim l As New logger()
            'l.action = sql
            'l.datetime = DateTime.Now
            'l.program_part = "LOAN"
            'l.data = "LOAN ID :" & id & "-DATE_UNSET :" & _this_date & "-BY:" & CURRENT_USER.id & "-" & CURRENT_USER.lname & "," & CURRENT_USER.fname

            'l.WriteLog()
            UNSET_TO_FULLY_PAID = True
        Else
            UNSET_TO_FULLY_PAID = False
        End If
    End Function
    Public Function SELECT_ALL() As DataTable
        Dim sql As String = "LOAN_SELECT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_ALL = dt
    End Function

    Public Function SELECT_ACTIVE() As DataTable
        Dim sql As String = "LOAN_SELECT_ACTIVE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_ACTIVE = dt
    End Function

    Public Function SELECT_BY_NAME(ByVal thisname As String) As DataTable
        Dim sql As String = "LOAN_SELECT_BY_NAME"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_name", thisname)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_NAME = dt

    End Function


    Public Function SELECT_ACTIVE_BY_NAME(ByVal thisname As String) As DataTable
        Dim sql As String = "LOAN_SELECT_ACTIVE_BY_NAME"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_name", thisname)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_ACTIVE_BY_NAME = dt
    End Function
    Public Function SELECT_BY_CLIENTID(ByVal id As Integer) As DataTable
        Dim sql As String = "LOAN_SELECT_BY_CLIENTID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_CLIENTID = dt
    End Function

    Public Function SELECT_BY_COMAKERID() As DataTable
        Dim sql As String = "LOAN_SELECT_BY_COMAKERID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_comakerid", comakerid)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_COMAKERID = dt
    End Function
    Public Function SELECT_BY_ID() As loan
        Dim sql As String = "LOAN_SELECT_BY_ID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim e As New loan

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                e.id = dt.Rows(0).Item("id")
                e.clientid = dt.Rows(0).Item("clientid")
                e.comakerid = dt.Rows(0).Item("comakerid")
                e.date_released = dt.Rows(0).Item("date_released")
                e.start_of_payment = dt.Rows(0).Item("start_of_payment")
                e.end_of_payment = dt.Rows(0).Item("end_of_payment")
                e.loan_amount = dt.Rows(0).Item("loan_amount")
                e.daily_payment_amount = dt.Rows(0).Item("daily_payment_amount")

                SELECT_BY_ID = e
            Else
                SELECT_BY_ID = Nothing
            End If

        Else
            SELECT_BY_ID = Nothing
        End If
    End Function

    Public Function GET_BALANCE() As Decimal
        Dim sql As String = "LOAN_GET_BALANCE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_loanid", id)
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                GET_BALANCE = dt.Rows(0).Item(0)
            Else
                GET_BALANCE = 0
            End If
        Else
            GET_BALANCE = 0
        End If

    End Function
End Class
