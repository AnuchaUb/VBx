Imports System.Configuration
Module code
    Public strCon As String = ConfigurationManager.ConnectionStrings("MiniProjectVB.My.MySettings.myData").ConnectionString
    Public strSql As String

End Module
