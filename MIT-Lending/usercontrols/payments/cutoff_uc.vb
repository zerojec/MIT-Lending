Public Class cutoff_uc
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.Width = Me.Parent.Width - 30
        Catch ex As Exception

        End Try
    End Sub
End Class
