Public Class clients_uc

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim a As New new_client_uc
        a.Dock = DockStyle.Fill
        pnlops.Height = a.Height
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub

    Sub LoadClientsBySearching(ByVal thisname As String)
        Dim dt As New DataTable
        Dim c As New client

        dt = c.SELECT_CLIENTS_BY_NAME(thisname)

        lv.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim li As New ListViewItem
                    li.Text = x
                    li.SubItems.Add(r.Item("lname") & ", " & r.Item("fname") & " " & r.Item("mname"))
                    li.SubItems.Add(r.Item("address"))
                    li.SubItems.Add(r.Item("areaid"))
                    li.SubItems.Add(r.Item("contactno"))
                    li.Tag = r.Item("id")
                    lv.Items.Add(li)
                    x += 1
                Next
            End If
        Else

        End If

    End Sub

    Sub LoadClients()
        Dim dt As New DataTable
        Dim c As New client
        dt = c.SELECT_ALL

        lv.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim li As New ListViewItem
                    li.Text = x
                    li.SubItems.Add(r.Item("lname") & ", " & r.Item("fname") & " " & r.Item("mname"))
                    li.SubItems.Add(r.Item("address"))
                    li.SubItems.Add(r.Item("areaid"))
                    li.SubItems.Add(r.Item("contactno"))
                    li.Tag = r.Item("id")
                    lv.Items.Add(li)
                    x += 1
                Next
            End If
        Else

        End If

    End Sub

    Private Sub clients_uc_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If lv.SelectedItems.Count > 0 Then

            Dim clientid As Integer = lv.SelectedItems(0).Tag
            Dim a, b As New client
            b.id = clientid
            a = b.SELECT_BY_ID()

            Dim edit_uc As New edit_client_uc
            edit_uc.Dock = DockStyle.Fill
            edit_uc.edit_object = a

            pnlops.Controls.Clear()
            pnlops.Height = edit_uc.Height

            pnlops.Controls.Add(edit_uc)


        End If
    End Sub

   
    Private Sub txtSearchBox_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchBox.KeyUp

        Dim n As String = txtSearchBox.Text
        LoadClientsBySearching(n)

    End Sub

    Private Sub ViewProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProfileToolStripMenuItem.Click
        If lv.SelectedItems.Count > 0 Then

            Dim clientid As Integer = lv.SelectedItems(0).Tag
            Dim a, b As New client
            b.id = clientid
            a = b.SELECT_BY_ID()

            Dim cp As New client_profile_uc
            cp.Dock = DockStyle.Fill
            cp.c = a

            pnlops.Controls.Clear()
            pnlops.Height = cp.Height

            pnlops.Controls.Add(cp)


        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If lv.SelectedItems.Count > 0 Then

            Dim clientid As Integer = lv.SelectedItems(0).Tag
            Dim a, b As New client
            b.id = clientid
            a = b.SELECT_BY_ID()

            If MsgBox("Deleting this client will cause damage to future queries. If you know the risk, click yes to confirm delete.", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                If a.delete Then
                    MsgBox("Success", MsgBoxStyle.Information, "Delete")
                Else
                    MsgBox("Failed: " & err_global.Message, MsgBoxStyle.Information, "Delete")
                End If
            End If

            pnlops.Controls.Clear()
            LoadClients()

        End If
    End Sub

    Private Sub lv_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lv.MouseDoubleClick
        If lv.SelectedItems.Count > 0 Then

            Dim clientid As Integer = lv.SelectedItems(0).Tag
            Dim a, b As New client
            b.id = clientid
            a = b.SELECT_BY_ID()

            Dim cp As New client_profile_uc
            cp.Dock = DockStyle.Fill
            cp.c = a

            pnlops.Controls.Clear()
            pnlops.Height = cp.Height

            pnlops.Controls.Add(cp)

        End If
    End Sub

    Sub ApplyRestrictions()

        If CURRENT_RESTRICTION.CAN_SEARCH_CLIENT Then
            pnlSearch.Visible = True
        Else
            pnlSearch.Visible = False
        End If

        If CURRENT_RESTRICTION.CAN_EDIT_CLIENT Then
            EditToolStripMenuItem.Enabled = True
        Else
            EditToolStripMenuItem.Enabled = False
        End If

        If CURRENT_RESTRICTION.CAN_DELETE_CLIENT Then
            DeleteToolStripMenuItem.Enabled = True
        Else
            DeleteToolStripMenuItem.Enabled = False
        End If

        If CURRENT_RESTRICTION.CAN_ADD_CLIENT Then
            btnNew.Visible = True
        Else
            btnNew.Visible = False
        End If


        If CURRENT_RESTRICTION.CAN_VIEW_CLIENT_PROFILE Then
            ViewProfileToolStripMenuItem.Enabled = True
        Else
            ViewProfileToolStripMenuItem.Enabled = False
        End If

        If CURRENT_RESTRICTION.CAN_VIEW_CLIENT Then
            lv.Visible = True
        Else
            lv.Visible = False
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadClients()
        ApplyRestrictions()
        Timer1.Enabled = False
    End Sub
End Class
