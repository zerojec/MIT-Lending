Imports System.Reflection

Public Class restriction_uc


    Dim r As New restriction
    Sub LoadEmployees()
        Dim dt As New DataTable
        Dim e As New emp
        dt = e.SELECT_ALL

        cboUser.Items.Clear()
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then

                For Each r As DataRow In dt.Rows
                    Dim str As String = r.Item("fname") & " " & r.Item("lname") & "-" & r.Item("id")
                    cboUser.Items.Add(str)
                Next
                cboUser.Text = cboUser.Items(0).ToString
            Else
                cboUser.Items.Add("Nothing Found...")
            End If
        Else
            cboUser.Items.Add("Nothing Found...")
        End If



    End Sub

    Private Sub restriction_uc_Load(sender As Object, e As EventArgs) Handles Me.Load

        If CURRENT_RESTRICTION.CAN_VIEW_RESTRICTION And CURRENT_USER.position = "Super User" Then
            LoadEmployees()
            Dim empid As Integer = Split(cboUser.Text, "-")(1)
            LoadCheckBoxes(empid)
        Else

            cboUser.Text = CURRENT_USER.lname & ", " & CURRENT_USER.fname & "-" & CURRENT_USER.id
            Dim empid As Integer = Split(cboUser.Text, "-")(1)

            txtcontactno.Text = CURRENT_USER.contactno
            txtfname.Text = CURRENT_USER.fname
            txtid.Text = CURRENT_USER.id
            txtlname.Text = CURRENT_USER.lname

            cboposition.Text = CURRENT_USER.position
            cboarea.Text = CURRENT_USER.areaid

            If CURRENT_RESTRICTION.CAN_VIEW_RESTRICTION Then
                LoadCheckBoxes(empid)
            Else
                Dim lbl As New Label
                lbl.Font = New Font("Verdana", 12, FontStyle.Bold)
                lbl.ForeColor = Color.Red
                lbl.Dock = DockStyle.Fill
                lbl.TextAlign = ContentAlignment.MiddleCenter
                lbl.Text = "You are not allowed to VIEW_RESTRICTION. Contact Admin to elevate previlege."
                pnlRestrictions.Controls.Add(lbl)
            End If
        End If

    End Sub

    Private Sub cboUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUser.SelectedIndexChanged

        If cboUser.Text = "" Then Exit Sub

        Dim empid As Integer = Split(cboUser.Text, "-")(1)
        Dim ep, emp As New emp
        ep.id = empid
        emp = ep.SELECT_BY_ID

        txtcontactno.Text = emp.contactno
        txtfname.Text = emp.fname
        txtid.Text = emp.id
        txtlname.Text = emp.lname

        cboposition.Text = emp.position
        cboarea.Text = emp.areaid

        LoadCheckBoxes(empid)

    End Sub

    Private Sub txtfname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfname.KeyPress, txtcontactno.KeyPress, txtid.KeyPress, txtlname.KeyPress, cboarea.KeyPress, cboposition.KeyPress
        e.Handled = True
    End Sub

    Sub LoadCheckBoxes(ByVal id As Integer)

        If cboUser.Text = "" Then Exit Sub
        
        Dim rest As New restriction
        rest.ID = id

        r = rest.SELECT_BY_ID

        Dim infolist() As PropertyInfo = r.GetType().GetProperties()
        Dim info = infolist.ToList.OrderBy(Function(a) a.Name)
        Dim chk(info.Count - 1) As CheckBox

        info.OrderBy(Function(a) a.Name)

        pnlRestrictions.Controls.Clear()

        For x As Integer = 0 To info.Count - 1

            If info(x).Name.ToString <> "ID" Then
                chk(x) = New CheckBox
                chk(x).Text = info(x).Name.ToString
                chk(x).Dock = DockStyle.Top

                If Not CURRENT_RESTRICTION.CAN_EDIT_RESTRICTION Or cboposition.Text = "Super User" Then
                    chk(x).Enabled = False
                End If
                Dim val As Boolean = CBool(info(x).GetValue(r, Nothing))

                'chk(x).Text &= val.ToString
                If val = True Then
                    chk(x).Checked = True
                Else
                    chk(x).Checked = False
                End If

                chk(x).Left = 100

                AddHandler chk(x).CheckedChanged, AddressOf onCheckedChanged
                pnlRestrictions.Controls.Add(chk(x))
            End If

        Next

    End Sub

    Private Sub onCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim chk As CheckBox = DirectCast(sender, CheckBox)
        Dim rest As String = chk.Text

        If r.TOGGLE(rest) Then
            'MsgBox(rest & " Toggled", MsgBoxStyle.Information, "Toggle")
        Else
            MsgBox("Error Toggling :" & rest & ": " & err_global.Message, MsgBoxStyle.Exclamation, "Toggle")
            If chk.Checked Then
                chk.Checked = False
            Else
                chk.Checked = True
            End If
        End If

    End Sub
End Class
