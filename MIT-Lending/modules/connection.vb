Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Module connection

    Public con As New MySqlConnection
    Public err_global As New Exception

    Public CURRENT_USER As New emp
    Public CURRENT_RESTRICTION As New restriction

    Public COLOR_ABOVE_AVE As Color = Color.Blue
    Public COLOR_AVE As Color = Color.GreenYellow
    Public COLOR_BELOW_AVE As Color = Color.Orange
    Public COLOR_BELOW_TWENTY_PERNCET As Color = Color.Red

    Public this_date_time As New DateTime

    Public kd As New List(Of Integer)

    Public cuttoff_date As New List(Of String)

    '====================================================================
    'OPENING DATABASE CONNECTION
    '====================================================================
    Public Function open_connection() As Boolean
        Dim constr As String
        constr = My.Settings.CONSTR
        con = New MySqlConnection(constr)
        Try
            con.Open()
            open_connection = True
        Catch ex As Exception
            clear_exception()
            err_global = ex
            open_connection = False
        End Try
    End Function



    '====================================================================
    'FUNCTION TO LOAD DATATABLE FROM STOREDPROCEDURE
    '====================================================================
    Public Function LOADDT_STRPRO(ByRef cmd As MySqlCommand) As DataTable
        Dim dt As New DataTable
        Dim da As MySqlDataAdapter

        Try
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            LOADDT_STRPRO = dt
        Catch ex As Exception
            clear_exception()
            err_global = ex
            LOADDT_STRPRO = Nothing
        End Try
    End Function


    '====================================================================
    'FUNCTION TO LOAD DATATABLE FROM SQL
    '====================================================================
    Public Function LODADT(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(sql, con)
        Try
            da.Fill(dt)
            If dt IsNot Nothing Then
                LODADT = dt
            Else
                LODADT = Nothing
            End If
        Catch ex As Exception
            clear_exception()
            err_global = ex
            LODADT = Nothing
        End Try
    End Function


    '====================================================================
    'FUNCTION TO EXECUTE COMMAND
    '====================================================================
    Public Function ExecuteCommand(ByRef cmd As MySqlCommand) As Boolean
        Try
            cmd.ExecuteNonQuery()
            ExecuteCommand = True
        Catch ex As Exception
            clear_exception()
            err_global = ex
            ExecuteCommand = False
        End Try
    End Function


    '====================================================================
    'SETTING COMMAND PROPERTIES
    '====================================================================
    Public Sub SetCommandProperties(ByRef cmd As MySqlCommand, ByVal sql As String)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = sql
        cmd.Connection = con
    End Sub



    '====================================================================
    'CLEARING GLOBAL ERROR STRING HANDLER
    '====================================================================
    Public Sub clear_exception()
        err_global = Nothing
    End Sub

    Public Function GetLastDayOfMonth(ByVal intMonth As Integer, ByVal intYear As Integer) As Date
        GetLastDayOfMonth = DateSerial(intYear, intMonth + 1, 0)
    End Function


    Function IsLastDay(ByVal myDate As Date) As Boolean
        Return myDate.Day = Date.DaysInMonth(myDate.Year, myDate.Month)
    End Function



    '=====================================================================
    'ALLOW ONLY NUMBERS ON KEYPRESS
    '=====================================================================
    Sub InitiateKeyCodes()
        kd.Add(48) '0
        kd.Add(49) '1
        kd.Add(50) '2
        kd.Add(51) '3
        kd.Add(52) '4
        kd.Add(53) '5
        kd.Add(54) '6
        kd.Add(55) '7
        kd.Add(56) '8
        kd.Add(57) '9:
        kd.Add(46)
        kd.Add(190)
        kd.Add(8)
    End Sub

    Sub InitiateCutOffs()
        cuttoff_date.Add("1-7")
        cuttoff_date.Add("8-15")
        cuttoff_date.Add("16-23")
    End Sub
    'find keycodes is kd
    Public Function ThisKeyCodeIsHere(ByVal k As Integer) As Boolean
        ThisKeyCodeIsHere = False
        For x As Integer = 0 To kd.Count - 1
            If k = kd.Item(x) Then
                ThisKeyCodeIsHere = True
                Exit For
            End If
        Next
    End Function


    Public payment_dt As New DataTable



    Public Function GenerateHash(ByVal SourceText As String) As String
        'Create an encoding object to ensure the encoding standard for the source text
        Dim Ue As New UnicodeEncoding()
        'Retrieve a byte array based on the source text
        Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
        'Instantiate an MD5 Provider object
        Dim Md5 As New MD5CryptoServiceProvider()
        'Compute the hash value from the source
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'And convert it to String format for return
        Return Convert.ToBase64String(ByteHash)
    End Function



    Public Function GET_DUE_FROM_LAST_WEEK(ByVal start_date As Date, ByVal end_date As Date, ByVal daily As Decimal, ByVal end_of_100days_date As Date) As Decimal
        Dim d As Decimal = 0
        If end_date < end_of_100days_date Then
            Dim num_of_days = end_date.Subtract(start_date).TotalDays
            d = daily * (num_of_days + 1)
            Return d
        Else
            Dim num_of_days = end_of_100days_date.Subtract(start_date).TotalDays
            d = daily * (num_of_days + 1)
            Return d
        End If

    End Function


    Public Function CalculateDue(ByVal start_date As Date, ByVal cutoff As Date, ByVal daily As Decimal) As Decimal
        Dim nofdays As Integer = DateDiff(DateInterval.Day, start_date, cutoff)
        Dim amount As Decimal = CDec(nofdays + 1) * daily
        Return amount
    End Function

End Module
