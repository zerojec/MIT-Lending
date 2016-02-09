Imports MySql.Data.MySqlClient
Public Class restriction

    Public Property ID As Integer
    Public Property CAN_ACCESS_CLIENT As Boolean
    Public Property CAN_ADD_CLIENT As Boolean
    Public Property CAN_EDIT_CLIENT As Boolean
    Public Property CAN_DELETE_CLIENT As Boolean
    Public Property CAN_SEARCH_CLIENT As Boolean
    Public Property CAN_VIEW_CLIENT As Boolean
    Public Property CAN_VIEW_CLIENT_PROFILE As Boolean


    Public Property CAN_ACCESS_EMP As Boolean
    Public Property CAN_ADD_EMP As Boolean
    Public Property CAN_EDIT_EMP As Boolean
    Public Property CAN_DELETE_EMP As Boolean
    Public Property CAN_SEARCH_EMP As Boolean
    Public Property CAN_VIEW_EMP As Boolean



    Public Property CAN_ACCESS_LOAN As Boolean
    Public Property CAN_ADD_LOAN As Boolean
    Public Property CAN_EDIT_LOAN As Boolean
    Public Property CAN_DELETE_LOAN As Boolean
    Public Property CAN_SEARCH_LOAN As Boolean
    Public Property CAN_VIEW_LOAN As Boolean



    Public Property CAN_ACCESS_PAYMENT As Boolean
    'Public Property CAN_ADD_PAYMENT As Boolean
    Public Property CAN_EDIT_PAYMENT As Boolean
    Public Property CAN_DELETE_PAYMENT As Boolean
    Public Property CAN_SEARCH_PAYMENT As Boolean
    Public Property CAN_VIEW_PAYMENT As Boolean

    Public Property CAN_GENERATE_PAYMENT_ENTRY As Boolean

    Public Property CAN_ACCESS_RESTRICTION As Boolean
    'Public Property CAN_ADD_RESTRICTION As Boolean
    Public Property CAN_EDIT_RESTRICTION As Boolean
    'Public Property CAN_DELETE_RESTRICTION As Boolean
    Public Property CAN_VIEW_RESTRICTION As Boolean

    Public Property CAN_ACCESS_REPORT As Boolean
    Public Property CAN_ACCESS_SETTINGS As Boolean
    Public Property CAN_SHOW_AMOUNT As Boolean
    Public Property CAN_SHOW_SUBTOTAL As Boolean
    Public Property CAN_ACCESS_CLIENT_REPORT As Boolean
    Public Property CAN_ACCESS_PAYMENT_REPORT As Boolean
    Public Property CAN_ACCESS_BALANCE_REPORT As Boolean
    Public Property CAN_ACCESS_CASH_ADVANCE As Boolean

    Public Function crate_default() As Boolean
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "RESTRICTION_INSERT_DEFAULT")
        cmd.Parameters.AddWithValue("_ID", ID)
        If ExecuteCommand(cmd) Then
            crate_default = True
        Else
            crate_default = False
        End If
    End Function


    Public Function save() As Boolean
        Dim cmd As New MySqlCommand

        SetCommandProperties(cmd, "RESTRICTION_INSERT")

        cmd.Parameters.AddWithValue("_ID", ID)

        cmd.Parameters.AddWithValue("_CAN_ACCESS_CLIENT", CAN_ACCESS_CLIENT)
        cmd.Parameters.AddWithValue("_CAN_ADD_CLIENT", CAN_ADD_CLIENT)
        cmd.Parameters.AddWithValue("_CAN_EDIT_CLIENT", CAN_EDIT_CLIENT)
        cmd.Parameters.AddWithValue("_CAN_DELETE_CLIENT", CAN_DELETE_CLIENT)
        cmd.Parameters.AddWithValue("_CAN_SEARCH_CLIENT", CAN_SEARCH_CLIENT)
        cmd.Parameters.AddWithValue("_CAN_VIEW_CLIENT_PROFILE", CAN_VIEW_CLIENT_PROFILE)

        cmd.Parameters.AddWithValue("_CAN_ACCESS_EMP", CAN_ACCESS_EMP)
        cmd.Parameters.AddWithValue("_CAN_ADD_EMP", CAN_ADD_EMP)
        cmd.Parameters.AddWithValue("_CAN_EDIT_EMP", CAN_EDIT_EMP)
        cmd.Parameters.AddWithValue("_CAN_DELETE_EMP", CAN_DELETE_EMP)
        cmd.Parameters.AddWithValue("_CAN_SEARCH_EMP", CAN_SEARCH_EMP)
        cmd.Parameters.AddWithValue("_CAN_VIEW_EMP", CAN_VIEW_EMP)

        cmd.Parameters.AddWithValue("_CAN_ACCESS_LOAN", CAN_ACCESS_LOAN)
        cmd.Parameters.AddWithValue("_CAN_ADD_LOAN", CAN_ADD_LOAN)
        cmd.Parameters.AddWithValue("_CAN_EDIT_LOAN", CAN_EDIT_LOAN)
        cmd.Parameters.AddWithValue("_CAN_DELETE_LOAN", CAN_DELETE_LOAN)
        cmd.Parameters.AddWithValue("_CAN_SEARCH_LOAN", CAN_SEARCH_LOAN)
        cmd.Parameters.AddWithValue("_CAN_VIEW_LOAN", CAN_VIEW_LOAN)

        cmd.Parameters.AddWithValue("_CAN_ACCESS_PAYMENT", CAN_ACCESS_PAYMENT)
        ' cmd.Parameters.AddWithValue("_CAN_ADD_PAYMENT", CAN_ADD_PAYMENT)
        cmd.Parameters.AddWithValue("_CAN_EDIT_PAYMENT", CAN_EDIT_PAYMENT)
        cmd.Parameters.AddWithValue("_CAN_DELETE_PAYMENT", CAN_DELETE_PAYMENT)
        cmd.Parameters.AddWithValue("_CAN_SEARCH_PAYMENT", CAN_SEARCH_PAYMENT)
        cmd.Parameters.AddWithValue("_CAN_VIEW_PAYMENT", CAN_VIEW_PAYMENT)

        cmd.Parameters.AddWithValue("_CAN_ACCESS_RESTRICTION", CAN_ACCESS_RESTRICTION)
        ' cmd.Parameters.AddWithValue("_CAN_ADD_RESTRICTION", CAN_ADD_RESTRICTION)
        cmd.Parameters.AddWithValue("_CAN_EDIT_RESTRICTION", CAN_EDIT_RESTRICTION)
        ' cmd.Parameters.AddWithValue("_CAN_DELETE_RESTRICTION", CAN_DELETE_RESTRICTION)
        cmd.Parameters.AddWithValue("_CAN_VIEW_RESTRICTION", CAN_VIEW_RESTRICTION)

        cmd.Parameters.AddWithValue("_CAN_ACCESS_SETTINGS", CAN_ACCESS_SETTINGS)
        cmd.Parameters.AddWithValue("_CAN_SHOW_AMOUNT", CAN_SHOW_AMOUNT)
        cmd.Parameters.AddWithValue("_CAN_SHOW_SUBTOTAL", CAN_SHOW_SUBTOTAL)
        cmd.Parameters.AddWithValue("_CAN_ACCESS_CLIENT_REPORT", CAN_ACCESS_CLIENT_REPORT)
        cmd.Parameters.AddWithValue("_CAN_ACCESS_PAYMENT_REPORT", CAN_ACCESS_PAYMENT_REPORT)
        cmd.Parameters.AddWithValue("_CAN_ACCESS_BALANCE_REPORT", CAN_ACCESS_BALANCE_REPORT)
        cmd.Parameters.AddWithValue("_CAN_ACCESS_CASH_ADVANCE", CAN_ACCESS_CASH_ADVANCE)

        If ExecuteCommand(cmd) Then
            save = True
        Else
            save = False
        End If

    End Function



    Public Function update() As Boolean
        Dim cmd As New MySqlCommand

        SetCommandProperties(cmd, "RESTRICTION_UPDATE")

        cmd.Parameters.AddWithValue("_ID", ID)
        cmd.Parameters.AddWithValue("_CAN_ACCESS_CLIENT", CAN_ACCESS_CLIENT)
        cmd.Parameters.AddWithValue("_CAN_ADD_CLIENT", CAN_ADD_CLIENT)
        cmd.Parameters.AddWithValue("_CAN_EDIT_CLIENT", CAN_EDIT_CLIENT)
        cmd.Parameters.AddWithValue("_CAN_DELETE_CLIENT", CAN_DELETE_CLIENT)
        cmd.Parameters.AddWithValue("_CAN_SEARCH_CLIENT", CAN_SEARCH_CLIENT)
        cmd.Parameters.AddWithValue("_CAN_VIEW_CLIENT_PROFILE", CAN_VIEW_CLIENT_PROFILE)


        cmd.Parameters.AddWithValue("_CAN_ACCESS_EMP", CAN_ACCESS_EMP)
        cmd.Parameters.AddWithValue("_CAN_ADD_EMP", CAN_ADD_EMP)
        cmd.Parameters.AddWithValue("_CAN_EDIT_EMP", CAN_EDIT_EMP)
        cmd.Parameters.AddWithValue("_CAN_DELETE_EMP", CAN_DELETE_EMP)
        cmd.Parameters.AddWithValue("_CAN_SEARCH_EMP", CAN_SEARCH_EMP)
        cmd.Parameters.AddWithValue("_CAN_VIEW_EMP", CAN_VIEW_EMP)


        cmd.Parameters.AddWithValue("_CAN_ACCESS_LOAN", CAN_ACCESS_LOAN)
        cmd.Parameters.AddWithValue("_CAN_ADD_LOAN", CAN_ADD_LOAN)
        cmd.Parameters.AddWithValue("_CAN_EDIT_LOAN", CAN_EDIT_LOAN)
        cmd.Parameters.AddWithValue("_CAN_DELETE_LOAN", CAN_DELETE_LOAN)
        cmd.Parameters.AddWithValue("_CAN_SEARCH_LOAN", CAN_SEARCH_LOAN)
        cmd.Parameters.AddWithValue("_CAN_VIEW_LOAN", CAN_VIEW_LOAN)


        cmd.Parameters.AddWithValue("_CAN_ACCESS_PAYMENT", CAN_ACCESS_PAYMENT)
        ' cmd.Parameters.AddWithValue("_CAN_ADD_PAYMENT", CAN_ADD_PAYMENT)
        cmd.Parameters.AddWithValue("_CAN_EDIT_PAYMENT", CAN_EDIT_PAYMENT)
        cmd.Parameters.AddWithValue("_CAN_DELETE_PAYMENT", CAN_DELETE_PAYMENT)
        cmd.Parameters.AddWithValue("_CAN_SEARCH_PAYMENT", CAN_SEARCH_PAYMENT)
        cmd.Parameters.AddWithValue("_CAN_VIEW_PAYMENT", CAN_VIEW_PAYMENT)



        cmd.Parameters.AddWithValue("_CAN_ACCESS_RESTRICTION", CAN_ACCESS_RESTRICTION)
        ' cmd.Parameters.AddWithValue("_CAN_ADD_RESTRICTION", CAN_ADD_RESTRICTION)
        cmd.Parameters.AddWithValue("_CAN_EDIT_RESTRICTION", CAN_EDIT_RESTRICTION)
        ' cmd.Parameters.AddWithValue("_CAN_DELETE_RESTRICTION", CAN_DELETE_RESTRICTION)
        cmd.Parameters.AddWithValue("_CAN_VIEW_RESTRICTION", CAN_VIEW_RESTRICTION)

        cmd.Parameters.AddWithValue("_CAN_ACCESS_SETTINGS", CAN_ACCESS_SETTINGS)
        cmd.Parameters.AddWithValue("_CAN_SHOW_AMOUNT", CAN_SHOW_AMOUNT)
        cmd.Parameters.AddWithValue("_CAN_SHOW_SUBTOTAL", CAN_SHOW_SUBTOTAL)
        cmd.Parameters.AddWithValue("_CAN_ACCESS_CLIENT_REPORT", CAN_ACCESS_CLIENT_REPORT)
        cmd.Parameters.AddWithValue("_CAN_ACCESS_PAYMENT_REPORT", CAN_ACCESS_PAYMENT_REPORT)
        cmd.Parameters.AddWithValue("_CAN_ACCESS_BALANCE_REPORT", CAN_ACCESS_BALANCE_REPORT)
        cmd.Parameters.AddWithValue("_CAN_ACCESS_CASH_ADVANCE", CAN_ACCESS_CASH_ADVANCE)

        If ExecuteCommand(cmd) Then
            update = True
        Else
            update = False
        End If

    End Function



    Public Function delete() As Boolean
        Dim cmd As New MySqlCommand

        SetCommandProperties(cmd, "RESTRICTION_DELETE")
        cmd.Parameters.AddWithValue("_ID", ID)

        If ExecuteCommand(cmd) Then
            delete = True
        Else
            delete = False
        End If

    End Function

    Public Function SELECT_BY_ID() As restriction
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "RESTRICTION_SELECT_BY_ID")
        cmd.Parameters.AddWithValue("_ID", ID)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim r As New restriction
                Dim row As DataRow
                row = dt.Rows(0)

                r.ID = row.Item("ID")
                r.CAN_ACCESS_CLIENT = row.Item("CAN_ACCESS_CLIENT")
                r.CAN_ADD_CLIENT = row.Item("CAN_ADD_CLIENT")
                r.CAN_EDIT_CLIENT = row.Item("CAN_EDIT_CLIENT")
                r.CAN_DELETE_CLIENT = row.Item("CAN_DELETE_CLIENT")
                r.CAN_VIEW_CLIENT_PROFILE = row.Item("CAN_VIEW_CLIENT_PROFILE")
                r.CAN_SEARCH_CLIENT = row.Item("CAN_SEARCH_CLIENT")
                r.CAN_VIEW_CLIENT = row.Item("CAN_VIEW_CLIENT")

                r.CAN_ACCESS_EMP = row.Item("CAN_ACCESS_EMP")
                r.CAN_ADD_EMP = row.Item("CAN_ADD_EMP")
                r.CAN_EDIT_EMP = row.Item("CAN_EDIT_EMP")
                r.CAN_DELETE_EMP = row.Item("CAN_DELETE_EMP")
                r.CAN_VIEW_EMP = row.Item("CAN_VIEW_EMP")
                r.CAN_SEARCH_EMP = row.Item("CAN_SEARCH_EMP")

                r.CAN_ACCESS_LOAN = row.Item("CAN_ACCESS_LOAN")
                r.CAN_ADD_LOAN = row.Item("CAN_ADD_LOAN")
                r.CAN_EDIT_LOAN = row.Item("CAN_EDIT_LOAN")
                r.CAN_DELETE_LOAN = row.Item("CAN_DELETE_LOAN")
                r.CAN_VIEW_LOAN = row.Item("CAN_VIEW_LOAN")
                r.CAN_SEARCH_LOAN = row.Item("CAN_SEARCH_LOAN")

                r.CAN_ACCESS_PAYMENT = row.Item("CAN_ACCESS_PAYMENT")
                ' r.CAN_ADD_PAYMENT = row.Item("CAN_ADD_PAYMENT")
                r.CAN_EDIT_PAYMENT = row.Item("CAN_EDIT_PAYMENT")
                r.CAN_DELETE_PAYMENT = row.Item("CAN_DELETE_PAYMENT")
                r.CAN_VIEW_PAYMENT = row.Item("CAN_VIEW_PAYMENT")
                r.CAN_SEARCH_PAYMENT = row.Item("CAN_SEARCH_PAYMENT")
                r.CAN_GENERATE_PAYMENT_ENTRY = row.Item("CAN_GENERATE_PAYMENT_ENTRY")

                r.CAN_ACCESS_RESTRICTION = row.Item("CAN_ACCESS_RESTRICTION")
                ' r.CAN_ADD_RESTRICTION = row.Item("CAN_ADD_RESTRICTION")
                r.CAN_EDIT_RESTRICTION = row.Item("CAN_EDIT_RESTRICTION")
                ' r.CAN_DELETE_RESTRICTION = row.Item("CAN_DELETE_RESTRICTION")
                r.CAN_VIEW_RESTRICTION = row.Item("CAN_VIEW_RESTRICTION")

                r.CAN_ACCESS_SETTINGS = row.Item("CAN_ACCESS_SETTINGS")
                r.CAN_SHOW_AMOUNT = row.Item("CAN_SHOW_AMOUNT")
                r.CAN_SHOW_SUBTOTAL = row.Item("CAN_SHOW_SUBTOTAL")
                r.CAN_ACCESS_CLIENT_REPORT = row.Item("CAN_ACCESS_CLIENT_REPORT")
                r.CAN_ACCESS_PAYMENT_REPORT = row.Item("CAN_ACCESS_PAYMENT_REPORT")
                r.CAN_ACCESS_BALANCE_REPORT = row.Item("CAN_ACCESS_BALANCE_REPORT")
                r.CAN_ACCESS_REPORT = row.Item("CAN_ACCESS_REPORT")
                r.CAN_ACCESS_CASH_ADVANCE = row.Item("CAN_ACCESS_CASH_ADVANCE")

                SELECT_BY_ID = r
            Else
                SELECT_BY_ID = Nothing
            End If
        Else

            SELECT_BY_ID = Nothing
        End If


    End Function

    Public Function TOGGLE(ByVal fieldname As String) As Boolean

        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "RESTRICTION_TOGGLE")
        cmd.Parameters.AddWithValue("_ID", ID)
        cmd.Parameters.AddWithValue("_FIELD_NAME", fieldname)

        If ExecuteCommand(cmd) Then
            TOGGLE = True
        Else
            TOGGLE = False
        End If

    End Function

End Class
