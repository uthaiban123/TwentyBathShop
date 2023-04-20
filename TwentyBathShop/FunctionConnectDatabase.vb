Imports System.Data.SqlClient
Module FunctionConnectDatabase

    Public STRCON As String = "Data Source=.\sqlexpress;Initial Catalog=TwentyBath;Integrated Security=True"
    Function executesql(sql As String) As DataTable
        Try
            Dim dtAdapter As SqlDataAdapter
            Dim objConn As New SqlConnection
            Dim dt As New DataTable

            objConn.ConnectionString = STRCON
            objConn.Open()
            dtAdapter = New SqlDataAdapter(sql, objConn)
            dtAdapter.Fill(dt)
            objConn.Close()
            objConn = Nothing

            Return dt
        Catch ex As Exception

        End Try
    End Function

    Public Function Getdatestart(datetime As DateTime)
        Dim strMonthDaye As String
        Dim strYeare As String
        Dim styMonthDayYeare As String
        Dim time As String
        time = Format(datetime, "H:mm:ss")
        strYeare = Format(datetime, "yyyy") - 543
        strMonthDaye = Format(datetime, "MM-dd")
        styMonthDayYeare = strYeare & "-" & strMonthDaye
        Return styMonthDayYeare
    End Function
    Public Function Getdateend(datetime As DateTime)
        Dim strMonthDaye As String
        Dim strYeare As String
        Dim styMonthDayYeare As String
        Dim time As String
        time = Format(datetime, "H:mm:ss")
        strYeare = Format(datetime, "yyyy") - 543
        strMonthDaye = Format(datetime, "MM-dd")
        styMonthDayYeare = strYeare & "-" & strMonthDaye
        Return styMonthDayYeare & " 23:59:59"
    End Function

End Module
