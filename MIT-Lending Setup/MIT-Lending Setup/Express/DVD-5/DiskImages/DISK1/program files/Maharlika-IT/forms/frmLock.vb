Public Class frmLock

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
     
    End Sub

    Private Sub txtpassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyUp
        If e.KeyValue = 13 Then

            If CURRENT_USER.pword = GenerateHash(txtpassword.Text) Then
                frmMain.Show()
                frmMain.Enabled = True

                txtpassword.Text = ""
                Me.Hide()
            End If
        End If
    End Sub
End Class