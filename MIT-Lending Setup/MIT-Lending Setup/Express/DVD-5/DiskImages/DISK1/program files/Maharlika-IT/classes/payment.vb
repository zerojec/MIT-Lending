Imports MySql.Data.MySqlClient
Public Class payment

    Public Property id As Integer
    Public Property clientid As Integer
    Public Property loanid As Integer
    Public Property amount As Decimal
    Public Property ornumber As String
    Public Property date_ As Date
    Public Property collectorid As Integer

    Public Function save() As Boolean
        save = False
        Dim sql As String = "PAYMENT_INSERT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_clientid", clientid)
        cmd.Parameters.AddWithValue("_loanid", loanid)
        cmd.Parameters.AddWithValue("_amount", amount)
        cmd.Parameters.AddWithValue("_ornumber", ornumber)
        cmd.Parameters.AddWithValue("_date", date_)
        cmd.Parameters.AddWithValue("_collectorid", collectorid)

        If ExecuteCommand(cmd) Then
            save = True
        Else
            save = False
        End If
    End Function

    Public Function create() As Boolean
        create = False
        Dim sql As String = "PAYMENT_CREATE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_clientid", clientid)
        cmd.Parameters.AddWithValue("_loanid", loanid)
        cmd.Parameters.AddWithValue("_amount", amount)
        cmd.Parameters.AddWithValue("_date", date_)

        If ExecuteCommand(cmd) Then
            create = True
        Else
            create = False
        End If

    End Function

    Public Function update() As Boolean
        update = False
        Dim sql As String = "PAYMENT_UPDATE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_clientid", clientid)
        cmd.Parameters.AddWithValue("_loanid", loanid)
        cmd.Parameters.AddWithValue("_amount", amount)
        cmd.Parameters.AddWithValue("_ornumber", ornumber)
        cmd.Parameters.AddWithValue("_date", date_)
        cmd.Parameters.AddWithValue("_collectorid", collectorid)

        If ExecuteCommand(cmd) Then
            update = True
        Else
            update = False
        End If

    End Function

    Public Function delete() As Boolean
        delete = False
        Dim sql As String = "PAYMENT_DELETE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)
        If ExecuteCommand(cmd) Then
            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "PAYMENT"
            l.data = "PAYMENT ID : " & id & "- AMOUNT :" & amount & "-CLIENTID :" & clientid & "-LOANID :" & loanid

            l.WriteLog()
            delete = True
        Else
            delete = False
        End If

    End Function

    Public Function delete_bydate_byclientid() As Boolean
        delete_bydate_byclientid = False
        Dim sql As String = "PAYMENT_DELETE_BYDATE_BYCLIENTID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_clientid", clientid)
        cmd.Parameters.AddWithValue("_date", date_)
        If ExecuteCommand(cmd) Then
            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "PAYMENT"
            l.data = clientid & " " & date_

            l.WriteLog()
            delete_bydate_byclientid = True
        Else
            delete_bydate_byclientid = False
        End If

    End Function

    Public Function DELETE_ALL_PAYMENT_BY_LOANID() As Boolean
        DELETE_ALL_PAYMENT_BY_LOANID = False
        Dim sql As String = "PAYMENT_DELETE_ALL_BY_LOANID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_loanid", loanid)
        If ExecuteCommand(cmd) Then
            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "PAYMENT"
            l.data = loanid

            l.WriteLog()
            DELETE_ALL_PAYMENT_BY_LOANID = True
        Else
            DELETE_ALL_PAYMENT_BY_LOANID = False
        End If
    End Function
    Public Function SELECT_ALL() As DataTable
        Dim sql As String = "PAYMENT_SELECT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_ALL = dt
    End Function


    Public Function SELECT_BY_NAME(ByVal thisname As String) As DataTable
        Dim sql As String = "PAYMENT_SELECT_BY_NAME"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_name", thisname)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_NAME = dt
    End Function

    Public Function SELECT_BY_DATE(ByVal _date As Date) As DataTable
        Dim sql As String = "PAYMENT_SELECT_BYDATE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_date", _date)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_DATE = dt
    End Function

    Public Function SELECT_BY_DATE_BY_CLIENTID() As Decimal
        Dim sql As String = "PAYMENT_SELECT_BYDATE_BY_CLIENTID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_date", date_)
        cmd.Parameters.AddWithValue("_clientid", clientid)
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                SELECT_BY_DATE_BY_CLIENTID = dt.Rows(0).Item(0)
            Else
                SELECT_BY_DATE_BY_CLIENTID = 0
            End If
        Else
            SELECT_BY_DATE_BY_CLIENTID = 0
        End If

    End Function

    Public Function SELECT_BETWDATE_BY_LOANID(ByVal fromdate As Date, ByVal todate As Date) As Decimal
        Dim sql As String = "PAYMENT_SELECT_BETWDATE_BY_LOANID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_fromdate", fromdate)
        cmd.Parameters.AddWithValue("_todate", todate)
        cmd.Parameters.AddWithValue("_loanid", loanid)
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                SELECT_BETWDATE_BY_LOANID = dt.Rows(0).Item(0)
            Else
                SELECT_BETWDATE_BY_LOANID = 0
            End If
        Else
            SELECT_BETWDATE_BY_LOANID = 0
        End If

    End Function

    Public Function SELECT_BY_LOANID() As DataTable
        Dim sql As String = "PAYMENT_SELECT_BY_LOANID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_loanid", loanid)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_LOANID = dt
    End Function

    Public Function SELECT_BY_DATE_BY_COLLECTOR(ByVal _date As Date, ByVal _empid As Integer) As DataTable
        Dim sql As String = "PAYMENT_SELECT_BYDATE_BYCOLLECTOR"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_date", _date)
        cmd.Parameters.AddWithValue("_empid", _empid)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_DATE_BY_COLLECTOR = dt
    End Function



    Public Function GENERATE_ENTRY(ByVal _from_date As Date, ByVal _to_date As Date, ByVal _areaid As String) As DataTable
        Dim sql As String = "GENERATE_PAYMENT_ENTRY"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_from_date", _from_date)
        cmd.Parameters.AddWithValue("_to_date", _to_date)
        cmd.Parameters.AddWithValue("_areaid", _areaid)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        GENERATE_ENTRY = dt
    End Function

    Public Function GENERATE_ENTRY_ALL_AREA(ByVal _from_date As Date, ByVal _to_date As Date) As DataTable
        Dim sql As String = "GENERATE_PAYMENT_ENTRY_ALL_AREA"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_from_date", _from_date)
        cmd.Parameters.AddWithValue("_to_date", _to_date)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        GENERATE_ENTRY_ALL_AREA = dt
    End Function

    Public Function SELECT_BY_ID() As payment
        Dim sql As String = "PAYMENT_SELECT_BY_ID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim p As New payment

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then

                p.id = dt.Rows(0).Item("id")
                p.loanid = dt.Rows(0).Item("loanid")
                'p.ornumber = (dt.Rows(0).Item("ornumber")!= DBNull.Value)
                p.amount = dt.Rows(0).Item("amount")
                p.clientid = dt.Rows(0).Item("clientid")
                'p.collectorid = dt.Rows(0).Item("collectorid")
                p.date_ = dt.Rows(0).Item("date_")

                SELECT_BY_ID = p
            Else
                SELECT_BY_ID = Nothing
            End If
        Else
            SELECT_BY_ID = Nothing
        End If
    End Function
    Public Function SELECT_SUM_BY_LOANID(ByVal loanid As Integer) As Decimal
        Dim sql As String = "PAYMENT_SELECT_SUM_BY_LOANID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_loanid", loanid)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                SELECT_SUM_BY_LOANID = CDec(dt.Rows(0).Item(0))
            Else
                SELECT_SUM_BY_LOANID = 0
            End If
        Else
            SELECT_SUM_BY_LOANID = 0
        End If
    End Function


    Public Function SELECT_BY_DATE_BY_LOANID(ByVal loanid As Integer, ByVal date_ As Date) As Decimal
        Dim sql As String = "PAYMENT_SELECT_BY_DATE_BY_LOANID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_loanid", loanid)
        cmd.Parameters.AddWithValue("_date", date_)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                SELECT_BY_DATE_BY_LOANID = CDec(dt.Rows(0).Item(0))
            Else
                SELECT_BY_DATE_BY_LOANID = 0
            End If
        Else
            SELECT_BY_DATE_BY_LOANID = 0
        End If
    End Function

    Public Function DUPLICATE_OR_NUMBER() As Boolean
        Dim sql As String = "PAYMENT_CHECK_OR_NUMBER"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_ornumber", ornumber)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item(0) = 1 Then
                    DUPLICATE_OR_NUMBER = 1
                Else
                    DUPLICATE_OR_NUMBER = 0
                End If
            Else
                DUPLICATE_OR_NUMBER = 0
            End If
        Else
            DUPLICATE_OR_NUMBER = 0
        End If
    End Function
End Class
