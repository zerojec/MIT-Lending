Imports MySql.Data.MySqlClient

Public Class logger

    Public Property datetime As DateTime
    Public Property action As String
    Public Property program_part As String
    Public Property data As String

    Public Function WriteLog() As Boolean

        Dim sql As String = "LOG_INSERT"
        Dim cmd As New MySqlCommand
        SetCommandProperties(cmd, sql)
        cmd.Parameters.AddWithValue("_datetime_", datetime)
        cmd.Parameters.AddWithValue("_action_", action)
        cmd.Parameters.AddWithValue("_program_part", program_part)
        cmd.Parameters.AddWithValue("_data_", data)
       
        If ExecuteCommand(cmd) Then
            WriteLog = True
        Else
            MessageBox.Show(err_global.Message)
            WriteLog = False
        End If

    End Function


End Class
