Public Class frmAdminPass

    Public Property access As String = "Denied"
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim pass As String = txtpassword.Text

        If pass <> "" Then
            If pass = My.Settings.APP_PASSWORD Then
                Me.access = "Granted"
                Me.Dispose()
            Else
                Me.Dispose()
            End If
        Else
            Me.Dispose()
        End If
    End Sub

    Public Function TryAccess() As Boolean
        Me.StartPosition = FormStartPosition.Manual
        Me.SetDesktopLocation(MousePosition.X, MousePosition.Y)
        Me.ShowDialog()
        If access = "Denied" Then
            TryAccess = False
        Else
            TryAccess = True
        End If
    End Function

   
    Private Sub frmAdminPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class