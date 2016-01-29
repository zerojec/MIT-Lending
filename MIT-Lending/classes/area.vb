Imports MySql.Data.MySqlClient
Public Class area

    Public Property areaid As String

    Public Function save() As Boolean
        save = False
        Dim sql As String = "AREA_INSERT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)

        cmd.Parameters.AddWithValue("_areaid", areaid)

        If ExecuteCommand(cmd) Then
            save = True
        Else
            save = False
        End If
    End Function

    Public Function update() As Boolean

        update = False
        Dim sql As String = "AREA_UPDATE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_areaid", areaid)

        Dim n As New area
        n.areaid = areaid

        If n.delete Then
            If n.save Then


                Dim l As New logger()
                l.action = sql
                l.datetime = DateTime.Now
                l.program_part = "AREA"
                l.data = areaid

                l.WriteLog()
                update = True

            Else
                update = False
            End If
        Else
            update = False
        End If

    End Function

    Public Function delete() As Boolean

        delete = False
        Dim sql As String = "AREA_DELETE"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_areaid", areaid)
        If ExecuteCommand(cmd) Then

            Dim l As New logger()
            l.action = sql
            l.datetime = DateTime.Now
            l.program_part = "AREA"
            l.data = areaid

            l.WriteLog()

            delete = True
        Else
            delete = False
        End If


    End Function

    Public Function SELECT_ALL() As DataTable
        Dim sql As String = "AREA_SELECT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)
        SELECT_ALL = dt
    End Function

End Class
