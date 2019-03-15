Imports System.Configuration
Module code
    Public strCon As String = ConfigurationManager.ConnectionStrings("MiniProjectVB.My.MySettings.myData").ConnectionString
    Public strSql As String
    Public empid, empname, emplastname, depname As String
    Public cusidfind, proidfind As String
End Module
