Imports MySql.Data.MySqlClient
Public Class edit_client_uc


    Public edit_object As New client
    Private Sub edit_client_uc_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtaddress.Text = edit_object.address
        txtcontactno.Text = edit_object.contactno
        txtfname.Text = edit_object.fname
        txtlname.Text = edit_object.lname
        txtid.Text = edit_object.id
        txtmname.Text = edit_object.mname
        LoadAreas()
        cboarea.Text = edit_object.areaid
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtfname.Text = "" Or txtlname.Text = "" Or txtcontactno.Text = "" Or txtaddress.Text = "" Or txtmname.Text = "" Then Exit Sub

        Dim nc As New client
        nc.id = txtid.Text
        nc.fname = Trim(txtfname.Text)
        nc.lname = Trim(txtlname.Text)
        nc.mname = Trim(txtmname.Text)
        nc.address = txtaddress.Text
        nc.contactno = txtcontactno.Text
        nc.areaid = cboarea.Text

        If nc.update Then
            MsgBox("Success", MsgBoxStyle.Information, "Updating Client")
        Else
            MsgBox("Failed : " & err_global.Message, MsgBoxStyle.Exclamation, "Updating Client")
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
