Public Class frmPassword

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim pass As String = txtpassword.Text

        If pass <> "" Then

            If pass = My.Settings.APP_PASSWORD Then

                Dim frm As New frmSettings
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()

            Else
                Me.Dispose()
            End If
        Else
            Me.Dispose()
        End If

    End Sub
End Class