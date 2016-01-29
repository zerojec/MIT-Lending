Imports MySql.Data.MySqlClient

Public Class client

    Public Property id As Integer
    Public Property fname As String
    Public Property mname As String
    Public Property lname As String
    Public Property address As String
    Public Property contactno As String
    Public Property areaid As String

    Public Function save() As Boolean
        save = False
        Dim sql As String = "CLIENT_INSERT"
        Dim cmd As New MySqlCommand


        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_fname", fname)
        cmd.Parameters.AddWithValue("_mname", mname)
        cmd.Parameters.AddWithValue("_lname", lname)
        cmd.Parameters.AddWithValue("_address", address)
        cmd.Parameters.AddWithValue("_contactno", contactno)
        cmd.Parameters.AddWithValue("_areaid", areaid)

        If ExecuteCommand(cmd) Then
            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "CLIENT"
            l.data = areaid

            l.WriteLog()
            save = True
        Else
            save = False
        End If
    End Function

    Public Function update() As Boolean
        update = False
        Dim sql As String = "CLIENT_UPDATE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
         cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_fname", fname)
        cmd.Parameters.AddWithValue("_mname", mname)
        cmd.Parameters.AddWithValue("_lname", lname)
        cmd.Parameters.AddWithValue("_address", address)
        cmd.Parameters.AddWithValue("_contactno", contactno)
        cmd.Parameters.AddWithValue("_areaid", areaid)
        If ExecuteCommand(cmd) Then

            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "CLIENT"
            l.data = areaid

            l.WriteLog()
            update = True
        Else
            update = False
        End If
    End Function

    Public Function delete() As Boolean
        delete = False
        Dim sql As String = "CLIENT_DELETE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)
        If ExecuteCommand(cmd) Then
            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "CLIENT"
            l.data = areaid

            l.WriteLog()
            delete = True
        Else
            delete = False
        End If
    End Function

    Public Function SELECT_ALL() As DataTable
        Dim sql As String = "CLIENT_SELECT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_ALL = dt
    End Function


    Public Function SELECT_CLIENTS_BY_NAME(ByVal thisname As String) As DataTable
        Dim sql As String = "CLIENT_SELECT_BY_NAME"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_name", thisname)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_CLIENTS_BY_NAME = dt
    End Function

    Public Function SELECT_BY_ID() As client
        Dim sql As String = "CLIENT_SELECT_BY_ID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim e As New client

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                e.id = dt.Rows(0).Item("id")
                e.fname = dt.Rows(0).Item("fname")
                e.lname = dt.Rows(0).Item("lname")
                e.mname = dt.Rows(0).Item("mname")
                e.address = dt.Rows(0).Item("address")
                e.contactno = dt.Rows(0).Item("contactno")
                e.areaid = dt.Rows(0).Item("areaid")

                SELECT_BY_ID = e
            Else
                SELECT_BY_ID = Nothing
            End If

        Else
            SELECT_BY_ID = Nothing
        End If
    End Function

    Public Function SELECT_BY_ID_DT() As DataTable
        Dim sql As String = "CLIENT_SELECT_BY_ID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim e As New client

        If dt IsNot Nothing Then
            SELECT_BY_ID_DT = dt
        Else
            SELECT_BY_ID_DT = Nothing
        End If
    End Function
    Public Function GET_LOAN_CYCLE(ByVal id As Integer) As Integer
        Dim sql As String = "CLIENT_GET_LOAN_CYCLE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then               
                GET_LOAN_CYCLE = CInt(dt.Rows(0).Item(0))
            Else
                GET_LOAN_CYCLE = 0
            End If
        Else
            GET_LOAN_CYCLE = 0
        End If
    End Function

    Public Function GET_ACTIVE_LOAN_CYCLE() As Integer
        Dim sql As String = "CLIENT_GET_ACTIVE_LOAN_CYCLE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                GET_ACTIVE_LOAN_CYCLE = CInt(dt.Rows(0).Item(0))
            Else
                GET_ACTIVE_LOAN_CYCLE = 0
            End If
        Else
            GET_ACTIVE_LOAN_CYCLE = 0
        End If
    End Function

    Public Function CHECK_IF_A_COMAKER() As Boolean
        Dim sql As String = "CLIENT_CHECK_IF_A_COMAKER"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_comakerid", id)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item(0) > 0 Then
                    CHECK_IF_A_COMAKER = True
                Else
                    CHECK_IF_A_COMAKER = False
                End If

            Else
                CHECK_IF_A_COMAKER = False
            End If
        Else
            CHECK_IF_A_COMAKER = False
        End If
    End Function


  
End Class
