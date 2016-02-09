Imports MySql.Data.MySqlClient
Public Class cash_advance

    Public Property id As Integer
    Public Property empid As Integer
    Public Property amount As Decimal
    Public Property date_ As Date

    Public Function save() As Boolean
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "CASH_ADVANCE_INSERT")

        cmd.Parameters.AddWithValue("_amount", amount)
        cmd.Parameters.AddWithValue("_date_", date_)
        cmd.Parameters.AddWithValue("_empid", empid)

        If ExecuteCommand(cmd) Then
            Dim evnt As String = "NEW CASH ADVANCE-" & empid & "-" & amount
            Dim l As New logger()

            l.action = "INSERT"
            l.data = evnt
            l.datetime = Now
            l.program_part = "CASH ADVANCE"
            l.WriteLog()

            save = True
        Else
            save = False
        End If
    End Function

    Public Function update() As Boolean
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "CASH_ADVANCE_UPDATE")

        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_amount", amount)
        cmd.Parameters.AddWithValue("_date", date_)
        cmd.Parameters.AddWithValue("_empid", empid)

        If ExecuteCommand(cmd) Then
            Dim evnt As String = "UPDATE CASH ADVANCE-" & empid & "-" & amount
            Dim l As New logger()

            l.action = "UPDATE"
            l.data = evnt
            l.datetime = Now
            l.program_part = "CASH ADVANCE"
            l.WriteLog()

            update = True
        Else
            update = False
        End If
    End Function

    Public Function delete() As Boolean

        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "CASH_ADVANCE_DELETE")

        cmd.Parameters.AddWithValue("_id", id)

        If ExecuteCommand(cmd) Then
            Dim evnt As String = "DELETE CASH ADVANCE-" & empid & "-" & amount
            Dim l As New logger()

            l.action = "DELETE"
            l.data = evnt
            l.datetime = Now
            l.program_part = "CASH ADVANCE"
            l.WriteLog()

            delete = True
        Else
            delete = False
        End If
    End Function

    Public Function SELECT_ALL() As DataTable
        Dim sql As String = "CASH_ADVANCE_SELECT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_ALL = dt
    End Function

    Public Function SELECT_BYID() As cash_advance

        Dim sql As String = "CASH_ADVANCE_SELECT_BYID"
        Dim cmd As New MySqlCommand
        cmd.Parameters.AddWithValue("_id", id)
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)


        If dt IsNot Nothing Then

            Dim cap As New cash_advance
            Dim r As DataRow = dt.Rows(0)
            cap.id = id
            cap.amount = CDec(r("amount").ToString())          
            cap.date_ = CDate(r("date_").ToString())
            cap.empid = r("empid").ToString()

            Return cap

        Else
            Return Nothing
        End If

    End Function


    Public Function SELECT_BY_EMPID() As DataTable
        Dim sql As String = "CASH_ADVANCE_ALL_BYEMPID"
        Dim cmd As New MySqlCommand
        cmd.Parameters.AddWithValue("_empid", empid)
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_EMPID = dt
    End Function

    Public Function GET_TOTAL_CASH_ADVANCE() As Decimal
        Dim sql As String = "CASH_ADVANCE_BALANCE_BYEMPID"
        Dim cmd As New MySqlCommand
        cmd.Parameters.AddWithValue("_empid", empid)
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim total As Decimal = 0

        If dt IsNot Nothing Then
            total = CDec(dt.Rows(0).Item("total").ToString())
            GET_TOTAL_CASH_ADVANCE = total
        Else
            GET_TOTAL_CASH_ADVANCE = 0
        End If

    End Function

    Public Function CHECK_BALANCE_BYEMPID() As Decimal()
        Dim sql As String = "CASH_ADVANCE_BALANCE_BYEMPID"
        Dim cmd As New MySqlCommand
        cmd.Parameters.AddWithValue("_empid", empid)
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim ret(3) As Decimal
        Dim bal As Decimal = 0

        If dt IsNot Nothing Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim r As DataRow = dt.Rows(x)
                bal = CDec(r("balance").ToString())

                If bal > 0 Then
                    ret = {CDec(r("amount").ToString()), bal, CDec(r("id").ToString())}
                    Exit For
                Else
                    ret = {CDec(r("amount").ToString()), 0.0, CDec(r("id").ToString())}
                End If
            Next
            CHECK_BALANCE_BYEMPID = ret
        Else
            ret = {0.0, 0.0, 0.0}
            CHECK_BALANCE_BYEMPID = ret            
        End If


    End Function
End Class
