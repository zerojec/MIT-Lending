Imports MySql.Data.MySqlClient

Public Class new_client_uc

    Function GET_CLIENT_ID() As Integer
        Dim dt As New DataTable
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "GET_CLIENT_ID")

        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt)

        GET_CLIENT_ID = 0
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                GET_CLIENT_ID = dt.Rows(0).Item(0)
            Else
                GET_CLIENT_ID = 0
            End If
        Else
            GET_CLIENT_ID = 0
        End If
    End Function

    Private Sub new_client_uc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = GET_CLIENT_ID()
        LoadAreas()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtfname.Text = "" Or txtlname.Text = "" Or txtcontactno.Text = "" Or txtaddress.Text = "" Or txtmname.Text = "" Then Exit Sub

        Dim nc As New client
        nc.fname = Trim(txtfname.Text)
        nc.lname = Trim(txtlname.Text)
        nc.mname = Trim(txtmname.Text)
        nc.address = txtaddress.Text
        nc.contactno = txtcontactno.Text
        nc.areaid = cboarea.Text

        If nc.save Then
            MsgBox("Success", MsgBoxStyle.Information, "Saving New Client")
        Else
            MsgBox("Failed : " & err_global.Message, MsgBoxStyle.Exclamation, "Saving New Client")
        End If
        frmMain.btnClients.PerformClick()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Parent.Height = 0
        Me.Dispose()
    End Sub

    Sub LoadAreas()
        Dim dt As New DataTable
        Dim a As New area
        dt = a.SELECT_ALL
        cboarea.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                For Each r As DataRow In dt.Rows
                    Dim ar As String = r.Item("areaid")
                    cboarea.Items.Add(ar)
                Next
            End If
        End If
    End Sub

    Private Sub cboarea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboarea.KeyPress
        e.Handled = True
    End Sub
End Class
