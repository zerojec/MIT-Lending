Public Class frmNewCashAdvance

    Public ca As New cash_advance

    Private Sub frmNewCashAdvance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtamount.Text = "" Then Exit Sub
        ca.amount = CDec(txtamount.Text)

        If ca.save() Then
            MsgBox("Success", MsgBoxStyle.Information, "Saving Cash Advance")            
            Me.Dispose()
        Else
            MsgBox("Failed", MsgBoxStyle.Information, "Saving Cash Advance")
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
End Class