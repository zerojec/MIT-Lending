Imports MySql.Data.MySqlClient

Public Class user

    Public Property uname As String
    Public Property fname As String
    Public Property lname As String
    Public Property pword As String

    
    Public Function save() As Boolean

        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "USER_INSERT")

        cmd.Parameters.AddWithValue("_uname", uname)
        cmd.Parameters.AddWithValue("_fname", fname)
        cmd.Parameters.AddWithValue("_lname", lname)
        cmd.Parameters.AddWithValue("_pword", pword)
        If ExecuteCommand(cmd) Then
            Dim evnt As String = "NEW USER-" & uname & "-" & lname                     
            save = True
        Else
            save = False
        End If
    End Function

    Public Function update() As Boolean
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "USER_UPDATE")
        cmd.Parameters.AddWithValue("_uname", uname)
        cmd.Parameters.AddWithValue("_fname", fname)
        cmd.Parameters.AddWithValue("_lname", lname)
        If ExecuteCommand(cmd) Then
            Dim evnt As String = "UPDATE USER-" & uname & "-" & lname
            update = True
        Else
            update = False
        End If
    End Function

    Public Function ChangePass(ByVal newpass As String) As Boolean
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, "CHANGE_PASSWORD")
        cmd.Parameters.AddWithValue("_uname", uname)
        cmd.Parameters.AddWithValue("_newpass", newpass)
        If ExecuteCommand(cmd) Then
            ChangePass = True
        Else
            ChangePass = False
        End If
    End Function

End Class
