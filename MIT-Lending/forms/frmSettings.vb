Public Class frmSettings

   
    Private Sub btnAreaSettings_Click(sender As Object, e As EventArgs) Handles btnAreaSettings.Click
        Dim a As New frmAreas
        a.SetDesktopLocation(MousePosition.X - a.Width, MousePosition.Y)
        a.ShowDialog()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcompanyname.Text = My.Settings.COMPANY_NAME
        txtowner.Text = My.Settings.SIGNATORY
        chkFormatting.Checked = My.Settings.APPLY_PAYMENT_FORMATTING
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtcompanyname.Text = "" Or txtowner.Text = "" Then Exit Sub

        My.Settings.COMPANY_NAME = txtcompanyname.Text
        My.Settings.SIGNATORY = txtowner.Text

        txtcompanyname.BackColor = Color.GreenYellow
        txtowner.BackColor = Color.GreenYellow

    End Sub

    Private Sub chkFormatting_CheckedChanged(sender As Object, e As EventArgs) Handles chkFormatting.CheckedChanged
        If chkFormatting.Checked Then
            My.Settings.APPLY_PAYMENT_FORMATTING = True
        Else
            My.Settings.APPLY_PAYMENT_FORMATTING = False
        End If
    End Sub

    Private Sub btnRestriction_Click(sender As Object, e As EventArgs)
        Dim rest As New restriction_uc
        frmMain.pnlops.Controls.Clear()
        rest.Dock = DockStyle.Fill
        frmMain.pnlops.Controls.Add(rest)

        Me.Dispose()
    End Sub
End Class