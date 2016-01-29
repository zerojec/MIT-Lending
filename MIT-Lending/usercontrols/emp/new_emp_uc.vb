Imports MySql.Data.MySqlClient
Public Class new_emp_uc

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Parent.Height = 0
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim ne As New emp
        ne.id = txtid.Text
        ne.fname = txtfname.Text
        ne.lname = txtlname.Text
        ne.contactno = txtcontactno.Text
        ne.position = cboposition.Text
        ne.areaid = cboarea.Text

        If ne.save Then
            MsgBox("Success", MsgBoxStyle.Information, "Save")
        Else
            MsgBox("Failed :" & err_global.Message, MsgBoxStyle.Information, "Save")
        End If

        frmMain.btnEmployees.PerformClick()
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

    Private Sub new_emp_uc_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadAreas()
        txtid.Text = GET_EMP_ID()
    End Sub



    Function GET_EMP_ID() As Integer
        Dim dt As New DataTable
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "GET_EMP_ID")

        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt)

        GET_EMP_ID = 0
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                GET_EMP_ID = dt.Rows(0).Item(0)
            Else
                GET_EMP_ID = 0
            End If
        Else
            GET_EMP_ID = 0
        End If
    End Function

    Private Sub cboposition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboposition.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboarea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboarea.KeyPress
        e.Handled = True
    End Sub
End Class
