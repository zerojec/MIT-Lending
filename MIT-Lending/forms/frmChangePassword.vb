Imports MySql.Data.MySqlClient
Public Class frmChangePassword

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtoldpass.Text = "" Or txtoldpass.Text = "" Or txtretyped.Text = "" Then Exit Sub

        Dim oldpass As String = GenerateHash(txtoldpass.Text)

        If oldpass = CURRENT_USER.pword Then
            If txtnewpass.Text = txtretyped.Text Then

                If CURRENT_USER.CHANGE_PASSWORD(txtnewpass.Text) Then
                    MsgBox("Successful.", MsgBoxStyle.Information, "Changing Password")
                    Me.Dispose()
                Else
                    MsgBox("Failed : " & err_global.Message, MsgBoxStyle.Information, "Changing Password")
                    resetInputs()
                End If
            Else
                'PASSWORD DID NOT MATCHED
                'MsgBox("Failed : " & err_global.Message, MsgBoxStyle.Information, "Changing Password")
                Me.BackColor = Color.Red
                resetInputs()
            End If
        Else
            'OLD PASSWORD INCORRECT
            Me.BackColor = Color.Red
            resetInputs()
        End If

    End Sub

    Private Sub txtoldpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtoldpass.KeyPress, txtnewpass.KeyPress, txtretyped.KeyPress
        Me.BackColor = TableLayoutPanel1.BackColor
    End Sub

    Sub resetInputs()
        txtnewpass.Text = ""
        txtoldpass.Text = ""
        txtretyped.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class