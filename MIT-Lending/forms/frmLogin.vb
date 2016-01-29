Imports MySql.Data.MySqlClient
Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If open_connection() Then
            LoadEmployees()
            btnLogin.Enabled = True
            txtpassword.Enabled = True
        Else
            btnLogin.Enabled = False
            txtpassword.Enabled = False
        End If

        'cboUser.Text = GenerateHash("mitpass")
    End Sub


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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If cboUser.Text = "" Then Exit Sub

        Dim curr_emp, emp As New emp

        emp.id = Split(cboUser.Text, "-")(1)

        'MsgBox(emp.id)
        curr_emp = emp.SELECT_BY_ID


        If curr_emp IsNot Nothing Then


            'CURRENT_USER = curr_emp

            'Dim curr_rest As New restriction
            'curr_rest.ID = CURRENT_USER.id
            'CURRENT_RESTRICTION = curr_rest.SELECT_BY_ID

            'frmMain.Show()
            'frmMain.Enabled = True

            'ResetInputs()
            'Me.Hide()


            If curr_emp.pword = GenerateHash(txtpassword.Text) Then

                CURRENT_USER = curr_emp

                Dim curr_rest As New restriction
                curr_rest.ID = CURRENT_USER.id
                CURRENT_RESTRICTION = curr_rest.SELECT_BY_ID

                frmMain.Show()
                frmMain.Enabled = True

                ResetInputs()
                Me.Hide()


            Else
                ResetInputs()
                Me.BackColor = Color.Red
            End If
        Else
            ResetInputs()
            Me.BackColor = Color.Red
        End If

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        Me.BackColor = TableLayoutPanel1.BackColor
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Sub ResetInputs()
        txtpassword.Text = ""
        cboUser.Text = ""
    End Sub

    Private Sub txtpassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyUp

        If e.KeyValue = 13 Then
            btnLogin.PerformClick()
        End If

    End Sub
End Class