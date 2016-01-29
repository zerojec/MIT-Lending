Imports MySql.Data.MySqlClient
Public Class emp

    Public Property id As Integer
    Public Property fname As String
    Public Property lname As String
    Public Property position As String
    Public Property contactno As String
    Public Property areaid As String
    Public Property pword As String

    Public Function save() As Boolean
        save = False
        Dim sql As String = "EMP_INSERT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_fname", fname)
        cmd.Parameters.AddWithValue("_lname", lname)
        cmd.Parameters.AddWithValue("_position", position)
        cmd.Parameters.AddWithValue("_contactno", contactno)
        cmd.Parameters.AddWithValue("_areaid", areaid)

        If ExecuteCommand(cmd) Then

            Dim r As New restriction
            r.ID = id
            If r.crate_default Then

                Dim l As New logger()
                l.action = sql
                l.datetime = DateTime.Now
                l.program_part = "EMP"
                l.data = id

                l.WriteLog()
                save = True
            Else
                save = False
            End If

        Else
            save = False
        End If
    End Function

    Public Function update() As Boolean
        update = False
        Dim sql As String = "EMP_UPDATE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)
        cmd.Parameters.AddWithValue("_fname", fname)
        cmd.Parameters.AddWithValue("_lname", lname)
        cmd.Parameters.AddWithValue("_position", position)
        cmd.Parameters.AddWithValue("_contactno", contactno)
        cmd.Parameters.AddWithValue("_areaid", areaid)
        If ExecuteCommand(cmd) Then
            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "EMP"
            l.data = id

            l.WriteLog()
            update = True
        Else
            update = False
        End If
    End Function

    Public Function delete() As Boolean
        delete = False
        Dim sql As String = "EMP_DELETE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)   
        If ExecuteCommand(cmd) Then
            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "EMP"
            l.data = id

            l.WriteLog()
            delete = True
        Else
            delete = False
        End If
    End Function

    Public Function SELECT_ALL() As DataTable
        Dim sql As String = "EMP_SELECT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_ALL = dt
    End Function


    Public Function SELECT_BY_NAME(ByVal thisname As String) As DataTable
        Dim sql As String = "EMP_SELECT_BY_NAME"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_name", thisname)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        SELECT_BY_NAME = dt
    End Function

    Public Function SELECT_BY_ID() As emp
        Dim sql As String = "EMP_SELECT_BY_ID"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_id", id)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        Dim e As New emp

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                e.id = dt.Rows(0).Item("id")
                e.fname = dt.Rows(0).Item("fname")
                e.lname = dt.Rows(0).Item("lname")
                e.position = dt.Rows(0).Item("position")
                e.contactno = dt.Rows(0).Item("contactno")
                e.areaid = dt.Rows(0).Item("areaid")
                e.pword = dt.Rows(0).Item("pword")

                SELECT_BY_ID = e
            Else
                SELECT_BY_ID = Nothing
            End If

        Else
            SELECT_BY_ID = Nothing
        End If
    End Function

    Public Function CHANGE_PASSWORD(ByVal newpass As String) As Boolean

        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "EMP_CHANGE_PASSWORD")

        Dim hash As String = GenerateHash(newpass)
        cmd.Parameters.AddWithValue("_NEW_PASS", hash)
        cmd.Parameters.AddWithValue("_ID", id)

        If ExecuteCommand(cmd) Then
            pword = hash

            Dim l As New logger()
            l.action = "EMP_CHANGE_PASSWORD"
            l.datetime = DateTime.Now
            l.program_part = "EMP"
            l.data = hash

            l.WriteLog()

            CHANGE_PASSWORD = True
        Else
            CHANGE_PASSWORD = False
        End If

    End Function

End Class
