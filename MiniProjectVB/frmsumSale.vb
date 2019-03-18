Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmsumSale
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New dsPrintSale

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader
    Dim myRPT As New crpReportSale
    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub salereport()
        connData()
        strSql = "select * from tbsale s,tbsaledetail sd,tbproducts p,tbtypeofproduct tp,tbcompany cp,tbcustomers c,tbemployee e,tbshop sp where s.saleid = sd.saleid " & vbCrLf &
            "and s.empid = e.empid and s.cusid = c.cusid and sd.proid = p.proid and p.typeproductid = tp.typeproductid and p.companyid = cp.companyid"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "Datatablex")

        myRPT.SetDataSource(myDS.Tables("Datatablex"))
        crvReportsale.ReportSource = myRPT
        crvReportsale.Show()
        myCon.Close()
    End Sub
    Private Sub frmsumSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        salereport()
    End Sub
End Class