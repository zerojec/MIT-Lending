Public Class frmMain

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click

        Dim a As New emp_uc
        a.Dock = DockStyle.Fill
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        IntitializeMainForm()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitiateKeyCodes()
        InitiateCutOffs()
        IntitializeMainForm()
    End Sub

    Sub IntitializeMainForm()
        If con.State = ConnectionState.Open Then
            Me.Text = My.Settings.COMPANY_NAME & "-Powered by: Maharlika-IT"
            pnlstatus.BackColor = Color.GreenYellow

            'If CURRENT_RESTRICTION.CAN_ACCESS_PAYMENT Then
            '    btnPayments.PerformClick()
            'End If

            lblCurrentUser.Text = CURRENT_USER.lname & ", " & CURRENT_USER.fname
            lblposition.Text = CURRENT_USER.position

            If CURRENT_USER.position = "Super User" Then
                lblCurrentUser.BackColor = Color.Black
                lblCurrentUser.ForeColor = Color.White
            ElseIf CURRENT_USER.position = "Admin" Then
                lblCurrentUser.BackColor = Color.Blue
                lblCurrentUser.ForeColor = Color.White
            Else
                lblCurrentUser.BackColor = Color.Green
                lblCurrentUser.ForeColor = Color.White
            End If
        Else
            Me.Text = My.Settings.COMPANY_NAME & "-not connected"
            Dim lbl As New Label
            lbl.Font = New Font("Verdana", 12, FontStyle.Regular)
            lbl.ForeColor = Color.Red
            lbl.Text = err_global.Message
            lbl.AutoSize = True
            pnlops.Controls.Add(lbl)
            pnlstatus.BackColor = Color.Red
        End If

        ApplyRestrictions()
    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        Dim a As New clients_uc
        a.Dock = DockStyle.Fill
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        Dim a As New payments_uc
        a.Dock = DockStyle.Fill
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub

    Private Sub btnLoans_Click(sender As Object, e As EventArgs) Handles btnLoans.Click
        Dim a As New loans_uc
        a.Dock = DockStyle.Fill
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub


    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim a As New reports_uc
        a.Dock = DockStyle.Fill
        pnlops.Controls.Clear()
        pnlops.Controls.Add(a)
    End Sub


    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim frm As New frmChangePassword
        frm.ShowDialog()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim frm As New frmSettings
        frm.ShowDialog()
    End Sub

    Private Sub RestrictiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestrictiosToolStripMenuItem.Click

        Dim uc As New restriction_uc
        uc.Dock = DockStyle.Fill
        Me.pnlops.Controls.Clear()
        Me.pnlops.Controls.Add(uc)

    End Sub


    Sub ApplyRestrictions()

        If Not CURRENT_RESTRICTION.CAN_ACCESS_EMP Then
            btnEmployees.Visible = False
        Else
            btnEmployees.Visible = True
        End If

        If Not CURRENT_RESTRICTION.CAN_ACCESS_LOAN Then
            btnLoans.Visible = False
        Else
            btnLoans.Visible = True
        End If

        If Not CURRENT_RESTRICTION.CAN_ACCESS_PAYMENT Then
            btnPayments.Visible = False
        Else
            btnPayments.Visible = True
        End If

        If Not CURRENT_RESTRICTION.CAN_ACCESS_CLIENT Then
            btnClients.Visible = False
        Else
            btnClients.Visible = True
        End If

        If Not CURRENT_RESTRICTION.CAN_ACCESS_REPORT Then
            btnReports.Visible = False
        Else
            btnReports.Visible = True
        End If

        If Not CURRENT_RESTRICTION.CAN_ACCESS_SETTINGS Then
            SettingsToolStripMenuItem.Enabled = False
        Else
            SettingsToolStripMenuItem.Enabled = True
        End If

        If Not CURRENT_RESTRICTION.CAN_ACCESS_RESTRICTION Then
            RestrictiosToolStripMenuItem.Enabled = False
        Else
            RestrictiosToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub LockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockToolStripMenuItem.Click

        Me.pnlops.Controls.Clear()
        Me.Enabled = False
        frmLock.ShowDialog()

    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.L AndAlso e.Modifiers = Keys.Control) Then
            MsgBox("CTRL + L Pressed !")
        End If

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        Me.pnlops.Controls.Clear()

        CURRENT_USER = Nothing
        CURRENT_RESTRICTION = Nothing

        Me.Enabled = False

        frmLogin.Show()
        frmLogin.ResetInputs()

        Me.Hide()
    End Sub

End Class
