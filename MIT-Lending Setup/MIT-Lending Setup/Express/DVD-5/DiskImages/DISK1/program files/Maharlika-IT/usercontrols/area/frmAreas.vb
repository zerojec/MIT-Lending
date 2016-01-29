Imports MySql.Data.MySqlClient
Public Class frmAreas

    Public edit_id As String = ""
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If txtarea_name.Text = "" Then Exit Sub
        If btnSave.Text = "&Save" Then

            Dim a As New area
            a.areaid = txtarea_name.Text
            If a.save Then
                MsgBox("Success", MsgBoxStyle.Information, "Saving Area")
                LoadAreas()
                txtarea_name.Text = ""
            Else
                MsgBox("Failed: " & err_global.Message, MsgBoxStyle.Information, "Saving Area")
            End If
        Else
            Dim old As New area
            old.areaid = edit_id

            Dim new_area As New area
            new_area.areaid = txtarea_name.Text

            If old.delete Then
                If new_area.save Then
                    MsgBox("Success", MsgBoxStyle.Information, "Updating Area")
                    LoadAreas()
                    txtarea_name.Text = ""
                Else
                    MsgBox("Failed: " & err_global.Message, MsgBoxStyle.Information, "Updating Area")
                End If
            Else
                MsgBox("Failed: " & err_global.Message, MsgBoxStyle.Information, "Updating Area")
            End If
            btnSave.Text = "&Save"
            edit_id = 0
            lv.Enabled = True
        End If





    End Sub

    Private Sub frmAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAreas()
    End Sub


    Sub LoadAreas()
        Dim dt As New DataTable
        Dim a As New area
        dt = a.SELECT_ALL
        lv.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim x As Integer = 1
                For Each r As DataRow In dt.Rows
                    Dim li As New ListViewItem
                    li.Text = x
                    li.Tag = r.Item("areaid")
                    li.SubItems.Add(r.Item("areaid"))
                    lv.Items.Add(li)
                    x += 1
                Next
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        If lv.SelectedItems.Count > 0 Then
            Dim id_selected As Integer = CInt(lv.SelectedItems(0).Tag)
            '  MsgBox(id_selected)

            If MsgBox("Please confirm delete of AREA :" & lv.SelectedItems(0).SubItems(1).Text, MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then

                Dim a As New area
                a.areaid = id_selected

                If a.delete Then
                    MsgBox("Success", MsgBoxStyle.Information, "Delete Area")
                Else
                    MsgBox("Failed :" & err_global.Message, MsgBoxStyle.Exclamation, "Delete Area")
                End If

                LoadAreas()
            End If

        End If


    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If lv.SelectedItems.Count > 0 Then
            Dim id_selected As String = lv.SelectedItems(0).Tag
            btnSave.Text = "&Update"
            txtarea_name.Text = lv.SelectedItems(0).SubItems(1).Text
            edit_id = id_selected

            lv.Enabled = False
        End If

    End Sub
End Class