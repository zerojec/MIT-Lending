Public Class edit_emp_uc

    Public edit_emp As New emp
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Parent.Height = 0
        Me.Dispose()
    End Sub

    Private Sub edit_emp_uc_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtcontactno.Text = edit_emp.contactno
        txtfname.Text = edit_emp.fname
        txtid.Text = edit_emp.id
        txtlname.Text = edit_emp.lname

        LoadAreas()

        cboposition.Text = edit_emp.position
        cboarea.Text = edit_emp.areaid

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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim ne As New emp

        ne.id = txtid.Text
        ne.fname = txtfname.Text
        ne.lname = txtlname.Text
        ne.contactno = txtcontactno.Text
        ne.position = cboposition.Text
        ne.areaid = cboarea.Text

        If ne.update Then
            MsgBox("Success", MsgBoxStyle.Information, "Update")
        Else
            MsgBox("Failed :" & err_global.Message, MsgBoxStyle.Information, "Update")
        End If

        frmMain.btnEmployees.PerformClick()
    End Sub

    Private Sub cboposition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboposition.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboarea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboarea.KeyPress
        e.Handled = True
    End Sub
End Class
