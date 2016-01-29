Public Class emp_ca

    Public ca_emp As emp


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Parent.Height = 0
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ca As New cash_advance
        ca.empid = txtid.Text
        ca.amount = CDec(txtamount.Text)
        ca.date_ = dtdate_.Value

        If ca.save() Then
            MsgBox("Success", MsgBoxStyle.Information, "Saving New Cash Advance")
            Me.Parent.Height = 0
            Me.Dispose()
        Else
            MsgBox("Failed:" & err_global.Message, MsgBoxStyle.Information, "Saving New Cash Advance")
            Me.Parent.Height = 0
            Me.Dispose()
        End If

    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        Dim n As Integer = AscW(e.KeyChar)
        If ThisKeyCodeIsHere(n) Then
            If n = 46 Then
                If txtamount.Text.Contains(".") Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub emp_ca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtid.Text = ca_emp.id
        txtlname.Text = ca_emp.lname
        txtfname.Text = ca_emp.fname

        txtid.Enabled = False
        txtfname.Enabled = False
        txtlname.Enabled = False

    End Sub
End Class
